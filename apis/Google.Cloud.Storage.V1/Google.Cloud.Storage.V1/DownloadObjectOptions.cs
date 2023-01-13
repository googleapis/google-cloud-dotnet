// Copyright 2015 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Apis.Download;
using Google.Apis.Requests;
using Google.Apis.Util;
using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// Options for <c>DownloadObject</c> operations.
    /// </summary>
    public sealed class DownloadObjectOptions
    {
        /// <summary>
        /// The chunk size to use for each request.
        /// </summary>
        public int? ChunkSize { get; set; }

        /// <summary>
        /// The generation to download. When not specified, the latest version
        /// is always downloaded.
        /// </summary>
        public long? Generation { get; set; }

        /// <summary>
        /// Precondition for download: the object is only downloaded if its generation matches the given value.
        /// </summary>
        public long? IfGenerationMatch { get; set; }

        /// <summary>
        /// Precondition for download: the object is only downloaded if its generation does not match the given value.
        /// </summary>
        public long? IfGenerationNotMatch { get; set; }

        /// <summary>
        /// Precondition for download: the object is only downloaded if its meta-generation matches the given value.
        /// </summary>
        public long? IfMetagenerationMatch { get; set; }

        /// <summary>
        /// Precondition for download: the object is only downloaded if its meta-generation does not match the given value.
        /// </summary>
        public long? IfMetagenerationNotMatch { get; set; }

        /// <summary>
        /// If non-null, limits the range of bytes of the object to download.
        /// </summary>
        public RangeHeaderValue Range { get; set; }

        /// <summary>
        /// The encryption key to use for this operation. If this property is null, the <see cref="StorageClient.EncryptionKey"/>
        /// will be used instead. Use <see cref="EncryptionKey.None"/> to remove encryption headers from this request.
        /// </summary>
        public EncryptionKey EncryptionKey { get; set; }

        /// <summary>
        /// If set, this is the ID of the project which will be billed for the request.
        /// The caller must have suitable permissions for the project being billed.
        /// </summary>
        public string UserProject { get; set; }

        /// <summary>
        /// Specifies whether or not the object's hash should be validated. If this property is null,
        /// the hash will always be validated.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This is effectively an escape hatch for situations where hash validation fails.
        /// See https://github.com/googleapis/google-cloud-dotnet/issues/1641 for background
        /// on this option. It is recommended that you leave this option unset (or use
        /// <see cref="DownloadValidationMode.Automatic"/>) unless you are knowingly
        /// downloading data for an object where hashing will fail.
        /// </para>
        /// <para>
        /// The current implementation defaults to <see cref="DownloadValidationMode.Always"/>; in a future
        /// major version the default will change to <see cref="DownloadValidationMode.Automatic"/> which will
        /// automatically ignore the hash where validation is expected to fail (even with valid data).
        /// </para>
        /// </remarks>
        public DownloadValidationMode? DownloadValidationMode { get; set; }

        internal void ModifyDownloader(MediaDownloader downloader)
        {
            if (ChunkSize != null)
            {
                downloader.ChunkSize = ChunkSize.Value;
            }
            if (Range != null)
            {
                downloader.Range = Range;
            }
        }

        internal void ModifyRequestBuilder(RequestBuilder builder)
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

            MaybeAppendParameter(builder, "generation", Generation);
            MaybeAppendParameter(builder, "ifGenerationMatch", IfGenerationMatch);
            MaybeAppendParameter(builder, "ifGenerationNotMatch", IfGenerationNotMatch);
            MaybeAppendParameter(builder, "ifMetagenerationMatch", IfMetagenerationMatch);
            MaybeAppendParameter(builder, "ifMetagenerationNotMatch", IfMetagenerationNotMatch);
            MaybeAppendParameter(builder, "userProject", UserProject);
        }

        private static void MaybeAppendParameter(RequestBuilder builder, string name, long? value)
        {
            if (value != null)
            {
                builder.AddParameter(RequestParameterType.Query, name, value.Value.ToString(CultureInfo.InvariantCulture));
            }
        }

        private static void MaybeAppendParameter(RequestBuilder builder, string name, string value)
        {
            if (value != null)
            {
                // Note: RequestBuilder performs Uri.EscapeDataString on the name and value, so we don't need to.
                builder.AddParameter(RequestParameterType.Query, name, value);
            }
        }
    }
}
