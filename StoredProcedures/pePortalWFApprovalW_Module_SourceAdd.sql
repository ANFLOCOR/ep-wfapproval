if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalW_Module_SourceAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalW_Module_SourceAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[W_Module_Source] table.
CREATE PROCEDURE pePortalWFApprovalW_Module_SourceAdd
    @p_W_MS_A_ID smallint,
    @p_W_MS_Name varchar(50),
    @p_W_MS_Desc varchar(50),
    @p_W_MS_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[W_Module_Source]
        (
            [W_MS_A_ID],
            [W_MS_Name],
            [W_MS_Desc]
        )
    VALUES
        (
             @p_W_MS_A_ID,
             @p_W_MS_Name,
             @p_W_MS_Desc
        )

    SET @p_W_MS_ID_out = SCOPE_IDENTITY()

END

