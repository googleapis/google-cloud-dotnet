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

namespace Google.Cloud.BigQuery.Reservation.V1.Snippets
{
    // [START bigqueryreservation_v1_generated_ReservationService_CreateAssignment_sync]
    using Google.Cloud.BigQuery.Reservation.V1;

    public sealed partial class GeneratedReservationServiceClientSnippets
    {
        /// <summary>Snippet for CreateAssignment</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CreateAssignmentRequestObject()
        {
            // Create client
            ReservationServiceClient reservationServiceClient = ReservationServiceClient.Create();
            // Initialize request argument(s)
            CreateAssignmentRequest request = new CreateAssignmentRequest
            {
                ParentAsReservationName = ReservationName.FromProjectLocationReservation("[PROJECT]", "[LOCATION]", "[RESERVATION]"),
                Assignment = new Assignment(),
                AssignmentId = "",
            };
            // Make the request
            Assignment response = reservationServiceClient.CreateAssignment(request);
        }
    }
    // [END bigqueryreservation_v1_generated_ReservationService_CreateAssignment_sync]
}
