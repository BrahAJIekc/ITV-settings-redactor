using System.Windows.Forms;
using System.IO;
using LexemWork.Core;
using EventMapWork;

namespace WindowsFormsITV_Settings.Methods
{
    public static class EventList
    {
	   public static void mEventList(ref TreeView treeView2)
	   {
		  StreamReader sr = new StreamReader("EventMap.json");
		  string json = sr.ReadToEnd();
		  TreeNode<EventLexem> tree = JSONWork.JSONHelper.ReadJSON<TreeNode<EventLexem>>(json) as TreeNode<EventLexem>;
		  string[] arr = new string[tree.ChildrenCount];
		  for (int q = 0; q < tree.ChildrenCount; q++)
		  {
			 arr[q] = tree.GetChild(q).Name;
		  }
		  for (int u = 0; u < arr.Length; u++)
		  {
			 treeView2.Nodes.Add("Событие " + arr[u] + " - " + WindowsFormsITV_Settings.Methods.EventsToDiction.GetInfo(arr[u]));
		  }
	   }
    }
}
