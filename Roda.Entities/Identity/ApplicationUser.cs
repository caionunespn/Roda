using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Roda.Entities.Identity;

public class ApplicationUser : IdentityUser
{
    public string Name { get; set; }
    public string Avatar { get; set; }

}