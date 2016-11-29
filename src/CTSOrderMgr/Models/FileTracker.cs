using System;
using System.Collections.Generic;

namespace CTSOrderMgr.Models
{
    public partial class FileTracker
    {
        public int FileTrackerId { get; set; }
        public int FileId { get; set; }
        public int FileTrackerStatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDatetime { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDatetime { get; set; }
        public string Notes { get; set; }
        public bool Active { get; set; }
        public bool Hide { get; set; }

        public virtual FileTrackerStatus FileTrackerStatus { get; set; }
    }
}
