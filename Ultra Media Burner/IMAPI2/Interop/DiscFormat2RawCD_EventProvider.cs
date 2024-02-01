using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace IMAPI2.Interop
{
	// Token: 0x02000033 RID: 51
	[ClassInterface(ClassInterfaceType.None)]
	internal sealed class DiscFormat2RawCD_EventProvider : DiscFormat2RawCD_Event, IDisposable
	{
		// Token: 0x06000073 RID: 115 RVA: 0x00005E8C File Offset: 0x0000408C
		public DiscFormat2RawCD_EventProvider(object pointContainer)
		{
			lock (this)
			{
				Guid guid = typeof(DDiscFormat2RawCDEvents).GUID;
				(pointContainer as IConnectionPointContainer).FindConnectionPoint(ref guid, out this.m_connectionPoint);
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000074 RID: 116 RVA: 0x00005EF0 File Offset: 0x000040F0
		// (remove) Token: 0x06000075 RID: 117 RVA: 0x00005F4C File Offset: 0x0000414C
		public event DiscFormat2RawCD_EventHandler Update
		{
			add
			{
				lock (this)
				{
					DiscFormat2RawCD_SinkHelper discFormat2RawCD_SinkHelper = new DiscFormat2RawCD_SinkHelper(value);
					int num;
					this.m_connectionPoint.Advise(discFormat2RawCD_SinkHelper, out num);
					discFormat2RawCD_SinkHelper.Cookie = num;
					this.m_aEventSinkHelpers.Add(discFormat2RawCD_SinkHelper.UpdateDelegate, discFormat2RawCD_SinkHelper);
				}
			}
			remove
			{
				lock (this)
				{
					DiscFormat2RawCD_SinkHelper discFormat2RawCD_SinkHelper = this.m_aEventSinkHelpers[value] as DiscFormat2RawCD_SinkHelper;
					if (discFormat2RawCD_SinkHelper != null)
					{
						this.m_connectionPoint.Unadvise(discFormat2RawCD_SinkHelper.Cookie);
						this.m_aEventSinkHelpers.Remove(discFormat2RawCD_SinkHelper.UpdateDelegate);
					}
				}
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00005FB4 File Offset: 0x000041B4
		~DiscFormat2RawCD_EventProvider()
		{
			this.Cleanup();
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00005FE0 File Offset: 0x000041E0
		public void Dispose()
		{
			this.Cleanup();
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00005FF0 File Offset: 0x000041F0
		private void Cleanup()
		{
			lock (this)
			{
				try
				{
					foreach (object obj in this.m_aEventSinkHelpers.Values)
					{
						DiscFormat2RawCD_SinkHelper discFormat2RawCD_SinkHelper = (DiscFormat2RawCD_SinkHelper)obj;
						this.m_connectionPoint.Unadvise(discFormat2RawCD_SinkHelper.Cookie);
					}
					this.m_aEventSinkHelpers.Clear();
					Marshal.ReleaseComObject(this.m_connectionPoint);
				}
				catch (SynchronizationLockException)
				{
				}
			}
		}

		// Token: 0x0400014E RID: 334
		private Hashtable m_aEventSinkHelpers = new Hashtable();

		// Token: 0x0400014F RID: 335
		private IConnectionPoint m_connectionPoint;
	}
}
