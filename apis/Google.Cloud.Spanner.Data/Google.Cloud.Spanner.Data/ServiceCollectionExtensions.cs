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

using Google.Api.Gax;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Spanner.Data;
using Grpc.Core;
using Microsoft.Extensions.Configuration;
using System;

namespace Microsoft.Extensions.DependencyInjection;

/// <summary>
/// Provides extension methods to configure dependency injection with Spanner.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds a transient service providing a <see cref="SpannerConnection"/> using the ConnectionStrings
    /// section of the configuration. If the container providers a <see cref="ChannelCredentials"/> or
    /// <see cref="GoogleCredential"/>, this will be used for the connection (with <see cref="ChannelCredentials"/> taking precedence).
    /// </summary>
    /// <param name="services">The service collection to add the transient dependency to.</param>
    /// <param name="connectionStringName">The name of the the connection string within the ConnectionStrings section of the configuration.
    /// Must not be null or empty.</param>
    /// <returns>The same service collection (<paramref name="services"/>), for method chaining.</returns>
    public static IServiceCollection AddSpannerConnection(this IServiceCollection services, string connectionStringName)
    {
        GaxPreconditions.CheckNotNullOrEmpty(connectionStringName, nameof(connectionStringName));
        return services.AddTransient(provider =>
        {
            var config = provider.GetRequiredService<IConfiguration>();
            string connectionString = config.GetConnectionString(connectionStringName);
            if (connectionString is null)
            {
                throw new ArgumentException($"Connection string '{connectionStringName}' is not present in the configuration.");
            }

            var channelCredentials = provider.GetService<ChannelCredentials>();
            if (channelCredentials is not null)
            {
                return new SpannerConnection(connectionString, channelCredentials);
            }

            var googleCredential = provider.GetService<GoogleCredential>();
            return new SpannerConnection(connectionString, googleCredential);
        });
    }
}
