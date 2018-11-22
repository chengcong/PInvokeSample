//输出user32.dll函数信息。dumpbin /exports user32.dll >U:\DesktopBridgeProjects\PInvokeSamples\PInvokeSamples\PInvoke.Shared\user32dllFunctionList.txt
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAPI
{
    public class msvcrt
    {
        /// <summary>
        /// 标准微软C运行库"msvcrt.dll"：输出文本
        /// </summary>
        /// <param name="msg">输出文本</param>
        /// <returns></returns>
        [DllImport("msvcrt.dll")]
        public static extern int puts(string msg);
        /// <summary>
        /// 标准微软C运行库"msvcrt.dll":清除输出流
        /// </summary>
        /// <returns></returns>
        [DllImport("msvcrt.dll")]
        public static extern int _flushall();
    }
    public class user32
    {

        /// <summary>
        /// Win32 API调用：弹出对话框
        /// 原型：int MessageBox(HWND hWnd,LPCTSTR lpText,LPCTSTR lpCaption,UINT uType);
        /// </summary>
        /// <param name="hWnd">对话框句柄</param>
        /// <param name="lpText">输出文本</param>
        /// <param name="lpCaption">标题</param>
        /// <param name="uType">对话框类型</param>
        /// <returns></returns>
        [DllImport("user32.dll", EntryPoint = "MessageBox")]
        public static extern int MessageBox(int hWnd, string lpText, string lpCaption, uint uType);


    }
    public class kernel32
    {
        /// <summary>
        /// 获取Windows系统目录（System目录）的完整路径
        /// </summary>
        /// <param name="lpBuffer">用于装载系统目录路径的一个字符串缓冲区</param>
        /// <param name="uSize">lpBuffer字串的最大长度</param>
        /// 原型：UINT GetSystemDirectory(LPTSTR lpBuffer,UINT uSize);
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        public static extern uint GetSystemDirectory(StringBuilder lpBuffer, uint uSize);
    }
}
