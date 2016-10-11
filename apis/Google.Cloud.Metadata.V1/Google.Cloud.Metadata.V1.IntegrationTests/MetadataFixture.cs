// Copyright 2016 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using Xunit;

namespace Google.Cloud.Metadata.V1.IntegrationTests
{
    /// <summary>
    /// Fixture which is set up at the start of the test run, and torn down at the end.
    /// </summary>
    [CollectionDefinition(nameof(MetadataFixture))]
    public class MetadataFixture : IDisposable, ICollectionFixture<MetadataFixture>
    {
        private const string EmulatorEnvironmentVariable = "METADATA_EMULATOR_HOST";

        private Process emulatorProcess;

        public MetadataFixture()
        {
            var temp = new TcpListener(IPAddress.Loopback, 0);
            temp.Start();
            int port = ((IPEndPoint)temp.LocalEndpoint).Port;
            temp.Stop();

            Environment.SetEnvironmentVariable(EmulatorEnvironmentVariable, $"localhost:{port}");

            emulatorProcess = Process.Start("python", $"Emulator\\metadata_server.py --test --port {port}");
            emulatorProcess.EnableRaisingEvents = true;
            emulatorProcess.Exited += EmulatorProcess_Exited;
        }

        private void EmulatorProcess_Exited(object sender, EventArgs e)
        {
            throw new InvalidOperationException("The metadata server emulator exited with code " + emulatorProcess.ExitCode);
        }

        public void Dispose()
        {
            emulatorProcess.Exited -= EmulatorProcess_Exited;
            emulatorProcess.Kill();
        }
    }
}
