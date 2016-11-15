using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using JSONWork;
using LexemWork.Core;
using LexemWork;
using EventMapWork;
using System.Xml;
using System.Xml.Linq;
using System.Diagnostics;

namespace WindowsFormsITV_Settings
{
    public partial class Form1000 : Form
    {
	   public Form1000()
	   {
		  InitializeComponent();
		  //Stopwatch st = new Stopwatch();
		  //st.Start();
		  WindowsFormsITV_Settings.Methods.TreeForConfigAndDevRules.mTreeForConfigAndDevRules();//Запись триконфиг и деврулс через камрулс
		  WindowsFormsITV_Settings.Methods.DevRulesVar.mDevRulesVar(ref devjson);//Чтение деврулс и запись в переменную devjson 
		  treeView1.Nodes.Clear();
		  WindowsFormsITV_Settings.Methods.BindTreViewText.mBindTreViewText(ref treeView1);//Первичное заполнение тривью1 из триконфиг
		  WindowsFormsITV_Settings.Methods.EventsToDiction.mEventsToDiction(ref eventdiction);//Составление дикшенари из евентмап 
		  WindowsFormsITV_Settings.Methods.GetDeviceName.mGetDeviceName(ref treeView1);//Переименование устройств (раньше теги)
		  WindowsFormsITV_Settings.Methods.GetCamName.mGetCamName(ref treeView1);//Переименование камер(раньше теги)
		  //EventsBindings();
		  WindowsFormsITV_Settings.Methods.BindDictionaryFromDevRules.mBindDictionaryFromDevRules(ref treeView1, ref  devjson, ref  eventdiction);//Добавление узлов событий к устройствам 
		  WindowsFormsITV_Settings.Methods.SetToggles.mSetToggles(ref treeView1);//Открытие узлов камер
		  WindowsFormsITV_Settings.Methods.EventList.mEventList(ref treeView2);//Заполнение тривью2
		  WindowsFormsITV_Settings.Methods.DevicesIn.mDevicesIn(ref treeView2,ref devjson);//Добавление устройств в тривью2
		  treeView2.CheckBoxes = true;
		  treeView1.CheckBoxes = true;
		  WindowsFormsITV_Settings.Methods.CheckedNodes.mCheckedNodes(ref treeView1);//Галочки на все кроме устройств
		  ContextMenu = new System.Windows.Forms.ContextMenu();
		  //Form1000.treeView1.DrawMode = TreeViewDrawMode.OwnerDrawText;
		  Form1000.treeView1.DrawMode = TreeViewDrawMode.OwnerDrawAll;
		  Form1000.treeView2.DrawMode = TreeViewDrawMode.OwnerDrawAll;
		  //tn = treeView1.Nodes[0];
		  //st.Stop();
		  //TimeSpan ts = st.Elapsed;
		  //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
		  //ts.Hours, ts.Minutes, ts.Seconds,
		  //ts.Milliseconds / 10);
		  //MessageBox.Show("RunTime " + elapsedTime);
		
		  //JsonToXML();
		  //XmlToTreeConfig();

		  //xmlremovingnodes();
		  //GetEvents();
		  //DevRulesSettings();
		 
	   }
          public static string Dir = null;
          public static string devjson = null;
		  public static List<string> devjsonBackUp = null;
		  public static string x = null;
		  public static int y = 0;
		  public static string b = null;
		  public static string type = null, value = null;
		  public static Dictionary<int, string> eventdiction = new Dictionary<int, string> { };
		  public static MenuItem menuItem1 = new MenuItem();
		  public static MenuItem menuItem2 = new MenuItem();
		  public static MenuItem menuItem3 = new MenuItem();
		  public static MenuItem menuItem4 = new MenuItem();
		  public static MenuItem menuItem5 = new MenuItem();
		  public static MenuItem menuItem6 = new MenuItem();
		  public static TreeNode tn = null;
		  public static List<TreeNode> tn2 = null;
		  //public static int last = treeView1.Nodes[0].Nodes.Count;

	   #region Описание событий и методов
	   /* События и методы 
	    * ----------------
	    * События 
	    * По порядку 
	    * Добавить/Удалить устройство (две кнопки)
	    * Добавить/Удалить событие (две кнопки)
	    * Очистка камер и устройств(две кнопки)
	    * Удаление всех камер(одна кнопка)
	    * Добавление/Удаление чекбоксами (две кнопки)
	    * Закрытие окна
	    * Загрузка окна
	    * Изменение значения в нумерикапдаун(во всех)
	    * Добавить/Удалить камеру(две кнопки)
	    * Двойные клики для добавления и удаления камер
	    * refresh - удаление узлов
	    * Сохранение
	    * Выбор всех событий
	    * Растягивание окна (растягивается тривью1)
	    * Клики чекбоксов
	    * undo - отмена удаления (не реализовано)
	    ------------------------------------------------------------------------------------
	        Методы
	    * Добавления контексного меню
	    * Добавление событий
	    * Добавление событий к устройствам в тривью1
	    * Заполнение тревью1 из триконфига.хмл
	    * Перезапись камрулс
	    * Прочекование камер и событий
	    * Очистка и перезаполнение тривью1
	    * Удаление устройств из листбокса
	    * Запись устройств в тривью2
	    * Пустой деврулс
	    * Запись в переменную текста из деврулс
	    * Запись событий и описаний в тривью2
	    * Запись событий с описанием в дикшенари
	    * Переименование камер
	    * Переименование устройств
	    * Добавить события списком
	    * Удалить события 
	    * Перепись триконфиг
	    * Перепись деврулс
	    * Установка раскрытия узлов
	    * Запись деврулс и триконфиг из камрулс
	    * Сброс проверенных чекбоксов
	    * Удаление события списком
	    */


	   #endregion;

	   #region OldCode
	   //==================================Checking first nodes=============================\\
	   
	   //void CheckedNodes()
	   //{
	   //    for (int i = 0; i < treeView1.Nodes.Count; i++)
	   //    {
	   //	   treeView1.Nodes[i].Checked = true;

	   //	   for (int j = 0; j < treeView1.Nodes[i].Nodes.Count; j++)
	   //	   {
	   //		  treeView1.Nodes[i].Nodes[j].Checked = true;

	   //		  for (int c = 0; c < treeView1.Nodes[i].Nodes[j].Nodes.Count; c++)
	   //		  {
	   //			for (int k = 0; k < treeView1.Nodes[i].Nodes[j].Nodes[c].Nodes.Count; k++)
	   //		  {

	   //			 treeView1.Nodes[i].Nodes[j].Nodes[c].Nodes[k].Checked = true;

	   //		  } 
	   //		  }
				
	   //	   }
	   //    }
	   //}

	   //=============================Binding Caption from EventMap.json============================================================\\

	   //string GetInfo(string t)
	   //{
	   //    StreamReader sr = new StreamReader("EventMap.json");
	   //    string json = sr.ReadToEnd();
	   //    TreeNode<EventLexem> tree = JSONWork.JSONHelper.ReadJSON<TreeNode<EventLexem>>(json) as TreeNode<EventLexem>;
	   //    var tree_event = tree.GetChildByName(t);
	   //    string s = tree_event.Data.Caption;
	   //    sr.Close();
	   //    return s;
	   //}

	   //======================================Getting treeview from Config.xml====================\\

	   //private void BindTreViewText()
	   //{
	   //    try
	   //    {
	   //	   XmlDocument xdoc = new XmlDocument();
	   //	   string path = "TreeConfig.xml";//"C:\\work\\Config.xml"; //"C:\\Users\\ALX\\Documents\\Visual Studio 2012\\Projects\\ITVTree\\ITVTree\\bin\\Debug\\Config.xml";
	   //	   xdoc.Load(path);
	   //	   treeView1.Nodes.Clear();
	   //	   treeView1.Nodes.Add(new TreeNode(xdoc.DocumentElement.Name));
	   //	   TreeNode rnode = treeView1.Nodes[0];
	   //	   AddText(xdoc.DocumentElement, rnode);
	   //	   treeView1.ExpandAll();
	   //    }
	   //    catch //(XmlException xe)
	   //    {
	   //	   //MessageBox.Show(xe.Message);
	   //	   StreamWriter sw = new StreamWriter("TreeConfig.xml");
	   //	   sw.Write("<?xml version=\"1.0\" encoding=\"utf-8\" ?>\n<Камеры>\n<Камера1/>\n</Камеры>");
	   //	   sw.Close();

	   //	   XmlDocument xdoc = new XmlDocument();
	   //	   string path = "TreeConfig.xml";//"C:\\work\\Config.xml"; //"C:\\Users\\ALX\\Documents\\Visual Studio 2012\\Projects\\ITVTree\\ITVTree\\bin\\Debug\\Config.xml";
	   //	   xdoc.Load(path);
	   //	   treeView1.Nodes.Clear();
	   //	   treeView1.Nodes.Add(new TreeNode(xdoc.DocumentElement.Name));
	   //	   TreeNode rnode = treeView1.Nodes[0];
	   //	   AddText(xdoc.DocumentElement, rnode);
	   //	   treeView1.ExpandAll();
	   //    }
	   //}
	   //private void AddText(XmlNode xnode, TreeNode tnode)
	   //{
	   //    XmlNode new_x_node;
	   //    TreeNode new_tnode;
	   //    XmlNodeList x_list;
	   //    if (xnode.HasChildNodes)
	   //    {
	   //	   x_list = xnode.ChildNodes;
	   //	   for (int i = 0; i <= x_list.Count - 1; i++)
	   //	   {
	   //		  new_x_node = xnode.ChildNodes[i];
	   //		  tnode.Nodes.Add(new TreeNode(new_x_node.Name));
	   //		  new_tnode = tnode.Nodes[i];
	   //		  AddText(new_x_node, new_tnode);
	   //	   }
	   //    }
	   //    else { tnode.Text = (xnode.OuterXml).Trim(); };
	   //}

	   //==================================Adding event in dictionary===============================================================\\ 

	   //Dictionary<int, string> eventdiction = new Dictionary<int, string> { };
	   //void EventsToDiction()
	   //{

	   //    StreamReader sr = new StreamReader("EventMap.json");
	   //    string json = sr.ReadToEnd();
	   //    TreeNode<EventLexem> tree = JSONWork.JSONHelper.ReadJSON<TreeNode<EventLexem>>(json) as TreeNode<EventLexem>;


	   //    string[] arr = new string[tree.ChildrenCount];
	   //    for (int q = 0; q < tree.ChildrenCount; q++)
	   //    {
	   //	   arr[q] = tree.GetChild(q).Name;
	   //    }
	   //    for (int u = 0; u < arr.Length; u++)
	   //    {
	   //	   eventdiction.Add(Convert.ToInt32(arr[u]), "Событие " + arr[u] + " " + GetInfo(arr[u]));
	   //    }


