// Copyright 2022 Google LLC
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

using CloudNative.CloudEvents;
using CloudNative.CloudEvents.Protobuf;
using Google.Api.Gax.Grpc;
using Google.Protobuf.WellKnownTypes;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Eventarc.Publishing.V1;

// Partial class for adding CloudEvents SDK integration.

public partial class PublisherClient
{
    /// <summary>
    /// TODO
    /// </summary>
    public PublishEventsResponse PublishEvent(string channel, CloudEvent cloudEvent, CallSettings callSettings = null) =>
        PublishEvents(channel, new[] { cloudEvent }, callSettings);

    /// <summary>
    /// TODO
    /// </summary>
    public PublishEventsResponse PublishEvents(string channel, IEnumerable<CloudEvent> cloudEvents, CallSettings callSettings = null)
    {
        var request = new PublishEventsRequest
        {
            Channel = channel,
            Events = { cloudEvents.Select(ToAny) }
        };
        return PublishEvents(request, callSettings);
    }

    /// <summary>
    /// TODO
    /// </summary>
    public Task<PublishEventsResponse> PublishEventAsync(string channel, CloudEvent cloudEvent, CancellationToken cancellationToken) =>
        PublishEventAsync(channel, cloudEvent, CallSettings.FromCancellationToken(cancellationToken));

    /// <summary>
    /// TODO
    /// </summary>
    public Task<PublishEventsResponse> PublishEventAsync(string channel, CloudEvent cloudEvent, CallSettings callSettings = null) =>
        PublishEventsAsync(channel, new[] { cloudEvent }, callSettings);

    /// <summary>
    /// TODO
    /// </summary>
    public Task<PublishEventsResponse> PublishEventsAsync(string channel, IEnumerable<CloudEvent> cloudEvents, CancellationToken cancellationToken) =>
        PublishEventsAsync(channel, cloudEvents, CallSettings.FromCancellationToken(cancellationToken));

    /// <summary>
    /// TODO
    /// </summary>
    public async Task<PublishEventsResponse> PublishEventsAsync(string channel, IEnumerable<CloudEvent> cloudEvents, CallSettings callSettings = null)
    {
        var request = new PublishEventsRequest
        {
            Channel = channel,
            Events = { cloudEvents.Select(ToAny) }
        };
        return await PublishEventsAsync(request, callSettings).ConfigureAwait(false);
    }

    private static readonly ProtobufEventFormatter s_eventFormatter = new ProtobufEventFormatter();

    private Any ToAny(CloudEvent cloudEvent) => Any.Pack(s_eventFormatter.ConvertToProto(cloudEvent));
}
