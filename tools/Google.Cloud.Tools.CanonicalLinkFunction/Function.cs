// Copyright 2021 Google LLC
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

using Google.Cloud.Functions.Framework;
using Google.Cloud.Tools.GenerateCanonicalLinks;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Google.Cloud.Tools.CanonicalLinkFunction
{
    /// <summary>
    /// Function to expose the logic in <see cref="Canonicalizer"/>.
    /// </summary>
    public class Function : IHttpFunction
    {
        /// <summary>
        /// Logic for your function goes here.
        /// </summary>
        /// <param name="context">The HTTP context, containing the request and the response.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task HandleAsync(HttpContext context)
        {
            var request = context.Request;
            var response = context.Response;

            string package = request.Query["package"];
            string page = request.Query["page"];

            if (string.IsNullOrEmpty(package) || string.IsNullOrEmpty(page))
            {
                response.StatusCode = 400;
                await response.WriteAsync("Error: both package and page must be specified");
            }

            string url = Canonicalizer.GetUrl(package, page);
            await response.WriteAsync(url);
        }
    }
}
