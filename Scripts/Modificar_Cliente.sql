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
CREATE PROCEDURE alter nMODIFICAR_CLIENTE
@CUI AS VARCHAR(25),
@NOMBRE AS VARCHAR(25),
@APELLIDO AS VARCHAR(25),
@DIRECCION AS VARCHAR(64),
@TELEFONO AS VARCHAR(25)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE CLIENTE SET	CUI=@CUI,
						NOMBRE = @NOMBRE,
						APELLIDO = @APELLIDO,
						DIRECCION = @DIRECCION,
						TELEFONO = @TELEFONO
	WHERE CUI = @CUI
END
GO

select * from cliente