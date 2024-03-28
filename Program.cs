var typeNames = new List<string> {
    "System.Boolean",
    "System.Byte",
    "System.SByte",
    "System.Char",
    "System.Decimal",
    "System.Double",
    "System.Single",
    "System.Int32",
    "System.UInt32",
    "System.IntPtr",
    "System.UIntPtr",
    "System.Int64",
    "System.UInt64",
    "System.Int16",
    "System.UInt16",
    "System.Object",
    "System.String"
};

foreach (string typeName in typeNames) {
    Console.WriteLine($"Type: {typeName}, DefaultValue: {Activator.CreateInstance(Type.GetType(typeName))}");
};

