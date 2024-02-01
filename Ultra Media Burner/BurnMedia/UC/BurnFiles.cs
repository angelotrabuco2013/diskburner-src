using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BurnMedia.UC
{
	// Token: 0x02000006 RID: 6
	public class BurnFiles : UserControl
	{
		// Token: 0x0600002F RID: 47 RVA: 0x0000558A File Offset: 0x0000378A
		public BurnFiles()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00005598 File Offset: 0x00003798
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000055B8 File Offset: 0x000037B8
		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Name = "BurnFiles";
			base.Size = new Size(454, 343);
			base.ResumeLayout(false);
		}

		// Token: 0x0400003A RID: 58
		private IContainer components;
	}
}
