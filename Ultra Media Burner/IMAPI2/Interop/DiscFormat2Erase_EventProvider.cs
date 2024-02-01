using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace IMAPI2.Interop
{
	// Token: 0x0200002E RID: 46
	[ClassInterface(ClassInterfaceType.None)]
	internal sealed class DiscFormat2Erase_EventProvider : DiscFormat2Erase_Event, IDisposable
	{
		// Token: 0x06000060 RID: 96 RVA: 0x00005C20 File Offset: 0x00003E20
		public DiscFormat2Erase_EventProvider(object pointContainer)
		{
			lock (this)
			{
				Guid guid = typeof(DDiscFormat2EraseEvents).GUID;
				(pointContainer as IConnectionPointContainer).FindConnectionPoint(ref guid, out this.m_connectionPoint);
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000061 RID: 97 RVA: 0x00005C84 File Offset: 0x00003E84
		// (remove) Token: 0x06000062 RID: 98 RVA: 0x00005CE4 File Offset: 0x00003EE4
		public event DiscFormat2Erase_EventHandler Update
		{
			add
			{
				lock (this)
				{
					DiscFormat2Erase_SinkHelper discFormat2Erase_SinkHelper = new DiscFormat2Erase_SinkHelper(value);
					int num = -1;
					this.m_connectionPoint.Advise(discFormat2Erase_SinkHelper, out num);
					discFormat2Erase_SinkHelper.Cookie = num;
					this.m_aEventSinkHelpers.Add(discFormat2Erase_SinkHelper.UpdateDelegate, discFormat2Erase_SinkHelper);
				}
			}
			remove
			{
				lock (this)
				{
					DiscFormat2Erase_SinkHelper discFormat2Erase_SinkHelper = this.m_aEventSinkHelpers[value] as DiscFormat2Erase_SinkHelper;
					if (discFormat2Erase_SinkHelper != null)
					{
						this.m_connectionPoint.Unadvise(discFormat2Erase_SinkHelper.Cookie);
						this.m_aEventSinkHelpers.Remove(discFormat2Erase_SinkHelper.UpdateDelegate);
					}
				}
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00005D4C File Offset: 0x00003F4C
		~DiscFormat2Erase_EventProvider()
		{
			this.Cleanup();
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00005D78 File Offset: 0x00003F78
		public void Dispose()
		{
			this.Cleanup();
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00005D88 File Offset: 0x00003F88
		private void Cleanup()
		{
			lock (this)
			{
				try
				{
					foreach (object obj in this.m_aEventSinkHelpers.Values)
					{
						DiscFormat2Erase_SinkHelper discFormat2Erase_SinkHelper = (DiscFormat2Erase_SinkHelper)obj;
						this.m_connectionPoint.Unadvise(discFormat2Erase_SinkHelper.Cookie);
					}
					this.m_aEventSinkHelpers.Clear();
					Marshal.ReleaseComObject(this.m_connectionPoint);
				}
				catch (SynchronizationLockException)
				{
				}
			}
		}

		// Token: 0x0400014A RID: 330
		private Hashtable m_aEventSinkHelpers = new Hashtable();

		// Token: 0x0400014B RID: 331
		private IConnectionPoint m_connectionPoint;
	}
}
