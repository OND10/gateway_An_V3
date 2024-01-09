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
    public class Regions
    {

        public Regions()
        {
            providerregion = new HashSet<ProviderRegions>();
        }

        [Key]
        public int RegionId { get; set; }

        public string RegioName { get; set; } = null!;

        public string RegioDescription { get; set; } = string.Empty;

        [InverseProperty(nameof(ProviderRegions.region))]
        public ICollection<ProviderRegions>? providerregion { get; set; }

    }
}
