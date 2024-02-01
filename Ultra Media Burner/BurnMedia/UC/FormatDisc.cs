using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BurnMedia.UC
{
	// Token: 0x02000007 RID: 7
	public class FormatDisc : UserControl
	{
		// Token: 0x06000032 RID: 50 RVA: 0x0000560E File Offset: 0x0000380E
		public FormatDisc()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000561C File Offset: 0x0000381C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000563B File Offset: 0x0000383B
		private void InitializeComponent()
		{
			this.components = new Container();
			base.AutoScaleMode = AutoScaleMode.Font;
		}

		// Token: 0x0400003B RID: 59
		private IContainer components;
	}
}
