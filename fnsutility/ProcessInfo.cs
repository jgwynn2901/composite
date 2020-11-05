#region File Header
/**************************************************************************
 * 
 * Innovation First Notice
 * Proprietary Source Code -- Distribution restricted
 * Copyright (c) 2011 
 * 
 **************************************************************************/
/* $Header: $ */
#endregion

using System.Diagnostics;
namespace FnsUtility
{
    [System.Runtime.Serialization.DataContract]
    public class ProcessInfo
    {
        [System.Runtime.Serialization.DataMember]
        long PrivateMemorySize { get; set; }

        [System.Runtime.Serialization.DataMember]
        long PagedMemorySize { get; set; }

        [System.Runtime.Serialization.DataMember]
        long VirtualMemorySize { get; set; }

        [System.Runtime.Serialization.DataMember]
        long WorkingSet { get; set; }

        [System.Runtime.Serialization.DataMember]
        long PeakVirtualMemorySize { get; set; }

        [System.Runtime.Serialization.DataMember]
        long PeakWorkingSet { get; set; }

        [System.Runtime.Serialization.DataMember]
        int HandleCount { get; set; }

        [System.Runtime.Serialization.DataMember]
        int ThreadCount { get; set; }

        public ProcessInfo(Process source)
        {
            PrivateMemorySize = source.PagedMemorySize64;
            PagedMemorySize = source.PagedMemorySize64;
            VirtualMemorySize = source.VirtualMemorySize64;
            WorkingSet = source.WorkingSet64;
            PeakVirtualMemorySize = source.PeakVirtualMemorySize64;
            PeakWorkingSet = source.PeakWorkingSet64;
            HandleCount = source.HandleCount;
            ThreadCount = source.Threads.Count;
        }
    }
}

#region Log
/*
 * $Log: $
 */
#endregion