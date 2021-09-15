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

// Partial class constructors to preserve compatibility when migrating
// from gRPC 1.x to 2.x tooling.

using Grpc.Core;
using System;

namespace Google.Cloud.Dialogflow.V2
{
    public partial class Agents
    {
        public partial class AgentsClient
        {
            /// <summary>Creates a new client using a channel.</summary>
            /// <param name="channel">The channel to use to make remote calls.</param>
            [Obsolete("This constructor overload is present for compatibility only, and will be removed in the next major version")]
            public AgentsClient(Channel channel) : base(channel)
            {
            }
        }
    }

    public partial class Contexts
    {
        public partial class ContextsClient
        {
            /// <summary>Creates a new client using a channel.</summary>
            /// <param name="channel">The channel to use to make remote calls.</param>
            [Obsolete("This constructor overload is present for compatibility only, and will be removed in the next major version")]
            public ContextsClient(Channel channel) : base(channel)
            {
            }
        }
    }

    public partial class EntityTypes
    {
        public partial class EntityTypesClient
        {
            /// <summary>Creates a new client using a channel.</summary>
            /// <param name="channel">The channel to use to make remote calls.</param>
            [Obsolete("This constructor overload is present for compatibility only, and will be removed in the next major version")]
            public EntityTypesClient(Channel channel) : base(channel)
            {
            }
        }
    }

    public partial class Environments
    {
        public partial class EnvironmentsClient
        {
            /// <summary>Creates a new client using a channel.</summary>
            /// <param name="channel">The channel to use to make remote calls.</param>
            [Obsolete("This constructor overload is present for compatibility only, and will be removed in the next major version")]
            public EnvironmentsClient(Channel channel) : base(channel)
            {
            }
        }
    }

    public partial class Intents
    {
        public partial class IntentsClient
        {
            /// <summary>Creates a new client using a channel.</summary>
            /// <param name="channel">The channel to use to make remote calls.</param>
            [Obsolete("This constructor overload is present for compatibility only, and will be removed in the next major version")]
            public IntentsClient(Channel channel) : base(channel)
            {
            }
        }
    }

    public partial class SessionEntityTypes
    {
        public partial class SessionEntityTypesClient
        {
            /// <summary>Creates a new client using a channel.</summary>
            /// <param name="channel">The channel to use to make remote calls.</param>
            [Obsolete("This constructor overload is present for compatibility only, and will be removed in the next major version")]
            public SessionEntityTypesClient(Channel channel) : base(channel)
            {
            }
        }
    }

    public partial class Sessions
    {
        public partial class SessionsClient
        {
            /// <summary>Creates a new client using a channel.</summary>
            /// <param name="channel">The channel to use to make remote calls.</param>
            [Obsolete("This constructor overload is present for compatibility only, and will be removed in the next major version")]
            public SessionsClient(Channel channel) : base(channel)
            {
            }
        }
    }
}
