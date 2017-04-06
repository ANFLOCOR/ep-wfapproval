if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPO_DocAttach1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPO_DocAttach1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WPO_DocAttach] table.
CREATE PROCEDURE pePortalWFApprovalWPO_DocAttach1Add
    @p_WPODA_PONum nvarchar(20),
    @p_WPODA_Desc varchar(50),
    @p_WPODA_File image,
    @p_WPODA_WAT_ID smallint,
    @p_WPODA_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WPO_DocAttach]
        (
            [WPODA_PONum],
            [WPODA_Desc],
            [WPODA_File],
            [WPODA_WAT_ID]
        )
    VALUES
        (
             @p_WPODA_PONum,
             @p_WPODA_Desc,
             @p_WPODA_File,
             @p_WPODA_WAT_ID
        )

    SET @p_WPODA_ID_out = SCOPE_IDENTITY()

END

