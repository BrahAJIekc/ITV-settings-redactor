using System;

namespace WindowsFormsITV_Settings.Events
{
    public static class DeleteAllCams
    {
	   public static void удалитьКамерыToolStripMenuItem_Click(object sender, EventArgs e)
	   {
		  Form1000.tn = WindowsFormsITV_Settings.Methods.CopyTree.mCopyTree(Form1000.treeView1);

		  Form1000.treeView1.Nodes[0].Nodes.Clear();
		  //WindowsFormsITV_Settings.Methods.ClearingAndFilling.mClearingAndFilling();
            WindowsFormsITV_Settings.Methods.DevRulesSettings.mDevRulesSettings();
            WindowsFormsITV_Settings.Methods.ClearingAndFilling.mClearingAndFilling();
            Form1000.treeView2.Nodes.Clear();
            WindowsFormsITV_Settings.Methods.EventList.mEventList(ref Form1000.treeView2);
            WindowsFormsITV_Settings.Methods.DevicesIn.mDevicesIn(ref Form1000.treeView2, ref Form1000.devjson);
            WindowsFormsITV_Settings.Methods.BindDictionaryFromDevRules.mBindDictionaryFromDevRules(ref Form1000.treeView1, ref Form1000.devjson, ref Form1000.eventdiction);

            Form1000.labelToolStripMenuItem.Text = "Данные не сохранены";
	   }
    }
}
