namespace ManualMapInjection.Injection.Win32
{
    using System;
    using System.Diagnostics;
    using System.Runtime.ConstrainedExecution;
    using System.Runtime.InteropServices;
    using System.Security;

    /// <summary>
    /// Defines the <see cref="Imports" />.
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    internal static class Imports
    {
        /// <summary>
        /// Defines the AllocationType.
        /// </summary>
        [Flags]
        public enum AllocationType
        {
            /// <summary>
            /// Defines the Commit.
            /// </summary>
            Commit = 0x1000,
            /// <summary>
            /// Defines the Reserve.
            /// </summary>
            Reserve = 0x2000,
            /// <summary>
            /// Defines the Decommit.
            /// </summary>
            Decommit = 0x4000,
            /// <summary>
            /// Defines the Release.
            /// </summary>
            Release = 0x8000,
            /// <summary>
            /// Defines the Reset.
            /// </summary>
            Reset = 0x80000,
            /// <summary>
            /// Defines the Physical.
            /// </summary>
            Physical = 0x400000,
            /// <summary>
            /// Defines the TopDown.
            /// </summary>
            TopDown = 0x100000,
            /// <summary>
            /// Defines the WriteWatch.
            /// </summary>
            WriteWatch = 0x200000,
            /// <summary>
            /// Defines the LargePages.
            /// </summary>
            LargePages = 0x20000000
        }

        /// <summary>
        /// Defines the MemoryProtection.
        /// </summary>
        [Flags]
        public enum MemoryProtection
        {
            /// <summary>
            /// Defines the Execute.
            /// </summary>
            Execute = 0x10,
            /// <summary>
            /// Defines the ExecuteRead.
            /// </summary>
            ExecuteRead = 0x20,
            /// <summary>
            /// Defines the ExecuteReadWrite.
            /// </summary>
            ExecuteReadWrite = 0x40,
            /// <summary>
            /// Defines the ExecuteWriteCopy.
            /// </summary>
            ExecuteWriteCopy = 0x80,
            /// <summary>
            /// Defines the NoAccess.
            /// </summary>
            NoAccess = 0x01,
            /// <summary>
            /// Defines the ReadOnly.
            /// </summary>
            ReadOnly = 0x02,
            /// <summary>
            /// Defines the ReadWrite.
            /// </summary>
            ReadWrite = 0x04,
            /// <summary>
            /// Defines the WriteCopy.
            /// </summary>
            WriteCopy = 0x08,
            /// <summary>
            /// Defines the GuardModifierflag.
            /// </summary>
            GuardModifierflag = 0x100,
            /// <summary>
            /// Defines the NoCacheModifierflag.
            /// </summary>
            NoCacheModifierflag = 0x200,
            /// <summary>
            /// Defines the WriteCombineModifierflag.
            /// </summary>
            WriteCombineModifierflag = 0x400
        }

        /// <summary>
        /// Defines the ProcessAccessFlags.
        /// </summary>
        [Flags]
        public enum ProcessAccessFlags : uint
        {
            /// <summary>
            /// Defines the All.
            /// </summary>
            All = 0x001F0FFF,
            /// <summary>
            /// Defines the Terminate.
            /// </summary>
            Terminate = 0x00000001,
            /// <summary>
            /// Defines the CreateThread.
            /// </summary>
            CreateThread = 0x00000002,
            /// <summary>
            /// Defines the VirtualMemoryOperation.
            /// </summary>
            VirtualMemoryOperation = 0x00000008,
            /// <summary>
            /// Defines the VirtualMemoryRead.
            /// </summary>
            VirtualMemoryRead = 0x00000010,
            /// <summary>
            /// Defines the VirtualMemoryWrite.
            /// </summary>
            VirtualMemoryWrite = 0x00000020,
            /// <summary>
            /// Defines the DuplicateHandle.
            /// </summary>
            DuplicateHandle = 0x00000040,
            /// <summary>
            /// Defines the CreateProcess.
            /// </summary>
            CreateProcess = 0x000000080,
            /// <summary>
            /// Defines the SetQuota.
            /// </summary>
            SetQuota = 0x00000100,
            /// <summary>
            /// Defines the SetInformation.
            /// </summary>
            SetInformation = 0x00000200,
            /// <summary>
            /// Defines the QueryInformation.
            /// </summary>
            QueryInformation = 0x00000400,
            /// <summary>
            /// Defines the QueryLimitedInformation.
            /// </summary>
            QueryLimitedInformation = 0x00001000,
            /// <summary>
            /// Defines the Synchronize.
            /// </summary>
            Synchronize = 0x00100000
        }

        /// <summary>
        /// Defines the FreeType.
        /// </summary>
        [Flags]
        public enum FreeType
        {
            /// <summary>
            /// Defines the Decommit.
            /// </summary>
            Decommit = 0x4000,
            /// <summary>
            /// Defines the Release.
            /// </summary>
            Release = 0x8000,
        }

        /// <summary>
        /// The VirtualAllocEx.
        /// </summary>
        /// <param name="hProcess">The hProcess<see cref="IntPtr"/>.</param>
        /// <param name="lpAddress">The lpAddress<see cref="UIntPtr"/>.</param>
        /// <param name="dwSize">The dwSize<see cref="IntPtr"/>.</param>
        /// <param name="flAllocationType">The flAllocationType<see cref="AllocationType"/>.</param>
        /// <param name="flProtect">The flProtect<see cref="MemoryProtection"/>.</param>
        /// <returns>The <see cref="IntPtr"/>.</returns>
        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        public static extern IntPtr VirtualAllocEx(IntPtr hProcess, UIntPtr lpAddress, IntPtr dwSize, AllocationType flAllocationType, MemoryProtection flProtect);

        /// <summary>
        /// The VirtualAlloc.
        /// </summary>
        /// <param name="lpAddress">The lpAddress<see cref="IntPtr"/>.</param>
        /// <param name="dwSize">The dwSize<see cref="UIntPtr"/>.</param>
        /// <param name="flAllocationType">The flAllocationType<see cref="AllocationType"/>.</param>
        /// <param name="flProtect">The flProtect<see cref="MemoryProtection"/>.</param>
        /// <returns>The <see cref="IntPtr"/>.</returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr VirtualAlloc(IntPtr lpAddress, UIntPtr dwSize, AllocationType flAllocationType, MemoryProtection flProtect);

        /// <summary>
        /// The OpenProcess.
        /// </summary>
        /// <param name="processAccess">The processAccess<see cref="ProcessAccessFlags"/>.</param>
        /// <param name="bInheritHandle">The bInheritHandle<see cref="bool"/>.</param>
        /// <param name="processId">The processId<see cref="int"/>.</param>
        /// <returns>The <see cref="IntPtr"/>.</returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr OpenProcess(ProcessAccessFlags processAccess, bool bInheritHandle, int processId);

        /// <summary>
        /// The CloseHandle.
        /// </summary>
        /// <param name="hObject">The hObject<see cref="IntPtr"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        [SuppressUnmanagedCodeSecurity]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseHandle(IntPtr hObject);

        /// <summary>
        /// The ImageRvaToVa.
        /// </summary>
        /// <param name="NtHeaders">The NtHeaders<see cref="IntPtr"/>.</param>
        /// <param name="Base">The Base<see cref="IntPtr"/>.</param>
        /// <param name="Rva">The Rva<see cref="UIntPtr"/>.</param>
        /// <param name="LastRvaSection">The LastRvaSection<see cref="IntPtr"/>.</param>
        /// <returns>The <see cref="IntPtr"/>.</returns>
        [DllImport("Dbghelp.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern IntPtr ImageRvaToVa(IntPtr NtHeaders, IntPtr Base, UIntPtr Rva, [Optional] IntPtr LastRvaSection);

        /// <summary>
        /// The GetProcessHeap.
        /// </summary>
        /// <returns>The <see cref="IntPtr"/>.</returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr GetProcessHeap();

        /// <summary>
        /// The HeapAlloc.
        /// </summary>
        /// <param name="hHeap">The hHeap<see cref="IntPtr"/>.</param>
        /// <param name="dwFlags">The dwFlags<see cref="uint"/>.</param>
        /// <param name="dwBytes">The dwBytes<see cref="UIntPtr"/>.</param>
        /// <returns>The <see cref="IntPtr"/>.</returns>
        [DllImport("kernel32.dll", SetLastError = false)]
        public static extern IntPtr HeapAlloc(IntPtr hHeap, uint dwFlags, UIntPtr dwBytes);

        /// <summary>
        /// The HeapFree.
        /// </summary>
        /// <param name="hHeap">The hHeap<see cref="IntPtr"/>.</param>
        /// <param name="dwFlags">The dwFlags<see cref="uint"/>.</param>
        /// <param name="lpMem">The lpMem<see cref="IntPtr"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool HeapFree(IntPtr hHeap, uint dwFlags, IntPtr lpMem);

        /// <summary>
        /// The NtQueryInformationProcess.
        /// </summary>
        /// <param name="hProcess">The hProcess<see cref="IntPtr"/>.</param>
        /// <param name="pic">The pic<see cref="int"/>.</param>
        /// <param name="pbi">The pbi<see cref="IntPtr"/>.</param>
        /// <param name="cb">The cb<see cref="uint"/>.</param>
        /// <param name="pSize">The pSize<see cref="uint"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        [DllImport("NTDLL.DLL", SetLastError = true)]
        public static extern int NtQueryInformationProcess(IntPtr hProcess, int pic, IntPtr pbi, uint cb, out uint pSize);

        /// <summary>
        /// The ReadProcessMemory.
        /// </summary>
        /// <param name="hProcess">The hProcess<see cref="IntPtr"/>.</param>
        /// <param name="lpBaseAddress">The lpBaseAddress<see cref="IntPtr"/>.</param>
        /// <param name="lpBuffer">The lpBuffer<see cref="IntPtr"/>.</param>
        /// <param name="dwSize">The dwSize<see cref="int"/>.</param>
        /// <param name="lpNumberOfBytesRead">The lpNumberOfBytesRead<see cref="UIntPtr"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, IntPtr lpBuffer, int dwSize, out UIntPtr lpNumberOfBytesRead);

        /// <summary>
        /// The WriteProcessMemory.
        /// </summary>
        /// <param name="hProcess">The hProcess<see cref="IntPtr"/>.</param>
        /// <param name="lpBaseAddress">The lpBaseAddress<see cref="IntPtr"/>.</param>
        /// <param name="lpBuffer">The lpBuffer<see cref="byte[]"/>.</param>
        /// <param name="nSize">The nSize<see cref="int"/>.</param>
        /// <param name="lpNumberOfBytesWritten">The lpNumberOfBytesWritten<see cref="UIntPtr"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int nSize, out UIntPtr lpNumberOfBytesWritten);

        /// <summary>
        /// The WriteProcessMemory.
        /// </summary>
        /// <param name="hProcess">The hProcess<see cref="IntPtr"/>.</param>
        /// <param name="lpBaseAddress">The lpBaseAddress<see cref="IntPtr"/>.</param>
        /// <param name="lpBuffer">The lpBuffer<see cref="IntPtr"/>.</param>
        /// <param name="nSize">The nSize<see cref="IntPtr"/>.</param>
        /// <param name="lpNumberOfBytesWritten">The lpNumberOfBytesWritten<see cref="UIntPtr"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, IntPtr lpBuffer, IntPtr nSize, out UIntPtr lpNumberOfBytesWritten);

        /// <summary>
        /// The GetProcAddress.
        /// </summary>
        /// <param name="hModule">The hModule<see cref="IntPtr"/>.</param>
        /// <param name="procName">The procName<see cref="string"/>.</param>
        /// <returns>The <see cref="IntPtr"/>.</returns>
        [DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        public static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

        /// <summary>
        /// The GetModuleHandle.
        /// </summary>
        /// <param name="lpModuleName">The lpModuleName<see cref="string"/>.</param>
        /// <returns>The <see cref="IntPtr"/>.</returns>
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        /// <summary>
        /// The CreateRemoteThread.
        /// </summary>
        /// <param name="hProcess">The hProcess<see cref="IntPtr"/>.</param>
        /// <param name="lpThreadAttributes">The lpThreadAttributes<see cref="IntPtr"/>.</param>
        /// <param name="dwStackSize">The dwStackSize<see cref="uint"/>.</param>
        /// <param name="lpStartAddress">The lpStartAddress<see cref="IntPtr"/>.</param>
        /// <param name="lpParameter">The lpParameter<see cref="IntPtr"/>.</param>
        /// <param name="dwCreationFlags">The dwCreationFlags<see cref="uint"/>.</param>
        /// <param name="lpThreadId">The lpThreadId<see cref="IntPtr"/>.</param>
        /// <returns>The <see cref="IntPtr"/>.</returns>
        [DllImport("kernel32.dll")]
        public static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

        /// <summary>
        /// The WaitForSingleObject.
        /// </summary>
        /// <param name="hHandle">The hHandle<see cref="IntPtr"/>.</param>
        /// <param name="dwMilliseconds">The dwMilliseconds<see cref="UInt32"/>.</param>
        /// <returns>The <see cref="UInt32"/>.</returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern UInt32 WaitForSingleObject(IntPtr hHandle, UInt32 dwMilliseconds);

        /// <summary>
        /// The VirtualFreeEx.
        /// </summary>
        /// <param name="hProcess">The hProcess<see cref="IntPtr"/>.</param>
        /// <param name="lpAddress">The lpAddress<see cref="IntPtr"/>.</param>
        /// <param name="dwSize">The dwSize<see cref="int"/>.</param>
        /// <param name="dwFreeType">The dwFreeType<see cref="FreeType"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        public static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, FreeType dwFreeType);

        /// <summary>
        /// The VirtualFree.
        /// </summary>
        /// <param name="lpAddress">The lpAddress<see cref="IntPtr"/>.</param>
        /// <param name="dwSize">The dwSize<see cref="int"/>.</param>
        /// <param name="dwFreeType">The dwFreeType<see cref="FreeType"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool VirtualFree(IntPtr lpAddress, int dwSize, FreeType dwFreeType);

        /// <summary>
        /// The VirtualProtectEx.
        /// </summary>
        /// <param name="hProcess">The hProcess<see cref="IntPtr"/>.</param>
        /// <param name="lpAddress">The lpAddress<see cref="IntPtr"/>.</param>
        /// <param name="dwSize">The dwSize<see cref="UIntPtr"/>.</param>
        /// <param name="flNewProtect">The flNewProtect<see cref="uint"/>.</param>
        /// <param name="lpflOldProtect">The lpflOldProtect<see cref="uint"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        [DllImport("kernel32.dll")]
        public static extern bool VirtualProtectEx(IntPtr hProcess, IntPtr lpAddress, UIntPtr dwSize, uint flNewProtect, out uint lpflOldProtect);

        /// <summary>
        /// The GetSystemTimeAsFileTime.
        /// </summary>
        /// <param name="lpSystemTimeAsFileTime">The lpSystemTimeAsFileTime<see cref="FILETIME"/>.</param>
        [DllImport("kernel32.dll")]
        public static extern void GetSystemTimeAsFileTime(out FILETIME lpSystemTimeAsFileTime);

        /// <summary>
        /// The QueryPerformanceCounter.
        /// </summary>
        /// <param name="lpPerformanceCount">The lpPerformanceCount<see cref="long"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool QueryPerformanceCounter(out long lpPerformanceCount);

        /// <summary>
        /// The ReadProcessMemory.
        /// </summary>
        /// <param name="hProcess">The hProcess<see cref="IntPtr"/>.</param>
        /// <param name="lpBaseAddress">The lpBaseAddress<see cref="IntPtr"/>.</param>
        /// <param name="lpBuffer">The lpBuffer<see cref="byte[]"/>.</param>
        /// <param name="lpNumberOfBytesRead">The lpNumberOfBytesRead<see cref="UIntPtr"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public static bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, out UIntPtr lpNumberOfBytesRead)
        {
            var handle = GCHandle.Alloc(lpBuffer, GCHandleType.Pinned);
            var result = ReadProcessMemory(hProcess, lpBaseAddress, handle.AddrOfPinnedObject(), lpBuffer.Length, out lpNumberOfBytesRead);
            handle.Free();
            return result;
        }

        /// <summary>
        /// The ReadProcessMemory.
        /// </summary>
        /// <param name="hProcess">The hProcess<see cref="IntPtr"/>.</param>
        /// <param name="lpBaseAddress">The lpBaseAddress<see cref="IntPtr"/>.</param>
        /// <param name="lpBuffer">The lpBuffer<see cref="uint"/>.</param>
        /// <param name="lpNumberOfBytesRead">The lpNumberOfBytesRead<see cref="UIntPtr"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public static bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, out uint lpBuffer, out UIntPtr lpNumberOfBytesRead)
        {
            var buffer = new byte[4];
            var result = ReadProcessMemory(hProcess, lpBaseAddress, buffer, out lpNumberOfBytesRead);
            lpBuffer = BitConverter.ToUInt32(buffer, 0);
            return result;
        }

        /// <summary>
        /// The ReadProcessMemory.
        /// </summary>
        /// <typeparam name="T">.</typeparam>
        /// <param name="hProcess">The hProcess<see cref="IntPtr"/>.</param>
        /// <param name="lpBaseAddress">The lpBaseAddress<see cref="IntPtr"/>.</param>
        /// <param name="lpBuffer">The lpBuffer<see cref="T"/>.</param>
        /// <param name="lpNumberOfBytesRead">The lpNumberOfBytesRead<see cref="UIntPtr"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public static bool ReadProcessMemory<T>(IntPtr hProcess, IntPtr lpBaseAddress, out T lpBuffer, out UIntPtr lpNumberOfBytesRead) where T : struct
        {
            var buffer = new byte[Marshal.SizeOf(typeof(T))];
            var result = ReadProcessMemory(hProcess, lpBaseAddress, buffer, out lpNumberOfBytesRead);
            var handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            lpBuffer = Marshal.PtrToStructure<T>(handle.AddrOfPinnedObject());
            handle.Free();

            return result;
        }

        /// <summary>
        /// The OpenProcess.
        /// </summary>
        /// <param name="proc">The proc<see cref="Process"/>.</param>
        /// <param name="flags">The flags<see cref="ProcessAccessFlags"/>.</param>
        /// <returns>The <see cref="IntPtr"/>.</returns>
        public static IntPtr OpenProcess(Process proc, ProcessAccessFlags flags)
        {
            return OpenProcess(flags, false, proc.Id);
        }
    }
}
