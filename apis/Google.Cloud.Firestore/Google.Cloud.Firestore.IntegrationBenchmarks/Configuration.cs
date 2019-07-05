// Copyright 2019, Google LLC
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

namespace Google.Cloud.Firestore.IntegrationBenchmarks
{
    /// <summary>
    /// Configuration for a particular run.
    /// </summary>
    public class Configuration
    {
        /// <summary>
        /// Description for the configuration, e.g. where it's running, or the hypothesis it's testing.
        /// </summary>
        public string Description { get; set; }
        
        /// <summary>
        /// The Firestore project ID.
        /// </summary>
        public string ProjectId { get; set; }
        
        /// <summary>
        /// The number of tasks to run concurrently.
        /// </summary>
        public int TaskCount { get; set; }
        
        /// <summary>
        /// The number of batches to write.
        /// </summary>
        public int Batches { get; set; }

        /// <summary>
        /// The size of each batch, i.e. how many documents to create in each.
        /// </summary>
        public int BatchSize { get; set; }
        
        /// <summary>
        /// The size of the <see cref="SampleDocument.Data"/> field in each document, in bytes.
        /// </summary>
        public int DataSize { get; set; }
        
        /// <summary>
        /// The number of <see cref="FirestoreDb"/> instances to create and use in a round-robin fashion.
        /// </summary>
        public int PoolSize { get; set; }
        
        /// <summary>
        /// Storage buckets to write results into, or null to only write results locally.
        /// </summary>
        public string StorageBucket { get; set; }
        
        /// <summary>
        /// The prefix to use for the collection within Firestore.
        /// A run-specific date/time-based suffix is appended to this so each run has its own collection.
        /// </summary>
        public string CollectionPrefix { get; set; }
        
        /// <summary>
        /// How many batch commits we try to execute per second.
        /// </summary>
        public int TargetQps { get; set; }
    }
}
