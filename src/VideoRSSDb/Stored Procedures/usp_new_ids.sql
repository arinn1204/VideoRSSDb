CREATE PROCEDURE [rss].[usp_new_ids]
	@torrent_data [rss].[torrent_id_table_type] READONLY
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION


		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		DECLARE @ErrorMessage NVARCHAR(MAX) = ERROR_MESSAGE();

		IF (@ErrorMessage NOT LIKE ('% is a required parameter%'))
			SET @ErrorMessage = @ErrorMessage + ':' + CONVERT(VARCHAR, ERROR_LINE());
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY(),
            @ErrorState INT = ERROR_STATE();
		
        ROLLBACK TRANSACTION;
        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
	END CATCH
END
