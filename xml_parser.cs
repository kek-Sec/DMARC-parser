using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DMARC_parser
{
    class xml_parser
    {
        dmarc_object DMARC;
        
        public xml_parser(string filepath)
        {
            XmlDocument xDoc = new XmlDocument();

            xDoc.Load(filepath);

            DMARC = new dmarc_object();
            DMARC.records = new List<dmarc_record_object>();

            XmlNodeList name = xDoc.GetElementsByTagName("myName");

        }
    }
}
