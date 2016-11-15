using LexemWork.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsITV_Settings.Events
{
    public class Refresher : TreeView
    {
	   public delegate void ChangedEventHandler(object sender, EventArgs e);
	   public event ChangedEventHandler changed_node;
	   //protected virtual void OnChanged(EventArgs e)
	   //{
	   //    if (changed_node != null)
	   //	   changed_node(this, e);
	   //}
	   //public  int Add(TreeNode value)
	   //{
	   //    int i = base.Nodes.Add(value);
	   //    OnChanged(EventArgs.Empty);
	   //    return i;
	   //}



	   public static void Changed_Node(object sender, MouseEventArgs e)
	   {
		  if (e.Button == System.Windows.Forms.MouseButtons.Right) 
		  {
			 
			 ContextMenu cm = new ContextMenu();
			 cm.MenuItems.Add("Обновить", new EventHandler(refresh));
			 cm.MenuItems.Add("X", new EventHandler(refresh));

			 cm.Show(Form1000.treeView1, new System.Drawing.Point(e.X, e.Y));
		  }
		  //if (Form1000.treeView1.Nodes[0].Nodes.Count != Form1000.last)
		  //{
			 //WindowsFormsITV_Settings.Methods.ClearingAndFilling.mClearingAndFilling();
		  //}
	   }

	   private static void refresh(object sender, EventArgs e)
	   {
		  //e.Node.Checked = true;
		  Form1000.treeView1.Nodes.Clear();
		  WindowsFormsITV_Settings.Methods.BindTreViewText.mBindTreViewText(ref Form1000.treeView1);//Первичное заполнение тривью1 из триконфиг
		  WindowsFormsITV_Settings.Methods.GetDeviceName.mGetDeviceName(ref Form1000.treeView1);//Переименование устройств (раньше теги)
		  WindowsFormsITV_Settings.Methods.GetCamName.mGetCamName(ref Form1000.treeView1);//Переименование камер(раньше теги)
		  WindowsFormsITV_Settings.Methods.ClearingAndFilling.mClearingAndFilling();
	   }
//static bool t = false;
	   static TreeNode x = null;
	   public static void Delete(object sender, TreeNodeMouseClickEventArgs e)
	   {
		  
		  if (e.Button == System.Windows.Forms.MouseButtons.Right)
		  {
			 ContextMenu cm = new ContextMenu();

			 cm.MenuItems.Add("Удалить", new EventHandler(deleteit));
			 cm.Show(Form1000.treeView1, new System.Drawing.Point(e.X, e.Y));
			 EventHandler handler = deleteit;
			 x = e.Node;
			 //if (e.Node.Level > 0 && handler !=null)
			 //    e.Node.Remove();
		  }
		  //Form1000.treeView1.Nodes.Clear();
		  //WindowsFormsITV_Settings.Methods.BindTreViewText.mBindTreViewText(ref Form1000.treeView1);//Первичное заполнение тривью1 из триконфиг
		  //WindowsFormsITV_Settings.Methods.GetDeviceName.mGetDeviceName(ref Form1000.treeView1);//Переименование устройств (раньше теги)
		  //WindowsFormsITV_Settings.Methods.GetCamName.mGetCamName(ref Form1000.treeView1);//Переименование камер(раньше теги)
		  //WindowsFormsITV_Settings.Methods.ClearingAndFilling.mClearingAndFilling();
	   }
	   private static void deleteit(object sender, EventArgs e)
	   {

		  //t = true;
		 Form1000.tn = WindowsFormsITV_Settings.Methods.CopyTree.mCopyTree(Form1000.treeView1);
		 Form1000.tn2 = WindowsFormsITV_Settings.Methods.CopyTree.mCopyTree2(Form1000.treeView2);
		  //capture();

		  action(ref x);
		 // action(ref x);

		  //}
	   }

	   static void capture()
	   {
		  //TreeNode temp ;
		  //temp = Form1000.treeView1.Nodes[0];
		  Clone clone = new Clone(Form1000.treeView1.Nodes[0]);
		  Clone clone2 = clone.SwallowCopy();
		  
		  Form1000.tn = clone2.Node;
	   }
	   static void action(ref TreeNode x) 
	   {
		  TreeNode tmp  = x;
		  switch (tmp.Level)
		  {
			 case 3:
		  {
			 chengetree(x);

			 for (int i = 0; i < Form1000.treeView2.Nodes.Count; i++)
			 {
				for (int j = 0; j < Form1000.treeView2.Nodes[i].Nodes.Count; j++)
				{
				    if (Form1000.treeView2.Nodes[i].Nodes[j].Text == "  ⇒ " + x.Parent.Text + " " + x.Parent.Parent.Text && Form1000.treeView2.Nodes[i].Nodes[j].Parent.Text == x.Text)
				    { Form1000.treeView2.Nodes[i].Nodes[j].Remove(); }
				}
			 }

			 x.Remove();

			 Form1000.labelToolStripMenuItem.Text = "Данные не сохранены";
			 break;
		  }

		   case 2:
		  {
			 for (int i = 0; i < x.Nodes.Count; i++)
			 {
				chengetree(x.Nodes[i]);
			 }
			 

			 for (int i = 0; i < Form1000.treeView2.Nodes.Count; i++)
			 {
				for (int j = 0; j < Form1000.treeView2.Nodes[i].Nodes.Count; j++)
				{

				    if (Form1000.treeView2.Nodes[i].Nodes[j].Text == "  ⇒ " + x.Text + " " + x.Parent.Text)
				    { Form1000.treeView2.Nodes[i].Nodes[j].Remove(); }
				}
			 }
			 x.Remove();

			 Form1000.labelToolStripMenuItem.Text = "Данные не сохранены";
			 break;
		  }

		  case 1:
		  {
			 for (int i = 0; i < x.Nodes.Count; i++)
			 {
				for (int j = 0; j < x.Nodes[i].Nodes.Count; j++)
				{
				    chengetree(x.Nodes[i].Nodes[j]);
				}
				
			 }

			 for (int i = 0; i < Form1000.treeView2.Nodes.Count; i++)
			 {
				for (int j = 0; j < Form1000.treeView2.Nodes[i].Nodes.Count; j++)
				{
				    for (int k = 0; k < x.Nodes.Count; k++)
				    {
					   if (Form1000.treeView2.Nodes[i].Nodes[j].Text == "  ⇒ " + x.Nodes[k].Text + " " + x.Text)
					   { Form1000.treeView2.Nodes[i].Nodes[j].Remove(); }
				    }

				}
			 }
			 x.Remove();

			 Form1000.labelToolStripMenuItem.Text = "Данные не сохранены";
			 break;
		  }
	   }
		  	   }
	   static void chengetree(TreeNode X)
	   {
		  //Form1000.devjsonBackUp.Add(Form1000.devjson);
		  TreeNode<NodeData> tree = JsonConvert.DeserializeObject(Form1000.devjson, typeof(TreeNode<NodeData>)) as TreeNode<NodeData>;
		  TreeNode<NodeData> SelectedTree = tree.GetChildByName(Regex.Replace(X.Text,@"[A-Za-z]|[А-Яа-я]", "").Substring(1,3));
		  //MessageBox.Show("q"+Regex.Replace(X.Text, @"[A-Za-z]|[А-Яа-я]", "").Substring(1, 3)+"q");
		  //TreeNode<NodeData> newtreeT = new TreeNode<NodeData>(new NodeData(t), "CurrentType");
		  TreeNode<NodeData> Child = new TreeNode<NodeData>(new NodeData(Regex.Replace(X.Parent.Parent.Text,"[A-Za-z]|[А-Яа-я]", "")),X.Parent.Text);
		  //MessageBox.Show("q" + Child.Name + "q");
		  //MessageBox.Show("q" + Child.Data.Value.Substring(0,Child.Data.Value.Length -1) + "q");
		  //MessageBox.Show(SelectedTree.Name);
		  //MessageBox.Show(Child.Data.Value.Remove(0, 1));
		  //MessageBox.Show("q"+Child.Data.Value+ "q");
		  //for (int i = 0; i < SelectedTree.ChildrenCount; i++)
		  //{
		  //    MessageBox.Show("Q"+SelectedTree.GetChild(i).Name+"Q");
		  //    MessageBox.Show("Q" + Child.Name + "Q");
		  //    MessageBox.Show("Q"+SelectedTree.GetChild(i).Data.Value+"Q");
		  //    MessageBox.Show("Q" + Child.Data.Value + "Q"); 
		  //    if (SelectedTree.GetChild(i) == Child) {
		  //	   MessageBox.Show("It has it");
		  //    }
		  //}

		  if(Child.Data.Value == SelectedTree.GetChildByName(Child.Name).Data.Value)
		  {
		  tree.GetChildByName(Regex.Replace(X.Text, @"[A-Za-z]|[А-Яа-я]", "").Substring(1, 3)).RemoveChild(SelectedTree.GetChildByName(Child.Name));
		  }
			 //TreeNode<NodeData> SelectedTree = tree.GetChildByName(Regex.Replace(X.Text, @"[A-Za-z]|[А-Яа-я]", "").Substring(1, 3));
		  //MessageBox.Show(SelectedTree.GetChildByName(Child.Name).Name);
		  string json = string.Empty;
		  object obj = tree;
		  json = JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);
		  Form1000.devjson = json;
	   }

    }
			   class Clone
			  {
				 public readonly TreeNode Node;



				 public Clone(TreeNode node)
				 {
					this.Node = node;
				 }

				 public Clone SwallowCopy() 
				 {
					//TreeNode clone = Node;
					return (Clone) this.MemberwiseClone();
				 }
			  }


}
