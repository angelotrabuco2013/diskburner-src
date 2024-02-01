using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace IMAPI2.Interop
{
	// Token: 0x02000043 RID: 67
	[ClassInterface(ClassInterfaceType.None)]
	internal sealed class DFileSystemImage_EventProvider : DFileSystemImage_Event, IDisposable
	{
		// Token: 0x060000B9 RID: 185 RVA: 0x000066CC File Offset: 0x000048CC
		public DFileSystemImage_EventProvider(object pointContainer)
		{
			lock (this)
			{
				Guid guid = typeof(DFileSystemImageEvents).GUID;
				(pointContainer as IConnectionPointContainer).FindConnectionPoint(ref guid, out this.m_connectionPoint);
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x060000BA RID: 186 RVA: 0x00006730 File Offset: 0x00004930
		// (remove) Token: 0x060000BB RID: 187 RVA: 0x0000678C File Offset: 0x0000498C
		public event DFileSystemImage_EventHandler Update
		{
			add
			{
				lock (this)
				{
					DFileSystemImage_SinkHelper dfileSystemImage_SinkHelper = new DFileSystemImage_SinkHelper(value);
					int num;
					this.m_connectionPoint.Advise(dfileSystemImage_SinkHelper, out num);
					dfileSystemImage_SinkHelper.Cookie = num;
					this.m_aEventSinkHelpers.Add(dfileSystemImage_SinkHelper.UpdateDelegate, dfileSystemImage_SinkHelper);
				}
			}
			remove
			{
				lock (this)
				{
					DFileSystemImage_SinkHelper dfileSystemImage_SinkHelper = this.m_aEventSinkHelpers[value] as DFileSystemImage_SinkHelper;
					if (dfileSystemImage_SinkHelper != null)
					{
						this.m_connectionPoint.Unadvise(dfileSystemImage_SinkHelper.Cookie);
						this.m_aEventSinkHelpers.Remove(dfileSystemImage_SinkHelper.UpdateDelegate);
					}
				}
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000067F4 File Offset: 0x000049F4
		~DFileSystemImage_EventProvider()
		{
			this.Cleanup();
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00006820 File Offset: 0x00004A20
		public void Dispose()
		{
			this.Cleanup();
			GC.SuppressFinalize(this);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00006830 File Offset: 0x00004A30
		private void Cleanup()
		{
			lock (this)
			{
				try
				{
					foreach (object obj in this.m_aEventSinkHelpers.Values)
					{
						DFileSystemImage_SinkHelper dfileSystemImage_SinkHelper = (DFileSystemImage_SinkHelper)obj;
						this.m_connectionPoint.Unadvise(dfileSystemImage_SinkHelper.Cookie);
					}
					this.m_aEventSinkHelpers.Clear();
					Marshal.ReleaseComObject(this.m_connectionPoint);
				}
				catch (SynchronizationLockException)
				{
				}
			}
		}

		// Token: 0x0400015B RID: 347
		private Hashtable m_aEventSinkHelpers = new Hashtable();

		// Token: 0x0400015C RID: 348
		private IConnectionPoint m_connectionPoint;
	}
}
