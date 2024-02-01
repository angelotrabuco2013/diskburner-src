using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x0200004E RID: 78
	[TypeLibType(TypeLibTypeFlags.FHidden)]
	[ClassInterface(ClassInterfaceType.None)]
	public sealed class DWriteEngine2_SinkHelper : DWriteEngine2Events
	{
		// Token: 0x060000E5 RID: 229 RVA: 0x00006DB4 File Offset: 0x00004FB4
		public DWriteEngine2_SinkHelper(DWriteEngine2_EventHandler eventHandler)
		{
			if (eventHandler == null)
			{
				throw new ArgumentNullException("Delegate (callback function) cannot be null");
			}
			this.m_dwCookie = 0;
			this.m_UpdateDelegate = eventHandler;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00006DD8 File Offset: 0x00004FD8
		public void Update(object sender, object progress)
		{
			this.m_UpdateDelegate(sender, progress);
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00006DE7 File Offset: 0x00004FE7
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x00006DEF File Offset: 0x00004FEF
		public int Cookie
		{
			get
			{
				return this.m_dwCookie;
			}
			set
			{
				this.m_dwCookie = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00006DF8 File Offset: 0x00004FF8
		// (set) Token: 0x060000EA RID: 234 RVA: 0x00006E00 File Offset: 0x00005000
		public DWriteEngine2_EventHandler UpdateDelegate
		{
			get
			{
				return this.m_UpdateDelegate;
			}
			set
			{
				this.m_UpdateDelegate = value;
			}
		}

		// Token: 0x04000165 RID: 357
		private int m_dwCookie;

		// Token: 0x04000166 RID: 358
		private DWriteEngine2_EventHandler m_UpdateDelegate;
	}
}
