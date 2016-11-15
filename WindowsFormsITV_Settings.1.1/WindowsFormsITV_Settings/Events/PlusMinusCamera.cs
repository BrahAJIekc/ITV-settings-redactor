using System;
using System.Windows.Forms;

namespace WindowsFormsITV_Settings.Events
{
    public static class PlusMinusCamera
    {
	   public static void камераToolStripMenuItem_Click(object sender, EventArgs e)
	   {
		  if (Form1000.treeView1.Nodes[0].Nodes.Count < 100)
		  {
			 if (Form1000.treeView1.Nodes[0].Nodes.Count > 0)
			 {
				//string str = treeView1.Nodes[0].Nodes[treeView1.Nodes[0].Nodes.Count - 1].Text.Substring(0, treeView1.Nodes[0].Nodes[treeView1.Nodes[0].Nodes.Count - 1].Text.Length - 1);

				Form1000.treeView1.Nodes[0].Nodes.Add("Камера" + Convert.ToString(Form1000.treeView1.Nodes[0].Nodes.Count + 1));
			 }

			 else { Form1000.treeView1.Nodes[0].Nodes.Add("Камера1"); }
		  }

		  WindowsFormsITV_Settings.Methods.ClearingAndFilling.mClearingAndFilling();
		  
		  //Form1000.last = Form1000.treeView1.Nodes[0].Nodes.Count;
		  //MessageBox.Show(Convert.ToString(Form1000.last));

	   }

	   public static void камераToolStripMenuItem1_Click(object sender, EventArgs e)
	   {
		  if (Form1000.treeView1.Nodes[0].Nodes.Count > 0)
		  {
			 Form1000.treeView1.Nodes[0].Nodes[Form1000.treeView1.Nodes[0].Nodes.Count - 1].Remove();

			 WindowsFormsITV_Settings.Methods.ClearingAndFilling.mClearingAndFilling();
		  }
	   }

    }
}
