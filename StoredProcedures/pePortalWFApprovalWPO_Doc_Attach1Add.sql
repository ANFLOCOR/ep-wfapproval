if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWPO_Doc_Attach1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWPO_Doc_Attach1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WPO_Doc_Attach] table.
CREATE PROCEDURE pePortalWFApprovalWPO_Doc_Attach1Add
    @p_WPODA_PONo nvarchar(20),
    @p_WPODA_Desc varchar(50),
    @p_WPODA_File image,
    @p_WPODA_CMPNY smallint,
    @p_WPODA_ID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[WPO_Doc_Attach]
        (
            [WPODA_PONo],
            [WPODA_Desc],
            [WPODA_File],
            [WPODA_CMPNY]
        )
    VALUES
        (
             @p_WPODA_PONo,
             @p_WPODA_Desc,
             @p_WPODA_File,
             @p_WPODA_CMPNY
        )

    SET @p_WPODA_ID_out = SCOPE_IDENTITY()

END

