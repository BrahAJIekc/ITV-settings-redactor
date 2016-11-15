using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsITV_Settings.Methods
{
    public static class CopyTree
    {
	   public static TreeNode mCopyTree(TreeView t)
	   {
		  TreeNode tree = new TreeNode("Камеры");
		  //tree.Nodes.Add(t.Nodes[0].Text);

		  for (int i = 0; i < t.Nodes[0].Nodes.Count; i++)
			{
				tree.Nodes.Add(t.Nodes[0].Nodes[i].Text);

			    for (int j = 0; j < t.Nodes[0].Nodes[i].Nodes.Count; j++)
			{
				    tree.Nodes[i].Nodes.Add(t.Nodes[0].Nodes[i].Nodes[j].Text);

				    for (int l = 0; l < t.Nodes[0].Nodes[i].Nodes[j].Nodes.Count; l++)
				    {

					   tree.Nodes[i].Nodes[j].Nodes.Add(t.Nodes[0].Nodes[i].Nodes[j].Nodes[l].Text);
				    }

			}
			}

		  return tree;
	   }
	   public static List<TreeNode> mCopyTree2(TreeView t)
	   {
		  List<TreeNode> tree = new List<TreeNode>();

		  for (int i = 0; i < t.Nodes.Count; i++)
		  {
			 tree.Add(t.Nodes[i]);
		  }
		  //tree.Nodes.Add(t.Nodes[0].Text);
		  //tree.Nodes[0].Remove();
		  //for (int i = 0; i < t.Nodes.Count; i++)
		  //{
		  //    tree.Nodes.Add(t.Nodes[i].Text);

		  //    for (int j = 0; j < t.Nodes[i].Nodes.Count; j++)
		  //    {
		  //	   tree.Nodes[i].Nodes.Add(t.Nodes[i].Nodes[j].Text);

		  //	   //for (int l = 0; l < t.Nodes[0].Nodes[i].Nodes[j].Nodes.Count; l++)
		  //	   //{



		  //	   //}

		  //    }
		  
		  return tree;
	   }
    }
}
