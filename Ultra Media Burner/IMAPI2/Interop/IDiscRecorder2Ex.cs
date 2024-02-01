using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x0200005C RID: 92
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("27354132-7F64-5B0F-8F00-5D77AFBE261E")]
	public interface IDiscRecorder2Ex
	{
		// Token: 0x060001A5 RID: 421
		void SendCommandNoData([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1, SizeParamIndex = 1)] byte[] Cdb, uint CdbSize, [MarshalAs(UnmanagedType.LPArray, SizeConst = 18)] byte[] SenseBuffer, uint Timeout);

		// Token: 0x060001A6 RID: 422
		void SendCommandSendDataToDevice([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1, SizeParamIndex = 1)] byte[] Cdb, uint CdbSize, [MarshalAs(UnmanagedType.LPArray, SizeConst = 18)] byte[] SenseBuffer, uint Timeout, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1, SizeParamIndex = 5)] byte[] Buffer, uint BufferSize);

		// Token: 0x060001A7 RID: 423
		void SendCommandGetDataFromDevice([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1, SizeParamIndex = 1)] byte[] Cdb, uint CdbSize, [MarshalAs(UnmanagedType.LPArray, SizeConst = 18)] byte[] SenseBuffer, uint Timeout, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1, SizeParamIndex = 5)] byte[] Buffer, uint BufferSize, out uint BufferFetched);

		// Token: 0x060001A8 RID: 424
		void ReadDvdStructure(uint format, uint address, uint layer, uint agid, out IntPtr data, out uint Count);

		// Token: 0x060001A9 RID: 425
		void SendDvdStructure(uint format, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1, SizeParamIndex = 2)] byte[] data, uint Count);

		// Token: 0x060001AA RID: 426
		void GetAdapterDescriptor(out IntPtr data, ref uint byteSize);

		// Token: 0x060001AB RID: 427
		void GetDeviceDescriptor(out IntPtr data, ref uint byteSize);

		// Token: 0x060001AC RID: 428
		void GetDiscInformation(out IntPtr discInformation, ref uint byteSize);

		// Token: 0x060001AD RID: 429
		void GetTrackInformation(uint address, IMAPI_READ_TRACK_ADDRESS_TYPE addressType, out IntPtr trackInformation, ref uint byteSize);

		// Token: 0x060001AE RID: 430
		void GetFeaturePage(IMAPI_FEATURE_PAGE_TYPE requestedFeature, sbyte currentFeatureOnly, out IntPtr featureData, ref uint byteSize);

		// Token: 0x060001AF RID: 431
		void GetModePage(IMAPI_MODE_PAGE_TYPE requestedModePage, IMAPI_MODE_PAGE_REQUEST_TYPE requestType, out IntPtr modePageData, ref uint byteSize);

		// Token: 0x060001B0 RID: 432
		void SetModePage(IMAPI_MODE_PAGE_REQUEST_TYPE requestType, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1, SizeParamIndex = 2)] byte[] data, uint byteSize);

		// Token: 0x060001B1 RID: 433
		void GetSupportedFeaturePages(sbyte currentFeatureOnly, out IntPtr featureData, ref uint byteSize);

		// Token: 0x060001B2 RID: 434
		void GetSupportedProfiles(sbyte currentOnly, out IntPtr profileTypes, out uint validProfiles);

		// Token: 0x060001B3 RID: 435
		void GetSupportedModePages(IMAPI_MODE_PAGE_REQUEST_TYPE requestType, out IntPtr modePageTypes, out uint validPages);

		// Token: 0x060001B4 RID: 436
		uint GetByteAlignmentMask();

		// Token: 0x060001B5 RID: 437
		uint GetMaximumNonPageAlignedTransferSize();

		// Token: 0x060001B6 RID: 438
		uint GetMaximumPageAlignedTransferSize();
	}
}
