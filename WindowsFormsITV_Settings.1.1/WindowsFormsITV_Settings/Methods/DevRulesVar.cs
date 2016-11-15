using System.IO;

namespace WindowsFormsITV_Settings.Methods
{
    public static class DevRulesVar
    {
	   public static void mDevRulesVar(ref string devjson)
	   {
		  if (File.Exists("DevRules.json"))
		  {
			 string json = null;

			 StreamReader strread = new StreamReader("DevRules.json");
			 json = strread.ReadToEnd();
			 strread.Close();
			 devjson = json;
		  }
		  else
		  {
			 StreamReader strread = new StreamReader("emptyDevRules.json.txt");
			 string json = null;
			 json = strread.ReadToEnd();
			 strread.Close();
			 devjson = json;
		  }

	   }
    }
}
