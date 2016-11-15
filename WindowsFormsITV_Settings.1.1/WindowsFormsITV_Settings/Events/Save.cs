using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsITV_Settings.Events
{
    public static class Save
    {
	   public static void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
	   {
		  WindowsFormsITV_Settings.Methods.CamRulesEdit.mCamRulesEdit();
		  WindowsFormsITV_Settings.Methods.RewriteConfig.mRewriteConfig(ref Form1000.treeView1);
		  WindowsFormsITV_Settings.Methods.RewriteDevRules.mRewriteDevRules();
		  Form1000.labelToolStripMenuItem.Text = "Данные сохранены";
		  //label1.Text = "Данные сохранены ";
	   }
    }
}
