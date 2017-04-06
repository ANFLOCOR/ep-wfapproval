if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalW_Email_Default1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalW_Email_Default1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[W_Email_Default] table.
CREATE PROCEDURE pePortalWFApprovalW_Email_Default1Add
    @p_WED_Type varchar(50),
    @p_WED_Template text,
    @p_WED_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[W_Email_Default]
        (
            [WED_Type],
            [WED_Template]
        )
    VALUES
        (
             @p_WED_Type,
             @p_WED_Template
        )

    SET @p_WED_ID_out = SCOPE_IDENTITY()

END

