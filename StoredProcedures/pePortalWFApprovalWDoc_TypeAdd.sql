if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWDoc_TypeAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWDoc_TypeAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WDoc_Type] table.
CREATE PROCEDURE pePortalWFApprovalWDoc_TypeAdd
    @p_WDT_C_ID smallint,
    @p_WDT_Name varchar(100),
    @p_WDT_Desc varchar(250),
    @p_WDT_Type varchar(5),
    @p_WDT_Limit numeric(18,2),
    @p_WDT_Minimum numeric(18,2),
    @p_WDT_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WDoc_Type]
        (
            [WDT_C_ID],
            [WDT_Name],
            [WDT_Desc],
            [WDT_Type],
            [WDT_Limit],
            [WDT_Minimum]
        )
    VALUES
        (
             @p_WDT_C_ID,
             @p_WDT_Name,
             @p_WDT_Desc,
             @p_WDT_Type,
             @p_WDT_Limit,
             @p_WDT_Minimum
        )

    SET @p_WDT_ID_out = SCOPE_IDENTITY()

END

