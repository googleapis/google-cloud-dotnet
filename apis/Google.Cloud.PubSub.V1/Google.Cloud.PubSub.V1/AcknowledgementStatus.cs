// Copyright 2022 Google LLC
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

namespace Google.Cloud.PubSub.V1;

/// <summary>
/// The possible status values of acknowledgement for a message in an acknowledgement request.
/// </summary>
public enum AcknowledgementStatus
{
    /// <summary>
    /// Default value. Indicates that the acknowledgement is successful.
    /// </summary>
    Success = 0,

    /// <summary>
    /// Indicates that the acknowledgement is not successful due to permission denied error.
    /// </summary>
    PermissionDenied,

    /// <summary>
    /// Indicates that the acknowledgement is not successful due to a failed precondition.
    /// </summary>
    FailedPrecondition,

    /// <summary>
    /// Indicates that the acknowledgement is not successful due to invalid AckId.
    /// </summary>
    InvalidAckId,

    /// <summary>
    /// Indicates that the acknowledgement is not successful due to an unknown reason.
    /// </summary>
    Other
}
