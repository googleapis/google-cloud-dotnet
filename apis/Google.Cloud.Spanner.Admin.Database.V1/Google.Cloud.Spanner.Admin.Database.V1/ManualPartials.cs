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

using gcscv = Google.Cloud.Spanner.Common.V1;

namespace Google.Cloud.Spanner.Admin.Database.V1
{
    // Manual partial classes that the generator doesn't create.
    public partial class Database
    {
        /// <summary>
        /// <see cref="gcscv::DatabaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::DatabaseName DatabaseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcscv::DatabaseName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }
}
