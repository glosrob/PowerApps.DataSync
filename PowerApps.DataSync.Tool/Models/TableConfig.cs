using System.Collections.Generic;

namespace PowerApps.DataSync.Tool.Models
{
    internal class TableConfig
    {
        internal TableConfig()
        {
            Fields = new List<string>();
        }

        internal string Name { get; set; }

        internal string Schema { get; set; }

        internal string PrimaryField { get; set; }

        internal string SyncAttribute { get; set; }

        internal string IdAttribute { get; set; }

        internal string DisplayAttribute { get; set; }

        internal List<string> Fields { get; set; }

        internal string Filter { get; set; }

        internal int Order { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
