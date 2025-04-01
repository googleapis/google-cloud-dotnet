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

namespace Google.Cloud.Tools.ReleaseManager.History
{
    /// <summary>
    /// Note: the ordering here is the order in which the results are shown in the
    /// release notes.
    /// </summary>
    public enum ReleaseNoteElementType
    {
        Fix,
        Feature,
        Docs,
        Chore,
        BreakingChange,
        // Any conventional commit type which is effectively a placeholder for
        // later "real" elements. (This will be skipped.)
        Placeholder,
        Unknown,
    }
}
