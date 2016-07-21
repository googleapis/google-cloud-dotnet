// Copyright 2016 Google Inc. All Rights Reserved.
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

using System.Collections.Generic;

namespace Google.Cloud.Metadata.V1
{
    /// <summary>
    /// Metadata for a service account associated with a Google Compute Engine VM instance.
    /// </summary>
    /// <seealso cref="InstanceMetadata.ServiceAccounts"/>
    public sealed class ServiceAccountMetadata
    {
        /// <summary>
        /// Gets the collection of aliases for the service account.
        /// </summary>
        public IReadOnlyList<string> Aliases { get; }

        /// <summary>
        /// Gets the email address of the service account.
        /// </summary>
        public string Email { get; }

        /// <summary>
        /// Gets the collection of scoped available to the service account.
        /// </summary>
        public IReadOnlyList<string> Scopes { get; }
    }
}
