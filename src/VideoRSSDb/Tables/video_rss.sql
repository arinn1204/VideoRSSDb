﻿CREATE TABLE [rss].[video_rss](
	[torrent_id] VARCHAR(64) PRIMARY KEY NOT NULL,
	[torrent_name] VARCHAR(512) NOT NULL,
	[time_added] DATETIME2(7) NOT NULL,
	[magnet] VARCHAR(1024) NOT NULL
);