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

using Mono.Cecil;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Google.Cloud.Tools.VersionCompat.CecilUtils
{
    internal static class ShowExtensions
    {
        private static string Show(this IList<GenericParameter> ps, FormatDetail detail) =>
            ps.Any() ? $"<{string.Join(", ", ps.Select(p => p.Show(detail)))}>" : "";

        private static string ShowGenArgs(this IList<TypeReference> types, FormatDetail detail) =>
            types.Any() ? $"<{string.Join(", ", types.Select(type => type.Show(detail)))}>" : "";

        private static string Show(this IList<ParameterDefinition> ps, char open, char close, bool openCloseIfEmpty, FormatDetail detail) =>
            ps.Any() ? $"{open}{string.Join(", ", ps.Select(p => p.Show(detail)))}{close}" : openCloseIfEmpty ? $"{open}{close}" : "";

        private static string Show(this ParameterDefinition p, FormatDetail detail)
        {
            var sb = new StringBuilder();
            sb.Append(p.IsIn && p.IsOut ? "ref " : p.IsIn ? "in " : p.IsOut ? "out " : "");
            sb.Append(Show(p.ParameterType, detail));
            sb.Append(' ');
            sb.Append(p.Name);
            if (p.IsOptional)
            {
                sb.Append(" = ");
                sb.Append(p.Constant ?? "null"); // TODO: I suspect `Constant` is not the right way to do this.
            }
            return sb.ToString();
        }

        public static string Show(this TypeReference type, FormatDetail detail)
        {
            if (type.FullName == "System.Void")
            {
                return "void";
            }
            var prefix = type.DeclaringType != null
                ? Show(type.DeclaringType, detail) + "."
                : detail == FormatDetail.Full ? type.Namespace + "." : "";
            switch (type)
            {
                case GenericInstanceType generic:
                    return $"{prefix}{type.Name.Split('`')[0]}{generic.GenericArguments.ShowGenArgs(detail)}";
                default:
                    return $"{prefix}{type.Name}";
            }
        }

        public static string ShowSas(this TypeDefinition type) =>
            type.IsStatic() ? "static" :
            type.IsAbstractOnly() ? "abstract" :
            type.IsSealedOnly() ? "sealed" :
            "<none>";

        public static string Show(this MethodDefinition method, FormatDetail detail) =>
            $"{method.ReturnType.Show(detail)} {method.Name}{method.GenericParameters.Show(detail)}{method.Parameters.Show('(', ')', true, detail)}";

        public static string Show(this PropertyDefinition property, FormatDetail detail) =>
            $"{property.PropertyType.Show(detail)} {property.Name}{property.Parameters.Show('[', ']', false, detail)} " +
            $"{{ {(property.GetMethod != null ? "get; " : "")}{(property.SetMethod != null ? "set; " : "")}}}";

        public static string Show(this TypeType typeType) => typeType.ToString();

        public static string ShowInOut(this ParameterDefinition param) =>
            param.IsIn && param.IsOut ? "ref" : param.IsIn ? "in" : param.IsOut ? "out" : "<none>";

        public static string ShowModifiers(this MethodDefinition method)
        {
            var oav = method.IsReuseSlot ? "override" :
                method.IsAbstract ? "abstract" :
                method.IsVirtual ? "virtual" :
                "<none>";
            var seal = method.IsFinal ? "sealed " : "";
            return seal + oav;
        }

        public static string ShowAccessModifier(this MethodDefinition method) =>
            method == null ? "<not present>" :
            method.IsPublic ? "public" :
            method.IsPrivate ? "private" :
            method.IsFamily ? "protected" :
            method.IsAssembly ? "internal" :
            method.IsFamilyOrAssembly ? "protected internal" :
            method.IsFamilyAndAssembly ? "private protected" :
            method.IsCompilerControlled ? "<compiler controlled>" :
            "<unknown>";
    }
}
