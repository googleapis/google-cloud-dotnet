// Copyright 2017 Google Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Collections.Generic;
using System;
using Xunit;

namespace Google.Cloud.Bigtable.V2.Tests
{
    /// <summary>
    /// Test for <see cref="BigtableMutateRowsRequestManager"/>.
    /// </summary>
    class BigtableBigtableMutateRowsRequestManagerTest
    {
        public class BigtableMutateRowsRequestManagerTest
        {
            private static readonly Rpc.Status OK =
                new Rpc.Status { Code = (int)Grpc.Core.StatusCode.OK };
            private static readonly Rpc.Status DEADLINE_EXCEEDED =
                new Rpc.Status { Code = (int)Grpc.Core.StatusCode.DeadlineExceeded };
            private static readonly Rpc.Status NOT_FOUND =
                new Rpc.Status { Code = (int)Grpc.Core.StatusCode.NotFound };

            private static List<T> Fill<T>(T value, int size)
            {
                List<T> list = new List<T>();
                while (--size >= 0)
                {
                    list.Add(value);
                }
                return list;
            }

            private static MutateRowsRequest CreateRequest(int entryCount)
            {
                MutateRowsRequest request = new MutateRowsRequest();
                for (int i = 0; i < entryCount; i++)
                {
                    Mutation mutation = new Mutation { SetCell = new Mutation.Types.SetCell { FamilyName = "Family" + i } };
                    request.Entries.Add(new MutateRowsRequest.Types.Entry { Mutations = { mutation } });
                }
                return request;
            }

            private static MutateRowsRequest CreateRequest(MutateRowsRequest original, params int[] indices)
            {
                MutateRowsRequest request = new MutateRowsRequest();
                foreach (int i in indices)
                {
                    request.Entries.Add(original.Entries[i]);
                }
                return request;
            }

            private static MutateRowsResponse CreateResponse(params Rpc.Status[] statuses)
            {
                MutateRowsResponse response = new MutateRowsResponse();
                for (int i = 0; i < statuses.Length; i++)
                {
                    response.Entries.Add(ToEntry(i, statuses[i]));
                }
                return response;
            }

            private static MutateRowsResponse.Types.Entry ToEntry(int i, Rpc.Status status)
            {
                return new MutateRowsResponse.Types.Entry { Index = i, Status = status };
            }

            /// <summary>
            /// This method sends MutateRowsResponse message to MutateRowsRequestManger 
            /// and requests back <see cref="BigtableMutateRowsRequestManager.ProcessingStatus"/> based on the message sent.
            /// </summary>
            /// <param name="underTest"></param>
            /// <param name="response"></param>
            /// <returns>ProcessingStatus - OK, RETRIABLE, NOT_RETRIABLE, INVALID.</returns>
            private static BigtableMutateRowsRequestManager.ProcessingStatus Send(BigtableMutateRowsRequestManager underTest,
                MutateRowsResponse response)
            {
                underTest.SetStatus(response);
                return underTest.OnOk();
            }

            /// <summary>
            /// This array holds statuses to retry on.
            /// </summary>
            private readonly Grpc.Core.StatusCode[] _retryStatuses = { Grpc.Core.StatusCode.DeadlineExceeded };

            /// <summary>
            /// An empty request should return an empty response.
            /// </summary>
            [Fact]
            public void Test_empty_success()
            {
                BigtableMutateRowsRequestManager underTest = new BigtableMutateRowsRequestManager(_retryStatuses, CreateRequest(0));

                Send(underTest, CreateResponse());
                Assert.Equal(CreateResponse(), underTest.BuildResponse());
            }

            /// <summary>
            /// A single successful entry should work.
            /// </summary>
            [Fact]
            public void Test_single_success()
            {
                BigtableMutateRowsRequestManager underTest =
                    new BigtableMutateRowsRequestManager(_retryStatuses, CreateRequest(1));

                Send(underTest, CreateResponse(OK));
                Assert.Equal(CreateResponse(OK), underTest.BuildResponse());
            }

            /// <summary>
            /// Two individual calls with one retry should work.
            /// </summary>
            [Fact]
            public void Test_two_try_success_one_failure()
            {
                MutateRowsRequest originalRequest = CreateRequest(3);
                BigtableMutateRowsRequestManager underTest = new BigtableMutateRowsRequestManager(_retryStatuses, originalRequest);

                Send(underTest, CreateResponse(OK, DEADLINE_EXCEEDED, OK));
                Assert.Equal(CreateRequest(originalRequest, 1), underTest.GetRetryRequest());
                Assert.Equal(CreateResponse(OK, DEADLINE_EXCEEDED, OK), underTest.BuildResponse());

                Send(underTest, CreateResponse(OK));
                Assert.Equal(CreateResponse(OK, OK, OK), underTest.BuildResponse());
            }

