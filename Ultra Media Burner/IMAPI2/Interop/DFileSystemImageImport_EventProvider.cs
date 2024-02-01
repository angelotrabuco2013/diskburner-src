using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace IMAPI2.Interop
{
	// Token: 0x02000048 RID: 72
	[ClassInterface(ClassInterfaceType.None)]
	internal sealed class DFileSystemImageImport_EventProvider : DFileSystemImageImport_Event, IDisposable
	{
		// Token: 0x060000CC RID: 204 RVA: 0x00006934 File Offset: 0x00004B34
		public DFileSystemImageImport_EventProvider(object pointContainer)
		{
			lock (this)
			{
				Guid guid = typeof(DFileSystemImageImportEvents).GUID;
				(pointContainer as IConnectionPointContainer).FindConnectionPoint(ref guid, out this.m_connectionPoint);
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x060000CD RID: 205 RVA: 0x00006998 File Offset: 0x00004B98
		// (remove) Token: 0x060000CE RID: 206 RVA: 0x000069F4 File Offset: 0x00004BF4
		public event DFileSystemImageImport_EventHandler UpdateImport
		{
			add
			{
				lock (this)
				{
					DFileSystemImageImport_SinkHelper dfileSystemImageImport_SinkHelper = new DFileSystemImageImport_SinkHelper(value);
					int num;
					this.m_connectionPoint.Advise(dfileSystemImageImport_SinkHelper, out num);
					dfileSystemImageImport_SinkHelper.Cookie = num;
					this.m_aEventSinkHelpers.Add(dfileSystemImageImport_SinkHelper.UpdateDelegate, dfileSystemImageImport_SinkHelper);
				}
			}
			remove
			{
				lock (this)
				{
					DFileSystemImageImport_SinkHelper dfileSystemImageImport_SinkHelper = this.m_aEventSinkHelpers[value] as DFileSystemImageImport_SinkHelper;
					if (dfileSystemImageImport_SinkHelper != null)
					{
						this.m_connectionPoint.Unadvise(dfileSystemImageImport_SinkHelper.Cookie);
						this.m_aEventSinkHelpers.Remove(dfileSystemImageImport_SinkHelper.UpdateDelegate);
					}
				}
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00006A5C File Offset: 0x00004C5C
		~DFileSystemImageImport_EventProvider()
		{
			this.Cleanup();
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00006A88 File Offset: 0x00004C88
		public void Dispose()
		{
			this.Cleanup();
			GC.SuppressFinalize(this);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00006A98 File Offset: 0x00004C98
		private void Cleanup()
		{
			lock (this)
			{
				try
				{
					foreach (object obj in this.m_aEventSinkHelpers.Values)
					{
						DFileSystemImageImport_SinkHelper dfileSystemImageImport_SinkHelper = (DFileSystemImageImport_SinkHelper)obj;
						this.m_connectionPoint.Unadvise(dfileSystemImageImport_SinkHelper.Cookie);
					}
					this.m_aEventSinkHelpers.Clear();
					Marshal.ReleaseComObject(this.m_connectionPoint);
				}
				catch (SynchronizationLockException)
				{
				}
			}
		}

		// Token: 0x0400015F RID: 351
		private Hashtable m_aEventSinkHelpers = new Hashtable();

		// Token: 0x04000160 RID: 352
		private IConnectionPoint m_connectionPoint;
	}
}
