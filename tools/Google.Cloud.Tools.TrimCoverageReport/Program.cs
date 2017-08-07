// Copyright 2017 Google Inc. All Rights Reserved.
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

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace TrimCoverageReport
{
    /// <summary>
    /// Application to trim the detailed XML coverage report produced by dotCover to remove generated code.
    /// </summary>
    class Program
    {
        // Attributes used multiple times in the XML
        const string TotalStatements = "TotalStatements";
        const string CoveredStatements = "CoveredStatements";
        const string CoveragePercent = "CoveragePercent";

        static int Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Arguments: <input file> <output file>");
                return 1;
            }
            XDocument doc = XDocument.Load(args[0]);
            ProcessDocument(doc);
            using (var writer = File.CreateText(args[1]))
            {
                doc.Save(writer);
            }
            return 0;
        }

        static void ProcessDocument(XDocument document)
        {
            // TODO: Check how local methods are handled (issue 1320)

            // Steps:
            // - Work out all files that are generated
            // - Remove File elements for generated files
            // - Remove each Statement element with a FileIndex for a generated file
            // - Recompute the coverage for each Method element
            // - Remove Method elements with 0 statements
            // - Recompute the coverage for each Type element (based on descendant Method elements)
            // - Remove Type elements with 0 methods
            // - Recompute the coverage for each Namespace element (based on descendant Type elements)
            // - Remove Namespace elements with 0 types
            // - Recompute the coverage for each Assembly element (based on descendant Namespace elements)
            // - Remove Assembly elements with 0 namespaces

            var fileElements = document.Root.Element("FileIndices").Elements("File");
            var generatedFiles = fileElements.Where(file => IsGeneratedFile(file.Attribute("Name").Value)).ToList();
            var generatedIndices = new HashSet<int>(generatedFiles.Select(file => (int) file.Attribute("Index")));
            generatedFiles.Remove();

            document.Descendants("Statement")
                .Where(st => generatedIndices.Contains((int)st.Attribute("FileIndex")))
                .Remove();

            RecomputeAndSimplify(document, "Method", "Statement", GetStatementCoverage);
            RecomputeAndSimplify(document, "Type", "Method", GetContainerCoverage);
            RecomputeAndSimplify(document, "Namespace", "Type", GetContainerCoverage);
            RecomputeAndSimplify(document, "Assembly", "Namespace", GetContainerCoverage);
        }

        private static void RecomputeAndSimplify(XDocument document, string parentElement, string descendantElement, Func<XElement, (int statements, int covered)> coverageSelector)
        {
            List<XElement> elementsToRemove = new List<XElement>();
            foreach (var parent in document.Descendants(parentElement))
            {
                var coverage = parent
                    .Descendants(descendantElement)
                    .Select(coverageSelector)
                    .Aggregate((statements: 0, covered: 0), (current, next) => ((current.statements + next.statements), (current.covered + next.covered)));
                if (coverage.statements == 0)
                {
                    elementsToRemove.Add(parent);
                }
                else
                {
                    parent.SetAttributeValue(TotalStatements, coverage.statements);
                    parent.SetAttributeValue(CoveredStatements, coverage.covered);
                    parent.SetAttributeValue(CoveragePercent, (coverage.covered * 100) / coverage.statements);
                }
            }

            // Remove all the elements with 0 statements.
            elementsToRemove.Remove();
        }

        private static (int statements, int covered) GetStatementCoverage(XElement statement) =>
            (1, (bool)statement.Attribute("Covered") ? 1 : 0);

        private static (int statements, int covered) GetContainerCoverage(XElement container) =>
            ((int)container.Attribute(TotalStatements), (int)container.Attribute(CoveredStatements));

        /// <summary>
        /// Detects whether a file is generated. All three code generators we use (protoc, grpc,
        /// toolkit) include a comment starting with "// Generated" early in the file.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        static bool IsGeneratedFile(string path) =>
            File.ReadLines(path).Take(20).Any(line => line.StartsWith("// Generated"));
    }
}