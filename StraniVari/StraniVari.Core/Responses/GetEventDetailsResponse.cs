using StraniVari.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StraniVari.Core.Responses
{
    public class GetEventDetailsResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfChildren { get; set; }
        public int StartDateYear { get; set; }
    }
}
