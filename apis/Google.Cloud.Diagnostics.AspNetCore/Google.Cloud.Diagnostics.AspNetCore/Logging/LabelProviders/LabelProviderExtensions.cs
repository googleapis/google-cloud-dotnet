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

using System;
using Microsoft.Extensions.DependencyInjection;

#if NETCOREAPP3_1
namespace Google.Cloud.Diagnostics.AspNetCore3
#elif NETSTANDARD2_0
namespace Google.Cloud.Diagnostics.AspNetCore
#else
#error unknown target framework
#endif
{
    /// <summary>
    /// Provides extension methods to register <see cref="Common.ILogEntryLabelProvider"/> implementations.
    /// </summary>
    public static class LabelProviderExtensions
    {
        /// <summary>
        /// Adds a <see cref="Common.ILogEntryLabelProvider"/> of type <typeparamref name="T"/> to the service collection instance.
        /// </summary>
        /// <typeparam name="T">The type of the <see cref="Common.ILogEntryLabelProvider"/> implementation.</typeparam>
        /// <param name="serivces">The <see cref="IServiceCollection"/> instance.</param>
        /// <returns>The <see cref="IServiceCollection"/> instance.</returns>
        public static IServiceCollection AddLogEntryLabelProvider<T>(this IServiceCollection serivces)
            where T : class, Common.ILogEntryLabelProvider
            => serivces.AddSingleton<Common.ILogEntryLabelProvider, T>();

        /// <summary>
        /// Adds a <see cref="Common.ILogEntryLabelProvider"/> of type <typeparamref name="T"/> to the service collection instance.
        /// </summary>
        /// <typeparam name="T">The type of the <see cref="Common.ILogEntryLabelProvider"/> implementation.</typeparam>
        /// <param name="serivces">The <see cref="IServiceCollection"/> instance.</param>
        /// <param name="implementationFactory">The factory that creates the service.</param>
        /// <returns>The <see cref="IServiceCollection"/> instance.</returns>
        public static IServiceCollection AddLogEntryLabelProvider<T>(this IServiceCollection serivces, Func<IServiceProvider, T> implementationFactory)
            where T : class, Common.ILogEntryLabelProvider
             => serivces.AddSingleton<Common.ILogEntryLabelProvider, T>(implementationFactory);

        /// <summary>
        /// Adds a <see cref="Common.ILogEntryLabelProvider"/> of type <typeparamref name="T"/> to the service collection instance.
        /// </summary>
        /// <typeparam name="T">The type of the <see cref="Common.ILogEntryLabelProvider"/> implementation.</typeparam>
        /// <param name="serivces">The <see cref="IServiceCollection"/> instance.</param>
        /// <param name="instance">The instance of <typeparamref name="T"/>.</param>
        /// <returns>The <see cref="IServiceCollection"/> instance.</returns>
        public static IServiceCollection AddLogEntryLabelProvider<T>(this IServiceCollection serivces, T instance)
            where T : class, Common.ILogEntryLabelProvider
            => serivces.AddSingleton<Common.ILogEntryLabelProvider>(instance);
    }
}
