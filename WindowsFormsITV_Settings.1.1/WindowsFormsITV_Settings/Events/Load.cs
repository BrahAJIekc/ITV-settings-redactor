using System;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsITV_Settings.Events
{
    public static class Load
    {
	   public static void Form1000_Load(object sender, EventArgs e)
	   {
	      //ContextMenu = new System.Windows.Forms.ContextMenu();
	   //    //button1.Location = new Point(treeView1.Width - 130, treeView1.Height + 20);
	   //    //button2.Location = new Point(treeView1.Width - 130 - 582, treeView1.Height + 20);
	   //    //label2.Location = new Point(numericUpDown2.Location.X - 80, numericUpDown2.Location.Y + 10);
	   //    //label3.Location = new Point(numericUpDown1.Location.X - 120, numericUpDown1.Location.Y + 10);
	   //    ////label1.Location = new Point(button4.Location.X -120, button4.Location.Y+3 );
	   //    //label1.ForeColor = Color.Red;
		  Form1000.treeView2.Width = Form1000.treeView2.Width + 100;
		  Form1000.button5.Enabled = false;
		  Form1000.button6.Enabled = false;
		  Form1000.button5.Visible = false;
		  Form1000.button6.Visible = false;
		  Form1000.numericUpDown3.Enabled = false;
		  Form1000.numericUpDown3.Visible = false;
		  //Form1000.button4.Location = new Point(Form1000.button5.Location.X, Form1000.button5.Location.Y);
		  Form1000.panel1.Location = new Point(Form1000.treeView2.Location.X, Form1000.treeView2.Height+30);
		  Form1000.panel2.Location = new Point(Form1000.treeView1.Location.X, Form1000.treeView1.Height + 30);

		  //Form1000.groupBox1.Visible = false;
		  Form1000.panel1.Width = Form1000.treeView2.Width;
		  Form1000.panel1.Height = Form1000.button5.Height+5;
		  //Form1000.groupBox1.Text = null;
		  Form1000.button4.Location = new Point(10, 7);
		  Form1000.button7.Location = new Point(Form1000.panel1.Width - Form1000.button7.Width - 110, 7);
		  //Form1000.button4.Width = 100;
		  //Form1000.button7.Width = 100;
		  Form1000.button4.Height = Form1000.button5.Height -5;
		  Form1000.button7.Height = Form1000.button5.Height - 5;
		  Form1000.button4.Width = Form1000.treeView2.Width / 2 - 20;
		  Form1000.button7.Width = Form1000.treeView2.Width / 2 - 20;
		  Form1000.button4.Enabled = false;
		  Form1000.button4.Visible = false;
		  //Form1000.button2.Enabled = false;
		  //Form1000.button2.Visible = false;
		  //Form1000.button7.Location = new System.Drawing.Point(Form1000.groupBox1.Location.X + Form1000.groupBox1.Width, 15);
		  //Form1000.button4.Location = new Point(Form1000.groupBox1.Location.X+40,Form1000.groupBox1.Location.Y-10);
		  //Form1000.button7.Location = new Point(Form1000.groupBox1.Location.X, Form1000.groupBox1.Location.Y);
		  Form1000.button8.Enabled = false;
		  Form1000.button8.Visible = false;
		  Form1000.button9.Enabled = false;
		  Form1000.button9.Visible = false;
		  Form1000.button3.Enabled = false;
		  Form1000.button3.Visible = false;
		  Form1000.button9.Height = Form1000.button2.Height;
		  Form1000.button9.Location = new Point(Form1000.button9.Location.X,Form1000.button2.Location.Y);
		  Form1000.labelToolStripMenuItem.Text = null;
		  Form1000.listBox1.Enabled = false;
		  Form1000.listBox1.Visible = false;
		  Form1000.button2.Width = 220;
		  Form1000.numericUpDown1.Location = new Point(Form1000.numericUpDown1.Location.X, Form1000.treeView1.Height + 40);
		  Form1000.numericUpDown2.Location = new Point(Form1000.numericUpDown2.Location.X, Form1000.treeView1.Height + 40);
		  //Form1000.label2.Location = new Point(Form1000.numericUpDown2.Location.X, Form1000.treeView1.Height + 40);
		  Form1000.button7.Width = Form1000.treeView2.Width;
		  Form1000.button1.Width = Form1000.treeView2.Width;
		  Form1000.button7.Location = new Point(0, 7);
		  Form1000.button2.Height = Form1000.button1.Height;
		 // new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		  Form1000.button2.Font = Form1000.button1.Font = Form1000.button7.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		 
		  Form1000.tn = WindowsFormsITV_Settings.Methods.CopyTree.mCopyTree(Form1000.treeView1);
		  Form1000.tn2 = WindowsFormsITV_Settings.Methods.CopyTree.mCopyTree2(Form1000.treeView2);
		  Form1000.UndoToolStripMenuItem.Enabled = false;
		  Form1000.UndoToolStripMenuItem.Visible = false;
		  //Form1000.devjsonBackUp.Add(Form1000.devjson);

	   //    int d = Form1000.groupBox1.Width - 375;
	   //    String nospace = new String(' ', d);

	   //    Form1000.groupBox1.Text = "  Удалить" + nospace + "Добавить";
	   }

    }
}
