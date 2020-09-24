using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCore_MVC_RateBoard.Models;

namespace WebCore_MVC_RateBoard.Services
{
    public class SqlService
    {
        public readonly AppDbContext context;
        public IEnumerable<RateModelSql> rateModelSqls;
        public IEnumerable<BackScreenRateSql> backScreenRateSql;
        

        public SqlService(AppDbContext _context, IEnumerable<RateModelSql> _rateModelSql, IEnumerable<BackScreenRateSql> _backScreenRateSql)
        {
            context = _context;
            rateModelSqls = _rateModelSql;
            backScreenRateSql = _backScreenRateSql;
            


        }

        public IEnumerable<RateModelSql> GetRateBoardData()
        {
            rateModelSqls =  context.rateModels.ToList();
            return rateModelSqls;

        }

        public IEnumerable<BackScreenRateSql> GetBackScreenData()
        {

            backScreenRateSql = context.backScreenRates.ToList();
            return backScreenRateSql;

        }


        public void AddRateBoardData(IEnumerable<RateModelSql> rateModelsSql) 
        {

            foreach(var item in rateModelsSql)
            {
                RateModelSql modelSql = new RateModelSql();
                modelSql =  context.rateModels.Single(x => x.Code == item.Code);
                modelSql.FCBuy = item.FCBuy;
                modelSql.FCSale = item.FCSale;
                modelSql.TFRate = item.TFRate;
                context.Entry(modelSql).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();



            }

        }

        public void AddBackScreenData(IEnumerable<BackScreenRateSql> rateModels)
        {

            foreach(var item in rateModels)
            {
                BackScreenRateSql backScreenRateSql = new BackScreenRateSql();
                backScreenRateSql = context.backScreenRates.Single(x => x.Id == item.Id);
                backScreenRateSql.backRate = item.backRate;
                context.Entry(backScreenRateSql).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }

        }

        public void SetRefreshData()
        {
            RefreshStatusModel refreshStatus = new RefreshStatusModel();
            refreshStatus = context.refreshStausObj.Single(x=> x.Code == "Change");
            refreshStatus.rfStatus = true;
            context.Entry(refreshStatus).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public RefreshStatusModel GetRefreshData()
        {
            RefreshStatusModel refreshStatus = new RefreshStatusModel();
            refreshStatus = context.refreshStausObj.Single(x => x.Code == "Change");
            return refreshStatus;
        }

        public void setRefreshDataFalse()
        {
            RefreshStatusModel refreshStatus = new RefreshStatusModel();
            refreshStatus = context.refreshStausObj.Single(x => x.Code == "Change");
            refreshStatus.rfStatus = false;
            context.Entry(refreshStatus).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();

        }

    }
}
