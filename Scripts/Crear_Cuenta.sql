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
CREATE PROCEDURE CREAR_CUENTA
	@NUMERO_CUENTA	AS VARCHAR(25),
	@SALDO			AS NUMERIC(20,2),
	@ID_CLIENTE		AS INTEGER,
	@ID_TIPO_CUENTA	AS INTEGER
AS
BEGIN
	
	SET NOCOUNT ON;

	INSERT INTO CUENTA VALUES(@NUMERO_CUENTA,@SALDO,@ID_CLIENTE,@ID_TIPO_CUENTA)

    
END
GO
