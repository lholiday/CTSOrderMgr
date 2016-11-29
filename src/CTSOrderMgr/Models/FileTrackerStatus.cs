using System;
using System.Collections.Generic;

namespace CTSOrderMgr.Models
{
    public partial class FileTrackerStatus
    {
        public FileTrackerStatus()
        {
            FileTracker = new HashSet<FileTracker>();
        }

        public int FileTrackerStatusId { get; set; }
        public string Title { get; set; }

        public virtual ICollection<FileTracker> FileTracker { get; set; }
    }
}