	   //    sr.Close();
	   //}


	   //=====================================Connecting events to devices===========================================================\\

	   //void EventsBindings()
	   //{
	   //    List<string> l = new List<string>();
	   //    StreamReader srr = new StreamReader("C:\\work\\1234\\WN.Aggregator\\WN.Aggregator\\src\\EventMapWork\\Data\\EventMap.json");
	   //    string jsonn = srr.ReadToEnd();
	   //    srr.Close();
	   //    TreeNode<EventLexem> treee = JSONWork.JSONHelper.ReadJSON<TreeNode<EventLexem>>(jsonn) as TreeNode<EventLexem>;
	   //    StreamReader sr = new StreamReader("C:\\work\\1234\\WN.Aggregator\\WN.Aggregator\\src\\WN.Aggregator\\CamRules.json");
	   //    string json = sr.ReadToEnd();
	   //    sr.Close();
	   //    object obj;
	   //    obj = JsonConvert.DeserializeObject(json, typeof(object));
	   //    TreeNode<Lexem> tree = JSONWork.JSONHelper.ReadJSON<TreeNode<Lexem>>(obj.ToString()) as TreeNode<Lexem>;

	   //    //===============================List of events=========================================\\

	   //    string[] arr = new string[treee.ChildrenCount];
	   //    for (int q = 0; q < treee.ChildrenCount; q++)
	   //    {
	   //	   arr[q] = treee.GetChild(q).Name;
	   //    }
	   //    for (int u = 0; u < arr.Length; u++)
	   //    {
	   //	   l.Add(arr[u]);
	   //    }

	   //    //====================================Connecting events ===================================================\\

	   //    foreach (var item in l)
	   //    {
	   //	   for (int a = 0; a < tree.ChildrenCount; a++)
	   //	   {
	   //		  var tree_cam = tree.GetChild(a);


	   //		  for (int i = 0; i < tree_cam.ChildrenCount; i++)
	   //		  {
	   //			 if (tree_cam.GetChild(i).Name == item)
	   //			 {
	   //				var tree_event = tree_cam.GetChild(i);
	   //				var tree_site = tree_event.GetChildByName("SiteID");
	   //				string x = tree_site.Data.Type;
	   //				string y = tree_site.Data.Value;
	   //				string t = null;
	   //				if (x == "0") { t = "POS"; }
	   //				if (x == "1") { t = "BOS"; }
	   //				if (x == "2") { t = "ТРК"; }
	   //				if (x == "3") { t = "Уровнемер"; }
	   //				if (x == "4") { t = "OPT"; }
	   //				if (x == "5") { t = "DOMS"; }

	   //				int r = Convert.ToInt32(y);
	   //				r++;
	   //				string d = t + r;

	   //				for (int q = 0; q < treeView1.Nodes.Count; q++)
	   //				{
	   //				    for (int j = 0; j < treeView1.Nodes[q].Nodes.Count; j++)
	   //				    {
	   //					   for (int n = 0; n < treeView1.Nodes[q].Nodes[j].Nodes.Count; n++)
	   //					   {
	   //						  if (treeView1.Nodes[q].Nodes[j].Nodes[n].ToString().Remove(0, 10) == d)
	   //							 treeView1.Nodes[q].Nodes[j].Nodes[n].Nodes.Add((eventdiction[Convert.ToInt32(item)]));
	   //					   }
	   //				    }
	   //				}
	   //			 }
	   //		  }
	   //	   }
	   //    }
	   //}

	   //===================================Cutting devices's names=====================================================================================================\\
 
	   //void GetDeviceName()
	   //{
	   //    for (int i = 0; i < treeView1.Nodes.Count; i++)
	   //    {
	   //	   for (int j = 0; j < treeView1.Nodes[i].Nodes.Count; j++)
	   //	   {
	   //		  for (int q = 0; q < treeView1.Nodes[i].Nodes[j].Nodes.Count; q++)
	   //		  {
	   //			 treeView1.Nodes[i].Nodes[j].Nodes[q].Text = treeView1.Nodes[i].Nodes[j].Nodes[q].Text.Remove(0, 1);
	   //			 treeView1.Nodes[i].Nodes[j].Nodes[q].Text = treeView1.Nodes[i].Nodes[j].Nodes[q].Text.Remove(treeView1.Nodes[i].Nodes[j].Nodes[q].Text.Length - 3);
	   //		  }
	   //	   }


	   //    }

	   //}

	   //=======================================================Cutting Cams's names=========================================================\\
	  
	   //void GetCamName()
	   //{

	   //    for (int i = 0; i < treeView1.Nodes.Count; i++)
	   //    {
	   //	   for (int j = 0; j < treeView1.Nodes[i].Nodes.Count; j++)
	   //	   {
	   //		  if (treeView1.Nodes[i].Nodes[j].Nodes.Count == 0)
	   //		  {

	   //			 treeView1.Nodes[i].Nodes[j].Text = treeView1.Nodes[i].Nodes[j].Text.Remove(0, 1);
	   //			 treeView1.Nodes[i].Nodes[j].Text = treeView1.Nodes[i].Nodes[j].Text.Remove(treeView1.Nodes[i].Nodes[j].Text.Length - 3);
	   //		  }
	   //	   }

	   //    }
	   //}

	   //=============================Settings to toggle nodes===================\\

	   //void SetToggles()
	   //{
	   //    for (int i = 0; i < treeView1.Nodes.Count; i++)
	   //    {
	   //	   for (int j = 0; j < treeView1.Nodes[i].Nodes.Count; j++)
	   //	   {
	   //		  for (int q = 0; q < treeView1.Nodes[i].Nodes[j].Nodes.Count; q++)
	   //		  {
	   //			 treeView1.Nodes[i].Nodes[j].Nodes[q].Toggle();
	   //		  }
	   //	   }


	   //    }

	   //}

	   //====================Variables and actions for context menu=====================\\


	   //private void menuItem1_Click(object sender, System.EventArgs e)
	   //{

	   //    b = "POS";

	   //}
	   //private void menuItem2_Click(object sender, System.EventArgs e)
	   //{

	   //    b = "BOS";
	   //}

	   //==================================Rewriting Config.Xml based on treeview=========================================================\\
	   

	   //void RewriteConfig()
	   //{
	   //    string filename = "TreeConfig.xml";//"C:\\work\\Config.xml";
	   //    swww = new StreamWriter(filename, false, System.Text.Encoding.UTF8);
	   //    //Write the header
	   //    swww.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
	   //    //Write our root node
	   //    swww.WriteLine("<" + treeView1.Nodes[0].Text + ">");
	   //    foreach (TreeNode node in treeView1.Nodes)
	   //    {
	   //	   saveNode(node.Nodes);
	   //    }
	   //    //Close the root node
	   //    swww.WriteLine("</" + treeView1.Nodes[0].Text + ">");
	   //    swww.Close();
	   //}
	   //private void saveNode(TreeNodeCollection tnc)
	   //{
	   //    foreach (TreeNode node in tnc)
	   //    {
	   //	   //If we have child nodes, we'll write 
	   //	   //a parent node, then iterrate through
	   //	   //the children
	   //	   if (node.Nodes.Count > 0 & node.Level < 2)
	   //	   {
	   //		  swww.WriteLine("<" + node.Text + ">");
	   //		  saveNode(node.Nodes);
	   //		  swww.WriteLine("</" + node.Text + ">");
	   //	   }
	   //	   else //No child nodes, so we just write the text
	   //		  swww.WriteLine("<" + node.Text + "/>");



	   //    }
	   //}

	   //================================Add cams to list====================================\\
	   
	   //List<string> cams()
	   //{
	   //    List<string> cameras = new List<string>();
	   //    for (int i = 0; i < treeView1.Nodes.Count; i++)
	   //    {
	   //	   for (int t = 0; t < treeView1.Nodes[i].Nodes.Count; t++)
	   //	   {
	   //		  cameras.Add(treeView1.Nodes[0].Nodes[t].Text);
	   //	   }

	   //    }
	   //    return cameras;
	   //}

	   //================================Positions at start for some controls==========================\\

	   //private void Form1000_Load(object sender, EventArgs e)
	   //{
	   //    ContextMenu = new System.Windows.Forms.ContextMenu();
	   //    //button1.Location = new Point(treeView1.Width - 130, treeView1.Height + 20);
	   //    //button2.Location = new Point(treeView1.Width - 130 - 582, treeView1.Height + 20);
	   //    //label2.Location = new Point(numericUpDown2.Location.X - 80, numericUpDown2.Location.Y + 10);
	   //    //label3.Location = new Point(numericUpDown1.Location.X - 120, numericUpDown1.Location.Y + 10);
	   //    ////label1.Location = new Point(button4.Location.X -120, button4.Location.Y+3 );
	   //    //label1.ForeColor = Color.Red;
	   //    labelToolStripMenuItem.Text = null;
	   //}

	   
	   //=================================Buttons's functions for first treeview ====================================================\\
	   
	   //private void button1_Click(object sender, EventArgs e)
	   //{
		  
	   //    ContextMenu mnuContextMenu = new ContextMenu();

	   //    this.ContextMenu = mnuContextMenu;

	   //    MenuItem menuItem1 = new MenuItem();
	   //    MenuItem menuItem2 = new MenuItem();
	   //    MenuItem menuItem3 = new MenuItem();
	   //    MenuItem menuItem4 = new MenuItem();
	   //    MenuItem menuItem5 = new MenuItem();
	   //    MenuItem menuItem6 = new MenuItem();

	   //    menuItem1.Select += new System.EventHandler(this.menuItem1_Click);
	   //    menuItem2.Select += new System.EventHandler(this.menuItem2_Click);
	   //    menuItem3.Select += new System.EventHandler(this.menuItem3_Click);
	   //    menuItem4.Select += new System.EventHandler(this.menuItem4_Click);
	   //    menuItem5.Select += new System.EventHandler(this.menuItem5_Click);
	   //    menuItem6.Select += new System.EventHandler(this.menuItem6_Click);

	   //    mnuContextMenu.MenuItems.Clear();
	   //    // Set the Text property.
	   //    menuItem1.Text = "POS";
	   //    menuItem2.Text = "BOS";
	   //    menuItem3.Text = "ТРК";
	   //    menuItem4.Text = "Уровнемер";
	   //    menuItem5.Text = "OPT";
	   //    menuItem6.Text = "DOMS";

	   //    mnuContextMenu.MenuItems.Add(menuItem1);
	   //    mnuContextMenu.MenuItems.Add(menuItem2);
	   //    mnuContextMenu.MenuItems.Add(menuItem3);
	   //    mnuContextMenu.MenuItems.Add(menuItem4);
	   //    mnuContextMenu.MenuItems.Add(menuItem5);
	   //    mnuContextMenu.MenuItems.Add(menuItem6);

