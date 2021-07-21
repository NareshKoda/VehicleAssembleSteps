# VehicleAssembleSteps
This Application is about
Creating the vehicle assemble steps and we can able to display the vehicle assemble steps.


Database scripts:
CREATE TABLE dbo.tbl_VehicleAssemble
	(
	VehicleAssembleID int NOT NULL IDENTITY (1, 1),
	VehicleProjeCode varchar(50) NOT NULL,
	Variant varchar(50) NULL,
	TirePressure int NULL,
	Region varchar(50) NULL,
	TransmissionType varchar(50) NULL,
	AssemblyProcess varchar(300) NOT NULL,
	ColourCode varchar(50) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.tbl_VehicleAssemble ADD CONSTRAINT
	PK_VehicleAssemble PRIMARY KEY CLUSTERED 
	(
	VehicleAssembleID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.VehicleAssemble SET (LOCK_ESCALATION = TABLE)
GO
COMMIT


Create PROCEDURE [dbo].[sp_GetVehicleAssembleDetails]
AS
BEGIN
	
   SELECT VehicleAssembleID,VehicleProjeCode,Variant,TirePressure,Region,TransmissionType,AssemblyProcess,ColourCode  
   FROM tbl_VehicleAssemble
    
END

Create PROCEDURE [dbo].[sp_AddVehicleAssembleDetails]
@VehicleProjeCode varchar(50),
@Variant varchar(50),
@Region varchar(50),
@TransmissionType varchar(50),
@AssemblyProcess varchar(300),
@ColourCode varchar(50),
@TirePressure int,
@result int Output
AS
BEGIN
	Insert into tbl_VehicleAssemble
	(
	VehicleProjeCode,
	Variant,
	TirePressure,
	Region,
	TransmissionType,
	AssemblyProcess,
	ColourCode
	)
	values
	(
		@VehicleProjeCode,
		@Variant,
		@Region ,
		@TransmissionType ,
		@AssemblyProcess ,
		@ColourCode ,
		@TirePressure 
	)
	SET @result = @@ROWCOUNT;
  
END
