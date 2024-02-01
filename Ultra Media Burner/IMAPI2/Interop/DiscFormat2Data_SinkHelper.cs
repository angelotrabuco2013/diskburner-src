using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x0200002A RID: 42
	[ClassInterface(ClassInterfaceType.None)]
	[TypeLibType(TypeLibTypeFlags.FHidden)]
	public sealed class DiscFormat2Data_SinkHelper : DDiscFormat2DataEvents
	{
		// Token: 0x06000053 RID: 83 RVA: 0x00005BC8 File Offset: 0x00003DC8
		internal DiscFormat2Data_SinkHelper(DiscFormat2Data_EventHandler eventHandler)
		{
			if (eventHandler == null)
			{
				throw new ArgumentNullException("Delegate (callback function) cannot be null");
			}
			this.m_dwCookie = 0;
			this.m_UpdateDelegate = eventHandler;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00005BEC File Offset: 0x00003DEC
		public void Update(object sender, object args)
		{
			this.m_UpdateDelegate(sender, args);
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00005BFB File Offset: 0x00003DFB
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00005C03 File Offset: 0x00003E03
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

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00005C0C File Offset: 0x00003E0C
		// (set) Token: 0x06000058 RID: 88 RVA: 0x00005C14 File Offset: 0x00003E14
		public DiscFormat2Data_EventHandler UpdateDelegate
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

		// Token: 0x04000148 RID: 328
		private int m_dwCookie;

		// Token: 0x04000149 RID: 329
		private DiscFormat2Data_EventHandler m_UpdateDelegate;
	}
}
