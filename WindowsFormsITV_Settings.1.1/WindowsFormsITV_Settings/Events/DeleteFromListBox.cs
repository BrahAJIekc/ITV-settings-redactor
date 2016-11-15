using System;


namespace WindowsFormsITV_Settings.Events
{
    public static class DeleteFromListBox
    {
	   public static void button3_Click(object sender, EventArgs e)
	   {
		  if (Form1000.listBox1.Items.Count != 0)
		  {
			 WindowsFormsITV_Settings.Methods.DeleteNodesFromListBox.mDeleteNodesFromListBox(ref Form1000.treeView1, ref Form1000.listBox1);
			 Form1000.listBox1.Items.Clear();



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

			 //EventsBindings();
			 WindowsFormsITV_Settings.Methods.BindDictionaryFromDevRules.mBindDictionaryFromDevRules(ref Form1000.treeView1, ref Form1000.devjson, ref Form1000.eventdiction);
			 Form1000.treeView2.CheckBoxes = true;
			 Form1000.treeView1.CheckBoxes = true;
			 WindowsFormsITV_Settings.Methods.CheckedNodes.mCheckedNodes(ref Form1000.treeView1);
			 Form1000.labelToolStripMenuItem.Text = "Данные не сохранены";
		  }
		  //label1.Text = "Данные не сохранены";
	   }
    }
}
