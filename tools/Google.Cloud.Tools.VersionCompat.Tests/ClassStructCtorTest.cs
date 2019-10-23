using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Google.Cloud.Tools.VersionCompat.Tests.ClassStructCtor
{
    // All class ctors are explicitly declared for clarity.

    namespace ClassCtorAdded.A { public class C { public C() { } } }
    namespace ClassCtorAdded.B { public class C { public C() { } public C(int i) { } } }

    namespace ClassCtorRemoved.A { public class C { public C() { } public C(int i) { } } }
    namespace ClassCtorRemoved.B { public class C { public C() { } } }

    namespace ClassCtorMadeExported.A { public class C { private C() { } } }
    namespace ClassCtorMadeExported.B { public class C { protected C() { } } }

    namespace ClassCtorMadeNotExported.A { public class C { protected C() { } } }
    namespace ClassCtorMadeNotExported.B { public class C { private C() { } } }

    namespace ClassCtorParamNameChanged.A { public class C { public C(int i) { } } }
    namespace ClassCtorParamNameChanged.B { public class C { public C(int j) { } } }

    namespace ClassCtorParamInOutChanged1.A { public class C { public C(in string s) { } } }
    namespace ClassCtorParamInOutChanged1.B { public class C { public C(ref string s) { } } }

    namespace ClassCtorParamInOutChanged2.A { public class C { public C(ref string s) { } } }
    namespace ClassCtorParamInOutChanged2.B { public class C { public C(out string s) => s = ""; } }

    namespace ClassCtorAccessModifierChanged1.A { public class C { public C() { } } }
    namespace ClassCtorAccessModifierChanged1.B { public class C { protected C() { } } }

    namespace ClassCtorAccessModifierChanged2.A { public class C { protected C() { } } }
    namespace ClassCtorAccessModifierChanged2.B { public class C { public C() { } } }

    namespace ClassCtorAccessModifierChanged3.A { public class C { internal C() { } } }
    namespace ClassCtorAccessModifierChanged3.B { public class C { private C() { } } }

    // Structs always have a default parameterless ctor, which cannot be explicitly declared.

    namespace StructCtorAdded.A { public struct S { } }
    namespace StructCtorAdded.B { public struct S { public S(int i) { } } }

    namespace StructCtorRemoved.A { public struct S { public S(int i) { } } }
    namespace StructCtorRemoved.B { public struct S { } }

    namespace StructCtorMadeExported.A { public struct S { private S(int i) { } } }
    namespace StructCtorMadeExported.B { public struct S { public S(int i) { } } }

    namespace StructCtorMadeNotExported.A { public struct S { public S(int i) { } } }
    namespace StructCtorMadeNotExported.B { public struct S { private S(int i) { } } }

    namespace StructCtorParamNameChanged.A { public struct S { public S(int i) { } } }
    namespace StructCtorParamNameChanged.B { public struct S { public S(int j) { } } }

    namespace StructCtorParamInOutChanged1.A { public struct S { public S(in string s) { } } }
    namespace StructCtorParamInOutChanged1.B { public struct S { public S(ref string s) { } } }

    namespace StructCtorParamInOutChanged2.A { public struct S { public S(ref string s) { } } }
    namespace StructCtorParamInOutChanged2.B { public struct S { public S(out string s) => s = ""; } }

    public class ClassStructCtorTest : TestBase
    {
        [Fact] public void ClassCtorAdded() => TestMinor(Cause.CtorAdded);
        [Fact] public void ClassCtorRemoved() => TestMajor(Cause.CtorRemoved);
        [Fact] public void ClassCtorMadeExported() => TestMinor(Cause.CtorMadeExported);
        [Fact] public void ClassCtorMadeNotExported() => TestMajor(Cause.CtorMadeNotExported);
        [Fact] public void ClassCtorParamNameChanged() => TestMajor(Cause.CtorParameterNameChanged);
        [Fact] public void ClassCtorParamInOutChanged1() => TestMajor(Cause.CtorParameterInOutChanged);
        [Fact] public void ClassCtorParamInOutChanged2() => TestMajor(Cause.CtorParameterInOutChanged);
        [Fact] public void ClassCtorAccessModifierChanged1() => TestMajor(Cause.CtorAccessModifierChanged);
        [Fact] public void ClassCtorAccessModifierChanged2() => TestMinor(Cause.CtorAccessModifierChanged);
        [Fact] public void ClassCtorAccessModifierChanged3() => TestNone();

        [Fact] public void StructCtorAdded() => TestMinor(Cause.CtorAdded);
        [Fact] public void StructCtorRemoved() => TestMajor(Cause.CtorRemoved);
        [Fact] public void StructCtorMadeExported() => TestMinor(Cause.CtorMadeExported);
        [Fact] public void StructCtorMadeNotExported() => TestMajor(Cause.CtorMadeNotExported);
        [Fact] public void StructCtorParamNameChanged() => TestMajor(Cause.CtorParameterNameChanged);
        [Fact] public void StructCtorParamInOutChanged1() => TestMajor(Cause.CtorParameterInOutChanged);
        [Fact] public void StructCtorParamInOutChanged2() => TestMajor(Cause.CtorParameterInOutChanged);
    }
}