	   //    mnuContextMenu.Show(button1, new System.Drawing.Point(-110, 0));
	   //    mnuContextMenu.Dispose();

	   //    x = b + numericUpDown1.Value;
	   //    y = Convert.ToInt32(numericUpDown2.Value) - 1;

	   //    try
	   //    {
	   //	   if (x != null)
	   //	   {
	   //		  treeView1.Nodes[0].Nodes[y].Nodes.Add(x);
	   //		  if (treeView1.Nodes[0].Nodes[y].IsExpanded == false)
	   //		  {
	   //			 treeView1.Nodes[0].Nodes[y].Toggle();
	   //		  }
	   //	   }
	   //    }
	   //    catch { goto Line; }

	   //Line:


	   //    for (int g = 0; g < treeView1.Nodes[0].Nodes.Count; g++)
	   //    {
	   //	   for (int j = 0; j < treeView1.Nodes[0].Nodes[g].Nodes.Count; j++)
	   //	   {
	   //		  for (int k = 0; k < treeView1.Nodes[0].Nodes[g].Nodes[j].Nodes.Count; k++)
	   //		  {
	   //			 treeView1.Nodes[0].Nodes[g].Nodes[j].Nodes.Clear();
	   //		  }
	   //	   }
	   //    }
	   //    //EventsBindings();
	   //    WindowsFormsITV_Settings.Methods.BindDictionaryFromDevRules.mBindDictionaryFromDevRules(ref treeView1, ref devjson, ref eventdiction);
	   //    treeView2.CheckBoxes = true;
	   //    treeView1.CheckBoxes = true;
	   //    WindowsFormsITV_Settings.Methods.CheckedNodes.mCheckedNodes(ref treeView1);
	   //    //CamRulesEdit();
	   //    //RewriteConfig();
	   //    //treeView1.Nodes.Clear();
	   //    //BindTreViewText();
	   //    //GetDeviceName();
	   //    //EventsBindings();
	   //    //GetCamName();
	   //    labelToolStripMenuItem.Text = "Данные не сохранены";
	   //    //label1.Text = "Данные не сохранены";

	   //}

	   //private void menuItem4_Click(object sender, EventArgs e)
	   //{
	   //    b = "Уровнемер";
	   //}

	   //private void menuItem3_Click(object sender, EventArgs e)
	   //{
	   //    b = "ТРК"; 
	   //}

	   //private void button2_Click(object sender, EventArgs e)
	   //{
	   //    WindowsFormsITV_Settings.Methods.DeleteNodesFromListBox.mDeleteNodesFromListBox(ref treeView1,ref listBox1);
	   //    ContextMenu mnuContextMenu = new ContextMenu();
	   //    this.ContextMenu = mnuContextMenu;


	   //    MenuItem menuItem1 = new MenuItem();
	   //    MenuItem menuItem2 = new MenuItem();
	   //    MenuItem menuItem3 = new MenuItem();
	   //    MenuItem menuItem4 = new MenuItem();
	   //    MenuItem menuItem5 = new MenuItem();
	   //    MenuItem menuItem6 = new MenuItem();

	   //    menuItem1.Select += new System.EventHandler(this.menuItem1_Click);
	   //    menuItem2.Select += new System.EventHandler(this.menuItem2_Click);
	   //    menuItem3.Select += new System.EventHandler(this.menuItem3_Click);
	   //    menuItem4.Select += new System.EventHandler(this.menuItem4_Click);
	   //    menuItem5.Select += new System.EventHandler(this.menuItem5_Click);
	   //    menuItem6.Select += new System.EventHandler(this.menuItem6_Click);


	   //    menuItem1.Text = "POS";
	   //    menuItem2.Text = "BOS";
	   //    menuItem3.Text = "ТРК";
	   //    menuItem4.Text = "Уровнемер";
	   //    menuItem5.Text = "OPT";
	   //    menuItem6.Text = "DOMS";

	   //    mnuContextMenu.MenuItems.Add(menuItem1);
	   //    mnuContextMenu.MenuItems.Add(menuItem2);
	   //    mnuContextMenu.MenuItems.Add(menuItem3);
	   //    mnuContextMenu.MenuItems.Add(menuItem4);
	   //    mnuContextMenu.MenuItems.Add(menuItem5);
	   //    mnuContextMenu.MenuItems.Add(menuItem6);

	   //    mnuContextMenu.Show(button2, new System.Drawing.Point(130, 0));
	   //    mnuContextMenu.Dispose();

	   //    x = b + numericUpDown1.Value;
	   //    y = Convert.ToInt32(numericUpDown2.Value) - 1;
	   //    if (x != null)
	   //    {
	   //	   try
	   //	   {
	   //		  for (int i = 0; i < treeView1.Nodes[0].Nodes[y].Nodes.Count; i++)
	   //		  {
	   //			 if (treeView1.Nodes[0].Nodes[y].Nodes[i].Text == x)
	   //			 {
	   //				treeView1.Nodes[0].Nodes[y].Nodes.Remove(treeView1.Nodes[0].Nodes[y].Nodes[i]);
	   //			 }
	   //		  }
	   //	   }
	   //	   catch { goto Line; }

	   //    }
	   //Line:


	   //    for (int g = 0; g < treeView1.Nodes[0].Nodes.Count; g++)
	   //    {
	   //	   for (int j = 0; j < treeView1.Nodes[0].Nodes[g].Nodes.Count; j++)
	   //	   {
	   //		  for (int k = 0; k < treeView1.Nodes[0].Nodes[g].Nodes[j].Nodes.Count; k++)
	   //		  {
	   //			 treeView1.Nodes[0].Nodes[g].Nodes[j].Nodes.Clear();
	   //		  }
	   //	   }
	   //    }

		  
	   //    //EventsBindings();
	   //    WindowsFormsITV_Settings.Methods.BindDictionaryFromDevRules.mBindDictionaryFromDevRules(ref treeView1, ref devjson, ref eventdiction);
	   //    treeView2.CheckBoxes = true;
	   //    treeView1.CheckBoxes = true;
	   //    WindowsFormsITV_Settings.Methods.CheckedNodes.mCheckedNodes(ref treeView1);
	   //    //RewriteConfig();
	   //    //CamRulesEdit();
	   //    //treeView1.Nodes.Clear();
	   //    //BindTreViewText();
	   //    //GetDeviceName();
	   //    //EventsBindings();
	   //    //GetCamName();
	   //    labelToolStripMenuItem.Text = "Данные не сохранены";
	   //    //label1.Text = "Данные не сохранены";

	   //}


	   //=======================================Adaptation for window=======================================================\\
	   
	   //private void treeView1_Resize(object sender, EventArgs e)
	   //{
	   //    Form1000 f = new Form1000();
	   //    button1.Location = new Point(treeView1.Width - 130 + treeView2.Width, treeView1.Height + 20);
	   //    button2.Location = new Point(treeView1.Location.X, treeView1.Height + 20);
	   //    numericUpDown1.Location = new Point(button2.Location.X + label3.Width + button2.Width + 10, treeView1.Height + 20);
	   //    //label1.Location = new Point(numericUpDown1.Location.X, numericUpDown1.Location.Y + 50);
	   //    label3.Location = new Point(numericUpDown1.Location.X - 90, numericUpDown1.Location.Y + 20);
	   //    listBox1.Location = new Point(treeView1.Width + treeView2.Width + 20, treeView1.Location.Y);
	   //    listBox1.Height = treeView1.Height;
	   //    button3.Location = new Point(listBox1.Location.X , listBox1.Height + 20);
	   //    //button4.Location = new Point(numericUpDown2.Location.X - 10, numericUpDown2.Height);
	   //    //label1.Location = new Point(button4.Location.X - 120, button4.Location.Y+5);
	   //    treeView2.Location = new Point(treeView1.Width  + 10, treeView1.Location.Y);
	   //    treeView2.Height = treeView1.Height - button6.Height;
	   //    numericUpDown2.Location = new Point(treeView2.Location.X, treeView1.Height + 20);
	   //    label2.Location = new Point(numericUpDown2.Location.X - 70, numericUpDown2.Location.Y + 20);
	   //    button6.Location = new Point(treeView2.Location.X + treeView2.Width - button6.Width, treeView2.Height+10);
	   //    button5.Location = new Point(treeView2.Location.X , treeView2.Height + 10);
	   //    numericUpDown3.Location = new Point(treeView2.Location.X + treeView2.Width / 2 - 15, treeView2.Height + 13);
	   //    groupBox1.Location = new Point(button1.Location.X - (groupBox1.Width+5), button1.Location.Y-5);

	   //}

	   //===========================================Actions for using NumericsUPDOWNs=====================================================\\
	   
	   //private void numericUpDown1_ValueChanged(object sender, EventArgs e)
	   //{
	   //    button1.Text = " Добавить устройство " + numericUpDown1.Value + " в камеру " + numericUpDown2.Value;
	   //    button2.Text = " Удалить устройство " + numericUpDown1.Value + " из камеры " + numericUpDown2.Value;
	   //}

	   //private void numericUpDown2_ValueChanged(object sender, EventArgs e)
	   //{
	   //    button1.Text = " Добавить устройство " + numericUpDown1.Value + " в камеру " + numericUpDown2.Value;
	   //    button2.Text = " Удалить устройство " + numericUpDown1.Value + " из камеры " + numericUpDown2.Value;
	   //}

	   //======================Editing CamRules.json============\\
	   
	   //void CamRulesEdit()
	   //{
	   //    TreeNode<NodeData> newtree = new TreeNode<NodeData>();
	   //    newtree.Name = "root";


	   //    for (int i = 0; i < treeView1.Nodes.Count; i++)
	   //    {		  
	   //	   for (int j = 0; j < treeView1.Nodes[i].Nodes.Count; j++)
	   //	   {	TreeNode<NodeData> newtree1 = new TreeNode<NodeData>();
	   //				    newtree1.Name = Convert.ToString(j+1);
	   //				    newtree.Children.AddLast(newtree1);
	   //		  for (int q = 0; q < treeView1.Nodes[i].Nodes[j].Nodes.Count; q++)
	   //		  {
	   //			 TreeNode<NodeData> newtree2 = new TreeNode<NodeData>();
	   //			 newtree2.Name = treeView1.Nodes[i].Nodes[j].Nodes[q].Text;



