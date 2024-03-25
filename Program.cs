using System;
using System.Runtime.InteropServices;

class Program
{
    // Объявление функции API MessageBox
    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);
    static void Main(string[] args)
    {
        // Вызов функции API MessageBox
        MessageBox(IntPtr.Zero, "Пример вызова функции API с помощью С#", "API", 0);
    }
}