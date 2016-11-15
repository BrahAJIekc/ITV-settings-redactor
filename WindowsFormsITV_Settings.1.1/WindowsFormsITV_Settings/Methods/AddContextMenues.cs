using System.Windows.Forms;
using System;

namespace WindowsFormsITV_Settings.Methods
{
    public static class AddContextMenues
    {
	   public static void mAddContextMenues(Button bt)
	   {
		  ContextMenu cm = new ContextMenu();
		  cm.MenuItems.Clear();

		  Form1000.menuItem1.Text = "POS"+ Convert.ToString(Form1000.numericUpDown3.Value);
		  Form1000.menuItem2.Text = "BOS" + Convert.ToString(Form1000.numericUpDown3.Value);
		  Form1000.menuItem3.Text = "ТРК" + Convert.ToString(Form1000.numericUpDown3.Value);
		  Form1000.menuItem4.Text = "Уровнемер" + Convert.ToString(Form1000.numericUpDown3.Value);
		  Form1000.menuItem5.Text = "OPT" + Convert.ToString(Form1000.numericUpDown3.Value);
		  Form1000.menuItem6.Text = "DOMS" + Convert.ToString(Form1000.numericUpDown3.Value);

		  cm.MenuItems.Add(Form1000.menuItem1);
		  cm.MenuItems.Add(Form1000.menuItem2);
		  cm.MenuItems.Add(Form1000.menuItem3);
		  cm.MenuItems.Add(Form1000.menuItem4);
		  cm.MenuItems.Add(Form1000.menuItem5);
		  cm.MenuItems.Add(Form1000.menuItem6);
		  cm.Show(bt, new System.Drawing.Point(0, 0));
		  cm.MenuItems.Clear();
	   }
    }
}
