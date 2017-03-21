if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPO_Doc_Type1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPO_Doc_Type1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WPO_Doc_Type] table.
CREATE PROCEDURE pePortalWFApprovalWPO_Doc_Type1Add
    @p_WPO_DT_C_ID smallint,
    @p_WPO_DT_Name varchar(100),
    @p_WPO_DT_Desc varchar(250),
    @p_WPO_DT_Type varchar(50),
    @p_WPO_DT_Minimum numeric(18,2),
    @p_WPO_DT_Maximum numeric(18,2),
    @p_WPO_DT_Limit numeric(18,2),
    @p_WPO_DT_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WPO_Doc_Type]
        (
            [WPO_DT_C_ID],
            [WPO_DT_Name],
            [WPO_DT_Desc],
            [WPO_DT_Type],
            [WPO_DT_Minimum],
            [WPO_DT_Maximum],
            [WPO_DT_Limit]
        )
    VALUES
        (
             @p_WPO_DT_C_ID,
             @p_WPO_DT_Name,
             @p_WPO_DT_Desc,
             @p_WPO_DT_Type,
             @p_WPO_DT_Minimum,
             @p_WPO_DT_Maximum,
             @p_WPO_DT_Limit
        )

    SET @p_WPO_DT_ID_out = SCOPE_IDENTITY()

END

