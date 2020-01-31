using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP4911WebAPI.ViewModels
{
    public class AvailableUsername
    {
        public string Username { get; set; }

        public AvailableUsername(string user)
        {
            this.Username = user;
        }
    }
}
