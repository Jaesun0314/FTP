using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toss.Util
{
    public struct FolderInfo
    {
        public string name;
    }

    public class FtpInfo : Object
    {
        public string host { get; set; }
        public string id { get; set; }
        public string password { get; set; }
        public int port { get; set; }
        public bool passiveMode { get; set; }
        public string remotePath { get; set; }
        public List<String> lFiles;
    }
}
