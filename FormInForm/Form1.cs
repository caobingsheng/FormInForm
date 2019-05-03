using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vanara.PInvoke;

namespace FormInForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var handler = User32_Gdi.FindWindow("#32770", "Windows 任务管理器");
            if (!handler.IsNull)
            {
                User32_Gdi.SetParent(handler, new HWND(Handle));
            }
        }
    }
}
