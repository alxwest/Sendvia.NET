using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sendvia.Api.Model
{
    public class Alert
    {
        public Guid Id { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
    }
}
