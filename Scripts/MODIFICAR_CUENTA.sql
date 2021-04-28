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
CREATE PROCEDURE MODIFICAR_CUENTA
@NUMERO_CUENTA AS VARCHAR(25),
@SALDO NUMERIC(20,2),
@ID_CLIENTE AS INTEGER,
@ID_TIPO AS INTEGER
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE CUENTA SET	NUMERO_CUENTA = @NUMERO_CUENTA,
						SALDO	= @SALDO,
						ID_CLIENTE = @ID_CLIENTE,
						ID_TIPO = @ID_TIPO
	WHERE NUMERO_CUENTA = @NUMERO_CUENTA
END
GO
