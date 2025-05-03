
.assembly extern System.Runtime
{
  .publickeytoken = ( B0 3F 5F 7F 11 D5 0A 3A ) // .._.....
  .ver 8:0:0:0
}

.assembly extern System.Console
{
  .publickeytoken = ( B0 3F 5F 7F 11 D5 0A 3A ) // .._.....
  .ver 8:0:0:0
}

.assembly 'ConsoleApp2'
{
  .custom instance void class [System.Runtime]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) // ........
  .custom instance void class [System.Runtime]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78 63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 ) // ....T..WrapNonExceptionThrows.
  .custom instance void class [System.Runtime]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 18 2E 4E 45 54 43 6F 72 65 41 70 70 2C 56 65 72 73 69 6F 6E 3D 76 38 2E 30 01 00 54 0E 14 46 72 61 6D 65 77 6F 72 6B 44 69 73 70 6C 61 79 4E 61 6D 65 08 2E 4E 45 54 20 38 2E 30 ) // ....NETCoreApp.Version.v8.0..T..FrameworkDisplayName..NET.8.0
  .custom instance void class [System.Runtime]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 0B 43 6F 6E 73 6F 6C 65 41 70 70 32 00 00 ) // ...ConsoleApp2..
  .custom instance void class [System.Runtime]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 05 44 65 62 75 67 00 00 ) // ...Debug..
  .custom instance void class [System.Runtime]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 ) // ...1.0.0.0..
  .custom instance void class [System.Runtime]System.Reflection.AssemblyInformationalVersionAttribute::.ctor(string) = ( 01 00 05 31 2E 30 2E 30 00 00 ) // ...1.0.0..
  .custom instance void class [System.Runtime]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 0B 43 6F 6E 73 6F 6C 65 41 70 70 32 00 00 ) // ...ConsoleApp2..
  .custom instance void class [System.Runtime]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 0B 43 6F 6E 73 6F 6C 65 41 70 70 32 00 00 ) // ...ConsoleApp2..
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}

.module 'ConsoleApp2.dll'
// MVID: {6c8c8951-be41-4784-b82e-94a0d2de7d75}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003  // WindowsCui
.corflags 0x00000001  // ILOnly

