// Copyright 2023 Google LLC
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

using Google.Api.Gax;
using Grpc.Core;
using System;

namespace Google.Cloud.PubSub.V1;

public abstract partial class SubscriberClient
{
    /// <summary>
    /// Settings for creating <see cref="SubscriberServiceApiClient"/>s.
    /// This type is now obsolete; please use <see cref="SubscriberClientBuilder"/> which provides an
    /// API surface consistent with other clients (as well as additional Pub/Sub-specific properties such as <see cref="SubscriberClientBuilder.ClientCount"/>).
    /// </summary>
    [Obsolete("Use PublisherClientBuilder to customize client settings.")]
    public sealed class ClientCreationSettings
    {
        /// <summary>
        /// The number of <see cref="SubscriberServiceApiClient"/>s to create and use within a <see cref="SubscriberClient"/> instance.
        /// If set, must be in the range 1 to 256 (inclusive).
        /// If <c>null</c>, defaults to the CPU count on the machine this is being executed on.
        /// </summary>
        public int? ClientCount { get; }

        /// <summary>
        /// The settings to use when creating <see cref="SubscriberServiceApiClient"/> instances.
        /// If <c>null</c>, defaults to <see cref="SubscriberServiceApiSettings.GetDefault"/>.
        /// </summary>
        public SubscriberServiceApiSettings SubscriberServiceApiSettings { get; }

        /// <summary>
        /// Credentials to use when creating <see cref="SubscriberServiceApiClient"/> instances.
        /// If <c>null</c>, defaults to using the default credentials.
        /// </summary>
        public ChannelCredentials Credentials { get; }

        /// <summary>
        /// The endpoint to use when creating <see cref="SubscriberServiceApiClient"/> instances.
        /// If <c>null</c>, defaults to <see cref="SubscriberServiceApiClient.DefaultEndpoint"/>.
        /// </summary>
        public string ServiceEndpoint { get; }

        /// <summary>
        /// Specifies how to respond to the presence of emulator environment variables.
        /// </summary>
        /// <remarks>
        /// This property defaults to <see cref="EmulatorDetection.None"/>, meaning that
        /// environment variables are ignored.
        /// </remarks>
        public EmulatorDetection EmulatorDetection { get; }

        /// <summary>
        /// Instantiate with the specified settings.
        /// </summary>
        /// <param name="clientCount">Optional.
        /// The number of <see cref="SubscriberServiceApiClient"/>s to create and use within a <see cref="SubscriberClient"/> instance.</param>
        /// <param name="subscriberServiceApiSettings">Optional. The settings to use when creating <see cref="SubscriberServiceApiClient"/> instances.</param>
        /// <param name="credentials">Optional. Credentials to use when creating <see cref="SubscriberServiceApiClient"/> instances.</param>
        /// <param name="serviceEndpoint">Optional.
        /// The <see cref="ServiceEndpoint"/> to use when creating <see cref="SubscriberServiceApiClient"/> instances.</param>
        public ClientCreationSettings(
            int? clientCount = null,
            SubscriberServiceApiSettings subscriberServiceApiSettings = null,
            ChannelCredentials credentials = null,
            string serviceEndpoint = null)
            : this(clientCount, subscriberServiceApiSettings, credentials, serviceEndpoint, EmulatorDetection.None)
        {
        }

        private ClientCreationSettings(
            int? clientCount,
            SubscriberServiceApiSettings subscriberServiceApiSettings,
            ChannelCredentials credentials,
            string serviceEndpoint,
            EmulatorDetection emulatorDetection)
        {
            ClientCount = clientCount;
            SubscriberServiceApiSettings = subscriberServiceApiSettings;
            Credentials = credentials;
            ServiceEndpoint = serviceEndpoint;
            EmulatorDetection = emulatorDetection;
        }

        /// <summary>
        /// Creates a new instance of this type with the specified emulator detection value.
        /// </summary>
        /// <param name="emulatorDetection">Determines how and whether to detect the emulator.</param>
        /// <returns>The new instance</returns>
        public ClientCreationSettings WithEmulatorDetection(EmulatorDetection emulatorDetection)
        {
            GaxPreconditions.CheckEnumValue(emulatorDetection, nameof(emulatorDetection));
            return new ClientCreationSettings(ClientCount, SubscriberServiceApiSettings, Credentials, ServiceEndpoint, emulatorDetection);
        }

        internal void Validate()
        {
            // Fairly arbitrary upper limit.
            GaxPreconditions.CheckArgumentRange(ClientCount ?? 1, nameof(ClientCount), 1, 256);
        }
    }
}
