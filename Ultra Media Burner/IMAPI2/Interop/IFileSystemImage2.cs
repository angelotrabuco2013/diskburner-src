using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000060 RID: 96
	[Guid("D7644B2C-1537-4767-B62F-F1387B02DDFD")]
	[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	[ComImport]
	public interface IFileSystemImage2
	{
		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060001F3 RID: 499
		[DispId(0)]
		IFsiDirectoryItem Root { get; }

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060001F4 RID: 500
		// (set) Token: 0x060001F5 RID: 501
		[DispId(1)]
		int SessionStartBlock { get; set; }

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060001F6 RID: 502
		// (set) Token: 0x060001F7 RID: 503
		[DispId(2)]
		int FreeMediaBlocks { get; set; }

		// Token: 0x060001F8 RID: 504
		[DispId(36)]
		void SetMaxMediaBlocksFromDevice(IDiscRecorder2 discRecorder);

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060001F9 RID: 505
		[DispId(3)]
		int UsedBlocks { get; }

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060001FA RID: 506
		// (set) Token: 0x060001FB RID: 507
		[DispId(4)]
		string VolumeName { get; set; }

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060001FC RID: 508
		[DispId(5)]
		string ImportedVolumeName { get; }

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060001FD RID: 509
		// (set) Token: 0x060001FE RID: 510
		[DispId(6)]
		IBootOptions BootImageOptions { get; set; }

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060001FF RID: 511
		[DispId(7)]
		int FileCount { get; }

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000200 RID: 512
		[DispId(8)]
		int DirectoryCount { get; }

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000201 RID: 513
		// (set) Token: 0x06000202 RID: 514
		[DispId(9)]
		string WorkingDirectory { get; set; }

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000203 RID: 515
		[DispId(10)]
		int ChangePoint { get; }

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000204 RID: 516
		// (set) Token: 0x06000205 RID: 517
		[DispId(11)]
		bool StrictFileSystemCompliance { get; set; }

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000206 RID: 518
		// (set) Token: 0x06000207 RID: 519
		[DispId(12)]
		bool UseRestrictedCharacterSet { get; set; }

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000208 RID: 520
		// (set) Token: 0x06000209 RID: 521
		[DispId(13)]
		FsiFileSystems FileSystemsToCreate { get; set; }

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600020A RID: 522
		[DispId(14)]
		FsiFileSystems FileSystemsSupported { get; }

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600020C RID: 524
		// (set) Token: 0x0600020B RID: 523
		[DispId(37)]
		int UDFRevision { get; set; }

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600020D RID: 525
		[DispId(31)]
		object[] UDFRevisionsSupported { get; }

		// Token: 0x0600020E RID: 526
		[DispId(32)]
		void ChooseImageDefaults(IDiscRecorder2 discRecorder);

		// Token: 0x0600020F RID: 527
		[DispId(33)]
		void ChooseImageDefaultsForMediaType(IMAPI_MEDIA_PHYSICAL_TYPE value);

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000211 RID: 529
		// (set) Token: 0x06000210 RID: 528
		[DispId(34)]
		int ISO9660InterchangeLevel { get; set; }

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000212 RID: 530
		[DispId(38)]
		object[] ISO9660InterchangeLevelsSupported { get; }

		// Token: 0x06000213 RID: 531
		[DispId(15)]
		IFileSystemImageResult CreateResultImage();

		// Token: 0x06000214 RID: 532
		[DispId(16)]
		FsiItemType Exists(string FullPath);

		// Token: 0x06000215 RID: 533
		[DispId(18)]
		string CalculateDiscIdentifier();

		// Token: 0x06000216 RID: 534
		[DispId(19)]
		FsiFileSystems IdentifyFileSystemsOnDisc(IDiscRecorder2 discRecorder);

		// Token: 0x06000217 RID: 535
		[DispId(20)]
		FsiFileSystems GetDefaultFileSystemForImport(FsiFileSystems fileSystems);

		// Token: 0x06000218 RID: 536
		[DispId(21)]
		FsiFileSystems ImportFileSystem();

		// Token: 0x06000219 RID: 537
		[DispId(22)]
		void ImportSpecificFileSystem(FsiFileSystems fileSystemToUse);

		// Token: 0x0600021A RID: 538
		[DispId(23)]
		void RollbackToChangePoint(int ChangePoint);

		// Token: 0x0600021B RID: 539
		[DispId(24)]
		void LockInChangePoint();

		// Token: 0x0600021C RID: 540
		[DispId(25)]
		IFsiDirectoryItem CreateDirectoryItem(string Name);

		// Token: 0x0600021D RID: 541
		[DispId(26)]
		IFsiFileItem CreateFileItem(string Name);

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600021E RID: 542
		[DispId(27)]
		string VolumeNameUDF { get; }

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600021F RID: 543
		[DispId(28)]
		string VolumeNameJoliet { get; }

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000220 RID: 544
		[DispId(29)]
		string VolumeNameISO9660 { get; }

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000221 RID: 545
		// (set) Token: 0x06000222 RID: 546
		[DispId(30)]
		bool StageFiles { get; set; }

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000223 RID: 547
		// (set) Token: 0x06000224 RID: 548
		[DispId(40)]
		object[] MultisessionInterfaces { get; set; }

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000225 RID: 549
		// (set) Token: 0x06000226 RID: 550
		[DispId(60)]
		object[] BootImageOptionsArray { get; set; }
	}
}
