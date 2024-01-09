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
    public class Provinces
    {
        public Provinces()
        {
            providerprovince = new HashSet<ProviderProvinces>();
        }

        [Key]
        public int ProvinceId { get; set; }
        public string ProvinceName { get; set; } = null!;
        public string ProvinceDescription { get; set; } = string.Empty;

        [InverseProperty(nameof(ProviderProvinces.province))]
        public ICollection<ProviderProvinces>? providerprovince {  get; set; }
    }
}
