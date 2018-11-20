using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PInvokeSamples.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            PInvoke.puts("微软标准C运行库msvcrt.dll打印的字符");
            //PInvoke._flushall();
            PInvoke.MessageBox(0, "AAA", "BBB", 1);
        }
    }
}
