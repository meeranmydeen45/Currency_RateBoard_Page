using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCore_MVC_RateBoard.Models
{
    public class RateModelSql
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string Image { get; set; }
        public string Code { get; set; }
        public string? FCBuy { get; set; }
        public string? FCSale { get; set; }
        public string? TFRate { get; set; }
    }
}
