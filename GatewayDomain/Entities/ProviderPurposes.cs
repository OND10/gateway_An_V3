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
    public class ProviderPurposes: AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ProviderId { get; set; }
        public int PurposeId { get; set; }
        public int CompanyId { get; set; }

        [ForeignKey(nameof(ProviderId))]
        [InverseProperty(nameof(Providers.providerpurpose))]
        public Providers? provide { get; set; }

        [ForeignKey(nameof(PurposeId))]
        [InverseProperty(nameof(Purposes.providerpurpose))]
        public Purposes? purpose { get; set; }

        [ForeignKey(nameof(CompanyId))]
        [InverseProperty(nameof(Companies.providerpurpose))]
        public Companies? company { get; set; }
    }
}
