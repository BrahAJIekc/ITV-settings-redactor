using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsITV_Settings
{
    class NodeData
    {
	   public NodeData()
	   {

	   }

	   public NodeData(string value)
		{
			this.m_Value = value;
		}

		private string m_Value;
		public string Value
		{
			get
			{
				return this.m_Value;
			}
			set
			{
				this.m_Value = value;
			}
		}

    }
}
