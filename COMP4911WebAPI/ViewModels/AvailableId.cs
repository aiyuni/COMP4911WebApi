using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP4911WebAPI.ViewModels
{
    /**Model to represent an available Employee Id */
    public class AvailableId
    {
        public int Id { get; set; }

        public AvailableId(int id)
        {
            this.Id = id;
        }
    }
}
