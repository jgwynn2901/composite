#region Header
/**************************************************************************
* First Notice Systems
* 95 Wells Avenue
* Newton, MA 02459
* (617) 886-2600
*
* Proprietary Source Code -- Distribution restricted
*
* Copyright (c) 2007 by First Notice Systems
**************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/UnitOfWork.cs 7     10/12/09 5:42p John.gwynn $ */
#endregion

using System;
using System.Collections.Generic;
using System.Transactions;
using DbClassLibrary.Interfaces;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace DbClassLibrary
{
	/// <summary>
	/// Implements the UnitOfWork Pattern (Fowler POEA)
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public class UnitOfWork : IUnitOfWork
	{
		/// <summary>
		/// contains all objects marked for Insert
		/// </summary>
		protected List<IActiveRecord> InsertList = new List<IActiveRecord>();
		/// <summary>
		/// contains all objects marked for Update
		/// </summary>
		protected List<IActiveRecord> UpdateList = new List<IActiveRecord>();

		/// <summary>
		/// holds the database instance of the conection
		/// </summary>
		protected string DbInstance;
		/// <summary>
		/// Initializes a new instance of the <see cref="UnitOfWork"/> class.
		/// </summary>
		public UnitOfWork() :this(string.Empty)
		{}
		/// <summary>
		/// Initializes a new instance of the <see cref="UnitOfWork"/> class.
		/// </summary>
		/// <param name="instance">The instance.</param>
		public UnitOfWork(string instance)
		{
			DbInstance = instance;
		}
		/// <summary>
		/// Gets or sets the instance.
		/// </summary>
		/// <value>The instance.</value>
		public string Instance
		{
			get { return DbInstance; }
			set { DbInstance = value; }
		}
		/// <summary>
		/// Gets a value indicating whether this instance has work.
		/// </summary>
		/// <value><c>true</c> if this instance has work; otherwise, <c>false</c>.</value>
		public bool HasWork
		{
			get { return (InsertList.Count + UpdateList.Count) > 0; }
		}
		/// <summary>
		/// Registers the insert.
		/// </summary>
		/// <param name="obj">The obj.</param>
		public virtual void RegisterInsert(IActiveRecord obj)
		{
			AddRecordToList(InsertList, obj);
		}
		/// <summary>
		/// Registers the update.
		/// </summary>
		/// <param name="obj">The obj.</param>
		public virtual void RegisterUpdate(IActiveRecord obj)
		{
			AddRecordToList(UpdateList, obj);
		}
		/// <summary>
		/// Adds the record to list.
		/// </summary>
		/// <param name="list">The list.</param>
		/// <param name="record">The record.</param>
		private static void AddRecordToList (List<IActiveRecord> list,IActiveRecord record)
		{
			lock (list)
			{
				list.Add(record);
			}
		}
		/// <summary>
		/// Commits the inserted.
		/// </summary>
		protected virtual bool CommitInserted(Database db)
		{
			bool results = true;
			try
			{
				foreach (IActiveRecord rec in InsertList)
				{
					if (!rec.Insert(db))
						throw new ApplicationException(rec.LastError);
				}
			}
			catch (Exception ex)
			{
				LastError = ex.Message;
        GeneralUtility.LogError(LastError, ToString());
				results = false;
			}
			return results;
		}
		/// <summary>
		/// Commits the updated.
		/// </summary>
		protected virtual bool CommitUpdated(Database db)
		{
			bool results = true;
			try
			{
				foreach (IActiveRecord rec in UpdateList)
				{
					if (!rec.Update(db))
						throw new ApplicationException(rec.LastError);
				}
			}
			catch (Exception ex)
			{
        LastError = ex.Message;
        GeneralUtility.LogError(LastError, ToString());
				results = false;
			}
			return results;
		}
		/// <summary>
		/// Gets the last error message.
		/// </summary>
		/// <value>The last error.</value>
		public string LastError { get; set; }

		/// <summary>
		/// Commits this instance.
		/// </summary>
		/// <returns></returns>
		public virtual bool Commit()
		{
			bool results;
			try
			{
				GeneralUtility.DebugLog("Transaction started", ToString());
				using (var oTranScope = new TransactionScope(TransactionScopeOption.RequiresNew))
				{
					if (DbInstance.Length == 0)
					{
						DbInstance = ApplicationConfiguration.Instance.DefaultInstance;
					}
					GeneralUtility.DebugLog("Execute entered", ToString());
          var db = new Microsoft.Practices.EnterpriseLibrary.Data.Oracle.OracleDatabase(GeneralUtility.GetConnectStringFromInstance(DbInstance));
          GeneralUtility.DebugLog("Database created", ToString());

					results = CommitInserted(db);
					if (results)
					{
						if (CommitUpdated(db))
						{
							oTranScope.Complete();
							GeneralUtility.DebugLog("Transaction complete ", ToString());
						}
					}
				}
			}
			catch (Exception ex)
			{
        LastError = ex.Message;
        GeneralUtility.LogError(LastError, ToString());
				results = false;
			}
			ClearAll();
			return results;
		}
		/// <summary>
		/// Clears all.
		/// </summary>
		private void ClearAll()
		{
			while (InsertList.Count > 0)
			{
				InsertList.Remove(InsertList[0]);
			}
			while (UpdateList.Count > 0)
			{
				UpdateList.Remove(UpdateList[0]);
			}
			
		}
		/// <summary>
		/// Rollbacks this instance.
		/// </summary>
		/// <returns></returns>
		public virtual bool Rollback()
		{
			ClearAll();
			return true;
		}
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/UnitOfWork.cs $
 * 
 * 7     10/12/09 5:42p John.gwynn
 * Added an ApplicationConfiguration class for the Instance default.
 * Added LocationCode ActiveRecords and also cacheing
 * 
 * 6     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 5     10/11/07 6:08p John.gwynn
 * implemented IDataRecord and IDataReader interfaces
 * 
 * 4     8/07/07 6:15p John.gwynn
 * several fixes to default instance to registry when not supplied.
 * Specific destination support. Added ISequenceStep interface for OPM
 * 
 * 3     7/19/07 5:43p John.gwynn
 * UnitOfWork enhancements
 * 
 * 2     7/11/07 3:29p John.gwynn
 * 
 * 1     7/10/07 7:26p John.gwynn
 * Start of UnitOfWork generic implementation
 */
#endregion