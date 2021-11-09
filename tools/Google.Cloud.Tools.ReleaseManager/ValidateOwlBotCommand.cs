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

using Google.Cloud.Tools.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Google.Cloud.Tools.ReleaseManager
{
    /// <summary>
    /// Command to validate that all OwlBot-configured APIs are actually generated.
    /// </summary>
    public class ValidateOwlBotCommand : CommandBase
    {
        public ValidateOwlBotCommand() : base(
            "validate-owl-bot",
            "Validates that all OwlBot-configured APIs are generated in googleapis-gen",
            "Path to local googleapis-gen")
        {
        }

        protected override void ExecuteImpl(string[] args)
        {
            string googleapisGen = args[0];
            ApiCatalog catalog = ApiCatalog.Load();

            var apis = catalog.Apis.Where(x => x.DetermineAutoGeneratorType() == AutoGeneratorType.OwlBot).ToList();
            var ungenerated = apis.Where(api => !IsGenerated(api, googleapisGen)).ToList();
            foreach (var api in ungenerated)
            {
                Console.WriteLine($"Ungenerated API: {api.Id}");
            }
            Console.WriteLine($"Total OwlBot APIs: {apis.Count}; ungenerated APIs: {ungenerated.Count}");
        }

        private bool IsGenerated(ApiMetadata api, string googleapisGen)
        {
            var allLanguagesDirectory = Path.Combine(googleapisGen, api.ProtoPath);
            if (!Directory.Exists(allLanguagesDirectory))
            {
                return false;
            }

            var csharpDirectories = Directory.GetDirectories(allLanguagesDirectory, "*-csharp");
            return csharpDirectories.Length == 1 &&
                Directory.Exists(Path.Combine(csharpDirectories[0], api.Id));
        }
    }
}
