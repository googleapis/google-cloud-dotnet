// Copyright 2015 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

using Google.Apis.Upload;
using Google.Common;
using System;
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

        /// <summary>
        /// Precondition for upload: the object is only uploaded if the existing object's
        /// generation matches the given value.
        /// </summary>
        public long? IfGenerationMatch;

        /// <summary>
        /// Precondition for upload: the object is only uploaded if the existing object's
        /// generation does not match the given value.
        /// </summary>
        public long? IfGenerationNotMatch;

        /// <summary>
        /// Precondition for upload: the object is only uploaded if the existing object's
        /// meta-generation matches the given value.
        /// </summary>
        public long? IfMetagenerationMatch;

        /// <summary>
        /// Precondition for upload: the object is only uploaded if the existing object's
        /// meta-generation does not match the given value.
        /// </summary>
        public long? IfMetagenerationNotMatch;

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

            if (ChunkSize != null)
            {
                upload.ChunkSize = ChunkSize.Value;
            }
            if (PredefinedAcl != null)
            {
                upload.PredefinedAcl = PredefinedAcl.Value;
            }
            if (IfGenerationMatch != null)
            {
                upload.IfGenerationMatch = IfGenerationMatch.Value;
            }
            if (IfGenerationNotMatch != null)
            {
                upload.IfGenerationNotMatch = IfGenerationNotMatch.Value;
            }
            if (IfMetagenerationMatch != null)
            {
                upload.IfMetagenerationMatch = IfMetagenerationMatch.Value;
            }
            if (IfMetagenerationNotMatch != null)
            {
                upload.IfMetagenerationNotMatch = IfMetagenerationNotMatch.Value;
            }
        }
    }
}
