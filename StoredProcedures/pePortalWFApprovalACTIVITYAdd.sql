if exists (select * from sysobjects where id = object_id(N'pePortalWFApprovalACTIVITYAdd') and sysstat & 0xf = 4) drop procedure pePortalWFApprovalACTIVITYAdd 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Creates a new record in the [dbo].[ACTIVITY] table.
CREATE PROCEDURE pePortalWFApprovalACTIVITYAdd
    @p_USERID char(15),
    @p_CMPNYNAM char(65),
    @p_LOGINDAT datetime,
    @p_LOGINTIM datetime,
    @p_SQLSESID int,
    @p_Language_ID smallint,
    @p_IsWebClient tinyint,
    @p_IsOffline tinyint
AS
BEGIN
    INSERT
    INTO [dbo].[ACTIVITY]
        (
            [USERID],
            [CMPNYNAM]
        )
    VALUES
        (
             @p_USERID,
             @p_CMPNYNAM
        )

    -- Call UPDATE for fields that have database defaults
    IF @p_LOGINDAT IS NOT NULL
        UPDATE [dbo].[ACTIVITY] SET [LOGINDAT] = @p_LOGINDAT WHERE [USERID] = @p_USERID AND [CMPNYNAM] = @p_CMPNYNAM

    IF @p_LOGINTIM IS NOT NULL
        UPDATE [dbo].[ACTIVITY] SET [LOGINTIM] = @p_LOGINTIM WHERE [USERID] = @p_USERID AND [CMPNYNAM] = @p_CMPNYNAM

    IF @p_SQLSESID IS NOT NULL
        UPDATE [dbo].[ACTIVITY] SET [SQLSESID] = @p_SQLSESID WHERE [USERID] = @p_USERID AND [CMPNYNAM] = @p_CMPNYNAM

    IF @p_Language_ID IS NOT NULL
        UPDATE [dbo].[ACTIVITY] SET [Language_ID] = @p_Language_ID WHERE [USERID] = @p_USERID AND [CMPNYNAM] = @p_CMPNYNAM

    IF @p_IsWebClient IS NOT NULL
        UPDATE [dbo].[ACTIVITY] SET [IsWebClient] = @p_IsWebClient WHERE [USERID] = @p_USERID AND [CMPNYNAM] = @p_CMPNYNAM

    IF @p_IsOffline IS NOT NULL
        UPDATE [dbo].[ACTIVITY] SET [IsOffline] = @p_IsOffline WHERE [USERID] = @p_USERID AND [CMPNYNAM] = @p_CMPNYNAM

END

