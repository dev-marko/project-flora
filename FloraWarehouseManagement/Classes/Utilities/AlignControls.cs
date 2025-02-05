﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloraWarehouseManagement.Classes.Utilities
{
    public class AlignControls
    {
        public AlignControls() { }
        public static void CenterControlHorizontal(Control ctrlToCenter)
        {
            ctrlToCenter.Left = (ctrlToCenter.Parent.Width - ctrlToCenter.Width) / 2;
        }

        public static void CenterControl(Control ctrlToCenter)
        {
            ctrlToCenter.Left = (ctrlToCenter.Parent.Width - ctrlToCenter.Width) / 2;
            ctrlToCenter.Top = (ctrlToCenter.Parent.Height - ctrlToCenter.Height) / 2;
        }

        public static void PositionCursorInMaskedTextBox(Form f, MaskedTextBox mtb)
        {
            if (mtb == null) return;

            int pos = mtb.SelectionStart;

            if (pos > mtb.Text.Length)
            {
                f.BeginInvoke((MethodInvoker)delegate () { mtb.Select(mtb.Text.Length, 0); });
            }
        }

    }
}
