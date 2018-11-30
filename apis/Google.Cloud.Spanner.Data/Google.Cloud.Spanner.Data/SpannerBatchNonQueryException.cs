// Copyright 2018 Google LLC
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

using Google.Rpc;
using System.Collections.Generic;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Represents an error communicating with the Spanner database when executing
    /// batch non query operations.
    /// </summary>
    /// <remarks>
    /// In Spanner batched commands are executed sequentially in the order they are received.
    /// If one command fails then the following commands won't be executed.
    /// This exception contains the error code and error message corresponding to the command that failed.
    /// It also contains the number of rows modified by each of the commands that executed successfully.
    /// </remarks>
    public class SpannerBatchNonQueryException : SpannerException
    {
        internal SpannerBatchNonQueryException(Status status, IEnumerable<long> result)
            : base(status)
        {
            SuccessfulCommandResults = result;
        }

        /// <summary>
        /// Returns the affected rows for each of the batch commands that executed succesfully. 
        /// </summary>
        public IEnumerable<long> SuccessfulCommandResults { get; }
    }
}
