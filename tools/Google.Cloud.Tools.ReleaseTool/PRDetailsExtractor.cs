// Copyright 2023 Google LLC
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

using System.Text.RegularExpressions;

namespace Google.Cloud.Tools.ReleaseTool
{
    public class PRDetailsExtractor
    {
        public static PrDetails ExtractPRDetails(string pr)
        {
            var match = Regex.Match(pr, @"https://github\.com/(?<owner>.+?)/(?<repo>.+?)/pull/(?<number>\d+?)$");

            if (match == null)
            {
                throw new Exception("Not a PR URL.");
            }

            var res = Tuple.Create(match.Groups["owner"].Value, match.Groups["repo"].Value, match.Groups["number"].Value);
            return new PrDetails(Convert.ToInt32(res.Item3), res.Item1, res.Item2);
        }
    }
}
