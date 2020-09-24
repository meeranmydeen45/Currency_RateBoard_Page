using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCore_MVC_RateBoard.Models
{
    public class CombineData
    {
        public IEnumerable<RateModelSql> rateModels { get; set; }
        public IEnumerable<BackScreenRateSql> BackScreenRate { get; set; }

    }
}
