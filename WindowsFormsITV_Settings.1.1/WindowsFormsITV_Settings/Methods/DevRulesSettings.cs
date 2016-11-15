using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using LexemWork.Core;

namespace WindowsFormsITV_Settings.Methods
{
    public static class DevRulesSettings
    {

	   public static void mDevRulesSettings()
	   {
		  TreeNode<NodeData> newtree = new TreeNode<NodeData>();
		  newtree.Name = "root";

		  //TreeNode<NodeData> newtreeN = new TreeNode<NodeData>("POS");
		  //TreeNode<NodeData> newtreeT = new TreeNode<NodeData>("BOS");

		  for (int i = 0; i < Form1000.treeView2.Nodes.Count; i++)
		  {
			 TreeNode<NodeData> newtree1 = new TreeNode<NodeData>();
			 newtree1.Name = Convert.ToString(Regex.Match(Form1000.treeView2.Nodes[i].Text.Remove(0, 8), @"\S.?\S"));
			 newtree.Children.AddLast(newtree1);
			 //newtree1.Children.AddLast(newtreeN);
			 //newtree1.Children.AddLast(newtreeT);

		  }
		  string json = string.Empty;
		  object obj = newtree;
		  json = JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);
		  Form1000.devjson = json;
		  //StreamWriter strwtr = new StreamWriter("DevRules.json");
		  //strwtr.Write(json);
		  //strwtr.Close();

	   }
    }
}
