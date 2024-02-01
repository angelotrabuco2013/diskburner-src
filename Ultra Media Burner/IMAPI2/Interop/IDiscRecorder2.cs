using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x0200005B RID: 91
	[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	[Guid("27354133-7F64-5B0F-8F00-5D77AFBE261E")]
	[ComImport]
	public interface IDiscRecorder2
	{
		// Token: 0x06000190 RID: 400
		[DispId(256)]
		void EjectMedia();

		// Token: 0x06000191 RID: 401
		[DispId(257)]
		void CloseTray();

		// Token: 0x06000192 RID: 402
		[DispId(258)]
		void AcquireExclusiveAccess(bool force, string clientName);

		// Token: 0x06000193 RID: 403
		[DispId(259)]
		void ReleaseExclusiveAccess();

		// Token: 0x06000194 RID: 404
		[DispId(260)]
		void DisableMcn();

		// Token: 0x06000195 RID: 405
		[DispId(261)]
		void EnableMcn();

		// Token: 0x06000196 RID: 406
		[DispId(262)]
		void InitializeDiscRecorder(string recorderUniqueId);

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000197 RID: 407
		[DispId(0)]
		string ActiveDiscRecorder { get; }

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000198 RID: 408
		[DispId(513)]
		string VendorId { get; }

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000199 RID: 409
		[DispId(514)]
		string ProductId { get; }

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600019A RID: 410
		[DispId(515)]
		string ProductRevision { get; }

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600019B RID: 411
		[DispId(516)]
		string VolumeName { get; }

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600019C RID: 412
		[DispId(517)]
		object[] VolumePathNames
		{
			[DispId(517)]
			get;
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600019D RID: 413
		[DispId(518)]
		bool DeviceCanLoadMedia
		{
			[DispId(518)]
			get;
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600019E RID: 414
		[DispId(519)]
		int LegacyDeviceNumber
		{
			[DispId(519)]
			get;
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600019F RID: 415
		[DispId(520)]
		object[] SupportedFeaturePages
		{
			[DispId(520)]
			get;
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001A0 RID: 416
		[DispId(521)]
		object[] CurrentFeaturePages
		{
			[DispId(521)]
			get;
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001A1 RID: 417
		[DispId(522)]
		object[] SupportedProfiles
		{
			[DispId(522)]
			get;
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001A2 RID: 418
		[DispId(523)]
		object[] CurrentProfiles
		{
			[DispId(523)]
			get;
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001A3 RID: 419
		[DispId(524)]
		object[] SupportedModePages
		{
			[DispId(524)]
			get;
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001A4 RID: 420
		[DispId(525)]
		string ExclusiveAccessOwner
		{
			[DispId(525)]
			get;
		}
	}
}
