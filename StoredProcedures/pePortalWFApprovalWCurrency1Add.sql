if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWCurrency1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWCurrency1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WCurrency] table.
CREATE PROCEDURE pePortalWFApprovalWCurrency1Add
    @p_WCur_Short varchar(5),
    @p_WCur_Desc varchar(75),
    @p_WCur_ID_out smallint output
AS
BEGIN
    INSERT
    INTO [dbo].[WCurrency]
        (
            [WCur_Short],
            [WCur_Desc]
        )
    VALUES
        (
             @p_WCur_Short,
             @p_WCur_Desc
        )

    SET @p_WCur_ID_out = SCOPE_IDENTITY()

END

