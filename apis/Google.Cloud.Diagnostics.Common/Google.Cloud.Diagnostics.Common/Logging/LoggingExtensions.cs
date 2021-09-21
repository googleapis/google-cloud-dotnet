// Copyright 2021 Google LLC
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

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Extension methods for registering Google Cloud Logging.
    /// </summary>
    public static class LoggingExtensions
    {
        /// <summary>
        /// Adds a <see cref="GoogleLoggerProvider"/> for <see cref="GoogleLogger"/>s.
        /// </summary>
        public static ILoggingBuilder AddGoogle(this ILoggingBuilder builder, LoggingServiceOptions options = null)
        {
            builder.Services.AddSingleton<ILoggerProvider, GoogleLoggerProvider>(sp => GoogleLoggerProvider.Create(sp, options));
            return builder;
        }

        /// <summary>
        /// Adds a <see cref="ILogEntryLabelProvider"/> of type <typeparamref name="T"/> to the service collection instance
        /// as a singleton.
        /// </summary>
        /// <typeparam name="T">The type of the <see cref="ILogEntryLabelProvider"/> implementation.</typeparam>
        /// <param name="services">The <see cref="IServiceCollection"/> instance.</param>
        /// <returns>The <see cref="IServiceCollection"/> instance.</returns>
        public static IServiceCollection AddLogEntryLabelProviderSingleton<T>(this IServiceCollection services)
            where T : class, ILogEntryLabelProvider
            => services.AddSingleton<ILogEntryLabelProvider, T>();

        /// <summary>
        /// Adds a <see cref="ILogEntryLabelProvider"/> of type <typeparamref name="T"/> to the service collection instance
        /// as a singleton.
        /// </summary>
        /// <typeparam name="T">The type of the <see cref="ILogEntryLabelProvider"/> implementation.</typeparam>
        /// <param name="services">The <see cref="IServiceCollection"/> instance.</param>
        /// <param name="implementationFactory">The factory that creates the service.</param>
        /// <returns>The <see cref="IServiceCollection"/> instance.</returns>
        public static IServiceCollection AddLogEntryLabelProviderSingleton<T>(this IServiceCollection services, Func<IServiceProvider, T> implementationFactory)
            where T : class, ILogEntryLabelProvider
             => services.AddSingleton<ILogEntryLabelProvider, T>(implementationFactory);

        /// <summary>
        /// Adds a <see cref="ILogEntryLabelProvider"/> of type <typeparamref name="T"/> to the service collection instance
        /// as a singleton.
        /// </summary>
        /// <typeparam name="T">The type of the <see cref="ILogEntryLabelProvider"/> implementation.</typeparam>
        /// <param name="services">The <see cref="IServiceCollection"/> instance.</param>
        /// <param name="instance">The instance of <typeparamref name="T"/>.</param>
        /// <returns>The <see cref="IServiceCollection"/> instance.</returns>
        public static IServiceCollection AddLogEntryLabelProviderSingleton<T>(this IServiceCollection services, T instance)
            where T : class, ILogEntryLabelProvider
            => services.AddSingleton<ILogEntryLabelProvider>(instance);
    }
}
