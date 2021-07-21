using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DMARC_parser
{
    class xml_parser
    {
        dmarc_object DMARC;
        
        public xml_parser(string filepath)
        {
            var xml = XDocument.Load(filepath);

            DMARC = new dmarc_object();
            DMARC.records = new List<dmarc_record_object>();

            var record_nodes = xml.Descendants("record").Where(b => b.Parent.Name == "feedback");
            


        }
    }
}