	   //			 for (int w = 0; w < treeView1.Nodes[i].Nodes[j].Nodes[q].Nodes.Count; w++)
	   //			 {
	   //				TreeNode<NodeData> newtree3 = new TreeNode<NodeData>();
	   //				newtree3.Name = treeView1.Nodes[i].Nodes[j].Nodes[q].Nodes[w].Text.Substring(0,11).Remove(0,8);
	   //				newtree1.Children.AddLast(newtree3);
	   //				if (treeView1.Nodes[i].Nodes[j].Nodes[q].Nodes[w].Text != null)
	   //				{
	   //				    string t =null;
	   //				    //TreeNode<NodeData> newtreeT = new TreeNode<NodeData>();
	   //				    //TreeNode<NodeData> newtreeN =  new TreeNode<NodeData>();
	   //				    //if (Regex.IsMatch(treeView1.Nodes[i].Nodes[j].Nodes[q].Text, @"\d{2}"))
	   //				    //{

	   //				    //    if (Regex.Replace(treeView1.Nodes[i].Nodes[j].Nodes[q].Text, @"\d{2}", "") == "POS") { t = "1"; }
	   //				    //    if (Regex.Replace(treeView1.Nodes[i].Nodes[j].Nodes[q].Text, @"\d{2}", "") == "BOS") { t = "2"; }
	   //				    //    if (Regex.Replace(treeView1.Nodes[i].Nodes[j].Nodes[q].Text, @"\d{2}", "") == "ТРК") { t = "3"; }
	   //				    //    if (Regex.Replace(treeView1.Nodes[i].Nodes[j].Nodes[q].Text, @"\d{2}", "") == "Уровнемер") { t = "4"; }
	   //				    //    if (Regex.Replace(treeView1.Nodes[i].Nodes[j].Nodes[q].Text, @"\d{2}", "") == "OPT") { t = "5"; }
	   //				    //    if (Regex.Replace(treeView1.Nodes[i].Nodes[j].Nodes[q].Text, @"\d{2}", "") == "DOMS") { t = "6"; }
	   //				    //    Regex.Replace(treeView1.Nodes[i].Nodes[j].Nodes[q].Text, @"\d{2}", "");
	   //				    //	newtreeT = new TreeNode<NodeData>(new NodeData(t), "CurrentType");
	   //				    //    newtreeN = new TreeNode<NodeData>(new NodeData(Regex.Replace(treeView1.Nodes[i].Nodes[j].Nodes[q].Text, @"\w", "")), "Number");
	   //				    //}

	   //				    //else
	   //				    //{
	   //				    string nodetext = treeView1.Nodes[i].Nodes[j].Nodes[q].Text;
	   //				    if (Regex.Replace(nodetext, @"\d{1}|\d{2}|\d{3}|\d{4}|\d{5}|\d{6}|\d{7}|\d{8}|\d{9}", "") == "POS") { t = "1"; }
	   //				    if (Regex.Replace(nodetext, @"\d{1}|\d{2}|\d{3}|\d{4}|\d{5}|\d{6}|\d{7}|\d{8}|\d{9}", "") == "BOS") { t = "2"; }
	   //				    if (Regex.Replace(nodetext, @"\d{1}|\d{2}|\d{3}|\d{4}|\d{5}|\d{6}|\d{7}|\d{8}|\d{9}", "") == "ТРК") { t = "3"; }
	   //				    if (Regex.Replace(nodetext, @"\d{1}|\d{2}|\d{3}|\d{4}|\d{5}|\d{6}|\d{7}|\d{8}|\d{9}", "") == "Уровнемер") { t = "4"; }
	   //				    if (Regex.Replace(nodetext, @"\d{1}|\d{2}|\d{3}|\d{4}|\d{5}|\d{6}|\d{7}|\d{8}|\d{9}", "") == "OPT") { t = "5"; }
	   //				    if (Regex.Replace(nodetext, @"\d{1}|\d{2}|\d{3}|\d{4}|\d{5}|\d{6}|\d{7}|\d{8}|\d{9}", "") == "DOMS") { t = "6"; }

	   //				    TreeNode<NodeData> newtreeT = new TreeNode<NodeData>(new NodeData(t), "CurrentType");
	   //				    TreeNode<NodeData> newtreeN = new TreeNode<NodeData>(new NodeData(Regex.Replace(nodetext, @"[A-Za-z]|[А-Яа-я]", "")), "Number");

	   //				    //    if (treeView1.Nodes[i].Nodes[j].Nodes[q].Text.Substring(0, treeView1.Nodes[i].Nodes[j].Nodes[q].Text.Length - 1) == "POS") { t = "1"; }
	   //				    //    if (treeView1.Nodes[i].Nodes[j].Nodes[q].Text.Substring(0, treeView1.Nodes[i].Nodes[j].Nodes[q].Text.Length - 1) == "BOS") { t = "2"; }
	   //				    //    if (treeView1.Nodes[i].Nodes[j].Nodes[q].Text.Substring(0, treeView1.Nodes[i].Nodes[j].Nodes[q].Text.Length - 1) == "ТРК") { t = "3"; }
	   //				    //    if (treeView1.Nodes[i].Nodes[j].Nodes[q].Text.Substring(0, treeView1.Nodes[i].Nodes[j].Nodes[q].Text.Length - 1) == "Уровнемер") { t = "4"; }
	   //				    //    if (treeView1.Nodes[i].Nodes[j].Nodes[q].Text.Substring(0, treeView1.Nodes[i].Nodes[j].Nodes[q].Text.Length - 1) == "OPT") { t = "5"; }
	   //				    //    if (treeView1.Nodes[i].Nodes[j].Nodes[q].Text.Substring(0, treeView1.Nodes[i].Nodes[j].Nodes[q].Text.Length - 1) == "DOMS") { t = "6"; }

	   //				    //    TreeNode<NodeData>  newtreeT = new TreeNode<NodeData>(new NodeData(t), "CurrentType");
	   //				    //    TreeNode<NodeData>  newtreeN = new TreeNode<NodeData>(new NodeData(treeView1.Nodes[i].Nodes[j].Nodes[q].Text.Remove(0, treeView1.Nodes[i].Nodes[j].Nodes[q].Text.Length - 1)), "Number");
	   //				    ////}

	   //				    newtree3.Children.AddLast(newtreeN);
	   //				    newtree3.Children.AddLast(newtreeT);
	   //				}
	   //			 }
				    
	   //		  }
	   //	   }
	   //    }
	   //    string json = string.Empty;
	   //    object obj = newtree;
	   //    json = JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);
	   //    string text = "\n//CurrentType:\n//POS - 1\n//BOS - 2\n//ТРК - 3\n//Уровнемер - 4\n//OPT - 5\n//DOMS - 6\n";
	   //    StreamWriter strwtr = new StreamWriter("C:\\SNI\\NamosRus\\CamRules.json");
	   //    strwtr.Write(text + json);
	   //    strwtr.Close();
	   //}

	   //============================Actions for checked nodes====================================\\
	   
	   //private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
	   //{
	   //    if (e.Node.Checked & e.Node.Level == 2)
	   //	   listBox1.Items.Add(e.Node.Text + " " + e.Node.Parent.Text);
	   //    else if (e.Node.Level == 2)
	   //		  listBox1.Items.Remove(e.Node.Text + " " + e.Node.Parent.Text);

	   //}

	   //===========================Deleting nodes from listbox==========================================\\
	   
	   //void DeleteNodesFromListBox()
	   //{

	   //    foreach (string item in listBox1.Items)
	   //    {
	   //	   string nd = Convert.ToString(Regex.Match(item, @"^(.*)\s"));
	   //	   string cam = item.Replace(nd, "");
	   //	   nd = nd.Substring(0, nd.Length-1);
	   //	   //cam = cam.Substring(0, cam.Length - 1);
	   //	   MessageBox.Show(nd);
	   //	   for (int i = 0; i < treeView1.Nodes[0].Nodes.Count; i++)
	   //	   {
	   //		  for (int k = 0; k < treeView1.Nodes[0].Nodes[i].Nodes.Count; k++)
	   //		  {
	   //			 if (nd == treeView1.Nodes[0].Nodes[i].Nodes[k].Text)
	   //			 {
	   //				if (treeView1.Nodes[0].Nodes[i].Text == cam)
	   //				treeView1.Nodes[0].Nodes[i].Nodes.Remove(treeView1.Nodes[0].Nodes[i].Nodes[k]);
	   //			 }
	   //		  }
	   //	   }
	   //    }
	   //}
	
	   //================================Buttons to delete from listbox and saving==============\\
	   
	   //private void button3_Click(object sender, EventArgs e)
	   //{
	   //    if (listBox1.Items.Count != 0)
	   //    {
	   //	   WindowsFormsITV_Settings.Methods.DeleteNodesFromListBox.mDeleteNodesFromListBox(ref treeView1, ref listBox1);
	   //	   listBox1.Items.Clear();



	   //	   for (int g = 0; g < treeView1.Nodes[0].Nodes.Count; g++)
	   //	   {
	   //		  for (int j = 0; j < treeView1.Nodes[0].Nodes[g].Nodes.Count; j++)
	   //		  {
	   //			 for (int k = 0; k < treeView1.Nodes[0].Nodes[g].Nodes[j].Nodes.Count; k++)
	   //			 {
	   //				treeView1.Nodes[0].Nodes[g].Nodes[j].Nodes.Clear();
	   //			 }
	   //		  }
	   //	   }

	   //	   //EventsBindings();
	   //	   WindowsFormsITV_Settings.Methods.BindDictionaryFromDevRules.mBindDictionaryFromDevRules(ref treeView1, ref devjson, ref eventdiction);
	   //	   treeView2.CheckBoxes = true;
	   //	   treeView1.CheckBoxes = true;
	   //	   WindowsFormsITV_Settings.Methods.CheckedNodes.mCheckedNodes(ref treeView1);
	   //	   labelToolStripMenuItem.Text = "Данные не сохранены";
	   //    }
	   //    //label1.Text = "Данные не сохранены";
	   //}


	   //=====================================================Getting events to second treeview=====================================\\
	   
	   //void EventList() 
	   //{
	   //    StreamReader sr = new StreamReader("EventMap.json");
	   //    string json = sr.ReadToEnd();
	   //    TreeNode<EventLexem> tree = JSONWork.JSONHelper.ReadJSON<TreeNode<EventLexem>>(json) as TreeNode<EventLexem>;


	   //    string[] arr = new string[tree.ChildrenCount];
	   //    for (int q = 0; q < tree.ChildrenCount; q++)
	   //    {
	   //	   arr[q] = tree.GetChild(q).Name;
	   //    }
	   //    for (int u = 0; u < arr.Length; u++)
	   //    {
	   //	   treeView2.Nodes.Add("Событие " + arr[u] + " " + WindowsFormsITV_Settings.Methods.EventsToDiction.GetInfo(arr[u]));
	   //    }
			 

	   //}

	   //=====================================================Buttons's fuctions for second treeview================================\\




	   //======================Actions for add button============================\\
	   
	   //private void button6_Click(object sender, EventArgs e)
	   //{
	   //    AddContextMenues(button6);

