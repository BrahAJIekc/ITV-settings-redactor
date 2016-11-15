using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsITV_Settings.Events
{
    public  class Refresh
    {

		  public static Refresher CN;


		  public Refresh(Refresher cn)
		  {
			 CN = cn;
			 // Add "ListChanged" to the Changed event on "List":
			 //CN.changed_node += new WindowsFormsITV_Settings.Events.Refresher.ChangedEventHandler(ListChanged);
		  }

		  // This will be called whenever the list changes:
		  public static  void ListChanged(object sender, EventArgs e)
		  {
			 Console.WriteLine("This is called when the event fires.");
		  }

		  public void Detach()
		  {
			 // Detach the event and delete the list:
			 //CN.changed_node -= new WindowsFormsITV_Settings.Events.Refresher.ChangedEventHandler(ListChanged);
			 CN = null;
		  }
    }
}
