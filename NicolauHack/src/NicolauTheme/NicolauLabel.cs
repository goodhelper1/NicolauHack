using System;
using System.Drawing;
using System.Windows.Forms;

namespace NicolauTheme
{
	public class NicolauLabel : Label
	{
		protected override void OnTextChanged(EventArgs e)
		{
			base.OnTextChanged(e);
			Invalidate();
		}

		public NicolauLabel()
		{
			SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			Font = new Font("Segoe UI", 8);
			ForeColor = Color.White;
			BackColor = Color.Transparent;
			Text = Text;
		}
	}
}