	   //    for (int i = 0; i < treeView2.Nodes.Count; i++)
	   //    {
	   //	   if (treeView2.Nodes[i].Checked == true)
	   //	   {
	   //		  AddTypesAndNumbers(Convert.ToString(Regex.Match(treeView2.Nodes[i].Text.Remove(0, 8), @"\S.?\S")));
	   //		  treeView2.Nodes[i].Checked = false;
	   //	   }
	   //    }

	   //    for (int g = 0; g < treeView1.Nodes[0].Nodes.Count; g++)
	   //    {
	   //	   for (int j = 0; j < treeView1.Nodes[0].Nodes[g].Nodes.Count; j++)
	   //	   {
	   //		  for (int k = 0; k < treeView1.Nodes[0].Nodes[g].Nodes[j].Nodes.Count; k++)
	   //		  {
	   //			 treeView1.Nodes[0].Nodes[g].Nodes[j].Nodes.Clear();
	   //		  }
	   //	   }
	   //    }

	   //    if (выделитьВсеToolStripMenuItem.Text == "Отмена")
	   //    {
	   //	   выделитьВсеToolStripMenuItem.Text = "Выделить все события";
	   //    }
	   //    labelToolStripMenuItem.Text = "Данные не сохранены";
	   //    //label1.Text = "Данные не сохранены";
	   //    //EventsBindings();
	   //    treeView2.Nodes.Clear();
	   //    WindowsFormsITV_Settings.Methods.EventList.mEventList(ref treeView2);
	   //    WindowsFormsITV_Settings.Methods.DevicesIn.mDevicesIn(ref treeView2, ref devjson);
	   //    WindowsFormsITV_Settings.Methods.BindDictionaryFromDevRules.mBindDictionaryFromDevRules(ref treeView1, ref devjson, ref eventdiction);
	   //    treeView2.CheckBoxes = true;
	   //    treeView1.CheckBoxes = true;
	   //    WindowsFormsITV_Settings.Methods.CheckedNodes.mCheckedNodes(ref treeView1);
	   //}

	   
	   //==========================Appending context menues to buttons===============================\\

	   //void AddContextMenues(Button bt) 
	   //{
	   //    ContextMenu cm = new ContextMenu();
	   //    this.ContextMenu = cm;
	   //    MenuItem menuItem1 = new MenuItem();
	   //    MenuItem menuItem2 = new MenuItem();
	   //    MenuItem menuItem3 = new MenuItem();
	   //    MenuItem menuItem4 = new MenuItem();
	   //    MenuItem menuItem5 = new MenuItem();
	   //    MenuItem menuItem6 = new MenuItem();
	   //    menuItem1.Text = "POS";
	   //    menuItem2.Text = "BOS";
	   //    menuItem3.Text = "ТРК";
	   //    menuItem4.Text = "Уровнемер";
	   //    menuItem5.Text = "OPT";
	   //    menuItem6.Text = "DOMS";

	   //    //menuItem1.Select += new System.EventHandler(this.menuItem1_Click);
	   //    //menuItem2.Select += new System.EventHandler(this.menuItem2_Click);
	   //    //menuItem3.Select += new System.EventHandler(this.menuItem3_Click);
	   //    //menuItem4.Select += new System.EventHandler(this.menuItem4_Click);
	   //    //menuItem5.Select += new System.EventHandler(this.menuItem5_Click);
	   //    //menuItem6.Select += new System.EventHandler(this.menuItem6_Click);

	   //    cm.MenuItems.Add(menuItem1);
	   //    cm.MenuItems.Add(menuItem2);
	   //    cm.MenuItems.Add(menuItem3);
	   //    cm.MenuItems.Add(menuItem4);
	   //    cm.MenuItems.Add(menuItem5);
	   //    cm.MenuItems.Add(menuItem6);
	   //    cm.Show(bt, new System.Drawing.Point(130, 0));
	   //    cm.Dispose();
	   //    cm.MenuItems.Clear();
		  
	   //}

	   //private void menuItem6_Click(object sender, EventArgs e)
	   //{
	   //    b = "DOMS";
	   //}

	   //private void menuItem5_Click(object sender, EventArgs e)
	   //{
	   //    b = "OPT";
	   //}

	   //===============================Getting copy of CamRules.json=====================================\\

	   //string CopyOfCamRules() 
	   //{
	   //    string json = null;

	   //    StreamReader strread = new StreamReader("CamRules.json");
	   //    json = strread.ReadToEnd();
	   //    strread.Close();

	   //    return json;
	   //}

	   //====================================Creating DevRules.json(used once)=======================================\\

	   //void DevRulesSettings() 
	   //{
	   //    TreeNode<NodeData> newtree = new TreeNode<NodeData>();
	   //    newtree.Name = "root";

	   //    //TreeNode<NodeData> newtreeN = new TreeNode<NodeData>("POS");
	   //    //TreeNode<NodeData> newtreeT = new TreeNode<NodeData>("BOS");

	   //    for (int i = 0; i < treeView2.Nodes.Count; i++)
	   //    {
	   //		  TreeNode<NodeData> newtree1 = new TreeNode<NodeData>();
	   //		  newtree1.Name = Convert.ToString(Regex.Match(treeView2.Nodes[i].Text.Remove(0, 8),@"\S.?\S"));
	   //		  newtree.Children.AddLast(newtree1);
	   //		  //newtree1.Children.AddLast(newtreeN);
	   //		  //newtree1.Children.AddLast(newtreeT);

	   //    }
	   //    string json = string.Empty;
	   //    object obj = newtree;
	   //    json = JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);
	   //    devjson = json;
	   //    //StreamWriter strwtr = new StreamWriter("DevRules.json");
	   //    //strwtr.Write(json);
	   //    //strwtr.Close();

	   //}
	   //==================================Changing values in DevRules.json=========================================\\



	   //==============Reading DevRules.json===================\\

											 //void DevRulesVar()
											 //{
											 //    if (File.Exists("DevRules.json"))
											 //    {
											 //	   string json = null;

											 //	   StreamReader strread = new StreamReader("DevRules.json");
											 //	   json = strread.ReadToEnd();
											 //	   strread.Close();
											 //	   devjson = json;
											 //    }
											 //    else
											 //    {
											 //	   StreamReader strread = new StreamReader("emptyDevRules.json");
											 //	   string json = null;
											 //	   json = strread.ReadToEnd();
											 //	   strread.Close();
											 //	   devjson = json;
											 //    }

											 //}



	   //============================================Devices event tree===============================================================\\

	   //void DevicesIn()
	   //{
	   //    try
	   //    {
	   //	   TreeNode<NodeData> tree = JsonConvert.DeserializeObject(devjson, typeof(TreeNode<NodeData>)) as TreeNode<NodeData>;
	   //	   for (int i = 0; i < tree.ChildrenCount; i++)
	   //	   {
	   //		  TreeNode<NodeData> SecondTree = tree.GetChild(i);
	   //		  for (int j = 0; j < SecondTree.ChildrenCount; j++)
	   //		  {
	   //			 TreeNode<NodeData> devtree = SecondTree.GetChild(j);
	   //			 for (int r = 0; r < treeView2.Nodes.Count; r++)
	   //			 {
	   //				if (SecondTree.Name == Convert.ToString(Regex.Match(treeView2.Nodes[r].Text.Remove(0, 8), @"\S.?\S")))
	   //				{
	   //				    treeView2.Nodes[r].Text += " " + "( " + devtree.Name + " )";
	   //				}

	   //			 }
	   //		  }

	   //	   }


	   //    }
	   //    catch { };
	   //}

	   //====================Saving DevRules.json======================\\

	   //void RewriteDevRules() 
	   //{
	   //    StreamWriter strwtr = new StreamWriter("DevRules.json");
	   //    strwtr.Write(devjson);
	   //    strwtr.Close();

	   //}
	   //===================================================================================\\
	   //void AddTypesAndNumbers(string ev)
	   //{
	   //    //string json = null;

	   //    //StreamReader strread = new StreamReader("DevRules.json");
	   //    //json = strread.ReadToEnd();
	   //    //strread.Close();
	   //    try
	   //    {
	   //	   TreeNode<NodeData> tree = JsonConvert.DeserializeObject(devjson, typeof(TreeNode<NodeData>)) as TreeNode<NodeData>;
	   //	   TreeNode<NodeData> SecondTree = tree.GetChildByName(ev);
	   //	   TreeNode<NodeData> dev = new TreeNode<NodeData>(b + numericUpDown3.Value);
	   //	   SecondTree.AddChild(dev);
	   //	   string jsonout = string.Empty;
	   //	   object obj = tree;
	   //	   jsonout = JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);
	   //	   devjson = jsonout;
	   //    }
	   //    catch
	   //    {
	   //	   StreamReader strread = new StreamReader("emptyDevRules.json.txt");
	   //	   string json = null;
	   //	   json = strread.ReadToEnd();
	   //	   strread.Close();
	   //	   devjson = json;
	   //	   TreeNode<NodeData> tree = JsonConvert.DeserializeObject(devjson, typeof(TreeNode<NodeData>)) as TreeNode<NodeData>;
	   //	   TreeNode<NodeData> SecondTree = tree.GetChildByName(ev);
	   //	   TreeNode<NodeData> dev = new TreeNode<NodeData>(b + numericUpDown3.Value);
	   //	   SecondTree.AddChild(dev);
	   //	   string jsonout = string.Empty;
	   //	   object obj = tree;
	   //	   jsonout = JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);
	   //	   devjson = jsonout;

	   //    }
	   //    //TreeNode<NodeData> dev = new TreeNode<NodeData>( b + numericUpDown3.Value);
	   //    //SecondTree.AddChild(dev);
	   //    //string jsonout = string.Empty;
	   //    //object obj = tree;
	   //    //jsonout = JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);
	   //    //devjson = jsonout;
	   //    //StreamWriter strwtr = new StreamWriter("DevRules.json");
	   //    //strwtr.Write(jsonout);
	   //    //strwtr.Close();


	   //}

	   //void RemoveTypesAndNumbers(string ev)
	   //{
	   //    //string json = null;

	   //    //StreamReader strread = new StreamReader("DevRules.json");
	   //    //json = strread.ReadToEnd();
	   //    //strread.Close();

