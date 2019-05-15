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

// Generated code. DO NOT EDIT!

namespace Google.Cloud.ErrorReporting.V1Beta1.SmokeTests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Api.Gax.ResourceNames;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading;
    using System.Threading.Tasks;

    public class ReportErrorsServiceSmokeTest
    {
        public static int Main(string[] args)
        {
            // Read projectId from args
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: Project ID must be passed as first argument.");
                Console.WriteLine();
                return 1;
            }
            string projectId = args[0];

            // Create client
            ReportErrorsServiceClient client = ReportErrorsServiceClient.Create();

            // Initialize request argument(s)
            ProjectName projectName = new ProjectName(projectId);
            ReportedErrorEvent @event = new ReportedErrorEvent
            {
                Message = "[MESSAGE]",
                ServiceContext = new ServiceContext
                {
                    Service = "[SERVICE]",
                },
                Context = new ErrorContext
                {
                    ReportLocation = new SourceLocation
                                     {
                                         FilePath = "path/to/file.lang",
                                         LineNumber = 42,
                                         FunctionName = "meaningOfLife",
                                     },
                },
            };

            // Call API method
            ReportErrorEventResponse response = client.ReportErrorEvent(projectName, @event);
            // Show the result
            Console.WriteLine(response);

            // Success
            Console.WriteLine("Smoke test passed OK");
            return 0;
        }
    }
}
