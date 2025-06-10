// Copyright 2025 Google LLC
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

using Google.Cloud.ClientTesting;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Xunit;

namespace Google.Cloud.Tools.ReleaseManager.IntegrationTests.ContainerCommands;

[CollectionDefinition(nameof(ContainerCommandFixture))]
public sealed class ContainerCommandFixture : ICollectionFixture<ContainerCommandFixture>
{
    private static readonly bool DeleteContextDirectoriesOnExit = false;

    private readonly List<ContainerCommandTestContext> _contexts;
    private readonly string _contextRoot;

    public ContainerCommandFixture()
    {
        _contexts = [];
        _contextRoot = Path.Combine(Path.GetTempPath(), IdGenerator.FromDateTime("ContainerCommandFixture"));
    }

    public ContainerCommandTestContext CreateContext([CallerFilePath] string callerFile = null, [CallerMemberName] string callerMember = null)
    {
        var file = Path.GetFileNameWithoutExtension(callerFile);
        var context = new ContainerCommandTestContext(Path.Combine(_contextRoot, $"{file}-{callerMember}"));
        _contexts.Add(context);
        return context;
    }

    public void Dispose()
    {
        _contexts.ForEach(c => c.Dispose());
        if (DeleteContextDirectoriesOnExit)
        {
            Directory.Delete(_contextRoot, true);
        }
    }
}
