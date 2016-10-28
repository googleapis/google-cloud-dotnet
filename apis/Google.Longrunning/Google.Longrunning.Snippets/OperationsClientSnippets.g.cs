// Copyright 2016, Google Inc. All rights reserved.
//
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are
// met:
//
//     * Redistributions of source code must retain the above copyright
// notice, this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above
// copyright notice, this list of conditions and the following disclaimer
// in the documentation and/or other materials provided with the
// distribution.
//     * Neither the name of Google Inc. nor the names of its
// contributors may be used to endorse or promote products derived from
// this software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
// A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
// OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
// SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
// LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
// DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
// THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
// OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Longrunning;
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
