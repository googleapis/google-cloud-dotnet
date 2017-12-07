// Copyright 2017 Google Inc. All Rights Reserved.
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
using System;
using System.IO;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// Exception thrown when an upload failed validation.
    /// </summary>
    public sealed class UploadValidationException : IOException
    {
        /// <summary>
        /// The hash computed locally, in base64.
        /// </summary>
        public string ClientSideHash { get; }

        /// <summary>
        /// The uploaded object.
        /// </summary>
        public Object UploadedObject { get; }

        /// <summary>
        /// A collection of additional failures following on from this one, if any. For
        /// example, if the validation mode indicates that on failure the file should be deleted,
        /// but the deletion fails, that exception would be present here. This property
        /// is either null, or returns an <see cref="AggregateException"/> containing one or more
        /// exceptions; it will never return an empty <see cref="AggregateException"/>.
        /// </summary>
        public AggregateException AdditionalFailures { get; }
    
        /// <summary>
        /// Creates a new exception.
        /// </summary>
        /// <param name="clientSideHash">The hash of the uploaded data, as computed at the client. Must not be null.</param>
        /// <param name="uploadedObject">The object created by Google Cloud Storage. Must not be null.</param>
        /// <param name="additionalFailures">Any additional failures encountered while handling the error. May be null; if non-null,
        /// must contain at least one exception.</param>
        public UploadValidationException(string clientSideHash, Object uploadedObject, AggregateException additionalFailures)
            : base("Upload validation failed")
        {
            ClientSideHash = GaxPreconditions.CheckNotNull(clientSideHash, nameof(clientSideHash));
            UploadedObject = GaxPreconditions.CheckNotNull(uploadedObject, nameof(uploadedObject));
            AdditionalFailures = additionalFailures;
            if (additionalFailures != null)
            {
                GaxPreconditions.CheckArgument(
                    additionalFailures.InnerExceptions.Count > 0,
                    nameof(additionalFailures),
                    "Additional failures AggregateException cannot be empty");
            }
        }
    }
}
