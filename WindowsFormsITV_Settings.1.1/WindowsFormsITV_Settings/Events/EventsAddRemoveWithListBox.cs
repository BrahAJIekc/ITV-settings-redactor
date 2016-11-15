using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsITV_Settings.Events
{
    public static class EventsAddRemoveWithListBox
    {
	   public static void button4_Click(object sender, EventArgs e)
	   {

		  //RemoveTypesAndNumbers(Convert.ToString(Regex.Match(treeView2.Nodes[i].Text.Remove(0, 8), @"\S.?\S")));


		  foreach (string item in Form1000.listBox1.Items)
		  {
			 for (int i = 0; i < Form1000.treeView2.Nodes.Count; i++)
			 {
				if (Form1000.treeView2.Nodes[i].Checked == true)
				{
				    WindowsFormsITV_Settings.Methods.XClick.mxClick(Convert.ToString(Regex.Match(Form1000.treeView2.Nodes[i].Text.Remove(0, 8), @"\S.?\S")), item);

				}
			 }
		  }
		  for (int i = 0; i < Form1000.treeView2.Nodes.Count; i++)
		  {
			 Form1000.treeView2.Nodes[i].Checked = false;
		  }

		  WindowsFormsITV_Settings.Methods.ClearingAndFilling.mClearingAndFilling();
		  WindowsFormsITV_Settings.Methods.UncheckingItem.mUncheckingItem();

		  //for (int g = 0; g < treeView1.Nodes[0].Nodes.Count; g++)
		  //{
		  //    for (int j = 0; j < treeView1.Nodes[0].Nodes[g].Nodes.Count; j++)
		  //    {
		  //	   for (int k = 0; k < treeView1.Nodes[0].Nodes[g].Nodes[j].Nodes.Count; k++)
		  //	   { 
		  //		  MessageBox.Show(treeView1.Nodes[0].Nodes[g].Nodes[j].Text);
		  //		  treeView1.Nodes[0].Nodes[g].Nodes[j].Nodes.Clear();
		  //		  treeView1.Nodes[0].Nodes[g].Nodes[j].Checked = false;
		  //	   }
		  //    }
		  //}

		  if (Form1000.выделитьВсеToolStripMenuItem.Text == "Отмена")
		  {
			 Form1000.выделитьВсеToolStripMenuItem.Text = "Выделить все события";
		  }

		  // BindDictionaryFromDevRules();
		  //treeView2.CheckBoxes = true;
		  //treeView1.CheckBoxes = true;
		  //CheckedNodes();

		  // labelToolStripMenuItem.Text = "Данные не сохранены";
		  //label1.Text = "Данные не сохранены";
		  //EventsBindings();
		  Form1000.listBox1.Items.Clear();
		  Form1000.treeView2.Nodes.Clear();
		  WindowsFormsITV_Settings.Methods.EventList.mEventList(ref Form1000.treeView2);
		  WindowsFormsITV_Settings.Methods.DevicesIn.mDevicesIn(ref Form1000.treeView2, ref Form1000.devjson);
		  //BindDictionaryFromDevRules();
		  //treeView2.CheckBoxes = true;
		  //treeView1.CheckBoxes = true;
		  //CheckedNodes();


		  //CamRulesEdit();
		  //RewriteConfig();
		  //RewriteDevRules();
		  //CheckedNodes();
		  Form1000.labelToolStripMenuItem.Text = "Данные не сохранены";
		  ////label1.Text = "Данные сохранены ";

	   }
	   public static void button7_Click(object sender, EventArgs e)
	   {
		  Form1000.tn = WindowsFormsITV_Settings.Methods.CopyTree.mCopyTree(Form1000.treeView1);


		  foreach (string item in Form1000.listBox1.Items)
		  {
			 for (int i = 0; i < Form1000.treeView2.Nodes.Count; i++)
			 {
				if (Form1000.treeView2.Nodes[i].Checked == true)
				{
				    WindowsFormsITV_Settings.Methods.PlusClick.mPlusClick(Convert.ToString(Regex.Match(Form1000.treeView2.Nodes[i].Text.Remove(0, 8), @"\S.?\S")), item);
				}
			 }
		  }
		  for (int i = 0; i < Form1000.treeView2.Nodes.Count; i++)
		  {
			 Form1000.treeView2.Nodes[i].Checked = false;
		  }






		  //for (int g = 0; g < treeView1.Nodes[0].Nodes.Count; g++)
		  //{
		  //    for (int j = 0; j < treeView1.Nodes[0].Nodes[g].Nodes.Count; j++)
		  //    {
		  //	   for (int k = 0; k < treeView1.Nodes[0].Nodes[g].Nodes[j].Nodes.Count; k++)
		  //	   {
		  //		  treeView1.Nodes[0].Nodes[g].Nodes[j].Nodes.Clear();
		  //	   }
		  //    }
		  //}
		  WindowsFormsITV_Settings.Methods.ClearingAndFilling.mClearingAndFilling();
		  WindowsFormsITV_Settings.Methods.UncheckingItem.mUncheckingItem();

		  if (Form1000.выделитьВсеToolStripMenuItem.Text == "        Отмена       ")
		  {
			 Form1000.выделитьВсеToolStripMenuItem.Text = "Выделить все события";
		  }

		  Form1000.labelToolStripMenuItem.Text = "Данные не сохранены";
		  //label1.Text = "Данные не сохранены";
		  //EventsBindings();
		  Form1000.listBox1.Items.Clear();
		  Form1000.treeView2.Nodes.Clear();
		  WindowsFormsITV_Settings.Methods.EventList.mEventList(ref Form1000.treeView2);
		  WindowsFormsITV_Settings.Methods.DevicesIn.mDevicesIn(ref Form1000.treeView2, ref Form1000.devjson);
		  //treeView2.CheckBoxes = true;
		  //treeView1.CheckBoxes = true;
		  //CheckedNodes();



	   }
    }
}
