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

using Google.Api.Gax;
using Google.Cloud.Diagnostics.Common;
using Google.Cloud.Logging.V2;
using Microsoft.Extensions.Logging;

namespace Google.Cloud.Diagnostics.AspNetCore
{
    public static class GoogleLoggerFactoryExtensions
    {
        public static ILoggerFactory AddGoogle(this ILoggerFactory factory, string projectId,
            LoggerOptions options = null, LoggingServiceV2Client client = null)
        {
            GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            client = client ?? LoggingServiceV2Client.Create();
            options = options ?? LoggerOptions.Create();

            GrpcLogConsumer grpcConsumer = new GrpcLogConsumer(client);
            IConsumer<LogEntry> consumer = ConsumerFactory<LogEntry>.GetConsumer(
                grpcConsumer, LogEntrySizer.Instance, options.BufferOptions);
            GoogleLoggerProvider provider = new GoogleLoggerProvider(consumer, projectId, options.LogLevel);

            factory.AddProvider(provider);
            return factory;
        }
    }
}
