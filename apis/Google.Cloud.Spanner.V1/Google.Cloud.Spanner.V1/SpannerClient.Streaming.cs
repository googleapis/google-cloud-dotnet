// Copyright 2017, Google Inc. All rights reserved.
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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace Google.Cloud.Spanner.V1
{
    public partial class SpannerClient
    {
        /// <summary>
        /// Returns the effective <see cref="CallSettings"/> used for each API call.
        /// This can be used to create a modified instance of <see cref="CallSettings"/> to pass
        /// for a single API request.
        /// </summary>
        public virtual SpannerSettings Settings { get; protected set; }
    }

    /// <summary>
    /// Settings for a <see cref="SpannerClient"/>.
    /// </summary>
    public sealed partial class SpannerSettings
    {
        partial void OnCopy(SpannerSettings existing)
        {
            Logger = existing.Logger;
        }

        private ILogger _logger = NullLogger.Instance;

        /// <summary>
        /// The logger to use for operations involving this client. This property is never null.
        /// </summary>
        public ILogger Logger
        {
            get => _logger;
            set => _logger = GaxPreconditions.CheckNotNull(value, nameof(value));
        }
    }

    public partial class SpannerClientImpl
    {
        partial void OnConstruction(Spanner.SpannerClient grpcClient, SpannerSettings effectiveSettings, ClientHelper clientHelper)
        {
            Settings = effectiveSettings;
        }
    }
}
