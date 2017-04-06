if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalVw_WFinRep_DocAttach_FIN_Month1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalVw_WFinRep_DocAttach_FIN_Month1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[vw_WFinRep_DocAttach_FIN_Month] table.
CREATE PROCEDURE pePortalWFApprovalVw_WFinRep_DocAttach_FIN_Month1Add
    @p_Mo int,
    @p_MoName nvarchar(30)
AS
BEGIN
    INSERT
    INTO [dbo].[vw_WFinRep_DocAttach_FIN_Month]
        (
            [Mo],
            [MoName]
        )
    VALUES
        (
             @p_Mo,
             @p_MoName
        )

END

