using System.Windows.Forms;
using System.IO;


namespace WindowsFormsITV_Settings.Methods
{
    public static class RewriteConfig
    {	  public static StreamWriter swww;
	   public static void mRewriteConfig(ref TreeView treeView1)
	   { 
		  
		  string filename = "TreeConfig.xml";//"C:\\work\\Config.xml";
		  swww = new StreamWriter(filename, false, System.Text.Encoding.UTF8);
		  //Write the header
		  swww.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
		  //Write our root node
		  swww.WriteLine("<" + treeView1.Nodes[0].Text + ">");
		  foreach (TreeNode node in treeView1.Nodes)
		  {
			 saveNode(node.Nodes);
		  }
		  //Close the root node
		  swww.WriteLine("</" + treeView1.Nodes[0].Text + ">");
		  swww.Close();
	   }
	   public static  void saveNode(TreeNodeCollection tnc)
	   {
		  foreach (TreeNode node in tnc)
		  {
			 //If we have child nodes, we'll write 
			 //a parent node, then iterrate through
			 //the children
			 if (node.Nodes.Count > 0 & node.Level < 2)
			 {
				swww.WriteLine("<" + node.Text + ">");
				saveNode(node.Nodes);
				swww.WriteLine("</" + node.Text + ">");
			 }
			 else //No child nodes, so we just write the text
				swww.WriteLine("<" + node.Text + "/>");
		  }
	   }
    }
}
