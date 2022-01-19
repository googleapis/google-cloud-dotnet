// Copyright 2022 Google LLC
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

namespace Google.Cloud.Bigtable.V2.Snippets
{
    using Google.Cloud.Bigtable.V2;
    using Google.Protobuf;
    using System.Collections.Generic;

    public sealed partial class GeneratedBigtableClientStandaloneSnippets
    {
        /// <summary>Snippet for ReadModifyWriteRow</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void ReadModifyWriteRow1()
        {
            // Create client
            BigtableClient bigtableClient = BigtableClient.Create();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            ByteString rowKey = ByteString.Empty;
            IEnumerable<ReadModifyWriteRule> rules = new ReadModifyWriteRule[]
            {
                new ReadModifyWriteRule(),
            };
            // Make the request
            ReadModifyWriteRowResponse response = bigtableClient.ReadModifyWriteRow(tableName, rowKey, rules);
        }
    }
}
