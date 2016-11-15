using System.Windows.Forms;

namespace WindowsFormsITV_Settings.Methods
{
    public static class CheckedNodes
    {
	   public static void mCheckedNodes(ref TreeView treeView1)
	   {
		  for (int i = 0; i < treeView1.Nodes.Count; i++)
		  {
			 treeView1.Nodes[i].Checked = true;
			 for (int j = 0; j < treeView1.Nodes[i].Nodes.Count; j++)
			 {
				//treeView1.Nodes[i].Nodes[j].Checked = true;
				for (int c = 0; c < treeView1.Nodes[i].Nodes[j].Nodes.Count; c++)
				{
				    for (int k = 0; k < treeView1.Nodes[i].Nodes[j].Nodes[c].Nodes.Count; k++)
				    {
					   treeView1.Nodes[i].Nodes[j].Nodes[c].Nodes[k].Checked = true;
				    }
				}
			 }
		  }
	   }
    }
}
