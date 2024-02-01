using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace IMAPI2.Interop
{
	// Token: 0x0200003D RID: 61
	[ClassInterface(ClassInterfaceType.None)]
	internal sealed class DiscMaster2_EventProvider : DiscMaster2_Event, IDisposable
	{
		// Token: 0x0600009C RID: 156 RVA: 0x0000635C File Offset: 0x0000455C
		public DiscMaster2_EventProvider(object pointContainer)
		{
			lock (this)
			{
				Guid guid = typeof(DDiscMaster2Events).GUID;
				(pointContainer as IConnectionPointContainer).FindConnectionPoint(ref guid, out this.m_connectionPoint);
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x0600009D RID: 157 RVA: 0x000063C0 File Offset: 0x000045C0
		// (remove) Token: 0x0600009E RID: 158 RVA: 0x0000641C File Offset: 0x0000461C
		public event DiscMaster2_NotifyDeviceAddedEventHandler NotifyDeviceAdded
		{
			add
			{
				lock (this)
				{
					DiscMaster2_SinkHelper discMaster2_SinkHelper = new DiscMaster2_SinkHelper(value);
					int num;
					this.m_connectionPoint.Advise(discMaster2_SinkHelper, out num);
					discMaster2_SinkHelper.Cookie = num;
					this.m_aEventSinkHelpers.Add(discMaster2_SinkHelper.NotifyDeviceAddedDelegate, discMaster2_SinkHelper);
				}
			}
			remove
			{
				lock (this)
				{
					DiscMaster2_SinkHelper discMaster2_SinkHelper = this.m_aEventSinkHelpers[value] as DiscMaster2_SinkHelper;
					if (discMaster2_SinkHelper != null)
					{
						this.m_connectionPoint.Unadvise(discMaster2_SinkHelper.Cookie);
						this.m_aEventSinkHelpers.Remove(discMaster2_SinkHelper.NotifyDeviceAddedDelegate);
					}
				}
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x0600009F RID: 159 RVA: 0x00006484 File Offset: 0x00004684
		// (remove) Token: 0x060000A0 RID: 160 RVA: 0x000064E0 File Offset: 0x000046E0
		public event DiscMaster2_NotifyDeviceRemovedEventHandler NotifyDeviceRemoved
		{
			add
			{
				lock (this)
				{
					DiscMaster2_SinkHelper discMaster2_SinkHelper = new DiscMaster2_SinkHelper(value);
					int num;
					this.m_connectionPoint.Advise(discMaster2_SinkHelper, out num);
					discMaster2_SinkHelper.Cookie = num;
					this.m_aEventSinkHelpers.Add(discMaster2_SinkHelper.NotifyDeviceRemovedDelegate, discMaster2_SinkHelper);
				}
			}
			remove
			{
				lock (this)
				{
					DiscMaster2_SinkHelper discMaster2_SinkHelper = this.m_aEventSinkHelpers[value] as DiscMaster2_SinkHelper;
					if (discMaster2_SinkHelper != null)
					{
						this.m_connectionPoint.Unadvise(discMaster2_SinkHelper.Cookie);
						this.m_aEventSinkHelpers.Remove(discMaster2_SinkHelper.NotifyDeviceRemovedDelegate);
					}
				}
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00006548 File Offset: 0x00004748
		~DiscMaster2_EventProvider()
		{
			this.Cleanup();
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00006574 File Offset: 0x00004774
		public void Dispose()
		{
			this.Cleanup();
			GC.SuppressFinalize(this);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00006584 File Offset: 0x00004784
		private void Cleanup()
		{
			lock (this)
			{
				try
				{
					foreach (object obj in this.m_aEventSinkHelpers.Values)
					{
						DiscMaster2_SinkHelper discMaster2_SinkHelper = (DiscMaster2_SinkHelper)obj;
						this.m_connectionPoint.Unadvise(discMaster2_SinkHelper.Cookie);
					}
					this.m_aEventSinkHelpers.Clear();
					Marshal.ReleaseComObject(this.m_connectionPoint);
				}
				catch (SynchronizationLockException)
				{
				}
			}
		}

		// Token: 0x04000156 RID: 342
		private Hashtable m_aEventSinkHelpers = new Hashtable();

		// Token: 0x04000157 RID: 343
		private IConnectionPoint m_connectionPoint;
	}
}
