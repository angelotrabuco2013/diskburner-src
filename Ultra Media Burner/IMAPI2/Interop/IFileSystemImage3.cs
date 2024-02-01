using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000061 RID: 97
	[Guid("7CFF842C-7E97-4807-8304-910DD8F7C051")]
	[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	[ComImport]
	public interface IFileSystemImage3
	{
		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000227 RID: 551
		[DispId(0)]
		IFsiDirectoryItem Root { get; }

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000228 RID: 552
		// (set) Token: 0x06000229 RID: 553
		[DispId(1)]
		int SessionStartBlock { get; set; }

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600022A RID: 554
		// (set) Token: 0x0600022B RID: 555
		[DispId(2)]
		int FreeMediaBlocks { get; set; }

		// Token: 0x0600022C RID: 556
		[DispId(36)]
		void SetMaxMediaBlocksFromDevice(IDiscRecorder2 discRecorder);

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600022D RID: 557
		[DispId(3)]
		int UsedBlocks { get; }

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600022E RID: 558
		// (set) Token: 0x0600022F RID: 559
		[DispId(4)]
		string VolumeName { get; set; }

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000230 RID: 560
		[DispId(5)]
		string ImportedVolumeName { get; }

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000231 RID: 561
		// (set) Token: 0x06000232 RID: 562
		[DispId(6)]
		IBootOptions BootImageOptions { get; set; }

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000233 RID: 563
		[DispId(7)]
		int FileCount { get; }

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000234 RID: 564
		[DispId(8)]
		int DirectoryCount { get; }

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000235 RID: 565
		// (set) Token: 0x06000236 RID: 566
		[DispId(9)]
		string WorkingDirectory { get; set; }

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000237 RID: 567
		[DispId(10)]
		int ChangePoint { get; }

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000238 RID: 568
		// (set) Token: 0x06000239 RID: 569
		[DispId(11)]
		bool StrictFileSystemCompliance { get; set; }

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600023A RID: 570
		// (set) Token: 0x0600023B RID: 571
		[DispId(12)]
		bool UseRestrictedCharacterSet { get; set; }

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600023C RID: 572
		// (set) Token: 0x0600023D RID: 573
		[DispId(13)]
		FsiFileSystems FileSystemsToCreate { get; set; }

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600023E RID: 574
		[DispId(14)]
		FsiFileSystems FileSystemsSupported { get; }

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000240 RID: 576
		// (set) Token: 0x0600023F RID: 575
		[DispId(37)]
		int UDFRevision { get; set; }

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000241 RID: 577
		[DispId(31)]
		object[] UDFRevisionsSupported { get; }

		// Token: 0x06000242 RID: 578
		[DispId(32)]
		void ChooseImageDefaults(IDiscRecorder2 discRecorder);

		// Token: 0x06000243 RID: 579
		[DispId(33)]
		void ChooseImageDefaultsForMediaType(IMAPI_MEDIA_PHYSICAL_TYPE value);

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000245 RID: 581
		// (set) Token: 0x06000244 RID: 580
		[DispId(34)]
		int ISO9660InterchangeLevel { get; set; }

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000246 RID: 582
		[DispId(38)]
		object[] ISO9660InterchangeLevelsSupported { get; }

		// Token: 0x06000247 RID: 583
		[DispId(15)]
		IFileSystemImageResult CreateResultImage();

		// Token: 0x06000248 RID: 584
		[DispId(16)]
		FsiItemType Exists(string FullPath);

		// Token: 0x06000249 RID: 585
		[DispId(18)]
		string CalculateDiscIdentifier();

		// Token: 0x0600024A RID: 586
		[DispId(19)]
		FsiFileSystems IdentifyFileSystemsOnDisc(IDiscRecorder2 discRecorder);

		// Token: 0x0600024B RID: 587
		[DispId(20)]
		FsiFileSystems GetDefaultFileSystemForImport(FsiFileSystems fileSystems);

		// Token: 0x0600024C RID: 588
		[DispId(21)]
		FsiFileSystems ImportFileSystem();

		// Token: 0x0600024D RID: 589
		[DispId(22)]
		void ImportSpecificFileSystem(FsiFileSystems fileSystemToUse);

		// Token: 0x0600024E RID: 590
		[DispId(23)]
		void RollbackToChangePoint(int ChangePoint);

		// Token: 0x0600024F RID: 591
		[DispId(24)]
		void LockInChangePoint();

		// Token: 0x06000250 RID: 592
		[DispId(25)]
		IFsiDirectoryItem CreateDirectoryItem(string Name);

		// Token: 0x06000251 RID: 593
		[DispId(26)]
		IFsiFileItem CreateFileItem(string Name);

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000252 RID: 594
		[DispId(27)]
		string VolumeNameUDF { get; }

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000253 RID: 595
		[DispId(28)]
		string VolumeNameJoliet { get; }

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000254 RID: 596
		[DispId(29)]
		string VolumeNameISO9660 { get; }

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000255 RID: 597
		// (set) Token: 0x06000256 RID: 598
		[DispId(30)]
		bool StageFiles { get; set; }

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000257 RID: 599
		// (set) Token: 0x06000258 RID: 600
		[DispId(40)]
		object[] MultisessionInterfaces { get; set; }

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000259 RID: 601
		// (set) Token: 0x0600025A RID: 602
		[DispId(60)]
		object[] BootImageOptionsArray { get; set; }

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600025B RID: 603
		// (set) Token: 0x0600025C RID: 604
		[DispId(61)]
		bool CreateRedundantUdfMetadataFiles { get; set; }

		// Token: 0x0600025D RID: 605
		[DispId(70)]
		bool ProbeSpecificFileSystem(FsiFileSystems fileSystemToProbe);
	}
}
