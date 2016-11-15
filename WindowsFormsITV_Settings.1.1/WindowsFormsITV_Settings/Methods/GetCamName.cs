using System.Windows.Forms;

namespace WindowsFormsITV_Settings.Methods
{
    public static class GetCamName
    {
	   public static void mGetCamName(ref TreeView treeView1)
	   {

		  for (int i = 0; i < treeView1.Nodes.Count; i++)
		  {
			 for (int j = 0; j < treeView1.Nodes[i].Nodes.Count; j++)
			 {
				if (treeView1.Nodes[i].Nodes[j].Nodes.Count == 0)
				{

				    treeView1.Nodes[i].Nodes[j].Text = treeView1.Nodes[i].Nodes[j].Text.Remove(0, 1);
				    treeView1.Nodes[i].Nodes[j].Text = treeView1.Nodes[i].Nodes[j].Text.Remove(treeView1.Nodes[i].Nodes[j].Text.Length - 3);
				}
			 }

		  }
	   }
    }
}
