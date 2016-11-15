using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace WindowsFormsITV_Settings.Methods
{
    public static class BindTreViewText
    {
	   public static void mBindTreViewText(ref TreeView treeView1)
	   {
		  try
		  {
			 XmlDocument xdoc = new XmlDocument();
			 string path = "TreeConfig.xml";
			 xdoc.Load(path);
			 treeView1.Nodes.Clear();
			 treeView1.Nodes.Add(new TreeNode(xdoc.DocumentElement.Name));
			 TreeNode rnode = treeView1.Nodes[0];
			 AddText(xdoc.DocumentElement, rnode);
			 treeView1.ExpandAll();
		  }
		  catch 
		  {

			 StreamWriter sw = new StreamWriter("TreeConfig.xml");
			 sw.Write("<?xml version=\"1.0\" encoding=\"utf-8\" ?>\n<Камеры>\n<Камера1/>\n</Камеры>");
			 sw.Close();

			 XmlDocument xdoc = new XmlDocument();
			 string path = "TreeConfig.xml";
			 xdoc.Load(path);
			 treeView1.Nodes.Clear();
			 treeView1.Nodes.Add(new TreeNode(xdoc.DocumentElement.Name));
			 TreeNode rnode = treeView1.Nodes[0];
			 AddText(xdoc.DocumentElement, rnode);
			 treeView1.ExpandAll();
		  }
	   }
	   private static void AddText(XmlNode xnode, TreeNode tnode)
	   {
		  XmlNode new_x_node;
		  TreeNode new_tnode;
		  XmlNodeList x_list;
		  if (xnode.HasChildNodes)
		  {
			 x_list = xnode.ChildNodes;
			 for (int i = 0; i <= x_list.Count - 1; i++)
			 {
				new_x_node = xnode.ChildNodes[i];
				tnode.Nodes.Add(new TreeNode(new_x_node.Name));
				new_tnode = tnode.Nodes[i];
				AddText(new_x_node, new_tnode);
			 }
		  }
		  else { tnode.Text = (xnode.OuterXml).Trim(); };
	   }
    }
}
