using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x0200008B RID: 139
	[Guid("2C941FD6-975B-59BE-A960-9A2A262853A5")]
	[CoClass(typeof(EnumProgressItemsClass))]
	[ComImport]
	public interface EnumProgressItems : IEnumProgressItems
	{
	}
}
