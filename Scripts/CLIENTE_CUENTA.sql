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
CREATE PROCEDURE CUENTA_CLIENTE
@ID_CLIENTE AS INT
AS
BEGIN
	SET NOCOUNT ON;

SELECT NUMERO_CUENTA AS "NUMERO_CUENTA"
FROM CUENTA
WHERE ID_CLIENTE = @ID_CLIENTE

END
GO

select * from cuenta
select * from cliente
SELECT * FROM ENCABEZADO_CHEQUERA
