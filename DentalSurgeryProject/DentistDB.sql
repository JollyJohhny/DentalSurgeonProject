USE [DBDentist]
GO
/****** Object:  Table [dbo].[Appointment]    Script Date: 09/05/2019 01:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointment](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[PatientDetails] [nvarchar](max) NULL,
	[PatientName] [nvarchar](max) NULL,
	[PatientAddress] [nvarchar](max) NULL,
	[PatientTelephoneNumber] [nvarchar](max) NULL,
	[PatientEmailAddress] [nvarchar](max) NULL,
	[PatientType] [nvarchar](max) NULL,
	[ApointmentDetails] [nvarchar](max) NULL,
	[AppointmentType] [nvarchar](max) NULL,
	[OtherDetails] [nvarchar](max) NULL,
	[AppointmentDate] [date] NULL,
	[AppointmentStartTime] [nvarchar](max) NULL,
	[AppointmentEndTime] [nvarchar](max) NULL,
	[DentistName] [nvarchar](max) NULL,
 CONSTRAINT [PK_Appointment] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