	   //    TreeNode<NodeData> tree = JsonConvert.DeserializeObject(devjson, typeof(TreeNode<NodeData>)) as TreeNode<NodeData>;
	   //    TreeNode<NodeData> SecondTree = tree.GetChildByName(ev);
	   //    //TreeNode<NodeData> dev = new TreeNode<NodeData>(new NodeData(Convert.ToString(numericUpDown3.Value)), b + numericUpDown3.Value);
	   //    //TreeNode<NodeData> dev = new TreeNode<NodeData>( b + numericUpDown3.Value);
	   //    if (SecondTree.GetChildByName(b + numericUpDown3.Value) != null)
	   //    {
	   //	   TreeNode<NodeData> child = SecondTree.GetChildByName(b + numericUpDown3.Value);
	   //	   SecondTree.RemoveChild(child);
	   //	   string jsonout = string.Empty;
	   //	   object obj = tree;
	   //	   jsonout = JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);
	   //	   devjson = jsonout;
	   //	   //StreamWriter strwtr = new StreamWriter("DevRules.json");
	   //	   //strwtr.Write(jsonout);
	   //	   //strwtr.Close();
	   //    }

	   //}

	   //============================Actions for menu items =========================================\\

	   //private void itemBOS_click(object sender, EventArgs e)
	   //{
	   //    type = "BOS";
	   //    value = Convert.ToString(numericUpDown3.Value);
	   //}

	   //private void itemPOS_click(object sender, EventArgs e)
	   //{
	   //    type = "POS";
	   //    value = Convert.ToString(numericUpDown3.Value);
	   //}

	   //=============================Actions for NumericUPDOWN=========================================\\

	   //private void numericUpDown3_ValueChanged(object sender, EventArgs e)
	   //{
	   //    button6.Text = "Добавить в устройство " + numericUpDown3.Value;
	   //    button5.Text = "Удалить из устройства " + numericUpDown3.Value;
	   //}

	   //===================Actions for delete button===========================\\
	   
	   //private void button5_Click(object sender, EventArgs e)
	   //{
	   //    AddContextMenues(button5);

	   //    for (int i = 0; i < treeView2.Nodes.Count; i++)
	   //    {
	   //	   if (treeView2.Nodes[i].Checked == true)
	   //	   {
	   //		  RemoveTypesAndNumbers(Convert.ToString(Regex.Match(treeView2.Nodes[i].Text.Remove(0, 8), @"\S.?\S")));
	   //		  treeView2.Nodes[i].Checked = false;
	   //	   }
	   //    }



	   //    for (int g = 0; g < treeView1.Nodes[0].Nodes.Count; g++)
	   //    {
	   //	   for (int j = 0; j < treeView1.Nodes[0].Nodes[g].Nodes.Count; j++)
	   //	   {
	   //		  for (int k = 0; k < treeView1.Nodes[0].Nodes[g].Nodes[j].Nodes.Count; k++)
	   //		  {
	   //			 treeView1.Nodes[0].Nodes[g].Nodes[j].Nodes.Clear();
	   //		  }
	   //	   }
	   //    }
	   //    if (выделитьВсеToolStripMenuItem.Text == "Отмена")
	   //    {
	   //	   выделитьВсеToolStripMenuItem.Text = "Выделить все события";
	   //    }
	   //    labelToolStripMenuItem.Text = "Данные не сохранены";
	   //    //label1.Text = "Данные не сохранены";
	   //    //EventsBindings();

	   //    treeView2.Nodes.Clear();
	   //    WindowsFormsITV_Settings.Methods.EventList.mEventList(ref treeView2);
	   //    WindowsFormsITV_Settings.Methods.DevicesIn.mDevicesIn(ref treeView2, ref devjson);
	   //    WindowsFormsITV_Settings.Methods.BindDictionaryFromDevRules.mBindDictionaryFromDevRules(ref treeView1, ref devjson, ref eventdiction);
	   //    treeView2.CheckBoxes = true;
	   //    treeView1.CheckBoxes = true;
	   //    WindowsFormsITV_Settings.Methods.CheckedNodes.mCheckedNodes(ref treeView1);
	   //}

	   //======================Binding event's data to devices=====================\\

	   //void BindDictionaryFromDevRules()
	   //{
	   //    try
	   //    {
	   //	   List<string> l = new List<string>();
	   //	   StreamReader srr = new StreamReader("EventMap.json");
	   //	   string jsonn = srr.ReadToEnd();
	   //	   srr.Close();
	   //	   TreeNode<EventLexem> treee = JSONWork.JSONHelper.ReadJSON<TreeNode<EventLexem>>(jsonn) as TreeNode<EventLexem>;
	   //	   //StreamReader sr = new StreamReader("DevRules.json");
	   //	   //string json = sr.ReadToEnd();
	   //	   //sr.Close();
	   //	   object obj;
	   //	   obj = JsonConvert.DeserializeObject(devjson, typeof(object));
	   //	   TreeNode<NodeData> tree = JSONWork.JSONHelper.ReadJSON<TreeNode<NodeData>>(obj.ToString()) as TreeNode<NodeData>;

	   //	   //===============================List of events=========================================\\

	   //	   string[] arr = new string[treee.ChildrenCount];
	   //	   for (int q = 0; q < treee.ChildrenCount; q++)
	   //	   {
	   //		  arr[q] = treee.GetChild(q).Name;
	   //	   }
	   //	   for (int u = 0; u < arr.Length; u++)
	   //	   {
	   //		  l.Add(arr[u]);
	   //	   }
	   //	   //====================================Connecting events ===================================================\\

	   //	   foreach (var item in l)
	   //	   {

	   //		  for (int i = 0; i < tree.ChildrenCount; i++)
	   //		  {
	   //			 if (tree.GetChild(i).Name == item)
	   //			 {
	   //				var tree_event = tree.GetChild(i);

	   //				for (int o = 0; o < tree_event.ChildrenCount; o++)
	   //				{
	   //				    string x = tree_event.GetChild(o).Name;

	   //				    for (int q = 0; q < treeView1.Nodes.Count; q++)
	   //				    {
	   //					   for (int j = 0; j < treeView1.Nodes[q].Nodes.Count; j++)
	   //					   {
	   //						  for (int n = 0; n < treeView1.Nodes[q].Nodes[j].Nodes.Count; n++)
	   //						  {
	   //							 if (treeView1.Nodes[q].Nodes[j].Nodes[n].ToString().Remove(0, 10) == x)
	   //								treeView1.Nodes[q].Nodes[j].Nodes[n].Nodes.Add((eventdiction[Convert.ToInt32(item)]));
	   //						  }
	   //					   }
	   //				    }
	   //				}
	   //			 }
	   //		  }
	   //	   }
	   //    }
	   //    catch { };
	   //}
	   //==================================================Message when window is closing=======================================\\

	   //private void Form1000_FormClosing(object sender, FormClosingEventArgs e)
	   //{
	   //    if (labelToolStripMenuItem.Text == "Данные не сохранены")//label1.Text == "Данные не сохранены")
	   //    {

	   //	   if (MessageBox.Show("Не желаете сохранить изменения ?", "Настройка сервиса ITV",
	   // MessageBoxButtons.YesNo) == DialogResult.Yes)
	   //	   {
	   //		  сохранитьToolStripMenuItem.PerformClick();
	   //		  //button4.PerformClick();
	   //		  // Cancel the Closing event from closing the form.
	   //		  e.Cancel = true;
	   //		  // Call method to save file...
	   //	   }

	   //    }
	   //}

	   //================================Edit bottom menu bar============================================\\ 

	   //private void камераToolStripMenuItem_Click(object sender, EventArgs e)
	   //{
	   //    if (treeView1.Nodes[0].Nodes.Count < 100)
	   //    {
	   //	   if (treeView1.Nodes[0].Nodes.Count > 0)
	   //	   {
	   //		  //string str = treeView1.Nodes[0].Nodes[treeView1.Nodes[0].Nodes.Count - 1].Text.Substring(0, treeView1.Nodes[0].Nodes[treeView1.Nodes[0].Nodes.Count - 1].Text.Length - 1);

	   //		  treeView1.Nodes[0].Nodes.Add("Камера" + Convert.ToString(treeView1.Nodes[0].Nodes.Count + 1));
	   //	   }

	   //	   else { treeView1.Nodes[0].Nodes.Add("Камера1"); }
	   //    }
		 
	   //    ClearingAndFilling();

	   //}

	   //private void камераToolStripMenuItem1_Click(object sender, EventArgs e)
	   //{
	   //    if (treeView1.Nodes[0].Nodes.Count > 0)
	   //    {
	   //	   treeView1.Nodes[0].Nodes[treeView1.Nodes[0].Nodes.Count - 1].Remove();
	   //	   ClearingAndFilling();
	   //    }
	   //}

	   //private void очиститьУстройстваToolStripMenuItem_Click(object sender, EventArgs e)
	   //{

	   //    DevRulesSettings();
	   //    ClearingAndFilling();
	   //    treeView2.Nodes.Clear();
	   //    WindowsFormsITV_Settings.Methods.EventList.mEventList(ref treeView2);
	   //    WindowsFormsITV_Settings.Methods.DevicesIn.mDevicesIn(ref treeView2, ref devjson);
	   //    WindowsFormsITV_Settings.Methods.BindDictionaryFromDevRules.mBindDictionaryFromDevRules(ref treeView1, ref devjson, ref eventdiction);
	   //}

	   //private void удалитьКамерыToolStripMenuItem_Click(object sender, EventArgs e)
	   //{
	   //    treeView1.Nodes[0].Nodes.Clear();
	   //    WindowsFormsITV_Settings.Methods.ClearingAndFilling.mClearingAndFilling();
	   //}



	   //=======================Clear and fill=============================================\\

	   //void ClearingAndFilling()
	   //{
	   //    for (int g = 0; g < treeView1.Nodes[0].Nodes.Count; g++)
	   //    {
	   //	   for (int j = 0; j < treeView1.Nodes[0].Nodes[g].Nodes.Count; j++)
	   //	   {
	   //		  for (int k = 0; k < treeView1.Nodes[0].Nodes[g].Nodes[j].Nodes.Count; k++)
	   //		  {
	   //			 treeView1.Nodes[0].Nodes[g].Nodes[j].Nodes.Clear();
	   //		  }
	   //	   }
	   //    }

	   //    labelToolStripMenuItem.Text = "Данные не сохранены";
	   //    //label1.Text = "Данные не сохранены";
	   //    //EventsBindings();
	   //    WindowsFormsITV_Settings.Methods.BindDictionaryFromDevRules.mBindDictionaryFromDevRules(ref treeView1, ref devjson, ref eventdiction);
	   //    treeView2.CheckBoxes = true;
	   //    treeView1.CheckBoxes = true;
	   //    WindowsFormsITV_Settings.Methods.CheckedNodes.mCheckedNodes(ref treeView1);
	   //}

	   //====================================Select all===================================================\\

	   //private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
	   //{
	   //    if (выделитьВсеToolStripMenuItem.Text == "Выделить все события")
	   //    {
	   //	   for (int i = 0; i < treeView2.Nodes.Count; i++)
	   //	   {
	   //		  treeView2.Nodes[i].Checked = true;
	   //	   }

	   //	   выделитьВсеToolStripMenuItem.Text = "Отмена";
	   //    }

