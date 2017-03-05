using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Scheorbi
{
    public class KeyHandler
    {
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private int key;
        private IntPtr hWnd;
        private int id;

        public KeyHandler(Keys key, Form form)
        {
            this.key = (int)key;
            this.hWnd = form.Handle;
            id = this.GetHashCode();
        }

        public override int GetHashCode()
        {
            return key ^ hWnd.ToInt32();
        }

        public bool Register()
        {
            return RegisterHotKey(hWnd, id, 0, key);
        }

        public bool Unregiser()
        {
            return UnregisterHotKey(hWnd, id);
        }

        public static Keys StringToKey(string key)
        {
            var res = Keys.None;

            switch (key)
            {
                case "F1":
                    res = Keys.F1;
                    break;
                case "F2":
                    res = Keys.F2;
                    break;
                case "F3":
                    res = Keys.F3;
                    break;
                case "F4":
                    res = Keys.F4;
                    break;
                case "F5":
                    res = Keys.F5;
                    break;
                case "F6":
                    res = Keys.F6;
                    break;
                case "F7":
                    res = Keys.F7;
                    break;
                case "F8":
                    res = Keys.F8;
                    break;
                case "F9":
                    res = Keys.F9;
                    break;
                case "F10":
                    res = Keys.F10;
                    break;
                case "F11":
                    res = Keys.F11;
                    break;
                case "F12":
                    res = Keys.F12;
                    break;
            }

            return res;
        }
    }
}
