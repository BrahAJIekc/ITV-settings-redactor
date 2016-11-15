
namespace WindowsFormsITV_Settings.Methods
{
    public static class UncheckingItem
    {
	   public static void mUncheckingItem()
	   {


		  for (int g = 0; g < Form1000.treeView1.Nodes[0].Nodes.Count; g++)
		  {

			 for (int j = 0; j < Form1000.treeView1.Nodes[0].Nodes[g].Nodes.Count; j++)
			 {


				Form1000.treeView1.Nodes[0].Nodes[g].Nodes[j].Checked = false;

			 }
		  }
	   }
    }
}
