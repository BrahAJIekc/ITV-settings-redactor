using System.Windows.Forms;

namespace WindowsFormsITV_Settings.Methods
{
    public static class SetToggles
    {
	   public static void mSetToggles(ref TreeView treeView1)
	   {
		  for (int i = 0; i < treeView1.Nodes.Count; i++)
		  {
			 for (int j = 0; j < treeView1.Nodes[i].Nodes.Count; j++)
			 {
				for (int q = 0; q < treeView1.Nodes[i].Nodes[j].Nodes.Count; q++)
				{
				    treeView1.Nodes[i].Nodes[j].Nodes[q].Toggle();
				}
			 }
		  }
	   }
    }
}