using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using LexemWork.Core;
using EventMapWork;
using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;

namespace WindowsFormsITV_Settings.Methods
{
    public static class BindDictionaryFromDevRules
    {
	   public static void mBindDictionaryFromDevRules(ref TreeView treeView1, ref string devjson, ref Dictionary<int, string> eventdiction)
	   {
		  try
		  {
			 //Stopwatch st = new Stopwatch();
			 //st.Start();
			 var codeBaseUrl = Assembly.GetExecutingAssembly().CodeBase;
			 var filePathToCodeBase = new Uri(codeBaseUrl).LocalPath;
			 var directoryPath = Path.GetDirectoryName(filePathToCodeBase);
			 List<string> l = new List<string>();
			 StreamReader srr = new StreamReader(directoryPath + @"\EventMap.json");
			 string jsonn = srr.ReadToEnd();
			 srr.Close();
			 TreeNode<EventLexem> treee = JSONWork.JSONHelper.ReadJSON<TreeNode<EventLexem>>(jsonn) as TreeNode<EventLexem>;
			 object obj;
			 obj = JsonConvert.DeserializeObject(devjson, typeof(object));
			 TreeNode<NodeData> tree = JSONWork.JSONHelper.ReadJSON<TreeNode<NodeData>>(obj.ToString()) as TreeNode<NodeData>;

			 //===============================List of events=========================================\\

			 string[] arr = new string[treee.ChildrenCount];
			 for (int q = 0; q < treee.ChildrenCount; q++)
			 {
				arr[q] = treee.GetChild(q).Name;
			 }
			 for (int u = 0; u < arr.Length; u++)
			 {
				l.Add(arr[u]);
			 }

			 //====================================Connecting events ===================================================\\



			 for (int j = 0; j < treeView1.Nodes[0].Nodes.Count; j++)
				{
				    for (int n = 0; n < treeView1.Nodes[0].Nodes[j].Nodes.Count; n++)
					   {
						  foreach (string item in l )
								{
								    for (int i = 0; i < tree.GetChildByName(item).ChildrenCount; i++)
								    {
									   //MessageBox.Show(tree.GetChildByName(item).GetChild(i).Data.Value);
									   string x = tree.GetChildByName(item).GetChild(i).Name;

									   if (treeView1.Nodes[0].Nodes[j].Nodes[n].ToString().Remove(0, 10) == x && tree.GetChildByName(item).GetChild(i).Data.Value == Convert.ToString(Regex.Replace(treeView1.Nodes[0].Nodes[j].Text, @"[A-Za-z]|[А-Яа-я]|\s", "")))
									   {
										  
										  treeView1.Nodes[0].Nodes[j].Nodes[n].Nodes.Add((eventdiction[Convert.ToInt32(item)]));
									   }
								    }
							     }
					   }
				}

			 

			 //st.Stop();
			 //TimeSpan ts = st.Elapsed;
			 //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
			 //ts.Hours, ts.Minutes, ts.Seconds,
			 //ts.Milliseconds / 10);
			 //MessageBox.Show("RunTime " + elapsedTime);
		
		  }

		  catch { };
	   }
    }
}
