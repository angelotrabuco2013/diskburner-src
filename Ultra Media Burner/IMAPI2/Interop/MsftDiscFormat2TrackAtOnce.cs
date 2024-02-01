using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000079 RID: 121
	[Guid("27354154-8F64-5B0F-8F00-5D77AFBE261E")]
	[CoClass(typeof(MsftDiscFormat2TrackAtOnceClass))]
	[ComImport]
	public interface MsftDiscFormat2TrackAtOnce : IDiscFormat2TrackAtOnce, DiscFormat2TrackAtOnce_Event
	{
	}
}
