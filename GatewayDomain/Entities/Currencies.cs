using GatewayDomain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatewayDomain.Entities
{
    public class Currencies:AuditableEntity
    {
     

        [Key]
        public int CurrencyId { get; set; }
        public string CurrencyArabicName { get; set; } = string.Empty;
        public string CurrencyEnglishName { get; set; } = string.Empty;
        public string CurrencyType {  get; set; } = string.Empty;
        public string CurrencyCode { get; set; }= string.Empty;
        
        public ICollection<ProviderCurrencies>? providercurrencies { get; set; }
    }
}
