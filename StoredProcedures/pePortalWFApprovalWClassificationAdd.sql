if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWClassificationAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWClassificationAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WClassification] table.
CREATE PROCEDURE pePortalWFApprovalWClassificationAdd
    @p_WClass_Name varchar(100),
    @p_WClass_Value int,
    @p_WClass_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WClassification]
        (
            [WClass_Name],
            [WClass_Value]
        )
    VALUES
        (
             @p_WClass_Name,
             @p_WClass_Value
        )

    SET @p_WClass_ID_out = SCOPE_IDENTITY()

END

