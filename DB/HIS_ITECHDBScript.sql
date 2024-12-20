USE [ITECHIS]
GO
/****** Object:  Table [dbo].[HIS_Appointment]    Script Date: 11/3/2024 11:48:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HIS_Appointment](
	[AppointmentNo] [bigint] IDENTITY(1,1) NOT NULL,
	[AppointmentType] [int] NULL,
	[AppointmentDate] [date] NULL,
	[PatientId] [int] NULL,
	[DoctorId] [int] NULL,
	[ClinicId] [int] NULL,
	[StartTime] [varchar](50) NULL,
	[EndTime] [varchar](50) NULL,
	[Status] [smallint] NULL,
	[VisitType] [smallint] NULL,
	[PatientArrivalStatusType] [smallint] NULL,
	[ActualVisitStartTime] [time](7) NULL,
	[ActualVisitEndTime] [time](7) NULL,
	[BookedBy] [int] NULL,
	[BookedOn] [datetime] NULL,
	[ConfirmedBy] [int] NULL,
	[ConfirmedIOn] [datetime] NULL,
	[ArrivedBy] [int] NULL,
	[ArrivedOn] [datetime] NULL,
	[RescheduledBy] [int] NULL,
	[RescheduledOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[EditedBy] [int] NULL,
	[E] [nchar](10) NULL,
 CONSTRAINT [PK_HIS_Appointment] PRIMARY KEY CLUSTERED 
(
	[AppointmentNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HIS_Clinic]    Script Date: 11/3/2024 11:48:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HIS_Clinic](
	[ClinicId] [int] IDENTITY(1,1) NOT NULL,
	[ClinicName] [varchar](500) NULL,
	[IsActive] [bit] NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[EditedBy] [int] NULL,
	[EditedOn] [datetime] NULL,
 CONSTRAINT [PK_HIS_Clinic] PRIMARY KEY CLUSTERED 
(
	[ClinicId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HIS_Doctor]    Script Date: 11/3/2024 11:48:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HIS_Doctor](
	[DoctorId] [int] IDENTITY(2000,1) NOT NULL,
	[FirstName] [varchar](500) NOT NULL,
	[MiddleName] [varchar](500) NOT NULL,
	[LastName] [varchar](500) NOT NULL,
	[DateOfBirth] [date] NULL,
	[EmailId] [varchar](100) NULL,
	[MobileNumber] [varchar](50) NULL,
	[EmergencyContactName] [varchar](500) NULL,
	[EmergencyContactNumber] [varchar](50) NULL,
	[AreaId] [int] NULL,
	[CityId] [int] NULL,
	[StateId] [int] NULL,
	[CountryId] [int] NULL,
	[Address] [varchar](1000) NULL,
	[IsActive] [bit] NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[EditedBy] [int] NULL,
	[EditedOn] [datetime] NULL,
 CONSTRAINT [PK_HIS_Doctor] PRIMARY KEY CLUSTERED 
(
	[DoctorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HIS_DoctorCalender]    Script Date: 11/3/2024 11:48:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HIS_DoctorCalender](
	[DoctorCalenderId] [int] IDENTITY(1,1) NOT NULL,
	[DoctorId] [int] NOT NULL,
	[ClinicId] [int] NOT NULL,
	[GregDate] [date] NULL,
	[SlotDuration] [int] NULL,
	[StartTime] [varchar](50) NULL,
	[EndTime] [varchar](50) NULL,
	[IsActive] [bit] NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[EditedBy] [int] NULL,
	[EditedOn] [datetime] NULL,
 CONSTRAINT [PK_HIS_DoctorCalender] PRIMARY KEY CLUSTERED 
(
	[DoctorCalenderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HIS_DoctorClinicMapping]    Script Date: 11/3/2024 11:48:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HIS_DoctorClinicMapping](
	[DoctorClinicID] [int] IDENTITY(1,1) NOT NULL,
	[DoctorId] [int] NOT NULL,
	[ClinicId] [int] NOT NULL,
	[IsActive] [bit] NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[EditedBy] [int] NULL,
	[EditedOn] [datetime] NULL,
 CONSTRAINT [PK_HIS_DoctorClinicMapping] PRIMARY KEY CLUSTERED 
(
	[DoctorClinicID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HIS_DoctorSchedule]    Script Date: 11/3/2024 11:48:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HIS_DoctorSchedule](
	[ScheduleId] [int] IDENTITY(1,1) NOT NULL,
	[DoctorId] [int] NOT NULL,
	[WeekDayId] [int] NOT NULL,
	[SlotDuration] [varchar](50) NOT NULL,
	[StartTime] [varchar](50) NULL,
	[EndTime] [varchar](50) NULL,
	[IsActive] [bit] NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[EditedBy] [int] NULL,
	[EditedOn] [datetime] NULL,
 CONSTRAINT [PK_HIS_DoctorSchedule] PRIMARY KEY CLUSTERED 
(
	[ScheduleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HIS_DoctorSpecialityMapping]    Script Date: 11/3/2024 11:48:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HIS_DoctorSpecialityMapping](
	[DoctorSpecialityId] [int] IDENTITY(1,1) NOT NULL,
	[DoctorId] [int] NOT NULL,
	[SpecialityId] [int] NOT NULL,
	[IsActive] [bit] NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[EditedBy] [int] NULL,
	[EditedOn] [datetime] NULL,
 CONSTRAINT [PK_HIS_DoctorSpecialityMapping] PRIMARY KEY CLUSTERED 
(
	[DoctorSpecialityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HIS_Parameter]    Script Date: 11/3/2024 11:48:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HIS_Parameter](
	[ParameterId] [int] NOT NULL,
	[ParameterTypeId] [int] NOT NULL,
	[ParameterName] [varchar](200) NOT NULL,
	[ParameterNameN] [nvarchar](200) NULL,
	[IsActive] [bit] NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[EditedBy] [int] NULL,
	[EditedOn] [datetime] NULL,
 CONSTRAINT [PK_HIS_Parameter] PRIMARY KEY CLUSTERED 
(
	[ParameterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HIS_ParameterType]    Script Date: 11/3/2024 11:48:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HIS_ParameterType](
	[ParameterTypeId] [int] IDENTITY(1,1) NOT NULL,
	[ParameterTypeName] [varchar](200) NOT NULL,
	[ParameterTypeNameN] [nvarchar](200) NULL,
	[IsActive] [bit] NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[EditedBy] [int] NULL,
	[EditedOn] [datetime] NULL,
 CONSTRAINT [PK_HIS_ParameterType] PRIMARY KEY CLUSTERED 
(
	[ParameterTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HIS_PatientId]    Script Date: 11/3/2024 11:48:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HIS_PatientId](
	[PatientId] [int] IDENTITY(1000,1) NOT NULL,
	[FirstName] [varchar](500) NOT NULL,
	[MiddleName] [varchar](500) NOT NULL,
	[LastName] [varchar](500) NOT NULL,
	[DateOfBirth] [date] NULL,
	[EmailId] [varchar](100) NULL,
	[MobileNumber] [varchar](50) NULL,
	[EmergencyContactName] [varchar](500) NULL,
	[EmergencyContactNumber] [varchar](50) NULL,
	[AreaId] [int] NULL,
	[CityId] [int] NULL,
	[StateId] [int] NULL,
	[CountryId] [int] NULL,
	[Address] [varchar](1000) NULL,
	[IsActive] [bit] NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[EditedBy] [int] NULL,
	[EditedOn] [datetime] NULL,
 CONSTRAINT [PK_HIS_PatientId] PRIMARY KEY CLUSTERED 
(
	[PatientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HIS_Role]    Script Date: 11/3/2024 11:48:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HIS_Role](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [varchar](200) NOT NULL,
	[IsActive] [bit] NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[EditedBy] [int] NULL,
	[EditedOn] [datetime] NULL,
 CONSTRAINT [PK_HIS_Role] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HIS_User]    Script Date: 11/3/2024 11:48:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HIS_User](
	[UserId] [int] NOT NULL,
	[UserName] [varchar](250) NOT NULL,
	[FirstName] [varchar](500) NULL,
	[MiddleName] [varchar](500) NULL,
	[LastName] [varchar](500) NULL,
	[EmailId] [varchar](150) NULL,
	[Mobile] [varchar](50) NULL,
	[IsActive] [bit] NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[EditedBy] [int] NULL,
	[EditedOn] [datetime] NULL,
 CONSTRAINT [PK_HIS_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HIS_UserRole]    Script Date: 11/3/2024 11:48:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HIS_UserRole](
	[UserRoleId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[RoleI] [int] NOT NULL,
	[IsActive] [bit] NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[EditedBy] [int] NULL,
	[EditedOn] [datetime] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[HIS_Parameter]  WITH CHECK ADD  CONSTRAINT [FK_HIS_Parameter_HIS_ParameterType] FOREIGN KEY([ParameterTypeId])
REFERENCES [dbo].[HIS_ParameterType] ([ParameterTypeId])
GO
ALTER TABLE [dbo].[HIS_Parameter] CHECK CONSTRAINT [FK_HIS_Parameter_HIS_ParameterType]
GO
