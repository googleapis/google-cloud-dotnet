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

using System.Threading.Tasks;

namespace TodoFunctions;

/// <summary>
/// Cloud Function to create a todo item in the Todo Application.
/// </summary>
public class CreateTodo : AbstractTodoFunction
{
    protected override bool ValidateRequest(TodoData todoData)
    {
        string userId = todoData.UserId;
        string title = todoData.Title;
        string description = todoData.Description;
        int? priority = todoData.Priority;

        // UserID, title, and description must not be null or empty. Priority must be an integer between 1 to 5.
        return userId is not null
            && title is not null
            && description is not null
            && userId != ""
            && title != ""
            && description != ""
            && (priority is null || (1 <= priority && priority <= 5));
    }
    protected override async Task<string> PerformOperation(TodoData todoData)
    {
        // prepare the object before creating
        todoData.PrepareForCreate();

        // create the document
        string documentId = $"{todoData.UserId}-{todoData.TaskId}";
        await TodoItemsCollection.Document(documentId).CreateAsync(todoData);

        return $"Successfully created new task {documentId}\n";
    }
}
