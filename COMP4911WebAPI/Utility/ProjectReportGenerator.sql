USE COMP4911WebAPI;
GO
SET ANSI_NULLS ON  
GO  
SET QUOTED_IDENTIFIER ON  
GO  

DROP PROCEDURE IF EXISTS GenerateProjectReport;
GO

CREATE OR ALTER PROCEDURE GenerateProjectReport
AS
BEGIN
DECLARE @today datetime = GETDATE(); --todays date saved in @today
--Job runs every day
--Procedure checks if it is the last day of the month and friday OR
--It is friday and within the first 7 days of the month
--IF today is a Friday and it is the last day of the month run
--OR if today is a friday and it is < the 7th of the month
--DATEPART(dw,@today) = 6 means friday
--EOMONTH(Today) returns the last day of the current month
--DATEPART(d,@today) returns the day of the month
/*IF((DATEPART(dw,@today) = 6 AND EOMONTH(@today) = @today) 
OR (DATEPART(dw,@today) = 6 AND DATEPART(d,@today) < 7))
*/
BEGIN
/*
Create new project report Records
*/
	INSERT INTO ProjectReport (ProjectId,ProjectCode,ProjectName,ReportDate,StartDate,EndDate)
	SELECT DISTINCT p.ProjectID,
		   p.ProjectCode,
		   p.ProjectName, 
		   CAST(GETDATE() AS DATE) AS "ReportDate",
		   p.StartDate,
		   p.EndDate
	FROM Projects p;
	--WHERE EndDate > GETDATE() OR EndDate IS NULL;


/*
Create new report snapshot records
*/
--CTE FOR wpBudget


WITH wpBudget AS (
SELECT wp.WorkPackageId,
	   SUM(COALESCE(wplg.reBudget,0)*COALESCE(lg.HourlyWage,0)*8) AS "wpBudget"
FROM WorkPackages wp
LEFT JOIN WorkPackageLabourGradeAssignment wplg
ON wp.WorkPackageId = wplg.WorkPackageId
LEFT JOIN LabourGrades lg
ON wplg.LabourGradeId = lg.LabourGradeId
GROUP BY wp.WorkPackageId
),
--CTE FOR wpActualSpends
wpActualSpends AS (
SELECT wp.WorkPackageId,
--SUM of SUMS
	  SUM((tr.monday+tr.tuesday+tr.Wednesday+tr.Thursday+tr.Friday+tr.Saturday+tr.Sunday)*lg.HourlyWage) AS "wpActualSpends"
FROM WorkPackages wp
LEFT JOIN  TimesheetRows tr
ON tr.WorkPackageId = wp.WorkPackageId
INNER JOIN Timesheets t
ON tr.TimesheetId = t.TimesheetId
INNER JOIN Employees e
ON t.EmployeeId = e.EmployeeId
INNER JOIN LabourGrades lg
ON e.LabourGradeId = lg.LabourGradeId
GROUP BY wp.WorkPackageId
),
--CTE FOR pmEAC
pmEAC AS (
SELECT wp.WorkPackageId,
	   SUM(COALESCE(wplg.pmEAC,0) * COALESCE(lg.HourlyWage,0)*8) AS "pmEAC"
FROM WorkPackages wp
LEFT JOIN WorkPackageLabourGradeAssignment wplg
ON wp.WorkPackageId = wplg.WorkPackageId
LEFT JOIN LabourGrades lg
ON wplg.LabourGradeId = lg.LabourGradeId
GROUP BY wp.WorkPackageId
),

