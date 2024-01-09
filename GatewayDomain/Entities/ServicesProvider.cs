using Gateway_Domain.Entities;
using GatewayDomain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatewayDomain.Entities
{
    public class ServicesProvider: AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ProviderId { get; set; }
        public int ServiceId { get; set; }
        public int CompanyId { get; set; }

        [ForeignKey(nameof(ProviderId))]
        [InverseProperty(nameof(Providers.servicesprovider))]
        public Providers? provide { get; set; }

        [ForeignKey(nameof(ServiceId))]
        [InverseProperty(nameof(Services.servicesprovider))]
        public Services? service { get; set; }

        [ForeignKey(nameof(CompanyId))]
        [InverseProperty(nameof(Companies.servicesprovider))]
        public Companies? company { get; set; }

    }
}
