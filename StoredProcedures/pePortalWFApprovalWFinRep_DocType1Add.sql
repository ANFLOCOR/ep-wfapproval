if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_DocType1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_DocType1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WFinRep_DocType] table.
CREATE PROCEDURE pePortalWFApprovalWFinRep_DocType1Add
    @p_WFIN_DT_C_ID smallint,
    @p_WFIN_DT_Name varchar(100),
    @p_WFIN_DT_Desc varchar(250),
    @p_WFIN_DT_Type varchar(50),
    @p_WFIN_DT_Minimum numeric(18,2),
    @p_WFIN_DT_Maximum numeric(18,2),
    @p_WFIN_DT_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WFinRep_DocType]
        (
            [WFIN_DT_C_ID],
            [WFIN_DT_Name],
            [WFIN_DT_Desc],
            [WFIN_DT_Type],
            [WFIN_DT_Minimum],
            [WFIN_DT_Maximum]
        )
    VALUES
        (
             @p_WFIN_DT_C_ID,
             @p_WFIN_DT_Name,
             @p_WFIN_DT_Desc,
             @p_WFIN_DT_Type,
             @p_WFIN_DT_Minimum,
             @p_WFIN_DT_Maximum
        )

    SET @p_WFIN_DT_ID_out = SCOPE_IDENTITY()

END

