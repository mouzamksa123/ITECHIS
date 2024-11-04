using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Context.Interface
{
    public interface IContextHelper
    {
        Guid GetUser();
        Guid GetSession();
        Guid GetToken();
        string GetClientIp();
    }
}
