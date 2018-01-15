// Copyright 2017, Google LLC All rights reserved.
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

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.ResourceManager.V2.SmokeTests
{
    public class FoldersSmokeTest
    {
        public static int Main(string[] args)
        {
            // Create client
            FoldersClient client = FoldersClient.Create();

            // Initialize request argument(s)
            string query = "";

            // Call API method
            PagedEnumerable<SearchFoldersResponse, Folder> pagedResponse = client.SearchFolders(query);
            // Show the result
            foreach (var item in pagedResponse)
            {
                Console.WriteLine(item);
            }

            // Success
            Console.WriteLine("Smoke test passed OK");
            return 0;
        }
    }
}
