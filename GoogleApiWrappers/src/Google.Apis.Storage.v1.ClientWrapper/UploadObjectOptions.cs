// Copyright 2015 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

using Google.Apis.Upload;
using Google.Common;
using static Google.Apis.Storage.v1.ObjectsResource;
using static Google.Apis.Storage.v1.ObjectsResource.InsertMediaUpload;

namespace Google.Apis.Storage.v1.ClientWrapper
{
    /// <summary>
    /// Options for <c>UploadObject</c> operations.
    /// </summary>
    public class UploadObjectOptions
    {
        /// <summary>
        /// The minimum chunk size for uploading.
        /// </summary>
        public const int MinimumChunkSize = ResumableUpload<Data.Object>.MinimumChunkSize;

        private int? _chunkSize;
        /// <summary>
        /// The chunk size to use for each request. When setting to a non-null value, this
        /// must be a positive multiple of <see cref="MinimumChunkSize"/>.
        /// </summary>
        public int? ChunkSize
        {
            get { return _chunkSize; }
            set
            {
                Preconditions.CheckArgument(
                    value == null || (value.Value % MinimumChunkSize == 0 && value.Value >= 1),
                    nameof(value),
                    "Requested chunk size {0} is not a positive multiple of {1}",
                    value.Value, MinimumChunkSize);
                _chunkSize = value;
            }
        }

        /// <summary>
        /// A pre-defined ACL for simple access control scenarios.
        /// </summary>
        public PredefinedAclEnum? PredefinedAcl;

        internal void ModifyMediaUpload(InsertMediaUpload upload)
        {
            if (ChunkSize != null)
            {
                upload.ChunkSize = ChunkSize.Value;
            }
            if (PredefinedAcl != null)
            {
                upload.PredefinedAcl = PredefinedAcl.Value;
            }
        }
    }
}
