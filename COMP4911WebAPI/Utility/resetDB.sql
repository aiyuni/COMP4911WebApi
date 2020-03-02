
USE COMP4911WebAPI;
GO

while(exists(select 1 from INFORMATION_SCHEMA.TABLE_CONSTRAINTS where CONSTRAINT_TYPE='FOREIGN KEY'))
begin
 declare @sql nvarchar(2000)
 SELECT TOP 1 @sql=('ALTER TABLE ' + TABLE_SCHEMA + '.[' + TABLE_NAME
 + '] DROP CONSTRAINT [' + CONSTRAINT_NAME + ']')
 FROM information_schema.table_constraints
 WHERE CONSTRAINT_TYPE = 'FOREIGN KEY'
 exec (@sql)
 PRINT @sql
end


DROP TABLE IF EXISTS dbo.Credentials
DROP TABLE IF EXISTS dbo.TimesheetRows
DROP TABLE IF EXISTS dbo.Timesheets
DROP TABLE IF EXISTS dbo.EmployeeProjectAssignments
DROP TABLE IF EXISTS dbo.LabourGrades
DROP TABLE IF EXISTS dbo.WorkPackages
DROP TABLE IF EXISTS dbo.EmployeeWorkPackageAssignments
DROP TABLE IF EXISTS dbo.JobTitles
DROP TABLE IF EXISTS dbo.Projects
DROP TABLE IF EXISTS dbo.Employees
