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

using Google.Cloud.Vision.V1;
using System;

namespace Google.Cloud.Docs.Snippets;

public class LongRunningOperationsSnippets
{
    public void PollUntilCompleted()
    {
        // Note: not a test; we don't want to run this code.
        // (We have no input file etc.)

        // Sample: PollUntilCompleted
        var client = ImageAnnotatorClient.Create();
        var textDetectionFeature = new Feature
        {
            Type = Feature.Types.Type.DocumentTextDetection,
            Model = "builtin/latest"
        };
        var request = new AsyncAnnotateFileRequest
        {
            Features = { textDetectionFeature },
            InputConfig = { GcsSource = new GcsSource { Uri = "gs://..." } },
            OutputConfig = { GcsDestination = new GcsDestination { Uri = "gs://..." } }
        };

        var batchRequest = new AsyncBatchAnnotateFilesRequest
        {
            Parent = "...",
            Requests = { request }
        };
        var operation = client.AsyncBatchAnnotateFiles(batchRequest);

        // Almost certainly False at this point
        Console.WriteLine(operation.IsCompleted);

        // Poll until the operation is completed. Note that this
        // can block *forever* with the default poll settings.
        operation = operation.PollUntilCompleted();

        // Print out the final result (or throw an exception if it failed).
        Console.WriteLine(operation.Result);
        // End sample
    }
}
