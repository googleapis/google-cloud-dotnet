// Copyright 2025 Google LLC
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
    // [START css_v1_generated_CssProductsService_GetCssProduct_async_flattened_resourceNames]
    using Google.Shopping.Css.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedCssProductsServiceClientSnippets
    {
        /// <summary>Snippet for GetCssProductAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task GetCssProductResourceNamesAsync()
        {
            // Create client
            CssProductsServiceClient cssProductsServiceClient = await CssProductsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CssProductName name = CssProductName.FromAccountCssProduct("[ACCOUNT]", "[CSS_PRODUCT]");
            // Make the request
            CssProduct response = await cssProductsServiceClient.GetCssProductAsync(name);
        }
    }
    // [END css_v1_generated_CssProductsService_GetCssProduct_async_flattened_resourceNames]
}
