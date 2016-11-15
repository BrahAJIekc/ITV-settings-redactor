using System.Windows.Forms;

namespace WindowsFormsITV_Settings.Events
{
    public static class treeViews_AfterCheck
    {
	   public static void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
	   {
		  if (e.Node.Checked & e.Node.Level == 2)
			 Form1000.listBox1.Items.Add(e.Node.Text + " " + e.Node.Parent.Text);
		  else if (e.Node.Level == 2)
			 Form1000.listBox1.Items.Remove(e.Node.Text + " " + e.Node.Parent.Text);

	   }
    }
}
