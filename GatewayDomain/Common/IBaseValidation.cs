using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatewayDomain.Common
{
    public interface IBaseValidation
    {

        Task<string> isValid();
        

    }
}
