if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPR_Doc_Status1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPR_Doc_Status1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WPR_Doc_Status] table.
CREATE PROCEDURE pePortalWFApprovalWPR_Doc_Status1Add
    @p_WPRDS_Desc varchar(150),
    @p_WPRDS_Value smallint,
    @p_WPRDS_ID_out smallint output
AS
BEGIN
    INSERT
    INTO [dbo].[WPR_Doc_Status]
        (
            [WPRDS_Desc],
            [WPRDS_Value]
        )
    VALUES
        (
             @p_WPRDS_Desc,
             @p_WPRDS_Value
        )

    SET @p_WPRDS_ID_out = SCOPE_IDENTITY()

END

