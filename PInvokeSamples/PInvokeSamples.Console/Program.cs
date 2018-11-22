using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAPI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //PInvoke.puts("微软标准C运行库msvcrt.dll打印的字符");
            //PInvoke._flushall();
            //PInvoke.MessageBox(0, "AAA", "BBB", 1);

            StringBuilder lpBuffer = new StringBuilder(256);
            kernel32.GetSystemDirectory( lpBuffer, 256);
            user32.MessageBox(0, lpBuffer.ToString(),"输出结果" , 1);
        }
    }
}
