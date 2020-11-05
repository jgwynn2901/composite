#region Header
/**************************************************************************
 * Innovation First Notice
 * 199 Wells Ave
 * Newton, MA 02459
* (617) 886-2600
 *
 * Proprietary Source Code -- Distribution restricted
 *
 * © 2013 Innovation First Notice, http://www.innovation-group.com/us
 **************************************************************************/
#endregion

using System;

namespace FnsComposite.Interfaces
{
    public interface IDriver
    {
        String PolicyId { get; }
        String Ssn { get; }
        String UploadKey { get; }
        String NameFirst { get; }
        String NameLast { get; }
        String Address1 { get; }
        String Address2 { get; }
        String City { get; }
        String State { get; }
        String Zip { get; }
        String Phone { get; }
        String RelationToInsured { get; }
        String LicenseNumber { get; }
        String ActiveStartDate { get; }
        String ActiveEndDate { get; }
        String FileTransmissionLogId { get; }
        String DriverNumber { get; }
        String BirthDate { get; }
        String Gender { get; }
    }
}
