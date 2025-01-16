// Copyright 2025 Google LLC
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

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981
using gax = Google.Api.Gax;

namespace Google.Maps.Places.V1
{
    public partial class References
    {
        /// <summary><see cref="PlaceName"/>-typed view over the <see cref="Places"/> resource name property.</summary>
        public gax::ResourceNameList<PlaceName> PlacesAsPlaceNames
        {
            get => new gax::ResourceNameList<PlaceName>(Places, s => string.IsNullOrEmpty(s) ? null : PlaceName.Parse(s, allowUnparsed: true));
        }
    }
}
