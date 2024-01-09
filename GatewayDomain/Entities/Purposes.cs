using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatewayDomain.Entities
{
    public class Purposes
    {
        public Purposes()
        {
            providerpurpose = new HashSet<ProviderPurposes>();
        }
        public int PurposeId { get; set; }
        public string PurposeName { get; set; } = string.Empty;
        public string PurposeDescription { get; set; } = string.Empty;
        
        [InverseProperty(nameof(ProviderPurposes.purpose))]
        public ICollection<ProviderPurposes>? providerpurpose { get; set; }
    }
}
