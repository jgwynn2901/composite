#region Header
/**************************************************************************
* $Workfile: FileUtility.cs $
* 
* NAME: FnsUtility.FileUtility.cs
* 
* Innovation First Notice
* 140 Kendrick Street 
* Building A, Suite 300 
* Needham, MA 02494
* (617) 886-2600
*
* Proprietary Source Code -- Distribution restricted
*
* Copyright (c) 2011 by First Notice Systems
**************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/FnsUtility/FileUtility.cs 5     11/14/11 4:22p Pintoa $ */
#endregion

using System;
using System.Collections.Generic;
using System.IO;
using FTP;

namespace FnsUtility
{
	/// <summary>
	/// repository for refactored file utility functions
	/// </summary>
	public sealed class FileUtility
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="source">in Destination string format i.e. "FTP;user_name;password;host;directory"</param>
		/// <param name="pattern">FROIXXX* etc.</param>
		/// <returns></returns>
		public static IEnumerable<string> CheckFtpSourceForFiles (string source, string pattern)
		{
			string[] files = GetFtpFileList(source, pattern);
			foreach(string file in files)
				yield return file;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="source"></param>
		/// <param name="pattern"></param>
		/// <returns></returns>
		public static IEnumerable<string> CheckSourceForFiles(string source, string pattern)
		{
			string[] files = GetFileList(source, pattern);
			foreach (string file in files)
				yield return file;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="source"></param>
		/// <param name="destination"></param>
		/// <param name="clientCode"></param>
		/// <param name="files"></param>
		/// <returns></returns>
		public static int MoveFtpFilesToDirectory(string source, string destination, string clientCode, IEnumerable<string> files)
		{
			int count = 0;
			try
			{
				clsFTP ftp = OpenFtp(source);
				try
				{
					foreach (string file in files)
					{
						if (!string.IsNullOrEmpty(file))
						{
							string destFileName = String.Format("{0}\\{1}_{2}", destination, clientCode, file);
							ftp.DownloadFile(file, destFileName);
							if (!ftp.DeleteFile(file))
								ErrorLog.LogError(String.Format("Unable to FTP delete {0}", file), new CallingMethod());
							++count;
						}
					}
				}
				finally
				{
					ftp.CloseConnection();
				}
			}
			catch (Exception ex)
			{
				ErrorLog.LogError(ex.Message, new CallingMethod());
			}
			return count;
		}

		/// <summary>
		/// Moves the files to dir.
		/// </summary>
		static public int MoveFilesToDirectory(string source, string destination, string clientCode, IEnumerable<string> files)
		{
			int count = 0;
			try
			{
                int fileNameIndex = 0;
                string[] parms = source.Split(';');
                if (parms.Length > 1 && parms[0].Equals("FILE", StringComparison.InvariantCultureIgnoreCase))
                    fileNameIndex = 1;

				foreach (string file in files)
				{
                    if (string.IsNullOrEmpty(file)) continue;    // Prevent unnecessary exception catching due to IEnumerable<string> files caching
                    string destFileName = Path.Combine(destination, string.Format("{0}_{1}", clientCode, file));
                    File.Move(Path.Combine(parms[fileNameIndex], file), destFileName);
					++count;
				}
			}
			catch (Exception ex)
			{
				ErrorLog.LogError(ex.Message, new CallingMethod());
			}
			return count;
		}

		private static string[] GetFtpFileList (string source, string pattern)
		{
			string[] files = null;
			try
			{
				clsFTP ftp = OpenFtp(source);
				try
				{
					files = ftp.GetFileList(pattern);
				}
				finally
				{
					ftp.CloseConnection();					
				}
			}
			catch (Exception ex)
			{
				ErrorLog.DebugLog(ex.Message, "FileUtility");
			}
			return files ?? new string[] { };
		}

		private static string[] GetFileList(string source, string pattern)
		{
			string[] files = null;
			try
			{
				string[] parms = source.Split(';');
				int fileNameIndex = 0;

				if (parms.Length > 1 && parms[0].Equals("FILE", StringComparison.InvariantCultureIgnoreCase))
					fileNameIndex = 1;
				
				DirectoryInfo di = new DirectoryInfo(parms[fileNameIndex]);

				int index = 0;
				foreach (FileInfo fi in di.GetFiles(pattern))
				{
					if (files == null)
					{
						files = new string[di.GetFiles().Length];
					}
					files[index++] = fi.Name;
				}
			}
			catch (Exception ex)
			{
				ErrorLog.LogError(ex.Message, new CallingMethod());
			}
			return files ?? new string[] { };
		}

		private static clsFTP OpenFtp(string source)
		{
			try
			{
				string[] parms = source.Split(';');

				Assert.Test(parms.Length >= 5 && String.Compare(parms[0], "FTP", true) == 0,
							"CheckFtpSourceForWorkFiles parsing error");

				clsFTP ftp = new clsFTP();

				ftp.RemoteUser = parms[1];
				ftp.RemotePassword = parms[2];
				ftp.RemoteHost = parms[3];

				Assert.Test(ftp.Login(), "CheckFtpSourceForWorkFiles ftp login failed");
				Assert.Test(ftp.ChangeDirectory(parms[4]), "CheckFtpSourceForWorkFiles change directory failed");
				ftp.SetBinaryMode(true);
				return ftp;
			}
			catch (Exception ex)
			{
				ErrorLog.LogError(ex.Message, new CallingMethod());
			}
			return null;
		}


		/// <summary>
		/// Loads the binary file.
		/// </summary>
		/// <param name="file">The file.</param>
		/// <returns></returns>
		static public byte[] LoadBinaryFile(string file)
		{
			byte[] results = null;
			try
			{
				if (file.Length == 0)
					throw new ApplicationException("null or empty filename");
		
				using (BinaryReader reader = new BinaryReader(File.Open(file, FileMode.Open)))
				{
					int length = (int)reader.BaseStream.Length;
					results = reader.ReadBytes(length);
				}
			}
			catch (Exception ex)
			{
				ErrorLog.LogError("ERROR reading file: " + file + ": " + ex.Message, "LoadBinaryFile");
			}
			return results;
		}
	}
}

#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/FnsUtility/FileUtility.cs $
 * 
 * 5     11/14/11 4:22p Pintoa
 * Prevent unnecessary exception catching due to IEnumerable<string> files
 * caching.
 * 
 */
#endregion
