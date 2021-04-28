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
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE MOSTRAR_DATOS
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT  C.*,CU.NUMERO_CUENTA,CHE.NUMERO_CHEQUERA,CU.SALDO
	FROM CLIENTE C, CUENTA CU, ENCABEZADO_CHEQUERA CHE
	WHERE C.ID_CLIENTE = CU.ID_CLIENTE
	AND  C.ID_CLIENTE = CHE.ID_CLIENTE
	AND  CU.ID_CUENTA = CHE.ID_CUENTA



END
GO
