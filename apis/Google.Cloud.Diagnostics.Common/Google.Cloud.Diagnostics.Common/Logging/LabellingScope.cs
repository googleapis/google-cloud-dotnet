// Copyright 2021 Google LLC
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

using Google.Cloud.Logging.V2;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Represents the data for the labelling scope, basically, labels.
    /// </summary>
    // Note: We implement IEnumerable for the benefit of other ILogger implementations,
    // so they can represent this information as they see fit.
    internal class LabellingScopeState : IEnumerable<KeyValuePair<string, object>>
    {
        /// <summary>
        /// Creates a new <see cref="LabellingScopeState"/> for the given labels.
        /// </summary>
        public LabellingScopeState(IEnumerable<KeyValuePair<string, string>> labels)
        {
            var dictionary = new Dictionary<string, string>();
            if (labels != null)
            {
                foreach(var pair in labels)
                {
                    // Let's do this to allow overriding
                    dictionary[pair.Key] = pair.Value;
                }
            }
            Labels = new ReadOnlyDictionary<string, string>(dictionary);
        }

        internal LabellingScopeState(params KeyValuePair<string, string>[] labels)
            : this(labels.AsEnumerable())
        { }

        /// <summary>
        /// Labels contained by this state. Won't be null but may be empty.
        /// </summary>
        public IReadOnlyDictionary<string, string> Labels { get; }

        /// <inheritdoc/>
        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() => 
            Labels.Select(pair => new KeyValuePair<string, object>(pair.Key, pair.Value)).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        /// <summary>
        /// Returns a string representing the given labels with the format:
        /// ['key1'='value1']['key2'='value2']...
        /// </summary>
        // Note: we do this for the benefit of other ILogger implementations.
        // If they want to represent this information in a different format
        // they can use the enumerator to iterate over all the labels and their values.
        public override string ToString() => Labels.ToDefaultStringRepresentation();
    }

    /// <summary>
    /// Scope that adds the given labels to a log entry.
    /// </summary>
    internal class LabellingScope : GoogleLoggerScope<LabellingScopeState>
    {
        public LabellingScope(LabellingScopeState state, GoogleLoggerScope parent)
            :base(state, parent)
        { }

        protected internal override void ApplyThisScopeOnlyTo(LogEntry entry)
        {
            // We very explicitly don't call the base implementation of this
            // method which adds the state information to the scope field of the
            // LogEntry.JsonPayload. We know these to be labels so we add them
            // on the LogEntry.Labels collection.

            foreach(var pair in State.Labels)
            {
                // It's OK to override, these will get executed in the correct order.
                entry.Labels[pair.Key] = pair.Value;
            }
        }
    }
}
