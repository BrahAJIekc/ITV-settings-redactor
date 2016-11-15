using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsITV_Settings.Events
{
    class Hide 
    {
	   public static void treeView1_DrawNode(object sender, DrawTreeNodeEventArgs e)
	   {
		  if (e.Node.Level == 0 || e.Node.Level == 3 || e.Node.Level == 1)
			 WindowsFormsITV_Settings.Methods.HideCheckboxes.HideCheckBox(Form1000.treeView1, e.Node);
		  e.DrawDefault = true;
		  
		  
	   }

	   public static void treeView2_DrawNode(object sender, DrawTreeNodeEventArgs e)
	   {
		  if (e.Node.Level == 1)
			 WindowsFormsITV_Settings.Methods.HideCheckboxes.HideCheckBox(Form1000.treeView2, e.Node);
		  e.DrawDefault = true;


	   } 
    }
}
