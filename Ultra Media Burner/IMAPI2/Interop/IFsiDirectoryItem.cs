using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace IMAPI2.Interop
{
	// Token: 0x02000063 RID: 99
	[Guid("2C941FDC-975B-59BE-A960-9A2A262853A5")]
	[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	public interface IFsiDirectoryItem
	{
		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000263 RID: 611
		[DispId(11)]
		string Name { get; }

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000264 RID: 612
		[DispId(12)]
		string FullPath { get; }

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000265 RID: 613
		// (set) Token: 0x06000266 RID: 614
		[DispId(13)]
		DateTime CreationTime { get; set; }

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000267 RID: 615
		// (set) Token: 0x06000268 RID: 616
		[DispId(14)]
		DateTime LastAccessedTime { get; set; }

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000269 RID: 617
		// (set) Token: 0x0600026A RID: 618
		[DispId(15)]
		DateTime LastModifiedTime { get; set; }

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600026B RID: 619
		// (set) Token: 0x0600026C RID: 620
		[DispId(16)]
		bool IsHidden { get; set; }

		// Token: 0x0600026D RID: 621
		[DispId(17)]
		string FileSystemName(FsiFileSystems fileSystem);

		// Token: 0x0600026E RID: 622
		[DispId(18)]
		string FileSystemPath(FsiFileSystems fileSystem);

		// Token: 0x0600026F RID: 623
		[TypeLibFunc(65)]
		[DispId(-4)]
		IEnumerator GetEnumerator();

		// Token: 0x170000F2 RID: 242
		[DispId(0)]
		IFsiItem this[string path] { get; }

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000271 RID: 625
		[DispId(1)]
		int Count { get; }

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000272 RID: 626
		[DispId(2)]
		IEnumFsiItems EnumFsiItems { get; }

		// Token: 0x06000273 RID: 627
		[DispId(30)]
		void AddDirectory(string path);

		// Token: 0x06000274 RID: 628
		[DispId(31)]
		void AddFile(string path, IStream fileData);

		// Token: 0x06000275 RID: 629
		[DispId(32)]
		void AddTree(string sourceDirectory, bool includeBaseDirectory);

		// Token: 0x06000276 RID: 630
		[DispId(33)]
		void Add(IFsiItem Item);

		// Token: 0x06000277 RID: 631
		[DispId(34)]
		void Remove(string path);

		// Token: 0x06000278 RID: 632
		[DispId(35)]
		void RemoveTree(string path);
	}
}
