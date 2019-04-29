// Copyright 2019 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Apis.Storage.v1.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// String constants for the names of the storage classes, as used in <see cref="HmacKeyMetadata.State" />.
    /// </summary>
    public static class HmacKeyStates
    {
        /// <summary>
        /// The key is active, and can be used for signing. It cannot be deleted in this state.
        /// </summary>
        public const string Active = "ACTIVE";

        /// <summary>
        /// The key is inactive, and can be used for signing. It can be deleted.
        /// </summary>
        public const string Inactive = "INACTIVE";

        /// <summary>
        /// The key has been deleted.
        /// </summary>
        public const string Deleted = "DELETED";
    }
}
