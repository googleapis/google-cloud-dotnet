// Copyright 2025 Google LLC
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

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Domains.V1Beta1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using Google.Type;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDomainsClientSnippets
    {
        /// <summary>Snippet for SearchDomains</summary>
        public void SearchDomainsRequestObject()
        {
            // Snippet: SearchDomains(SearchDomainsRequest, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            SearchDomainsRequest request = new SearchDomainsRequest
            {
                Query = "",
                LocationAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            SearchDomainsResponse response = domainsClient.SearchDomains(request);
            // End snippet
        }

        /// <summary>Snippet for SearchDomainsAsync</summary>
        public async Task SearchDomainsRequestObjectAsync()
        {
            // Snippet: SearchDomainsAsync(SearchDomainsRequest, CallSettings)
            // Additional: SearchDomainsAsync(SearchDomainsRequest, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            SearchDomainsRequest request = new SearchDomainsRequest
            {
                Query = "",
                LocationAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            SearchDomainsResponse response = await domainsClient.SearchDomainsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SearchDomains</summary>
        public void SearchDomains()
        {
            // Snippet: SearchDomains(string, string, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            string location = "projects/[PROJECT]/locations/[LOCATION]";
            string query = "";
            // Make the request
            SearchDomainsResponse response = domainsClient.SearchDomains(location, query);
            // End snippet
        }

        /// <summary>Snippet for SearchDomainsAsync</summary>
        public async Task SearchDomainsAsync()
        {
            // Snippet: SearchDomainsAsync(string, string, CallSettings)
            // Additional: SearchDomainsAsync(string, string, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            string location = "projects/[PROJECT]/locations/[LOCATION]";
            string query = "";
            // Make the request
            SearchDomainsResponse response = await domainsClient.SearchDomainsAsync(location, query);
            // End snippet
        }

        /// <summary>Snippet for SearchDomains</summary>
        public void SearchDomainsResourceNames()
        {
            // Snippet: SearchDomains(LocationName, string, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            LocationName location = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string query = "";
            // Make the request
            SearchDomainsResponse response = domainsClient.SearchDomains(location, query);
            // End snippet
        }

        /// <summary>Snippet for SearchDomainsAsync</summary>
        public async Task SearchDomainsResourceNamesAsync()
        {
            // Snippet: SearchDomainsAsync(LocationName, string, CallSettings)
            // Additional: SearchDomainsAsync(LocationName, string, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName location = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string query = "";
            // Make the request
            SearchDomainsResponse response = await domainsClient.SearchDomainsAsync(location, query);
            // End snippet
        }

        /// <summary>Snippet for RetrieveRegisterParameters</summary>
        public void RetrieveRegisterParametersRequestObject()
        {
            // Snippet: RetrieveRegisterParameters(RetrieveRegisterParametersRequest, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            RetrieveRegisterParametersRequest request = new RetrieveRegisterParametersRequest
            {
                DomainName = "",
                LocationAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            RetrieveRegisterParametersResponse response = domainsClient.RetrieveRegisterParameters(request);
            // End snippet
        }

        /// <summary>Snippet for RetrieveRegisterParametersAsync</summary>
        public async Task RetrieveRegisterParametersRequestObjectAsync()
        {
            // Snippet: RetrieveRegisterParametersAsync(RetrieveRegisterParametersRequest, CallSettings)
            // Additional: RetrieveRegisterParametersAsync(RetrieveRegisterParametersRequest, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            RetrieveRegisterParametersRequest request = new RetrieveRegisterParametersRequest
            {
                DomainName = "",
                LocationAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            RetrieveRegisterParametersResponse response = await domainsClient.RetrieveRegisterParametersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RetrieveRegisterParameters</summary>
        public void RetrieveRegisterParameters()
        {
            // Snippet: RetrieveRegisterParameters(string, string, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            string location = "projects/[PROJECT]/locations/[LOCATION]";
            string domainName = "";
            // Make the request
            RetrieveRegisterParametersResponse response = domainsClient.RetrieveRegisterParameters(location, domainName);
            // End snippet
        }

        /// <summary>Snippet for RetrieveRegisterParametersAsync</summary>
        public async Task RetrieveRegisterParametersAsync()
        {
            // Snippet: RetrieveRegisterParametersAsync(string, string, CallSettings)
            // Additional: RetrieveRegisterParametersAsync(string, string, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            string location = "projects/[PROJECT]/locations/[LOCATION]";
            string domainName = "";
            // Make the request
            RetrieveRegisterParametersResponse response = await domainsClient.RetrieveRegisterParametersAsync(location, domainName);
            // End snippet
        }

        /// <summary>Snippet for RetrieveRegisterParameters</summary>
        public void RetrieveRegisterParametersResourceNames()
        {
            // Snippet: RetrieveRegisterParameters(LocationName, string, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            LocationName location = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string domainName = "";
            // Make the request
            RetrieveRegisterParametersResponse response = domainsClient.RetrieveRegisterParameters(location, domainName);
            // End snippet
        }

        /// <summary>Snippet for RetrieveRegisterParametersAsync</summary>
        public async Task RetrieveRegisterParametersResourceNamesAsync()
        {
            // Snippet: RetrieveRegisterParametersAsync(LocationName, string, CallSettings)
            // Additional: RetrieveRegisterParametersAsync(LocationName, string, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName location = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string domainName = "";
            // Make the request
            RetrieveRegisterParametersResponse response = await domainsClient.RetrieveRegisterParametersAsync(location, domainName);
            // End snippet
        }

        /// <summary>Snippet for RegisterDomain</summary>
        public void RegisterDomainRequestObject()
        {
            // Snippet: RegisterDomain(RegisterDomainRequest, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            RegisterDomainRequest request = new RegisterDomainRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Registration = new Registration(),
                DomainNotices =
                {
                    DomainNotice.Unspecified,
                },
                ContactNotices =
                {
                    ContactNotice.Unspecified,
                },
                YearlyPrice = new Money(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Registration, OperationMetadata> response = domainsClient.RegisterDomain(request);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = domainsClient.PollOnceRegisterDomain(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RegisterDomainAsync</summary>
        public async Task RegisterDomainRequestObjectAsync()
        {
            // Snippet: RegisterDomainAsync(RegisterDomainRequest, CallSettings)
            // Additional: RegisterDomainAsync(RegisterDomainRequest, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            RegisterDomainRequest request = new RegisterDomainRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Registration = new Registration(),
                DomainNotices =
                {
                    DomainNotice.Unspecified,
                },
                ContactNotices =
                {
                    ContactNotice.Unspecified,
                },
                YearlyPrice = new Money(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Registration, OperationMetadata> response = await domainsClient.RegisterDomainAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = await domainsClient.PollOnceRegisterDomainAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RegisterDomain</summary>
        public void RegisterDomain()
        {
            // Snippet: RegisterDomain(string, Registration, Money, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Registration registration = new Registration();
            Money yearlyPrice = new Money();
            // Make the request
            Operation<Registration, OperationMetadata> response = domainsClient.RegisterDomain(parent, registration, yearlyPrice);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = domainsClient.PollOnceRegisterDomain(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RegisterDomainAsync</summary>
        public async Task RegisterDomainAsync()
        {
            // Snippet: RegisterDomainAsync(string, Registration, Money, CallSettings)
            // Additional: RegisterDomainAsync(string, Registration, Money, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Registration registration = new Registration();
            Money yearlyPrice = new Money();
            // Make the request
            Operation<Registration, OperationMetadata> response = await domainsClient.RegisterDomainAsync(parent, registration, yearlyPrice);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = await domainsClient.PollOnceRegisterDomainAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RegisterDomain</summary>
        public void RegisterDomainResourceNames()
        {
            // Snippet: RegisterDomain(LocationName, Registration, Money, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Registration registration = new Registration();
            Money yearlyPrice = new Money();
            // Make the request
            Operation<Registration, OperationMetadata> response = domainsClient.RegisterDomain(parent, registration, yearlyPrice);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = domainsClient.PollOnceRegisterDomain(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RegisterDomainAsync</summary>
        public async Task RegisterDomainResourceNamesAsync()
        {
            // Snippet: RegisterDomainAsync(LocationName, Registration, Money, CallSettings)
            // Additional: RegisterDomainAsync(LocationName, Registration, Money, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Registration registration = new Registration();
            Money yearlyPrice = new Money();
            // Make the request
            Operation<Registration, OperationMetadata> response = await domainsClient.RegisterDomainAsync(parent, registration, yearlyPrice);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = await domainsClient.PollOnceRegisterDomainAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RetrieveTransferParameters</summary>
        public void RetrieveTransferParametersRequestObject()
        {
            // Snippet: RetrieveTransferParameters(RetrieveTransferParametersRequest, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            RetrieveTransferParametersRequest request = new RetrieveTransferParametersRequest
            {
                DomainName = "",
                LocationAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            RetrieveTransferParametersResponse response = domainsClient.RetrieveTransferParameters(request);
            // End snippet
        }

        /// <summary>Snippet for RetrieveTransferParametersAsync</summary>
        public async Task RetrieveTransferParametersRequestObjectAsync()
        {
            // Snippet: RetrieveTransferParametersAsync(RetrieveTransferParametersRequest, CallSettings)
            // Additional: RetrieveTransferParametersAsync(RetrieveTransferParametersRequest, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            RetrieveTransferParametersRequest request = new RetrieveTransferParametersRequest
            {
                DomainName = "",
                LocationAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            RetrieveTransferParametersResponse response = await domainsClient.RetrieveTransferParametersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RetrieveTransferParameters</summary>
        public void RetrieveTransferParameters()
        {
            // Snippet: RetrieveTransferParameters(string, string, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            string location = "projects/[PROJECT]/locations/[LOCATION]";
            string domainName = "";
            // Make the request
            RetrieveTransferParametersResponse response = domainsClient.RetrieveTransferParameters(location, domainName);
            // End snippet
        }

        /// <summary>Snippet for RetrieveTransferParametersAsync</summary>
        public async Task RetrieveTransferParametersAsync()
        {
            // Snippet: RetrieveTransferParametersAsync(string, string, CallSettings)
            // Additional: RetrieveTransferParametersAsync(string, string, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            string location = "projects/[PROJECT]/locations/[LOCATION]";
            string domainName = "";
            // Make the request
            RetrieveTransferParametersResponse response = await domainsClient.RetrieveTransferParametersAsync(location, domainName);
            // End snippet
        }

        /// <summary>Snippet for RetrieveTransferParameters</summary>
        public void RetrieveTransferParametersResourceNames()
        {
            // Snippet: RetrieveTransferParameters(LocationName, string, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            LocationName location = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string domainName = "";
            // Make the request
            RetrieveTransferParametersResponse response = domainsClient.RetrieveTransferParameters(location, domainName);
            // End snippet
        }

        /// <summary>Snippet for RetrieveTransferParametersAsync</summary>
        public async Task RetrieveTransferParametersResourceNamesAsync()
        {
            // Snippet: RetrieveTransferParametersAsync(LocationName, string, CallSettings)
            // Additional: RetrieveTransferParametersAsync(LocationName, string, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName location = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string domainName = "";
            // Make the request
            RetrieveTransferParametersResponse response = await domainsClient.RetrieveTransferParametersAsync(location, domainName);
            // End snippet
        }

        /// <summary>Snippet for TransferDomain</summary>
        public void TransferDomainRequestObject()
        {
            // Snippet: TransferDomain(TransferDomainRequest, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            TransferDomainRequest request = new TransferDomainRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Registration = new Registration(),
                ContactNotices =
                {
                    ContactNotice.Unspecified,
                },
                YearlyPrice = new Money(),
                AuthorizationCode = new AuthorizationCode(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Registration, OperationMetadata> response = domainsClient.TransferDomain(request);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = domainsClient.PollOnceTransferDomain(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TransferDomainAsync</summary>
        public async Task TransferDomainRequestObjectAsync()
        {
            // Snippet: TransferDomainAsync(TransferDomainRequest, CallSettings)
            // Additional: TransferDomainAsync(TransferDomainRequest, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            TransferDomainRequest request = new TransferDomainRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Registration = new Registration(),
                ContactNotices =
                {
                    ContactNotice.Unspecified,
                },
                YearlyPrice = new Money(),
                AuthorizationCode = new AuthorizationCode(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Registration, OperationMetadata> response = await domainsClient.TransferDomainAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = await domainsClient.PollOnceTransferDomainAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TransferDomain</summary>
        public void TransferDomain()
        {
            // Snippet: TransferDomain(string, Registration, Money, AuthorizationCode, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Registration registration = new Registration();
            Money yearlyPrice = new Money();
            AuthorizationCode authorizationCode = new AuthorizationCode();
            // Make the request
            Operation<Registration, OperationMetadata> response = domainsClient.TransferDomain(parent, registration, yearlyPrice, authorizationCode);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = domainsClient.PollOnceTransferDomain(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TransferDomainAsync</summary>
        public async Task TransferDomainAsync()
        {
            // Snippet: TransferDomainAsync(string, Registration, Money, AuthorizationCode, CallSettings)
            // Additional: TransferDomainAsync(string, Registration, Money, AuthorizationCode, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Registration registration = new Registration();
            Money yearlyPrice = new Money();
            AuthorizationCode authorizationCode = new AuthorizationCode();
            // Make the request
            Operation<Registration, OperationMetadata> response = await domainsClient.TransferDomainAsync(parent, registration, yearlyPrice, authorizationCode);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = await domainsClient.PollOnceTransferDomainAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TransferDomain</summary>
        public void TransferDomainResourceNames()
        {
            // Snippet: TransferDomain(LocationName, Registration, Money, AuthorizationCode, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Registration registration = new Registration();
            Money yearlyPrice = new Money();
            AuthorizationCode authorizationCode = new AuthorizationCode();
            // Make the request
            Operation<Registration, OperationMetadata> response = domainsClient.TransferDomain(parent, registration, yearlyPrice, authorizationCode);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = domainsClient.PollOnceTransferDomain(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TransferDomainAsync</summary>
        public async Task TransferDomainResourceNamesAsync()
        {
            // Snippet: TransferDomainAsync(LocationName, Registration, Money, AuthorizationCode, CallSettings)
            // Additional: TransferDomainAsync(LocationName, Registration, Money, AuthorizationCode, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Registration registration = new Registration();
            Money yearlyPrice = new Money();
            AuthorizationCode authorizationCode = new AuthorizationCode();
            // Make the request
            Operation<Registration, OperationMetadata> response = await domainsClient.TransferDomainAsync(parent, registration, yearlyPrice, authorizationCode);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = await domainsClient.PollOnceTransferDomainAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListRegistrations</summary>
        public void ListRegistrationsRequestObject()
        {
            // Snippet: ListRegistrations(ListRegistrationsRequest, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            ListRegistrationsRequest request = new ListRegistrationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListRegistrationsResponse, Registration> response = domainsClient.ListRegistrations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Registration item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRegistrationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Registration item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Registration> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Registration item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRegistrationsAsync</summary>
        public async Task ListRegistrationsRequestObjectAsync()
        {
            // Snippet: ListRegistrationsAsync(ListRegistrationsRequest, CallSettings)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            ListRegistrationsRequest request = new ListRegistrationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListRegistrationsResponse, Registration> response = domainsClient.ListRegistrationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Registration item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRegistrationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Registration item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Registration> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Registration item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRegistrations</summary>
        public void ListRegistrations()
        {
            // Snippet: ListRegistrations(string, string, int?, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListRegistrationsResponse, Registration> response = domainsClient.ListRegistrations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Registration item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRegistrationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Registration item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Registration> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Registration item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRegistrationsAsync</summary>
        public async Task ListRegistrationsAsync()
        {
            // Snippet: ListRegistrationsAsync(string, string, int?, CallSettings)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListRegistrationsResponse, Registration> response = domainsClient.ListRegistrationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Registration item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRegistrationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Registration item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Registration> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Registration item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRegistrations</summary>
        public void ListRegistrationsResourceNames()
        {
            // Snippet: ListRegistrations(LocationName, string, int?, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListRegistrationsResponse, Registration> response = domainsClient.ListRegistrations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Registration item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRegistrationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Registration item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Registration> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Registration item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRegistrationsAsync</summary>
        public async Task ListRegistrationsResourceNamesAsync()
        {
            // Snippet: ListRegistrationsAsync(LocationName, string, int?, CallSettings)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListRegistrationsResponse, Registration> response = domainsClient.ListRegistrationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Registration item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRegistrationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Registration item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Registration> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Registration item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetRegistration</summary>
        public void GetRegistrationRequestObject()
        {
            // Snippet: GetRegistration(GetRegistrationRequest, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            GetRegistrationRequest request = new GetRegistrationRequest
            {
                RegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
            };
            // Make the request
            Registration response = domainsClient.GetRegistration(request);
            // End snippet
        }

        /// <summary>Snippet for GetRegistrationAsync</summary>
        public async Task GetRegistrationRequestObjectAsync()
        {
            // Snippet: GetRegistrationAsync(GetRegistrationRequest, CallSettings)
            // Additional: GetRegistrationAsync(GetRegistrationRequest, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            GetRegistrationRequest request = new GetRegistrationRequest
            {
                RegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
            };
            // Make the request
            Registration response = await domainsClient.GetRegistrationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRegistration</summary>
        public void GetRegistration()
        {
            // Snippet: GetRegistration(string, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/registrations/[REGISTRATION]";
            // Make the request
            Registration response = domainsClient.GetRegistration(name);
            // End snippet
        }

        /// <summary>Snippet for GetRegistrationAsync</summary>
        public async Task GetRegistrationAsync()
        {
            // Snippet: GetRegistrationAsync(string, CallSettings)
            // Additional: GetRegistrationAsync(string, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/registrations/[REGISTRATION]";
            // Make the request
            Registration response = await domainsClient.GetRegistrationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRegistration</summary>
        public void GetRegistrationResourceNames()
        {
            // Snippet: GetRegistration(RegistrationName, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            RegistrationName name = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]");
            // Make the request
            Registration response = domainsClient.GetRegistration(name);
            // End snippet
        }

        /// <summary>Snippet for GetRegistrationAsync</summary>
        public async Task GetRegistrationResourceNamesAsync()
        {
            // Snippet: GetRegistrationAsync(RegistrationName, CallSettings)
            // Additional: GetRegistrationAsync(RegistrationName, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            RegistrationName name = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]");
            // Make the request
            Registration response = await domainsClient.GetRegistrationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateRegistration</summary>
        public void UpdateRegistrationRequestObject()
        {
            // Snippet: UpdateRegistration(UpdateRegistrationRequest, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            UpdateRegistrationRequest request = new UpdateRegistrationRequest
            {
                Registration = new Registration(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Registration, OperationMetadata> response = domainsClient.UpdateRegistration(request);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = domainsClient.PollOnceUpdateRegistration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRegistrationAsync</summary>
        public async Task UpdateRegistrationRequestObjectAsync()
        {
            // Snippet: UpdateRegistrationAsync(UpdateRegistrationRequest, CallSettings)
            // Additional: UpdateRegistrationAsync(UpdateRegistrationRequest, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateRegistrationRequest request = new UpdateRegistrationRequest
            {
                Registration = new Registration(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Registration, OperationMetadata> response = await domainsClient.UpdateRegistrationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = await domainsClient.PollOnceUpdateRegistrationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRegistration</summary>
        public void UpdateRegistration()
        {
            // Snippet: UpdateRegistration(Registration, FieldMask, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            Registration registration = new Registration();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Registration, OperationMetadata> response = domainsClient.UpdateRegistration(registration, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = domainsClient.PollOnceUpdateRegistration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRegistrationAsync</summary>
        public async Task UpdateRegistrationAsync()
        {
            // Snippet: UpdateRegistrationAsync(Registration, FieldMask, CallSettings)
            // Additional: UpdateRegistrationAsync(Registration, FieldMask, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            Registration registration = new Registration();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Registration, OperationMetadata> response = await domainsClient.UpdateRegistrationAsync(registration, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = await domainsClient.PollOnceUpdateRegistrationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ConfigureManagementSettings</summary>
        public void ConfigureManagementSettingsRequestObject()
        {
            // Snippet: ConfigureManagementSettings(ConfigureManagementSettingsRequest, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            ConfigureManagementSettingsRequest request = new ConfigureManagementSettingsRequest
            {
                RegistrationAsRegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
                ManagementSettings = new ManagementSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Registration, OperationMetadata> response = domainsClient.ConfigureManagementSettings(request);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = domainsClient.PollOnceConfigureManagementSettings(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ConfigureManagementSettingsAsync</summary>
        public async Task ConfigureManagementSettingsRequestObjectAsync()
        {
            // Snippet: ConfigureManagementSettingsAsync(ConfigureManagementSettingsRequest, CallSettings)
            // Additional: ConfigureManagementSettingsAsync(ConfigureManagementSettingsRequest, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            ConfigureManagementSettingsRequest request = new ConfigureManagementSettingsRequest
            {
                RegistrationAsRegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
                ManagementSettings = new ManagementSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Registration, OperationMetadata> response = await domainsClient.ConfigureManagementSettingsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = await domainsClient.PollOnceConfigureManagementSettingsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ConfigureManagementSettings</summary>
        public void ConfigureManagementSettings()
        {
            // Snippet: ConfigureManagementSettings(string, ManagementSettings, FieldMask, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            string registration = "projects/[PROJECT]/locations/[LOCATION]/registrations/[REGISTRATION]";
            ManagementSettings managementSettings = new ManagementSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Registration, OperationMetadata> response = domainsClient.ConfigureManagementSettings(registration, managementSettings, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = domainsClient.PollOnceConfigureManagementSettings(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ConfigureManagementSettingsAsync</summary>
        public async Task ConfigureManagementSettingsAsync()
        {
            // Snippet: ConfigureManagementSettingsAsync(string, ManagementSettings, FieldMask, CallSettings)
            // Additional: ConfigureManagementSettingsAsync(string, ManagementSettings, FieldMask, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            string registration = "projects/[PROJECT]/locations/[LOCATION]/registrations/[REGISTRATION]";
            ManagementSettings managementSettings = new ManagementSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Registration, OperationMetadata> response = await domainsClient.ConfigureManagementSettingsAsync(registration, managementSettings, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = await domainsClient.PollOnceConfigureManagementSettingsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ConfigureManagementSettings</summary>
        public void ConfigureManagementSettingsResourceNames()
        {
            // Snippet: ConfigureManagementSettings(RegistrationName, ManagementSettings, FieldMask, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            RegistrationName registration = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]");
            ManagementSettings managementSettings = new ManagementSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Registration, OperationMetadata> response = domainsClient.ConfigureManagementSettings(registration, managementSettings, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = domainsClient.PollOnceConfigureManagementSettings(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ConfigureManagementSettingsAsync</summary>
        public async Task ConfigureManagementSettingsResourceNamesAsync()
        {
            // Snippet: ConfigureManagementSettingsAsync(RegistrationName, ManagementSettings, FieldMask, CallSettings)
            // Additional: ConfigureManagementSettingsAsync(RegistrationName, ManagementSettings, FieldMask, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            RegistrationName registration = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]");
            ManagementSettings managementSettings = new ManagementSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Registration, OperationMetadata> response = await domainsClient.ConfigureManagementSettingsAsync(registration, managementSettings, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = await domainsClient.PollOnceConfigureManagementSettingsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ConfigureDnsSettings</summary>
        public void ConfigureDnsSettingsRequestObject()
        {
            // Snippet: ConfigureDnsSettings(ConfigureDnsSettingsRequest, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            ConfigureDnsSettingsRequest request = new ConfigureDnsSettingsRequest
            {
                RegistrationAsRegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
                DnsSettings = new DnsSettings(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Registration, OperationMetadata> response = domainsClient.ConfigureDnsSettings(request);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = domainsClient.PollOnceConfigureDnsSettings(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ConfigureDnsSettingsAsync</summary>
        public async Task ConfigureDnsSettingsRequestObjectAsync()
        {
            // Snippet: ConfigureDnsSettingsAsync(ConfigureDnsSettingsRequest, CallSettings)
            // Additional: ConfigureDnsSettingsAsync(ConfigureDnsSettingsRequest, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            ConfigureDnsSettingsRequest request = new ConfigureDnsSettingsRequest
            {
                RegistrationAsRegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
                DnsSettings = new DnsSettings(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Registration, OperationMetadata> response = await domainsClient.ConfigureDnsSettingsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = await domainsClient.PollOnceConfigureDnsSettingsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ConfigureDnsSettings</summary>
        public void ConfigureDnsSettings()
        {
            // Snippet: ConfigureDnsSettings(string, DnsSettings, FieldMask, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            string registration = "projects/[PROJECT]/locations/[LOCATION]/registrations/[REGISTRATION]";
            DnsSettings dnsSettings = new DnsSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Registration, OperationMetadata> response = domainsClient.ConfigureDnsSettings(registration, dnsSettings, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = domainsClient.PollOnceConfigureDnsSettings(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ConfigureDnsSettingsAsync</summary>
        public async Task ConfigureDnsSettingsAsync()
        {
            // Snippet: ConfigureDnsSettingsAsync(string, DnsSettings, FieldMask, CallSettings)
            // Additional: ConfigureDnsSettingsAsync(string, DnsSettings, FieldMask, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            string registration = "projects/[PROJECT]/locations/[LOCATION]/registrations/[REGISTRATION]";
            DnsSettings dnsSettings = new DnsSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Registration, OperationMetadata> response = await domainsClient.ConfigureDnsSettingsAsync(registration, dnsSettings, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = await domainsClient.PollOnceConfigureDnsSettingsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ConfigureDnsSettings</summary>
        public void ConfigureDnsSettingsResourceNames()
        {
            // Snippet: ConfigureDnsSettings(RegistrationName, DnsSettings, FieldMask, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            RegistrationName registration = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]");
            DnsSettings dnsSettings = new DnsSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Registration, OperationMetadata> response = domainsClient.ConfigureDnsSettings(registration, dnsSettings, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = domainsClient.PollOnceConfigureDnsSettings(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ConfigureDnsSettingsAsync</summary>
        public async Task ConfigureDnsSettingsResourceNamesAsync()
        {
            // Snippet: ConfigureDnsSettingsAsync(RegistrationName, DnsSettings, FieldMask, CallSettings)
            // Additional: ConfigureDnsSettingsAsync(RegistrationName, DnsSettings, FieldMask, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            RegistrationName registration = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]");
            DnsSettings dnsSettings = new DnsSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Registration, OperationMetadata> response = await domainsClient.ConfigureDnsSettingsAsync(registration, dnsSettings, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = await domainsClient.PollOnceConfigureDnsSettingsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ConfigureContactSettings</summary>
        public void ConfigureContactSettingsRequestObject()
        {
            // Snippet: ConfigureContactSettings(ConfigureContactSettingsRequest, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            ConfigureContactSettingsRequest request = new ConfigureContactSettingsRequest
            {
                RegistrationAsRegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
                ContactSettings = new ContactSettings(),
                UpdateMask = new FieldMask(),
                ContactNotices =
                {
                    ContactNotice.Unspecified,
                },
                ValidateOnly = false,
            };
            // Make the request
            Operation<Registration, OperationMetadata> response = domainsClient.ConfigureContactSettings(request);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = domainsClient.PollOnceConfigureContactSettings(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ConfigureContactSettingsAsync</summary>
        public async Task ConfigureContactSettingsRequestObjectAsync()
        {
            // Snippet: ConfigureContactSettingsAsync(ConfigureContactSettingsRequest, CallSettings)
            // Additional: ConfigureContactSettingsAsync(ConfigureContactSettingsRequest, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            ConfigureContactSettingsRequest request = new ConfigureContactSettingsRequest
            {
                RegistrationAsRegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
                ContactSettings = new ContactSettings(),
                UpdateMask = new FieldMask(),
                ContactNotices =
                {
                    ContactNotice.Unspecified,
                },
                ValidateOnly = false,
            };
            // Make the request
            Operation<Registration, OperationMetadata> response = await domainsClient.ConfigureContactSettingsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = await domainsClient.PollOnceConfigureContactSettingsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ConfigureContactSettings</summary>
        public void ConfigureContactSettings()
        {
            // Snippet: ConfigureContactSettings(string, ContactSettings, FieldMask, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            string registration = "projects/[PROJECT]/locations/[LOCATION]/registrations/[REGISTRATION]";
            ContactSettings contactSettings = new ContactSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Registration, OperationMetadata> response = domainsClient.ConfigureContactSettings(registration, contactSettings, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = domainsClient.PollOnceConfigureContactSettings(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ConfigureContactSettingsAsync</summary>
        public async Task ConfigureContactSettingsAsync()
        {
            // Snippet: ConfigureContactSettingsAsync(string, ContactSettings, FieldMask, CallSettings)
            // Additional: ConfigureContactSettingsAsync(string, ContactSettings, FieldMask, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            string registration = "projects/[PROJECT]/locations/[LOCATION]/registrations/[REGISTRATION]";
            ContactSettings contactSettings = new ContactSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Registration, OperationMetadata> response = await domainsClient.ConfigureContactSettingsAsync(registration, contactSettings, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = await domainsClient.PollOnceConfigureContactSettingsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ConfigureContactSettings</summary>
        public void ConfigureContactSettingsResourceNames()
        {
            // Snippet: ConfigureContactSettings(RegistrationName, ContactSettings, FieldMask, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            RegistrationName registration = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]");
            ContactSettings contactSettings = new ContactSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Registration, OperationMetadata> response = domainsClient.ConfigureContactSettings(registration, contactSettings, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = domainsClient.PollOnceConfigureContactSettings(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ConfigureContactSettingsAsync</summary>
        public async Task ConfigureContactSettingsResourceNamesAsync()
        {
            // Snippet: ConfigureContactSettingsAsync(RegistrationName, ContactSettings, FieldMask, CallSettings)
            // Additional: ConfigureContactSettingsAsync(RegistrationName, ContactSettings, FieldMask, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            RegistrationName registration = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]");
            ContactSettings contactSettings = new ContactSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Registration, OperationMetadata> response = await domainsClient.ConfigureContactSettingsAsync(registration, contactSettings, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = await domainsClient.PollOnceConfigureContactSettingsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportRegistration</summary>
        public void ExportRegistrationRequestObject()
        {
            // Snippet: ExportRegistration(ExportRegistrationRequest, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            ExportRegistrationRequest request = new ExportRegistrationRequest
            {
                RegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
            };
            // Make the request
            Operation<Registration, OperationMetadata> response = domainsClient.ExportRegistration(request);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = domainsClient.PollOnceExportRegistration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportRegistrationAsync</summary>
        public async Task ExportRegistrationRequestObjectAsync()
        {
            // Snippet: ExportRegistrationAsync(ExportRegistrationRequest, CallSettings)
            // Additional: ExportRegistrationAsync(ExportRegistrationRequest, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            ExportRegistrationRequest request = new ExportRegistrationRequest
            {
                RegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
            };
            // Make the request
            Operation<Registration, OperationMetadata> response = await domainsClient.ExportRegistrationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = await domainsClient.PollOnceExportRegistrationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportRegistration</summary>
        public void ExportRegistration()
        {
            // Snippet: ExportRegistration(string, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/registrations/[REGISTRATION]";
            // Make the request
            Operation<Registration, OperationMetadata> response = domainsClient.ExportRegistration(name);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = domainsClient.PollOnceExportRegistration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportRegistrationAsync</summary>
        public async Task ExportRegistrationAsync()
        {
            // Snippet: ExportRegistrationAsync(string, CallSettings)
            // Additional: ExportRegistrationAsync(string, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/registrations/[REGISTRATION]";
            // Make the request
            Operation<Registration, OperationMetadata> response = await domainsClient.ExportRegistrationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = await domainsClient.PollOnceExportRegistrationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportRegistration</summary>
        public void ExportRegistrationResourceNames()
        {
            // Snippet: ExportRegistration(RegistrationName, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            RegistrationName name = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]");
            // Make the request
            Operation<Registration, OperationMetadata> response = domainsClient.ExportRegistration(name);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = domainsClient.PollOnceExportRegistration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportRegistrationAsync</summary>
        public async Task ExportRegistrationResourceNamesAsync()
        {
            // Snippet: ExportRegistrationAsync(RegistrationName, CallSettings)
            // Additional: ExportRegistrationAsync(RegistrationName, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            RegistrationName name = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]");
            // Make the request
            Operation<Registration, OperationMetadata> response = await domainsClient.ExportRegistrationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = await domainsClient.PollOnceExportRegistrationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRegistration</summary>
        public void DeleteRegistrationRequestObject()
        {
            // Snippet: DeleteRegistration(DeleteRegistrationRequest, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            DeleteRegistrationRequest request = new DeleteRegistrationRequest
            {
                RegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = domainsClient.DeleteRegistration(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = domainsClient.PollOnceDeleteRegistration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRegistrationAsync</summary>
        public async Task DeleteRegistrationRequestObjectAsync()
        {
            // Snippet: DeleteRegistrationAsync(DeleteRegistrationRequest, CallSettings)
            // Additional: DeleteRegistrationAsync(DeleteRegistrationRequest, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRegistrationRequest request = new DeleteRegistrationRequest
            {
                RegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await domainsClient.DeleteRegistrationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await domainsClient.PollOnceDeleteRegistrationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRegistration</summary>
        public void DeleteRegistration()
        {
            // Snippet: DeleteRegistration(string, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/registrations/[REGISTRATION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = domainsClient.DeleteRegistration(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = domainsClient.PollOnceDeleteRegistration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRegistrationAsync</summary>
        public async Task DeleteRegistrationAsync()
        {
            // Snippet: DeleteRegistrationAsync(string, CallSettings)
            // Additional: DeleteRegistrationAsync(string, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/registrations/[REGISTRATION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await domainsClient.DeleteRegistrationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await domainsClient.PollOnceDeleteRegistrationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRegistration</summary>
        public void DeleteRegistrationResourceNames()
        {
            // Snippet: DeleteRegistration(RegistrationName, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            RegistrationName name = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = domainsClient.DeleteRegistration(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = domainsClient.PollOnceDeleteRegistration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRegistrationAsync</summary>
        public async Task DeleteRegistrationResourceNamesAsync()
        {
            // Snippet: DeleteRegistrationAsync(RegistrationName, CallSettings)
            // Additional: DeleteRegistrationAsync(RegistrationName, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            RegistrationName name = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await domainsClient.DeleteRegistrationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await domainsClient.PollOnceDeleteRegistrationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RetrieveAuthorizationCode</summary>
        public void RetrieveAuthorizationCodeRequestObject()
        {
            // Snippet: RetrieveAuthorizationCode(RetrieveAuthorizationCodeRequest, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            RetrieveAuthorizationCodeRequest request = new RetrieveAuthorizationCodeRequest
            {
                RegistrationAsRegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
            };
            // Make the request
            AuthorizationCode response = domainsClient.RetrieveAuthorizationCode(request);
            // End snippet
        }

        /// <summary>Snippet for RetrieveAuthorizationCodeAsync</summary>
        public async Task RetrieveAuthorizationCodeRequestObjectAsync()
        {
            // Snippet: RetrieveAuthorizationCodeAsync(RetrieveAuthorizationCodeRequest, CallSettings)
            // Additional: RetrieveAuthorizationCodeAsync(RetrieveAuthorizationCodeRequest, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            RetrieveAuthorizationCodeRequest request = new RetrieveAuthorizationCodeRequest
            {
                RegistrationAsRegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
            };
            // Make the request
            AuthorizationCode response = await domainsClient.RetrieveAuthorizationCodeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RetrieveAuthorizationCode</summary>
        public void RetrieveAuthorizationCode()
        {
            // Snippet: RetrieveAuthorizationCode(string, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            string registration = "projects/[PROJECT]/locations/[LOCATION]/registrations/[REGISTRATION]";
            // Make the request
            AuthorizationCode response = domainsClient.RetrieveAuthorizationCode(registration);
            // End snippet
        }

        /// <summary>Snippet for RetrieveAuthorizationCodeAsync</summary>
        public async Task RetrieveAuthorizationCodeAsync()
        {
            // Snippet: RetrieveAuthorizationCodeAsync(string, CallSettings)
            // Additional: RetrieveAuthorizationCodeAsync(string, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            string registration = "projects/[PROJECT]/locations/[LOCATION]/registrations/[REGISTRATION]";
            // Make the request
            AuthorizationCode response = await domainsClient.RetrieveAuthorizationCodeAsync(registration);
            // End snippet
        }

        /// <summary>Snippet for RetrieveAuthorizationCode</summary>
        public void RetrieveAuthorizationCodeResourceNames()
        {
            // Snippet: RetrieveAuthorizationCode(RegistrationName, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            RegistrationName registration = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]");
            // Make the request
            AuthorizationCode response = domainsClient.RetrieveAuthorizationCode(registration);
            // End snippet
        }

        /// <summary>Snippet for RetrieveAuthorizationCodeAsync</summary>
        public async Task RetrieveAuthorizationCodeResourceNamesAsync()
        {
            // Snippet: RetrieveAuthorizationCodeAsync(RegistrationName, CallSettings)
            // Additional: RetrieveAuthorizationCodeAsync(RegistrationName, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            RegistrationName registration = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]");
            // Make the request
            AuthorizationCode response = await domainsClient.RetrieveAuthorizationCodeAsync(registration);
            // End snippet
        }

        /// <summary>Snippet for ResetAuthorizationCode</summary>
        public void ResetAuthorizationCodeRequestObject()
        {
            // Snippet: ResetAuthorizationCode(ResetAuthorizationCodeRequest, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            ResetAuthorizationCodeRequest request = new ResetAuthorizationCodeRequest
            {
                RegistrationAsRegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
            };
            // Make the request
            AuthorizationCode response = domainsClient.ResetAuthorizationCode(request);
            // End snippet
        }

        /// <summary>Snippet for ResetAuthorizationCodeAsync</summary>
        public async Task ResetAuthorizationCodeRequestObjectAsync()
        {
            // Snippet: ResetAuthorizationCodeAsync(ResetAuthorizationCodeRequest, CallSettings)
            // Additional: ResetAuthorizationCodeAsync(ResetAuthorizationCodeRequest, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            ResetAuthorizationCodeRequest request = new ResetAuthorizationCodeRequest
            {
                RegistrationAsRegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
            };
            // Make the request
            AuthorizationCode response = await domainsClient.ResetAuthorizationCodeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ResetAuthorizationCode</summary>
        public void ResetAuthorizationCode()
        {
            // Snippet: ResetAuthorizationCode(string, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            string registration = "projects/[PROJECT]/locations/[LOCATION]/registrations/[REGISTRATION]";
            // Make the request
            AuthorizationCode response = domainsClient.ResetAuthorizationCode(registration);
            // End snippet
        }

        /// <summary>Snippet for ResetAuthorizationCodeAsync</summary>
        public async Task ResetAuthorizationCodeAsync()
        {
            // Snippet: ResetAuthorizationCodeAsync(string, CallSettings)
            // Additional: ResetAuthorizationCodeAsync(string, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            string registration = "projects/[PROJECT]/locations/[LOCATION]/registrations/[REGISTRATION]";
            // Make the request
            AuthorizationCode response = await domainsClient.ResetAuthorizationCodeAsync(registration);
            // End snippet
        }

        /// <summary>Snippet for ResetAuthorizationCode</summary>
        public void ResetAuthorizationCodeResourceNames()
        {
            // Snippet: ResetAuthorizationCode(RegistrationName, CallSettings)
            // Create client
            DomainsClient domainsClient = DomainsClient.Create();
            // Initialize request argument(s)
            RegistrationName registration = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]");
            // Make the request
            AuthorizationCode response = domainsClient.ResetAuthorizationCode(registration);
            // End snippet
        }

        /// <summary>Snippet for ResetAuthorizationCodeAsync</summary>
        public async Task ResetAuthorizationCodeResourceNamesAsync()
        {
            // Snippet: ResetAuthorizationCodeAsync(RegistrationName, CallSettings)
            // Additional: ResetAuthorizationCodeAsync(RegistrationName, CancellationToken)
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            RegistrationName registration = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]");
            // Make the request
            AuthorizationCode response = await domainsClient.ResetAuthorizationCodeAsync(registration);
            // End snippet
        }
    }
}
