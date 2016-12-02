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

using Google.Api.Gax;

namespace Google.Cloud.Datastore.V1
{
    public partial class PropertyReference
    {
        /// <summary>
        /// Creates a property reference for the given name.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        public PropertyReference(string propertyName) : this()
        {
            Name = GaxPreconditions.CheckNotNull(propertyName, nameof(propertyName));
        }
    }
}
