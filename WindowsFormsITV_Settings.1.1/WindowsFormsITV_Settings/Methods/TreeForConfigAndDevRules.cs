using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using LexemWork.Core;
using EventMapWork;
using System.Threading;
using System.Resources;
using System.Text;
using System.Reflection;

namespace WindowsFormsITV_Settings.Methods
{
    public static class TreeForConfigAndDevRules
    {

	   public static void mTreeForConfigAndDevRules()
	   {
		  var codeBaseUrl = Assembly.GetExecutingAssembly().CodeBase;
		  var filePathToCodeBase = new Uri(codeBaseUrl).LocalPath;
		  var directoryPath = Path.GetDirectoryName(filePathToCodeBase);
		
		  var evmapdir = Path.GetDirectoryName(Path.GetDirectoryName(directoryPath));
		  //string codeBase = System.Reflection.Assembly.GetExecutingAssembly();
		  //StreamReader rs = new StreamReader(System.Reflection.Assembly.GetExecutingAssembly().GetFile("EventMap.json"));
		  //MessageBox.Show(evmapdir);
		  //MessageBox.Show(directoryPath);
		  //MessageBox.Show(rs.ReadToEnd());

			 List<string> l = new List<string>();
			 StreamReader srr = new StreamReader(directoryPath + @"\EventMap.json");
			 string jsonn = srr.ReadToEnd();
			 srr.Close();
			 TreeNode<EventLexem> treee = JSONWork.JSONHelper.ReadJSON<TreeNode<EventLexem>>(jsonn) as TreeNode<EventLexem>;


		  //===============================List of events=========================================\\

		  string[] arr = new string[treee.ChildrenCount];
		  for (int q = 0; q < treee.ChildrenCount; q++)
		  {
			 arr[q] = treee.GetChild(q).Name;
		  }
		  for (int u = 0; u < arr.Length; u++)
		  {
			 l.Add(arr[u]);
		  }

            string fromdirectory = null;

            try
		  {
                string json = null;
                if (!File.Exists("C:\\SNI\\NamosRus\\CamRules.json"))
                {
                    Stream myStream = null;
                    OpenFileDialog openFileDialog1 = new OpenFileDialog();

                    openFileDialog1.InitialDirectory = "c:\\";
                    openFileDialog1.Filter = "JSON files (*.json)|*.json";
                    openFileDialog1.FilterIndex = 2;
                    openFileDialog1.RestoreDirectory = true;

                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            if ((myStream = openFileDialog1.OpenFile()) != null)
                            {
                                using (myStream)
                                {
                                    StreamReader tempsr = new StreamReader(myStream);
                                    fromdirectory = tempsr.ReadToEnd();
                                    json = fromdirectory;
                                }
                            }
                            string dir = System.IO.Path.GetDirectoryName(openFileDialog1.FileName);
                            Form1000.Dir =  openFileDialog1.FileName;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                        }
                    }
                    //Form f = new Form();
                    //f.Text = "Input directory";
                    //TextBox tb = new TextBox();
                    //Button bt = new Button();
                    //bt.Text = "Ok";
                    //bt.Click += new System.EventHandler((sender, e) => bt_Click(sender, e));
                    //tb.Location = new System.Drawing.Point(10, 30);
                    //tb.Size = new System.Drawing.Size(300, 30);
                    //f.Controls.Add(tb);
                    //f.Controls.Add(bt);
                    //f.ClientSize = new System.Drawing.Size(200, 20);
                    //f.ShowDialog();

                }
                else
                {
                    StreamReader sr = new StreamReader("C:\\SNI\\NamosRus\\CamRules.json");
                    json = sr.ReadToEnd();
                    sr.Close();
                }
                //MessageBox.Show(fromdirectory);
            
                
                TreeNode<NodeData> tree = JSONWork.JSONHelper.ReadJSON<TreeNode<NodeData>>(json) as TreeNode<NodeData>;
			 
			 string temp = null, cap = null, cap2 = null, cap3 = null, cap4 = null, cap5 = null, xml = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>\n" + "<Камеры>\n";
			 string conf = null, cap6 = null;
			 //string[] lines = null;
			 //string alllines = null;
			 //int k = 0;
			 //List<string> LineMasssive = new List<string>();

			 TreeNode<NodeData> dev = new TreeNode<NodeData>();

			 foreach (var item in l)
			 {
				TreeNode<NodeData> tmp = new TreeNode<NodeData>(new NodeData(null), item);
				dev.AddChild(tmp);
			 }

