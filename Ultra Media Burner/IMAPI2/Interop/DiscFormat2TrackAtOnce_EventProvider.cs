using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace IMAPI2.Interop
{
	// Token: 0x02000038 RID: 56
	[ClassInterface(ClassInterfaceType.None)]
	internal sealed class DiscFormat2TrackAtOnce_EventProvider : DiscFormat2TrackAtOnce_Event, IDisposable
	{
		// Token: 0x06000086 RID: 134 RVA: 0x000060F4 File Offset: 0x000042F4
		public DiscFormat2TrackAtOnce_EventProvider(object pointContainer)
		{
			lock (this)
			{
				Guid guid = typeof(DDiscFormat2TrackAtOnceEvents).GUID;
				(pointContainer as IConnectionPointContainer).FindConnectionPoint(ref guid, out this.m_connectionPoint);
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000087 RID: 135 RVA: 0x00006158 File Offset: 0x00004358
		// (remove) Token: 0x06000088 RID: 136 RVA: 0x000061B4 File Offset: 0x000043B4
		public event DiscFormat2TrackAtOnce_EventHandler Update
		{
			add
			{
				lock (this)
				{
					DiscFormat2TrackAtOnce_SinkHelper discFormat2TrackAtOnce_SinkHelper = new DiscFormat2TrackAtOnce_SinkHelper(value);
					int num;
					this.m_connectionPoint.Advise(discFormat2TrackAtOnce_SinkHelper, out num);
					discFormat2TrackAtOnce_SinkHelper.Cookie = num;
					this.m_aEventSinkHelpers.Add(discFormat2TrackAtOnce_SinkHelper.UpdateDelegate, discFormat2TrackAtOnce_SinkHelper);
				}
			}
			remove
			{
				lock (this)
				{
					DiscFormat2TrackAtOnce_SinkHelper discFormat2TrackAtOnce_SinkHelper = this.m_aEventSinkHelpers[value] as DiscFormat2TrackAtOnce_SinkHelper;
					if (discFormat2TrackAtOnce_SinkHelper != null)
					{
						this.m_connectionPoint.Unadvise(discFormat2TrackAtOnce_SinkHelper.Cookie);
						this.m_aEventSinkHelpers.Remove(discFormat2TrackAtOnce_SinkHelper.UpdateDelegate);
					}
				}
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000621C File Offset: 0x0000441C
		~DiscFormat2TrackAtOnce_EventProvider()
		{
			this.Cleanup();
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00006248 File Offset: 0x00004448
		public void Dispose()
		{
			this.Cleanup();
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00006258 File Offset: 0x00004458
		private void Cleanup()
		{
			lock (this)
			{
				try
				{
					foreach (object obj in this.m_aEventSinkHelpers.Values)
					{
						DiscFormat2TrackAtOnce_SinkHelper discFormat2TrackAtOnce_SinkHelper = (DiscFormat2TrackAtOnce_SinkHelper)obj;
						this.m_connectionPoint.Unadvise(discFormat2TrackAtOnce_SinkHelper.Cookie);
					}
					this.m_aEventSinkHelpers.Clear();
					Marshal.ReleaseComObject(this.m_connectionPoint);
				}
				catch (SynchronizationLockException)
				{
				}
			}
		}

		// Token: 0x04000152 RID: 338
		private Hashtable m_aEventSinkHelpers = new Hashtable();

		// Token: 0x04000153 RID: 339
		private IConnectionPoint m_connectionPoint;
	}
}
