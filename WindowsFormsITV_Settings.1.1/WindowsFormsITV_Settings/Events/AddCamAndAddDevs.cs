using System;
using System.Windows.Forms;

namespace WindowsFormsITV_Settings.Events
{
    public static class AddCamAndAddDevs
    {
	   public static  void button1_Click(object sender, EventArgs e)
	   {

		  ContextMenu mnuContextMenu = new ContextMenu();



		  mnuContextMenu.MenuItems.Clear();


		  string t1 = "POS" + Form1000.numericUpDown1.Value;
		  string t2 = "BOS" + Form1000.numericUpDown1.Value;
		  string t3 = "ТРК" + Form1000.numericUpDown1.Value;
		  string t4 = "Уровнемер" + Form1000.numericUpDown1.Value;
		  string t5 = "OPT" + Form1000.numericUpDown1.Value;
		  string t6 = "DOMS" + Form1000.numericUpDown1.Value;

		  mnuContextMenu.MenuItems.Add(t1, new EventHandler(menuItem1_Click));
		  mnuContextMenu.MenuItems.Add(t2, new EventHandler(menuItem2_Click));
		  mnuContextMenu.MenuItems.Add(t3, new EventHandler(menuItem3_Click));
		  mnuContextMenu.MenuItems.Add(t4, new EventHandler(menuItem4_Click));
		  mnuContextMenu.MenuItems.Add(t5, new EventHandler(menuItem5_Click));
		  mnuContextMenu.MenuItems.Add(t6, new EventHandler(menuItem6_Click));

		  mnuContextMenu.Show(Form1000.button1, new System.Drawing.Point(Form1000.button1.Width / 2 - 80, 5));



	   }
	   public static void button2_Click(object sender, EventArgs e)
	   {
		  if (ExistNode("Камера" + Form1000.numericUpDown2.Value) == false)
	   {
		  Form1000.treeView1.Nodes[0].Nodes.Add("Камера"+ Form1000.numericUpDown2.Value);
	   }
		  Form1000.labelToolStripMenuItem.Text = "Данные не сохранены";
	  

	   }

	   static bool ExistNode(string cam) 
	   {
		  int count = 0;
		  for (int i = 0; i < Form1000.treeView1.Nodes[0].Nodes.Count; i++)
		  {
			 if (Form1000.treeView1.Nodes[0].Nodes[i].Text == cam) { count++; }
		  }

		  if (count > 0) { return true; }
		  else return false;
	   }
	   static int Position()
	   {
		  int temp = 0;
		  for (int i = 0; i < Form1000.treeView1.Nodes[0].Nodes.Count; i++)
			{
                if (Form1000.treeView1.Nodes[0].Nodes[i].Text == "Камера" + Form1000.numericUpDown2.Value)
                {
                    temp = i;
                    break;
                }
                else { temp = 666; }
               
			}
 		   return temp;
	   }
        static bool NodeExist(int position,string device)
        {
            int count = 0;
            for (int i = 0; i < Form1000.treeView1.Nodes[0].Nodes[position].Nodes.Count; i++)
            {
                if (Form1000.treeView1.Nodes[0].Nodes[position].Nodes[i].Text == device) { count++; break; }
            }
            if (count > 0) { return true; }
            else return false;
        }
	   public static void menuItem1_Click(object sender, System.EventArgs e)
	   {
		  Form1000.b = "POS";
		  Form1000.x = Form1000.b + Form1000.numericUpDown1.Value;
		  Form1000.y = Convert.ToInt32(Form1000.numericUpDown2.Value) - 1;
            try
            {
                if (Form1000.x != null & Position() != 666 & NodeExist(Position(), Form1000.x) == false)
                {
                        Form1000.treeView1.Nodes[0].Nodes[Position()].Nodes.Add(Form1000.x);
                        if (Form1000.treeView1.Nodes[0].Nodes[Position()].IsExpanded == false)
                        {
                            Form1000.treeView1.Nodes[0].Nodes[Position()].Toggle();
                        }
                    
                }
            }
            catch { goto Line; }

	   Line:


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


		  WindowsFormsITV_Settings.Methods.BindDictionaryFromDevRules.mBindDictionaryFromDevRules(ref Form1000.treeView1, ref Form1000.devjson, ref Form1000.eventdiction);
		  Form1000.treeView2.CheckBoxes = true;
		  Form1000.treeView1.CheckBoxes = true;
		  WindowsFormsITV_Settings.Methods.CheckedNodes.mCheckedNodes(ref Form1000.treeView1);
		  Form1000.labelToolStripMenuItem.Text = "Данные не сохранены";


	   }
	   public static void menuItem2_Click(object sender, System.EventArgs e)
	   {

		  Form1000.b = "BOS";
		  Form1000.x = Form1000.b + Form1000.numericUpDown1.Value;
		  Form1000.y = Convert.ToInt32(Form1000.numericUpDown2.Value) - 1;

		  try
		  {
			 if (Form1000.x != null & Position() != 666 & NodeExist(Position(), Form1000.x) == false)
			 {
				Form1000.treeView1.Nodes[0].Nodes[Position()].Nodes.Add(Form1000.x);
				if (Form1000.treeView1.Nodes[0].Nodes[Position()].IsExpanded == false)
				{
				    Form1000.treeView1.Nodes[0].Nodes[Position()].Toggle();
				}
			 }
		  }
		  catch { goto Line; }

	   Line:


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

		  WindowsFormsITV_Settings.Methods.BindDictionaryFromDevRules.mBindDictionaryFromDevRules(ref Form1000.treeView1, ref Form1000.devjson, ref Form1000.eventdiction);
		  Form1000.treeView2.CheckBoxes = true;
		  Form1000.treeView1.CheckBoxes = true;
		  WindowsFormsITV_Settings.Methods.CheckedNodes.mCheckedNodes(ref Form1000.treeView1);

		  Form1000.labelToolStripMenuItem.Text = "Данные не сохранены";


	   }
	   public static void menuItem4_Click(object sender, EventArgs e)
	   {
		  Form1000.b = "Уровнемер";
		  Form1000.x = Form1000.b + Form1000.numericUpDown1.Value;
		  Form1000.y = Convert.ToInt32(Form1000.numericUpDown2.Value) - 1;

		  try
		  {
			 if (Form1000.x != null & Position() != 666 & NodeExist(Position(), Form1000.x) == false)
			 {
				Form1000.treeView1.Nodes[0].Nodes[Position()].Nodes.Add(Form1000.x);
				if (Form1000.treeView1.Nodes[0].Nodes[Position()].IsExpanded == false)
				{
				    Form1000.treeView1.Nodes[0].Nodes[Position()].Toggle();
				}
			 }
		  }
		  catch { goto Line; }

	   Line:


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

		  WindowsFormsITV_Settings.Methods.BindDictionaryFromDevRules.mBindDictionaryFromDevRules(ref Form1000.treeView1, ref Form1000.devjson, ref Form1000.eventdiction);
		  Form1000.treeView2.CheckBoxes = true;
		  Form1000.treeView1.CheckBoxes = true;
		  WindowsFormsITV_Settings.Methods.CheckedNodes.mCheckedNodes(ref Form1000.treeView1);

		  Form1000.labelToolStripMenuItem.Text = "Данные не сохранены";


	   }

