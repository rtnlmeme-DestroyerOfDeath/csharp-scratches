# if false

using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using System.IO;

public static class Programm {

    public static void Main(string[] args) {
        Console.WriteLine("==== indexOf ====\n");

        var arr = new int[] { 1 , 2 , 3 };

        var i = Array.IndexOf(arr,10);

        Console.WriteLine(i);
        Console.WriteLine(Array.IndexOf(null,10));



    }
}
# endif