.class private auto ansi beforefieldinit Program extends [System.Runtime]System.Object
{
  .custom instance void class [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) // ....
  .method private hidebysig static default void <Main>$(string[] args) cil managed
  {
    // Method begins at Relative Virtual Address (RVA) 0x2050
    .entrypoint
    // Code size 195 (0xC3)
    .maxstack 3
    .locals init(string V_0, int32 V_1, int32 V_2, valuetype [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler V_3)
    IL_0000: ldstr "100000 in hex is {0:X}"
    IL_0005: ldc.i4 100000
    IL_000a: box class System.Int32
    IL_000f: call string class string::Format(string, [System.Runtime]System.Object)
    IL_0014: stloc.0
    IL_0015: ldloc.0
    IL_0016: call void class [System.Console]System.Console::WriteLine(string)
    IL_001b: nop
    IL_001c: call void class Program::<<Main>$>g__DefaultDeclaration|0_1()
    IL_0021: nop
    IL_0022: call void class Program::<<Main>$>g__DataTypeFunctionality|0_2()
    IL_0027: nop
    IL_0028: call void class Program::<<Main>$>g__CharFunctionality|0_3()
    IL_002d: nop
    IL_002e: call void class Program::<<Main>$>g__ParseFromStringsWithTryParse|0_4()
    IL_0033: nop
    IL_0034: call void class Program::<<Main>$>g__UseDatesAndTimes|0_5()
    IL_0039: nop
    IL_003a: call void class Program::<<Main>$>g__EscapeChars|0_6()
    IL_003f: nop
    IL_0040: call void class Program::<<Main>$>g__StringEquality|0_7()
    IL_0045: nop
    IL_0046: call void class Program::<<Main>$>g__FunWithStringBuilder|0_8()
    IL_004b: nop
    IL_004c: ldstr "**** Fun with type conversions ****"
    IL_0051: call void class [System.Console]System.Console::WriteLine(string)
    IL_0056: nop
    IL_0057: ldc.i4.6
    IL_0058: stloc.1
    IL_0059: ldc.i4.s 10
    IL_005b: stloc.2
    IL_005c: ldloca.s class V_3
    IL_005e: ldc.i4.6
    IL_005f: ldc.i4.3
    IL_0060: call instance void class valuetype [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::.ctor(int32, int32)
    IL_0065: ldloca.s class V_3
    IL_0067: ldloc.1
    IL_0068: call instance System.Void class valuetype [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::AppendFormatted<int32>(!!0)
    IL_006d: nop
    IL_006e: ldloca.s class V_3
    IL_0070: ldstr " + "
    IL_0075: call instance void class valuetype [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::AppendLiteral(string)
    IL_007a: nop
    IL_007b: ldloca.s class V_3
    IL_007d: ldloc.2
    IL_007e: call instance System.Void class valuetype [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::AppendFormatted<int32>(!!0)
    IL_0083: nop
    IL_0084: ldloca.s class V_3
    IL_0086: ldstr " = "
    IL_008b: call instance void class valuetype [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::AppendLiteral(string)
    IL_0090: nop
    IL_0091: ldloca.s class V_3
    IL_0093: ldloc.1
    IL_0094: ldloc.2
    IL_0095: call double class Program::<<Main>$>g__Add|0_0(int32, int32)
    IL_009a: call instance System.Void class valuetype [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::AppendFormatted<double>(!!0)
    IL_009f: nop
    IL_00a0: ldloca.s class V_3
    IL_00a2: call instance string class valuetype [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::ToStringAndClear()
    IL_00a7: call void class [System.Console]System.Console::WriteLine(string)
    IL_00ac: nop
    IL_00ad: call string class [System.Console]System.Console::ReadLine()
    IL_00b2: pop
    IL_00b3: nop
    IL_00b4: nop
    IL_00b5: nop
    IL_00b6: nop
    IL_00b7: nop
    IL_00b8: nop
    IL_00b9: nop
    IL_00ba: nop
    IL_00bb: nop
    IL_00bc: call void class [System.Console]System.Console::Beep()
    IL_00c1: nop
    IL_00c2: ret
  } // End of method System.Void Program::<Main>$(System.String[])
  .method public hidebysig specialname rtspecialname instance default void .ctor() cil managed
  {
    // Method begins at Relative Virtual Address (RVA) 0x211F
    // Code size 8 (0x8)
    .maxstack 8
    IL_0000: ldarg.0
    IL_0001: call instance void class [System.Runtime]System.Object::.ctor()
    IL_0006: nop
    IL_0007: ret
  } // End of method System.Void Program::.ctor()
  .method hidebysig static default double <<Main>$>g__Add|0_0(int32 x, int32 y) cil managed
  {
    .custom instance void class [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) // ....
    // Method begins at Relative Virtual Address (RVA) 0x2128
    // Code size 10 (0xA)
    .maxstack 2
    .locals init(double V_0)
    IL_0000: nop
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: add
    IL_0004: conv.r8
    IL_0005: stloc.0
    IL_0006: br.s     IL_0008
    IL_0008: ldloc.0
    IL_0009: ret
  } // End of method System.Double Program::<<Main>$>g__Add|0_0(System.Int32,System.Int32)
  .method hidebysig static default void <<Main>$>g__DefaultDeclaration|0_1() cil managed
  {
    .custom instance void class [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) // ....
    // Method begins at Relative Virtual Address (RVA) 0x2140
    // Code size 57 (0x39)
    .maxstack 3
    .locals init(int32 V_0, bool V_1, int32 V_2)
    IL_0000: nop
    IL_0001: ldc.i4.0
    IL_0002: stloc.0
    IL_0003: ldc.i4.0
    IL_0004: stloc.1
    IL_0005: ldstr "{0}, {1}"
    IL_000a: ldloc.0
    IL_000b: box class System.Int32
    IL_0010: ldloc.1
    IL_0011: box class System.Boolean
    IL_0016: call void class [System.Console]System.Console::WriteLine(string, [System.Runtime]System.Object, [System.Runtime]System.Object)
    IL_001b: nop
    IL_001c: ldstr "12.Equals(23) = {0}"
    IL_0021: ldc.i4.s 12
    IL_0023: stloc.2
    IL_0024: ldloca.s class V_2
    IL_0026: ldc.i4.s 23
    IL_0028: call instance bool class int32::Equals(int32)
    IL_002d: box class System.Boolean
    IL_0032: call void class [System.Console]System.Console::WriteLine(string, [System.Runtime]System.Object)
    IL_0037: nop
    IL_0038: ret
  } // End of method System.Void Program::<<Main>$>g__DefaultDeclaration|0_1()
  .method hidebysig static default void <<Main>$>g__DataTypeFunctionality|0_2() cil managed
  {
    .custom instance void class [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) // ....
    // Method begins at Relative Virtual Address (RVA) 0x2188
    // Code size 177 (0xB1)
    .maxstack 3
    .locals init(double V_0, valuetype [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler V_1)
    IL_0000: nop
    IL_0001: ldstr "=> Data type Functionality:"
    IL_0006: call void class [System.Console]System.Console::WriteLine(string)
    IL_000b: nop
    IL_000c: ldstr "Max of int: {0}"
    IL_0011: ldc.i4 2147483647
    IL_0016: box class System.Int32
    IL_001b: call void class [System.Console]System.Console::WriteLine(string, [System.Runtime]System.Object)
    IL_0020: nop
    IL_0021: ldstr "Min of int: {0}"
    IL_0026: ldc.i4 -2147483648
    IL_002b: box class System.Int32
    IL_0030: call void class [System.Console]System.Console::WriteLine(string, [System.Runtime]System.Object)
    IL_0035: nop
    IL_0036: ldstr "Max of double: {0}"
    IL_003b: ldc.r8 1,7976931348623157E+308
    IL_0044: box class System.Double
    IL_0049: call void class [System.Console]System.Console::WriteLine(string, [System.Runtime]System.Object)
    IL_004e: nop
    IL_004f: ldstr "Min of double: {0}"
    IL_0054: ldc.r8 -1,7976931348623157E+308
    IL_005d: box class System.Double
    IL_0062: call void class [System.Console]System.Console::WriteLine(string, [System.Runtime]System.Object)
    IL_0067: nop
    IL_0068: ldstr "double.Epsilon: {0}"
    IL_006d: ldc.r8 5E-324
    IL_0076: box class System.Double
    IL_007b: call void class [System.Console]System.Console::WriteLine(string, [System.Runtime]System.Object)
    IL_0080: nop
    IL_0081: ldc.r8 0
    IL_008a: stloc.0
    IL_008b: ldloca.s class V_1
    IL_008d: ldc.i4.0
    IL_008e: ldc.i4.1
    IL_008f: call instance void class valuetype [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::.ctor(int32, int32)
    IL_0094: ldloca.s class V_1
    IL_0096: ldloc.0
    IL_0097: call instance System.Void class valuetype [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::AppendFormatted<double>(!!0)
    IL_009c: nop
    IL_009d: ldloca.s class V_1
    IL_009f: call instance string class valuetype [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::ToStringAndClear()
    IL_00a4: call void class [System.Console]System.Console::WriteLine(string)
    IL_00a9: nop
    IL_00aa: call void class [System.Console]System.Console::WriteLine()
    IL_00af: nop
    IL_00b0: ret
  } // End of method System.Void Program::<<Main>$>g__DataTypeFunctionality|0_2()
  .method hidebysig static default void <<Main>$>g__CharFunctionality|0_3() cil managed
  {
    .custom instance void class [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) // ....
    // Method begins at Relative Virtual Address (RVA) 0x2248
    // Code size 143 (0x8F)
    .maxstack 3
    .locals init(char V_0)
    IL_0000: nop
    IL_0001: ldstr "=> char type Functionality:"
    IL_0006: call void class [System.Console]System.Console::WriteLine(string)
    IL_000b: nop
    IL_000c: ldc.i4.s 97
    IL_000e: stloc.0
    IL_000f: ldstr "char.IsDigit('a'): {0}"
    IL_0014: ldloc.0
    IL_0015: call bool class char::IsDigit(char)
    IL_001a: box class System.Boolean
    IL_001f: call void class [System.Console]System.Console::WriteLine(string, [System.Runtime]System.Object)
    IL_0024: nop
    IL_0025: ldstr "char.IsLetter('a'): {0}"
    IL_002a: ldloc.0
    IL_002b: call bool class char::IsLetter(char)
    IL_0030: box class System.Boolean
    IL_0035: call void class [System.Console]System.Console::WriteLine(string, [System.Runtime]System.Object)
    IL_003a: nop
    IL_003b: ldstr "char.IsWhiteSpace('Hello There', 5): {0}"
    IL_0040: ldstr "Hello There"
    IL_0045: ldc.i4.5
    IL_0046: call bool class char::IsWhiteSpace(string, int32)
    IL_004b: box class System.Boolean
    IL_0050: call void class [System.Console]System.Console::WriteLine(string, [System.Runtime]System.Object)
    IL_0055: nop
    IL_0056: ldstr "char.IsWhiteSpace('Hello There', 6): {0}"
    IL_005b: ldstr "Hello There"
    IL_0060: ldc.i4.6
    IL_0061: call bool class char::IsWhiteSpace(string, int32)
    IL_0066: box class System.Boolean
    IL_006b: call void class [System.Console]System.Console::WriteLine(string, [System.Runtime]System.Object)
    IL_0070: nop
    IL_0071: ldstr "char.IsPunctuation('?'): {0}"
    IL_0076: ldc.i4.s 63
    IL_0078: call bool class char::IsPunctuation(char)
    IL_007d: box class System.Boolean
    IL_0082: call void class [System.Console]System.Console::WriteLine(string, [System.Runtime]System.Object)
    IL_0087: nop
    IL_0088: call void class [System.Console]System.Console::WriteLine()
    IL_008d: nop
    IL_008e: ret
  } // End of method System.Void Program::<<Main>$>g__CharFunctionality|0_3()
  .method hidebysig static default void <<Main>$>g__ParseFromStringsWithTryParse|0_4() cil managed
  {
    .custom instance void class [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) // ....
    // Method begins at Relative Virtual Address (RVA) 0x22E4
    // Code size 136 (0x88)
    .maxstack 3
    .locals init(bool V_0, string V_1, double V_2, bool V_3, bool V_4)
    IL_0000: nop
    IL_0001: ldstr "=> Data type parsing with TryParse:"
    IL_0006: call void class [System.Console]System.Console::WriteLine(string)
    IL_000b: nop
    IL_000c: ldstr "True"
    IL_0011: ldloca.s class V_0
    IL_0013: call bool class bool::TryParse(string, byreference)
    IL_0018: stloc.3
    IL_0019: ldloc.3
    IL_001a: brfalse.s     IL_0031
    IL_001c: nop
    IL_001d: ldstr "Value of b: {0}"
    IL_0022: ldloc.0
    IL_0023: box class System.Boolean
    IL_0028: call void class [System.Console]System.Console::WriteLine(string, [System.Runtime]System.Object)
    IL_002d: nop
    IL_002e: nop
    IL_002f: br.s     IL_0044
    IL_0031: nop
    IL_0032: ldstr "Default value of b: {0}"
    IL_0037: ldloc.0
    IL_0038: box class System.Boolean
    IL_003d: call void class [System.Console]System.Console::WriteLine(string, [System.Runtime]System.Object)
    IL_0042: nop
    IL_0043: nop
    IL_0044: ldstr "True"
    IL_0049: stloc.1
    IL_004a: ldloc.1
    IL_004b: ldloca.s class V_2
    IL_004d: call bool class double::TryParse(string, byreference)
    IL_0052: stloc.s class V_4
    IL_0054: ldloc.s class V_4
    IL_0056: brfalse.s     IL_006d
    IL_0058: nop
    IL_0059: ldstr "Value of d: {0}"
    IL_005e: ldloc.2
    IL_005f: box class System.Double
    IL_0064: call void class [System.Console]System.Console::WriteLine(string, [System.Runtime]System.Object)
    IL_0069: nop
    IL_006a: nop
    IL_006b: br.s     IL_0081
    IL_006d: nop
    IL_006e: ldstr "Failed to convert the input ({0}) to a double and the variable was assigned the default {1}"
    IL_0073: ldloc.1
    IL_0074: ldloc.2
    IL_0075: box class System.Double
    IL_007a: call void class [System.Console]System.Console::WriteLine(string, [System.Runtime]System.Object, [System.Runtime]System.Object)
    IL_007f: nop
    IL_0080: nop
    IL_0081: call void class [System.Console]System.Console::WriteLine()
    IL_0086: nop
    IL_0087: ret
  } // End of method System.Void Program::<<Main>$>g__ParseFromStringsWithTryParse|0_4()
  .method hidebysig static default void <<Main>$>g__UseDatesAndTimes|0_5() cil managed
  {
    .custom instance void class [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) // ....
    // Method begins at Relative Virtual Address (RVA) 0x2378
    // Code size 146 (0x92)
    .maxstack 4
    .locals init(valuetype [System.Runtime]System.DateTime V_0, valuetype [System.Runtime]System.TimeSpan V_1)
    IL_0000: nop
    IL_0001: ldstr "=> Dates and Times:"
    IL_0006: call void class [System.Console]System.Console::WriteLine(string)
    IL_000b: nop
    IL_000c: ldloca.s class V_0
    IL_000e: ldc.i4 2015
    IL_0013: ldc.i4.s 10
    IL_0015: ldc.i4.s 17
    IL_0017: call instance void class valuetype [System.Runtime]System.DateTime::.ctor(int32, int32, int32)
    IL_001c: ldstr "The day of {0} is {1}"
    IL_0021: ldloca.s class V_0
    IL_0023: call instance valuetype [System.Runtime]System.DateTime class valuetype [System.Runtime]System.DateTime::get_Date()
    IL_0028: box class System.DateTime
    IL_002d: ldloca.s class V_0
    IL_002f: call instance valuetype [System.Runtime]System.DayOfWeek class valuetype [System.Runtime]System.DateTime::get_DayOfWeek()
    IL_0034: box class System.DayOfWeek
    IL_0039: call void class [System.Console]System.Console::WriteLine(string, [System.Runtime]System.Object, [System.Runtime]System.Object)
    IL_003e: nop
    IL_003f: ldloca.s class V_0
    IL_0041: ldc.i4.2
    IL_0042: call instance valuetype [System.Runtime]System.DateTime class valuetype [System.Runtime]System.DateTime::AddMonths(int32)
    IL_0047: stloc.0
    IL_0048: ldstr "Daylight savings: {0}"
    IL_004d: ldloca.s class V_0
    IL_004f: call instance bool class valuetype [System.Runtime]System.DateTime::IsDaylightSavingTime()
    IL_0054: box class System.Boolean
    IL_0059: call void class [System.Console]System.Console::WriteLine(string, [System.Runtime]System.Object)
    IL_005e: nop
    IL_005f: ldloca.s class V_1
    IL_0061: ldc.i4.4
    IL_0062: ldc.i4.s 30
    IL_0064: ldc.i4.0
    IL_0065: call instance void class valuetype [System.Runtime]System.TimeSpan::.ctor(int32, int32, int32)
    IL_006a: ldloc.1
    IL_006b: box class System.TimeSpan
    IL_0070: call void class [System.Console]System.Console::WriteLine([System.Runtime]System.Object)
    IL_0075: nop
    IL_0076: ldloca.s class V_1
    IL_0078: ldc.i4.0
    IL_0079: ldc.i4.s 15
    IL_007b: ldc.i4.0
    IL_007c: newobj instance void class valuetype [System.Runtime]System.TimeSpan::.ctor(int32, int32, int32)
    IL_0081: call instance valuetype [System.Runtime]System.TimeSpan class valuetype [System.Runtime]System.TimeSpan::Subtract(valuetype [System.Runtime]System.TimeSpan)
    IL_0086: box class System.TimeSpan
    IL_008b: call void class [System.Console]System.Console::WriteLine([System.Runtime]System.Object)
    IL_0090: nop
    IL_0091: ret
  } // End of method System.Void Program::<<Main>$>g__UseDatesAndTimes|0_5()
  .method hidebysig static default void <<Main>$>g__EscapeChars|0_6() cil managed
  {
    .custom instance void class [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) // ....
    // Method begins at Relative Virtual Address (RVA) 0x2418
    // Code size 65 (0x41)
    .maxstack 1
    .locals init(string V_0)
    IL_0000: nop
    IL_0001: ldstr "=> Escape characters:"
    IL_0006: call void class [System.Console]System.Console::WriteLine(string)
    IL_000b: nop
    IL_000c: ldstr "Model	Color	Speed	Pet Name "
    IL_0011: stloc.0
    IL_0012: ldloc.0
    IL_0013: call void class [System.Console]System.Console::WriteLine(string)
    IL_0018: nop
    IL_0019: ldstr "Everyone loves "Hello World" "
    IL_001e: call void class [System.Console]System.Console::WriteLine(string)
    IL_0023: nop
    IL_0024: ldstr "C:\MyApp\bin\Debug "
    IL_0029: call void class [System.Console]System.Console::WriteLine(string)
    IL_002e: nop
    IL_002f: ldstr "All finished.


 "
    IL_0034: call void class [System.Console]System.Console::WriteLine(string)
    IL_0039: nop
    IL_003a: call void class [System.Console]System.Console::WriteLine()
    IL_003f: nop
    IL_0040: ret
  } // End of method System.Void Program::<<Main>$>g__EscapeChars|0_6()
  .method hidebysig static default void <<Main>$>g__StringEquality|0_7() cil managed
  {
    .custom instance void class [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) // ....
    // Method begins at Relative Virtual Address (RVA) 0x2468
    // Code size 248 (0xF8)
    .maxstack 3
    .locals init(string V_0, string V_1, valuetype [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler V_2)
    IL_0000: nop
    IL_0001: ldstr "=> String equality:"
    IL_0006: call void class [System.Console]System.Console::WriteLine(string)
    IL_000b: nop
    IL_000c: ldstr "Hello!"
    IL_0011: stloc.0
    IL_0012: ldstr "Yo!"
    IL_0017: stloc.1
    IL_0018: ldstr "si = "
    IL_001d: ldloc.0
    IL_001e: call string class string::Concat(string, string)
    IL_0023: call void class [System.Console]System.Console::WriteLine(string)
    IL_0028: nop
    IL_0029: ldstr "s2 = {0}"
    IL_002e: ldloc.1
    IL_002f: call void class [System.Console]System.Console::WriteLine(string, [System.Runtime]System.Object)
    IL_0034: nop
    IL_0035: call void class [System.Console]System.Console::WriteLine()
    IL_003a: nop
    IL_003b: ldloca.s class V_2
    IL_003d: ldc.i4.s 10
    IL_003f: ldc.i4.1
    IL_0040: call instance void class valuetype [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::.ctor(int32, int32)
    IL_0045: ldloca.s class V_2
    IL_0047: ldstr "si == s2: "
    IL_004c: call instance void class valuetype [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::AppendLiteral(string)
    IL_0051: nop
    IL_0052: ldloca.s class V_2
    IL_0054: ldloc.0
    IL_0055: ldloc.1
    IL_0056: call bool class string::op_Equality(string, string)
    IL_005b: call instance System.Void class valuetype [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::AppendFormatted<bool>(!!0)
    IL_0060: nop
    IL_0061: ldloca.s class V_2
    IL_0063: call instance string class valuetype [System.Runtime]System.Runtime.CompilerServices.DefaultInterpolatedStringHandler::ToStringAndClear()
    IL_0068: call void class [System.Console]System.Console::WriteLine(string)
    IL_006d: nop
    IL_006e: ldstr "si == Hello!: {0}"
    IL_0073: ldloc.0
    IL_0074: ldstr "Hello!"
    IL_0079: call bool class string::op_Equality(string, string)
    IL_007e: box class System.Boolean
    IL_0083: call void class [System.Console]System.Console::WriteLine(string, [System.Runtime]System.Object)
    IL_0088: nop
    IL_0089: ldstr "si == HELLO!: {0}"
    IL_008e: ldloc.0
    IL_008f: ldstr "HELLO!"
    IL_0094: call bool class string::op_Equality(string, string)
    IL_0099: box class System.Boolean
    IL_009e: call void class [System.Console]System.Console::WriteLine(string, [System.Runtime]System.Object)
    IL_00a3: nop
    IL_00a4: ldstr "si == hello!: {0}"
    IL_00a9: ldloc.0
    IL_00aa: ldstr "hello!"
    IL_00af: call bool class string::op_Equality(string, string)
    IL_00b4: box class System.Boolean
    IL_00b9: call void class [System.Console]System.Console::WriteLine(string, [System.Runtime]System.Object)
    IL_00be: nop
    IL_00bf: ldstr "si.Equals(s2): {0}"
    IL_00c4: ldloc.0
    IL_00c5: ldloc.1
    IL_00c6: callvirt instance bool class string::Equals(string)
    IL_00cb: box class System.Boolean
    IL_00d0: call void class [System.Console]System.Console::WriteLine(string, [System.Runtime]System.Object)
    IL_00d5: nop
    IL_00d6: ldstr "Yo!.Equals(s2): {0}"
    IL_00db: ldstr "Yo!"
    IL_00e0: ldloc.1
    IL_00e1: call instance bool class string::Equals(string)
    IL_00e6: box class System.Boolean
    IL_00eb: call void class [System.Console]System.Console::WriteLine(string, [System.Runtime]System.Object)
    IL_00f0: nop
    IL_00f1: call void class [System.Console]System.Console::WriteLine()
    IL_00f6: nop
    IL_00f7: ret
  } // End of method System.Void Program::<<Main>$>g__StringEquality|0_7()
  .method hidebysig static default void <<Main>$>g__FunWithStringBuilder|0_8() cil managed
  {
    .custom instance void class [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) // ....
    // Method begins at Relative Virtual Address (RVA) 0x256C
    // Code size 153 (0x99)
    .maxstack 3
    .locals init(class [System.Runtime]System.Text.StringBuilder V_0)
    IL_0000: nop
    IL_0001: ldstr "=> Using the StringBuilder:"
    IL_0006: call void class [System.Console]System.Console::WriteLine(string)
    IL_000b: nop
    IL_000c: ldstr "***** Fantastic Games ******"
    IL_0011: newobj instance void class [System.Runtime]System.Text.StringBuilder::.ctor(string)
    IL_0016: stloc.0
    IL_0017: ldloc.0
    IL_0018: ldstr "
"
    IL_001d: callvirt instance [System.Runtime]System.Text.StringBuilder class [System.Runtime]System.Text.StringBuilder::Append(string)
    IL_0022: pop
    IL_0023: ldloc.0
    IL_0024: ldstr "Half Life"
    IL_0029: callvirt instance [System.Runtime]System.Text.StringBuilder class [System.Runtime]System.Text.StringBuilder::AppendLine(string)
    IL_002e: pop
    IL_002f: ldloc.0
    IL_0030: ldstr "Morrowind"
    IL_0035: callvirt instance [System.Runtime]System.Text.StringBuilder class [System.Runtime]System.Text.StringBuilder::AppendLine(string)
    IL_003a: pop
    IL_003b: ldloc.0
    IL_003c: ldstr "Deus Ex2"
    IL_0041: callvirt instance [System.Runtime]System.Text.StringBuilder class [System.Runtime]System.Text.StringBuilder::AppendLine(string)
    IL_0046: pop
    IL_0047: ldloc.0
    IL_0048: ldstr "System Shock"
    IL_004d: callvirt instance [System.Runtime]System.Text.StringBuilder class [System.Runtime]System.Text.StringBuilder::AppendLine(string)
    IL_0052: pop
    IL_0053: ldloc.0
    IL_0054: callvirt instance string class [System.Runtime]System.Object::ToString()
    IL_0059: call void class [System.Console]System.Console::WriteLine(string)
    IL_005e: nop
    IL_005f: ldloc.0
    IL_0060: ldstr "2"
    IL_0065: ldstr " Invisible War"
    IL_006a: callvirt instance [System.Runtime]System.Text.StringBuilder class [System.Runtime]System.Text.StringBuilder::Replace(string, string)
    IL_006f: pop
    IL_0070: ldloc.0
    IL_0071: callvirt instance string class [System.Runtime]System.Object::ToString()
    IL_0076: call void class [System.Console]System.Console::WriteLine(string)
    IL_007b: nop
    IL_007c: ldstr "sb has {0} chars."
    IL_0081: ldloc.0
    IL_0082: callvirt instance int32 class [System.Runtime]System.Text.StringBuilder::get_Length()
    IL_0087: box class System.Int32
    IL_008c: call void class [System.Console]System.Console::WriteLine(string, [System.Runtime]System.Object)
    IL_0091: nop
    IL_0092: call void class [System.Console]System.Console::WriteLine()
    IL_0097: nop
    IL_0098: ret
  } // End of method System.Void Program::<<Main>$>g__FunWithStringBuilder|0_8()
} // End of class Program
