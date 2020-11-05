using System.Collections.Generic;
using FnsComposite.Monads;

namespace DbClassLibrary.FirstNotice
{
    /// <summary>
    /// 
    /// </summary>
   public partial class Call
    {
       private static readonly IDictionary<long, AccountHierarchyStep> ClientCache = new Dictionary<long, AccountHierarchyStep>();

       private static AccountHierarchyStep ClientFromIdCache(long id)
       {
           var client = ClientCache.TryGetTuple(id);
           if (client.First) return client.Second;
           var account = AccountHierarchyStep.AhsRecordFromId(id, DbBaseClass.FNSP);
           ClientCache.Add(id, account);
           return account;
       }

       /// <summary>
       /// Gets the AHS record for the client.
       /// </summary>
       /// <value>The client.</value>
        public AccountHierarchyStep Client
        {
            get
            {
                return ClientFromIdCache(ClientHrcyStepId);
            }
        }    
    }
}
