if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalSysPages1Add') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalSysPages1Add 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[SysPages] table.
CREATE PROCEDURE pePortalWFApprovalSysPages1Add
    @p_PageName varchar(100),
    @p_ParentID int,
    @p_Level int,
    @p_URL varchar(500),
    @p_DateCreated datetime,
    @p_Sorting varchar(50),
    @p_isDisplay bit,
    @p_Checked bit,
    @p_SystemID int,
    @p_PageID_out int output
AS
BEGIN
    INSERT
    INTO [dbo].[SysPages]
        (
            [PageName],
            [ParentID],
            [Level],
            [URL],
            [Sorting],
            [isDisplay],
            [Checked],
            [SystemID]
        )
    VALUES
        (
             @p_PageName,
             @p_ParentID,
             @p_Level,
             @p_URL,
             @p_Sorting,
             @p_isDisplay,
             @p_Checked,
             @p_SystemID
        )

    SET @p_PageID_out = SCOPE_IDENTITY()

    -- Call UPDATE for fields that have database defaults
    IF @p_DateCreated IS NOT NULL
        UPDATE [dbo].[SysPages] SET [DateCreated] = @p_DateCreated WHERE [PageID] = @p_PageID_out

END

