using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x0200002F RID: 47
	[TypeLibType(TypeLibTypeFlags.FHidden)]
	[ClassInterface(ClassInterfaceType.None)]
	public sealed class DiscFormat2Erase_SinkHelper : DDiscFormat2EraseEvents
	{
		// Token: 0x06000066 RID: 102 RVA: 0x00005E34 File Offset: 0x00004034
		public DiscFormat2Erase_SinkHelper(DiscFormat2Erase_EventHandler eventHandler)
		{
			if (eventHandler == null)
			{
				throw new ArgumentNullException("Delegate (callback function) cannot be null");
			}
			this.m_dwCookie = 0;
			this.m_UpdateDelegate = eventHandler;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00005E58 File Offset: 0x00004058
		public void Update(object sender, int elapsedSeconds, int estimatedTotalSeconds)
		{
			this.m_UpdateDelegate(sender, elapsedSeconds, estimatedTotalSeconds);
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00005E68 File Offset: 0x00004068
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00005E70 File Offset: 0x00004070
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

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00005E79 File Offset: 0x00004079
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00005E81 File Offset: 0x00004081
		public DiscFormat2Erase_EventHandler UpdateDelegate
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

		// Token: 0x0400014C RID: 332
		private int m_dwCookie;

		// Token: 0x0400014D RID: 333
		private DiscFormat2Erase_EventHandler m_UpdateDelegate;
	}
}
