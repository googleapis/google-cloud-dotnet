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

using Google.Cloud.Tools.Common;
using System;

namespace Google.Cloud.Tools.ReleaseManager
{
    public sealed class ShowVersionCommand : CommandBase
    {
        public ShowVersionCommand()
            : base("show-version", "Show the current version (in apis.json) of the specified package", "id")
        {
        }

        protected override int ExecuteImpl(string[] args)
        {
            string id = args[0];

            var catalog = ApiCatalog.Load(RootLayout);
            var api = catalog[id];

            Console.WriteLine($"Current version of {id} in the API catalog: {api.Version}");
            return 0;
        }
    }
}
