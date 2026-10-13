using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPSI.UControls
{
        public partial class UserTabControl : TabControl
        {
                public UserTabControl()
                {
                        InitializeComponent();
                        //减少闪烁
                        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
                }
                protected override CreateParams CreateParams
                {
                        get
                        {
                                CreateParams cp = base.CreateParams;
                                cp.ExStyle |= 0x02000000;
                                return cp;
                        }
                }
        }
}
