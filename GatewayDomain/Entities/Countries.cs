using GatewayDomain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gateway_Domain.Entities
{
    public class Countries
    {

        public Countries()
        {
                providercountrie = new HashSet<ProviderCountries>();
        }

        [Key]
        public int CountryId { get; set; }
        public string CountryName { get; set; } = null!;
        public string CountryCode { get; set; }=string.Empty;
        public string CountryDescription { get; set; }= string.Empty;

        [InverseProperty(nameof(ProviderCountries.country))]
        public ICollection<ProviderCountries>? providercountrie {  get; set; }

    }
}
