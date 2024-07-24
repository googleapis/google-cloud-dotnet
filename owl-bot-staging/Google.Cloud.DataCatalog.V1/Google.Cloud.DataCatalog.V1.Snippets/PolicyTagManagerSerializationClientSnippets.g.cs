// Copyright 2024 Google LLC
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

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.DataCatalog.V1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedPolicyTagManagerSerializationClientSnippets
    {
        /// <summary>Snippet for ReplaceTaxonomy</summary>
        public void ReplaceTaxonomyRequestObject()
        {
            // Snippet: ReplaceTaxonomy(ReplaceTaxonomyRequest, CallSettings)
            // Create client
            PolicyTagManagerSerializationClient policyTagManagerSerializationClient = PolicyTagManagerSerializationClient.Create();
            // Initialize request argument(s)
            ReplaceTaxonomyRequest request = new ReplaceTaxonomyRequest
            {
                TaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
                SerializedTaxonomy = new SerializedTaxonomy(),
            };
            // Make the request
            Taxonomy response = policyTagManagerSerializationClient.ReplaceTaxonomy(request);
            // End snippet
        }

        /// <summary>Snippet for ReplaceTaxonomyAsync</summary>
        public async Task ReplaceTaxonomyRequestObjectAsync()
        {
            // Snippet: ReplaceTaxonomyAsync(ReplaceTaxonomyRequest, CallSettings)
            // Additional: ReplaceTaxonomyAsync(ReplaceTaxonomyRequest, CancellationToken)
            // Create client
            PolicyTagManagerSerializationClient policyTagManagerSerializationClient = await PolicyTagManagerSerializationClient.CreateAsync();
            // Initialize request argument(s)
            ReplaceTaxonomyRequest request = new ReplaceTaxonomyRequest
            {
                TaxonomyName = TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
                SerializedTaxonomy = new SerializedTaxonomy(),
            };
            // Make the request
            Taxonomy response = await policyTagManagerSerializationClient.ReplaceTaxonomyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ImportTaxonomies</summary>
        public void ImportTaxonomiesRequestObject()
        {
            // Snippet: ImportTaxonomies(ImportTaxonomiesRequest, CallSettings)
            // Create client
            PolicyTagManagerSerializationClient policyTagManagerSerializationClient = PolicyTagManagerSerializationClient.Create();
            // Initialize request argument(s)
            ImportTaxonomiesRequest request = new ImportTaxonomiesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                InlineSource = new InlineSource(),
            };
            // Make the request
            ImportTaxonomiesResponse response = policyTagManagerSerializationClient.ImportTaxonomies(request);
            // End snippet
        }

        /// <summary>Snippet for ImportTaxonomiesAsync</summary>
        public async Task ImportTaxonomiesRequestObjectAsync()
        {
            // Snippet: ImportTaxonomiesAsync(ImportTaxonomiesRequest, CallSettings)
            // Additional: ImportTaxonomiesAsync(ImportTaxonomiesRequest, CancellationToken)
            // Create client
            PolicyTagManagerSerializationClient policyTagManagerSerializationClient = await PolicyTagManagerSerializationClient.CreateAsync();
            // Initialize request argument(s)
            ImportTaxonomiesRequest request = new ImportTaxonomiesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                InlineSource = new InlineSource(),
            };
            // Make the request
            ImportTaxonomiesResponse response = await policyTagManagerSerializationClient.ImportTaxonomiesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ExportTaxonomies</summary>
        public void ExportTaxonomiesRequestObject()
        {
            // Snippet: ExportTaxonomies(ExportTaxonomiesRequest, CallSettings)
            // Create client
            PolicyTagManagerSerializationClient policyTagManagerSerializationClient = PolicyTagManagerSerializationClient.Create();
            // Initialize request argument(s)
            ExportTaxonomiesRequest request = new ExportTaxonomiesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TaxonomiesAsTaxonomyNames =
                {
                    TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
                },
                SerializedTaxonomies = false,
            };
            // Make the request
            ExportTaxonomiesResponse response = policyTagManagerSerializationClient.ExportTaxonomies(request);
            // End snippet
        }

        /// <summary>Snippet for ExportTaxonomiesAsync</summary>
        public async Task ExportTaxonomiesRequestObjectAsync()
        {
            // Snippet: ExportTaxonomiesAsync(ExportTaxonomiesRequest, CallSettings)
            // Additional: ExportTaxonomiesAsync(ExportTaxonomiesRequest, CancellationToken)
            // Create client
            PolicyTagManagerSerializationClient policyTagManagerSerializationClient = await PolicyTagManagerSerializationClient.CreateAsync();
            // Initialize request argument(s)
            ExportTaxonomiesRequest request = new ExportTaxonomiesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TaxonomiesAsTaxonomyNames =
                {
                    TaxonomyName.FromProjectLocationTaxonomy("[PROJECT]", "[LOCATION]", "[TAXONOMY]"),
                },
                SerializedTaxonomies = false,
            };
            // Make the request
            ExportTaxonomiesResponse response = await policyTagManagerSerializationClient.ExportTaxonomiesAsync(request);
            // End snippet
        }
    }
}
