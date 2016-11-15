using System;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using LexemWork.Core;

namespace WindowsFormsITV_Settings.Methods
{
    public static class CamRulesEdit
    {
	   public static void mCamRulesEdit()
	   {
		  TreeNode<NodeData> newtree = new TreeNode<NodeData>();
		  newtree.Name = "root";


		  for (int i = 0; i < Form1000.treeView1.Nodes.Count; i++)
		  {
			 for (int j = 0; j < Form1000.treeView1.Nodes[i].Nodes.Count; j++)
			 {
				TreeNode<NodeData> newtree1 = new TreeNode<NodeData>();
				//MessageBox.Show(Regex.Replace(Form1000.treeView1.Nodes[i].Nodes[j].Text, @"[A-Za-z]|[А-Яа-я]|\s", ""));
				newtree1.Name = Convert.ToString(Regex.Replace(Form1000.treeView1.Nodes[i].Nodes[j].Text,@"[A-Za-z]|[А-Яа-я]|\s", ""));
				newtree.Children.AddLast(newtree1);
				for (int q = 0; q < Form1000.treeView1.Nodes[i].Nodes[j].Nodes.Count; q++)
				{
				    TreeNode<NodeData> newtree2 = new TreeNode<NodeData>();
				    newtree2.Name = Form1000.treeView1.Nodes[i].Nodes[j].Nodes[q].Text;



				    for (int w = 0; w < Form1000.treeView1.Nodes[i].Nodes[j].Nodes[q].Nodes.Count; w++)
				    {
					   TreeNode<NodeData> newtree3 = new TreeNode<NodeData>();
					   newtree3.Name = Form1000.treeView1.Nodes[i].Nodes[j].Nodes[q].Nodes[w].Text.Substring(0, 11).Remove(0, 8);
					   newtree1.Children.AddLast(newtree3);
					   if (Form1000.treeView1.Nodes[i].Nodes[j].Nodes[q].Nodes[w].Text != null)
					   {
						  string t = null;
						  //TreeNode<NodeData> newtreeT = new TreeNode<NodeData>();
						  //TreeNode<NodeData> newtreeN =  new TreeNode<NodeData>();
						  //if (Regex.IsMatch(treeView1.Nodes[i].Nodes[j].Nodes[q].Text, @"\d{2}"))
						  //{

						  //    if (Regex.Replace(treeView1.Nodes[i].Nodes[j].Nodes[q].Text, @"\d{2}", "") == "POS") { t = "1"; }
						  //    if (Regex.Replace(treeView1.Nodes[i].Nodes[j].Nodes[q].Text, @"\d{2}", "") == "BOS") { t = "2"; }
						  //    if (Regex.Replace(treeView1.Nodes[i].Nodes[j].Nodes[q].Text, @"\d{2}", "") == "ТРК") { t = "3"; }
						  //    if (Regex.Replace(treeView1.Nodes[i].Nodes[j].Nodes[q].Text, @"\d{2}", "") == "Уровнемер") { t = "4"; }
						  //    if (Regex.Replace(treeView1.Nodes[i].Nodes[j].Nodes[q].Text, @"\d{2}", "") == "OPT") { t = "5"; }
						  //    if (Regex.Replace(treeView1.Nodes[i].Nodes[j].Nodes[q].Text, @"\d{2}", "") == "DOMS") { t = "6"; }
						  //    Regex.Replace(treeView1.Nodes[i].Nodes[j].Nodes[q].Text, @"\d{2}", "");
						  //	newtreeT = new TreeNode<NodeData>(new NodeData(t), "CurrentType");
						  //    newtreeN = new TreeNode<NodeData>(new NodeData(Regex.Replace(treeView1.Nodes[i].Nodes[j].Nodes[q].Text, @"\w", "")), "Number");
						  //}

						  //else
						  //{
						  string nodetext = Form1000.treeView1.Nodes[i].Nodes[j].Nodes[q].Text;
						  if (Regex.Replace(nodetext, @"\d{1}|\d{2}|\d{3}|\d{4}|\d{5}|\d{6}|\d{7}|\d{8}|\d{9}", "") == "POS") { t = "1"; }
						  if (Regex.Replace(nodetext, @"\d{1}|\d{2}|\d{3}|\d{4}|\d{5}|\d{6}|\d{7}|\d{8}|\d{9}", "") == "BOS") { t = "2"; }
						  if (Regex.Replace(nodetext, @"\d{1}|\d{2}|\d{3}|\d{4}|\d{5}|\d{6}|\d{7}|\d{8}|\d{9}", "") == "ТРК") { t = "3"; }
						  if (Regex.Replace(nodetext, @"\d{1}|\d{2}|\d{3}|\d{4}|\d{5}|\d{6}|\d{7}|\d{8}|\d{9}", "") == "Уровнемер") { t = "4"; }
						  if (Regex.Replace(nodetext, @"\d{1}|\d{2}|\d{3}|\d{4}|\d{5}|\d{6}|\d{7}|\d{8}|\d{9}", "") == "OPT") { t = "5"; }
						  if (Regex.Replace(nodetext, @"\d{1}|\d{2}|\d{3}|\d{4}|\d{5}|\d{6}|\d{7}|\d{8}|\d{9}", "") == "DOMS") { t = "6"; }

						  TreeNode<NodeData> newtreeT = new TreeNode<NodeData>(new NodeData(t), "CurrentType");
						  TreeNode<NodeData> newtreeN = new TreeNode<NodeData>(new NodeData(Regex.Replace(nodetext, @"[A-Za-z]|[А-Яа-я]", "")), "Number");

						  //    if (treeView1.Nodes[i].Nodes[j].Nodes[q].Text.Substring(0, treeView1.Nodes[i].Nodes[j].Nodes[q].Text.Length - 1) == "POS") { t = "1"; }
						  //    if (treeView1.Nodes[i].Nodes[j].Nodes[q].Text.Substring(0, treeView1.Nodes[i].Nodes[j].Nodes[q].Text.Length - 1) == "BOS") { t = "2"; }
						  //    if (treeView1.Nodes[i].Nodes[j].Nodes[q].Text.Substring(0, treeView1.Nodes[i].Nodes[j].Nodes[q].Text.Length - 1) == "ТРК") { t = "3"; }
						  //    if (treeView1.Nodes[i].Nodes[j].Nodes[q].Text.Substring(0, treeView1.Nodes[i].Nodes[j].Nodes[q].Text.Length - 1) == "Уровнемер") { t = "4"; }
						  //    if (treeView1.Nodes[i].Nodes[j].Nodes[q].Text.Substring(0, treeView1.Nodes[i].Nodes[j].Nodes[q].Text.Length - 1) == "OPT") { t = "5"; }
						  //    if (treeView1.Nodes[i].Nodes[j].Nodes[q].Text.Substring(0, treeView1.Nodes[i].Nodes[j].Nodes[q].Text.Length - 1) == "DOMS") { t = "6"; }

						  //    TreeNode<NodeData>  newtreeT = new TreeNode<NodeData>(new NodeData(t), "CurrentType");
						  //    TreeNode<NodeData>  newtreeN = new TreeNode<NodeData>(new NodeData(treeView1.Nodes[i].Nodes[j].Nodes[q].Text.Remove(0, treeView1.Nodes[i].Nodes[j].Nodes[q].Text.Length - 1)), "Number");
						  ////}

						  newtree3.Children.AddLast(newtreeN);
						  newtree3.Children.AddLast(newtreeT);
					   }
				    }

				}
			 }
		  }
		  string json = string.Empty;
		  object obj = newtree;
		  json = JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);
		  string text = "\n//CurrentType:\n//POS - 1\n//BOS - 2\n//ТРК - 3\n//Уровнемер - 4\n//OPT - 5\n//DOMS - 6\n";
            if (File.Exists("C:\\SNI\\NamosRus\\CamRules.json"))
            {
                StreamWriter strwtr = new StreamWriter("C:\\SNI\\NamosRus\\CamRules.json");
                strwtr.Write(text + json);
                strwtr.Close();
            }
            else
            {
                if (Form1000.Dir != null)
                {
                    string path = Form1000.Dir.Replace(@"\", @"\\");
                    StreamWriter strwtr = new StreamWriter(path);
                    strwtr.Write(text + json);
                    strwtr.Close();
                }
                else
                {
                    StreamWriter strwtr = new StreamWriter("CamRules.json");
                    strwtr.Write(text + json);
                    strwtr.Close();
                }
            }
		  
	   }
    }
}
