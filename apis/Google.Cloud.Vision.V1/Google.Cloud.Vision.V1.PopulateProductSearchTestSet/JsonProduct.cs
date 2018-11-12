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

using System.Collections.Generic;

namespace Google.Cloud.Vision.V1.PopulateProductSearchTestSet
{
    /// <summary>
    /// A product as represented in the JSON file used to populate the product set
    /// </summary>
    public class JsonProduct
    {
        /// <summary>
        /// Name of the file containing the image for the product.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Any labels to include on the image
        /// </summary>
        public Dictionary<string, string> Labels { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// The ID to use for the product.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The display name of the product
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// The description of the product
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The category of the product
        /// </summary>
        public string Category { get; set; }
    }
}
