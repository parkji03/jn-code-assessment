# jn-code-assessment

NUnit Adapter 4.2.0.0: Test discovery starting
NUnit Adapter 4.2.0.0: Test discovery complete
NUnit Adapter 4.2.0.0: Test execution started
Running selected tests in c:\Users\jihoo\coding\JobNimbusCodeAssessment\UnitTests\bin\Debug\net6.0\UnitTests.dll
   NUnit3TestExecutor discovered 14 of 14 NUnit test cases using Current Discovery mode, Non-Explicit run
NUnit Adapter 4.2.0.0: Test execution complete
----- Test Execution Summary -----

UnitTests.Tests.isMatching_Fail("}{"):
    Outcome: Passed
    
UnitTests.Tests.isMatching_Fail("{{}"):
    Outcome: Passed
    
UnitTests.Tests.isMatching_Fail("{aaaaaaaaaaaaaaaaaaaaaa}}"):
    Outcome: Passed
    
UnitTests.Tests.isMatching_Fail("aaaaaaaaaaaaaaaaaaaaaa}"):
    Outcome: Passed
    
UnitTests.Tests.isMatching_Fail("{aaaaaaaaaaaaaaaaaaaaaa"):
    Outcome: Passed
    
UnitTests.Tests.isMatching_Fail("aaaaaaaaaaaaaaaa{aaaaaaaaaaaaaaaaaaaaaa"):
    Outcome: Passed
    
UnitTests.Tests.isMatching_Fail("aaaaaaaaaaaaaaaaaaaaaa}aaaaaaaaaaaaaaaaaaaaaa"):
    Outcome: Passed
    
UnitTests.Tests.IsMatching_Success("{}"):
    Outcome: Passed
    
UnitTests.Tests.IsMatching_Success(""):
    Outcome: Passed
    
UnitTests.Tests.IsMatching_Success("{abc...xyz}"):
    Outcome: Passed
    
UnitTests.Tests.IsMatching_Success("aaaaaaaaaaaaaaaaaaaaaa{aaaaaaaaaaaaaaaaaaaaaa}aaaaaaaaaaaaaaaaaaaaaa"):
    Outcome: Passed
    
UnitTests.Tests.IsMatching_Success("{a{{{{{{{{{a}}}a}}a}}a}}a}a"):
    Outcome: Passed
    
UnitTests.Tests.IsMatching_Success("aaaaaaaaaaaaaa"):
    Outcome: Passed
    
UnitTests.Tests.isMatching_ThrowError(null):
    Outcome: Passed
    
Total tests: 14. Passed: 14. Failed: 0. Skipped: 0
