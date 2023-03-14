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
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Google.Cloud.BigQuery.V2.GenerateOverloads
{
    public class ApiMethod
    {
        private static readonly Parameter ProjectIdParameter = new Parameter("string", "projectId", "The project ID. Must not be null.", null);
        private static readonly Parameter DatasetIdParameter = new Parameter("string", "datasetId", "The dataset ID. Must not be null.", null);
        private static readonly Parameter TableIdParameter = new Parameter("string", "tableId", "The table ID. Must not be null.", null);
        private static readonly Parameter JobIdParameter = new Parameter("string", "jobId", "The job ID. Must not be null.", null);
        private static readonly Parameter ModelIdParameter = new Parameter("string", "modelId", "The model ID. Must not be null.", null);
        private static readonly Parameter RoutineIdParameter = new Parameter("string", "routineId", "The routine ID. Must not be null.", null);
        private static readonly Parameter DatasetReferenceParameter = new Parameter("DatasetReference", "datasetReference", "A fully-qualified identifier for the dataset. Must not be null.", null);
        private static readonly Parameter TableReferenceParameter = new Parameter("TableReference", "tableReference", "A fully-qualified identifier for the table. Must not be null.", null);
        private static readonly Parameter JobReferenceParameter = new Parameter("JobReference", "jobReference", "A fully-qualified identifier for the job. Must not be null.", null);
        private static readonly Parameter ProjectReferenceParameter = new Parameter("ProjectReference", "projectReference", "A fully-qualified identifier for the project. Must not be null.", null);
        private static readonly Parameter ModelReferenceParameter = new Parameter("ModelReference", "modelReference", "A fully-qualified identifier for the model. Must not be null.", null);
        private static readonly Parameter RoutineReferenceParameter = new Parameter("RoutineReference", "routineReference", "A fully-qualified identifier for the routine. Must not be null.", null);
        private static readonly Parameter CancellationTokenParameter = new Parameter("CancellationToken", "cancellationToken", "The token to monitor for cancellation requests.", "default");

        private static readonly Parameter[] IdParameters = { ProjectIdParameter, DatasetIdParameter, TableIdParameter, JobIdParameter, ModelIdParameter, RoutineIdParameter };

        private static readonly Dictionary<TargetType, Parameter[]> TargetParametersByType = new Dictionary<TargetType, Parameter[]>
        {
            { TargetType.Dataset, new[] { ProjectIdParameter, DatasetIdParameter } },
            { TargetType.Table, new[] { ProjectIdParameter, DatasetIdParameter, TableIdParameter } },
            { TargetType.Job, new[] { ProjectIdParameter, JobIdParameter } },
            { TargetType.Project, new[] { ProjectIdParameter } },
            { TargetType.Model, new[] { ProjectIdParameter, DatasetIdParameter, ModelIdParameter } },
            { TargetType.Routine, new[] {ProjectIdParameter, DatasetIdParameter, RoutineIdParameter} },
            { TargetType.None, new Parameter[0] },
        };

        private static readonly Dictionary<TargetType, Parameter> ReferenceParametersByType = new Dictionary<TargetType, Parameter>
        {
            { TargetType.Dataset, DatasetReferenceParameter },
            { TargetType.Table, TableReferenceParameter },
            { TargetType.Job, JobReferenceParameter },
            { TargetType.Project, ProjectReferenceParameter },
            { TargetType.Model, ModelReferenceParameter },
            { TargetType.Routine, RoutineReferenceParameter },
            { TargetType.None, null },
        };

        public string Name { get; }
        public string RegionLabel { get; }
        public TargetType TargetType { get; }
        public string ReturnType { get; }
        public List<List<Parameter>> AdditionalParametersGroups { get; }
        public XElement Comments { get; }
        public Parameter OptionsParameter { get; }

        public ApiMethod(XElement element)
        {
            // Note: use of Value property for all mandatory elements/attributes; casting for optional ones.
            Name = element.Attribute("Name").Value;
            RegionLabel = (string)element.Attribute("RegionLabel") ?? Name;
            string targetType = element.Attribute("TargetType").Value;
            ReturnType = element.Attribute("ReturnType").Value;
            AdditionalParametersGroups = element.Elements("AdditionalParameters").Select(g => g.Elements("Parameter").Select(p => new Parameter(p)).ToList()).ToList();
            if (AdditionalParametersGroups.Count == 0)
            {
                // Add an empty parameter list so that we don't have to check later on.
                AdditionalParametersGroups.Add(new List<Parameter>());
            }
            var options = element.Element("Options");
            OptionsParameter = new Parameter(
                (string)options?.Attribute("Type") ?? $"{Name}Options",
                (string)options?.Attribute("Name") ?? "options",
                (string)options?.Attribute("Comment") ?? "The options for the operation. May be null, in which case defaults will be supplied.",
                "null");
            Comments = element.Element("Comments");

            TargetType = targetType == "" ? TargetType.None : (TargetType)Enum.Parse(typeof(TargetType), targetType);
            if (TargetType == TargetType.None)
            {
                throw new NotImplementedException("More work required to support TargetType.None...");
            }
        }

        /// <summary>
        /// Generates all relevant methods.
        /// </summary>
        public List<string> GenerateCode()
        {
            List<string> code = new List<string>
            {
                $"#region {RegionLabel}"
            };
            var targetParameters = TargetParametersByType[TargetType];
            foreach (var aditionalParametersGroup in AdditionalParametersGroups)
            {
                GenerateDelegatingMethod(code, targetParameters.Skip(1), aditionalParametersGroup, false);
                code.Add("");
                GenerateDelegatingMethod(code, targetParameters, aditionalParametersGroup, false);
                code.Add("");
                GenerateImplementationMethod(code, aditionalParametersGroup, false);
                code.Add("");
                GenerateDelegatingMethod(code, targetParameters.Skip(1), aditionalParametersGroup, true);
                code.Add("");
                GenerateDelegatingMethod(code, targetParameters, aditionalParametersGroup, true);
                code.Add("");
                GenerateImplementationMethod(code, aditionalParametersGroup, true);
            }
            code.Add("#endregion");

            // Indent everything...
            for (int i = 0; i < code.Count; i++)
            {
                code[i] = "    " + code[i];
            }
            // Add a trailing blank line (removed for the last method later)
            code.Add("");
            return code;
        }

        private void GenerateDelegatingMethod(List<string> code, IEnumerable<Parameter> targetParameters, IEnumerable<Parameter> additionalParameters, bool async)
        {
            var parameters = new List<Parameter>
            {
                targetParameters,
                additionalParameters,
                OptionsParameter,
                { CancellationTokenParameter, async }
            };
            GenerateComments(code, parameters, additionalParameters, async, true);
            string signature = GenerateSignature(parameters, async);
            code.Add($"{signature} =>");

            string getReferenceCall = $"Get{TargetType}Reference({string.Join(", ", targetParameters.Select(p => p.Name))})";
            var remainingArguments = parameters.Skip(targetParameters.Count()).Select(p => p.Name);
            code.Add($"    {GetMethodName(async)}({getReferenceCall}, {string.Join(", ", remainingArguments)});");
        }

        private void GenerateImplementationMethod(List<string> code, IEnumerable<Parameter> additionalParameters, bool async)
        {
            var parameters = GetImplementationMethodParameters(additionalParameters, async);
            GenerateComments(code, parameters, additionalParameters, async, false);
            string signature = GenerateSignature(parameters, async);
            code.Add($"{signature} =>");
            code.Add("    throw new NotImplementedException();");
        }

        private List<Parameter> GetImplementationMethodParameters(IEnumerable<Parameter> additionalParameters, bool async) => new List<Parameter>
            {
                ReferenceParametersByType[TargetType],
                additionalParameters,
                OptionsParameter,
                { CancellationTokenParameter, async }
            };

        private string GenerateSignature(IEnumerable<Parameter> parameters, bool async)
        {
            string methodReturnType = async
                ? ReturnType == "void" ? "Task" : $"Task<{ReturnType}>"
                : ReturnType;
            string formattedParameters = string.Join(", ", parameters.Select(p => p.Declaration));

            return $"public virtual {methodReturnType} {GetMethodName(async)}({formattedParameters})";
        }

        private void GenerateComments(List<string> code, IEnumerable<Parameter> parameters, IEnumerable<Parameter> additionalParameters, bool async, bool delegating)
        {
            // Order:
            // - summary (generate delegation comment)
            // - remarks (may not be present)
            // - param (multiple)
            // - anything else (e.g. exceptions)
            // - returns

            AddComments(code, GenerateSummaryComment(parameters, additionalParameters, async, delegating));
            AddComments(code, CopyRemarksComment());
            AddComments(code, GenerateParamsComments(parameters, async));
            AddComments(code, CopyUnknownComments());
            AddComments(code, GenerateReturnsComment(async));
        }

        /// <summary>
        /// Splits each entry in <paramref name="comments"/> into lines, trims it, and adds a prefix of "/// ".
        /// The result is added to <paramref name="code"/>.
        /// </summary>
        private void AddComments(List<string> code, IEnumerable<string> comments)
        {
            var formatted = comments
                .SelectMany(entry => entry.Replace("\r", "").Split('\n')) // Some entr
                .Select(line => $"/// {line.Trim()}");
            code.AddRange(formatted);
        }

        private List<string> GenerateSummaryComment(IEnumerable<Parameter> parameters, IEnumerable<Parameter> additionalParameters, bool async, bool delegating)
        {
            XElement element = Comments.Element("summary");
            string text = element.ToString();
            string targetTypeDescription = TargetType.ToString().ToLowerInvariant();
            // We only want to say "within this client's project" where we're using string IDs (not references) and there isn't a project ID parameter.
            string target = (!parameters.Contains(ProjectIdParameter) && IdParameters.Intersect(parameters).Any())
                ? $"the specified {targetTypeDescription} within this client's project"
                : $"the specified {targetTypeDescription}";
            text = text.Replace("{target}", target);
            if (async)
            {
                text = text.Substring(text.IndexOf(">") + 1).Trim();
                text = "<summary>\r\nAsynchronously " + LowerFirstLetter(text);
            }
            if (delegating)
            {
                var implementationParameters = GetImplementationMethodParameters(additionalParameters, async);
                string implementationMethod = $"{GetMethodName(async)}({string.Join(", ", implementationParameters.Select(p => p.XmlDocType))})";
                string delegation = $"This method just creates a <see cref=\"{TargetType}Reference\"/> and delegates to <see cref=\"{implementationMethod}\"/>.";
                text = text.Replace("</summary>", $"{delegation}\n</summary>");
            }
            return new List<string> { text };
        }

        private List<string> CopyRemarksComment()
        {
            XElement element = Comments.Element("remarks");
            return element == null ? new List<string>() : new List<string> { element.ToString() };
        }

        private IEnumerable<string> GenerateParamsComments(IEnumerable<Parameter> parameters, bool async) =>
            parameters.Select(p => $"<param name=\"{p.Name}\">{p.Comment}</param>");

        private static readonly HashSet<string> KnownCommentElements = new HashSet<string> { "summary", "remarks", "returns" };
        private IEnumerable<string> CopyUnknownComments() =>
            Comments.Elements().Where(x => !KnownCommentElements.Contains(x.Name.LocalName)).Select(x => x.ToString());

        private IEnumerable<string> GenerateReturnsComment(bool async)
        {
            if (ReturnType == "void")
            {
                return async ? new[] { "<returns>A task representing the asynchronous operation.</returns>" } : new string[0];
            }
            XElement element = Comments.Element("returns");
            string text = element.ToString().Trim();
            if (async)
            {
                text = text.Substring(text.IndexOf(">") + 1).Trim();
                text = $"<returns>A task representing the asynchronous operation. When complete, the result is \n{LowerFirstLetter(text)}";
            }
            return new List<string> { text };
        }

        private string GetMethodName(bool async) => async ? $"{Name}Async" : Name;

        public class Parameter
        {
            public string Type { get; }
            public string Name { get; }
            public string DefaultValue { get; }
            public string Comment { get; }
            /// <summary>
            /// The type name to use in XML doc comments for "see" elements.
            /// </summary>
            public string XmlDocType => Type.Replace("<", "{").Replace(">", "}");

            public string Declaration => $"{Type} {Name}{(DefaultValue == null ? "" : $" = {DefaultValue}")}";

            public Parameter(string type, string name, string comment, string defaultValue)
            {
                Type = type;
                Name = name;
                Comment = comment;
                DefaultValue = defaultValue;
            }

            public Parameter(XElement element)
                : this(element.Attribute("Type").Value, element.Attribute("Name").Value, element.Attribute("Comment").Value, (string) element.Attribute("DefaultValue"))
            {
            }
        }

        private static string LowerFirstLetter(string text) => char.ToLowerInvariant(text[0]) + text.Substring(1);
    }
}
