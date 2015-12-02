// Copyright 2015 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

using Google.Apis.Download;

namespace Google.Apis.Storage.v1.ClientWrapper
{
    /// <summary>
    /// Options for <c>DownloadObject</c> operations.
    /// </summary>
    public class DownloadObjectOptions
    {
        // TODO: Retry policy? There's not an awful lot else to specify.
        // 

        /// <summary>
        /// The chunk size to use for each request.
        /// </summary>
        public int? ChunkSize;

        internal void ModifyDownloader(MediaDownloader downloader)
        {
            if (ChunkSize != null)
            {
                downloader.ChunkSize = ChunkSize.Value;
            }
        }
    }
}
