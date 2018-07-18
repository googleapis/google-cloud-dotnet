// Copyright 2018 Google LLC
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
using gax = Google.Api.Gax;

namespace Google.Cloud.Location
{
    public partial class GetLocationRequest
    {
        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gax::IResourceName NameAsResourceName
        {
            get { return string.IsNullOrEmpty(Name) ? null : gax::UnknownResourceName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }
    }

    public partial class ListLocationsRequest
    {
        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gax::IResourceName NameAsResourceName
        {
            get { return string.IsNullOrEmpty(Name) ? null : gax::UnknownResourceName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }
    }

    public partial class Location
    {
        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gax::IResourceName NameAsResourceName
        {
            get { return string.IsNullOrEmpty(Name) ? null : gax::UnknownResourceName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }
    }
}