using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x0200005F RID: 95
	[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	[Guid("2C941FE1-975B-59BE-A960-9A2A262853A5")]
	public interface IFileSystemImage
	{
		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001C1 RID: 449
		[DispId(0)]
		IFsiDirectoryItem Root { get; }

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001C2 RID: 450
		// (set) Token: 0x060001C3 RID: 451
		[DispId(1)]
		int SessionStartBlock { get; set; }

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001C4 RID: 452
		// (set) Token: 0x060001C5 RID: 453
		[DispId(2)]
		int FreeMediaBlocks { get; set; }

		// Token: 0x060001C6 RID: 454
		[DispId(36)]
		void SetMaxMediaBlocksFromDevice(IDiscRecorder2 discRecorder);

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001C7 RID: 455
		[DispId(3)]
		int UsedBlocks { get; }

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001C8 RID: 456
		// (set) Token: 0x060001C9 RID: 457
		[DispId(4)]
		string VolumeName { get; set; }

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001CA RID: 458
		[DispId(5)]
		string ImportedVolumeName { get; }

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001CB RID: 459
		// (set) Token: 0x060001CC RID: 460
		[DispId(6)]
		IBootOptions BootImageOptions { get; set; }

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001CD RID: 461
		[DispId(7)]
		int FileCount { get; }

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060001CE RID: 462
		[DispId(8)]
		int DirectoryCount { get; }

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001CF RID: 463
		// (set) Token: 0x060001D0 RID: 464
		[DispId(9)]
		string WorkingDirectory { get; set; }

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001D1 RID: 465
		[DispId(10)]
		int ChangePoint { get; }

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060001D2 RID: 466
		// (set) Token: 0x060001D3 RID: 467
		[DispId(11)]
		bool StrictFileSystemCompliance { get; set; }

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001D4 RID: 468
		// (set) Token: 0x060001D5 RID: 469
		[DispId(12)]
		bool UseRestrictedCharacterSet { get; set; }

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060001D6 RID: 470
		// (set) Token: 0x060001D7 RID: 471
		[DispId(13)]
		FsiFileSystems FileSystemsToCreate { get; set; }

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060001D8 RID: 472
		[DispId(14)]
		FsiFileSystems FileSystemsSupported { get; }

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060001DA RID: 474
		// (set) Token: 0x060001D9 RID: 473
		[DispId(37)]
		int UDFRevision { get; set; }

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060001DB RID: 475
		[DispId(31)]
		object[] UDFRevisionsSupported { get; }

		// Token: 0x060001DC RID: 476
		[DispId(32)]
		void ChooseImageDefaults(IDiscRecorder2 discRecorder);

		// Token: 0x060001DD RID: 477
		[DispId(33)]
		void ChooseImageDefaultsForMediaType(IMAPI_MEDIA_PHYSICAL_TYPE value);

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001DF RID: 479
		// (set) Token: 0x060001DE RID: 478
		[DispId(34)]
		int ISO9660InterchangeLevel { get; set; }

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060001E0 RID: 480
		[DispId(38)]
		object[] ISO9660InterchangeLevelsSupported { get; }

		// Token: 0x060001E1 RID: 481
		[DispId(15)]
		IFileSystemImageResult CreateResultImage();

		// Token: 0x060001E2 RID: 482
		[DispId(16)]
		FsiItemType Exists(string FullPath);

		// Token: 0x060001E3 RID: 483
		[DispId(18)]
		string CalculateDiscIdentifier();

		// Token: 0x060001E4 RID: 484
		[DispId(19)]
		FsiFileSystems IdentifyFileSystemsOnDisc(IDiscRecorder2 discRecorder);

		// Token: 0x060001E5 RID: 485
		[DispId(20)]
		FsiFileSystems GetDefaultFileSystemForImport(FsiFileSystems fileSystems);

		// Token: 0x060001E6 RID: 486
		[DispId(21)]
		FsiFileSystems ImportFileSystem();

		// Token: 0x060001E7 RID: 487
		[DispId(22)]
		void ImportSpecificFileSystem(FsiFileSystems fileSystemToUse);

		// Token: 0x060001E8 RID: 488
		[DispId(23)]
		void RollbackToChangePoint(int ChangePoint);

		// Token: 0x060001E9 RID: 489
		[DispId(24)]
		void LockInChangePoint();

		// Token: 0x060001EA RID: 490
		[DispId(25)]
		IFsiDirectoryItem CreateDirectoryItem(string Name);

		// Token: 0x060001EB RID: 491
		[DispId(26)]
		IFsiFileItem CreateFileItem(string Name);

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060001EC RID: 492
		[DispId(27)]
		string VolumeNameUDF { get; }

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060001ED RID: 493
		[DispId(28)]
		string VolumeNameJoliet { get; }

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060001EE RID: 494
		[DispId(29)]
		string VolumeNameISO9660 { get; }

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060001EF RID: 495
		// (set) Token: 0x060001F0 RID: 496
		[DispId(30)]
		bool StageFiles { get; set; }

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060001F1 RID: 497
		// (set) Token: 0x060001F2 RID: 498
		[DispId(40)]
		object[] MultisessionInterfaces { get; set; }
	}
}
