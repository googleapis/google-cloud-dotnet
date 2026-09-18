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

using System;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// Describes the validation behavior when uploading data.
    /// </summary>
    public enum UploadValidationMode
    {
        /// <summary>
        /// The upload is not validated.
        /// </summary>
        None = 0,

        /// <summary>
        /// Obsolete. Use <see cref="RejectAndThrow"/> instead.
        /// Previously, the object was uploaded and then deleted if the hash mismatched. 
        /// The server now rejects mismatched objects automatically before creation.
        /// </summary>
        [Obsolete("DeleteAndThrow is deprecated. Use RejectAndThrow instead, as the server now rejects the object before creation.")]
        DeleteAndThrow = 2,

        /// <summary>
        /// The server validates the object hash during upload. If a hash mismatch is detected, 
        /// the server rejects the upload entirely, preventing the object from being created. 
        /// </summary>
        RejectAndThrow = 3
    }
}
