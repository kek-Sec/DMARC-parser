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
        
        public xml_parser(string filepath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filepath);

            dmarc_object dmarc = new dmarc_object();
            List< dmarc_record_object> records = new List<dmarc_record_object>();

            XmlNode org_name = doc.DocumentElement.SelectSingleNode("/feedback/report_metadata/org_name");
            XmlNode org_domain = doc.DocumentElement.SelectSingleNode("/feedback/policy_published/domain");
            XmlNode org_report_id = doc.DocumentElement.SelectSingleNode("/feedback/report_metadata/report_id");

            //build DMARC model
            dmarc.organization_name = org_name.InnerText;
            dmarc.report_id = org_report_id.InnerText;
            dmarc.domain_name = org_domain.InnerText;

            //get record data
            XmlNode source_ip = doc.DocumentElement.SelectSingleNode("/feedback/record/row/source_ip");
            XmlNode email_count = doc.DocumentElement.SelectSingleNode("/feedback/record/row/count");
            XmlNode dkim_policy_eval = doc.DocumentElement.SelectSingleNode("/feedback/record/row/policy_evaluated/dkim");
            XmlNode spf_policy_eval = doc.DocumentElement.SelectSingleNode("/feedback/record/row/policy_evaluated/spf");
            XmlNode header_from = doc.DocumentElement.SelectSingleNode("/feedback/record/identifiers/header_from");
            XmlNode auth_dkim_res = doc.DocumentElement.SelectSingleNode("/feedback/record/auth_results/dkim/result");
            XmlNode auth_spf_res = doc.DocumentElement.SelectSingleNode("/feedback/record/auth_results/spf/result");

            //add record items
            dmarc_record_object rec_obj = new dmarc_record_object();
            rec_obj.source_ip = source_ip.InnerText;
            rec_obj.email_count = email_count.InnerText;
            rec_obj.policy_evaluated_dkim = dkim_policy_eval.InnerText;
            rec_obj.policy_evaluated_spf = spf_policy_eval.InnerText;
            rec_obj.header_from = header_from.InnerText;
            rec_obj.dkim_auth_result = auth_dkim_res.InnerText;
            rec_obj.spf_auth_result = auth_spf_res.InnerText;





        }
    }
}
