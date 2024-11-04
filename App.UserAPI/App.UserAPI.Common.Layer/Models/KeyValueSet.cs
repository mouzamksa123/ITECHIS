using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.UserAPI.Common.Layer.Models
{
    public class KeyValueSet
    {
        public Guid Id { get; set; }
        public string Value { get; set; }
        public bool IsActive { get; set; }

    }
}
