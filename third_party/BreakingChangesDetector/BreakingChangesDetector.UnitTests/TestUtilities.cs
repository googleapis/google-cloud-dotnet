/*
    MIT License

    Copyright(c) 2014-2018 Infragistics, Inc.
    Copyright 2018 Google LLC

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in all
    copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    SOFTWARE.
*/

using BreakingChangesDetector.MetadataItems;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.CodeAnalysis;

namespace BreakingChangesDetector.UnitTests
{
    // TODO_Refactor: Do we want to keep this? If so, do something with the messages
    internal static class AssertX
    {
        internal static void Equal<T>(T expected, T actual, string message)
        {
            Assert.Equal(expected, actual);
        }

        internal static void Equal(int expected, int actual, string message)
        {
            Assert.Equal(expected, actual);
        }

        internal static void Fail(string message)
        {
            Assert.True(false, message);
        }

        internal static void Equal(string expected, string actual, string message)
        {
            Assert.Equal(expected, actual);
        }

        internal static void Null(object @object, string message)
        {
            Assert.Null(@object);
        }

        internal static void NotNull(object @object, string message)
        {
            Assert.NotNull(@object);
        }

        internal static void Inconclusive(string message)
        {
            // TODO: What should we do here?
            Fail(message);
        }
    }

    internal static class TestUtilities
    {
        private static Dictionary<Type, HashSet<Type>> _implicitNumericConversions = new Dictionary<Type, HashSet<Type>>() {
            { typeof(decimal), new HashSet<Type> { typeof(sbyte), typeof(byte), typeof(short), typeof(ushort), typeof(int), typeof(uint), typeof(long), typeof(ulong), typeof(char) } },
            { typeof(double), new HashSet<Type> { typeof(sbyte), typeof(byte), typeof(short), typeof(ushort), typeof(int), typeof(uint), typeof(long), typeof(ulong), typeof(char), typeof(float) } },
            { typeof(float), new HashSet<Type> { typeof(sbyte), typeof(byte), typeof(short), typeof(ushort), typeof(int), typeof(uint), typeof(long), typeof(ulong), typeof(char), typeof(float) } },
            { typeof(ulong), new HashSet<Type> { typeof(byte), typeof(ushort), typeof(uint), typeof(char) } },
            { typeof(long), new HashSet<Type> { typeof(sbyte), typeof(byte), typeof(short), typeof(ushort), typeof(int), typeof(uint), typeof(char) } },
            { typeof(uint), new HashSet<Type> { typeof(byte), typeof(ushort), typeof(char) } },
            { typeof(int), new HashSet<Type> { typeof(sbyte), typeof(byte), typeof(short), typeof(ushort), typeof(char) } },
            { typeof(ushort), new HashSet<Type> { typeof(byte), typeof(char) } },
            { typeof(short), new HashSet<Type> { typeof(sbyte), typeof(byte) } }
        };
        public static bool IsImplicitlyAssignableFrom(this Type to, Type from)
        {
            if (to.IsAssignableFrom(from))
            {
                return true;
            }

            if (_implicitNumericConversions.TryGetValue(to, out HashSet<Type> destTypes) && destTypes.Contains(from))
            {
                return true;
            }

            if (from.GetMethods(BindingFlags.Public | BindingFlags.Static)
                    .Any(m => m.Name == "op_Implicit" && m.ReturnType == to && m.GetParameters()[0].ParameterType == from))
            {
                return true;
            }

            if (to.GetMethods(BindingFlags.Public | BindingFlags.Static)
                    .Any(m => m.Name == "op_Implicit" && m.ReturnType == to && m.GetParameters()[0].ParameterType == from))
            {
                return true;
            }

            if (to.IsNullable())
            {
                // An implicit conversion from S? to T?
                if (from.IsNullable())
                {
                    return to.UnwrapNullable().IsImplicitlyAssignableFrom(from.UnwrapNullable());
                }

                // An implicit conversion from S to T?
                return to.UnwrapNullable().IsImplicitlyAssignableFrom(from);
            }

            // An implicit conversion from S? to to interfaces and base classes of S
            if (from.IsNullable() && to.IsValueType == false)
            {
                return to.IsImplicitlyAssignableFrom(from.UnwrapNullable());
            }

            return false;
        }

        public static Type UnwrapNullable(this Type t) => t.GenericTypeArguments[0];

        public static void VerifyAccessibility(TypeData typeDataBase, string memberName)
        {
            var typeData = (TypeDefinitionData)typeDataBase;
            var member = typeData.GetMember(memberName);
            AssertX.Equal(MemberAccessibility.Public, member.Accessibility, "Incorrect MemberAccessibility.");
            member = typeData.GetMember(memberName + "Protected");
            AssertX.Equal(MemberAccessibility.Protected, member.Accessibility, "Incorrect MemberAccessibility.");
            member = typeData.GetMember(memberName + "ProtectedInternal");
            AssertX.Equal(MemberAccessibility.Protected, member.Accessibility, "Incorrect MemberAccessibility.");
        }

        public static void VerifyInstanceAndStaticMember<T>(TypeData typeDataBase, string memberName)
            where T : MemberDataBase
        {
            var typeData = (TypeDefinitionData)typeDataBase;
            if (typeData.TypeKind != TypeKind.Interface)
            {
                VerifyMember<T>(typeData, memberName + "Static");
            }

            VerifyMember<T>(typeData, memberName + "Instance");
        }

        public static void VerifyMember<T>(TypeData typeDataBase, string memberName)
            where T : MemberDataBase
        {
            var typeData = (TypeDefinitionData)typeDataBase;
            var canHaveProtectedMembers = typeData.TypeKind == TypeKind.Class;

            var member = (T)typeData.GetMember(memberName);
            AssertX.NotNull(member, "Public " + typeof(T).Name + " instances should be returned.");
            member = (T)typeData.GetMember(memberName + "Internal");
            AssertX.Null(member, "Internal members should not be returned.");
            if (canHaveProtectedMembers)
            {
                member = (T)typeData.GetMember(memberName + "Protected");
                AssertX.NotNull(member, "Protected " + typeof(T).Name + " instances should be returned.");
                member = (T)typeData.GetMember(memberName + "ProtectedInternal");
                AssertX.NotNull(member, "Protected internal " + typeof(T).Name + " instances should be returned.");
            }
            else
            {
                member = (T)typeData.GetMember(memberName + "Protected");
                AssertX.Null(member, "Protected members should not be returned.");
                member = (T)typeData.GetMember(memberName + "ProtectedInternal");
                AssertX.Null(member, "Protected internal members should not be returned.");
            }
            member = (T)typeData.GetMember(memberName + "Private");
            AssertX.Null(member, "Private members should not be returned.");
        }
    }
}
