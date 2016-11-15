using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsITV_Settings.Events
{
    public static class Add2andDel2
    {
	   public static void button6_Click(object sender, EventArgs e)
	   {
		  WindowsFormsITV_Settings.Methods.AddContextMenues.mAddContextMenues(Form1000.button6);
		 
		  for (int i = 0; i < Form1000.treeView2.Nodes.Count; i++)
		  {
			 if (Form1000.treeView2.Nodes[i].Checked == true)
			 {
				WindowsFormsITV_Settings.Methods.AddTypesAndNumbers.mAddTypesAndNumbers(Convert.ToString(Regex.Match(Form1000.treeView2.Nodes[i].Text.Remove(0, 8), @"\S.?\S")));
				Form1000.treeView2.Nodes[i].Checked = false;
			 }
		  }

		  for (int g = 0; g < Form1000.treeView1.Nodes[0].Nodes.Count; g++)
		  {
			 for (int j = 0; j < Form1000.treeView1.Nodes[0].Nodes[g].Nodes.Count; j++)
			 {
				for (int k = 0; k < Form1000.treeView1.Nodes[0].Nodes[g].Nodes[j].Nodes.Count; k++)
				{
				    Form1000.treeView1.Nodes[0].Nodes[g].Nodes[j].Nodes.Clear();
				}
			 }
		  }

		  if (Form1000.выделитьВсеToolStripMenuItem.Text == "Отмена")
		  {
			 Form1000.выделитьВсеToolStripMenuItem.Text = "Выделить все события";
		  }
		  Form1000.labelToolStripMenuItem.Text = "Данные не сохранены";
		  //label1.Text = "Данные не сохранены";
		  //EventsBindings();
		  Form1000.treeView2.Nodes.Clear();
		  WindowsFormsITV_Settings.Methods.EventList.mEventList(ref Form1000.treeView2);
		  WindowsFormsITV_Settings.Methods.DevicesIn.mDevicesIn(ref Form1000.treeView2, ref Form1000.devjson);
		  WindowsFormsITV_Settings.Methods.BindDictionaryFromDevRules.mBindDictionaryFromDevRules(ref Form1000.treeView1, ref Form1000.devjson, ref Form1000.eventdiction);
		  Form1000.treeView2.CheckBoxes = true;
		  Form1000.treeView1.CheckBoxes = true;
		  WindowsFormsITV_Settings.Methods.CheckedNodes.mCheckedNodes(ref Form1000.treeView1);
	   }

	   public static  void button5_Click(object sender, EventArgs e)
	   {
		  WindowsFormsITV_Settings.Methods.AddContextMenues.mAddContextMenues(Form1000.button5);

		  for (int i = 0; i < Form1000.treeView2.Nodes.Count; i++)
		  {
			 if (Form1000.treeView2.Nodes[i].Checked == true)
			 {
				WindowsFormsITV_Settings.Methods.RemoveTypesAndNumbers.mRemoveTypesAndNumbers(Convert.ToString(Regex.Match(Form1000.treeView2.Nodes[i].Text.Remove(0, 8), @"\S.?\S")));
				Form1000.treeView2.Nodes[i].Checked = false;
			 }
		  }



		  for (int g = 0; g < Form1000.treeView1.Nodes[0].Nodes.Count; g++)
		  {
			 for (int j = 0; j < Form1000.treeView1.Nodes[0].Nodes[g].Nodes.Count; j++)
			 {
				for (int k = 0; k < Form1000.treeView1.Nodes[0].Nodes[g].Nodes[j].Nodes.Count; k++)
				{
				    Form1000.treeView1.Nodes[0].Nodes[g].Nodes[j].Nodes.Clear();
				}
			 }
		  }
		  if (Form1000.выделитьВсеToolStripMenuItem.Text == "Отмена")
		  {
			 Form1000.выделитьВсеToolStripMenuItem.Text = "Выделить все события";
		  }
		  Form1000.labelToolStripMenuItem.Text = "Данные не сохранены";
		  //label1.Text = "Данные не сохранены";
		  //EventsBindings();

		  Form1000.treeView2.Nodes.Clear();
		  WindowsFormsITV_Settings.Methods.EventList.mEventList(ref Form1000.treeView2);
		  WindowsFormsITV_Settings.Methods.DevicesIn.mDevicesIn(ref Form1000.treeView2, ref Form1000.devjson);
		  WindowsFormsITV_Settings.Methods.BindDictionaryFromDevRules.mBindDictionaryFromDevRules(ref Form1000.treeView1, ref Form1000.devjson, ref Form1000.eventdiction);
		  Form1000.treeView2.CheckBoxes = true;
		  Form1000.treeView1.CheckBoxes = true;
		  WindowsFormsITV_Settings.Methods.CheckedNodes.mCheckedNodes(ref Form1000.treeView1);
	   }
    }
}
