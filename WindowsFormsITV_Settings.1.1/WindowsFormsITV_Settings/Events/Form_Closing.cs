using System.Windows.Forms;

namespace WindowsFormsITV_Settings.Events
{
    public static class Form_Closing
    {
	   public static void Form1000_FormClosing(object sender, FormClosingEventArgs e)
	   {
		  if (Form1000.labelToolStripMenuItem.Text == "Данные не сохранены")//label1.Text == "Данные не сохранены")
		  {
			 if (MessageBox.Show("Не желаете сохранить изменения ?", "Настройка сервиса ITV",
	    MessageBoxButtons.YesNo) == DialogResult.Yes)
			 {
				Form1000.сохранитьToolStripMenuItem.PerformClick();
				//button4.PerformClick();
				// Cancel the Closing event from closing the form.
				e.Cancel = true;
				// Call method to save file...
			 }

		  }
	   }

    }
}
