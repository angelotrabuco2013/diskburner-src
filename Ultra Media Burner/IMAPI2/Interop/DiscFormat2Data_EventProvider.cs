using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace IMAPI2.Interop
{
	// Token: 0x02000029 RID: 41
	[ClassInterface(ClassInterfaceType.None)]
	internal sealed class DiscFormat2Data_EventProvider : DiscFormat2Data_Event, IDisposable
	{
		// Token: 0x0600004D RID: 77 RVA: 0x000059B8 File Offset: 0x00003BB8
		public DiscFormat2Data_EventProvider(object pointContainer)
		{
			lock (this)
			{
				Guid guid = typeof(DDiscFormat2DataEvents).GUID;
				(pointContainer as IConnectionPointContainer).FindConnectionPoint(ref guid, out this.m_connectionPoint);
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600004E RID: 78 RVA: 0x00005A1C File Offset: 0x00003C1C
		// (remove) Token: 0x0600004F RID: 79 RVA: 0x00005A78 File Offset: 0x00003C78
		public event DiscFormat2Data_EventHandler Update
		{
			add
			{
				lock (this)
				{
					DiscFormat2Data_SinkHelper discFormat2Data_SinkHelper = new DiscFormat2Data_SinkHelper(value);
					int num;
					this.m_connectionPoint.Advise(discFormat2Data_SinkHelper, out num);
					discFormat2Data_SinkHelper.Cookie = num;
					this.m_aEventSinkHelpers.Add(discFormat2Data_SinkHelper.UpdateDelegate, discFormat2Data_SinkHelper);
				}
			}
			remove
			{
				lock (this)
				{
					DiscFormat2Data_SinkHelper discFormat2Data_SinkHelper = this.m_aEventSinkHelpers[value] as DiscFormat2Data_SinkHelper;
					if (discFormat2Data_SinkHelper != null)
					{
						this.m_connectionPoint.Unadvise(discFormat2Data_SinkHelper.Cookie);
						this.m_aEventSinkHelpers.Remove(discFormat2Data_SinkHelper.UpdateDelegate);
					}
				}
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00005AE0 File Offset: 0x00003CE0
		~DiscFormat2Data_EventProvider()
		{
			this.Cleanup();
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00005B0C File Offset: 0x00003D0C
		public void Dispose()
		{
			this.Cleanup();
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00005B1C File Offset: 0x00003D1C
		private void Cleanup()
		{
			lock (this)
			{
				try
				{
					foreach (object obj in this.m_aEventSinkHelpers.Values)
					{
						DiscFormat2Data_SinkHelper discFormat2Data_SinkHelper = (DiscFormat2Data_SinkHelper)obj;
						this.m_connectionPoint.Unadvise(discFormat2Data_SinkHelper.Cookie);
					}
					this.m_aEventSinkHelpers.Clear();
					Marshal.ReleaseComObject(this.m_connectionPoint);
				}
				catch (SynchronizationLockException)
				{
				}
			}
		}

		// Token: 0x04000146 RID: 326
		private Hashtable m_aEventSinkHelpers = new Hashtable();

		// Token: 0x04000147 RID: 327
		private IConnectionPoint m_connectionPoint;
	}
}
