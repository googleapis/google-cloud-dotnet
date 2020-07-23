// Copyright 2020 Google LLC
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

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Google.Cloud.Logging.Console.SampleApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger) =>
            _logger = logger;

        public void OnGet()
        {
            // Used for testing log formatting.
            _logger.LogInformation("This is information. The answer is {answer}.", 42);

            // Used for testing scopes.
            using (_logger.BeginScope("Outer scope"))
            using (_logger.BeginScope("Middle scope"))
            using (_logger.BeginScope("Inner scope"))
            {
                _logger.LogWarning("We must go deeper");
            }
        }
    }
}
