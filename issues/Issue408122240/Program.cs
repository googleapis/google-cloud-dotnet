// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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

using Google.Cloud.Compute.V1;
using Grpc.Core;
using lro = Google.LongRunning;
using Google.Api.Gax.Grpc;

// Run program `dotnet run project-id={your-project-id} zone={your-zone} disk-name={your-disk-name}`
namespace test_legacy_errors
{
    class Program
    {
        const string PROJECT_ID_ARG = "project-id";
        const string ZONE_ARG = "zone";
        const string DISK_NAME_ARG = "disk-name";
        static string PROJECT_ID = "";
        static string ZONE = "";
        static string DISK_NAME = "";
        // const int SIZE_GB = 10;

        static void Main(string[] args)
        {
            InitializeCommandLineArgs(args);
            InsertDisk();
        }

        private static void InitializeCommandLineArgs(string[] args)
        {
            var arguments = new Dictionary<string, string>();

            foreach (string argument in args)
            {
                string[] splitted = argument.Split('=');

                if (splitted.Length == 2)
                {
                    arguments[splitted[0]] = splitted[1];
                }
            }

            try
            {
                PROJECT_ID = arguments[PROJECT_ID_ARG];
                ZONE = arguments[ZONE_ARG];
                DISK_NAME = arguments[DISK_NAME_ARG];
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine($"You did not provide a necessary command line argument! {e.Message}");
                throw;
            }

        }

        private static void InsertDisk()
        {
            // Create client
            DisksClient disksClient = DisksClient.Create();

            // Initialize request argument(s)
            Disk newDisk = new Disk();
            newDisk.Name = DISK_NAME;
            InsertDiskRequest request = new InsertDiskRequest
            {
                Zone = ZONE,
                DiskResource = newDisk,
                RequestId = "",
                Project = PROJECT_ID,
            };

            try
            {
                // Make the request
                lro::Operation<Operation, Operation> response = disksClient.Insert(request);
                // Poll until the returned long-running operation is complete
                lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
                // Retrieve the operation result
                Operation result = completedResponse.Result;
                if (result.HasHttpErrorStatusCode)
                {
                    Console.WriteLine($"Error code detected: {result.HttpErrorStatusCode}");
                    Console.WriteLine($"Error message detected: {result.HttpErrorMessage}");
                }
                else
                {
                    Console.WriteLine($"No errors found {result}");
                }
            }
            catch (RpcException e)
            {
                Console.WriteLine("Got Exception!!");
                Console.WriteLine($"Rpc Status: {e.GetRpcStatus()}");
                Console.WriteLine($"Error Info: {e.GetErrorInfo()}");
                // GetAllStatusDetails() should be available Google.Api.Gax v4.11.0 onwards
                // Console.WriteLine($"Error Details: {e.GetAllStatusDetails()}");

                Console.WriteLine($"Inner Exception: {e.InnerException}");
            }
        }

    }
}
