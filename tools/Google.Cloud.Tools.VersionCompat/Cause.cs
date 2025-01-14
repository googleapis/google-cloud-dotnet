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

namespace Google.Cloud.Tools.VersionCompat
{
    public enum Cause
    {
        TypeRemoved,
        TypeAdded,
        TypeMadeNotExported,
        TypeMadeExported,
        TypeTypeChanged,
        ClassModifierChanged,
        ClassBaseClassChanged,
        TypeImplementedInterfaceAdded,
        TypeImplementedInterfaceRemoved,
        TypeGenericConstraintChanged,
        TypeGenericVarianceChanged,
        InterfaceMemberAdded,
        InterfaceMemberRemoved,
        InterfaceMemberAltered,
        CtorRemoved,
        CtorAdded,
        CtorMadeNotExported,
        CtorMadeExported,
        CtorParameterNameChanged,
        CtorParameterInOutChanged,
        CtorAccessModifierChanged,
        MethodRemoved,
        MethodAdded,
        MethodMadeNotExported,
        MethodMadeExported,
        MethodReturnTypeChanged,
        MethodParameterNameChanged,
        MethodParameterInOutChanged,
        MethodMadeStatic,
        MethodMadeNonStatic,
        MethodGenericConstraintChanged,
        MethodGenericVarianceChanged,
        MethodModifierChanged,
        MethodAccessModifierChanged,
        PropertyRemoved,
        PropertyAdded,
        PropertyMadeNotExported,
        PropertyMadeExported,
        PropertyTypeChanged,
        PropertyMadeNonStatic,
        PropertyMadeStatic,
        PropertyModifierChanged,
        PropertyAccessModifierChanged,
        EnumValueAdded,
        EnumValueRemoved,
        EnumValueChanged,
        EnumUnderlyingTypeChanged,
        ObsoleteChanged,
        ConstantRemoved,
        ConstantAdded,
        ConstantMadeNotExported,
        ConstantMadeExported,
        ConstantTypeChanged,
        ConstantAccessModifierChanged,
        ConstantValueChanged,
        DependencyAdded,
        DependencyChanged,
        DependencyRemoved,
    }
}
