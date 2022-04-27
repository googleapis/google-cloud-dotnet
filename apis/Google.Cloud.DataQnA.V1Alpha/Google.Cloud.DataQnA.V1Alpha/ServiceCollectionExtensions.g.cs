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

// Generated code. DO NOT EDIT!

using gaxgrpc = Google.Api.Gax.Grpc;
using gcdv = Google.Cloud.DataQnA.V1Alpha;
using gpr = Google.Protobuf.Reflection;
using sys = System;
using scg = System.Collections.Generic;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>Static class to provide extension methods to configure API clients.</summary>
    public static partial class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds a singleton <see cref="gcdv::AutoSuggestionServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddAutoSuggestionServiceClient(this IServiceCollection services, sys::Action<gcdv::AutoSuggestionServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::AutoSuggestionServiceClientBuilder builder = new gcdv::AutoSuggestionServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::QuestionServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddQuestionServiceClient(this IServiceCollection services, sys::Action<gcdv::QuestionServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::QuestionServiceClientBuilder builder = new gcdv::QuestionServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });
    }
}
