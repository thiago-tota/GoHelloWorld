using System;
using System.Runtime.InteropServices;

namespace HelloGo
{
    class Program
    {
        [DllImport(@"GoWrapper", EntryPoint = "HelloGo", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private static extern int HelloGo(string name);

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(HelloGo("Thiago Tota"));
        }
    }
}
