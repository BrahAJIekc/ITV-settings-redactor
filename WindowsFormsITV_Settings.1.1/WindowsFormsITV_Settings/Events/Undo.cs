using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsITV_Settings.Events
{
    class Undo
    {
	   public static void Undo_Click(object sender, EventArgs e)
	   {
		  //if (Form1000.devjsonBackUp != null)
		  //{
		  //    int count = Form1000.devjsonBackUp.Count;
		  //    foreach (var item in Form1000.devjsonBackUp)
		  //    {
		  //	   if (item.GetEnumerator().Current == count)
		  //	   {
		  //		  Form1000.devjson = item;
		  //		  Form1000.devjsonBackUp.Remove(item);
		  //	   }
		  //    }
		  //}
		 
		  Form1000.treeView1.Nodes.Clear();

		  Form1000.treeView1.Nodes.Add(Form1000.tn);

		 // WindowsFormsITV_Settings.Methods.SetToggles.mSetToggles(ref Form1000.treeView1);
		  Form1000.treeView1.Nodes[0].Toggle();
		  for (int i = 0; i < Form1000.treeView1.Nodes[0].Nodes.Count; i++)
		  {
			 Form1000.treeView1.Nodes[0].Nodes[i].Toggle();
		  }


		  Form1000.treeView2.Nodes.Clear();

		  //Form1000.treeView2.Nodes.Add(Form1000.tn2);
		  foreach (var item in Form1000.tn2)
		  {
			  Form1000.treeView2.Nodes.Add(item);
		  }
		  



		  Form1000.labelToolStripMenuItem.Text = "Данные не сохранены";

	   }
    }
}
