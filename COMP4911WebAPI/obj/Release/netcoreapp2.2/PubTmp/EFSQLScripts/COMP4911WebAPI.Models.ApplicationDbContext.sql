IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    CREATE TABLE [JobTitles] (
        [JobTitleId] int NOT NULL IDENTITY,
        [JobTitleName] nvarchar(max) NULL,
        [LastUpdatedBy] nvarchar(max) NULL,
        [LastUpdatedTime] datetime2 NOT NULL,
        CONSTRAINT [PK_JobTitles] PRIMARY KEY ([JobTitleId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    CREATE TABLE [LabourGrades] (
        [LabourGradeId] int NOT NULL IDENTITY,
        [LabourGradeCode] nvarchar(max) NULL,
        [Multiplier] float NOT NULL,
        [LastUpdatedBy] nvarchar(max) NULL,
        [LastUpdatedTime] datetime2 NOT NULL,
        CONSTRAINT [PK_LabourGrades] PRIMARY KEY ([LabourGradeId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    CREATE TABLE [Projects] (
        [ProjectId] int NOT NULL IDENTITY,
        [ProjectName] nvarchar(max) NULL,
        [ProjectDescription] nvarchar(max) NULL,
        [ProjectManagerId] int NOT NULL,
        [IsClosed] bit NOT NULL,
        [StartDate] datetime2 NOT NULL,
        [EndDate] datetime2 NOT NULL,
        [LastUpdatedBy] nvarchar(max) NULL,
        [LastUpdatedTime] datetime2 NOT NULL,
        CONSTRAINT [PK_Projects] PRIMARY KEY ([ProjectId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    CREATE TABLE [Employees] (
        [EmployeeId] int NOT NULL IDENTITY,
        [JobTitleId] int NOT NULL,
        [LabourGradeId] int NOT NULL,
        [EmployeeCode] int NOT NULL,
        [EmployeeFirstName] nvarchar(max) NULL,
        [EmployeeLastName] nvarchar(max) NULL,
        [IsActivated] bit NOT NULL,
        [TimesheetApproverId] int NULL,
        [SupervisorId] int NULL,
        [IsProjectManager] bit NOT NULL,
        [IsAdmin] bit NOT NULL,
        [IsHumanResources] bit NOT NULL,
        [LastUpdatedBy] nvarchar(max) NULL,
        [LastUpdatedTime] datetime2 NOT NULL,
        CONSTRAINT [PK_Employees] PRIMARY KEY ([EmployeeId]),
        CONSTRAINT [FK_Employees_JobTitles_JobTitleId] FOREIGN KEY ([JobTitleId]) REFERENCES [JobTitles] ([JobTitleId]) ON DELETE CASCADE,
        CONSTRAINT [FK_Employees_LabourGrades_LabourGradeId] FOREIGN KEY ([LabourGradeId]) REFERENCES [LabourGrades] ([LabourGradeId]) ON DELETE CASCADE,
        CONSTRAINT [FK_Employees_Employees_SupervisorId] FOREIGN KEY ([SupervisorId]) REFERENCES [Employees] ([EmployeeId]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Employees_Employees_TimesheetApproverId] FOREIGN KEY ([TimesheetApproverId]) REFERENCES [Employees] ([EmployeeId]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    CREATE TABLE [WorkPackages] (
        [WorkPackageId] int NOT NULL IDENTITY,
        [ProjectId] int NOT NULL,
        [ResponsibleEngineerId] int NOT NULL,
        [WorkPackageCode] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [ProposedHours] float NULL,
        [BudgetHours] float NULL,
        [IssueDate] datetime2 NOT NULL,
        [IsClosed] bit NOT NULL,
        [ParentWorkPackageId] int NULL,
        [LastUpdatedBy] nvarchar(max) NULL,
        [LastUpdatedTime] datetime2 NOT NULL,
        CONSTRAINT [PK_WorkPackages] PRIMARY KEY ([WorkPackageId]),
        CONSTRAINT [FK_WorkPackages_WorkPackages_ParentWorkPackageId] FOREIGN KEY ([ParentWorkPackageId]) REFERENCES [WorkPackages] ([WorkPackageId]) ON DELETE NO ACTION,
        CONSTRAINT [FK_WorkPackages_Projects_ProjectId] FOREIGN KEY ([ProjectId]) REFERENCES [Projects] ([ProjectId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    CREATE TABLE [Credentials] (
        [CredentialId] nvarchar(450) NOT NULL,
        [EmployeeId] int NOT NULL,
        [Password] nvarchar(max) NULL,
        [Token] nvarchar(max) NULL,
        [Salt] varbinary(max) NULL,
        [LastUpdatedBy] nvarchar(max) NULL,
        [LastUpdatedTime] datetime2 NOT NULL,
        CONSTRAINT [PK_Credentials] PRIMARY KEY ([CredentialId]),
        CONSTRAINT [FK_Credentials_Employees_EmployeeId] FOREIGN KEY ([EmployeeId]) REFERENCES [Employees] ([EmployeeId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    CREATE TABLE [EmployeeProjectAssignments] (
        [EmployeeId] int NOT NULL,
        [ProjectId] int NOT NULL,
        [IsProjectManager] bit NOT NULL,
        [LastUpdatedBy] nvarchar(max) NULL,
        [LastUpdatedTime] datetime2 NOT NULL,
        CONSTRAINT [PK_EmployeeProjectAssignments] PRIMARY KEY ([EmployeeId], [ProjectId]),
        CONSTRAINT [FK_EmployeeProjectAssignments_Employees_EmployeeId] FOREIGN KEY ([EmployeeId]) REFERENCES [Employees] ([EmployeeId]) ON DELETE CASCADE,
        CONSTRAINT [FK_EmployeeProjectAssignments_Projects_ProjectId] FOREIGN KEY ([ProjectId]) REFERENCES [Projects] ([ProjectId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    CREATE TABLE [Timesheets] (
        [TimesheetId] int NOT NULL,
        [VersionNumber] int NOT NULL,
        [EmployeeId] int NOT NULL,
        [WeekNumber] int NOT NULL,
        [WeekEndingIn] datetime2 NOT NULL,
        [Status] int NOT NULL,
        [LastUpdatedBy] nvarchar(max) NULL,
        [LastUpdatedTime] datetime2 NOT NULL,
        CONSTRAINT [PK_Timesheets] PRIMARY KEY ([TimesheetId], [VersionNumber]),
        CONSTRAINT [FK_Timesheets_Employees_EmployeeId] FOREIGN KEY ([EmployeeId]) REFERENCES [Employees] ([EmployeeId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    CREATE TABLE [EmployeeWorkPackageAssignments] (
        [EmployeeId] int NOT NULL,
        [WorkPackageId] int NOT NULL,
        [LastUpdatedBy] nvarchar(max) NULL,
        [LastUpdatedTime] datetime2 NOT NULL,
        CONSTRAINT [PK_EmployeeWorkPackageAssignments] PRIMARY KEY ([EmployeeId], [WorkPackageId]),
        CONSTRAINT [FK_EmployeeWorkPackageAssignments_Employees_EmployeeId] FOREIGN KEY ([EmployeeId]) REFERENCES [Employees] ([EmployeeId]) ON DELETE NO ACTION,
        CONSTRAINT [FK_EmployeeWorkPackageAssignments_WorkPackages_WorkPackageId] FOREIGN KEY ([WorkPackageId]) REFERENCES [WorkPackages] ([WorkPackageId]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    CREATE TABLE [TimesheetRows] (
        [TimesheetRowId] int NOT NULL IDENTITY,
        [TimesheetId] int NOT NULL,
        [TimesheetVersionNumber] int NOT NULL,
        [WorkPackageId] int NOT NULL,
        [Monday] float NOT NULL,
        [Tuesday] float NOT NULL,
        [Wednesday] float NOT NULL,
        [Thursday] float NOT NULL,
        [Friday] float NOT NULL,
        [Saturday] float NOT NULL,
        [Sunday] float NOT NULL,
        [Notes] nvarchar(max) NULL,
        [LastUpdatedBy] nvarchar(max) NULL,
        [LastUpdatedTime] datetime2 NOT NULL,
        CONSTRAINT [PK_TimesheetRows] PRIMARY KEY ([TimesheetRowId]),
        CONSTRAINT [FK_TimesheetRows_WorkPackages_WorkPackageId] FOREIGN KEY ([WorkPackageId]) REFERENCES [WorkPackages] ([WorkPackageId]) ON DELETE NO ACTION,
        CONSTRAINT [FK_TimesheetRows_Timesheets_TimesheetId_TimesheetVersionNumber] FOREIGN KEY ([TimesheetId], [TimesheetVersionNumber]) REFERENCES [Timesheets] ([TimesheetId], [VersionNumber]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'JobTitleId', N'JobTitleName', N'LastUpdatedBy', N'LastUpdatedTime') AND [object_id] = OBJECT_ID(N'[JobTitles]'))
        SET IDENTITY_INSERT [JobTitles] ON;
    INSERT INTO [JobTitles] ([JobTitleId], [JobTitleName], [LastUpdatedBy], [LastUpdatedTime])
    VALUES (1, N'Software Developer', N'perry', '2020-02-08T15:12:25.5545083-08:00'),
    (2, N'Q/A Analyst', N'perry', '2020-02-08T15:12:25.5560051-08:00'),
    (3, N'Business Analyst', N'perry', '2020-02-08T15:12:25.5560901-08:00');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'JobTitleId', N'JobTitleName', N'LastUpdatedBy', N'LastUpdatedTime') AND [object_id] = OBJECT_ID(N'[JobTitles]'))
        SET IDENTITY_INSERT [JobTitles] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'LabourGradeId', N'LabourGradeCode', N'LastUpdatedBy', N'LastUpdatedTime', N'Multiplier') AND [object_id] = OBJECT_ID(N'[LabourGrades]'))
        SET IDENTITY_INSERT [LabourGrades] ON;
    INSERT INTO [LabourGrades] ([LabourGradeId], [LabourGradeCode], [LastUpdatedBy], [LastUpdatedTime], [Multiplier])
    VALUES (1, N'code1', N'seeded', '2020-02-08T15:12:25.5565469-08:00', 22.0E0),
    (2, N'code2', N'seeded', '2020-02-08T15:12:25.5566360-08:00', 23.0E0),
    (3, N'code3', N'seeded', '2020-02-08T15:12:25.5566374-08:00', 10.0E0);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'LabourGradeId', N'LabourGradeCode', N'LastUpdatedBy', N'LastUpdatedTime', N'Multiplier') AND [object_id] = OBJECT_ID(N'[LabourGrades]'))
        SET IDENTITY_INSERT [LabourGrades] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ProjectId', N'EndDate', N'IsClosed', N'LastUpdatedBy', N'LastUpdatedTime', N'ProjectDescription', N'ProjectManagerId', N'ProjectName', N'StartDate') AND [object_id] = OBJECT_ID(N'[Projects]'))
        SET IDENTITY_INSERT [Projects] ON;
    INSERT INTO [Projects] ([ProjectId], [EndDate], [IsClosed], [LastUpdatedBy], [LastUpdatedTime], [ProjectDescription], [ProjectManagerId], [ProjectName], [StartDate])
    VALUES (1, '2020-02-08T15:12:25.5578147-08:00', 0, N'seeded', '2020-02-08T15:12:25.5581710-08:00', N'NewProjectDescription1', 2, N'NewProject1', '2020-02-08T15:12:25.5578143-08:00'),
    (2, '2020-02-18T00:00:00.0000000', 0, N'seeded', '2020-02-08T15:12:25.5585626-08:00', N'ProjectDescription3', 2, N'ProjectName2', '2020-02-02T00:00:00.0000000'),
    (3, '2020-03-28T00:00:00.0000000', 0, N'seeded', '2020-02-08T15:12:25.5585657-08:00', N'ProjectDescription3', 3, N'ProjectName3', '2020-03-03T00:00:00.0000000');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ProjectId', N'EndDate', N'IsClosed', N'LastUpdatedBy', N'LastUpdatedTime', N'ProjectDescription', N'ProjectManagerId', N'ProjectName', N'StartDate') AND [object_id] = OBJECT_ID(N'[Projects]'))
        SET IDENTITY_INSERT [Projects] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmployeeId', N'EmployeeCode', N'EmployeeFirstName', N'EmployeeLastName', N'IsActivated', N'IsAdmin', N'IsHumanResources', N'IsProjectManager', N'JobTitleId', N'LabourGradeId', N'LastUpdatedBy', N'LastUpdatedTime', N'SupervisorId', N'TimesheetApproverId') AND [object_id] = OBJECT_ID(N'[Employees]'))
        SET IDENTITY_INSERT [Employees] ON;
    INSERT INTO [Employees] ([EmployeeId], [EmployeeCode], [EmployeeFirstName], [EmployeeLastName], [IsActivated], [IsAdmin], [IsHumanResources], [IsProjectManager], [JobTitleId], [LabourGradeId], [LastUpdatedBy], [LastUpdatedTime], [SupervisorId], [TimesheetApproverId])
    VALUES (1, 888, N'AdminFirstName', N'AdminLastName', 1, 1, 1, 1, 1, 1, N'Seeded', '2020-02-08T15:12:25.5573542-08:00', NULL, NULL);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmployeeId', N'EmployeeCode', N'EmployeeFirstName', N'EmployeeLastName', N'IsActivated', N'IsAdmin', N'IsHumanResources', N'IsProjectManager', N'JobTitleId', N'LabourGradeId', N'LastUpdatedBy', N'LastUpdatedTime', N'SupervisorId', N'TimesheetApproverId') AND [object_id] = OBJECT_ID(N'[Employees]'))
        SET IDENTITY_INSERT [Employees] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'WorkPackageId', N'BudgetHours', N'Description', N'IsClosed', N'IssueDate', N'LastUpdatedBy', N'LastUpdatedTime', N'Name', N'ParentWorkPackageId', N'ProjectId', N'ProposedHours', N'ResponsibleEngineerId', N'WorkPackageCode') AND [object_id] = OBJECT_ID(N'[WorkPackages]'))
        SET IDENTITY_INSERT [WorkPackages] ON;
    INSERT INTO [WorkPackages] ([WorkPackageId], [BudgetHours], [Description], [IsClosed], [IssueDate], [LastUpdatedBy], [LastUpdatedTime], [Name], [ParentWorkPackageId], [ProjectId], [ProposedHours], [ResponsibleEngineerId], [WorkPackageCode])
    VALUES (1, NULL, N'WpDescription1Root', 0, '2020-02-15T00:00:00.0000000', N'Seeded', '2020-02-08T15:12:25.5601912-08:00', N'WpName1Root', NULL, 1, NULL, 2, N'A'),
    (3, NULL, N'WpDescription2Root', 0, '2020-02-10T00:00:00.0000000', N'Seeded', '2020-02-08T15:12:25.5602996-08:00', N'WpName2Root', NULL, 2, NULL, 3, N'B'),
    (7, NULL, N'WpDescription3Root', 0, '2020-02-27T00:00:00.0000000', N'Seeded', '2020-02-08T15:12:25.5603033-08:00', N'WpName3Root', NULL, 3, NULL, 4, N'C');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'WorkPackageId', N'BudgetHours', N'Description', N'IsClosed', N'IssueDate', N'LastUpdatedBy', N'LastUpdatedTime', N'Name', N'ParentWorkPackageId', N'ProjectId', N'ProposedHours', N'ResponsibleEngineerId', N'WorkPackageCode') AND [object_id] = OBJECT_ID(N'[WorkPackages]'))
        SET IDENTITY_INSERT [WorkPackages] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CredentialId', N'EmployeeId', N'LastUpdatedBy', N'LastUpdatedTime', N'Password', N'Salt', N'Token') AND [object_id] = OBJECT_ID(N'[Credentials]'))
        SET IDENTITY_INSERT [Credentials] ON;
    INSERT INTO [Credentials] ([CredentialId], [EmployeeId], [LastUpdatedBy], [LastUpdatedTime], [Password], [Salt], [Token])
    VALUES (N'A100001', 1, N'seeded', '2020-02-08T15:12:25.5577354-08:00', N'KqGfR6SYojx3L+ay+gJWHMB8Pogp1d+E+rYAytvflD4=', 0xA31084B8B8651164374FA82D2F2D13FE, NULL);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CredentialId', N'EmployeeId', N'LastUpdatedBy', N'LastUpdatedTime', N'Password', N'Salt', N'Token') AND [object_id] = OBJECT_ID(N'[Credentials]'))
        SET IDENTITY_INSERT [Credentials] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmployeeId', N'EmployeeCode', N'EmployeeFirstName', N'EmployeeLastName', N'IsActivated', N'IsAdmin', N'IsHumanResources', N'IsProjectManager', N'JobTitleId', N'LabourGradeId', N'LastUpdatedBy', N'LastUpdatedTime', N'SupervisorId', N'TimesheetApproverId') AND [object_id] = OBJECT_ID(N'[Employees]'))
        SET IDENTITY_INSERT [Employees] ON;
    INSERT INTO [Employees] ([EmployeeId], [EmployeeCode], [EmployeeFirstName], [EmployeeLastName], [IsActivated], [IsAdmin], [IsHumanResources], [IsProjectManager], [JobTitleId], [LabourGradeId], [LastUpdatedBy], [LastUpdatedTime], [SupervisorId], [TimesheetApproverId])
    VALUES (2, 778, N'Perry', N'Li', 1, 0, 0, 1, 2, 2, N'Seeded', '2020-02-08T15:12:25.5574054-08:00', 1, 1);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmployeeId', N'EmployeeCode', N'EmployeeFirstName', N'EmployeeLastName', N'IsActivated', N'IsAdmin', N'IsHumanResources', N'IsProjectManager', N'JobTitleId', N'LabourGradeId', N'LastUpdatedBy', N'LastUpdatedTime', N'SupervisorId', N'TimesheetApproverId') AND [object_id] = OBJECT_ID(N'[Employees]'))
        SET IDENTITY_INSERT [Employees] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'WorkPackageId', N'BudgetHours', N'Description', N'IsClosed', N'IssueDate', N'LastUpdatedBy', N'LastUpdatedTime', N'Name', N'ParentWorkPackageId', N'ProjectId', N'ProposedHours', N'ResponsibleEngineerId', N'WorkPackageCode') AND [object_id] = OBJECT_ID(N'[WorkPackages]'))
        SET IDENTITY_INSERT [WorkPackages] ON;
    INSERT INTO [WorkPackages] ([WorkPackageId], [BudgetHours], [Description], [IsClosed], [IssueDate], [LastUpdatedBy], [LastUpdatedTime], [Name], [ParentWorkPackageId], [ProjectId], [ProposedHours], [ResponsibleEngineerId], [WorkPackageCode])
    VALUES (2, 15.0E0, N'WpDescription1Child1', 0, '2020-02-20T00:00:00.0000000', N'Seeded', '2020-02-08T15:12:25.5602935-08:00', N'WpName1Child1', 1, 1, 10.0E0, 2, N'AB'),
    (4, NULL, N'WpDescription2Child1', 0, '2020-02-12T00:00:00.0000000', N'Seeded', '2020-02-08T15:12:25.5603005-08:00', N'WpName2Child1', 3, 2, NULL, 5, N'BA'),
    (6, 8.0E0, N'WpDescription2Child2', 0, '2020-02-14T00:00:00.0000000', N'Seeded', '2020-02-08T15:12:25.5603022-08:00', N'WpName2Child2', 3, 2, 5.0E0, 5, N'BB');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'WorkPackageId', N'BudgetHours', N'Description', N'IsClosed', N'IssueDate', N'LastUpdatedBy', N'LastUpdatedTime', N'Name', N'ParentWorkPackageId', N'ProjectId', N'ProposedHours', N'ResponsibleEngineerId', N'WorkPackageCode') AND [object_id] = OBJECT_ID(N'[WorkPackages]'))
        SET IDENTITY_INSERT [WorkPackages] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CredentialId', N'EmployeeId', N'LastUpdatedBy', N'LastUpdatedTime', N'Password', N'Salt', N'Token') AND [object_id] = OBJECT_ID(N'[Credentials]'))
        SET IDENTITY_INSERT [Credentials] ON;
    INSERT INTO [Credentials] ([CredentialId], [EmployeeId], [LastUpdatedBy], [LastUpdatedTime], [Password], [Salt], [Token])
    VALUES (N'A100002', 2, N'seeded', '2020-02-08T15:12:25.5577831-08:00', N'XZpwG7EZyYoXbwah8gAz2xUaAt1vdVkDhlbCwepGvAg=', 0x206E8E343A47F9448E173846DA765CDB, NULL);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CredentialId', N'EmployeeId', N'LastUpdatedBy', N'LastUpdatedTime', N'Password', N'Salt', N'Token') AND [object_id] = OBJECT_ID(N'[Credentials]'))
        SET IDENTITY_INSERT [Credentials] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmployeeId', N'ProjectId', N'IsProjectManager', N'LastUpdatedBy', N'LastUpdatedTime') AND [object_id] = OBJECT_ID(N'[EmployeeProjectAssignments]'))
        SET IDENTITY_INSERT [EmployeeProjectAssignments] ON;
    INSERT INTO [EmployeeProjectAssignments] ([EmployeeId], [ProjectId], [IsProjectManager], [LastUpdatedBy], [LastUpdatedTime])
    VALUES (2, 1, 1, N'perry', '2020-02-08T15:12:25.5589965-08:00');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmployeeId', N'ProjectId', N'IsProjectManager', N'LastUpdatedBy', N'LastUpdatedTime') AND [object_id] = OBJECT_ID(N'[EmployeeProjectAssignments]'))
        SET IDENTITY_INSERT [EmployeeProjectAssignments] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmployeeId', N'WorkPackageId', N'LastUpdatedBy', N'LastUpdatedTime') AND [object_id] = OBJECT_ID(N'[EmployeeWorkPackageAssignments]'))
        SET IDENTITY_INSERT [EmployeeWorkPackageAssignments] ON;
    INSERT INTO [EmployeeWorkPackageAssignments] ([EmployeeId], [WorkPackageId], [LastUpdatedBy], [LastUpdatedTime])
    VALUES (2, 1, N'perry', '2020-02-08T15:12:25.5606506-08:00'),
    (2, 2, N'perry', '2020-02-08T15:12:25.5609402-08:00');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmployeeId', N'WorkPackageId', N'LastUpdatedBy', N'LastUpdatedTime') AND [object_id] = OBJECT_ID(N'[EmployeeWorkPackageAssignments]'))
        SET IDENTITY_INSERT [EmployeeWorkPackageAssignments] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmployeeId', N'EmployeeCode', N'EmployeeFirstName', N'EmployeeLastName', N'IsActivated', N'IsAdmin', N'IsHumanResources', N'IsProjectManager', N'JobTitleId', N'LabourGradeId', N'LastUpdatedBy', N'LastUpdatedTime', N'SupervisorId', N'TimesheetApproverId') AND [object_id] = OBJECT_ID(N'[Employees]'))
        SET IDENTITY_INSERT [Employees] ON;
    INSERT INTO [Employees] ([EmployeeId], [EmployeeCode], [EmployeeFirstName], [EmployeeLastName], [IsActivated], [IsAdmin], [IsHumanResources], [IsProjectManager], [JobTitleId], [LabourGradeId], [LastUpdatedBy], [LastUpdatedTime], [SupervisorId], [TimesheetApproverId])
    VALUES (3, 111, N'Bruce', N'Link', 1, 0, 0, 1, 3, 3, N'Seeded', '2020-02-08T15:12:25.5574069-08:00', 1, 2);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmployeeId', N'EmployeeCode', N'EmployeeFirstName', N'EmployeeLastName', N'IsActivated', N'IsAdmin', N'IsHumanResources', N'IsProjectManager', N'JobTitleId', N'LabourGradeId', N'LastUpdatedBy', N'LastUpdatedTime', N'SupervisorId', N'TimesheetApproverId') AND [object_id] = OBJECT_ID(N'[Employees]'))
        SET IDENTITY_INSERT [Employees] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'TimesheetId', N'VersionNumber', N'EmployeeId', N'LastUpdatedBy', N'LastUpdatedTime', N'Status', N'WeekEndingIn', N'WeekNumber') AND [object_id] = OBJECT_ID(N'[Timesheets]'))
        SET IDENTITY_INSERT [Timesheets] ON;
    INSERT INTO [Timesheets] ([TimesheetId], [VersionNumber], [EmployeeId], [LastUpdatedBy], [LastUpdatedTime], [Status], [WeekEndingIn], [WeekNumber])
    VALUES (1, 1, 2, N'Seeded', '2020-02-08T15:12:25.5619483-08:00', 2, '2020-05-20T00:00:00.0000000', 10);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'TimesheetId', N'VersionNumber', N'EmployeeId', N'LastUpdatedBy', N'LastUpdatedTime', N'Status', N'WeekEndingIn', N'WeekNumber') AND [object_id] = OBJECT_ID(N'[Timesheets]'))
        SET IDENTITY_INSERT [Timesheets] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'WorkPackageId', N'BudgetHours', N'Description', N'IsClosed', N'IssueDate', N'LastUpdatedBy', N'LastUpdatedTime', N'Name', N'ParentWorkPackageId', N'ProjectId', N'ProposedHours', N'ResponsibleEngineerId', N'WorkPackageCode') AND [object_id] = OBJECT_ID(N'[WorkPackages]'))
        SET IDENTITY_INSERT [WorkPackages] ON;
    INSERT INTO [WorkPackages] ([WorkPackageId], [BudgetHours], [Description], [IsClosed], [IssueDate], [LastUpdatedBy], [LastUpdatedTime], [Name], [ParentWorkPackageId], [ProjectId], [ProposedHours], [ResponsibleEngineerId], [WorkPackageCode])
    VALUES (5, 25.0E0, N'WpDescription2ChildChild1', 0, '2020-02-20T00:00:00.0000000', N'Seeded', '2020-02-08T15:12:25.5603014-08:00', N'WpName2ChildChild1', 4, 2, 20.0E0, 2, N'BAA');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'WorkPackageId', N'BudgetHours', N'Description', N'IsClosed', N'IssueDate', N'LastUpdatedBy', N'LastUpdatedTime', N'Name', N'ParentWorkPackageId', N'ProjectId', N'ProposedHours', N'ResponsibleEngineerId', N'WorkPackageCode') AND [object_id] = OBJECT_ID(N'[WorkPackages]'))
        SET IDENTITY_INSERT [WorkPackages] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmployeeId', N'ProjectId', N'IsProjectManager', N'LastUpdatedBy', N'LastUpdatedTime') AND [object_id] = OBJECT_ID(N'[EmployeeProjectAssignments]'))
        SET IDENTITY_INSERT [EmployeeProjectAssignments] ON;
    INSERT INTO [EmployeeProjectAssignments] ([EmployeeId], [ProjectId], [IsProjectManager], [LastUpdatedBy], [LastUpdatedTime])
    VALUES (3, 1, 0, N'perry', '2020-02-08T15:12:25.5591297-08:00'),
    (3, 2, 1, N'perry', '2020-02-08T15:12:25.5592099-08:00'),
    (3, 3, 0, N'perry', '2020-02-08T15:12:25.5594640-08:00');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmployeeId', N'ProjectId', N'IsProjectManager', N'LastUpdatedBy', N'LastUpdatedTime') AND [object_id] = OBJECT_ID(N'[EmployeeProjectAssignments]'))
        SET IDENTITY_INSERT [EmployeeProjectAssignments] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmployeeId', N'WorkPackageId', N'LastUpdatedBy', N'LastUpdatedTime') AND [object_id] = OBJECT_ID(N'[EmployeeWorkPackageAssignments]'))
        SET IDENTITY_INSERT [EmployeeWorkPackageAssignments] ON;
    INSERT INTO [EmployeeWorkPackageAssignments] ([EmployeeId], [WorkPackageId], [LastUpdatedBy], [LastUpdatedTime])
    VALUES (3, 1, N'perry', '2020-02-08T15:12:25.5607801-08:00'),
    (3, 2, N'perry', '2020-02-08T15:12:25.5608618-08:00'),
    (3, 3, N'perry', '2020-02-08T15:12:25.5610189-08:00'),
    (3, 7, N'perry', '2020-02-08T15:12:25.5614983-08:00'),
    (2, 5, N'perry', '2020-02-08T15:12:25.5613387-08:00');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmployeeId', N'WorkPackageId', N'LastUpdatedBy', N'LastUpdatedTime') AND [object_id] = OBJECT_ID(N'[EmployeeWorkPackageAssignments]'))
        SET IDENTITY_INSERT [EmployeeWorkPackageAssignments] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmployeeId', N'EmployeeCode', N'EmployeeFirstName', N'EmployeeLastName', N'IsActivated', N'IsAdmin', N'IsHumanResources', N'IsProjectManager', N'JobTitleId', N'LabourGradeId', N'LastUpdatedBy', N'LastUpdatedTime', N'SupervisorId', N'TimesheetApproverId') AND [object_id] = OBJECT_ID(N'[Employees]'))
        SET IDENTITY_INSERT [Employees] ON;
    INSERT INTO [Employees] ([EmployeeId], [EmployeeCode], [EmployeeFirstName], [EmployeeLastName], [IsActivated], [IsAdmin], [IsHumanResources], [IsProjectManager], [JobTitleId], [LabourGradeId], [LastUpdatedBy], [LastUpdatedTime], [SupervisorId], [TimesheetApproverId])
    VALUES (4, 123, N'Employee4FirstName', N'Employee4LastName', 1, 0, 0, 0, 2, 2, N'Seeded', '2020-02-08T15:12:25.5574072-08:00', 3, 3),
    (5, 222, N'Employee5FirstName', N'Employee5LastName', 1, 0, 0, 1, 3, 3, N'Seeded', '2020-02-08T15:12:25.5574075-08:00', 3, 3);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmployeeId', N'EmployeeCode', N'EmployeeFirstName', N'EmployeeLastName', N'IsActivated', N'IsAdmin', N'IsHumanResources', N'IsProjectManager', N'JobTitleId', N'LabourGradeId', N'LastUpdatedBy', N'LastUpdatedTime', N'SupervisorId', N'TimesheetApproverId') AND [object_id] = OBJECT_ID(N'[Employees]'))
        SET IDENTITY_INSERT [Employees] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'TimesheetRowId', N'Friday', N'LastUpdatedBy', N'LastUpdatedTime', N'Monday', N'Notes', N'Saturday', N'Sunday', N'Thursday', N'TimesheetId', N'TimesheetVersionNumber', N'Tuesday', N'Wednesday', N'WorkPackageId') AND [object_id] = OBJECT_ID(N'[TimesheetRows]'))
        SET IDENTITY_INSERT [TimesheetRows] ON;
    INSERT INTO [TimesheetRows] ([TimesheetRowId], [Friday], [LastUpdatedBy], [LastUpdatedTime], [Monday], [Notes], [Saturday], [Sunday], [Thursday], [TimesheetId], [TimesheetVersionNumber], [Tuesday], [Wednesday], [WorkPackageId])
    VALUES (1, 7.0E0, N'Seeded', '2020-02-08T15:12:25.5626718-08:00', 3.0E0, N'dota is best', 8.0E0, 9.0E0, 6.0E0, 1, 1, 4.0E0, 5.0E0, 2),
    (2, 3.0E0, N'Seeded', '2020-02-08T15:12:25.5627588-08:00', 3.0E0, N'PIG GOD!!!', 3.0E0, 3.0E0, 3.0E0, 1, 1, 3.0E0, 3.0E0, 3);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'TimesheetRowId', N'Friday', N'LastUpdatedBy', N'LastUpdatedTime', N'Monday', N'Notes', N'Saturday', N'Sunday', N'Thursday', N'TimesheetId', N'TimesheetVersionNumber', N'Tuesday', N'Wednesday', N'WorkPackageId') AND [object_id] = OBJECT_ID(N'[TimesheetRows]'))
        SET IDENTITY_INSERT [TimesheetRows] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmployeeId', N'ProjectId', N'IsProjectManager', N'LastUpdatedBy', N'LastUpdatedTime') AND [object_id] = OBJECT_ID(N'[EmployeeProjectAssignments]'))
        SET IDENTITY_INSERT [EmployeeProjectAssignments] ON;
    INSERT INTO [EmployeeProjectAssignments] ([EmployeeId], [ProjectId], [IsProjectManager], [LastUpdatedBy], [LastUpdatedTime])
    VALUES (4, 3, 0, N'perry', '2020-02-08T15:12:25.5595448-08:00'),
    (5, 2, 0, N'perry', '2020-02-08T15:12:25.5592972-08:00'),
    (5, 3, 1, N'perry', '2020-02-08T15:12:25.5593806-08:00');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmployeeId', N'ProjectId', N'IsProjectManager', N'LastUpdatedBy', N'LastUpdatedTime') AND [object_id] = OBJECT_ID(N'[EmployeeProjectAssignments]'))
        SET IDENTITY_INSERT [EmployeeProjectAssignments] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmployeeId', N'WorkPackageId', N'LastUpdatedBy', N'LastUpdatedTime') AND [object_id] = OBJECT_ID(N'[EmployeeWorkPackageAssignments]'))
        SET IDENTITY_INSERT [EmployeeWorkPackageAssignments] ON;
    INSERT INTO [EmployeeWorkPackageAssignments] ([EmployeeId], [WorkPackageId], [LastUpdatedBy], [LastUpdatedTime])
    VALUES (4, 3, N'perry', '2020-02-08T15:12:25.5610971-08:00'),
    (4, 7, N'perry', '2020-02-08T15:12:25.5615789-08:00'),
    (5, 4, N'perry', '2020-02-08T15:12:25.5611764-08:00'),
    (5, 5, N'perry', '2020-02-08T15:12:25.5612603-08:00'),
    (5, 6, N'perry', '2020-02-08T15:12:25.5614185-08:00');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmployeeId', N'WorkPackageId', N'LastUpdatedBy', N'LastUpdatedTime') AND [object_id] = OBJECT_ID(N'[EmployeeWorkPackageAssignments]'))
        SET IDENTITY_INSERT [EmployeeWorkPackageAssignments] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    CREATE INDEX [IX_Credentials_EmployeeId] ON [Credentials] ([EmployeeId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    CREATE INDEX [IX_EmployeeProjectAssignments_ProjectId] ON [EmployeeProjectAssignments] ([ProjectId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    CREATE INDEX [IX_Employees_JobTitleId] ON [Employees] ([JobTitleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    CREATE INDEX [IX_Employees_LabourGradeId] ON [Employees] ([LabourGradeId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    CREATE INDEX [IX_Employees_SupervisorId] ON [Employees] ([SupervisorId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    CREATE INDEX [IX_Employees_TimesheetApproverId] ON [Employees] ([TimesheetApproverId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    CREATE INDEX [IX_EmployeeWorkPackageAssignments_WorkPackageId] ON [EmployeeWorkPackageAssignments] ([WorkPackageId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    CREATE INDEX [IX_TimesheetRows_WorkPackageId] ON [TimesheetRows] ([WorkPackageId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    CREATE INDEX [IX_TimesheetRows_TimesheetId_TimesheetVersionNumber] ON [TimesheetRows] ([TimesheetId], [TimesheetVersionNumber]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    CREATE INDEX [IX_Timesheets_EmployeeId] ON [Timesheets] ([EmployeeId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    CREATE INDEX [IX_WorkPackages_ParentWorkPackageId] ON [WorkPackages] ([ParentWorkPackageId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    CREATE INDEX [IX_WorkPackages_ProjectId] ON [WorkPackages] ([ProjectId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200208231225_perryfinalcreate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200208231225_perryfinalcreate', N'2.2.6-servicing-10079');
END;

GO