--CTE FOR reEAC
--Self join - ST OVERFLOW LINK 
--https://stackoverflow.com/questions/1313120/retrieving-the-last-record-in-each-group-mysql
--https://stackoverflow.com/questions/17038193/select-row-with-most-recent-date-per-user
reEAC AS (
SELECT wp.WorkPackageId,
	   SUM(COALESCE(wprd.ReEstimateAtCompletion,0)*COALESCE(lg.HourlyWage,0)*8) AS "reEAC"
FROM WorkPackages wp
INNER JOIN WorkPackageReports wpr
ON wp.WorkPackageId = wpr.WorkPackageId
LEFT Join WorkPackageReports wpr2
ON wpr.WorkPackageReportID = wpr2.WorkPackageReportID
	AND wpr.LastUpdatedTime > wpr2.LastUpdatedTime
LEFT JOIN WorkPackageReportDetails wprd    
ON wpr.WorkPackageReportID = wprd.WorkPackageReportID
LEFT JOIN LabourGrades lg
ON wprd.LabourGradeId = lg.LabourGradeId
GROUP BY wp.WorkPackageId
)
/*
INSERT INTO WorkPackageReportSnapshot ([WorkPackageId]
      ,[ProjectReportId]
      ,[WorkPackageCode]
      ,[WorkPackageTitle]
      ,[WorkPackageResponsibleEngineerBudget]
      ,[WorkPackageActualSpends]
      ,[WorkPackageResponsibleEngineerEstimateAtCompletion]
      ,[WorkPackageProjectManagerEstimateAtCompletion]
      ,[LabourGradeWage]
      ,[IsHighWorkPackage]
      ,[WorkPackageReportSnapshotDate]
      ,[TotalWpHours]
      ,[wpReVariance]
      ,[wpPmVariance]
      ,[wpReCompletion]
      ,[wpPmCompletion]
      ,[isClosed]
      ,[engineerInitials])
*/
SELECT 
	   wp.[WorkPackageId]
      ,pr.[ProjectReportId]
      ,wp.[WorkPackageCode]
      ,wp.[Name]											AS [WorkPackageTitle]
      ,wpb.[wpBudget]										AS [WorkPackageResponsibleEngineerBudget]
      ,was.[wpActualSpends]									AS [WorkPackageActualSpends]
      ,reEac.[reEAC]										AS [WorkPackageResponsibleEngineerEstimateAtCompletion]
      ,pmEac.[pmEAC]										AS [WorkPackageProjectManagerEstimateAtCompletion]
      ,IIF(wp.ParentWorkPackageId IS NULL,1,0)				AS [IsHighWorkPackage]
      ,GETDATE()											AS [WorkPackageReportSnapshotDate]
      ,IIF(wpb.wpBudget IS NOT NULL AND wpb.wpBudget != 0,
		((reEac.[reEAC] - wpb.[wpBudget])/wpb.[wpBudget]),NULL)	AS [wpReVariance]

      ,IIF(wpb.wpBudget IS NOT NULL AND wpb.wpBudget != 0,
	  ((pmEac.[pmEAC] - wpb.[wpBudget])/wpb.[wpBudget]),NULL)	AS [wpPmVariance]

      ,IIF(reEac.[reEAC] IS NOT NULL AND reEac.[reEAC] != 0,
	   (was.[wpActualSpends]/reEac.[reEAC]),NULL)				AS [wpReCompletion]

      ,IIF(pmEac.[pmEAC] IS NOT NULL AND pmEac.[pmEAC] != 0, 
	  (was.[wpActualSpends]/pmEac.[pmEAC]),NULL)				AS [wpPmCompletion]
      ,wp.[isClosed]										AS [isClosed]

FROM WorkPackages wp 
INNER JOIN ProjectReport pr
ON pr.ProjectId = wp.ProjectId
AND CAST(pr.ReportDate AS DATE) = CAST(GETDATE() AS DATE)
LEFT JOIN wpActualSpends was
ON wp.WorkPackageId = was.WorkPackageId
LEFT JOIN wpBudget wpb
ON wp.WorkPackageId = wpb.WorkPackageId
LEFT JOIN reEAC
ON wp.WorkPackageId = reEAC.WorkPackageId
LEFT JOIN pmEAC
ON wp.WorkPackageId = pmEAC.WorkPackageId;


END
END


