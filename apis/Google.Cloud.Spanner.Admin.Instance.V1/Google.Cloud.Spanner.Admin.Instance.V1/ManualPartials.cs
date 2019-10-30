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
using gcsaiv = Google.Cloud.Spanner.Admin.Instance.V1;

namespace Google.Cloud.Spanner.Admin.Instance.V1
{
    // Manual partial classes that the generator doesn't create.
    public partial class Instance
    {
        /// <summary>
        /// <see cref="gcscv::InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::InstanceName InstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcscv::InstanceName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gcsaiv::InstanceConfigName"/>-typed view over the <see cref="Config"/> resource name property.
        /// </summary>
        public gcsaiv::InstanceConfigName ConfigAsInstanceConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsaiv::InstanceConfigName.Parse(Config);
            set => Name = value?.ToString() ?? "";
        }
    }
}
