using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgerDukkani.Classes
{
    public class Helper
    {
        public static void Temizle(Control.ControlCollection collection)
        {
            foreach (Control control in collection)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is NumericUpDown)
                {
                    ((NumericUpDown)control).Value = 0;
                }
                else if (control is ComboBox)
                {
                    ComboBox cbox = (ComboBox)control;
                    cbox.SelectedIndex = 0;
                }
                else if(control is ListBox)
                {
                    ((ListBox)control).Items.Clear();   
                }
                else if (control is RadioButton)
                {
                    RadioButton rb = (RadioButton)control;
                    if (rb.Name == "rbKucuk")
                    {
                        rb.Checked = true;
                    }
                    else rb.Checked = false;
                }
                else if (control is CheckedListBox) 
                {
                    ((CheckedListBox)control).Items.Clear();
                }
              
            }
        }
    }
}

