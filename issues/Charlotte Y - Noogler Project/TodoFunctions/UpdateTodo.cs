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

using Google.Cloud.Firestore;
using System.Threading.Tasks;

namespace TodoFunctions;

/// <summary>
/// Cloud Function to update a todo item in the Todo Application
/// </summary>
public class UpdateTodo : AbstractTodoFunction
{
    protected override bool ValidateRequest(TodoData todoData)
    {
        string userId = todoData.UserId;
        string taskId = todoData.TaskId;
        string title = todoData.Title;
        string description = todoData.Description;
        int? priority = todoData.Priority;

        // UserID and taskId must not be null or empty. Any user provided string value should not be empty. Priority must be an integer between 1 to 5.
        return userId is not null
            && taskId is not null
            && userId != ""
            && taskId != ""
            && (title is null || title != "")
            && (description is null || description != "")
            && (priority is null || 1 <= priority && priority <= 5);
    }
    protected override async Task<string> PerformOperation(TodoData todoData)
    {
        // update the document
        string documentId = $"{todoData.UserId}-{todoData.TaskId}";
        await TodoItemsCollection.Document(documentId).UpdateAsync(todoData.PrepareForUpdate(), Precondition.MustExist);

        return $"Successfully updated task {documentId}\n";
    }
}
