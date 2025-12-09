using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LANMIC_ComBank_Interface.HelpServices
{
    public static class ControlHelpers
    {
        public static Panel AddHorizontalSeparator(Control container,
                                                   int height = 1,
                                                   Color? backColor = null,
                                                   Padding? margin = null,
                                                   DockStyle dock = DockStyle.Top,
                                                   bool bringToFront = true)
        {
            Panel separator = new Panel
            {
                Height = height,
                BackColor = backColor ?? Color.FromArgb(200, 200, 200), // Default light gray
                Dock = dock,
                Margin = margin ?? new Padding(0, 20, 0, 10) // Default margin
            };

            container.Controls.Add(separator);
            if (bringToFront)
            {
                separator.BringToFront();
            }

            return separator; // Return the separator so you can modify it further if needed


            ////horizontal line
            //var separator = new Panel
            //{
            //    Height = 1,
            //    BackColor = Color.FromArgb(200, 200, 200),
            //    Dock = DockStyle.Top,
            //    Margin = new Padding(0, 20, 0, 10)
            //};
            //this.Controls.Add(separator);
            //separator.BringToFront();
        }
    }
}
