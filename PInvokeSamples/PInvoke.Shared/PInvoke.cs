using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PInvokeSamples
{
    public class PInvoke
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
        /// <summary>
        /// Win32 API调用：弹出对话框
        /// </summary>
        /// <param name="hWnd">对话框句柄</param>
        /// <param name="lpText">输出文本</param>
        /// <param name="lpCaption">标题</param>
        /// <param name="uType">对话框类型</param>
        /// <returns></returns>
        [DllImport("user32.dll",EntryPoint ="MessageBox")]
        public static extern int MessageBox(int hWnd, string lpText, string lpCaption, uint uType);
    }
}
