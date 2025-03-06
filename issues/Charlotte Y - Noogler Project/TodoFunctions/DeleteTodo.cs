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
/// Cloud Function to delete a todo item in the Todo Application
/// </summary>
public class DeleteTodo : AbstractTodoFunction
{

    protected override bool ValidateRequest(TodoData todoData)
    {
        string userId = todoData.UserId;
        string taskId = todoData.TaskId;

        // UserID and taskId must not be null or empty.
        return userId is not null
            && taskId is not null
            && userId != ""
            && taskId != "";
    }

    protected override async Task<string> PerformOperation(TodoData todoData)
    {
        // delete the document
        string documentId = $"{todoData.UserId}-{todoData.TaskId}";
        await TodoItemsCollection.Document(documentId).DeleteAsync(Precondition.MustExist);

        return $"Successfully deleted task {documentId}\n";
    }
}
