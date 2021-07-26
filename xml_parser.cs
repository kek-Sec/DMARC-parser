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
            XmlDocument doc = new XmlDocument();
            doc.Load(filepath);

            dmarc_object dmarc = new dmarc_object();
            //DMARC.records = new List<dmarc_record_object>();

            XmlNode org_name = doc.DocumentElement.SelectSingleNode("/feedback/report_metadata/org_name");
            XmlNode org_domain = doc.DocumentElement.SelectSingleNode("/feedback/policy_published/domain");
            XmlNode org_report_id = doc.DocumentElement.SelectSingleNode("/feedback/report_metadata/report_id");

            //build DMARC model
            dmarc.organization_name = org_name.InnerText;
            dmarc.report_id = org_report_id.InnerText;
            dmarc.domain_name = org_domain.InnerText;

            Console.WriteLine(dmarc.ToString());




        }
    }
}
