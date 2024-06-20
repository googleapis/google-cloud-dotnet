// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Cloud.Firestore;
using System;

namespace Microsoft.Extensions.DependencyInjection;

/// <summary>
/// Provides extension methods to configure dependency injection with Firestore.
/// </summary>
public static partial class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds a singleton <see cref="FirestoreDb"/> to the <see cref="IServiceCollection"/> as customized by the <paramref name="action"/>.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> to add the singleton client to.</param>
    /// <param name="action">
    /// An action to invoke on the <see cref="FirestoreDbBuilder"/> for configuring the <see cref="FirestoreDb"/>.
    /// This is invoked before <paramref name="services"/> are used.
    /// Must not be null and must set at least <see cref="FirestoreDbBuilder.ProjectId"/>.
    /// </param>
    /// <returns>The updated <see cref="IServiceCollection"/>, for method chaining.</returns>
    public static IServiceCollection AddFirestoreDb(this IServiceCollection services, Action<FirestoreDbBuilder> action)
    {
        GaxPreconditions.CheckNotNull(action, nameof(action));
        return AddFirestoreDb(services, (_, builder) => action(builder));
    }

    /// <summary>
    /// Adds a singleton <see cref="FirestoreDb"/> to the <see cref="IServiceCollection"/> as customized by the <paramref name="action"/>.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> to add the singleton client to.</param>
    /// <param name="action">
    /// An action to invoke on the <see cref="FirestoreDbBuilder"/> for configuring the <see cref="FirestoreDb"/>.
    /// This is invoked before <paramref name="services"/> are used.
    /// Must not be null and must set at least <see cref="FirestoreDbBuilder.ProjectId"/>.
    /// </param>
    /// <returns>The updated <see cref="IServiceCollection"/>, for method chaining.</returns>
    public static IServiceCollection AddFirestoreDb(this IServiceCollection services, Action<IServiceProvider, FirestoreDbBuilder> action)
    {
        GaxPreconditions.CheckNotNull(action, nameof(action));
        return services.AddSingleton(provider =>
        {
            var builder = new FirestoreDbBuilder();
            action.Invoke(provider, builder);
            return builder.Build(provider);
        });
    }

    /// <summary>
    /// Adds a singleton <see cref="FirestoreDb"/> for with the specified project ID, using default settings to the <see cref="IServiceCollection"/>.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> to add the singleton client to.</param>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <returns>The updated <see cref="IServiceCollection"/>, for method chaining.</returns>
    public static IServiceCollection AddFirestoreDb(this IServiceCollection services, string projectId)
    {
        GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
        return services.AddFirestoreDb(builder => builder.ProjectId = projectId);
    }
}
