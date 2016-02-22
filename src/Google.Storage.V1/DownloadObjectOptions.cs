// Copyright 2015 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

using Google.Apis.Download;
using System;
using System.Diagnostics;
using System.Globalization;

namespace Google.Storage.V1
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

        /// <summary>
        /// Precondition for download: the object is only downloaded if its generation matches the given value.
        /// </summary>
        public long? IfGenerationMatch;

        /// <summary>
        /// Precondition for download: the object is only uploaded if its generation does not match the given value.
        /// </summary>
        public long? IfGenerationNotMatch;

        /// <summary>
        /// Precondition for download: the object is only uploaded if its meta-generation matches the given value.
        /// </summary>
        public long? IfMetagenerationMatch;

        /// <summary>
        /// Precondition for download: the object is only uploaded if its meta-generation does not match the given value.
        /// </summary>
        public long? IfMetagenerationNotMatch;

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
            // Note the use of ArgumentException here, as this will basically be the result of invalid
            // options being passed to a public method.
            if (IfGenerationMatch != null && IfGenerationNotMatch != null)
            {
                throw new ArgumentException($"Cannot specify {nameof(IfGenerationMatch)} and {nameof(IfGenerationNotMatch)} in the same options", "options");
            }
            if (IfMetagenerationMatch != null && IfMetagenerationNotMatch != null)
            {
                throw new ArgumentException($"Cannot specify {nameof(IfMetagenerationMatch)} and {nameof(IfMetagenerationNotMatch)} in the same options", "options");
            }

            Debug.Assert(!string.IsNullOrEmpty(new Uri(baseUri).Query));
            string uri = MaybeAppendParameter(baseUri, "generation", Generation);
            uri = MaybeAppendParameter(uri, "ifGenerationMatch", IfGenerationMatch);
            uri = MaybeAppendParameter(uri, "ifGenerationNotMatch", IfGenerationNotMatch);
            uri = MaybeAppendParameter(uri, "ifMetagenerationMatch", IfMetagenerationMatch);
            uri = MaybeAppendParameter(uri, "ifMetagenerationNotMatch", IfMetagenerationNotMatch);
            return uri;
        }        

        private static string MaybeAppendParameter(string uri, string name, long? value)
        {
            return value == null ? uri : $"{uri}&{name}={value.Value.ToString(CultureInfo.InvariantCulture)}";
        }
    }
}
