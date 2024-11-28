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

using Google.Protobuf.Reflection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Google.Cloud.Compute.V1.EnumConstantGenerator
{
    /// <summary>
    /// A container for either enums or other nested enum containers (or both).
    /// </summary>
    public class EnumContainer
    {
        public MessageDescriptor Descriptor { get; }

        public List<EnumContainer> NestedContainers { get; }

        public List<EnumDescriptor> Enums { get; }

        public bool ShouldGenerate => Enums.Count > 0 || NestedContainers.Any(nc => nc.ShouldGenerate);

        public EnumContainer(MessageDescriptor descriptor, IEnumerable<EnumDescriptor> enums, IEnumerable<MessageDescriptor> messages)
        {
            Descriptor = descriptor;
            Enums = enums.ToList();
            NestedContainers = messages.Select(message => new EnumContainer(message, message.EnumTypes, message.NestedTypes)).ToList();
        }

        public void Generate(TextWriter writer, string indentation, System.Type computeEnumHelpersType)
        {
            if (Descriptor is object)
            {
                writer.WriteLine($"{indentation}/// <summary>Container class for enums within the <see cref=\"global::{Descriptor.ClrType.FullName.Replace("+", ".")}\"/> message.</summary>");
                writer.WriteLine($"{indentation}public static class {Descriptor.ClrType.Name}");
            }
            else
            {
                // Root class
                writer.WriteLine($"{indentation}/// <summary>Helper constants with the wire representation for enums within the Compute API.</summary>");
                writer.WriteLine($"{indentation}public static class ComputeEnumConstants");
            }
            writer.WriteLine($"{indentation}{{");
            bool first = true;
            string moreIndentation = indentation + "    ";
            foreach (var enumDescriptor in Enums.OrderBy(d => d.ClrType.Name, StringComparer.Ordinal))
            {
                MaybeWriteLineBetweenElements(writer, ref first);
                GenerateEnumConstants(writer, enumDescriptor, moreIndentation, computeEnumHelpersType);
            }
            foreach (var container in NestedContainers.Where(nc => nc.ShouldGenerate).OrderBy(nc => nc.Descriptor.Name, StringComparer.Ordinal))
            {
                MaybeWriteLineBetweenElements(writer, ref first);
                container.Generate(writer, moreIndentation, computeEnumHelpersType);
            }
            writer.WriteLine($"{indentation}}}");
        }

        private static void GenerateEnumConstants(TextWriter writer, EnumDescriptor descriptor, string indentation, System.Type computeEnumHelpersType)
        {
            var enumType = descriptor.ClrType;
            writer.WriteLine($"{indentation}/// <summary>Constants for wire representations of the <see cref=\"global::{enumType.FullName.Replace("+", ".")}\"/> enum.</summary>");
            writer.WriteLine($"{indentation}public static class {descriptor.ClrType.Name}");
            writer.WriteLine($"{indentation}{{");
            string moreIndentation = indentation + "    ";
            var formatMethod = computeEnumHelpersType.GetMethod("Format").MakeGenericMethod(enumType);
            bool first = true;
            foreach (var field in enumType.GetFields(BindingFlags.Static | BindingFlags.Public))
            {
                MaybeWriteLineBetweenElements(writer, ref first);
                var wireValue = formatMethod.Invoke(null, new object[] { field.GetValue(null) });
                // TODO: It would be nice to generate the comment for the enum value as well, but that's quite tricky.
                writer.WriteLine($"{moreIndentation}/// <summary>Wire representation of <see cref=\"global::{enumType.FullName.Replace("+", ".")}.{field.Name}\"/>.</summary>");
                string maybeUnderscore = NeedsUnderscore(field.Name) ? "_" : "";
                writer.WriteLine($"{moreIndentation}public const string {field.Name}{maybeUnderscore} = \"{wireValue}\";");
            }
            writer.WriteLine($"{indentation}}}");

            // Initially only Equals needs "escaping". It's unlikely that we'll get ToString or GetHashCode as field names,
            // but there may be other cases. Just add them here as needed.
            bool NeedsUnderscore(string name) => name == "Equals";
        }

        private static void MaybeWriteLineBetweenElements(TextWriter writer, ref bool firstElement)
        {
            if (!firstElement)
            {
                writer.WriteLine();
            }
            firstElement = false;
        }
    }
}
