if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalWAttach_Type1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalWAttach_Type1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[WAttach_Type] table.
CREATE PROCEDURE pePortalWFApprovalWAttach_Type1Add
    @p_WAT_Name varchar(50),
    @p_WAT_Operation varchar(10),
    @p_WAT_Order smallint,
    @p_WAT_ID_out smallint output
AS
BEGIN
    INSERT
    INTO [dbo].[WAttach_Type]
        (
            [WAT_Name],
            [WAT_Operation],
            [WAT_Order]
        )
    VALUES
        (
             @p_WAT_Name,
             @p_WAT_Operation,
             @p_WAT_Order
        )

    SET @p_WAT_ID_out = SCOPE_IDENTITY()

END

