// Copyright 2018 Google Inc. All Rights Reserved.
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

using Microsoft.Extensions.DependencyInjection;
using System;

namespace Google.Cloud.Diagnostics.AspNetCore3
{
    /// <summary>
    /// Provides extension methods to register <see cref="ILogEntryLabelProvider"/> implementations.
    /// </summary>
    [Obsolete("Use equivalent extension methods defined in Google.Cloud.Diagnostics.Common.LoggingExtensions instead.")]
    public static class LabelProviderExtensions
    {
        /// <summary>
        /// Adds a <see cref="ILogEntryLabelProvider"/> of type <typeparamref name="T"/> to the service collection instance.
        /// </summary>
        /// <typeparam name="T">The type of the <see cref="ILogEntryLabelProvider"/> implementation.</typeparam>
        /// <param name="serivces">The <see cref="IServiceCollection"/> instance.</param>
        /// <returns>The <see cref="IServiceCollection"/> instance.</returns>
        [Obsolete("Use equivalent extension method defined in Google.Cloud.Diagnostics.Common.LoggingExtensions instead.")]
        public static IServiceCollection AddLogEntryLabelProvider<T>(this IServiceCollection serivces)
            where T : class, ILogEntryLabelProvider
            => serivces.AddSingleton<ILogEntryLabelProvider, T>();

        /// <summary>
        /// Adds a <see cref="ILogEntryLabelProvider"/> of type <typeparamref name="T"/> to the service collection instance.
        /// </summary>
        /// <typeparam name="T">The type of the <see cref="ILogEntryLabelProvider"/> implementation.</typeparam>
        /// <param name="serivces">The <see cref="IServiceCollection"/> instance.</param>
        /// <param name="implementationFactory">The factory that creates the service.</param>
        /// <returns>The <see cref="IServiceCollection"/> instance.</returns>
        [Obsolete("Use equivalent extension method defined in Google.Cloud.Diagnostics.Common.LoggingExtensions instead.")]
        public static IServiceCollection AddLogEntryLabelProvider<T>(this IServiceCollection serivces, Func<IServiceProvider, T> implementationFactory)
            where T : class, ILogEntryLabelProvider
             => serivces.AddSingleton<ILogEntryLabelProvider>(implementationFactory);

        /// <summary>
        /// Adds a <see cref="ILogEntryLabelProvider"/> of type <typeparamref name="T"/> to the service collection instance.
        /// </summary>
        /// <typeparam name="T">The type of the <see cref="ILogEntryLabelProvider"/> implementation.</typeparam>
        /// <param name="serivces">The <see cref="IServiceCollection"/> instance.</param>
        /// <param name="instance">The instance of <typeparamref name="T"/>.</param>
        /// <returns>The <see cref="IServiceCollection"/> instance.</returns>
        [Obsolete("Use equivalent extension method defined in Google.Cloud.Diagnostics.Common.LoggingExtensions instead.")]
        public static IServiceCollection AddLogEntryLabelProvider<T>(this IServiceCollection serivces, T instance)
            where T : class, ILogEntryLabelProvider
            => serivces.AddSingleton<ILogEntryLabelProvider>(instance);
    }
}
