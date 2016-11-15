using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using LexemWork.Core;
namespace WindowsFormsITV_Settings.Methods
{
    public static class DevicesIn
    {
	   public static void mDevicesIn(ref TreeView treeView2,ref string devjson)
	   {
		  try
		  {
			 TreeNode<NodeData> tree = JsonConvert.DeserializeObject(devjson, typeof(TreeNode<NodeData>)) as TreeNode<NodeData>;
			 for (int i = 0; i < tree.ChildrenCount; i++)
			 {
				TreeNode<NodeData> SecondTree = tree.GetChild(i);
				for (int j = 0; j < SecondTree.ChildrenCount; j++)
				{
				    TreeNode<NodeData> devtree = SecondTree.GetChild(j);
				    for (int r = 0; r < treeView2.Nodes.Count; r++)
				    {
					   if (SecondTree.Name == Convert.ToString(Regex.Match(treeView2.Nodes[r].Text.Remove(0, 8), @"\S.?\S")))
					   {
						  treeView2.Nodes[r].Nodes.Add(" " + " ⇒ " + devtree.Name + " Камера" + devtree.Data.Value + "");
						  //treeView2.Nodes[r].Text += " " + "=>" + devtree.Name + " К"+devtree.Data.Value+"";
					   }
				    }
				}
			 }
		  }
		  catch { };
	   }
    }
}
