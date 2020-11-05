using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace FnsUtility
{
	///<summary>
	///</summary>
	[CLSCompliant(false)]
	public class NativeMethods
	{

		private readonly MEMORYSTATUSEX msex;
		private uint _MemoryLoad;
		const int MEMORY_TIGHT_CONST = 80;
		const uint ProcessMemoryTight = 1200000000;

		///<summary>
		///</summary>
		public bool isMemoryTight()
		{
			return isMemoryTight(MEMORY_TIGHT_CONST);
		}

		///<summary>
		///</summary>
		public bool isMemoryTight(int threshold)
		{
			if (_MemoryLoad > threshold)
				return true;
			else
				return false;
		}

		///<summary>
		///</summary>
		public uint MemoryLoad
		{
			get { return _MemoryLoad; }
			internal set { _MemoryLoad = value; }
		}

		///<summary>
		///</summary>
		public NativeMethods()
		{
			msex = new MEMORYSTATUSEX();
			if (GlobalMemoryStatusEx(msex))
			{

				_MemoryLoad = msex.dwMemoryLoad;
				//etc.. Repeat for other structure members        

			}
			else
				// Use a more appropriate Exception Type. 'Exception' should almost never be thrown
				throw new Exception("Unable to initalize the GlobalMemoryStatusEx API");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public static bool IsGlobalMemoryTight()
		{
			return IsGlobalMemoryTight(MEMORY_TIGHT_CONST);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="threshold"></param>
		/// <returns></returns>
		public static bool IsGlobalMemoryTight(int threshold)
		{
			bool results = false;
			try
			{
				NativeMethods memoryInfo = new NativeMethods();
				results = memoryInfo.isMemoryTight(threshold);
			}
			catch (Exception ex)
			{
				ErrorLog.LogError(ex.Message, new CallingMethod());
			}
			return results;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public static bool IsProcessMemoryTight()
		{
			return IsProcessMemoryTight(ProcessMemoryTight);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="threshold"></param>
		/// <returns></returns>
		public static bool IsProcessMemoryTight(uint threshold)
		{
			string component = "ProcessMemory";
			bool results = false;
			try
			{
				IntPtr handle = Process.GetCurrentProcess().Handle;
				PPROCESS_MEMORY_COUNTERS counters = new PPROCESS_MEMORY_COUNTERS();
				if (GetProcessMemoryInfo(handle, counters, counters.cb))
				{
					ErrorLog.DebugLog("Page Fault Count: " + counters.PageFaultCount, component);
					ErrorLog.DebugLog("Page File Usage: " + counters.PagefileUsage, component);
					ErrorLog.DebugLog("Peak Page File Usage: " + counters.PeakPagefileUsage, component);
					ErrorLog.DebugLog("Peak Working Set Size: " + counters.PeakWorkingSetSize, component);
					ErrorLog.DebugLog("Private Usage: " + counters.PrivateUsage, component);
					ErrorLog.DebugLog("Working Set Size: " + counters.WorkingSetSize, component);

					results = counters.PagefileUsage > threshold;
				}
			}
			catch(Exception ex)
			{
				ErrorLog.LogError(ex.Message, new CallingMethod());
			}
			return results;
		}


		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		private class MEMORYSTATUSEX
		{
#pragma warning disable 169
#pragma warning disable 219
			public uint dwLength;
#pragma warning disable 649
			public uint dwMemoryLoad;
#pragma warning restore 649
			public ulong ullTotalPhys;
			public ulong ullAvailPhys;
			public ulong ullTotalPageFile;
			public ulong ullAvailPageFile;
			public ulong ullTotalVirtual;
			public ulong ullAvailVirtual;
			public ulong ullAvailExtendedVirtual;
#pragma warning restore 219
#pragma warning restore 169
			public MEMORYSTATUSEX()
			{
				dwLength = (uint)Marshal.SizeOf(typeof(MEMORYSTATUSEX));
			}
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		private class PPROCESS_MEMORY_COUNTERS
		{

			public readonly uint cb;
			public readonly uint PageFaultCount;
			public readonly uint PeakWorkingSetSize;
			public readonly uint WorkingSetSize;
#pragma warning disable 219
			public readonly uint QuotaPeakPagedPoolUsage;
			public readonly uint QuotaPagedPoolUsage;
			public readonly uint QuotaPeakNonPagedPoolUsage;
			public readonly uint QuotaNonPagedPoolUsage;
#pragma warning restore 219
			public readonly uint PagefileUsage;
			public readonly uint PeakPagefileUsage;
			public readonly uint PrivateUsage;


			public PPROCESS_MEMORY_COUNTERS()
			{
				cb = (uint)Marshal.SizeOf(typeof(PPROCESS_MEMORY_COUNTERS));
				PageFaultCount = 0;
				PeakWorkingSetSize = 0;
				WorkingSetSize = 0;
				QuotaPeakPagedPoolUsage = 0;
				QuotaPagedPoolUsage = 0;
				QuotaPeakNonPagedPoolUsage = 0;
				QuotaNonPagedPoolUsage = 0;
				PagefileUsage = 0;
				PeakPagefileUsage = 0;
				PrivateUsage = 0;
			}
		}

		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		static extern bool GlobalMemoryStatusEx([In, Out] MEMORYSTATUSEX lpBuffer);

		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("psapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
		static extern bool GetProcessMemoryInfo([In] IntPtr handle, [In, Out] PPROCESS_MEMORY_COUNTERS counters, [In] uint cb);


	}
}
