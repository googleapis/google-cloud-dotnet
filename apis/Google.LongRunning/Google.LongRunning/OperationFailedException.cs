// Copyright 2016 Google Inc. All Rights Reserved.
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
using Google.Rpc;
using System;

namespace Google.LongRunning
{
    /// <summary>
    /// An exception to indicate that a long-running operation failed.
    /// </summary>
    public class OperationFailedException : Exception
    {
        /// <summary>
        /// The operation message containing the original error.
        /// </summary>
        public Operation Operation { get; }

        /// <summary>
        /// The status message within the operation's error field.
        /// </summary>
        public Status Status => Operation.Error;

        /// <summary>
        /// Constructs an exception based on a protobuf message representing a failed operation.
        /// </summary>
        /// <param name="operation">The failed operation. Must not be null, and must have an error.</param>
        public OperationFailedException(Operation operation) : base(ValidateProto(operation).Error.Message)
        {
            Operation = operation;
        }

        private static Operation ValidateProto(Operation operation)
        {
            GaxPreconditions.CheckNotNull(operation, nameof(operation));
            GaxPreconditions.CheckArgument(operation.Error != null, nameof(operation), "Operation must contain an error");
            return operation;
        }
    }
}
