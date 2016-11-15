using System.IO;

namespace WindowsFormsITV_Settings.Methods
{
    public static class RewriteDevRules
    {
	   public static void mRewriteDevRules()
	   {
		  StreamWriter strwtr = new StreamWriter("DevRules.json");
		  strwtr.Write(Form1000.devjson);
		  strwtr.Close();

	   }
    }
}
