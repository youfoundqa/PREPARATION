'<auto-generated />

Imports NUnit.Framework
Imports TechTalk.SpecFlow
Imports System
Imports System.CodeDom.Compiler
Imports System.Reflection
Imports System.Runtime.CompilerServices

<GeneratedCode("SpecFlow", "3.9.52")>
<SetUpFixture>
Public NotInheritable Class PROJECT_ROOT_NAMESPACE_NUnitAssemblyHooks
    <OneTimeSetUp>
    <MethodImpl(MethodImplOptions.NoInlining)>
    Public Shared Sub AssemblyInitialize()
        Dim currentAssembly As Assembly = GetType(PROJECT_ROOT_NAMESPACE_NUnitAssemblyHooks).Assembly

        TestRunnerManager.OnTestRunStart(currentAssembly)
    End Sub

    <OneTimeTearDown>
    <MethodImpl(MethodImplOptions.NoInlining)>
    Public Shared Sub AssemblyCleanup()
        Dim currentAssembly As Assembly = GetType(PROJECT_ROOT_NAMESPACE_NUnitAssemblyHooks).Assembly

        TestRunnerManager.OnTestRunEnd(currentAssembly)
    End Sub

End Class
