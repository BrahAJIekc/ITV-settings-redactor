using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using LexemWork.Core;
using System.Collections.Generic;

namespace WindowsFormsITV_Settings.Methods
{
    public static class PlusClick
    {
	   static bool Equal(string x, string y,string camnum) 
	   {

		  //MessageBox.Show(camnum);
		  //camnum = camnum.Remove(camnum.Length - 1, camnum.Length);

		  TreeNode<NodeData> tree = JsonConvert.DeserializeObject(Form1000.devjson, typeof(TreeNode<NodeData>)) as TreeNode<NodeData>;
		  TreeNode<NodeData> SecondTree = tree.GetChildByName(x);
		  int count = 0;
		  foreach (var item in SecondTree.GetChildsByName(y))
		  {
			 if (item.Data.Value == camnum)
				count++;
		  }
		  if (count == 0)
			 return false;
		  else return true;

	   } 
	   public static void mPlusClick(string x, string y)
	   {
		  string camnum = Regex.Replace(y, @"^(.*)\s", "");
		  camnum = Regex.Replace(camnum, @"[A-Za-z]|[А-Яа-я]", "");
		  //camnum = camnum.Remove(camnum.Length - 1, camnum.Length);
		  y = Convert.ToString(Regex.Match(y, @"^(.*)\s"));
		  y = y.Substring(0, y.Length - 1);
		  
		  //MessageBox.Show(y);
		  //y = Regex.Replace(y, @"\d{1}|\d{2}|\d{3}|\d{4}|\d{5}|\d{6}|\d{7}|\d{8}|\d{9}", "");

		  TreeNode<NodeData> tree = JsonConvert.DeserializeObject(Form1000.devjson, typeof(TreeNode<NodeData>)) as TreeNode<NodeData>;
		  TreeNode<NodeData> SecondTree = tree.GetChildByName(x);

		  //MessageBox.Show(SecondTree.GetChildByName(y).Name + "-" + SecondTree.GetChildByName(y).Data.Value + "-" + camnum + "-");
		  TreeNode<NodeData> child = new TreeNode<NodeData>(new NodeData(camnum),y);

		  if (SecondTree.GetChildByName(y) != null)
		  {//MessageBox.Show(SecondTree.GetChildByName(y).Name + "-" + SecondTree.GetChildByName(y).Data.Value + "-" + camnum + "-");
			 if (SecondTree.GetChildByName(y).Name == y && Equal(x,y,camnum)==false)
			 {
				//MessageBox.Show(SecondTree.GetChildByName(y).Data.Value);
				//MessageBox.Show(camnum);

				//MessageBox.Show(SecondTree.GetChildByName(y).Name + "-" + SecondTree.GetChildByName(y).Data.Value + "-" + camnum + "-");

				SecondTree.AddChild(child);
				string jsonout = string.Empty;
				object obj = tree;
				jsonout = JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);
				Form1000.devjson = jsonout;
			 }
		  }
		  else
		  {
			// MessageBox.Show("lol "+ y + " "+ SecondTree.Name);
			 SecondTree.AddChild(child);
			 string jsonout = string.Empty;
			 object obj = tree;
			 jsonout = JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);
			 Form1000.devjson = jsonout;
		  }
	   }
    }
}
