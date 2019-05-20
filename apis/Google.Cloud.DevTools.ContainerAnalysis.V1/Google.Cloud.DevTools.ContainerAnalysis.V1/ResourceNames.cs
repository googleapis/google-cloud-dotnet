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

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using sys = System;
using linq = System.Linq;

namespace Google.Cloud.DevTools.ContainerAnalysis.V1
{
    /// <summary>
    /// Resource name which will contain one of a choice of resource names.
    /// </summary>
    /// <remarks>
    /// This resource name will contain one of the following:
    /// <list type="bullet">
    /// <item><description>NoteName: A resource of type 'note'.</description></item>
    /// <item><description>OccurrenceName: A resource of type 'occurrence'.</description></item>
    /// </list>
    /// </remarks>
    public sealed partial class IamResourceNameOneof : gax::IResourceName, sys::IEquatable<IamResourceNameOneof>
    {
        /// <summary>
        /// The possible contents of <see cref="IamResourceNameOneof"/>.
        /// </summary>
        public enum OneofType
        {
            /// <summary>
            /// A resource of an unknown type.
            /// </summary>
            Unknown = 0,

            /// <summary>
            /// A resource of type 'note'.
            /// </summary>
            NoteName = 1,

            /// <summary>
            /// A resource of type 'occurrence'.
            /// </summary>
            OccurrenceName = 2,
        }

        /// <summary>
        /// Parses a resource name in string form into a new <see cref="IamResourceNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>NoteName: A resource of type 'note'.</description></item>
        /// <item><description>OccurrenceName: A resource of type 'occurrence'.</description></item>
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="gax::UnknownResourceName"/>; otherwise will throw an
        /// <see cref="sys::ArgumentException"/> if an unknown resource name is given.</param>
        /// <returns>The parsed <see cref="IamResourceNameOneof"/> if successful.</returns>
        public static IamResourceNameOneof Parse(string name, bool allowUnknown)
        {
            IamResourceNameOneof result;
            if (TryParse(name, allowUnknown, out result))
            {
                return result;
            }
            throw new sys::ArgumentException("Invalid name", nameof(name));
        }

        /// <summary>
        /// Tries to parse a resource name in string form into a new <see cref="IamResourceNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>NoteName: A resource of type 'note'.</description></item>
        /// <item><description>OccurrenceName: A resource of type 'occurrence'.</description></item>
        /// </list>
        /// Or an <see cref="gax::UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="gax::UnknownResourceName"/>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="IamResourceNameOneof"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string name, bool allowUnknown, out IamResourceNameOneof result)
        {
            gax::GaxPreconditions.CheckNotNull(name, nameof(name));
            Grafeas.V1.NoteName noteName;
            if (Grafeas.V1.NoteName.TryParse(name, out noteName))
            {
                result = new IamResourceNameOneof(OneofType.NoteName, noteName);
                return true;
            }
            Grafeas.V1.OccurrenceName occurrenceName;
            if (Grafeas.V1.OccurrenceName.TryParse(name, out occurrenceName))
            {
                result = new IamResourceNameOneof(OneofType.OccurrenceName, occurrenceName);
                return true;
            }
            if (allowUnknown)
            {
                gax::UnknownResourceName unknownResourceName;
                if (gax::UnknownResourceName.TryParse(name, out unknownResourceName))
                {
                    result = new IamResourceNameOneof(OneofType.Unknown, unknownResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        /// <summary>
        /// Construct a new instance of <see cref="IamResourceNameOneof"/> from the provided <see cref="Grafeas.V1.NoteName"/>
        /// </summary>
        /// <param name="noteName">The <see cref="Grafeas.V1.NoteName"/> to be contained within
        /// the returned <see cref="IamResourceNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="IamResourceNameOneof"/>, containing <paramref name="noteName"/>.</returns>
        public static IamResourceNameOneof From(Grafeas.V1.NoteName noteName) => new IamResourceNameOneof(OneofType.NoteName, noteName);

        /// <summary>
        /// Construct a new instance of <see cref="IamResourceNameOneof"/> from the provided <see cref="Grafeas.V1.OccurrenceName"/>
        /// </summary>
        /// <param name="occurrenceName">The <see cref="Grafeas.V1.OccurrenceName"/> to be contained within
        /// the returned <see cref="IamResourceNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="IamResourceNameOneof"/>, containing <paramref name="occurrenceName"/>.</returns>
        public static IamResourceNameOneof From(Grafeas.V1.OccurrenceName occurrenceName) => new IamResourceNameOneof(OneofType.OccurrenceName, occurrenceName);

        private static bool IsValid(OneofType type, gax::IResourceName name)
        {
            switch (type)
            {
                case OneofType.Unknown: return true; // Anything goes with Unknown.
                case OneofType.NoteName: return name is Grafeas.V1.NoteName;
                case OneofType.OccurrenceName: return name is Grafeas.V1.OccurrenceName;
                default: return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="IamResourceNameOneof"/> resource name class
        /// from a suitable <see cref="gax::IResourceName"/> instance.
        /// </summary>
        public IamResourceNameOneof(OneofType type, gax::IResourceName name)
        {
            Type = gax::GaxPreconditions.CheckEnumValue<OneofType>(type, nameof(type));
            Name = gax::GaxPreconditions.CheckNotNull(name, nameof(name));
            if (!IsValid(type, name))
            {
                throw new sys::ArgumentException($"Mismatched OneofType '{type}' and resource name '{name}'");
            }
        }

        /// <summary>
        /// The <see cref="OneofType"/> of the Name contained in this instance.
        /// </summary>
        public OneofType Type { get; }

        /// <summary>
        /// The <see cref="gax::IResourceName"/> contained in this instance.
        /// </summary>
        public gax::IResourceName Name { get; }

        private T CheckAndReturn<T>(OneofType type)
        {
            if (Type != type)
            {
                throw new sys::InvalidOperationException($"Requested type {type}, but this one-of contains type {Type}");
            }
            return (T)Name;
        }

        /// <summary>
        /// Get the contained <see cref="gax::IResourceName"/> as <see cref="Grafeas.V1.NoteName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="sys::InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="Grafeas.V1.NoteName"/>.
        /// </remarks>
        public Grafeas.V1.NoteName NoteName => CheckAndReturn<Grafeas.V1.NoteName>(OneofType.NoteName);

        /// <summary>
        /// Get the contained <see cref="gax::IResourceName"/> as <see cref="Grafeas.V1.OccurrenceName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="sys::InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="Grafeas.V1.OccurrenceName"/>.
        /// </remarks>
        public Grafeas.V1.OccurrenceName OccurrenceName => CheckAndReturn<Grafeas.V1.OccurrenceName>(OneofType.OccurrenceName);

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Oneof;

        /// <inheritdoc />
        public override string ToString() => Name.ToString();

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as IamResourceNameOneof);

        /// <inheritdoc />
        public bool Equals(IamResourceNameOneof other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(IamResourceNameOneof a, IamResourceNameOneof b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(IamResourceNameOneof a, IamResourceNameOneof b) => !(a == b);
    }



}