	   //    else
	   //    {
	   //	   for (int i = 0; i < treeView2.Nodes.Count; i++)
	   //	   {
	   //		  treeView2.Nodes[i].Checked = false;
	   //	   }
	   //	   выделитьВсеToolStripMenuItem.Text = "Выделить все события";

	   //    }
	   //}

	   //===================================Clear Cams====================================================\\

	   //private void очиститьКамерыToolStripMenuItem_Click(object sender, EventArgs e)
	   //{
	   //    for (int g = 0; g < treeView1.Nodes[0].Nodes.Count; g++)
	   //    {

	   //			 treeView1.Nodes[0].Nodes[g].Nodes.Clear();

	   //    }
	   //}

	   //============Saving============================================================\\

	   //private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
	   //{
	   //    CamRulesEdit();
	   //    WindowsFormsITV_Settings.Methods.RewriteConfig.mRewriteConfig(ref treeView1);
	   //    RewriteDevRules();
	   //    labelToolStripMenuItem.Text = "Данные сохранены";
	   //    //label1.Text = "Данные сохранены ";
	   //}

	   //===========================Double clicks===========================================\\

	   //private void камераToolStripMenuItem_DoubleClick(object sender, EventArgs e)
	   //{
	   //	   камераToolStripMenuItem.PerformClick();
	   //	   камераToolStripMenuItem.PerformClick();
	   //	   камераToolStripMenuItem.PerformClick();
	   //	   камераToolStripMenuItem.PerformClick();
	   //	   камераToolStripMenuItem.PerformClick();
	   //	   камераToolStripMenuItem.PerformClick();
	   //	   камераToolStripMenuItem.PerformClick();
	   //	   камераToolStripMenuItem.PerformClick();
	   //	   камераToolStripMenuItem.PerformClick();
	   //	   камераToolStripMenuItem.PerformClick();


	   //}

	   //private void камераToolStripMenuItem1_DoubleClick(object sender, EventArgs e)
	   //{
	   //    if (treeView1.Nodes[0].Nodes.Count >= 10)
	   //    {
	   //	   камераToolStripMenuItem1.PerformClick();
	   //	   камераToolStripMenuItem1.PerformClick();
	   //	   камераToolStripMenuItem1.PerformClick();
	   //	   камераToolStripMenuItem1.PerformClick();
	   //	   камераToolStripMenuItem1.PerformClick();
	   //	   камераToolStripMenuItem1.PerformClick();
	   //	   камераToolStripMenuItem1.PerformClick();
	   //	   камераToolStripMenuItem1.PerformClick();
	   //	   камераToolStripMenuItem1.PerformClick();
	   //	   камераToolStripMenuItem1.PerformClick();
	   //    }
	   //}

	   //========================X================================\\

	   //void xClick(string x,string y)
	   //{
	   //    y = Convert.ToString(Regex.Match(y, @"^(.*)\s"));
	   //    y = y.Substring(0, y.Length - 1);
	   //    //y = Regex.Replace(y, @"\d{1}|\d{2}|\d{3}|\d{4}|\d{5}|\d{6}|\d{7}|\d{8}|\d{9}", "");
	   //    TreeNode<NodeData> tree = JsonConvert.DeserializeObject(devjson, typeof(TreeNode<NodeData>)) as TreeNode<NodeData>;
	   //    TreeNode<NodeData> SecondTree = tree.GetChildByName(x);

	   //    if (SecondTree.GetChildByName(y) != null)
	   //    {
	   //	   TreeNode<NodeData> child = SecondTree.GetChildByName(y);
	   //	   SecondTree.RemoveChild(child);
	   //	   string jsonout = string.Empty;
	   //	   object obj = tree;
	   //	   jsonout = JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);
	   //	   devjson = jsonout;
	   //    }
	   //}

	   //=============================+===================================\\

	   //void PlusClick(string x, string y)
	   //{
		  
	   //    y = Convert.ToString(Regex.Match(y, @"^(.*)\s"));
	   //    y = y.Substring(0, y.Length - 1);
	   //    //MessageBox.Show(y);
	   //    //y = Regex.Replace(y, @"\d{1}|\d{2}|\d{3}|\d{4}|\d{5}|\d{6}|\d{7}|\d{8}|\d{9}", "");

	   //    TreeNode<NodeData> tree = JsonConvert.DeserializeObject(devjson, typeof(TreeNode<NodeData>)) as TreeNode<NodeData>;
	   //    TreeNode<NodeData> SecondTree = tree.GetChildByName(x);


	   //    TreeNode<NodeData> child = new TreeNode<NodeData>(y);
	   //    if (SecondTree.GetChildByName(y) == null)
	   //    {
	   //	   SecondTree.AddChild(child);
	   //	   string jsonout = string.Empty;
	   //	   object obj = tree;
	   //	   jsonout = JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);
	   //	   devjson = jsonout;
	   //    }
	   //}


	   //=====================================================Changing events with listbox============================================\\

	   //===================-=====================\\

	   //private void button4_Click(object sender, EventArgs e)
	   //{

	   //				  //RemoveTypesAndNumbers(Convert.ToString(Regex.Match(treeView2.Nodes[i].Text.Remove(0, 8), @"\S.?\S")));

		 
	   //		  foreach (string item in listBox1.Items)
	   //		  {	
	   //			 for (int i = 0; i < treeView2.Nodes.Count; i++)
	   //    {
	   //	   if (treeView2.Nodes[i].Checked == true)
	   //	   {
	   //			 xClick(Convert.ToString(Regex.Match(treeView2.Nodes[i].Text.Remove(0, 8), @"\S.?\S")),item);
	
	   //		  }
	   //	   }
	   //    }
	   //		  for (int i = 0; i < treeView2.Nodes.Count; i++)
	   //		  {
	   //			 treeView2.Nodes[i].Checked = false;
	   //		  }

	   //		  WindowsFormsITV_Settings.Methods.ClearingAndFilling.mClearingAndFilling();
	   //		  UncheckingItem();
		 
	   //    //for (int g = 0; g < treeView1.Nodes[0].Nodes.Count; g++)
	   //    //{
	   //    //    for (int j = 0; j < treeView1.Nodes[0].Nodes[g].Nodes.Count; j++)
	   //    //    {
	   //    //	   for (int k = 0; k < treeView1.Nodes[0].Nodes[g].Nodes[j].Nodes.Count; k++)
	   //    //	   { 
	   //    //		  MessageBox.Show(treeView1.Nodes[0].Nodes[g].Nodes[j].Text);
	   //    //		  treeView1.Nodes[0].Nodes[g].Nodes[j].Nodes.Clear();
	   //    //		  treeView1.Nodes[0].Nodes[g].Nodes[j].Checked = false;
	   //    //	   }
	   //    //    }
	   //    //}

	   //    if (выделитьВсеToolStripMenuItem.Text == "Отмена")
	   //    {
	   //	   выделитьВсеToolStripMenuItem.Text = "Выделить все события";
	   //    }

	   //    // BindDictionaryFromDevRules();
	   //    //treeView2.CheckBoxes = true;
	   //    //treeView1.CheckBoxes = true;
	   //    //CheckedNodes();

	   //   // labelToolStripMenuItem.Text = "Данные не сохранены";
	   //    //label1.Text = "Данные не сохранены";
	   //    //EventsBindings();
	   //    listBox1.Items.Clear();
	   //    treeView2.Nodes.Clear();
	   //    WindowsFormsITV_Settings.Methods.EventList.mEventList(ref treeView2);
	   //    WindowsFormsITV_Settings.Methods.DevicesIn.mDevicesIn(ref treeView2, ref devjson);
	   //    //BindDictionaryFromDevRules();
	   //    //treeView2.CheckBoxes = true;
	   //    //treeView1.CheckBoxes = true;
	   //    //CheckedNodes();


	   //    //CamRulesEdit();
	   //    //RewriteConfig();
	   //    //RewriteDevRules();
	   //    //CheckedNodes();
	   //    labelToolStripMenuItem.Text = "Данные не сохранены";
	   //    ////label1.Text = "Данные сохранены ";

	   //}

	   //====================Uncheck devices=====================\\

	   //void UncheckingItem() 
	   //{


	   //	   for (int g = 0; g < treeView1.Nodes[0].Nodes.Count; g++)
	   //	   {

	   //		  for (int j = 0; j < treeView1.Nodes[0].Nodes[g].Nodes.Count; j++)
	   //		  {


	   //				    treeView1.Nodes[0].Nodes[g].Nodes[j].Checked = false;

	   //		  }
	   //	   }
	   //    }

	   //==========================+=============================\\
	   //private void button7_Click(object sender, EventArgs e)
	   //{


	   //	  foreach (string item in listBox1.Items)
	   //		  {

	   //		 for (int i = 0; i < treeView2.Nodes.Count; i++)
	   //    {
	   //	   if (treeView2.Nodes[i].Checked == true)
	   //	   {
	   //			 PlusClick(Convert.ToString(Regex.Match(treeView2.Nodes[i].Text.Remove(0, 8), @"\S.?\S")), item);

	   //		  }
	   //		 }
	   //	  }
	   //		 for (int i = 0; i < treeView2.Nodes.Count; i++)
	   //		 {
	   //		    treeView2.Nodes[i].Checked = false; 
	   //		 }
				





	   //    //for (int g = 0; g < treeView1.Nodes[0].Nodes.Count; g++)
	   //    //{
	   //    //    for (int j = 0; j < treeView1.Nodes[0].Nodes[g].Nodes.Count; j++)
	   //    //    {
	   //    //	   for (int k = 0; k < treeView1.Nodes[0].Nodes[g].Nodes[j].Nodes.Count; k++)
	   //    //	   {
	   //    //		  treeView1.Nodes[0].Nodes[g].Nodes[j].Nodes.Clear();
	   //    //	   }
	   //    //    }
	   //    //}
	   //    WindowsFormsITV_Settings.Methods.ClearingAndFilling.mClearingAndFilling();
	   //    UncheckingItem();

	   //    if (выделитьВсеToolStripMenuItem.Text == "Отмена")
	   //    {
	   //	   выделитьВсеToolStripMenuItem.Text = "Выделить все события";
	   //    }

	   //    labelToolStripMenuItem.Text = "Данные не сохранены";
	   //    //label1.Text = "Данные не сохранены";
	   //    //EventsBindings();
	   //    listBox1.Items.Clear();
	   //    treeView2.Nodes.Clear();
	   //    WindowsFormsITV_Settings.Methods.EventList.mEventList(ref treeView2);
	   //    WindowsFormsITV_Settings.Methods.DevicesIn.mDevicesIn(ref treeView2,ref devjson);
	   //    //treeView2.CheckBoxes = true;
	   //    //treeView1.CheckBoxes = true;
	   //    //CheckedNodes();



