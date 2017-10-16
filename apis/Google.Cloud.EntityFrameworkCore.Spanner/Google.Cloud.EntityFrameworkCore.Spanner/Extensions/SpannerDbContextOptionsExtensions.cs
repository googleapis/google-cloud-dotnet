// Copyright 2017 Google Inc. All Rights Reserved.
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
using System.Data.Common;
using Google.Api.Gax;
using Google.Cloud.EntityFrameworkCore.Spanner.Infrastructure;
using Google.Cloud.EntityFrameworkCore.Spanner.Infrastructure.Internal;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Infrastructure;

// ReSharper disable once CheckNamespace
namespace Microsoft.EntityFrameworkCore
{
    /// <summary>
    /// Spanner specific extension methods for <see cref="DbContextOptionsBuilder" />.
    /// </summary>
    public static class SpannerDbContextOptionsExtensions
    {
        /// <summary>
        /// </summary>
        /// <param name="optionsBuilder"></param>
        /// <param name="connectionString"></param>
        /// <param name="spannerOptionsAction"></param>
        /// <returns></returns>
        public static DbContextOptionsBuilder UseSpanner(
            this DbContextOptionsBuilder optionsBuilder,
            string connectionString,
            Action<SpannerDbContextOptionsBuilder> spannerOptionsAction = null)
        {
            GaxPreconditions.CheckNotNull(optionsBuilder, nameof(optionsBuilder));
            GaxPreconditions.CheckNotNullOrEmpty(connectionString, nameof(connectionString));

            var extension = (SpannerOptionsExtension) GetOrCreateExtension(optionsBuilder)
                .WithConnectionString(connectionString);
            ((IDbContextOptionsBuilderInfrastructure) optionsBuilder).AddOrUpdateExtension(extension);

            ConfigureWarnings(optionsBuilder);
            spannerOptionsAction?.Invoke(new SpannerDbContextOptionsBuilder(optionsBuilder));

            return optionsBuilder;
        }

        /// <summary>
        /// </summary>
        /// <param name="optionsBuilder"></param>
        /// <param name="connection"></param>
        /// <param name="spannerOptionsAction"></param>
        /// <returns></returns>
        public static DbContextOptionsBuilder UseSpanner(
            this DbContextOptionsBuilder optionsBuilder,
            DbConnection connection,
            Action<SpannerDbContextOptionsBuilder> spannerOptionsAction = null)
        {
            GaxPreconditions.CheckNotNull(optionsBuilder, nameof(optionsBuilder));
            GaxPreconditions.CheckNotNull(connection, nameof(connection));

            var extension = (SpannerOptionsExtension) GetOrCreateExtension(optionsBuilder).WithConnection(connection);
            ((IDbContextOptionsBuilderInfrastructure) optionsBuilder).AddOrUpdateExtension(extension);

            ConfigureWarnings(optionsBuilder);

            spannerOptionsAction?.Invoke(new SpannerDbContextOptionsBuilder(optionsBuilder));

            return optionsBuilder;
        }

        /// <summary>
        /// </summary>
        /// <typeparam name="TContext"></typeparam>
        /// <param name="optionsBuilder"></param>
        /// <param name="connectionString"></param>
        /// <param name="spannerOptionsAction"></param>
        /// <returns></returns>
        public static DbContextOptionsBuilder<TContext> UseSpanner<TContext>(
            this DbContextOptionsBuilder<TContext> optionsBuilder,
            string connectionString,
            Action<SpannerDbContextOptionsBuilder> spannerOptionsAction = null)
            where TContext : DbContext
            => (DbContextOptionsBuilder<TContext>) UseSpanner(
                (DbContextOptionsBuilder) optionsBuilder, connectionString, spannerOptionsAction);

        /// <summary>
        /// </summary>
        /// <typeparam name="TContext"></typeparam>
        /// <param name="optionsBuilder"></param>
        /// <param name="connection"></param>
        /// <param name="spannerOptionsAction"></param>
        /// <returns></returns>
        public static DbContextOptionsBuilder<TContext> UseSpanner<TContext>(
            this DbContextOptionsBuilder<TContext> optionsBuilder,
            DbConnection connection,
            Action<SpannerDbContextOptionsBuilder> spannerOptionsAction = null)
            where TContext : DbContext
            => (DbContextOptionsBuilder<TContext>) UseSpanner(
                (DbContextOptionsBuilder) optionsBuilder, connection, spannerOptionsAction);

        private static SpannerOptionsExtension GetOrCreateExtension(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.Options.FindExtension<SpannerOptionsExtension>()
               ?? new SpannerOptionsExtension();

        private static void ConfigureWarnings(DbContextOptionsBuilder optionsBuilder)
        {
            var coreOptionsExtension
                = optionsBuilder.Options.FindExtension<CoreOptionsExtension>()
                  ?? new CoreOptionsExtension();

            coreOptionsExtension = coreOptionsExtension.WithWarningsConfiguration(
                coreOptionsExtension.WarningsConfiguration.TryWithExplicit(
                    RelationalEventId.AmbientTransactionWarning, WarningBehavior.Throw));

            ((IDbContextOptionsBuilderInfrastructure) optionsBuilder).AddOrUpdateExtension(coreOptionsExtension);
        }
    }
}