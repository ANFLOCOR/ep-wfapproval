if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWFinRepNGP_DocAttachAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWFinRepNGP_DocAttachAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WFinRepNGP_DocAttach] table.
CREATE PROCEDURE pePortalWFApprovalWFinRepNGP_DocAttachAdd
    @p_WFRCDNGP_Year int,
    @p_WFRCDNGP_Month int,
    @p_WFRCDNGP_Type nvarchar(10),
    @p_WFRCDNGP_Description nvarchar(250),
    @p_WFRCDNGP_File image,
    @p_WFRCDNGP_Company smallint,
    @p_WFRCDNGP_Status int,
    @p_WFRCDNGP_File1 nvarchar(100),
    @p_WFRCDNGP_RptID int,
    @p_WFRCDNGP_Post bit,
    @p_WFRCDNGP_RWRem nvarchar(50),
    @p_WFRCDNGP_WFRCHNGP_ID int,
    @p_WFRCDNGP_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WFinRepNGP_DocAttach]
        (
            [WFRCDNGP_Year],
            [WFRCDNGP_Month],
            [WFRCDNGP_Type],
            [WFRCDNGP_Description],
            [WFRCDNGP_File],
            [WFRCDNGP_Company],
            [WFRCDNGP_Status],
            [WFRCDNGP_File1],
            [WFRCDNGP_RptID],
            [WFRCDNGP_Post],
            [WFRCDNGP_RWRem],
            [WFRCDNGP_WFRCHNGP_ID]
        )
    VALUES
        (
             @p_WFRCDNGP_Year,
             @p_WFRCDNGP_Month,
             @p_WFRCDNGP_Type,
             @p_WFRCDNGP_Description,
             @p_WFRCDNGP_File,
             @p_WFRCDNGP_Company,
             @p_WFRCDNGP_Status,
             @p_WFRCDNGP_File1,
             @p_WFRCDNGP_RptID,
             @p_WFRCDNGP_Post,
             @p_WFRCDNGP_RWRem,
             @p_WFRCDNGP_WFRCHNGP_ID
        )

    SET @p_WFRCDNGP_ID_out = SCOPE_IDENTITY()

END

