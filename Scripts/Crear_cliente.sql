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
CREATE PROCEDURE CREAR_CLIENTE
@CUI		AS VARCHAR(25),
@NOMBRE		AS VARCHAR(25),
@APELLIDO	AS VARCHAR(25),
@DIRECCION	AS VARCHAR(64),
@TELEFONO	AS VARCHAR(25)
AS
BEGIN

	SET NOCOUNT ON;

    INSERT INTO CLIENTE VALUES(@CUI,@NOMBRE,@APELLIDO,@DIRECCION,@TELEFONO)

END
GO
