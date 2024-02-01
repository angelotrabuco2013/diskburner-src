using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000034 RID: 52
	[ClassInterface(ClassInterfaceType.None)]
	[TypeLibType(TypeLibTypeFlags.FHidden)]
	public sealed class DiscFormat2RawCD_SinkHelper : DDiscFormat2RawCDEvents
	{
		// Token: 0x06000079 RID: 121 RVA: 0x0000609C File Offset: 0x0000429C
		public DiscFormat2RawCD_SinkHelper(DiscFormat2RawCD_EventHandler eventHandler)
		{
			if (eventHandler == null)
			{
				throw new ArgumentNullException("Delegate (callback function) cannot be null");
			}
			this.m_dwCookie = 0;
			this.m_UpdateDelegate = eventHandler;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000060C0 File Offset: 0x000042C0
		public void Update(object sender, object progress)
		{
			this.m_UpdateDelegate(sender, progress);
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600007B RID: 123 RVA: 0x000060CF File Offset: 0x000042CF
		// (set) Token: 0x0600007C RID: 124 RVA: 0x000060D7 File Offset: 0x000042D7
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

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600007D RID: 125 RVA: 0x000060E0 File Offset: 0x000042E0
		// (set) Token: 0x0600007E RID: 126 RVA: 0x000060E8 File Offset: 0x000042E8
		public DiscFormat2RawCD_EventHandler UpdateDelegate
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

		// Token: 0x04000150 RID: 336
		private int m_dwCookie;

		// Token: 0x04000151 RID: 337
		private DiscFormat2RawCD_EventHandler m_UpdateDelegate;
	}
}
