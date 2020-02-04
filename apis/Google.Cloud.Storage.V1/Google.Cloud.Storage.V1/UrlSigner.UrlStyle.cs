// Copyright 2020 Google LLC
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

namespace Google.Cloud.Storage.V1
{
    public sealed partial class UrlSigner
    {
        /// <summary>
        /// Specifies the style of the signed URL to be generated.
        /// </summary>
        public enum UrlStyle
        {
            /// <summary>
            /// The signed URL will be generated using the Path style:
            /// https://storage.googleapis.com/mybucket/myobject.
            /// </summary>
            PathStyle,

            /// <summary>
            /// The signed URL will be generated using the Virtual-Hosted style:
            /// https://mybucket.storage.googleapis.com/myobject.
            /// </summary>
            VirtualHostedStyle,

            /// <summary>
            /// The signed URL will be generated using a client code provided host that
            /// is associated to the given bucket:
            /// https://mydomain.tld/my-object.
            /// </summary>
            BucketBoundHostname
        }
    }
}
