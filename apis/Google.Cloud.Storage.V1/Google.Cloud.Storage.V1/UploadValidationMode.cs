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
        /// The hash of the data is computed while uploading, and
        /// if the resulting object has a different hash, an <see cref="UploadValidationException"/>
        /// is thrown, but the object remains present in Storage.
        /// </summary>
        ThrowOnly = 1,

        /// <summary>
        /// The hash of the data is computed while uploading, and
        /// if the resulting object has a different hash, an attempt is made to delete the object.
        /// Whether the deletion fails or not, an <see cref="UploadValidationException"/>
        /// is thrown. If the deletion fails, that failure can be examined via
        /// <see cref="UploadValidationException.AdditionalFailures"/>
        /// </summary>
        DeleteAndThrow = 2
    }
}
