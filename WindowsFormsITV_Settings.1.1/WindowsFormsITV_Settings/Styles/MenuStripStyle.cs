using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsITV_Settings.Styles
{
    public class MenuStripStyle : ToolStripProfessionalRenderer
    {
	   protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
	   {
		  if (e.Item.Selected)
		  {
			 using (Brush b = new SolidBrush(ProfessionalColors.SeparatorLight))
			 {
				e.Graphics.FillEllipse(b, e.Item.ContentRectangle);
			 }
		  }
		  else
		  {
			 using (Pen p = new Pen(ProfessionalColors.SeparatorLight))
			 {
				e.Graphics.DrawEllipse(p, e.Item.ContentRectangle);
			 }
		  }
	   }

	   protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
	   {
		  Rectangle r = Rectangle.Inflate(e.Item.ContentRectangle, -2, -2);

		  if (e.Item.Selected)
		  {
			 using (Brush b = new SolidBrush(ProfessionalColors.SeparatorLight))
			 {
				e.Graphics.FillRectangle(b, r);
			 }
		  }
		  else
		  {
			 using (Pen p = new Pen(ProfessionalColors.SeparatorLight))
			 {
				e.Graphics.DrawRectangle(p, r);
			 }
		  }
	   }
    }

}
