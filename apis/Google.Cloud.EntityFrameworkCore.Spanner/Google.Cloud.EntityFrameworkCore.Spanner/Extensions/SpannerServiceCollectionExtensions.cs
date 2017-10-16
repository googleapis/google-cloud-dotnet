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

using Google.Api.Gax;
using Google.Cloud.EntityFrameworkCore.Spanner.Infrastructure.Internal;
using Google.Cloud.EntityFrameworkCore.Spanner.Metadata.Conventions;
using Google.Cloud.EntityFrameworkCore.Spanner.Query.ExpressionTranslators.Internal;
using Google.Cloud.EntityFrameworkCore.Spanner.Query.Internal;
using Google.Cloud.EntityFrameworkCore.Spanner.Query.Sql.Internal;
using Google.Cloud.EntityFrameworkCore.Spanner.Storage.Internal;
using Google.Cloud.EntityFrameworkCore.Spanner.Update.Internal;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Query.ExpressionTranslators;
using Microsoft.EntityFrameworkCore.Query.Sql;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Update;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Spanner specific extension methods for <see cref="IServiceCollection" />.
    /// </summary>
    public static class SpannerServiceCollectionExtensions
    {
        /// <summary>
        /// </summary>
        /// <param name="serviceCollection"></param>
        /// <returns></returns>
        public static IServiceCollection AddEntityFrameworkSpanner(this IServiceCollection serviceCollection)
        {
            GaxPreconditions.CheckNotNull(serviceCollection, nameof(serviceCollection));

            var builder = new EntityFrameworkRelationalServicesBuilder(serviceCollection)
                .TryAdd<IDatabase, RelationalDatabase>()
                .TryAdd<IDatabaseProvider, DatabaseProvider<SpannerOptionsExtension>>()
                .TryAdd<IRelationalTypeMapper, SpannerTypeMapper>()
                .TryAdd<ISqlGenerationHelper, SpannerSqlGenerationHelper>()
                //MODEL/MIGRATION SERVICES
                //.TryAdd<IMigrationsAnnotationProvider, SpannerMigrationsAnnotationProvider>()
                //.TryAdd<IModelValidator, SpannerModelValidator>()
                //.TryAdd<IMigrationsSqlGenerator, SpannerMigrationsSqlGenerator>()
                //.TryAdd<IRelationalDatabaseCreator, SpannerDatabaseCreator>()
                .TryAdd<IConventionSetBuilder, SpannerConventionSetBuilder>()
                //.TryAdd<IHistoryRepository, SpannerHistoryRepository>()
                .TryAdd<IRelationalConnection, SpannerRelationalConnection>()
                .TryAdd<IExecutionStrategyFactory, RelationalExecutionStrategyFactory>()
                //QUERY SERVICES
                .TryAdd<IQueryCompilationContextFactory, SpannerQueryCompilationContextFactory>()
                .TryAdd<IMemberTranslator, SpannerCompositeMemberTranslator>()
                .TryAdd<ICompositeMethodCallTranslator, SpannerCompositeMethodCallTranslator>()
                .TryAdd<IQuerySqlGeneratorFactory, SpannerQuerySqlGeneratorFactory>()
                .TryAdd<IRelationalCommandBuilderFactory, SpannerRelationalCommandBuilderFactory>()
                //UPDATE
                .TryAdd<IModificationCommandBatchFactory, SpannerModificationCommandBatchFactory>();

            builder.TryAddCoreServices();
            return serviceCollection;
        }
    }
}