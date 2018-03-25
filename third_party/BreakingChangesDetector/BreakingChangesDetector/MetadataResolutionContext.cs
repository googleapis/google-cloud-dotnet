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
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace BreakingChangesDetector
{
    public sealed class MetadataResolutionContext
    {
        // TODO_Refactor: Make private/non-static
        internal readonly Dictionary<AssemblyIdentity, AssemblyData> _cachedAssemblyDatas =
            new Dictionary<AssemblyIdentity, AssemblyData>();

        // TODO: We're going to want to pick up a lot of the options and the base reference from the project I think.
        private readonly Compilation _compilation = CSharpCompilation.Create(
            "temp",
            references: new[] { MetadataReference.CreateFromFile(typeof(object).Assembly.Location) },
            options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

        private MetadataResolutionContext(params MetadataReference[] references)
        {
            // TODO: This is a bit hacked
            if (references.OfType<PortableExecutableReference>().Any(pe => pe.FilePath == typeof(object).Assembly.Location))
            {
                _compilation = _compilation.RemoveAllReferences();
            }

            _compilation = _compilation.AddReferences(references);
        }

        /// <summary>
        /// Creates a <see cref="MetadataResolutionContext"/> which can resolve symbols from any assemblies specified or from references
        /// of those assemblies.
        /// </summary>
        public static MetadataResolutionContext CreateFromAssemblies(IEnumerable<Assembly> assemblies) =>
            new MetadataResolutionContext(assemblies.Distinct().Select(a => MetadataReference.CreateFromFile(a.Location)).ToArray());

        /// <summary>
        /// Creates a <see cref="MetadataResolutionContext"/> which can resolve symbols from any assemblies needed by the specified type
        /// or from references of those assemblies.
        /// </summary>
        public static MetadataResolutionContext CreateFromTypes(params Type[] types)
        {
            var assemblies = new List<Assembly>();
            var typesProcessed = new HashSet<Type>();
            foreach (var type in types)
            {
                ProcessType(type);
            }
            return CreateFromAssemblies(assemblies);

            void ProcessType(Type type)
            {
                if (!typesProcessed.Add(type))
                {
                    return;
                }
                assemblies.Add(type.Assembly);
                if (type.IsConstructedGenericType)
                {
                    foreach (var typeArgument in type.GenericTypeArguments)
                    {
                        ProcessType(typeArgument);
                    }
                }
            }
        }

        /// <summary>
        /// Gets the <see cref="AssemblyData"/> instance containing the metadata for externally visible types and members of the specified <see cref="Assembly"/>.
        /// </summary>
        /// <param name="assembly">The Assembly for which the AssemblyData should be obtained.</param>
        /// <returns>The AssemblyData instance containing the metadata for externally visible types and members of the specified Assembly.</returns>
        public AssemblyData GetAssemblyData(Assembly assembly) => GetAssemblyData(GetAssemblySymbol(assembly));

        /// <summary>
        /// Gets the <see cref="AssemblyData"/> instance containing the metadata for externally visible types and members of the specified <see cref="Assembly"/>.
        /// </summary>
        /// <param name="assembly">The Assembly for which the AssemblyData should be obtained.</param>
        /// <returns>The AssemblyData instance containing the metadata for externally visible types and members of the specified Assembly.</returns>
        public AssemblyData GetAssemblyData(IAssemblySymbol assembly)
        {
            lock (_cachedAssemblyDatas)
            {
                if (_cachedAssemblyDatas.TryGetValue(assembly.Identity, out AssemblyData assemblyData) == false)
                {
                    assemblyData = new AssemblyData(this, assembly);
                    _cachedAssemblyDatas[assembly.Identity] = assemblyData;
                    assemblyData.LoadFromMetadata(assembly);
                }

                return assemblyData;
            }
        }

        /// <summary>
        /// Gets the derived <see cref="ConstructedGenericTypeData"/> instance representing the specified type.
        /// </summary>
        /// <typeparam name="T">The type for which to get the <see cref="ConstructedGenericTypeData"/>.</typeparam>
        /// <returns>The derived <see cref="ConstructedGenericTypeData"/> instance.</returns>
        public ConstructedGenericTypeData GetConstructedGenericTypeData<T>() => GetConstructedGenericTypeData(typeof(T));

        /// <summary>
        /// Gets the derived <see cref="ConstructedGenericTypeData"/> instance representing the specified type.
        /// </summary>
        /// <returns>The derived <see cref="ConstructedGenericTypeData"/> instance.</returns>
        public ConstructedGenericTypeData GetConstructedGenericTypeData(Type t) =>
            // TODO_Public: throw an exception if the type is not a constructed generic
            (ConstructedGenericTypeData)GetTypeData(t);

        /// <summary>
        /// Gets the derived <see cref="GenericTypeParameterData"/> instance representing the specified type.
        /// </summary>
        /// <typeparam name="T">The type for which to get the <see cref="GenericTypeParameterData"/>.</typeparam>
        /// <returns>The derived <see cref="GenericTypeParameterData"/> instance.</returns>
        public GenericTypeParameterData GetGenericTypeParameterData<T>() => GetGenericTypeParameterData(typeof(T));

        /// <summary>
        /// Gets the derived <see cref="GenericTypeParameterData"/> instance representing the specified type.
        /// </summary>
        /// <returns>The derived <see cref="GenericTypeParameterData"/> instance.</returns>
        public GenericTypeParameterData GetGenericTypeParameterData(Type t)
        {
            if (t.IsGenericParameter == false)
            {
                throw new ArgumentException("The specified type is not a valid generic type parameter.", "t");
            }

            // TODO_Refactor: Think we need to convert to metadata name here (for nested types)
            var declaringType = GetAssemblySymbol(t.Assembly).GetTypeByMetadataName(t.DeclaringType.FullName);

            if (t.DeclaringMethod != null)
            {
                var methods = declaringType.Methods().Where(
                    m => m.Name == t.DeclaringMethod.Name &&
                    m.Parameters.Length == t.DeclaringMethod.GetParameters().Length &&
                    m.TypeParameters.Length == t.DeclaringMethod.GetGenericArguments().Length);

                // TODO: Test this with various cases (ref and out parameters, parameters types being nested types
                foreach (var method in methods)
                {
                    var isMatch = true;

                    int parameterIndex = 0;
                    foreach (var parameter in t.DeclaringMethod.GetParameters())
                    {
                        if (method.Parameters[parameterIndex++].Type.EqualsType(parameter.ParameterType) == false)
                        {
                            isMatch = false;
                            break;
                        }
                    }

                    if (isMatch)
                    {
                        return GetGenericTypeParameterData(method.TypeParameters[t.GenericParameterPosition]);
                    }
                }

                Debug.Fail("Cannot find matching method");
                return null;
            }
            else
            {
                return GetGenericTypeParameterData(declaringType.TypeParameters[t.GenericParameterPosition]);
            }
        }

        /// <summary>
        /// Gets the derived <see cref="GenericTypeParameterData"/> instance representing the specified type.
        /// </summary>
        /// <returns>The derived <see cref="GenericTypeParameterData"/> instance.</returns>
        public GenericTypeParameterData GetGenericTypeParameterData(ITypeParameterSymbol t) =>
            GetAssemblyData(GetDeclaringAssemblySymbol(t)).GetGenericTypeParameterData(t);

        /// <summary>
        /// Gets the derived <see cref="TypeData"/> instance representing the specified type.
        /// </summary>
        /// <typeparam name="T">The type for which to get the <see cref="TypeData"/>.</typeparam>
        /// <returns>The derived <see cref="TypeData"/> instance.</returns>
        public TypeData GetTypeData<T>() => GetTypeData(typeof(T));

        /// <summary>
        /// Gets the derived <see cref="TypeData"/> instance representing the specified type.
        /// </summary>
        /// <param name="t">The type for which to get the <see cref="TypeData"/>.</param>
        /// <returns>The derived <see cref="TypeData"/> instance.</returns>
        public TypeData GetTypeData(Type t) => GetTypeData(GetTypeSymbol(t));

        /// <summary>
        /// Gets the derived <see cref="TypeData"/> instance representing the specified type.
        /// </summary>
        /// <param name="t">The type for which to get the <see cref="TypeData"/>.</param>
        /// <returns>The derived <see cref="TypeData"/> instance.</returns>
        public TypeData GetTypeData(ITypeSymbol t) =>
            // TODO_Public: throw an exception if the type is not externally visible
            GetAssemblyData(GetDeclaringAssemblySymbol(t)).GetTypeData(t);

        /// <summary>
        /// Gets the <see cref="TypeDefinitionData"/> instance representing the specified type.
        /// </summary>
        /// <typeparam name="T">The type for which to get the <see cref="TypeDefinitionData"/>.</typeparam>
        /// <returns>The <see cref="TypeDefinitionData"/> instance.</returns>
        public TypeDefinitionData GetTypeDefinitionData<T>() => GetTypeDefinitionData(typeof(T));

        /// <summary>
        /// Gets the <see cref="TypeDefinitionData"/> instance representing the specified type.
        /// </summary>
        /// <returns>The <see cref="TypeDefinitionData"/> instance.</returns>
        public TypeDefinitionData GetTypeDefinitionData(Type t) =>
            GetTypeData(t) as TypeDefinitionData ??
            throw new ArgumentException("The specified type is not an externally visible type definition.", nameof(t));

        /// <summary>
        /// Gets the <see cref="TypeDefinitionData"/> instance representing the specified type.
        /// </summary>
        /// <returns>The <see cref="TypeDefinitionData"/> instance.</returns>
        public TypeDefinitionData GetTypeDefinitionData(INamedTypeSymbol t) => (TypeDefinitionData)GetTypeData(t);

        public IAssemblySymbol GetDeclaringAssemblySymbol(ITypeSymbol type)
        {
            switch (type.TypeKind)
            {
                case TypeKind.Array:
                    return GetDeclaringAssemblySymbol(((IArrayTypeSymbol)type).ElementType);
                case TypeKind.Dynamic:
                    return _compilation.ObjectType.ContainingAssembly;
                case TypeKind.Pointer:
                    return GetDeclaringAssemblySymbol(((IPointerTypeSymbol)type).PointedAtType);
                default:
                    return type.ContainingAssembly;
            }
        }

        private IAssemblySymbol GetAssemblySymbol(Assembly assembly)
        {
            var reference = _compilation.References.OfType<PortableExecutableReference>().FirstOrDefault(r => r.FilePath == assembly.Location);
            if (reference == null)
            {
                throw new InvalidOperationException("All assemblies must be pre-loaded into the SymbolResolutionContext");
            }

            return (IAssemblySymbol)_compilation.GetAssemblyOrModuleSymbol(reference);
        }

        private ITypeSymbol GetTypeSymbol(Type type)
        {
            if (type.IsPointer)
            {
                var pointedAtType = GetTypeSymbol(type.GetElementType());
                return _compilation.CreatePointerTypeSymbol(pointedAtType);
            }

            if (type.IsArray)
            {
                var elementType = GetTypeSymbol(type.GetElementType());
                return _compilation.CreateArrayTypeSymbol(elementType, type.GetArrayRank());
            }

            var assemblySymbol = GetAssemblySymbol(type.Assembly);
            if (type.IsConstructedGenericType)
            {
                var unboundType = assemblySymbol.GetTypeByMetadataName(type.GetGenericTypeDefinition().FullName);
                var typeArguments = type.GenericTypeArguments.Select(a => GetTypeSymbol(a)).ToArray();
                return unboundType.Construct(typeArguments);
            }
            else
            {
                return assemblySymbol.GetTypeByMetadataName(type.FullName);
            }
        }
    }
}
