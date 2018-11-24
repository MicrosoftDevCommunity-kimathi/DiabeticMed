CREATE TABLE [dbo].[MedicPatients] (
    [Id]                      INT            IDENTITY (1, 1) NOT NULL,
    [Age]                     INT            NOT NULL,
    [BMi]                     REAL           NOT NULL,
    [Diabetic]                REAL           NOT NULL,
    [DiabeticPadiac]          REAL           NOT NULL,
    [DiasotolicBloodPressure] REAL           NOT NULL,
    [Isdiabetic]              BIT            NOT NULL,
    [Name]                    NVARCHAR (MAX) NOT NULL,
    [PlasmaGlucose]           REAL           NOT NULL,
    [Pregnanicies]            INT            NOT NULL,
    [Seruminium]              REAL           NOT NULL,
    [TricepThickness]         REAL           NOT NULL,
    CONSTRAINT [PK_MedicPatients] PRIMARY KEY CLUSTERED ([Id] ASC)
);

