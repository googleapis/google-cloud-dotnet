// Copyright 2025 Google Inc. All Rights Reserved.
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

using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore;
using Google.Cloud.Functions.Framework;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TodoFunctions;

/// <summary>
/// Abstract parent class for CRUD functions on the Todo application.
/// </summary>
public abstract class AbstractTodoFunction : IHttpFunction
{
    private const string ProjectId = "REDACTED";
    private const string DatabaseId = "todo-application";
    private const string CollectionId = "todo-items";
    private static readonly Lazy<FirebaseAuth> _firebaseAuth = new Lazy<FirebaseAuth>(() => FirebaseAuth.GetAuth(FirebaseApp.Create(new AppOptions()
    {
        Credential = GoogleCredential.GetApplicationDefault(),
        ProjectId = ProjectId,
    })));
    private static FirebaseAuth FirebaseAuth => _firebaseAuth.Value;
    private static readonly Lazy<FirestoreDb> _firebaseDb = new Lazy<FirestoreDb>(() => new FirestoreDbBuilder { ProjectId = ProjectId, DatabaseId = DatabaseId }.Build());
    private static FirestoreDb FirebaseDb => _firebaseDb.Value;
    private static readonly Lazy<CollectionReference> _todoItemsCollection = new Lazy<CollectionReference>(() => FirebaseDb.Collection(CollectionId));
    protected static CollectionReference TodoItemsCollection => _todoItemsCollection.Value;
    protected static readonly JsonSerializerOptions SerializerOptions = new JsonSerializerOptions()
    {
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        Converters = { new JsonStringEnumConverter(), new FirestoreTimestampConverter() }
    };

    /// <summary>
    /// Main method for the CRUD operations. Authenticates user, validates the inputs, executes the DB operation, and prints results in the response.
    /// </summary>
    /// <param name="context">Object for the HTTP Request</param>
    /// <returns>void</returns>
    public async Task HandleAsync(HttpContext context)
    {

        // authenticate and parse request
        TodoData todoData = await AuthenticateAndParseRequest(context);

        // validate request
        bool isValid = ValidateRequest(todoData);
        if (!isValid)
        {
            await context.Response.WriteAsync("Request is not valid\n");
            return;
        }

        // perform operation
        try
        {
            string output = await PerformOperation(todoData);
            await context.Response.WriteAsync(output);
        }
        catch (Exception e)
        {
            await context.Response.WriteAsync($"{e.Message}\n");
        }
    }

    /// <summary>
    /// Authenticates user and deserializes the request body into TodoData object and returns it
    /// </summary>
    /// <param name="context">Object for the HTTP Request</param>
    /// <returns>TodoData object</returns>
    private static async Task<TodoData> AuthenticateAndParseRequest(HttpContext context)
    {

        using StreamReader reader = new StreamReader(context.Request.Body);
        try
        {
            // deserialize request body
            string body = await reader.ReadToEndAsync();
            TodoData todoData = JsonSerializer.Deserialize<TodoData>(body, SerializerOptions);

            // authenticate user and get user email
            FirebaseToken token = await FirebaseAuth.VerifyIdTokenAsync(todoData.IdToken);
            UserRecord userRecord = await FirebaseAuth.GetUserAsync(token.Uid);
            todoData.UserId = userRecord.Email;

            // set IdToken to null to avoid printing it out or storing it
            todoData.IdToken = null;

            await context.Response.WriteAsync($"Request Body: {JsonSerializer.Serialize(todoData, SerializerOptions)}\n");
            return todoData;
        }
        catch (Exception ex)
        {
            await context.Response.WriteAsync($"{ex.Message}\n");
            throw;
        }
    }

    /// <summary>
    /// Performs validation on inputs
    /// </summary>
    /// <param name="todoData">TodoData object</param>
    /// <returns>true if valid, false otherwise</returns>
    protected abstract bool ValidateRequest(TodoData todoData);

    /// <summary>
    /// Calls the Firestore client to perform DB operations
    /// </summary>
    /// <param name="todoData">TodoData object</param>
    /// <returns>Result string</returns>
    protected abstract Task<string> PerformOperation(TodoData todoData);
}
