using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMARC_parser
{
    public class dmarc_object
    {
        public string organization_name { get; set; }
        public string domain_name { get; set; }
        public string report_id { get; set; }

        public List<dmarc_record_object> records { get; set; }

        public override string ToString()
        {
            return $"ORG NAME -> {organization_name} \n DOMAIN -> {domain_name} \n ID -> {report_id}";
        }
    }

    public class dmarc_record_object
    {
        public string source_ip { get; set; }
        public string email_count { get; set; }
        public string policy_evaluated_dkim { get; set; }
        public string policy_evaluated_spf { get; set; }
        public string dkim_auth_result { get; set; }
        public string dkim_auth_domain { get; set; }
        public string spf_auth_result { get; set; }
        public string spf_auth_domain { get; set; }
    }
}
