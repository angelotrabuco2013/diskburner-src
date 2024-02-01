using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000040 RID: 64
	[ClassInterface(ClassInterfaceType.None)]
	[TypeLibType(TypeLibTypeFlags.FHidden)]
	public sealed class DiscMaster2_SinkHelper : DDiscMaster2Events
	{
		// Token: 0x060000AC RID: 172 RVA: 0x00006630 File Offset: 0x00004830
		public DiscMaster2_SinkHelper(DiscMaster2_NotifyDeviceAddedEventHandler eventHandler)
		{
			if (eventHandler == null)
			{
				throw new ArgumentNullException("Delegate (callback function) cannot be null");
			}
			this.m_dwCookie = 0;
			this.m_AddedDelegate = eventHandler;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00006654 File Offset: 0x00004854
		public DiscMaster2_SinkHelper(DiscMaster2_NotifyDeviceRemovedEventHandler eventHandler)
		{
			if (eventHandler == null)
			{
				throw new ArgumentNullException("Delegate (callback function) cannot be null");
			}
			this.m_dwCookie = 0;
			this.m_RemovedDelegate = eventHandler;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00006678 File Offset: 0x00004878
		public void NotifyDeviceAdded(object sender, string uniqueId)
		{
			this.m_AddedDelegate(sender, uniqueId);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00006687 File Offset: 0x00004887
		public void NotifyDeviceRemoved(object sender, string uniqueId)
		{
			this.m_RemovedDelegate(sender, uniqueId);
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00006696 File Offset: 0x00004896
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x0000669E File Offset: 0x0000489E
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

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x000066A7 File Offset: 0x000048A7
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x000066AF File Offset: 0x000048AF
		public DiscMaster2_NotifyDeviceAddedEventHandler NotifyDeviceAddedDelegate
		{
			get
			{
				return this.m_AddedDelegate;
			}
			set
			{
				this.m_AddedDelegate = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x000066B8 File Offset: 0x000048B8
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x000066C0 File Offset: 0x000048C0
		public DiscMaster2_NotifyDeviceRemovedEventHandler NotifyDeviceRemovedDelegate
		{
			get
			{
				return this.m_RemovedDelegate;
			}
			set
			{
				this.m_RemovedDelegate = value;
			}
		}

		// Token: 0x04000158 RID: 344
		private int m_dwCookie;

		// Token: 0x04000159 RID: 345
		private DiscMaster2_NotifyDeviceAddedEventHandler m_AddedDelegate;

		// Token: 0x0400015A RID: 346
		private DiscMaster2_NotifyDeviceRemovedEventHandler m_RemovedDelegate;
	}
}
