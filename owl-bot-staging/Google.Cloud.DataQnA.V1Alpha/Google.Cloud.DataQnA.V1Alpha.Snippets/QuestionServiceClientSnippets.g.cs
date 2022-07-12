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

namespace Google.Cloud.DataQnA.V1Alpha.Snippets
{
    using Google.Api.Gax.ResourceNames;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedQuestionServiceClientSnippets
    {
        /// <summary>Snippet for GetQuestion</summary>
        public void GetQuestionRequestObject()
        {
            // Snippet: GetQuestion(GetQuestionRequest, CallSettings)
            // Create client
            QuestionServiceClient questionServiceClient = QuestionServiceClient.Create();
            // Initialize request argument(s)
            GetQuestionRequest request = new GetQuestionRequest
            {
                QuestionName = QuestionName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
                ReadMask = new FieldMask(),
            };
            // Make the request
            Question response = questionServiceClient.GetQuestion(request);
            // End snippet
        }

        /// <summary>Snippet for GetQuestionAsync</summary>
        public async Task GetQuestionRequestObjectAsync()
        {
            // Snippet: GetQuestionAsync(GetQuestionRequest, CallSettings)
            // Additional: GetQuestionAsync(GetQuestionRequest, CancellationToken)
            // Create client
            QuestionServiceClient questionServiceClient = await QuestionServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetQuestionRequest request = new GetQuestionRequest
            {
                QuestionName = QuestionName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
                ReadMask = new FieldMask(),
            };
            // Make the request
            Question response = await questionServiceClient.GetQuestionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetQuestion</summary>
        public void GetQuestion()
        {
            // Snippet: GetQuestion(string, CallSettings)
            // Create client
            QuestionServiceClient questionServiceClient = QuestionServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/questions/[QUESTION]";
            // Make the request
            Question response = questionServiceClient.GetQuestion(name);
            // End snippet
        }

        /// <summary>Snippet for GetQuestionAsync</summary>
        public async Task GetQuestionAsync()
        {
            // Snippet: GetQuestionAsync(string, CallSettings)
            // Additional: GetQuestionAsync(string, CancellationToken)
            // Create client
            QuestionServiceClient questionServiceClient = await QuestionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/questions/[QUESTION]";
            // Make the request
            Question response = await questionServiceClient.GetQuestionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetQuestion</summary>
        public void GetQuestionResourceNames()
        {
            // Snippet: GetQuestion(QuestionName, CallSettings)
            // Create client
            QuestionServiceClient questionServiceClient = QuestionServiceClient.Create();
            // Initialize request argument(s)
            QuestionName name = QuestionName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]");
            // Make the request
            Question response = questionServiceClient.GetQuestion(name);
            // End snippet
        }

        /// <summary>Snippet for GetQuestionAsync</summary>
        public async Task GetQuestionResourceNamesAsync()
        {
            // Snippet: GetQuestionAsync(QuestionName, CallSettings)
            // Additional: GetQuestionAsync(QuestionName, CancellationToken)
            // Create client
            QuestionServiceClient questionServiceClient = await QuestionServiceClient.CreateAsync();
            // Initialize request argument(s)
            QuestionName name = QuestionName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]");
            // Make the request
            Question response = await questionServiceClient.GetQuestionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateQuestion</summary>
        public void CreateQuestionRequestObject()
        {
            // Snippet: CreateQuestion(CreateQuestionRequest, CallSettings)
            // Create client
            QuestionServiceClient questionServiceClient = QuestionServiceClient.Create();
            // Initialize request argument(s)
            CreateQuestionRequest request = new CreateQuestionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Question = new Question(),
            };
            // Make the request
            Question response = questionServiceClient.CreateQuestion(request);
            // End snippet
        }

        /// <summary>Snippet for CreateQuestionAsync</summary>
        public async Task CreateQuestionRequestObjectAsync()
        {
            // Snippet: CreateQuestionAsync(CreateQuestionRequest, CallSettings)
            // Additional: CreateQuestionAsync(CreateQuestionRequest, CancellationToken)
            // Create client
            QuestionServiceClient questionServiceClient = await QuestionServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateQuestionRequest request = new CreateQuestionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Question = new Question(),
            };
            // Make the request
            Question response = await questionServiceClient.CreateQuestionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateQuestion</summary>
        public void CreateQuestion()
        {
            // Snippet: CreateQuestion(string, Question, CallSettings)
            // Create client
            QuestionServiceClient questionServiceClient = QuestionServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Question question = new Question();
            // Make the request
            Question response = questionServiceClient.CreateQuestion(parent, question);
            // End snippet
        }

        /// <summary>Snippet for CreateQuestionAsync</summary>
        public async Task CreateQuestionAsync()
        {
            // Snippet: CreateQuestionAsync(string, Question, CallSettings)
            // Additional: CreateQuestionAsync(string, Question, CancellationToken)
            // Create client
            QuestionServiceClient questionServiceClient = await QuestionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Question question = new Question();
            // Make the request
            Question response = await questionServiceClient.CreateQuestionAsync(parent, question);
            // End snippet
        }

        /// <summary>Snippet for CreateQuestion</summary>
        public void CreateQuestionResourceNames()
        {
            // Snippet: CreateQuestion(LocationName, Question, CallSettings)
            // Create client
            QuestionServiceClient questionServiceClient = QuestionServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Question question = new Question();
            // Make the request
            Question response = questionServiceClient.CreateQuestion(parent, question);
            // End snippet
        }

        /// <summary>Snippet for CreateQuestionAsync</summary>
        public async Task CreateQuestionResourceNamesAsync()
        {
            // Snippet: CreateQuestionAsync(LocationName, Question, CallSettings)
            // Additional: CreateQuestionAsync(LocationName, Question, CancellationToken)
            // Create client
            QuestionServiceClient questionServiceClient = await QuestionServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Question question = new Question();
            // Make the request
            Question response = await questionServiceClient.CreateQuestionAsync(parent, question);
            // End snippet
        }

        /// <summary>Snippet for ExecuteQuestion</summary>
        public void ExecuteQuestionRequestObject()
        {
            // Snippet: ExecuteQuestion(ExecuteQuestionRequest, CallSettings)
            // Create client
            QuestionServiceClient questionServiceClient = QuestionServiceClient.Create();
            // Initialize request argument(s)
            ExecuteQuestionRequest request = new ExecuteQuestionRequest
            {
                Name = "",
                InterpretationIndex = 0,
            };
            // Make the request
            Question response = questionServiceClient.ExecuteQuestion(request);
            // End snippet
        }

        /// <summary>Snippet for ExecuteQuestionAsync</summary>
        public async Task ExecuteQuestionRequestObjectAsync()
        {
            // Snippet: ExecuteQuestionAsync(ExecuteQuestionRequest, CallSettings)
            // Additional: ExecuteQuestionAsync(ExecuteQuestionRequest, CancellationToken)
            // Create client
            QuestionServiceClient questionServiceClient = await QuestionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExecuteQuestionRequest request = new ExecuteQuestionRequest
            {
                Name = "",
                InterpretationIndex = 0,
            };
            // Make the request
            Question response = await questionServiceClient.ExecuteQuestionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ExecuteQuestion</summary>
        public void ExecuteQuestion()
        {
            // Snippet: ExecuteQuestion(string, int, CallSettings)
            // Create client
            QuestionServiceClient questionServiceClient = QuestionServiceClient.Create();
            // Initialize request argument(s)
            string name = "";
            int interpretationIndex = 0;
            // Make the request
            Question response = questionServiceClient.ExecuteQuestion(name, interpretationIndex);
            // End snippet
        }

        /// <summary>Snippet for ExecuteQuestionAsync</summary>
        public async Task ExecuteQuestionAsync()
        {
            // Snippet: ExecuteQuestionAsync(string, int, CallSettings)
            // Additional: ExecuteQuestionAsync(string, int, CancellationToken)
            // Create client
            QuestionServiceClient questionServiceClient = await QuestionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            int interpretationIndex = 0;
            // Make the request
            Question response = await questionServiceClient.ExecuteQuestionAsync(name, interpretationIndex);
            // End snippet
        }

        /// <summary>Snippet for GetUserFeedback</summary>
        public void GetUserFeedbackRequestObject()
        {
            // Snippet: GetUserFeedback(GetUserFeedbackRequest, CallSettings)
            // Create client
            QuestionServiceClient questionServiceClient = QuestionServiceClient.Create();
            // Initialize request argument(s)
            GetUserFeedbackRequest request = new GetUserFeedbackRequest
            {
                UserFeedbackName = UserFeedbackName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
            };
            // Make the request
            UserFeedback response = questionServiceClient.GetUserFeedback(request);
            // End snippet
        }

        /// <summary>Snippet for GetUserFeedbackAsync</summary>
        public async Task GetUserFeedbackRequestObjectAsync()
        {
            // Snippet: GetUserFeedbackAsync(GetUserFeedbackRequest, CallSettings)
            // Additional: GetUserFeedbackAsync(GetUserFeedbackRequest, CancellationToken)
            // Create client
            QuestionServiceClient questionServiceClient = await QuestionServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetUserFeedbackRequest request = new GetUserFeedbackRequest
            {
                UserFeedbackName = UserFeedbackName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]"),
            };
            // Make the request
            UserFeedback response = await questionServiceClient.GetUserFeedbackAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetUserFeedback</summary>
        public void GetUserFeedback()
        {
            // Snippet: GetUserFeedback(string, CallSettings)
            // Create client
            QuestionServiceClient questionServiceClient = QuestionServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/questions/[QUESTION]/userFeedback";
            // Make the request
            UserFeedback response = questionServiceClient.GetUserFeedback(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserFeedbackAsync</summary>
        public async Task GetUserFeedbackAsync()
        {
            // Snippet: GetUserFeedbackAsync(string, CallSettings)
            // Additional: GetUserFeedbackAsync(string, CancellationToken)
            // Create client
            QuestionServiceClient questionServiceClient = await QuestionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/questions/[QUESTION]/userFeedback";
            // Make the request
            UserFeedback response = await questionServiceClient.GetUserFeedbackAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserFeedback</summary>
        public void GetUserFeedbackResourceNames()
        {
            // Snippet: GetUserFeedback(UserFeedbackName, CallSettings)
            // Create client
            QuestionServiceClient questionServiceClient = QuestionServiceClient.Create();
            // Initialize request argument(s)
            UserFeedbackName name = UserFeedbackName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]");
            // Make the request
            UserFeedback response = questionServiceClient.GetUserFeedback(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserFeedbackAsync</summary>
        public async Task GetUserFeedbackResourceNamesAsync()
        {
            // Snippet: GetUserFeedbackAsync(UserFeedbackName, CallSettings)
            // Additional: GetUserFeedbackAsync(UserFeedbackName, CancellationToken)
            // Create client
            QuestionServiceClient questionServiceClient = await QuestionServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserFeedbackName name = UserFeedbackName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]");
            // Make the request
            UserFeedback response = await questionServiceClient.GetUserFeedbackAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserFeedback</summary>
        public void UpdateUserFeedbackRequestObject()
        {
            // Snippet: UpdateUserFeedback(UpdateUserFeedbackRequest, CallSettings)
            // Create client
            QuestionServiceClient questionServiceClient = QuestionServiceClient.Create();
            // Initialize request argument(s)
            UpdateUserFeedbackRequest request = new UpdateUserFeedbackRequest
            {
                UserFeedback = new UserFeedback(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            UserFeedback response = questionServiceClient.UpdateUserFeedback(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserFeedbackAsync</summary>
        public async Task UpdateUserFeedbackRequestObjectAsync()
        {
            // Snippet: UpdateUserFeedbackAsync(UpdateUserFeedbackRequest, CallSettings)
            // Additional: UpdateUserFeedbackAsync(UpdateUserFeedbackRequest, CancellationToken)
            // Create client
            QuestionServiceClient questionServiceClient = await QuestionServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateUserFeedbackRequest request = new UpdateUserFeedbackRequest
            {
                UserFeedback = new UserFeedback(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            UserFeedback response = await questionServiceClient.UpdateUserFeedbackAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserFeedback</summary>
        public void UpdateUserFeedback()
        {
            // Snippet: UpdateUserFeedback(UserFeedback, FieldMask, CallSettings)
            // Create client
            QuestionServiceClient questionServiceClient = QuestionServiceClient.Create();
            // Initialize request argument(s)
            UserFeedback userFeedback = new UserFeedback();
            FieldMask updateMask = new FieldMask();
            // Make the request
            UserFeedback response = questionServiceClient.UpdateUserFeedback(userFeedback, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserFeedbackAsync</summary>
        public async Task UpdateUserFeedbackAsync()
        {
            // Snippet: UpdateUserFeedbackAsync(UserFeedback, FieldMask, CallSettings)
            // Additional: UpdateUserFeedbackAsync(UserFeedback, FieldMask, CancellationToken)
            // Create client
            QuestionServiceClient questionServiceClient = await QuestionServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserFeedback userFeedback = new UserFeedback();
            FieldMask updateMask = new FieldMask();
            // Make the request
            UserFeedback response = await questionServiceClient.UpdateUserFeedbackAsync(userFeedback, updateMask);
            // End snippet
        }
    }
}
