-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<KEVIN CRUZ>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE CREAR_CHEQUERA
@NUMERO_CHEQUERA AS VARCHAR(25),
@ID_CLIENTE AS INT,
@ID_CUENTA AS INT
AS
BEGIN
	
	SET NOCOUNT ON;

    INSERT INTO ENCABEZADO_CHEQUERA VALUES(@NUMERO_CHEQUERA,@ID_CLIENTE,@ID_CUENTA)
END
GO

