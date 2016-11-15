using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsITV_Settings.Methods
{
    public static class DeleteNodesFromListBox
    {
	   public static void mDeleteNodesFromListBox(ref TreeView treeView1,ref ListBox listBox1)
	   {

		  foreach (string item in listBox1.Items)
		  {
			 string nd = Convert.ToString(Regex.Match(item, @"^(.*)\s"));
			 string cam = item.Replace(nd, "");
			 nd = nd.Substring(0, nd.Length - 1);
			 //cam = cam.Substring(0, cam.Length - 1);
			 for (int i = 0; i < treeView1.Nodes[0].Nodes.Count; i++)
			 {
				for (int k = 0; k < treeView1.Nodes[0].Nodes[i].Nodes.Count; k++)
				{
				    if (nd == treeView1.Nodes[0].Nodes[i].Nodes[k].Text)
				    {
					   if (treeView1.Nodes[0].Nodes[i].Text == cam)
						  treeView1.Nodes[0].Nodes[i].Nodes.Remove(treeView1.Nodes[0].Nodes[i].Nodes[k]);
				    }
				}
			 }
		  }
	   }
    }
}
