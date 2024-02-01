using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000049 RID: 73
	[TypeLibType(TypeLibTypeFlags.FHidden)]
	[ClassInterface(ClassInterfaceType.None)]
	public sealed class DFileSystemImageImport_SinkHelper : DFileSystemImageImportEvents
	{
		// Token: 0x060000D2 RID: 210 RVA: 0x00006B44 File Offset: 0x00004D44
		public DFileSystemImageImport_SinkHelper(DFileSystemImageImport_EventHandler eventHandler)
		{
			if (eventHandler == null)
			{
				throw new ArgumentNullException("Delegate (callback function) cannot be null");
			}
			this.m_dwCookie = 0;
			this.m_UpdateDelegate = eventHandler;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00006B68 File Offset: 0x00004D68
		public void UpdateImport(object sender, FsiFileSystems fileSystems, string currentItem, int importedDirectoryItems, int totalDirectoryItems, int importedFileItems, int totalFileItems)
		{
			this.m_UpdateDelegate(sender, fileSystems, currentItem, importedDirectoryItems, totalDirectoryItems, importedFileItems, totalFileItems);
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00006B80 File Offset: 0x00004D80
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x00006B88 File Offset: 0x00004D88
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

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00006B91 File Offset: 0x00004D91
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x00006B99 File Offset: 0x00004D99
		public DFileSystemImageImport_EventHandler UpdateDelegate
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

		// Token: 0x04000161 RID: 353
		private int m_dwCookie;

		// Token: 0x04000162 RID: 354
		private DFileSystemImageImport_EventHandler m_UpdateDelegate;
	}
}
