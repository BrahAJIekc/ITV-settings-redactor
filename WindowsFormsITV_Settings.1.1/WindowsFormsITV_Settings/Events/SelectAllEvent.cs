using System;

namespace WindowsFormsITV_Settings.Events
{
    public static class SelectAllEvent
    {
	   public static void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
	   {
		  if (Form1000.выделитьВсеToolStripMenuItem.Text == "Выделить все события")
		  {
			 for (int i = 0; i < Form1000.treeView2.Nodes.Count; i++)
			 {
				Form1000.treeView2.Nodes[i].Checked = true;
			 }

			 Form1000.выделитьВсеToolStripMenuItem.Text = "        Отмена       ";
		  }

		  else
		  {
			 for (int i = 0; i < Form1000.treeView2.Nodes.Count; i++)
			 {
				Form1000.treeView2.Nodes[i].Checked = false;
			 }
			 Form1000.выделитьВсеToolStripMenuItem.Text = "Выделить все события";

		  }
	   }
    }
}
