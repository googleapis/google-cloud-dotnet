// Copyright 2018 Google LLC
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
using NodaTime;
using NodaTime.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.ProcessBuildTimingLog
{
    /// <summary>
    /// Processes a build timing log created by the log_build_action function in toolversions.sh.
    /// This makes it easy to see how long each part of the build takes.
    /// </summary>
    internal class Program
    {
        private static readonly DurationPattern s_durationPattern = DurationPattern.CreateWithInvariantCulture("-HH:mm:ss");
        // The text to use instead of a duration for entries with no duration
        private const string NoDurationText = "--------";

        private const string StartPrefix = "(Start) ";
        private const string EndPrefix = "(End) ";

        private static int Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Required single argument: log file path");
                return 1;
            }
            string[] lines = File.ReadAllLines(args[0]);

            var logEntries = lines.Where(line => line.Length > 0).Select(LogEntry.FromLogLine).ToList();

            for (int i = 0; i < logEntries.Count; i++)
            {
                ProcessEntry(logEntries, i);
            }

            return 0;
        }

        private static void ProcessEntry(List<LogEntry> entries, int index)
        {
            LogEntry entry = entries[index];

            // Ignore any "end" actions. Assume they've already been handled (or are useless if they're orphans)
            if (entry.Action.StartsWith(EndPrefix))
            {
                return;
            }

            // If we have a "start" action, find the next matching "start" or "end", and handle appropriately
            if (entry.Action.StartsWith(StartPrefix))
            {
                string unprefixedAction = entry.Action.Substring(StartPrefix.Length);
                string expectedEndAction = EndPrefix + unprefixedAction;

                // Note: in theory we should probably do this by index rather than timing, but it's very unlikely
                // to cause issues.
                var nextStart = entries.Skip(index + 1).FirstOrDefault(e => e.Action.StartsWith(entry.Action));
                var nextEnd = entries.Skip(index + 1).FirstOrDefault(e => e.Action.StartsWith(expectedEndAction));
                if (nextEnd == null)
                {
                    PrintEntry(entry.Timestamp, null, $"No matching end: {unprefixedAction}");
                    return;
                }
                if (nextStart != null && nextStart.Timestamp < nextEnd.Timestamp)
                {
                    PrintEntry(entry.Timestamp, null, $"Matching start before end: {unprefixedAction}");
                    return;
                }
                // We report the action in parentheses as a simple indication that it's a compound action.
                PrintEntry(entry.Timestamp, nextEnd.Timestamp, $"({unprefixedAction})");
                return;
            }
            // Simple case: just one line for this action, and we're not at the end. Use the next entry.
            if (index < entries.Count - 1)
            {
                PrintEntry(entry.Timestamp, entries[index + 1].Timestamp, entry.Action);
            }
            // We only have one line for the action, but it's also the last line of the file. We have a start
            // but no end, so we can't work out the duration.
            else
            {
                PrintEntry(entry.Timestamp, null, $"Final line of file: {entry.Action}");
            }
        
            void PrintEntry(Instant start, Instant? end, string action)
            {
                string formattedDuration = end != null
                    ? s_durationPattern.Format(end.Value - start)
                    : NoDurationText;
                Console.WriteLine($"{InstantPattern.General.Format(start)}   {formattedDuration}   {action}");
            }
        }
    }
}
