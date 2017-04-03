if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_ReportType1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_ReportType1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WFinRep_ReportType] table.
CREATE PROCEDURE pePortalWFApprovalWFinRep_ReportType1Add
    @p_WFRT_Type varchar(50),
    @p_WFRT_Description varchar(350),
    @p_WFRT_SortOrder int
AS
BEGIN
    INSERT
    INTO [dbo].[WFinRep_ReportType]
        (
            [WFRT_Type],
            [WFRT_Description],
            [WFRT_SortOrder]
        )
    VALUES
        (
             @p_WFRT_Type,
             @p_WFRT_Description,
             @p_WFRT_SortOrder
        )

END

