using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using LexemWork.Core;

namespace WindowsFormsITV_Settings.Methods
{
    public static class AddTypesAndNumbers
    {
	   public static void mAddTypesAndNumbers(string ev)
	   {
		  //string json = null;

		  //StreamReader strread = new StreamReader("DevRules.json");
		  //json = strread.ReadToEnd();
		  //strread.Close();
		  try
		  {
			 
			 TreeNode<NodeData> tree = JsonConvert.DeserializeObject(Form1000.devjson, typeof(TreeNode<NodeData>)) as TreeNode<NodeData>;
			 TreeNode<NodeData> SecondTree = tree.GetChildByName(ev);
			 TreeNode<NodeData> dev = new TreeNode<NodeData>(Form1000.b + Form1000.numericUpDown3.Value);
			 SecondTree.AddChild(dev);
			 string jsonout = string.Empty;
			 object obj = tree;
			 jsonout = JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);
			 Form1000.devjson = jsonout;

		  }
		  catch
		  {
			 StreamReader strread = new StreamReader("emptyDevRules.json.txt");
			 string json = null;
			 json = strread.ReadToEnd();
			 strread.Close();
			 Form1000.devjson = json;
			 TreeNode<NodeData> tree = JsonConvert.DeserializeObject(Form1000.devjson, typeof(TreeNode<NodeData>)) as TreeNode<NodeData>;
			 TreeNode<NodeData> SecondTree = tree.GetChildByName(ev);
			 TreeNode<NodeData> dev = new TreeNode<NodeData>(Form1000.b + Form1000.numericUpDown3.Value);
			 SecondTree.AddChild(dev);
			 string jsonout = string.Empty;
			 object obj = tree;
			 jsonout = JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);
			 Form1000.devjson = jsonout;

		  }
		  //TreeNode<NodeData> dev = new TreeNode<NodeData>( b + numericUpDown3.Value);
		  //SecondTree.AddChild(dev);
		  //string jsonout = string.Empty;
		  //object obj = tree;
		  //jsonout = JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);
		  //devjson = jsonout;
		  //StreamWriter strwtr = new StreamWriter("DevRules.json");
		  //strwtr.Write(jsonout);
		  //strwtr.Close();


	   }
    }
}
