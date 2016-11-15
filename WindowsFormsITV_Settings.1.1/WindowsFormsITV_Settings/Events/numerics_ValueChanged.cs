using System;

namespace WindowsFormsITV_Settings.Events
{
    public static class numerics_ValueChanged
    {
	   public static  void numericUpDown1_ValueChanged(object sender, EventArgs e)
	   {
		  Form1000.button1.Text = " Добавить устройство " + Form1000.numericUpDown1.Value + " в камеру " + Form1000.numericUpDown2.Value;
		  //Form1000.button2.Text = " Удалить устройство " + Form1000.numericUpDown1.Value + " из камеры " + Form1000.numericUpDown2.Value;
	   }

	   public static void numericUpDown2_ValueChanged(object sender, EventArgs e)
	   {
		  Form1000.button1.Text = " Добавить устройство " + Form1000.numericUpDown1.Value + " в камеру " + Form1000.numericUpDown2.Value;
		  Form1000.button2.Text = " Добавить камеру " + Form1000.numericUpDown2.Value;
	   }

	   public static void numericUpDown3_ValueChanged(object sender, EventArgs e)
	   {
		  Form1000.button6.Text = "Добавить в устройство " + Form1000.numericUpDown3.Value;
		  Form1000.button5.Text = "Удалить из устройства " + Form1000.numericUpDown3.Value;
	   }
    }
}
