using System.Collections.Generic;

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

        public string header_from { get; set; }
        public string dkim_auth_result { get; set; }
        public string spf_auth_result { get; set; }

        public override string ToString()
        {
            return $"SOURCE IP --> {source_ip} \n EMAIL COUNT --> {email_count} \n POLICY EVALUATED DKIM --> {policy_evaluated_dkim} \n POLICY EVALUATED SPF --> {policy_evaluated_spf} \n HEADER FROM --> {header_from} \n AUTH RESULT DKIM --> {dkim_auth_result} \n AUTH RESULT SPF --> {spf_auth_result}\n";
        }
    }
}
