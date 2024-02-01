using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000044 RID: 68
	[ClassInterface(ClassInterfaceType.None)]
	[TypeLibType(TypeLibTypeFlags.FHidden)]
	public sealed class DFileSystemImage_SinkHelper : DFileSystemImageEvents
	{
		// Token: 0x060000BF RID: 191 RVA: 0x000068DC File Offset: 0x00004ADC
		public DFileSystemImage_SinkHelper(DFileSystemImage_EventHandler eventHandler)
		{
			if (eventHandler == null)
			{
				throw new ArgumentNullException("Delegate (callback function) cannot be null");
			}
			this.m_dwCookie = 0;
			this.m_UpdateDelegate = eventHandler;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00006900 File Offset: 0x00004B00
		public void Update(object sender, string currentFile, int copiedSectors, int totalSectors)
		{
			this.m_UpdateDelegate(sender, currentFile, copiedSectors, totalSectors);
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00006912 File Offset: 0x00004B12
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x0000691A File Offset: 0x00004B1A
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

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00006923 File Offset: 0x00004B23
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x0000692B File Offset: 0x00004B2B
		public DFileSystemImage_EventHandler UpdateDelegate
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

		// Token: 0x0400015D RID: 349
		private int m_dwCookie;

		// Token: 0x0400015E RID: 350
		private DFileSystemImage_EventHandler m_UpdateDelegate;
	}
}
