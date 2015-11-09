﻿using FootlooseFS.Models;
using FootlooseFS.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FootlooseFS.EnterpriseService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPersonService" in both code and config file together.
    [ServiceContract]
    public interface IPersonService
    {
        [OperationContract]
        PageOfPersonDocuments SearchPersons(int pageNumber, PersonSearchColumn personSearchColumn, SortDirection sortDirection, int numRecordsInPage, Dictionary<PersonSearchColumn, string> criteria);
    }
}