	   //}

	   //==================Json to Xml========================\\

	   //void JsonToXML() 
	   //{
	   //    StreamReader sr = new StreamReader("C:\\SNI\\NamosRus\\CamRules.json");
	   //    string json = sr.ReadToEnd();
	   //    TreeNode<NodeData> tree = JSONWork.JSONHelper.ReadJSON<TreeNode<NodeData>>(json) as TreeNode<NodeData>;
	   //    sr.Close();
	   //    object obj = tree;
	   //    string json2 = JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);
	   //    //XmlNode myXmlNode = JsonConvert.DeserializeXmlNode(json2);
	   //    //XmlDocument doc = (XmlDocument)JsonConvert.DeserializeXmlNode(json2);
	   //    XNode node = JsonConvert.DeserializeXNode(json2, "Root");
	   //    StreamWriter sw = new StreamWriter("CamRulesXML.xml");
	   //    sw.Write(node.ToString());
	   //    sw.Close();

	   //}

	   //========================Xml to TreeConfig====================\\

	   //void XmlToTreeConfig()
	   //{
	   //    StreamReader sr = new StreamReader("CamRulesXML.xml");
	   //    string xml = sr.ReadToEnd();
	   //    sr.Close();
	   //    XmlDocument doc = new XmlDocument();
	   //    doc.LoadXml(xml);
	   //    XmlElement el = (XmlElement)doc.SelectSingleNode("/Root/Name[Number=0]");
	   //    if (el != null) { el.ParentNode.RemoveChild(el); }

	   //    xml = xml.Replace("root", "Камеры");
	   //    //string pattern = @"<Name>(.*)</Name>";
	   //    //Match match = Regex.Match(xml, pattern);
	   //    //string x = match.Groups[1].ToString();

	   //    StreamWriter sw = new StreamWriter("CamRulesXML2.xml");
	   //    sw.Write(el);
	   //    sw.Close();
	   //}

	   //==========CONFIG FROM CAMRULES===========\\

	   //void TreeForConfigAndDevRules()
	   //{ 
	   //    List<string> l = new List<string>();
	   //    StreamReader srr = new StreamReader("EventMap.json");
	   //    string jsonn = srr.ReadToEnd();
	   //    srr.Close();
	   //    TreeNode<EventLexem> treee = JSONWork.JSONHelper.ReadJSON<TreeNode<EventLexem>>(jsonn) as TreeNode<EventLexem>;


	   //    //===============================List of events=========================================\\

	   //    string[] arr = new string[treee.ChildrenCount];
	   //    for (int q = 0; q < treee.ChildrenCount; q++)
	   //    {
	   //	   arr[q] = treee.GetChild(q).Name;
	   //    }
	   //    for (int u = 0; u < arr.Length; u++)
	   //    {
	   //	   l.Add(arr[u]);
	   //    }


	   //    try
	   //    {
	   //	   StreamReader sr = new StreamReader("C:\\SNI\\NamosRus\\CamRules.json");
	   //	   string json = sr.ReadToEnd();
	   //	   TreeNode<NodeData> tree = JSONWork.JSONHelper.ReadJSON<TreeNode<NodeData>>(json) as TreeNode<NodeData>;
	   //	   sr.Close();


	   //	   string temp = null, cap = null, cap2 = null, cap3 = null, cap4 = null, cap5 = null, xml = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>\n" + "<Камеры>\n";
	   //	   string conf = null, cap6 = null;
	   //	   string[] lines = null;
	   //	   string alllines = null;
	   //	   int k = 0;
	   //	   List<string> LineMasssive = new List<string>();

	   //	   TreeNode<NodeData> dev = new TreeNode<NodeData>();


	   //	   for (int i = 0; i < tree.ChildrenCount; i++)
	   //	   {
	   //		  TreeNode<NodeData> newtree = tree.GetChild(i);
	   //		  for (int g = 0; g < newtree.ChildrenCount; g++)
	   //		  {
	   //			 TreeNode<NodeData> newtree2 = newtree.GetChild(g);

	   //			 if (Regex.IsMatch(newtree2.Name, @"\d{3}") == true)
	   //			 {
	   //				//MessageBox.Show(newtree2.Name);
	   //				string x = newtree2.GetChildByName("Number").Data.Value;
	   //				string y = newtree2.GetChildByName("CurrentType").Data.Value;
	   //				if (y == "1") { y = "POS"; }
	   //				if (y == "2") { y = "BOS"; }
	   //				if (y == "3") { y = "ТРК"; }
	   //				if (y == "4") { y = "Уровнемер"; }
	   //				if (y == "5") { y = "OPT"; }
	   //				if (y == "6") { y = "DOMS"; }
	   //				cap3 = "Камера" + newtree.Name;
	   //				cap5 = y + x;
	   //				//MessageBox.Show(cap6);
	   //				//=============================for config===============================================================================================================\\
	   //				if (cap4 == null) { xml = xml + "<" + cap3 + ">\n"; }
	   //				if (cap3 == cap4 || cap4 == null) { if (cap5 != cap6) { xml = xml + "<" + cap5 + "/>\n"; cap6 = cap5; } } else { if (Convert.ToInt32(newtree.Name) - 1 != 0) { xml = xml + "</" + "Камера" + Convert.ToString(Convert.ToInt32(newtree.Name) - 1) + ">\n" + "<" + cap3 + ">\n"; cap6 = null; } }

	   //				cap4 = "Камера" + newtree.Name;


	   //				cap2 = "Камера" + newtree.Name + " " + y + "" + x + "\n";
	   //				if (cap != cap2)
	   //				{
	   //				    cap = cap2;
	   //				}

	   //				else { cap = null; }
	   //				temp = temp + "Камера № " + newtree.Name + " Event № " + newtree2.Name + " Number " + x + " CurrentType " + y + "\n";
	   //				//conf = conf + "Cam № " + newtree.Name +  " " + y + "  " + x + "\n";
	   //				conf = conf + cap;


	   //				LineMasssive.Add(cap2);
	   //				//----------------------------------------------------------------------------------------------------\\

	   //				foreach (var item in l)
	   //				{
	   //				    TreeNode<NodeData> tmp = new TreeNode<NodeData>(new NodeData(null), item);
	   //				    dev.AddChild(tmp);
	   //				}




	   //				TreeNode<NodeData> tmp2 = new TreeNode<NodeData>(new NodeData(null), cap5);


	   //				dev.GetChildByName(newtree2.Name).AddChild(tmp2);

	   //				dev.Name = "root";

	   //				//MessageBox.Show(dev.GetChildByName("005").GetChildByName("Уровнемер73").Name);
	   //				//k++;

	   //				//lines[k] = "Cam № " + newtree.Name + " " + y + "  " + x + "\n";

	   //				//if (lines[k] == lines[k - 1]) { lines[k] = ""; }
	   //			 }
	   //		  }

	   //	   }
	   //	   xml = xml + "</" + cap4 + ">\n" + "</Камеры>";
	   //	   LineMasssive = LineMasssive.Distinct().ToList<string>();
	   //	   string s = null;
	   //	   foreach (var item in LineMasssive)
	   //	   {
	   //		  s = s + item;
	   //	   }


	   //	   //for (int i = 0; i < lines.Length; i++)
	   //	   //{
	   //	   //    alllines = alllines + lines[i];
	   //	   //}
	   //	   //MessageBox.Show(alllines);

	   //	   StreamWriter sw = new StreamWriter("TreeConfig.xml");
	   //	   sw.Write(xml);
	   //	   sw.Close();


	   //	   //-------------------------------------\\
	   //	   //MessageBox.Show("here");
	   //	   int count = 0;
	   //	   for (int i = 1; i < 100; i++)
	   //	   {
	   //		  if(tree.GetChildByName(Convert.ToString(i)) != null)
	   //		  {
	   //			 int c;
	   //			 c = tree.GetChildByName(Convert.ToString(i)).ChildrenCount;
	   //			 count = count + c;
	   //		  }
	   //	   }

	   //	   if (count > 0)
	   //	   {
	   //		  //MessageBox.Show("here");
	   //		  string jsonout = string.Empty;
	   //		  object obj = dev;
	   //		  jsonout = JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);

	   //		  StreamWriter sw2 = new StreamWriter("DevRules.json");
	   //		  sw2.Write(jsonout);
	   //		  sw2.Close();
	   //		  //object obj = tree;
	   //		  //string json2 = JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);

	   //		  //StreamWriter sw = new StreamWriter("CamRulesJson2.xml");
	   //		  //sw.Write(json2);
	   //		  //sw.Close();
	   //	   }

	   //	   else
	   //	   {
	   //		  //MessageBox.Show("here");
	   //		  StreamReader sr1 = new StreamReader("emptyDevRules.json.txt");
	   //		  string empty = sr1.ReadToEnd();
	   //		  StreamWriter sw3 = new StreamWriter("DevRules.json");
	   //		  sw3.Write(empty);
	   //		  sw3.Close();
	   //	   }
	   //    }
	   //    catch
	   //    {

	   //	   //MessageBox.Show("catch");
	   //	   StreamWriter sw = new StreamWriter("TreeConfig.xml");
	   //	   sw.Write("<?xml version=\"1.0\" encoding=\"utf-8\" ?>\n<Камеры>\n<Камера1/>\n</Камеры>");
	   //	   sw.Close();
	   //	   StreamReader sr = new StreamReader("emptyDevRules.json.txt");
	   //	   string empty = sr.ReadToEnd();
	   //	   StreamWriter sw2 = new StreamWriter("DevRules.json");
	   //	   sw2.Write(empty);
	   //	   sw2.Close();
	   //    };

	   //}

	   //====================\\

	   //void xmlremovingnodes() 
	   //{
	   //    StreamReader sr = new StreamReader("CamRulesXML.xml");
	   //    string xml = sr.ReadToEnd();
	   //    sr.Close();
	   //    XElement root = XElement.Parse(xml);
	   //    //foreach (var x in root.Descendants("Data").ToList())
	   //    //{
	   //    //    x.Remove();
	   //    //}
	   //    foreach (var x in root.Descendants("ChildrenCount").ToList())
	   //    {
	   //	   x.Remove();
	   //    }
	   //    XmlDocument doc = new XmlDocument();
	   //    doc.LoadXml(root.ToString());
	   //    XmlNode newNode = doc.DocumentElement;

	   //    //foreach (var x in root.Descendants("Children").ToList())
	   //    //{
	   //    //    x.Remove();
	   //    //}
	   //    //root.Element("Name").Elements().Remove();
	   //    StreamWriter sw = new StreamWriter("CamRulesXML2.xml");
	   //    sw.Write(root);
	   //    sw.Close();

	   //} 

	   //===================\\

		  #endregion
    }

    }

