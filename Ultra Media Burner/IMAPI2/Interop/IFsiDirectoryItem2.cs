using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000064 RID: 100
	[Guid("F7FB4B9B-6D96-4D7B-9115-201B144811EF")]
	[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	[ComImport]
	public interface IFsiDirectoryItem2 : IFsiDirectoryItem
	{
		// Token: 0x06000279 RID: 633
		[DispId(36)]
		void AddTreeWithNamedStreams(string sourceDirectory, bool includeBaseDirectory);
	}
}
