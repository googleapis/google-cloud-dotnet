// Copyright 2019 Google LLC
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

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Google.Cloud.Tools.VersionCompat
{
    public class DiffResult
    {
        public DiffResult(IEnumerable<Diff> diffs) => All = diffs.ToImmutableList();
        public IReadOnlyList<Diff> All { get; }
        public IEnumerable<Diff> Major => All.Where(x => x.Level == Level.Major);
        public IEnumerable<Diff> Minor => All.Where(x => x.Level == Level.Minor);
        public Level Level => Major.Any() ? Level.Major : Minor.Any() ? Level.Minor : Level.Identical;

        public void PrintDifferences(Level level, FormatDetail detail)
        {
            var diffs = All.Where(x => x.Level == level);
            if (!diffs.Any())
            {
                return;
            }
            Console.WriteLine($"{level} changes:");
            foreach (var diff in All.Where(x => x.Level == level))
            {
                Console.WriteLine(diff.ToString(detail));
            }
            Console.WriteLine();
        }
    }
}
