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
using System.Linq;
using System.Reflection;

namespace BreakingChangesDetector.BreakingChanges.Definitions
{
    internal sealed class ChangedGenericTypeParameterConstraintsDefinition : BreakingChangeDefinitionBase
    {
        public static readonly ChangedGenericTypeParameterConstraintsDefinition Instance =
            new ChangedGenericTypeParameterConstraintsDefinition();

        private ChangedGenericTypeParameterConstraintsDefinition() { }

        public override void CompareItems(CompareItemsContext context)
        {
            var oldGenericParameter = (GenericTypeParameterData)context.OldItem;
            var newGenericParameter = (GenericTypeParameterData)context.NewItem;

            var oldConstraintAttributes = oldGenericParameter.GenericParameterAttributes & GenericParameterAttributes.SpecialConstraintMask;
            var newConstraintAttributes = newGenericParameter.GenericParameterAttributes & GenericParameterAttributes.SpecialConstraintMask;

            bool haveConstraintsChanged = (oldConstraintAttributes != newConstraintAttributes);
            if (haveConstraintsChanged == false)
            {
                foreach (var oldContraintType in oldGenericParameter.Constraints)
                {
                    if (newGenericParameter.Constraints.Any(c => oldContraintType.IsEquivalentToNew(c, context.NewAssemblyFamily)) == false)
                    {
                        haveConstraintsChanged = true;
                        break;
                    }
                }

                if (haveConstraintsChanged == false)
                {
                    foreach (var newContraintType in newGenericParameter.Constraints)
                    {
                        if (oldGenericParameter.Constraints.Any(c => newContraintType.IsEquivalentToOld(c, context.NewAssemblyFamily)) == false)
                        {
                            haveConstraintsChanged = true;
                            break;
                        }
                    }
                }
            }

            if (haveConstraintsChanged)
            {
                context.BreakingChanges.Add(new ChangedGenericTypeParameterConstraints(oldGenericParameter, newGenericParameter));
            }
        }

        public override BreakingChangeKind BreakingChangeKind =>
            BreakingChangeKind.ChangedGenericTypeParameterConstraints;

        public override MetadataItemKinds MembersKindsHandled =>
            MetadataItemKinds.GenericTypeParameter;
    }
}
