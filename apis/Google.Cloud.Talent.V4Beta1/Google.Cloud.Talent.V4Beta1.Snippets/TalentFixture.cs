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
using Xunit;

namespace Google.Cloud.Talent.V4Beta1.Snippets
{
    [CollectionDefinition(nameof(TalentFixture))]
    public class TalentFixture : CloudProjectFixtureBase, ICollectionFixture<TalentFixture>
    {
        public ProjectName ProjectName => new ProjectName(ProjectId);

        public CompanyNameOneof CreatedCompanyName { get; }

        private readonly string _companyExternalIdPrefix = IdGenerator.FromGuid(prefix: "test-", suffix: "-");

        public TalentFixture()
        {
            CreatedCompanyName = CreateSampleCompany();
        }

        public string GenerateCompanyExternalId() => IdGenerator.FromGuid(prefix: _companyExternalIdPrefix);

        private CompanyNameOneof CreateSampleCompany()
        {
            CompanyServiceClient client = CompanyServiceClient.Create();
            Company company = new Company
            {
                DisplayName = "Sample company created by fixture",
                ExternalId = GenerateCompanyExternalId(),
                Size = CompanySize.Giant
            };
            Company created = client.CreateCompany(TenantOrProjectNameOneof.From(ProjectName), company);
            return created.CompanyNameOneof;
        }

        // No clean-up: we can't do the full job here as there's a delay between the deletion of the last job for a company
        // and when that company can be deleted. Do it all in the CleanTestData project instead.
    }
}
