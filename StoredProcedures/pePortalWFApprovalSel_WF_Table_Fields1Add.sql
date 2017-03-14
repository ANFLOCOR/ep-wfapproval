if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSel_WF_Table_Fields1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSel_WF_Table_Fields1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[sel_WF_Table_Fields] table.
CREATE PROCEDURE pePortalWFApprovalSel_WF_Table_Fields1Add
    @p_Row bigint,
    @p_TABLE_NAME nvarchar(128),
    @p_COLUMN_NAME nvarchar(128),
    @p_IS_NULLABLE varchar(3),
    @p_DATA_TYPE nvarchar(128)
AS
BEGIN
    INSERT
    INTO [dbo].[sel_WF_Table_Fields]
        (
            [Row],
            [TABLE_NAME],
            [COLUMN_NAME],
            [IS_NULLABLE],
            [DATA_TYPE]
        )
    VALUES
        (
             @p_Row,
             @p_TABLE_NAME,
             @p_COLUMN_NAME,
             @p_IS_NULLABLE,
             @p_DATA_TYPE
        )

END

