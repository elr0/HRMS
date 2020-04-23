using System;
using System.Collections.Generic;

namespace HRMS.Models
{
    public partial class RequestStatus
    {
        public RequestStatus()
        {
            Request = new HashSet<Request>();
        }

        public int IdRequestStatus { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<Request> Request { get; set; }
    }
}
