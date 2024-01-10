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
    public class Services:AuditableEntity
    {

        [Key]
        public int ServiceId {  get; set; }
        public string ServiceName { get; set; }=string.Empty;
        public string ServiceDescription { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public ICollection<ServicesProvider>? servicesprovider { get; set; }
    }
}
