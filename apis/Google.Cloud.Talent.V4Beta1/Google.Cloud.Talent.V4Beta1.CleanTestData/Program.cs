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

using Google.Api.Gax.ResourceNames;
using Grpc.Core;
using System;
using System.Linq;

namespace Google.Cloud.Talent.V4Beta1.CleanTestData
{
    class Program
    {
        private static int Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.Error.WriteLine("Specify the project ID as the only command line argument");
                return 1;
            }
            ProjectName projectName = new ProjectName(args[0]);
            var companyClient = CompanyServiceClient.Create();
            var jobClient = JobServiceClient.Create();
            var parentName = TenantOrProjectNameOneof.From(projectName);

            var testCompanies = companyClient.ListCompanies(parentName)
                .Where(cn => cn.ExternalId.StartsWith("test-"))
                .Select(c => c.CompanyNameOneof)
                .ToList();
            Console.WriteLine($"Companies to delete: {testCompanies.Count}");

            foreach (var companyName in testCompanies)
            {
                var jobs = jobClient.ListJobs(parentName, $"companyName=\"{companyName}\"").ToList();
                Console.WriteLine($"Jobs for company {companyName}: {jobs.Count}");
                foreach (var job in jobs)
                {
                    try
                    {
                        jobClient.DeleteJob(job.JobNameOneof);
                    }
                    catch (RpcException e)
                    {
                        Console.WriteLine($"Failed to delete job {job.Name}: {e.Message}");
                    }
                }

                try
                {
                    companyClient.DeleteCompany(companyName);
                }
                catch (RpcException e)
                {
                    Console.WriteLine($"Failed to delete company {companyName}: {e.Message}");
                }
            }
            return 0;
        }
    }
}
