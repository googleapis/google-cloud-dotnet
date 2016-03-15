// Copyright 2016 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

using Google.Api.Gax;
using Grpc.Core;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using static Google.Pubsub.V1.IntegrationTests.PubsubTestHelpers;

namespace Google.Pubsub.V1.IntegrationTests
{
    // TODO: Move this to a testing package, and create some basic functionality in Google.Api.Gax.Testing.

    /// <summary>
    /// Test fixture which brings up a Pubsub emulator.
    /// </summary>
    public class PubsubEmulatorFixture : IDisposable
    {
        // TODO: Pick a free port automatically.
        private const int Port = 47364;

        public PublisherClient Publisher { get; }
        public SubscriberClient Subscriber { get; }
        public SimplePubsub SimplePubsub { get; }

        private readonly int port;
        private readonly Process process;

        public PubsubEmulatorFixture()
        {
            var psi = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/c \"gcloud beta emulators pubsub start --host-port localhost:{Port}\"",
                UseShellExecute = false
                // TODO: Work out what to do with the IO. Currently it just ends up in the same console,
                // when running dnx test from the command line.
            };
            process = Process.Start(psi);
            var endpoint = new ServiceEndpointSettings { Host = "localhost", Port = Port };
            Publisher = PublisherClient.CreateFromCredentials(ChannelCredentials.Insecure, serviceEndpointSettings: endpoint);
            Subscriber = SubscriberClient.CreateFromCredentials(ChannelCredentials.Insecure, serviceEndpointSettings: endpoint);
            SimplePubsub = new SimplePubsub(CreateRandomId(), Publisher, Subscriber);
        }

        public void Dispose()
        {
            PostCommand("/shutdown");
            process.WaitForExit();
        }

        public void Reset()
        {
            PostCommand("/reset");
        }

        private void PostCommand(string path)
        {
            using (var client = new HttpClient())
            {
                Task.Run(async () =>
                {
                    try
                    {
                        await client.PostAsync($"http://localhost:{Port}{path}", new StringContent(""));
                    }
                    catch (HttpRequestException e)
                    {
                        Console.WriteLine($"Command {path} received exception {e.Message}");
                    }
                }).Wait();
            }
        }
    }
}
