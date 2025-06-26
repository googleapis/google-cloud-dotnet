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
using Google.Cloud.Tools.Common;
using NuGet.Packaging;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using Xunit;

namespace Google.Cloud.Tools.ReleaseManager.IntegrationTests.ContainerCommands;

/// <summary>
/// Fixture for tests which run the actual Docker container (including the generator
/// etc).
/// </summary>
[CollectionDefinition(nameof(DockerCommandFixture))]
public sealed class DockerCommandFixture : ICollectionFixture<DockerCommandFixture>
{
    private const string DockerExecutable = "/usr/bin/docker";
    private const string DockerImageEnvironmentVariable = "TEST_LIBRARIAN_DOTNET_DOCKER_IMAGE";

    private readonly string _dockerHostRoot;
    private readonly string _dockerMountRoot;

    /// <summary>
    /// The directory in which to create subdirectories for tests.
    /// </summary>
    public string TempTestDirectory { get; }
    private readonly bool _enabled = false;
    private readonly string _userMapping;
    private readonly string _image;

    public DockerCommandFixture()
    {
        string image = Environment.GetEnvironmentVariable(DockerImageEnvironmentVariable);
        if (!TestEnvironment.IsLinux() || string.IsNullOrEmpty(image))
        {
            return;
        }

        // Handle Docker-in-Docker situations
        // This is the source directory which is mounted from the upstream host.
        _dockerHostRoot = Environment.GetEnvironmentVariable("KOKORO_HOST_ROOT_DIR");
        // This is the target directory which is mounted in our current context
        _dockerMountRoot = Environment.GetEnvironmentVariable("KOKORO_ROOT_DIR");

        if (string.IsNullOrEmpty(_dockerMountRoot) != string.IsNullOrEmpty(_dockerHostRoot))
        {
            throw new InvalidOperationException($"Inconsistent environment variables: {_dockerHostRoot} and {_dockerMountRoot}");
        }

        var testRoot = string.IsNullOrEmpty(_dockerMountRoot)
            ? Path.GetTempPath()
            : Path.Combine(_dockerMountRoot, "docker-tmp");
        TempTestDirectory = Path.Combine(testRoot, IdGenerator.FromDateTime(prefix: "DockerCommand-"));
        _enabled = true;
        _image = image;
        _userMapping = GetUserMapping();
    }

    public void MaybeSkip() => Skip.If(!_enabled);

    public void RunDocker(string command, string[] args, string testMount, int expectedExitCode)
    {
        // Handle Docker-in-Docker:
        // If we've been asked to mount /mounted/xyz but we know that /mounted/ is actually /host/
        // in the upstream host, we want to mount /host/xyz instead.
        if (!string.IsNullOrEmpty(_dockerMountRoot) && testMount.StartsWith(_dockerMountRoot, StringComparison.Ordinal))
        {
            testMount = $"{_dockerHostRoot}{testMount[_dockerMountRoot.Length..]}";
        }

        var psi = new ProcessStartInfo
        {
            FileName = DockerExecutable,
            ArgumentList = { "run", "--rm", _userMapping, "-v", $"{testMount}:/test", _image, command },
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = true
        };
        psi.ArgumentList.AddRange(args);
        var stdout = new StringWriter();
        var stderr = new StringWriter();

        psi.RedirectStandardOutput = true;
        psi.RedirectStandardError = true;
        psi.UseShellExecute = false;
        psi.CreateNoWindow = true;

        var proc = Process.Start(psi);
        proc.OutputDataReceived += HandleData(stdout);
        proc.ErrorDataReceived += HandleData(stderr);
        proc.BeginOutputReadLine();
        proc.BeginErrorReadLine();
        proc.WaitForExit();

        if (proc.ExitCode != expectedExitCode)
        {
            var messageBuilder = new StringBuilder();
            messageBuilder.AppendLine($"Expected exit code: {expectedExitCode}; actual exit code: {proc.ExitCode}");
            messageBuilder.AppendLine($"Docker arguments: {string.Join(", ", psi.ArgumentList)}");
            messageBuilder.AppendLine($"Standard output:\n{stdout}\n");
            messageBuilder.AppendLine($"Standard error:\n{stderr}\n");
            Assert.Fail(messageBuilder.ToString());
        }

        DataReceivedEventHandler HandleData(TextWriter writer) =>
            (object sender, DataReceivedEventArgs e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    writer.WriteLine(e.Data);
                }
            };
    }

    private static string GetUserMapping()
    {
        var userTxt = Path.GetTempFileName();
        var originalOut = Console.Out;
        try
        {
            int user = int.Parse(ExecuteId("-u"));
            int group = int.Parse(ExecuteId("-g"));
            return $"--user={user}:{group}";
        }
        finally
        {
            Console.SetOut(originalOut);
        }

        string ExecuteId(string arg)
        {
            var fakeOut = new StringWriter();
            Console.SetOut(fakeOut);
            var psi = new ProcessStartInfo { FileName = "/usr/bin/id", ArgumentList = { arg } };
            Processes.RunAndPropagateOutput(psi, "running id");
            return fakeOut.ToString();
        }
    }
}
