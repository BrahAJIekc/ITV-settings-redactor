using System.Windows.Forms;

namespace WindowsFormsITV_Settings.Methods
{
    public static class ClearingAndFilling
    {
	   public static void mClearingAndFilling()
	   {

		  for (int g = 0; g < Form1000.treeView1.Nodes[0].Nodes.Count; g++)
		  {
			 for (int j = 0; j < Form1000.treeView1.Nodes[0].Nodes[g].Nodes.Count; j++)
			 {
				    Form1000.treeView1.Nodes[0].Nodes[g].Nodes[j].Nodes.Clear();
			 }
		  }

		  Form1000.labelToolStripMenuItem.Text = "Данные не сохранены";
		  //label1.Text = "Данные не сохранены";
		  //EventsBindings();
		  WindowsFormsITV_Settings.Methods.BindDictionaryFromDevRules.mBindDictionaryFromDevRules(ref Form1000.treeView1, ref Form1000.devjson, ref Form1000.eventdiction);
		  Form1000.treeView2.CheckBoxes = true;
		  Form1000.treeView1.CheckBoxes = true;
		  WindowsFormsITV_Settings.Methods.CheckedNodes.mCheckedNodes(ref Form1000.treeView1);
	   }
    }
}
