# if false

using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using System.IO;

public static class Programm {

    public static void Main(string[] args) {
        Console.WriteLine("==== EnumWithNum ====\n");

        Console.WriteLine((int)Best.b);

    }

    public enum Best {
        a = 10,
        b,
    }
}
# endif