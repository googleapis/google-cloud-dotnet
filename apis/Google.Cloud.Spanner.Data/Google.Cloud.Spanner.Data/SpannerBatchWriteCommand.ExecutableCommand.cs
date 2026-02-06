// Copyright 2026 Google LLC
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
using Google.Cloud.Spanner.V1;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Google.Cloud.Spanner.Data;

public sealed partial class SpannerBatchWriteCommand
{
    /// <summary>
    /// Class that effectively contains a copy of the parameters of a SpannerBatchWriteCommand, but in a shallow-immutable way.
    /// This means we can validate various things and not worry about them changing. The SpannerConnection can be modified,
    /// but other objects should be fine.
    /// This class is an implementation detail, used to keep "code required to execute Spanner commands" separate from the ADO
    /// API surface with its mutable properties and many overloads.
    /// </summary>
    private class ExecutableCommand
    {
        internal SpannerConnection Connection { get; }
        internal IList<CommandGroup> CommandGroups { get; }
        internal int CommandTimeout { get; }
        internal Priority Priority { get; }
        internal string Tag { get; }

        public ExecutableCommand(SpannerBatchWriteCommand command)
        {
            Connection = command.Connection;
            CommandGroups = command._commandGroups.Select(g => g.Clone()).ToList();
            CommandTimeout = command.CommandTimeout;
            Priority = command.Priority;
            Tag = command.Tag;
        }

        /// <summary>
        /// Executes the batch of command groups asynchronously, returning a stream of responses.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>An <see cref="IAsyncEnumerable{BatchWriteResponse}"/> representing the stream of results.</returns>
        internal IAsyncEnumerable<BatchWriteResult> ExecuteNonQueryAsync(CancellationToken cancellationToken)
        {
            ValidateConnectionAndCommandCount();
            var request = CreateRequest();
            return Connection.ExecuteBatchWriteAsync(request, CommandTimeout, cancellationToken);
        }

        private BatchWriteRequest CreateRequest()
        {
            var request = new BatchWriteRequest
            {
                RequestOptions = BuildRequestOptions()
            };

            foreach (var group in CommandGroups)
            {
                var mutationGroup = new BatchWriteRequest.Types.MutationGroup();
                foreach (var command in group.Commands)
                {
                    mutationGroup.Mutations.Add(command.GetMutation());
                }
                request.MutationGroups.Add(mutationGroup);
            }

            return request;
        }

        private RequestOptions BuildRequestOptions()
        {
            if (string.IsNullOrEmpty(Tag) && Priority == Priority.Unspecified)
            {
                return null;
            }
            return new RequestOptions
            {
                RequestTag = Tag ?? "",
                Priority = PriorityConverter.ToProto(Priority)
            };
        }

        private void ValidateConnectionAndCommandCount()
        {
            GaxPreconditions.CheckState(Connection != null, "SpannerBatchWriteCommand can only be executed when a connection is assigned.");
            GaxPreconditions.CheckState(CommandGroups.Count > 0, "SpannerBatchWriteCommand can only be executed when the batch contains at least one command group.");
        }
    }
}