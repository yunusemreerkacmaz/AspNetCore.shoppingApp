using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.MsSqlServer.MvcWebUI.Entities
{
    public class CustomIdentityUser : IdentityUser
    {
        // kullanıcının birimi yada çalıştığı daire gibi veriler buraya eklenebilir
    }
}
