CREATE PROCEDURE [rss].[usp_new_ids]
	@torrent_data [rss].[torrent_id_table_type] READONLY
AS
BEGIN
	BEGIN TRY
		SELECT ids.id
		FROM @torrent_data ids
		LEFT JOIN [rss].[video_rss] rss
			ON rss.torrent_id = ids.id
		WHERE rss.magnet IS NULL;
	END TRY
	BEGIN CATCH
		DECLARE @ErrorMessage NVARCHAR(MAX) = ERROR_MESSAGE();

		IF (@ErrorMessage NOT LIKE ('% is a required parameter%'))
			SET @ErrorMessage = @ErrorMessage + ':' + CONVERT(VARCHAR, ERROR_LINE());
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY(),
            @ErrorState INT = ERROR_STATE();
		
        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
	END CATCH
END