            /// <summary>
            /// Two individual calls in a more complicated case with one retry should work.
            /// </summary>
            [Fact]
            public void Test_Multi_Success()
            {
                MutateRowsRequest originalRequest = CreateRequest(10);
                BigtableMutateRowsRequestManager underTest =
                    new BigtableMutateRowsRequestManager(_retryStatuses, originalRequest);

                // 5 mutations succeed, 5 mutations are retryable.
                MutateRowsResponse firstResponse = CreateResponse(OK, DEADLINE_EXCEEDED, OK, DEADLINE_EXCEEDED,
                    OK, DEADLINE_EXCEEDED, OK, DEADLINE_EXCEEDED, OK, DEADLINE_EXCEEDED);
                Send(underTest, firstResponse);
                Assert.Equal(CreateRequest(originalRequest, 1, 3, 5, 7, 9), underTest.GetRetryRequest());
                Assert.Equal(firstResponse, underTest.BuildResponse());

                // 3 mutations succeed, 2 mutations are retryable.
                Send(underTest, CreateResponse(OK, DEADLINE_EXCEEDED, OK, OK, DEADLINE_EXCEEDED));
                Assert.Equal(CreateRequest(originalRequest, 3, 9), underTest.GetRetryRequest());
                MutateRowsResponse secondResponse = CreateResponse(OK, OK, OK, DEADLINE_EXCEEDED,
                    OK, OK, OK, OK, OK, DEADLINE_EXCEEDED);
                Assert.Equal(secondResponse, underTest.BuildResponse());

                // The final 2 mutations are OK
                Send(underTest, CreateResponse(OK, OK));
                Assert.Equal(CreateResponse(OK, OK, OK, OK, OK, OK, OK, OK, OK, OK),
                    underTest.BuildResponse());
            }

            /// <summary>
            /// Multiple attempts at retries should work as expected. 10 mutations are added, and 1 gets an OK
            /// status for 9 rounds until 1 mutation is left.Each success shows up in a random location.
            /// </summary>
            [Fact]
            public void Test_multi_attempt()
            {
                Random rand = new Random();
                MutateRowsRequest originalRequest = CreateRequest(10);
                BigtableMutateRowsRequestManager underTest =
                    new BigtableMutateRowsRequestManager(_retryStatuses, originalRequest);

                // At the beginning, all mutations are outstanding
                List<int> remaining = new List<int>();
                for (int i = 0; i < 10; i++)
                {
                    remaining.Add(i);
                }

                // Create a List<Status> filled with DEADLINE_EXCEEDED
                List<Rpc.Status> statuses = Fill(DEADLINE_EXCEEDED, originalRequest.Entries.Count);

                for (int i = 0; i < 9; i++)
                {
                    int remainingMutationCount = remaining.Count;

                    // Randomly choose a successfull mutation
                    int successIndex = rand.Next(remainingMutationCount);
                    // Set the index of ramdom mutation to success
                    statuses[successIndex] = OK;

                    // The successful status can now be removed.
                    remaining.RemoveAt(successIndex);

                    // Make sure that the request is retryable, and that the retry request looks reasonable.
                    Assert.Equal(BigtableMutateRowsRequestManager.ProcessingStatus.RETRYABLE,
                        Send(underTest, CreateResponse(statuses.ToArray())));
                    Assert.Equal(CreateRequest(originalRequest, remaining.ToArray()), underTest.GetRetryRequest());

                    // Remove Successful status from statuses.
                    statuses.RemoveAt(successIndex);
                }

                // Only one Mutation should be outstanding at this point. Create a response that has all OKs,
                // with the exception of the remaining statuses.
                statuses = Fill(OK, originalRequest.Entries.Count);
                statuses[remaining[0]] = DEADLINE_EXCEEDED;

                Assert.Equal(CreateResponse(statuses.ToArray()), underTest.BuildResponse());
            }

            /// <summary>
            /// Processing status should return NOT_RETRIABLE if even a single response is not retryable.
            /// </summary>
            [Fact]
            public void Test_not_retriable()
            {
                BigtableMutateRowsRequestManager underTest = new BigtableMutateRowsRequestManager(_retryStatuses, CreateRequest(3));

                Assert.Equal(BigtableMutateRowsRequestManager.ProcessingStatus.NOT_RETRYABLE,
                    Send(underTest, CreateResponse(OK, OK, NOT_FOUND)));
                Assert.Equal(CreateResponse(OK, OK, NOT_FOUND), underTest.BuildResponse());
            }

            /// <summary>
            /// Processing status should return INVALID if even a single response is missing/did not receive status.
            /// Or response has an extra entry
            /// </summary>
            [Fact]
            public void Test_invalid()
            {
                // Create 3 muntations, but only 2 OKs. That should be invalid
                BigtableMutateRowsRequestManager underTest =
                    new BigtableMutateRowsRequestManager(_retryStatuses, CreateRequest(3));
                Assert.Equal(BigtableMutateRowsRequestManager.ProcessingStatus.INVALID,
                    Send(underTest, CreateResponse(OK, OK)));

                // Same 3 original mutations, but 4 entries in the response. That should be invalid
                Assert.Equal(BigtableMutateRowsRequestManager.ProcessingStatus.INVALID,
                    Send(underTest, CreateResponse(OK, OK, OK, OK)));
            }
        }
    }
}
