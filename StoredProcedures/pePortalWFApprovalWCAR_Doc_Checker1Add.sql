if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCAR_Doc_Checker1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCAR_Doc_Checker1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WCAR_Doc_Checker] table.
CREATE PROCEDURE pePortalWFApprovalWCAR_Doc_Checker1Add
    @p_WCDC_WCD_ID int,
    @p_WCDC_U_ID int,
    @p_WCDC_Status varchar(25),
    @p_WCDC_Rem varchar(250),
    @p_WCDC_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WCAR_Doc_Checker]
        (
            [WCDC_WCD_ID],
            [WCDC_U_ID],
            [WCDC_Status],
            [WCDC_Rem]
        )
    VALUES
        (
             @p_WCDC_WCD_ID,
             @p_WCDC_U_ID,
             @p_WCDC_Status,
             @p_WCDC_Rem
        )

    SET @p_WCDC_ID_out = SCOPE_IDENTITY()

END

