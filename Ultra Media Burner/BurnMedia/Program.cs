using System;
using System.Windows.Forms;

namespace BurnMedia
{
	// Token: 0x02000003 RID: 3
	internal static class Program
	{
		// Token: 0x06000027 RID: 39 RVA: 0x0000550B File Offset: 0x0000370B
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
