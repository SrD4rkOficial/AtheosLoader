namespace ManualMapInjection.Injection.Win32
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Defines the MachineType.
    /// </summary>
    public enum MachineType : ushort
    {
        /// <summary>
        /// Defines the Native.
        /// </summary>
        Native = 0,
        /// <summary>
        /// Defines the I386.
        /// </summary>
        I386 = 0x014c,
        /// <summary>
        /// Defines the Itanium.
        /// </summary>
        Itanium = 0x0200,
        /// <summary>
        /// Defines the x64.
        /// </summary>
        x64 = 0x8664
    }

    /// <summary>
    /// Defines the MagicType.
    /// </summary>
    public enum MagicType : ushort
    {
        /// <summary>
        /// Defines the IMAGE_NT_OPTIONAL_HDR32_MAGIC.
        /// </summary>
        IMAGE_NT_OPTIONAL_HDR32_MAGIC = 0x10b,
        /// <summary>
        /// Defines the IMAGE_NT_OPTIONAL_HDR64_MAGIC.
        /// </summary>
        IMAGE_NT_OPTIONAL_HDR64_MAGIC = 0x20b
    }

    /// <summary>
    /// Defines the SubSystemType.
    /// </summary>
    public enum SubSystemType : ushort
    {
        /// <summary>
        /// Defines the IMAGE_SUBSYSTEM_UNKNOWN.
        /// </summary>
        IMAGE_SUBSYSTEM_UNKNOWN = 0,
        /// <summary>
        /// Defines the IMAGE_SUBSYSTEM_NATIVE.
        /// </summary>
        IMAGE_SUBSYSTEM_NATIVE = 1,
        /// <summary>
        /// Defines the IMAGE_SUBSYSTEM_WINDOWS_GUI.
        /// </summary>
        IMAGE_SUBSYSTEM_WINDOWS_GUI = 2,
        /// <summary>
        /// Defines the IMAGE_SUBSYSTEM_WINDOWS_CUI.
        /// </summary>
        IMAGE_SUBSYSTEM_WINDOWS_CUI = 3,
        /// <summary>
        /// Defines the IMAGE_SUBSYSTEM_POSIX_CUI.
        /// </summary>
        IMAGE_SUBSYSTEM_POSIX_CUI = 7,
        /// <summary>
        /// Defines the IMAGE_SUBSYSTEM_WINDOWS_CE_GUI.
        /// </summary>
        IMAGE_SUBSYSTEM_WINDOWS_CE_GUI = 9,
        /// <summary>
        /// Defines the IMAGE_SUBSYSTEM_EFI_APPLICATION.
        /// </summary>
        IMAGE_SUBSYSTEM_EFI_APPLICATION = 10,
        /// <summary>
        /// Defines the IMAGE_SUBSYSTEM_EFI_BOOT_SERVICE_DRIVER.
        /// </summary>
        IMAGE_SUBSYSTEM_EFI_BOOT_SERVICE_DRIVER = 11,
        /// <summary>
        /// Defines the IMAGE_SUBSYSTEM_EFI_RUNTIME_DRIVER.
        /// </summary>
        IMAGE_SUBSYSTEM_EFI_RUNTIME_DRIVER = 12,
        /// <summary>
        /// Defines the IMAGE_SUBSYSTEM_EFI_ROM.
        /// </summary>
        IMAGE_SUBSYSTEM_EFI_ROM = 13,
        /// <summary>
        /// Defines the IMAGE_SUBSYSTEM_XBOX.
        /// </summary>
        IMAGE_SUBSYSTEM_XBOX = 14
    }

    /// <summary>
    /// Defines the DllCharacteristicsType.
    /// </summary>
    public enum DllCharacteristicsType : ushort
    {
        /// <summary>
        /// Defines the RES_0.
        /// </summary>
        RES_0 = 0x0001,
        /// <summary>
        /// Defines the RES_1.
        /// </summary>
        RES_1 = 0x0002,
        /// <summary>
        /// Defines the RES_2.
        /// </summary>
        RES_2 = 0x0004,
        /// <summary>
        /// Defines the RES_3.
        /// </summary>
        RES_3 = 0x0008,
        /// <summary>
        /// Defines the IMAGE_DLL_CHARACTERISTICS_DYNAMIC_BASE.
        /// </summary>
        IMAGE_DLL_CHARACTERISTICS_DYNAMIC_BASE = 0x0040,
        /// <summary>
        /// Defines the IMAGE_DLL_CHARACTERISTICS_FORCE_INTEGRITY.
        /// </summary>
        IMAGE_DLL_CHARACTERISTICS_FORCE_INTEGRITY = 0x0080,
        /// <summary>
        /// Defines the IMAGE_DLL_CHARACTERISTICS_NX_COMPAT.
        /// </summary>
        IMAGE_DLL_CHARACTERISTICS_NX_COMPAT = 0x0100,
        /// <summary>
        /// Defines the IMAGE_DLLCHARACTERISTICS_NO_ISOLATION.
        /// </summary>
        IMAGE_DLLCHARACTERISTICS_NO_ISOLATION = 0x0200,
        /// <summary>
        /// Defines the IMAGE_DLLCHARACTERISTICS_NO_SEH.
        /// </summary>
        IMAGE_DLLCHARACTERISTICS_NO_SEH = 0x0400,
        /// <summary>
        /// Defines the IMAGE_DLLCHARACTERISTICS_NO_BIND.
        /// </summary>
        IMAGE_DLLCHARACTERISTICS_NO_BIND = 0x0800,
        /// <summary>
        /// Defines the RES_4.
        /// </summary>
        RES_4 = 0x1000,
        /// <summary>
        /// Defines the IMAGE_DLLCHARACTERISTICS_WDM_DRIVER.
        /// </summary>
        IMAGE_DLLCHARACTERISTICS_WDM_DRIVER = 0x2000,
        /// <summary>
        /// Defines the IMAGE_DLLCHARACTERISTICS_TERMINAL_SERVER_AWARE.
        /// </summary>
        IMAGE_DLLCHARACTERISTICS_TERMINAL_SERVER_AWARE = 0x8000
    }

    /// <summary>
    /// Defines the DataSectionFlags.
    /// </summary>
    [Flags]
    public enum DataSectionFlags : uint
    {
        /// <summary>
        /// Reserved for future use.
        /// </summary>
        TypeReg = 0x00000000,
        /// <summary>
        /// Reserved for future use.
        /// </summary>
        TypeDsect = 0x00000001,
        /// <summary>
        /// Reserved for future use.
        /// </summary>
        TypeNoLoad = 0x00000002,
        /// <summary>
        /// Reserved for future use.
        /// </summary>
        TypeGroup = 0x00000004,
        /// <summary>
        /// The section should not be padded to the next boundary. This flag is obsolete and is replaced by IMAGE_SCN_ALIGN_1BYTES. This is valid only for object files.
        /// </summary>
        TypeNoPadded = 0x00000008,
        /// <summary>
        /// Reserved for future use.
        /// </summary>
        TypeCopy = 0x00000010,
        /// <summary>
        /// The section contains executable code.
        /// </summary>
        ContentCode = 0x00000020,
        /// <summary>
        /// The section contains initialized data.
        /// </summary>
        ContentInitializedData = 0x00000040,
        /// <summary>
        /// The section contains uninitialized data.
        /// </summary>
        ContentUninitializedData = 0x00000080,
        /// <summary>
        /// Reserved for future use.
        /// </summary>
        LinkOther = 0x00000100,
        /// <summary>
        /// The section contains comments or other information. The .drectve section has this type. This is valid for object files only.
        /// </summary>
        LinkInfo = 0x00000200,
        /// <summary>
        /// Reserved for future use.
        /// </summary>
        TypeOver = 0x00000400,
        /// <summary>
        /// The section will not become part of the image. This is valid only for object files.
        /// </summary>
        LinkRemove = 0x00000800,
        /// <summary>
        /// The section contains COMDAT data. For more information, see section 5.5.6, COMDAT Sections (Object Only). This is valid only for object files.
        /// </summary>
        LinkComDat = 0x00001000,
        /// <summary>
        /// Reset speculative exceptions handling bits in the TLB entries for this section.
        /// </summary>
        NoDeferSpecExceptions = 0x00004000,
        /// <summary>
        /// The section contains data referenced through the global pointer (GP).
        /// </summary>
        RelativeGP = 0x00008000,
        /// <summary>
        /// Reserved for future use.
        /// </summary>
        MemPurgeable = 0x00020000,
        /// <summary>
        /// Reserved for future use.
        /// </summary>
        Memory16Bit = 0x00020000,
        /// <summary>
        /// Reserved for future use.
        /// </summary>
        MemoryLocked = 0x00040000,
        /// <summary>
        /// Reserved for future use.
        /// </summary>
        MemoryPreload = 0x00080000,
        /// <summary>
        /// Align data on a 1-byte boundary. Valid only for object files.
        /// </summary>
        Align1Bytes = 0x00100000,
        /// <summary>
        /// Align data on a 2-byte boundary. Valid only for object files.
        /// </summary>
        Align2Bytes = 0x00200000,
        /// <summary>
        /// Align data on a 4-byte boundary. Valid only for object files.
        /// </summary>
        Align4Bytes = 0x00300000,
        /// <summary>
        /// Align data on an 8-byte boundary. Valid only for object files.
        /// </summary>
        Align8Bytes = 0x00400000,
        /// <summary>
        /// Align data on a 16-byte boundary. Valid only for object files.
        /// </summary>
        Align16Bytes = 0x00500000,
        /// <summary>
        /// Align data on a 32-byte boundary. Valid only for object files.
        /// </summary>
        Align32Bytes = 0x00600000,
        /// <summary>
        /// Align data on a 64-byte boundary. Valid only for object files.
        /// </summary>
        Align64Bytes = 0x00700000,
        /// <summary>
        /// Align data on a 128-byte boundary. Valid only for object files.
        /// </summary>
        Align128Bytes = 0x00800000,
        /// <summary>
        /// Align data on a 256-byte boundary. Valid only for object files.
        /// </summary>
        Align256Bytes = 0x00900000,
        /// <summary>
        /// Align data on a 512-byte boundary. Valid only for object files.
        /// </summary>
        Align512Bytes = 0x00A00000,
        /// <summary>
        /// Align data on a 1024-byte boundary. Valid only for object files.
        /// </summary>
        Align1024Bytes = 0x00B00000,
        /// <summary>
        /// Align data on a 2048-byte boundary. Valid only for object files.
        /// </summary>
        Align2048Bytes = 0x00C00000,
        /// <summary>
        /// Align data on a 4096-byte boundary. Valid only for object files.
        /// </summary>
        Align4096Bytes = 0x00D00000,
        /// <summary>
        /// Align data on an 8192-byte boundary. Valid only for object files.
        /// </summary>
        Align8192Bytes = 0x00E00000,
        /// <summary>
        /// The section contains extended relocations.
        /// </summary>
        LinkExtendedRelocationOverflow = 0x01000000,
        /// <summary>
        /// The section can be discarded as needed.
        /// </summary>
        MemoryDiscardable = 0x02000000,
        /// <summary>
        /// The section cannot be cached.
        /// </summary>
        MemoryNotCached = 0x04000000,
        /// <summary>
        /// The section is not pageable.
        /// </summary>
        MemoryNotPaged = 0x08000000,
        /// <summary>
        /// The section can be shared in memory.
        /// </summary>
        MemoryShared = 0x10000000,
        /// <summary>
        /// The section can be executed as code.
        /// </summary>
        MemoryExecute = 0x20000000,
        /// <summary>
        /// The section can be read.
        /// </summary>
        MemoryRead = 0x40000000,
        /// <summary>
        /// The section can be written to.
        /// </summary>
        MemoryWrite = 0x80000000
    }

    /// <summary>
    /// Defines the <see cref="IMAGE_DOS_HEADER" />.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct IMAGE_DOS_HEADER
    {
        /// <summary>
        /// Defines the e_magic.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] public char[] e_magic;// Magic number

        /// <summary>
        /// Defines the e_cblp.
        /// </summary>
        public UInt16 e_cblp;// Bytes on last page of file

        /// <summary>
        /// Defines the e_cp.
        /// </summary>
        public UInt16 e_cp;// Pages in file

        /// <summary>
        /// Defines the e_crlc.
        /// </summary>
        public UInt16 e_crlc;// Relocations

        /// <summary>
        /// Defines the e_cparhdr.
        /// </summary>
        public UInt16 e_cparhdr;// Size of header in paragraphs

        /// <summary>
        /// Defines the e_minalloc.
        /// </summary>
        public UInt16 e_minalloc;// Minimum extra paragraphs needed

        /// <summary>
        /// Defines the e_maxalloc.
        /// </summary>
        public UInt16 e_maxalloc;// Maximum extra paragraphs needed

        /// <summary>
        /// Defines the e_ss.
        /// </summary>
        public UInt16 e_ss;// Initial (relative) SS value

        /// <summary>
        /// Defines the e_sp.
        /// </summary>
        public UInt16 e_sp;// Initial SP value

        /// <summary>
        /// Defines the e_csum.
        /// </summary>
        public UInt16 e_csum;// Checksum

        /// <summary>
        /// Defines the e_ip.
        /// </summary>
        public UInt16 e_ip;// Initial IP value

        /// <summary>
        /// Defines the e_cs.
        /// </summary>
        public UInt16 e_cs;// Initial (relative) CS value

        /// <summary>
        /// Defines the e_lfarlc.
        /// </summary>
        public UInt16 e_lfarlc;// File address of relocation table

        /// <summary>
        /// Defines the e_ovno.
        /// </summary>
        public UInt16 e_ovno;// Overlay number

        /// <summary>
        /// Defines the e_res1.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] public UInt16[] e_res1;// Reserved words

        /// <summary>
        /// Defines the e_oemid.
        /// </summary>
        public UInt16 e_oemid;// OEM identifier (for e_oeminfo)

        /// <summary>
        /// Defines the e_oeminfo.
        /// </summary>
        public UInt16 e_oeminfo;// OEM information; e_oemid specific

        /// <summary>
        /// Defines the e_res2.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)] public UInt16[] e_res2;// Reserved words

        /// <summary>
        /// Defines the e_lfanew.
        /// </summary>
        public Int32 e_lfanew;// File address of new exe header

        /// <summary>
        /// Gets the _e_magic.
        /// </summary>
        private string _e_magic
        {
            get { return new string(e_magic); }
        }

        /// <summary>
        /// Gets a value indicating whether isValid.
        /// </summary>
        public bool isValid
        {
            get { return _e_magic == "MZ"; }
        }
    }

    /// <summary>
    /// Defines the <see cref="IMAGE_FILE_HEADER" />.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct IMAGE_FILE_HEADER
    {
        /// <summary>
        /// Defines the Machine.
        /// </summary>
        public UInt16 Machine;

        /// <summary>
        /// Defines the NumberOfSections.
        /// </summary>
        public UInt16 NumberOfSections;

        /// <summary>
        /// Defines the TimeDateStamp.
        /// </summary>
        public UInt32 TimeDateStamp;

        /// <summary>
        /// Defines the PointerToSymbolTable.
        /// </summary>
        public UInt32 PointerToSymbolTable;

        /// <summary>
        /// Defines the NumberOfSymbols.
        /// </summary>
        public UInt32 NumberOfSymbols;

        /// <summary>
        /// Defines the SizeOfOptionalHeader.
        /// </summary>
        public UInt16 SizeOfOptionalHeader;

        /// <summary>
        /// Defines the Characteristics.
        /// </summary>
        public UInt16 Characteristics;
    }

    /// <summary>
    /// Defines the <see cref="IMAGE_DATA_DIRECTORY" />.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct IMAGE_DATA_DIRECTORY
    {
        /// <summary>
        /// Defines the VirtualAddress.
        /// </summary>
        public UInt32 VirtualAddress;

        /// <summary>
        /// Defines the Size.
        /// </summary>
        public UInt32 Size;
    }

    /// <summary>
    /// Defines the <see cref="IMAGE_OPTIONAL_HEADER32" />.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct IMAGE_OPTIONAL_HEADER32
    {
        /// <summary>
        /// Defines the Magic.
        /// </summary>
        [FieldOffset(0)] public MagicType Magic;

        /// <summary>
        /// Defines the MajorLinkerVersion.
        /// </summary>
        [FieldOffset(2)] public byte MajorLinkerVersion;

        /// <summary>
        /// Defines the MinorLinkerVersion.
        /// </summary>
        [FieldOffset(3)] public byte MinorLinkerVersion;

        /// <summary>
        /// Defines the SizeOfCode.
        /// </summary>
        [FieldOffset(4)] public uint SizeOfCode;

        /// <summary>
        /// Defines the SizeOfInitializedData.
        /// </summary>
        [FieldOffset(8)] public uint SizeOfInitializedData;

        /// <summary>
        /// Defines the SizeOfUninitializedData.
        /// </summary>
        [FieldOffset(12)] public uint SizeOfUninitializedData;

        /// <summary>
        /// Defines the AddressOfEntryPoint.
        /// </summary>
        [FieldOffset(16)] public uint AddressOfEntryPoint;

        /// <summary>
        /// Defines the BaseOfCode.
        /// </summary>
        [FieldOffset(20)] public uint BaseOfCode;

        /// <summary>
        /// Defines the BaseOfData.
        /// </summary>
        [FieldOffset(24)] public uint BaseOfData;

        /// <summary>
        /// Defines the ImageBase.
        /// </summary>
        [FieldOffset(28)] public uint ImageBase;

        /// <summary>
        /// Defines the SectionAlignment.
        /// </summary>
        [FieldOffset(32)] public uint SectionAlignment;

        /// <summary>
        /// Defines the FileAlignment.
        /// </summary>
        [FieldOffset(36)] public uint FileAlignment;

        /// <summary>
        /// Defines the MajorOperatingSystemVersion.
        /// </summary>
        [FieldOffset(40)] public ushort MajorOperatingSystemVersion;

        /// <summary>
        /// Defines the MinorOperatingSystemVersion.
        /// </summary>
        [FieldOffset(42)] public ushort MinorOperatingSystemVersion;

        /// <summary>
        /// Defines the MajorImageVersion.
        /// </summary>
        [FieldOffset(44)] public ushort MajorImageVersion;

        /// <summary>
        /// Defines the MinorImageVersion.
        /// </summary>
        [FieldOffset(46)] public ushort MinorImageVersion;

        /// <summary>
        /// Defines the MajorSubsystemVersion.
        /// </summary>
        [FieldOffset(48)] public ushort MajorSubsystemVersion;

        /// <summary>
        /// Defines the MinorSubsystemVersion.
        /// </summary>
        [FieldOffset(50)] public ushort MinorSubsystemVersion;

        /// <summary>
        /// Defines the Win32VersionValue.
        /// </summary>
        [FieldOffset(52)] public uint Win32VersionValue;

        /// <summary>
        /// Defines the SizeOfImage.
        /// </summary>
        [FieldOffset(56)] public uint SizeOfImage;

        /// <summary>
        /// Defines the SizeOfHeaders.
        /// </summary>
        [FieldOffset(60)] public uint SizeOfHeaders;

        /// <summary>
        /// Defines the CheckSum.
        /// </summary>
        [FieldOffset(64)] public uint CheckSum;

        /// <summary>
        /// Defines the Subsystem.
        /// </summary>
        [FieldOffset(68)] public SubSystemType Subsystem;

        /// <summary>
        /// Defines the DllCharacteristics.
        /// </summary>
        [FieldOffset(70)] public DllCharacteristicsType DllCharacteristics;

        /// <summary>
        /// Defines the SizeOfStackReserve.
        /// </summary>
        [FieldOffset(72)] public uint SizeOfStackReserve;

        /// <summary>
        /// Defines the SizeOfStackCommit.
        /// </summary>
        [FieldOffset(76)] public uint SizeOfStackCommit;

        /// <summary>
        /// Defines the SizeOfHeapReserve.
        /// </summary>
        [FieldOffset(80)] public uint SizeOfHeapReserve;

        /// <summary>
        /// Defines the SizeOfHeapCommit.
        /// </summary>
        [FieldOffset(84)] public uint SizeOfHeapCommit;

        /// <summary>
        /// Defines the LoaderFlags.
        /// </summary>
        [FieldOffset(88)] public uint LoaderFlags;

        /// <summary>
        /// Defines the NumberOfRvaAndSizes.
        /// </summary>
        [FieldOffset(92)] public uint NumberOfRvaAndSizes;

        /// <summary>
        /// Defines the ExportTable.
        /// </summary>
        [FieldOffset(96)] public IMAGE_DATA_DIRECTORY ExportTable;

        /// <summary>
        /// Defines the ImportTable.
        /// </summary>
        [FieldOffset(104)] public IMAGE_DATA_DIRECTORY ImportTable;

        /// <summary>
        /// Defines the ResourceTable.
        /// </summary>
        [FieldOffset(112)] public IMAGE_DATA_DIRECTORY ResourceTable;

        /// <summary>
        /// Defines the ExceptionTable.
        /// </summary>
        [FieldOffset(120)] public IMAGE_DATA_DIRECTORY ExceptionTable;

        /// <summary>
        /// Defines the CertificateTable.
        /// </summary>
        [FieldOffset(128)] public IMAGE_DATA_DIRECTORY CertificateTable;

        /// <summary>
        /// Defines the BaseRelocationTable.
        /// </summary>
        [FieldOffset(136)] public IMAGE_DATA_DIRECTORY BaseRelocationTable;

        /// <summary>
        /// Defines the Debug.
        /// </summary>
        [FieldOffset(144)] public IMAGE_DATA_DIRECTORY Debug;

        /// <summary>
        /// Defines the Architecture.
        /// </summary>
        [FieldOffset(152)] public IMAGE_DATA_DIRECTORY Architecture;

        /// <summary>
        /// Defines the GlobalPtr.
        /// </summary>
        [FieldOffset(160)] public IMAGE_DATA_DIRECTORY GlobalPtr;

        /// <summary>
        /// Defines the TLSTable.
        /// </summary>
        [FieldOffset(168)] public IMAGE_DATA_DIRECTORY TLSTable;

        /// <summary>
        /// Defines the LoadConfigTable.
        /// </summary>
        [FieldOffset(176)] public IMAGE_DATA_DIRECTORY LoadConfigTable;

        /// <summary>
        /// Defines the BoundImport.
        /// </summary>
        [FieldOffset(184)] public IMAGE_DATA_DIRECTORY BoundImport;

        /// <summary>
        /// Defines the IAT.
        /// </summary>
        [FieldOffset(192)] public IMAGE_DATA_DIRECTORY IAT;

        /// <summary>
        /// Defines the DelayImportDescriptor.
        /// </summary>
        [FieldOffset(200)] public IMAGE_DATA_DIRECTORY DelayImportDescriptor;

        /// <summary>
        /// Defines the CLRRuntimeHeader.
        /// </summary>
        [FieldOffset(208)] public IMAGE_DATA_DIRECTORY CLRRuntimeHeader;

        /// <summary>
        /// Defines the Reserved.
        /// </summary>
        [FieldOffset(216)] public IMAGE_DATA_DIRECTORY Reserved;
    }

    /// <summary>
    /// Defines the <see cref="IMAGE_OPTIONAL_HEADER64" />.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct IMAGE_OPTIONAL_HEADER64
    {
        /// <summary>
        /// Defines the Magic.
        /// </summary>
        [FieldOffset(0)] public MagicType Magic;

        /// <summary>
        /// Defines the MajorLinkerVersion.
        /// </summary>
        [FieldOffset(2)] public byte MajorLinkerVersion;

        /// <summary>
        /// Defines the MinorLinkerVersion.
        /// </summary>
        [FieldOffset(3)] public byte MinorLinkerVersion;

        /// <summary>
        /// Defines the SizeOfCode.
        /// </summary>
        [FieldOffset(4)] public uint SizeOfCode;

        /// <summary>
        /// Defines the SizeOfInitializedData.
        /// </summary>
        [FieldOffset(8)] public uint SizeOfInitializedData;

        /// <summary>
        /// Defines the SizeOfUninitializedData.
        /// </summary>
        [FieldOffset(12)] public uint SizeOfUninitializedData;

        /// <summary>
        /// Defines the AddressOfEntryPoint.
        /// </summary>
        [FieldOffset(16)] public uint AddressOfEntryPoint;

        /// <summary>
        /// Defines the BaseOfCode.
        /// </summary>
        [FieldOffset(20)] public uint BaseOfCode;

        /// <summary>
        /// Defines the ImageBase.
        /// </summary>
        [FieldOffset(24)] public ulong ImageBase;

        /// <summary>
        /// Defines the SectionAlignment.
        /// </summary>
        [FieldOffset(32)] public uint SectionAlignment;

        /// <summary>
        /// Defines the FileAlignment.
        /// </summary>
        [FieldOffset(36)] public uint FileAlignment;

        /// <summary>
        /// Defines the MajorOperatingSystemVersion.
        /// </summary>
        [FieldOffset(40)] public ushort MajorOperatingSystemVersion;

        /// <summary>
        /// Defines the MinorOperatingSystemVersion.
        /// </summary>
        [FieldOffset(42)] public ushort MinorOperatingSystemVersion;

        /// <summary>
        /// Defines the MajorImageVersion.
        /// </summary>
        [FieldOffset(44)] public ushort MajorImageVersion;

        /// <summary>
        /// Defines the MinorImageVersion.
        /// </summary>
        [FieldOffset(46)] public ushort MinorImageVersion;

        /// <summary>
        /// Defines the MajorSubsystemVersion.
        /// </summary>
        [FieldOffset(48)] public ushort MajorSubsystemVersion;

        /// <summary>
        /// Defines the MinorSubsystemVersion.
        /// </summary>
        [FieldOffset(50)] public ushort MinorSubsystemVersion;

        /// <summary>
        /// Defines the Win32VersionValue.
        /// </summary>
        [FieldOffset(52)] public uint Win32VersionValue;

        /// <summary>
        /// Defines the SizeOfImage.
        /// </summary>
        [FieldOffset(56)] public uint SizeOfImage;

        /// <summary>
        /// Defines the SizeOfHeaders.
        /// </summary>
        [FieldOffset(60)] public uint SizeOfHeaders;

        /// <summary>
        /// Defines the CheckSum.
        /// </summary>
        [FieldOffset(64)] public uint CheckSum;

        /// <summary>
        /// Defines the Subsystem.
        /// </summary>
        [FieldOffset(68)] public SubSystemType Subsystem;

        /// <summary>
        /// Defines the DllCharacteristics.
        /// </summary>
        [FieldOffset(70)] public DllCharacteristicsType DllCharacteristics;

        /// <summary>
        /// Defines the SizeOfStackReserve.
        /// </summary>
        [FieldOffset(72)] public ulong SizeOfStackReserve;

        /// <summary>
        /// Defines the SizeOfStackCommit.
        /// </summary>
        [FieldOffset(80)] public ulong SizeOfStackCommit;

        /// <summary>
        /// Defines the SizeOfHeapReserve.
        /// </summary>
        [FieldOffset(88)] public ulong SizeOfHeapReserve;

        /// <summary>
        /// Defines the SizeOfHeapCommit.
        /// </summary>
        [FieldOffset(96)] public ulong SizeOfHeapCommit;

        /// <summary>
        /// Defines the LoaderFlags.
        /// </summary>
        [FieldOffset(104)] public uint LoaderFlags;

        /// <summary>
        /// Defines the NumberOfRvaAndSizes.
        /// </summary>
        [FieldOffset(108)] public uint NumberOfRvaAndSizes;

        /// <summary>
        /// Defines the ExportTable.
        /// </summary>
        [FieldOffset(112)] public IMAGE_DATA_DIRECTORY ExportTable;

        /// <summary>
        /// Defines the ImportTable.
        /// </summary>
        [FieldOffset(120)] public IMAGE_DATA_DIRECTORY ImportTable;

        /// <summary>
        /// Defines the ResourceTable.
        /// </summary>
        [FieldOffset(128)] public IMAGE_DATA_DIRECTORY ResourceTable;

        /// <summary>
        /// Defines the ExceptionTable.
        /// </summary>
        [FieldOffset(136)] public IMAGE_DATA_DIRECTORY ExceptionTable;

        /// <summary>
        /// Defines the CertificateTable.
        /// </summary>
        [FieldOffset(144)] public IMAGE_DATA_DIRECTORY CertificateTable;

        /// <summary>
        /// Defines the BaseRelocationTable.
        /// </summary>
        [FieldOffset(152)] public IMAGE_DATA_DIRECTORY BaseRelocationTable;

        /// <summary>
        /// Defines the Debug.
        /// </summary>
        [FieldOffset(160)] public IMAGE_DATA_DIRECTORY Debug;

        /// <summary>
        /// Defines the Architecture.
        /// </summary>
        [FieldOffset(168)] public IMAGE_DATA_DIRECTORY Architecture;

        /// <summary>
        /// Defines the GlobalPtr.
        /// </summary>
        [FieldOffset(176)] public IMAGE_DATA_DIRECTORY GlobalPtr;

        /// <summary>
        /// Defines the TLSTable.
        /// </summary>
        [FieldOffset(184)] public IMAGE_DATA_DIRECTORY TLSTable;

        /// <summary>
        /// Defines the LoadConfigTable.
        /// </summary>
        [FieldOffset(192)] public IMAGE_DATA_DIRECTORY LoadConfigTable;

        /// <summary>
        /// Defines the BoundImport.
        /// </summary>
        [FieldOffset(200)] public IMAGE_DATA_DIRECTORY BoundImport;

        /// <summary>
        /// Defines the IAT.
        /// </summary>
        [FieldOffset(208)] public IMAGE_DATA_DIRECTORY IAT;

        /// <summary>
        /// Defines the DelayImportDescriptor.
        /// </summary>
        [FieldOffset(216)] public IMAGE_DATA_DIRECTORY DelayImportDescriptor;

        /// <summary>
        /// Defines the CLRRuntimeHeader.
        /// </summary>
        [FieldOffset(224)] public IMAGE_DATA_DIRECTORY CLRRuntimeHeader;

        /// <summary>
        /// Defines the Reserved.
        /// </summary>
        [FieldOffset(232)] public IMAGE_DATA_DIRECTORY Reserved;
    }

    /// <summary>
    /// Defines the <see cref="IMAGE_NT_HEADERS32" />.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct IMAGE_NT_HEADERS32
    {
        /// <summary>
        /// Defines the Signature.
        /// </summary>
        [FieldOffset(0)] [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] public char[] Signature;

        /// <summary>
        /// Defines the FileHeader.
        /// </summary>
        [FieldOffset(4)] public IMAGE_FILE_HEADER FileHeader;

        /// <summary>
        /// Defines the OptionalHeader.
        /// </summary>
        [FieldOffset(24)] public IMAGE_OPTIONAL_HEADER32 OptionalHeader;

        /// <summary>
        /// Gets the _Signature.
        /// </summary>
        private string _Signature
        {
            get { return new string(Signature); }
        }

        /// <summary>
        /// Gets a value indicating whether isValid.
        /// </summary>
        public bool isValid
        {
            get
            {
                return _Signature == "PE\0\0"
                    /*&& (OptionalHeader.Magic == PE.MagicType.IMAGE_NT_OPTIONAL_HDR32_MAGIC || OptionalHeader.Magic == PE.MagicType.IMAGE_NT_OPTIONAL_HDR64_MAGIC)*/;
            }
        }
    }

    /// <summary>
    /// Defines the <see cref="IMAGE_NT_HEADERS64" />.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct IMAGE_NT_HEADERS64
    {
        /// <summary>
        /// Defines the Signature.
        /// </summary>
        [FieldOffset(0)] [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] public char[] Signature;

        /// <summary>
        /// Defines the FileHeader.
        /// </summary>
        [FieldOffset(4)] public IMAGE_FILE_HEADER FileHeader;

        /// <summary>
        /// Defines the OptionalHeader.
        /// </summary>
        [FieldOffset(24)] public IMAGE_OPTIONAL_HEADER64 OptionalHeader;

        /// <summary>
        /// Gets the _Signature.
        /// </summary>
        private string _Signature
        {
            get { return new string(Signature); }
        }

        /// <summary>
        /// Gets a value indicating whether isValid.
        /// </summary>
        public bool isValid
        {
            get
            {
                return _Signature == "PE\0\0"
                    /*&& (OptionalHeader.Magic == PE.MagicType.IMAGE_NT_OPTIONAL_HDR32_MAGIC || OptionalHeader.Magic == PE.MagicType.IMAGE_NT_OPTIONAL_HDR64_MAGIC)*/;
            }
        }
    }

    /// <summary>
    /// Defines the <see cref="IMAGE_SECTION_HEADER" />.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct IMAGE_SECTION_HEADER
    {
        /// <summary>
        /// Defines the Name.
        /// </summary>
        [FieldOffset(0)] [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] public char[] Name;

        /// <summary>
        /// Defines the VirtualSize.
        /// </summary>
        [FieldOffset(8)] public UInt32 VirtualSize;

        /// <summary>
        /// Defines the VirtualAddress.
        /// </summary>
        [FieldOffset(12)] public UInt32 VirtualAddress;

        /// <summary>
        /// Defines the SizeOfRawData.
        /// </summary>
        [FieldOffset(16)] public UInt32 SizeOfRawData;

        /// <summary>
        /// Defines the PointerToRawData.
        /// </summary>
        [FieldOffset(20)] public UInt32 PointerToRawData;

        /// <summary>
        /// Defines the PointerToRelocations.
        /// </summary>
        [FieldOffset(24)] public UInt32 PointerToRelocations;

        /// <summary>
        /// Defines the PointerToLinenumbers.
        /// </summary>
        [FieldOffset(28)] public UInt32 PointerToLinenumbers;

        /// <summary>
        /// Defines the NumberOfRelocations.
        /// </summary>
        [FieldOffset(32)] public UInt16 NumberOfRelocations;

        /// <summary>
        /// Defines the NumberOfLinenumbers.
        /// </summary>
        [FieldOffset(34)] public UInt16 NumberOfLinenumbers;

        /// <summary>
        /// Defines the Characteristics.
        /// </summary>
        [FieldOffset(36)] public DataSectionFlags Characteristics;

        /// <summary>
        /// Gets the Section.
        /// </summary>
        public string Section
        {
            get { return new string(Name); }
        }
    }

    /// <summary>
    /// Defines the <see cref="IMAGE_IMPORT_DESCRIPTOR" />.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct IMAGE_IMPORT_DESCRIPTOR
    {
        /// <summary>
        /// Defines the Characteristics.
        /// </summary>
        [FieldOffset(0)] public uint Characteristics;

        /// <summary>
        /// Defines the OriginalFirstThunk.
        /// </summary>
        [FieldOffset(0)] public uint OriginalFirstThunk;

        /// <summary>
        /// Defines the TimeDateStamp.
        /// </summary>
        [FieldOffset(4)] public uint TimeDateStamp;

        /// <summary>
        /// Defines the ForwarderChain.
        /// </summary>
        [FieldOffset(8)] public uint ForwarderChain;

        /// <summary>
        /// Defines the Name.
        /// </summary>
        [FieldOffset(12)] public uint Name;

        /// <summary>
        /// Defines the FirstThunk.
        /// </summary>
        [FieldOffset(16)] public uint FirstThunk;
    }

    /// <summary>
    /// Defines the <see cref="PROCESS_BASIC_INFORMATION" />.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct PROCESS_BASIC_INFORMATION
    {
        /// <summary>
        /// Defines the ExitStatus.
        /// </summary>
        public IntPtr ExitStatus;

        /// <summary>
        /// Defines the PebBaseAddress.
        /// </summary>
        public IntPtr PebBaseAddress;

        /// <summary>
        /// Defines the AffinityMask.
        /// </summary>
        public IntPtr AffinityMask;

        /// <summary>
        /// Defines the BasePriority.
        /// </summary>
        public IntPtr BasePriority;

        /// <summary>
        /// Defines the UniqueProcessId.
        /// </summary>
        public UIntPtr UniqueProcessId;

        /// <summary>
        /// Defines the InheritedFromUniqueProcessId.
        /// </summary>
        public IntPtr InheritedFromUniqueProcessId;

        /// <summary>
        /// Gets the Size.
        /// </summary>
        public int Size
        {
            get { return (int)Marshal.SizeOf(typeof(PROCESS_BASIC_INFORMATION)); }
        }
    }

    /// <summary>
    /// Defines the <see cref="UNICODE_STRING" />.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 0)]
    public struct UNICODE_STRING
    {
        /// <summary>
        /// Defines the Length.
        /// </summary>
        public ushort Length;

        /// <summary>
        /// Defines the MaximumLength.
        /// </summary>
        public ushort MaximumLength;

        /// <summary>
        /// Defines the Buffer.
        /// </summary>
        public IntPtr Buffer;
    }

    /// <summary>
    /// Defines the <see cref="IMAGE_THUNK_DATA" />.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct IMAGE_THUNK_DATA
    {
        /// <summary>
        /// Defines the ForwarderString.
        /// </summary>
        [FieldOffset(0)] public uint ForwarderString;// PBYTE

        /// <summary>
        /// Defines the Function.
        /// </summary>
        [FieldOffset(0)] public uint Function;// PDWORD

        /// <summary>
        /// Defines the Ordinal.
        /// </summary>
        [FieldOffset(0)] public uint Ordinal;

        /// <summary>
        /// Defines the AddressOfData.
        /// </summary>
        [FieldOffset(0)] public uint AddressOfData;// PIMAGE_IMPORT_BY_NAME
    }

    /// <summary>
    /// Defines the <see cref="IMAGE_EXPORT_DIRECTORY" />.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct IMAGE_EXPORT_DIRECTORY
    {
        /// <summary>
        /// Defines the Characteristics.
        /// </summary>
        public UInt32 Characteristics;

        /// <summary>
        /// Defines the TimeDateStamp.
        /// </summary>
        public UInt32 TimeDateStamp;

        /// <summary>
        /// Defines the MajorVersion.
        /// </summary>
        public UInt16 MajorVersion;

        /// <summary>
        /// Defines the MinorVersion.
        /// </summary>
        public UInt16 MinorVersion;

        /// <summary>
        /// Defines the Name.
        /// </summary>
        public UInt32 Name;

        /// <summary>
        /// Defines the Base.
        /// </summary>
        public UInt32 Base;

        /// <summary>
        /// Defines the NumberOfFunctions.
        /// </summary>
        public UInt32 NumberOfFunctions;

        /// <summary>
        /// Defines the NumberOfNames.
        /// </summary>
        public UInt32 NumberOfNames;

        /// <summary>
        /// Defines the AddressOfFunctions.
        /// </summary>
        public UInt32 AddressOfFunctions;// RVA from base of image

        /// <summary>
        /// Defines the AddressOfNames.
        /// </summary>
        public UInt32 AddressOfNames;// RVA from base of image

        /// <summary>
        /// Defines the AddressOfNameOrdinals.
        /// </summary>
        public UInt32 AddressOfNameOrdinals;// RVA from base of image
    }

    /// <summary>
    /// Defines the <see cref="IMAGE_IMPORT_BY_NAME" />.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct IMAGE_IMPORT_BY_NAME
    {
        /// <summary>
        /// Defines the Hint.
        /// </summary>
        public short Hint;

        /// <summary>
        /// Defines the Name.
        /// </summary>
        public char Name;
    }

    /// <summary>
    /// Defines the <see cref="IMAGE_BASE_RELOCATION" />.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct IMAGE_BASE_RELOCATION
    {
        /// <summary>
        /// Defines the VirtualAddress.
        /// </summary>
        public UInt32 VirtualAddress;

        /// <summary>
        /// Defines the SizeOfBlock.
        /// </summary>
        public UInt32 SizeOfBlock;
    }

    /// <summary>
    /// Defines the <see cref="IMAGE_TLS_DIRECTORY32" />.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct IMAGE_TLS_DIRECTORY32
    {
        /// <summary>
        /// Defines the StartAddressOfRawData.
        /// </summary>
        public UInt32 StartAddressOfRawData;

        /// <summary>
        /// Defines the EndAddressOfRawData.
        /// </summary>
        public UInt32 EndAddressOfRawData;

        /// <summary>
        /// Defines the AddressOfIndex.
        /// </summary>
        public UInt32 AddressOfIndex;// PDWORD

        /// <summary>
        /// Defines the AddressOfCallBacks.
        /// </summary>
        public UInt32 AddressOfCallBacks;// PIMAGE_TLS_CALLBACK *

        /// <summary>
        /// Defines the SizeOfZeroFill.
        /// </summary>
        public UInt32 SizeOfZeroFill;

        /// <summary>
        /// Defines the Characteristics.
        /// </summary>
        public UInt32 Characteristics;
    }

    /// <summary>
    /// Defines the <see cref="IMAGE_LOAD_CONFIG_DIRECTORY32" />.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct IMAGE_LOAD_CONFIG_DIRECTORY32
    {
        /// <summary>
        /// Defines the Size.
        /// </summary>
        public UInt32 Size;

        /// <summary>
        /// Defines the TimeDateStamp.
        /// </summary>
        public UInt32 TimeDateStamp;

        /// <summary>
        /// Defines the MajorVersion.
        /// </summary>
        public UInt16 MajorVersion;

        /// <summary>
        /// Defines the MinorVersion.
        /// </summary>
        public UInt16 MinorVersion;

        /// <summary>
        /// Defines the GlobalFlagsClear.
        /// </summary>
        public UInt32 GlobalFlagsClear;

        /// <summary>
        /// Defines the GlobalFlagsSet.
        /// </summary>
        public UInt32 GlobalFlagsSet;

        /// <summary>
        /// Defines the CriticalSectionDefaultTimeout.
        /// </summary>
        public UInt32 CriticalSectionDefaultTimeout;

        /// <summary>
        /// Defines the DeCommitFreeBlockThreshold.
        /// </summary>
        public UInt32 DeCommitFreeBlockThreshold;

        /// <summary>
        /// Defines the DeCommitTotalFreeThreshold.
        /// </summary>
        public UInt32 DeCommitTotalFreeThreshold;

        /// <summary>
        /// Defines the LockPrefixTable.
        /// </summary>
        public UInt32 LockPrefixTable;// VA

        /// <summary>
        /// Defines the MaximumAllocationSize.
        /// </summary>
        public UInt32 MaximumAllocationSize;

        /// <summary>
        /// Defines the VirtualMemoryThreshold.
        /// </summary>
        public UInt32 VirtualMemoryThreshold;

        /// <summary>
        /// Defines the ProcessHeapFlags.
        /// </summary>
        public UInt32 ProcessHeapFlags;

        /// <summary>
        /// Defines the ProcessAffinityMask.
        /// </summary>
        public UInt32 ProcessAffinityMask;

        /// <summary>
        /// Defines the CSDVersion.
        /// </summary>
        public UInt16 CSDVersion;

        /// <summary>
        /// Defines the Reserved1.
        /// </summary>
        public UInt16 Reserved1;

        /// <summary>
        /// Defines the EditList.
        /// </summary>
        public UInt32 EditList;// VA

        /// <summary>
        /// Defines the SecurityCookie.
        /// </summary>
        public UInt32 SecurityCookie;// VA

        /// <summary>
        /// Defines the SEHandlerTable.
        /// </summary>
        public UInt32 SEHandlerTable;// VA

        /// <summary>
        /// Defines the SEHandlerCount.
        /// </summary>
        public UInt32 SEHandlerCount;

        /// <summary>
        /// Defines the GuardCFCheckFunctionPointer.
        /// </summary>
        public UInt32 GuardCFCheckFunctionPointer;// VA

        /// <summary>
        /// Defines the Reserved2.
        /// </summary>
        public UInt32 Reserved2;

        /// <summary>
        /// Defines the GuardCFFunctionTable.
        /// </summary>
        public UInt32 GuardCFFunctionTable;// VA

        /// <summary>
        /// Defines the GuardCFFunctionCount.
        /// </summary>
        public UInt32 GuardCFFunctionCount;

        /// <summary>
        /// Defines the GuardFlags.
        /// </summary>
        public UInt32 GuardFlags;
    }

    /// <summary>
    /// Defines the <see cref="FILETIME" />.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct FILETIME
    {
        /// <summary>
        /// Defines the DateTimeLow.
        /// </summary>
        public uint DateTimeLow;

        /// <summary>
        /// Defines the DateTimeHigh.
        /// </summary>
        public uint DateTimeHigh;
    }
}
