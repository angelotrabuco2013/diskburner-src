using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000093 RID: 147
	[Guid("ED79BA56-5294-4250-8D46-F9AECEE23459")]
	[CoClass(typeof(FsiNamedStreamsClass))]
	[ComImport]
	public interface FsiNamedStreams : IFsiNamedStreams, IEnumerable
	{
	}
}
