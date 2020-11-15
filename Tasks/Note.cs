using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasks
{
    public struct Note
    {
        public DateTime date{ get; set; }

        public string author { get; set; }

        public string title { get; set; }

        public string description { get; set; }

        public string phone { get; set; }

        public Note (DateTime date, string author, string title, string description, string phone)
        {
            this.date = date;
            this.author = author;
            this.title = title;
            this.description = description;
            this.phone = phone;
        }
    }
}
