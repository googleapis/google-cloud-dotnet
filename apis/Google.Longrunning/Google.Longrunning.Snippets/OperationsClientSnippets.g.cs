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

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Longrunning.Snippets
{
    public class GeneratedOperationsClientSnippets
    {
        public async Task GetOperationAsync()
        {
            // Snippet: GetOperationAsync(string,CallSettings)
            // Additional: GetOperationAsync(string,CancellationToken)
            // Create client
            OperationsClient operationsClient = OperationsClient.Create();
            // Initialize request argument(s)
            string formattedName = OperationsClient.FormatOperationPathName("[OPERATION_PATH]");
            // Make the request
            Operation response = await operationsClient.GetOperationAsync(formattedName);
            // End snippet
        }

        public void GetOperation()
        {
            // Snippet: GetOperation(string,CallSettings)
            // Create client
            OperationsClient operationsClient = OperationsClient.Create();
            // Initialize request argument(s)
            string formattedName = OperationsClient.FormatOperationPathName("[OPERATION_PATH]");
            // Make the request
            Operation response = operationsClient.GetOperation(formattedName);
            // End snippet
        }

        public async Task ListOperationsAsync()
        {
            // Snippet: ListOperationsAsync(string,string,string,int?,CallSettings)
            // Additional: ListOperationsAsync(string,string,string,int?,CancellationToken)
            // Create client
            OperationsClient operationsClient = OperationsClient.Create();
            // Initialize request argument(s)
            string name = "";
            string filter = "";
            // Make the request
            IPagedAsyncEnumerable<ListOperationsResponse,Operation> response =
                operationsClient.ListOperationsAsync(name, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Operation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over fixed-sized pages, lazily performing RPCs as required
            int pageSize = 10;
            IAsyncEnumerable<FixedSizePage<Operation>> fixedSizePages = response.AsPages().WithFixedSize(pageSize);
            await fixedSizePages.ForEachAsync((FixedSizePage<Operation> page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operation item in page)
                {
                    Console.WriteLine(item);
                }
            });
            // End snippet
        }

        public void ListOperations()
        {
            // Snippet: ListOperations(string,string,string,int?,CallSettings)
            // Create client
            OperationsClient operationsClient = OperationsClient.Create();
            // Initialize request argument(s)
            string name = "";
            string filter = "";
            // Make the request
            IPagedEnumerable<ListOperationsResponse,Operation> response =
                operationsClient.ListOperations(name, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Operation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over fixed-sized pages, lazily performing RPCs as required
            int pageSize = 10;
            foreach (FixedSizePage<Operation> page in response.AsPages().WithFixedSize(pageSize))
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operation item in page)
                {
                    Console.WriteLine(item);
                }
            }
            // End snippet
        }

        public async Task CancelOperationAsync()
        {
            // Snippet: CancelOperationAsync(string,CallSettings)
            // Additional: CancelOperationAsync(string,CancellationToken)
            // Create client
            OperationsClient operationsClient = OperationsClient.Create();
            // Initialize request argument(s)
            string formattedName = OperationsClient.FormatOperationPathName("[OPERATION_PATH]");
            // Make the request
            await operationsClient.CancelOperationAsync(formattedName);
            // End snippet
        }

        public void CancelOperation()
        {
            // Snippet: CancelOperation(string,CallSettings)
            // Create client
            OperationsClient operationsClient = OperationsClient.Create();
            // Initialize request argument(s)
            string formattedName = OperationsClient.FormatOperationPathName("[OPERATION_PATH]");
            // Make the request
            operationsClient.CancelOperation(formattedName);
            // End snippet
        }

        public async Task DeleteOperationAsync()
        {
            // Snippet: DeleteOperationAsync(string,CallSettings)
            // Additional: DeleteOperationAsync(string,CancellationToken)
            // Create client
            OperationsClient operationsClient = OperationsClient.Create();
            // Initialize request argument(s)
            string formattedName = OperationsClient.FormatOperationPathName("[OPERATION_PATH]");
            // Make the request
            await operationsClient.DeleteOperationAsync(formattedName);
            // End snippet
        }

        public void DeleteOperation()
        {
            // Snippet: DeleteOperation(string,CallSettings)
            // Create client
            OperationsClient operationsClient = OperationsClient.Create();
            // Initialize request argument(s)
            string formattedName = OperationsClient.FormatOperationPathName("[OPERATION_PATH]");
            // Make the request
            operationsClient.DeleteOperation(formattedName);
            // End snippet
        }

    }
}
