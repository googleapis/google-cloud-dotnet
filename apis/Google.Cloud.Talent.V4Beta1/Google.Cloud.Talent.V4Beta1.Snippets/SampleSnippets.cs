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
using Google.Cloud.ClientTesting;
using System;
using Xunit;
using static Google.Cloud.Talent.V4Beta1.Job.Types;

namespace Google.Cloud.Talent.V4Beta1.Snippets
{
    [SnippetOutputCollector]
    [Collection(nameof(TalentFixture))]
    public class SampleSnippets
    {
        private readonly TalentFixture _fixture;

        public SampleSnippets(TalentFixture fixture) => _fixture = fixture;

        [Fact(Skip = "Requires additional set-up")]
        public void CreateCompany()
        {
            string projectId = _fixture.ProjectId;
            string externalId = _fixture.GenerateCompanyExternalId();

            // Sample: CreateCompany
            CompanyServiceClient client = CompanyServiceClient.Create();
            Company company = new Company
            {
                DisplayName = "Sample company",
                ExternalId = externalId,
                Size = CompanySize.Medium
            };
            ProjectName parent = ProjectName.FromProject(projectId);
            Company created = client.CreateCompany(parent, company);
            Console.WriteLine($"Created company with resource name {created.Name}");
            // End sample
        }

        [Fact(Skip = "Requires additional set-up")]
        public void CreateJob()
        {
            string projectId = _fixture.ProjectId;
            CompanyName companyName = _fixture.CreatedCompanyName;
            string requisitionId = IdGenerator.FromGuid();

            // Sample: CreateJob
            JobServiceClient client = JobServiceClient.Create();
            Job job = new Job
            {
                ApplicationInfo = new ApplicationInfo
                {
                    Instruction = "See company web site"
                },
                CompanyAsCompanyName = companyName,
                Description = "Company CEO, responsible for everything in the company.",
                RequisitionId = requisitionId,
                Title = "CEO"
            };
            ProjectName parent = ProjectName.FromProject(projectId);
            Job created = client.CreateJob(parent, job);
            Console.WriteLine($"Created job with resource name {created.Name}");
            // End sample
        }
    }
}
