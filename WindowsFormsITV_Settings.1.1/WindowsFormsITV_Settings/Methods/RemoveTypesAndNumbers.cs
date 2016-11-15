using System.Windows.Forms;
using Newtonsoft.Json;
using LexemWork.Core;

namespace WindowsFormsITV_Settings.Methods
{
    public static class RemoveTypesAndNumbers
    {
	   public static void mRemoveTypesAndNumbers(string ev)
	   {
		  //string json = null;

		  //StreamReader strread = new StreamReader("DevRules.json");
		  //json = strread.ReadToEnd();
		  //strread.Close();

		  TreeNode<NodeData> tree = JsonConvert.DeserializeObject(Form1000.devjson, typeof(TreeNode<NodeData>)) as TreeNode<NodeData>;
		  TreeNode<NodeData> SecondTree = tree.GetChildByName(ev);
		  //TreeNode<NodeData> dev = new TreeNode<NodeData>(new NodeData(Convert.ToString(numericUpDown3.Value)), b + numericUpDown3.Value);
		  //TreeNode<NodeData> dev = new TreeNode<NodeData>( b + numericUpDown3.Value);
		  if (SecondTree.GetChildByName(Form1000.b + Form1000.numericUpDown3.Value) != null)
		  {
			 TreeNode<NodeData> child = SecondTree.GetChildByName(Form1000.b + Form1000.numericUpDown3.Value);
			 SecondTree.RemoveChild(child);
			 string jsonout = string.Empty;
			 object obj = tree;
			 jsonout = JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);
			 Form1000.devjson = jsonout;
			 //StreamWriter strwtr = new StreamWriter("DevRules.json");
			 //strwtr.Write(jsonout);
			 //strwtr.Close();
		  }

	   }

    }
}
