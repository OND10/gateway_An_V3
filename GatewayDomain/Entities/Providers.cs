using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatewayDomain.Entities
{
    public class Providers
    {
       
        public int ProviderId { get; set; }
        public string ProviderName { get; set; } = string.Empty;
        public string ProviderEnglishName { get; set; } = string.Empty;
        public string ProviderCode { get; set; } = string.Empty;
        public string ProvidePhoneNumber { get; set; } = string.Empty;
        public string ProviderEmail { get; set; } = string.Empty;
        public string AgentCode { get; set; } = string.Empty;
        public int User_Id { get; set; }
        public string User_Name { get; set; }=string.Empty;
        public string Password { get; set; }=string.Empty;

        public ICollection<ProviderCompanies>? providercompanies { get; set; }
        public ICollection<ProviderCurrencies>? providercurrencies { get; set; }
        public ICollection<ServicesProvider>? servicesprovider { get; set; }
        public ICollection<ProviderPurposes>? providerpurpose { get; set; }
        public ICollection<ProviderCountries>? providercountrie {  get; set; }
        public ICollection<ProviderProvinces>? providerprovince { get; set; }
        public ICollection<ProviderRegions>? providerregion { get; set; }

    }
}
