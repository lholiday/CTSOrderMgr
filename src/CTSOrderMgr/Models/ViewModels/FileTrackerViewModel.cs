using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CTSOrderMgr.Models.ViewModels
{
    public class FileTrackerViewModel
    {
        public FileTrackerViewModel()
        {
            this.fileTracker = new FileTracker();
        }
        public FileTracker fileTracker { get; set; }

        public long SelectedFileTracker { get; set; }

        public IEnumerable<FileTracker> FileTrackers { get; set; }

    }
}
