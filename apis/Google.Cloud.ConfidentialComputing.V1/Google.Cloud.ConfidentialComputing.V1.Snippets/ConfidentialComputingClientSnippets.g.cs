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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.ConfidentialComputing.V1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedConfidentialComputingClientSnippets
    {
        /// <summary>Snippet for CreateChallenge</summary>
        public void CreateChallengeRequestObject()
        {
            // Snippet: CreateChallenge(CreateChallengeRequest, CallSettings)
            // Create client
            ConfidentialComputingClient confidentialComputingClient = ConfidentialComputingClient.Create();
            // Initialize request argument(s)
            CreateChallengeRequest request = new CreateChallengeRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Challenge = new Challenge(),
            };
            // Make the request
            Challenge response = confidentialComputingClient.CreateChallenge(request);
            // End snippet
        }

        /// <summary>Snippet for CreateChallengeAsync</summary>
        public async Task CreateChallengeRequestObjectAsync()
        {
            // Snippet: CreateChallengeAsync(CreateChallengeRequest, CallSettings)
            // Additional: CreateChallengeAsync(CreateChallengeRequest, CancellationToken)
            // Create client
            ConfidentialComputingClient confidentialComputingClient = await ConfidentialComputingClient.CreateAsync();
            // Initialize request argument(s)
            CreateChallengeRequest request = new CreateChallengeRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Challenge = new Challenge(),
            };
            // Make the request
            Challenge response = await confidentialComputingClient.CreateChallengeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateChallenge</summary>
        public void CreateChallenge()
        {
            // Snippet: CreateChallenge(string, Challenge, CallSettings)
            // Create client
            ConfidentialComputingClient confidentialComputingClient = ConfidentialComputingClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Challenge challenge = new Challenge();
            // Make the request
            Challenge response = confidentialComputingClient.CreateChallenge(parent, challenge);
            // End snippet
        }

        /// <summary>Snippet for CreateChallengeAsync</summary>
        public async Task CreateChallengeAsync()
        {
            // Snippet: CreateChallengeAsync(string, Challenge, CallSettings)
            // Additional: CreateChallengeAsync(string, Challenge, CancellationToken)
            // Create client
            ConfidentialComputingClient confidentialComputingClient = await ConfidentialComputingClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Challenge challenge = new Challenge();
            // Make the request
            Challenge response = await confidentialComputingClient.CreateChallengeAsync(parent, challenge);
            // End snippet
        }

        /// <summary>Snippet for CreateChallenge</summary>
        public void CreateChallengeResourceNames()
        {
            // Snippet: CreateChallenge(LocationName, Challenge, CallSettings)
            // Create client
            ConfidentialComputingClient confidentialComputingClient = ConfidentialComputingClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Challenge challenge = new Challenge();
            // Make the request
            Challenge response = confidentialComputingClient.CreateChallenge(parent, challenge);
            // End snippet
        }

        /// <summary>Snippet for CreateChallengeAsync</summary>
        public async Task CreateChallengeResourceNamesAsync()
        {
            // Snippet: CreateChallengeAsync(LocationName, Challenge, CallSettings)
            // Additional: CreateChallengeAsync(LocationName, Challenge, CancellationToken)
            // Create client
            ConfidentialComputingClient confidentialComputingClient = await ConfidentialComputingClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Challenge challenge = new Challenge();
            // Make the request
            Challenge response = await confidentialComputingClient.CreateChallengeAsync(parent, challenge);
            // End snippet
        }

        /// <summary>Snippet for VerifyAttestation</summary>
        public void VerifyAttestationRequestObject()
        {
            // Snippet: VerifyAttestation(VerifyAttestationRequest, CallSettings)
            // Create client
            ConfidentialComputingClient confidentialComputingClient = ConfidentialComputingClient.Create();
            // Initialize request argument(s)
            VerifyAttestationRequest request = new VerifyAttestationRequest
            {
                ChallengeAsChallengeName = ChallengeName.FromProjectLocationUuid("[PROJECT]", "[LOCATION]", "[UUID]"),
                GcpCredentials = new GcpCredentials(),
                TpmAttestation = new TpmAttestation(),
                ConfidentialSpaceInfo = new ConfidentialSpaceInfo(),
                TokenOptions = new TokenOptions(),
                TdCcel = new TdxCcelAttestation(),
                Attester = "",
            };
            // Make the request
            VerifyAttestationResponse response = confidentialComputingClient.VerifyAttestation(request);
            // End snippet
        }

        /// <summary>Snippet for VerifyAttestationAsync</summary>
        public async Task VerifyAttestationRequestObjectAsync()
        {
            // Snippet: VerifyAttestationAsync(VerifyAttestationRequest, CallSettings)
            // Additional: VerifyAttestationAsync(VerifyAttestationRequest, CancellationToken)
            // Create client
            ConfidentialComputingClient confidentialComputingClient = await ConfidentialComputingClient.CreateAsync();
            // Initialize request argument(s)
            VerifyAttestationRequest request = new VerifyAttestationRequest
            {
                ChallengeAsChallengeName = ChallengeName.FromProjectLocationUuid("[PROJECT]", "[LOCATION]", "[UUID]"),
                GcpCredentials = new GcpCredentials(),
                TpmAttestation = new TpmAttestation(),
                ConfidentialSpaceInfo = new ConfidentialSpaceInfo(),
                TokenOptions = new TokenOptions(),
                TdCcel = new TdxCcelAttestation(),
                Attester = "",
            };
            // Make the request
            VerifyAttestationResponse response = await confidentialComputingClient.VerifyAttestationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for VerifyConfidentialSpace</summary>
        public void VerifyConfidentialSpaceRequestObject()
        {
            // Snippet: VerifyConfidentialSpace(VerifyConfidentialSpaceRequest, CallSettings)
            // Create client
            ConfidentialComputingClient confidentialComputingClient = ConfidentialComputingClient.Create();
            // Initialize request argument(s)
            VerifyConfidentialSpaceRequest request = new VerifyConfidentialSpaceRequest
            {
                ChallengeAsChallengeName = ChallengeName.FromProjectLocationUuid("[PROJECT]", "[LOCATION]", "[UUID]"),
                GcpCredentials = new GcpCredentials(),
                TdCcel = new TdxCcelAttestation(),
                SignedEntities = { new SignedEntity(), },
                GceShieldedIdentity = new GceShieldedIdentity(),
                Options = new VerifyConfidentialSpaceRequest.Types.ConfidentialSpaceOptions(),
            };
            // Make the request
            VerifyConfidentialSpaceResponse response = confidentialComputingClient.VerifyConfidentialSpace(request);
            // End snippet
        }

        /// <summary>Snippet for VerifyConfidentialSpaceAsync</summary>
        public async Task VerifyConfidentialSpaceRequestObjectAsync()
        {
            // Snippet: VerifyConfidentialSpaceAsync(VerifyConfidentialSpaceRequest, CallSettings)
            // Additional: VerifyConfidentialSpaceAsync(VerifyConfidentialSpaceRequest, CancellationToken)
            // Create client
            ConfidentialComputingClient confidentialComputingClient = await ConfidentialComputingClient.CreateAsync();
            // Initialize request argument(s)
            VerifyConfidentialSpaceRequest request = new VerifyConfidentialSpaceRequest
            {
                ChallengeAsChallengeName = ChallengeName.FromProjectLocationUuid("[PROJECT]", "[LOCATION]", "[UUID]"),
                GcpCredentials = new GcpCredentials(),
                TdCcel = new TdxCcelAttestation(),
                SignedEntities = { new SignedEntity(), },
                GceShieldedIdentity = new GceShieldedIdentity(),
                Options = new VerifyConfidentialSpaceRequest.Types.ConfidentialSpaceOptions(),
            };
            // Make the request
            VerifyConfidentialSpaceResponse response = await confidentialComputingClient.VerifyConfidentialSpaceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for VerifyConfidentialGke</summary>
        public void VerifyConfidentialGkeRequestObject()
        {
            // Snippet: VerifyConfidentialGke(VerifyConfidentialGkeRequest, CallSettings)
            // Create client
            ConfidentialComputingClient confidentialComputingClient = ConfidentialComputingClient.Create();
            // Initialize request argument(s)
            VerifyConfidentialGkeRequest request = new VerifyConfidentialGkeRequest
            {
                ChallengeAsChallengeName = ChallengeName.FromProjectLocationUuid("[PROJECT]", "[LOCATION]", "[UUID]"),
                TpmAttestation = new TpmAttestation(),
            };
            // Make the request
            VerifyConfidentialGkeResponse response = confidentialComputingClient.VerifyConfidentialGke(request);
            // End snippet
        }

        /// <summary>Snippet for VerifyConfidentialGkeAsync</summary>
        public async Task VerifyConfidentialGkeRequestObjectAsync()
        {
            // Snippet: VerifyConfidentialGkeAsync(VerifyConfidentialGkeRequest, CallSettings)
            // Additional: VerifyConfidentialGkeAsync(VerifyConfidentialGkeRequest, CancellationToken)
            // Create client
            ConfidentialComputingClient confidentialComputingClient = await ConfidentialComputingClient.CreateAsync();
            // Initialize request argument(s)
            VerifyConfidentialGkeRequest request = new VerifyConfidentialGkeRequest
            {
                ChallengeAsChallengeName = ChallengeName.FromProjectLocationUuid("[PROJECT]", "[LOCATION]", "[UUID]"),
                TpmAttestation = new TpmAttestation(),
            };
            // Make the request
            VerifyConfidentialGkeResponse response = await confidentialComputingClient.VerifyConfidentialGkeAsync(request);
            // End snippet
        }
    }
}
