Library "ScriptParameter"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct ScriptParameter
    {
        [FieldOffset(0x00)] public uint intervalMinuntes;
    }

}