using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlimmerAuto.Models.ViewModel
{
    public class UsersListViewModel
    {
        public List<ApplicationUser> ApplicationUserList { get; set; }
        public PagingInfo PageInfo { get; set; }

    }
}
