using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using LexemWork.Core;
using EventMapWork;
using System.Reflection;


namespace WindowsFormsITV_Settings.Methods
{
    class EventsToDiction
    {

	   public static void mEventsToDiction(ref Dictionary<int, string> eventdiction)
	   {
		  try
		  {
			 var codeBaseUrl = Assembly.GetExecutingAssembly().CodeBase;
			 var filePathToCodeBase = new Uri(codeBaseUrl).LocalPath;
			 var directoryPath = Path.GetDirectoryName(filePathToCodeBase);

			 StreamReader sr = new StreamReader(directoryPath + @"\EventMap.json");
			 string json = sr.ReadToEnd();
			 TreeNode<EventLexem> tree = JSONWork.JSONHelper.ReadJSON<TreeNode<EventLexem>>(json) as TreeNode<EventLexem>;

			 string[] arr = new string[tree.ChildrenCount];
			 for (int q = 0; q < tree.ChildrenCount; q++)
			 {
				arr[q] = tree.GetChild(q).Name;
			 }
			 for (int u = 0; u < arr.Length; u++)
			 {
				eventdiction.Add(Convert.ToInt32(arr[u]), "Событие " + arr[u] + " - " + GetInfo(arr[u]));
				
			 }

			 sr.Close();
		  }

#region BackUpEventMap
		  catch 
		  {
			 //StreamReader sr = new StreamReader("WindowsFormsITV_Settings\\Resources\\EventMap.resx");
			 //string json = sr.ReadToEnd();
			 //TreeNode<EventLexem> tree = JSONWork.JSONHelper.ReadJSON<TreeNode<EventLexem>>(json) as TreeNode<EventLexem>;

			 //string[] arr = new string[tree.ChildrenCount];
			 //for (int q = 0; q < tree.ChildrenCount; q++)
			 //{
			 //    arr[q] = tree.GetChild(q).Name;
			 //}
			 //for (int u = 0; u < arr.Length; u++)
			 //{
			 //    eventdiction.Add(Convert.ToInt32(arr[u]), "Событие " + arr[u] + " " + GetInfo(arr[u]));
			 //}

			 //sr.Close();
		  }
#endregion
	   }
	   public static string GetInfo(string t)
	   {
		  var codeBaseUrl = Assembly.GetExecutingAssembly().CodeBase;
		  var filePathToCodeBase = new Uri(codeBaseUrl).LocalPath;
		  var directoryPath = Path.GetDirectoryName(filePathToCodeBase);

		  StreamReader sr = new StreamReader(directoryPath + @"\EventMap.json");
		  string json = sr.ReadToEnd();
		  TreeNode<EventLexem> tree = JSONWork.JSONHelper.ReadJSON<TreeNode<EventLexem>>(json) as TreeNode<EventLexem>;
		  var tree_event = tree.GetChildByName(t);
		  string s = tree_event.Data.Caption;
		  sr.Close();
		  return s;
	   }
    }
}
