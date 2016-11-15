using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using LexemWork.Core;

namespace WindowsFormsITV_Settings.Methods
{
    public static class XClick
    {
	   public static void mxClick(string x, string y)
	   {
		  string camnum = Regex.Replace(y, @"^(.*)\s", "");
		  camnum = Regex.Replace(camnum, @"[A-Za-z]|[А-Яа-я]", "");

		  y = Convert.ToString(Regex.Match(y, @"^(.*)\s"));
		  y = y.Substring(0, y.Length - 1);
		  //y = Regex.Replace(y, @"\d{1}|\d{2}|\d{3}|\d{4}|\d{5}|\d{6}|\d{7}|\d{8}|\d{9}", "");
		  TreeNode<NodeData> tree = JsonConvert.DeserializeObject(Form1000.devjson, typeof(TreeNode<NodeData>)) as TreeNode<NodeData>;
		  TreeNode<NodeData> SecondTree = tree.GetChildByName(x);

		  if (SecondTree.GetChildByName(y) != null && SecondTree.GetChildByName(y).Data.Value == camnum)
		  {
			 //MessageBox.Show(SecondTree.GetChildByName(y)+" "+SecondTree.GetChildByName(y).Data.Value);
			 TreeNode<NodeData> child = SecondTree.GetChildByName(y);
			 SecondTree.RemoveChild(child);
			 string jsonout = string.Empty;
			 object obj = tree;
			 jsonout = JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);
			 Form1000.devjson = jsonout;
		  }
	   }
    }
}