	   public static void menuItem3_Click(object sender, EventArgs e)
	   {
		  Form1000.b = "ТРК";
		  Form1000.x = Form1000.b + Form1000.numericUpDown1.Value;
		  Form1000.y = Convert.ToInt32(Form1000.numericUpDown2.Value) - 1;

		  try
		  {
			 if (Form1000.x != null & Position() != 666 & NodeExist(Position(), Form1000.x) == false)
			 {
				Form1000.treeView1.Nodes[0].Nodes[Position()].Nodes.Add(Form1000.x);
				if (Form1000.treeView1.Nodes[0].Nodes[Position()].IsExpanded == false)
				{
				    Form1000.treeView1.Nodes[0].Nodes[Position()].Toggle();
				}
			 }
		  }
		  catch { goto Line; }

	   Line:


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


		  WindowsFormsITV_Settings.Methods.BindDictionaryFromDevRules.mBindDictionaryFromDevRules(ref Form1000.treeView1, ref Form1000.devjson, ref Form1000.eventdiction);
		  Form1000.treeView2.CheckBoxes = true;
		  Form1000.treeView1.CheckBoxes = true;
		  WindowsFormsITV_Settings.Methods.CheckedNodes.mCheckedNodes(ref Form1000.treeView1);

		  Form1000.labelToolStripMenuItem.Text = "Данные не сохранены";


	   }
	   public static void menuItem6_Click(object sender, EventArgs e)
	   {
		  Form1000.b = "DOMS";
		  Form1000.x = Form1000.b + Form1000.numericUpDown1.Value;
		  Form1000.y = Convert.ToInt32(Form1000.numericUpDown2.Value) - 1;

		  try
		  {
			 if (Form1000.x != null & Position() != 666 & NodeExist(Position(), Form1000.x) == false)
			 {
				Form1000.treeView1.Nodes[0].Nodes[Position()].Nodes.Add(Form1000.x);
				if (Form1000.treeView1.Nodes[0].Nodes[Position()].IsExpanded == false)
				{
				    Form1000.treeView1.Nodes[0].Nodes[Position()].Toggle();
				}
			 }
		  }
		  catch { goto Line; }

	   Line:


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


		  WindowsFormsITV_Settings.Methods.BindDictionaryFromDevRules.mBindDictionaryFromDevRules(ref Form1000.treeView1, ref Form1000.devjson, ref Form1000.eventdiction);
		  Form1000.treeView2.CheckBoxes = true;
		  Form1000.treeView1.CheckBoxes = true;
		  WindowsFormsITV_Settings.Methods.CheckedNodes.mCheckedNodes(ref Form1000.treeView1);

		  Form1000.labelToolStripMenuItem.Text = "Данные не сохранены";


	   }

	   public static void menuItem5_Click(object sender, EventArgs e)
	   {
		  Form1000.b = "OPT";
		  Form1000.x = Form1000.b + Form1000.numericUpDown1.Value;
		  Form1000.y = Convert.ToInt32(Form1000.numericUpDown2.Value) - 1;

		  try
		  {
			 if (Form1000.x != null & Position() != 666 & NodeExist(Position(), Form1000.x) == false)
			 {
				Form1000.treeView1.Nodes[0].Nodes[Position()].Nodes.Add(Form1000.x);
				if (Form1000.treeView1.Nodes[0].Nodes[Position()].IsExpanded == false)
				{
				    Form1000.treeView1.Nodes[0].Nodes[Position()].Toggle();
				}
			 }
		  }
		  catch { goto Line; }

	   Line:


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

		  WindowsFormsITV_Settings.Methods.BindDictionaryFromDevRules.mBindDictionaryFromDevRules(ref Form1000.treeView1, ref Form1000.devjson, ref Form1000.eventdiction);
		  Form1000.treeView2.CheckBoxes = true;
		  Form1000.treeView1.CheckBoxes = true;
		  WindowsFormsITV_Settings.Methods.CheckedNodes.mCheckedNodes(ref Form1000.treeView1);

		  Form1000.labelToolStripMenuItem.Text = "Данные не сохранены";


	   }
    }
}
