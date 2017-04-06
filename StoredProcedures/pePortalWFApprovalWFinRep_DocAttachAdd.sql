if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRep_DocAttachAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRep_DocAttachAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WFinRep_DocAttach] table.
CREATE PROCEDURE pePortalWFApprovalWFinRep_DocAttachAdd
    @p_FIN_Year int,
    @p_FIN_Month int,
    @p_FIN_Type nvarchar(10),
    @p_FIn_Description nvarchar(250),
    @p_FIN_File image,
    @p_FIN_Company smallint,
    @p_FIN_Status int,
    @p_FIN_File1 nvarchar(100),
    @p_FIN_RptID int,
    @p_FIN_Post bit,
    @p_FIN_RWRem nvarchar(50),
    @p_FIN_HFIN_ID int,
    @p_FIN_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WFinRep_DocAttach]
        (
            [FIN_Year],
            [FIN_Month],
            [FIN_Type],
            [FIn_Description],
            [FIN_File],
            [FIN_Company],
            [FIN_File1],
            [FIN_RptID],
            [FIN_Post],
            [FIN_RWRem],
            [FIN_HFIN_ID]
        )
    VALUES
        (
             @p_FIN_Year,
             @p_FIN_Month,
             @p_FIN_Type,
             @p_FIn_Description,
             @p_FIN_File,
             @p_FIN_Company,
             @p_FIN_File1,
             @p_FIN_RptID,
             @p_FIN_Post,
             @p_FIN_RWRem,
             @p_FIN_HFIN_ID
        )

    SET @p_FIN_ID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_FIN_Status IS NOT NULL
        UPDATE [dbo].[WFinRep_DocAttach] SET [FIN_Status] = @p_FIN_Status WHERE [FIN_ID] = @p_FIN_ID_out

END

