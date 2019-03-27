﻿using Skoruba.IdentityServer4.Admin.Configuration.Identity;
using System.Collections.Generic;

namespace Skoruba.IdentityServer4.Admin.Configuration.Interfaces
{
    public interface IUserDataConfiguration
    {
        List<Role> Roles { get; set; }
        List<User> Users { get; set; }
    }
}