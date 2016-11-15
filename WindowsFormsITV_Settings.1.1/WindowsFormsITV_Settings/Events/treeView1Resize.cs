using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsITV_Settings.Events
{
    public static class treeView1Resize
    {
	   public static  void treeView1_Resize(object sender, EventArgs e)
	   {
		  if (Form1000.ActiveForm.WindowState == FormWindowState.Minimized)
		  {

		  }
		  else
		  {
			 //int d =1;
			 //label1.Location = new Point(numericUpDown1.Location.X, numericUpDown1.Location.Y + 50);

			 //button4.Location = new Point(numericUpDown2.Location.X - 10, numericUpDown2.Height);
			 //label1.Location = new Point(button4.Location.X - 120, button4.Location.Y+5);
			 Form1000.treeView2.Location = new Point(Form1000.treeView1.Width + 15, Form1000.treeView1.Location.Y);
			 Form1000.treeView2.Height = Form1000.treeView1.Height - Form1000.button6.Height;
			 Form1000.button6.Location = new Point(Form1000.treeView2.Location.X + Form1000.treeView2.Width - Form1000.button6.Width, Form1000.treeView2.Height + 10);
			 Form1000.button5.Location = new Point(Form1000.treeView2.Location.X, Form1000.treeView2.Height + 10);
			 //Form1000.groupBox1.Location = new Point(Form1000.button1.Location.X - (Form1000.groupBox1.Width + 5), Form1000.button1.Location.Y - 5);
			 Form1000.treeView1.Width = Form1000.ActiveForm.Width / 2;
			 Form1000.treeView2.Width = Form1000.ActiveForm.Width - Form1000.treeView1.Width - 40;
			 //Form1000.button2.Location = new Point(Form1000.treeView1.Location.X, Form1000.treeView1.Height + 20);
			 Form1000.button1.Width = Form1000.treeView2.Width;
			 Form1000.button1.Location = new Point(Form1000.treeView2.Location.X, Form1000.treeView1.Height + 40);
			 //Form1000.button2.Width = Form1000.treeView1.Width - Form1000.numericUpDown2.Width - Form1000.numericUpDown1.Width -20;
			 Form1000.panel1.Location = new Point(Form1000.treeView2.Location.X, Form1000.treeView2.Height + 30);
			 Form1000.panel1.Width = Form1000.treeView2.Width;
			 Form1000.listBox1.Location = new Point(Form1000.treeView1.Width + Form1000.treeView2.Width + 20, Form1000.treeView1.Location.Y);
			 Form1000.listBox1.Height = Form1000.treeView1.Height;
			 Form1000.button3.Location = new Point(Form1000.listBox1.Location.X, Form1000.listBox1.Height + 20);
			 Form1000.button4.Location = new Point(10, 7);
			 Form1000.button7.Location = new Point(0, 7);
			 Form1000.button4.Width = Form1000.treeView2.Width / 2 - 20;
			 Form1000.button7.Width = Form1000.treeView2.Width;
			 Form1000.panel2.Location = new Point(Form1000.treeView1.Location.X-10, Form1000.treeView1.Height + 35);
			 Form1000.numericUpDown1.Location = new Point(Form1000.panel2.Location.X + Form1000.panel2.Width + 10, Form1000.treeView1.Height + 42);
			 Form1000.numericUpDown2.Location = new Point(Form1000.panel2.Location.X + Form1000.panel2.Width + 10 + Form1000.numericUpDown1.Width + 10, Form1000.treeView1.Height + 42);
			 Form1000.panel2.Width = Form1000.treeView1.Width - Form1000.numericUpDown2.Width - Form1000.numericUpDown1.Width - 20;
			 //Form1000.numericUpDown3.Location = new Point(Form1000.treeView2.Location.X + Form1000.treeView2.Width / 2 - 15, Form1000.treeView2.Height + 13);		  
			 Form1000.label2.Location = new Point(Form1000.numericUpDown2.Location.X, Form1000.numericUpDown2.Location.Y + 37);
			 Form1000.label3.Location = new Point(Form1000.numericUpDown1.Location.X - 5, Form1000.numericUpDown1.Location.Y + 37);
			 Form1000.button2.Width = Form1000.panel2.Width - 10;
			 Form1000.button2.Height= Form1000.button1.Height;

			 Form1000.button2.Location = new Point(10, 7);
			 Form1000.button9.Height = Form1000.button2.Height;
			 Form1000.button1.Width = Form1000.treeView2.Width;
			 Form1000.button3.Location = new Point(Form1000.button1.Location.X + Form1000.button1.Width + 10, Form1000.button1.Location.Y);
			 //if (Form1000.menuStrip1.Container.Components.Count<5) { MessageBox.Show("here"); }
			 
			 
			 //Form1000.menuStrip1.
			 //Form1000.menuStrip1.MinimumSize = new System.Drawing.Size(100, 40);
			 //Form1000.сохранитьToolStripMenuItem.Font = Form1000.labelToolStripMenuItem.Font = Form1000.очиститьКамерыToolStripMenuItem.Font = Form1000.выделитьВсеToolStripMenuItem.Font = Form1000.удалитьКамерыToolStripMenuItem.Font = Form1000.очиститьУстройстваToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))); 
			 //if(Form1000.menuStrip1.MinimumSize = (100,10))
			 //{
			 //    Form1000.menuStrip1.
			 //}

			 //Form1000.сохранитьToolStripMenuItem.Width = Form1000.сохранитьToolStripMenuItem.Width + Form1000.ActiveForm.Width;
		  }
		  //d = Form1000.groupBox1.Width - 375;
		  //String nospace = new String(' ', d);

		  //Form1000.groupBox1.Text = "  Удалить" + nospace + "Добавить";
	   }
    }
}
