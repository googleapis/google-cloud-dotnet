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


// This console application finds all the yml files in the specified directory,
// and removes any XML escaping from summary comments, only within backticks.

using System.Text;
using System.Text.RegularExpressions;

if (args.Length != 1)
{
    Console.WriteLine("Error: specify the directory containing metadata files");
    return 1;
}

Regex summaryRegex = new Regex("^  summary: \"(.*)\"$");

foreach (var file in Directory.GetFiles(args[0], "*.yml"))
{
    if (Path.GetFileName(file) == "toc.yml")
    {
        continue;
    }
    var lines = File.ReadAllLines(file);
    for (int i = 0; i < lines.Length; i++)
    {
        var match = summaryRegex.Match(lines[i]);
        if (match.Success)
        {
            var unescaped = Unescape(match.Groups[1].Value);
            lines[i] = $"  summary: \"{unescaped}\"";
        }
    }
    File.WriteAllLines(file, lines);
}
return 0;

string Unescape(string summary)
{
    if (summary.Length < 5 || !summary.Contains("&amp;") && !summary.Contains("&lt;"))
    {
        return summary;
    }
    bool inBackticks = false;
    StringBuilder builder = new StringBuilder();
    for (int i = 0; i < summary.Length - 5; i++)
    {
        if (summary[i] == '`')
        {
            inBackticks = !inBackticks;
        }
        if (inBackticks && summary[i] == '&' && summary.Substring(i, 5) == "&amp;")
        {
            builder.Append("&");
            i += 4;
        }
        else if (inBackticks && summary[i] == '&' && summary.Substring(i, 4) == "&lt;")
        {
            builder.Append("<");
            i += 3;
        }
        else if (inBackticks && summary[i] == '&' && summary.Substring(i, 4) == "&gt;")
        {
            builder.Append(">");
            i += 3;
        }
        else
        {
            builder.Append(summary[i]);
        }
    }

    builder.Append(summary[^5..]);
    return builder.ToString();
}
