﻿using Gateway_Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatewayDomain.Entities
{
    public class ProviderProvinces
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ProviderId { get; set; }
        public int ProvinceId { get; set; }
        public int CompanyId { get; set; }

        [ForeignKey(nameof(ProviderId))]
        [InverseProperty(nameof(Providers.providerprovince))]
        public Providers? provide { get; set; }

        [ForeignKey(nameof(ProvinceId))]
        [InverseProperty(nameof(Provinces.providerprovince))]
        public Provinces? province { get; set; }

        [ForeignKey(nameof(CompanyId))]
        [InverseProperty(nameof(Companies.providerprovince))]
        public Companies? company { get; set; }

    }
}