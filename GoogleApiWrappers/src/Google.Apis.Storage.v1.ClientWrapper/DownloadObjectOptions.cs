// Copyright 2015 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

using Google.Apis.Download;
using System;
using System.Diagnostics;
using System.Globalization;

namespace Google.Apis.Storage.v1.ClientWrapper
{
    /// <summary>
    /// Options for <c>DownloadObject</c> operations.
    /// </summary>
    public class DownloadObjectOptions
    {
        /// <summary>
        /// The chunk size to use for each request.
        /// </summary>
        public int? ChunkSize;

        /// <summary>
        /// The generation to download. When not specified, the latest version
        /// is always downloaded.
        /// </summary>
        public long? Generation;

        internal void ModifyDownloader(MediaDownloader downloader)
        {
            if (ChunkSize != null)
            {
                downloader.ChunkSize = ChunkSize.Value;
            }
        }

        /// <summary>
        /// Returns the URI to use for a download request, appending any options specified by this object.
        /// </summary>
        /// <param name="baseUri">Base URI which must end with a query parameter.</param>
        /// <returns>The URI including the specified options.</returns>
        internal string GetUri(string baseUri)
        {
            Debug.Assert(!string.IsNullOrEmpty(new Uri(baseUri).Query));
            string uri = MaybeAppendParameter(baseUri, "generation", Generation);
            // Further calls would be uri = MaybeAppendParameter(baseUri, "...", SomeProperty)
            return uri;
        }        

        private static string MaybeAppendParameter(string uri, string name, long? value)
        {
            return value == null ? uri : $"{uri}&{name}={value.Value.ToString(CultureInfo.InvariantCulture)}";
        }
    }
}
