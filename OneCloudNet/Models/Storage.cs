using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OneCloudNet.Models
{
    public class Storage
    {
        public int ID { get; set; }

        public int? QuotaBytes { get; set; }

        public string State { get; set; }

        public StorageUser Owner { get; set; }

        public object Tasks { get; set; }
    }

    public class StorageUser
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public object SwiftApiConnection { get; set; }

        public object S3Connection { get; set; }

        public object FtpConnection { get; set; }

        public string State { get; set; }
    }
}
