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

using Google.Api.Gax;
using Google.Apis.Upload;
using System;
using static Google.Apis.Storage.v1.ObjectsResource;
using static Google.Apis.Storage.v1.ObjectsResource.InsertMediaUpload;

using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// Options for <c>UploadObject</c> operations.
    /// </summary>
    public sealed class UploadObjectOptions
    {
        /// <summary>
        /// The minimum chunk size for uploading.
        /// </summary>
        public const int MinimumChunkSize = ResumableUpload<Object>.MinimumChunkSize;

        internal static UploadValidationMode DefaultValidationMode { get; } = V1.UploadValidationMode.DeleteAndThrow;

        /// <summary>
        /// Precondition for upload: the object is only uploaded if the existing object's
        /// generation matches the given value.
        /// </summary>
        public long? IfGenerationMatch { get; set; }

        /// <summary>
        /// Precondition for upload: the object is only uploaded if the existing object's
        /// generation does not match the given value.
        /// </summary>
        public long? IfGenerationNotMatch { get; set; }

        /// <summary>
        /// Precondition for upload: the object is only uploaded if the existing object's
        /// meta-generation matches the given value.
        /// </summary>
        public long? IfMetagenerationMatch { get; set; }

        /// <summary>
        /// Precondition for upload: the object is only uploaded if the existing object's
        /// meta-generation does not match the given value.
        /// </summary>
        public long? IfMetagenerationNotMatch { get; set; }

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
                GaxPreconditions.CheckArgument(
                    value == null || (value.Value % MinimumChunkSize == 0 && value.Value >= 1),
                    nameof(value),
                    "Requested chunk size {0} is not a positive multiple of {1}",
                    // Don't use value.Value - we don't want to break if value is null!
                    value ?? 0, MinimumChunkSize);
                _chunkSize = value;
            }
        }

        /// <summary>
        /// A pre-defined ACL for simple access control scenarios.
        /// </summary>
        public PredefinedObjectAcl? PredefinedAcl { get; set; }

        /// <summary>
        /// The projection of the uploaded object to retrieve.
        /// </summary>
        public Projection? Projection { get; set; }

        /// <summary>
        /// The customer-supplied encryption key to use for this operation. If this property is null, the <see cref="StorageClient.EncryptionKey"/>
        /// will be used instead. Use <see cref="EncryptionKey.None"/> to remove encryption headers from this request.
        /// </summary>
        public EncryptionKey EncryptionKey { get; set; }

        /// <summary>
        /// The name of the Cloud KMS key to use to encrypt the object.
        /// </summary>
        /// <remarks>
        /// Currently, either customer-supplied encryption or a Cloud KMS key can be used, but not both.
        /// If this property is null and customer-supplied encryption is not being used,
        /// the bucket encryption defaults will be used to determine the encryption for the object.
        /// If this property is non-null and the client object has a default encryption key, the <see cref="EncryptionKey"/> property
        /// of this options object must be set to <see cref="EncryptionKey.None"/> to make the intention clear.
        /// </remarks>
        public string KmsKeyName { get; set; }

        /// <summary>
        /// If set, this is the ID of the project which will be billed for the request.
        /// The caller must have suitable permissions for the project being billed.
        /// </summary>
        public string UserProject { get; set; }

        /// <summary>
        /// Specifies how the upload should be validated for data integrity.
        /// If this property is null, this is equivalent to <see cref="UploadValidationMode.DeleteAndThrow"/>.
        /// </summary>
        /// <remarks>
        /// The hash is only validated at the end of the upload, after the object has been created.
        /// An exception is thrown if it's incorrect, but the object will still exist unless
        /// the validation action deletes it.
        /// </remarks>
        public UploadValidationMode? UploadValidationMode { get; set; }

        /// <summary>
        /// If set, an Origin header is included when initiating the resumable upload. This allows for Cross-Origin
        /// Resource Sharing, as documented at https://cloud.google.com/storage/docs/cross-origin.
        /// </summary>
        public string Origin { get; set; }

        internal void ModifyMediaUpload(CustomMediaUpload upload)
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
                upload.PredefinedAcl =
                    GaxPreconditions.CheckEnumValue((PredefinedAclEnum) PredefinedAcl, nameof(PredefinedAcl));
            }
            if (IfGenerationMatch != null)
            {
                upload.IfGenerationMatch = IfGenerationMatch;
            }
            if (IfGenerationNotMatch != null)
            {
                upload.IfGenerationNotMatch = IfGenerationNotMatch;
            }
            if (IfMetagenerationMatch != null)
            {
                upload.IfMetagenerationMatch = IfMetagenerationMatch;
            }
            if (IfMetagenerationNotMatch != null)
            {
                upload.IfMetagenerationNotMatch = IfMetagenerationNotMatch;
            }
            if (Projection != null)
            {
                upload.Projection = GaxPreconditions.CheckEnumValue((ProjectionEnum) Projection, nameof(Projection));
            }
            if (UserProject != null)
            {
                upload.UserProject = UserProject;
            }

            // Note: specifying this and EncryptionKey as non-null/non-None is invalid, but that's checked in StorageClientImpl.
            if (KmsKeyName != null)
            {
                upload.KmsKeyName = KmsKeyName;
            }
            if (Origin != null)
            {
                upload.Options.ModifySessionInitiationRequest += message => message.Headers.Add("Origin", Origin);
            }
        }
    }
}