			 for (int i = 0; i < tree.ChildrenCount; i++)
			 {

				TreeNode<NodeData> newtree = tree.GetChild(i);
				for (int g = 0; g < newtree.ChildrenCount; g++)
				{
				    TreeNode<NodeData> newtree2 = newtree.GetChild(g);

				    
				    if (Regex.IsMatch(newtree2.Name, @"\d{3}") == true)
				    {


					   if (newtree2.GetChildByName("CurrentType") != null && newtree2.GetChildByName("Number") != null)
					   {

						  string x = newtree2.GetChildByName("Number").Data.Value;

						  string y = newtree2.GetChildByName("CurrentType").Data.Value;
						  if (y == "1") { y = "POS"; }
						  if (y == "2") { y = "BOS"; }
						  if (y == "3") { y = "ТРК"; }
						  if (y == "4") { y = "Уровнемер"; }
						  if (y == "5") { y = "OPT"; }
						  if (y == "6") { y = "DOMS"; }

						  
						  cap3 = "Камера" + newtree.Name;
						  cap5 = y + x;

						  //=============================for config===============================================================================================================\\
						  if (cap4 == null) { xml = xml + "<" + cap3 + ">\n"; }
						  if (cap3 == cap4 || cap4 == null) { if (cap5 != cap6) { xml = xml + "<" + cap5 + "/>\n"; cap6 = cap5; } } else { if (Convert.ToInt32(newtree.Name) - 1 != 0) { xml = xml + "</" + "Камера" + Convert.ToString(cap4.Remove(0,6)) + ">\n" + "<" + cap3 + ">\n"; cap6 = null; } }

						  cap4 = "Камера" + newtree.Name;


						  cap2 = "Камера" + newtree.Name + " " + y + "" + x + "\n";
						  if (cap != cap2)
						  {
							 cap = cap2;
						  }

						  else { cap = null; }
						  temp = temp + "Камера № " + newtree.Name + " Event № " + newtree2.Name + " Number " + x + " CurrentType " + y + "\n";
						  //conf = conf + "Cam № " + newtree.Name +  " " + y + "  " + x + "\n";
						  conf = conf + cap;


						  //LineMasssive.Add(cap2);
						  //----------------------------------------------------------------------------------------------------\\


						  TreeNode<NodeData> tmp2 = new TreeNode<NodeData>(new NodeData(newtree.Name), cap5);

						  if (dev.GetChildByName(newtree2.Name).GetChildByName(cap5) == null)
						  {
							 dev.GetChildByName(newtree2.Name).AddChild(tmp2);
						  }
						  else 
						  {
							 if (dev.GetChildByName(newtree2.Name).GetChildByName(cap5).Name == cap5 && dev.GetChildByName(newtree2.Name).GetChildByName(cap5).Data.Value != newtree.Name) 
							 {
								dev.GetChildByName(newtree2.Name).AddChild(tmp2);
							 }
						  }
						  dev.Name = "root";

					   }
				    }
				}

				//if (Regex.IsMatch(tree.GetChild(i).Name, @"\d{1}|\d{2}") == true && tree.GetChild(i).ChildrenCount == 0) { xml = xml + "</" + "Камера" + tree.GetChild(i-1).Name + ">\n" + "<" + "Камера" + tree.GetChild(i).Name + "/>\n"; }  

			 }

			 xml = xml + "</" + cap4 + ">\n" + "</Камеры>";
			 //LineMasssive = LineMasssive.Distinct().ToList<string>();
			 //string s = null;
			 //foreach (var item in LineMasssive)
			 //{
			 //    s = s + item;
			 //}
			 Thread th0 = new Thread(() => xmlwriter1(ref xml));
			 th0.Start();

			 //StreamWriter sw = new StreamWriter("TreeConfig.xml");
			 //sw.Write(xml);
			 //sw.Close();


			 //-------------------------------------\\

			 int count = 0;
			 for (int i = 1; i < 100; i++)
			 {
				if (tree.GetChildByName(Convert.ToString(i)) != null)
				{
				    int c;
				    c = tree.GetChildByName(Convert.ToString(i)).ChildrenCount;
				    count = count + c;
				}
			 }
			 if (count > 0)
			 {

				//Thread th1 = new Thread(() =>ifokdevrules1(ref dev));
				//th1.Start();
				ifokdevrules1(ref dev);
			 }
			 else
			 {
				
				//Thread th2 = new Thread(() =>devrules1());
				//th2.Start();
				devrules1();
			 }
		  }
		  catch
		  {

		  	   Thread th3 = new Thread(() =>treeconfig2());
		  	   th3.Start();

		  	   Thread th4 = new Thread(() =>devrules2());
		  	   th4.Start();

		  }
		  }

        private static void bt_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        static void treeconfig2()
			 {
			 StreamWriter sw = new StreamWriter("TreeConfig.xml");
			 sw.Write("<?xml version=\"1.0\" encoding=\"utf-8\" ?>\n<Камеры>\n<Камера1/>\n</Камеры>");
			 sw.Close();
			 }

			 static void devrules2()
			 {	
				var codeBaseUrl = Assembly.GetExecutingAssembly().CodeBase;
				var filePathToCodeBase = new Uri(codeBaseUrl).LocalPath;
				var directoryPath = Path.GetDirectoryName(filePathToCodeBase);
				StreamReader sr = new StreamReader(directoryPath +@"\emptyDevRules.json.txt");
				string empty = sr.ReadToEnd();
				sr.Close();
				StreamWriter sw2 = new StreamWriter("DevRules.json");
				sw2.Write(empty);
				sw2.Close();


			 }

				static void treeconfig1(ref string xml )
				{
				    StreamWriter sw = new StreamWriter("TreeConfig.xml");
				    sw.Write(xml);
				    sw.Close();
				}

				static void devrules1()
				{
				var codeBaseUrl = Assembly.GetExecutingAssembly().CodeBase;
				var filePathToCodeBase = new Uri(codeBaseUrl).LocalPath;
				var directoryPath = Path.GetDirectoryName(filePathToCodeBase);
				StreamReader sr1 = new StreamReader(directoryPath + @"\emptyDevRules.json.txt");
				string empty = sr1.ReadToEnd();
				sr1.Close();
				StreamWriter sw3 = new StreamWriter("DevRules.json");
				sw3.Write(empty);
				sw3.Close();
				}
				static void ifokdevrules1(ref TreeNode<NodeData> dev)
				{
				    string jsonout = string.Empty;
				    object obj = dev;
				    jsonout = JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);
				    StreamWriter sw2 = new StreamWriter("DevRules.json");
				    sw2.Write(jsonout);
				    sw2.Close();
				}
				static void xmlwriter1(ref string xml)
				{
				    StreamWriter sw = new StreamWriter("TreeConfig.xml");
				    sw.Write(xml);
				    sw.Close();
				}
    }
}
