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
        public Providers()
        {
            providercompanies = new HashSet<ProviderCompanies>();
            providercurrencies = new HashSet<ProviderCurrencies>();
            servicesprovider = new HashSet<ServicesProvider>();
            providerpurpose = new HashSet<ProviderPurposes>();
            providercountrie = new HashSet<ProviderCountries>();
            providerprovince = new HashSet<ProviderProvinces>();
            providerregion = new HashSet<ProviderRegions>();
        }
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

        [InverseProperty(nameof(ProviderCompanies.provide))]
        public ICollection<ProviderCompanies>? providercompanies { get; set; }

        [InverseProperty(nameof(ProviderCurrencies.provide))]
        public ICollection<ProviderCurrencies>? providercurrencies { get; set; }

        [InverseProperty(nameof(ServicesProvider.provide))]
        public ICollection<ServicesProvider>? servicesprovider { get; set; }

        [InverseProperty(nameof(ProviderPurposes.provide))]
        public ICollection<ProviderPurposes>? providerpurpose { get; set; }

        [InverseProperty(nameof(ProviderCountries.provide))]
        public ICollection<ProviderCountries>? providercountrie {  get; set; }

        [InverseProperty(nameof(ProviderProvinces.provide))]
        public ICollection<ProviderProvinces>? providerprovince { get; set; }

        [InverseProperty(nameof(ProviderRegions.provide))]
        public ICollection<ProviderRegions>? providerregion { get; set; }

    }
}
