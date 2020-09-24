using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCore_MVC_RateBoard.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RateModelSql>().HasData(
                new RateModelSql
                {
                    Id= 1,
                    Country ="USA",
                    Image = "~/Images/USA.png",
                    Code ="USD",
                    FCBuy= "3.67",
                    FCSale="3.68",
                    TFRate="56"
                },
                new RateModelSql
                {
                    Id = 2,
                    Country = "AUSTRALIA",
                    Image = "~/Images/AUSTRALIA.png",
                    Code = "AUD",
                    FCBuy = "3.67",
                    FCSale = "3.68",
                    TFRate = "45"
                },
                new RateModelSql
                {
                    Id = 3,
                    Country = "BRITAN",
                    Image = "~/Images/GB.png",
                    Code = "GBP",
                    FCBuy = "3.67",
                    FCSale = "3.68",
                    TFRate = "45"
                },
                new RateModelSql
                {
                    Id = 4,
                    Country = "BAHRAIN",
                    Image = "~/Images/BAHRAIN.jpg",
                    Code = "BHD",
                    FCBuy = "3.67",
                    FCSale = "3.68",
                    TFRate = "45"
                },
                 new RateModelSql
                 {
                     Id = 5,
                     Country = "BANGLADESH",
                     Image = "~/Images/BDT.png",
                     Code = "BDT",
                     FCBuy = "3.67",
                     FCSale = "3.68",
                     TFRate = "45"
                 },
                  new RateModelSql
                  {
                      Id = 6,
                      Country = "CANADA",
                      Image = "~/Images/CANADA.jpg",
                      Code = "CAD",
                      FCBuy = "3.67",
                      FCSale = "3.68",
                      TFRate = "45"
                  },
                  new RateModelSql
                  {
                      Id = 7,
                      Country = "EURO",
                      Image = "~/Images/EURO.",
                      Code = "EUR",
                      FCBuy = "3.67",
                      FCSale = "3.68",
                      TFRate = "45"
                  },
                  new RateModelSql
                  {
                      Id = 8,
                      Country = "EGYPT",
                      Image = "~/Images/EGYPT.jpg",
                      Code = "EGP",
                      FCBuy = "3.67",
                      FCSale = "3.68",
                      TFRate = "45"
                  },
                  new RateModelSql
                  {
                      Id = 9,
                      Country = "INDIA",
                      Image = "~/Images/INDIA.png",
                      Code = "INR",
                      FCBuy = "3.67",
                      FCSale = "3.68",
                      TFRate = "45"
                  },
                  new RateModelSql
                  {
                      Id = 10,
                      Country = "KUWAIT",
                      Image = "~/Images/KUWAIT.png",
                      Code = "KWD",
                      FCBuy = "3.67",
                      FCSale = "3.68",
                      TFRate = "45"
                  },
                   new RateModelSql
                   {
                       Id = 11,
                       Country = "NEPAL",
                       Image = "~/Images/NEPAL.jpg",
                       Code = "NPR",
                       FCBuy = "3.67",
                       FCSale = "3.68",
                       TFRate = "45"
                   },
                   new RateModelSql
                   {
                       Id = 12,
                       Country = "OMAN",
                       Image = "~/Images/OMAN.png",
                       Code = "OMR",
                       FCBuy = "3.67",
                       FCSale = "3.68",
                       TFRate = "45"
                   },
                   new RateModelSql
                   {
                       Id = 13,
                       Country = "PHILIPPINES",
                       Image = "~/Images/PHP.png",
                       Code = "PHP",
                       FCBuy = "3.67",
                       FCSale = "3.68",
                       TFRate = "45"
                   },
                   new RateModelSql
                   {
                       Id = 14,
                       Country = "PAKISTAN",
                       Image = "~/Images/PAK.png",
                       Code = "PKR",
                       FCBuy = "3.67",
                       FCSale = "3.68",
                       TFRate = "45"
                   },
                    new RateModelSql
                    {
                        Id = 15,
                        Country = "SWISS",
                        Image = "~/Images/SWISS.png",
                        Code = "CHF",
                        FCBuy = "3.67",
                        FCSale = "3.68",
                        TFRate = "45"
                    },
                    new RateModelSql
                    {
                        Id = 16,
                        Country = "SAUDIA",
                        Image = "~/Images/SAUDI.png",
                        Code = "SAR",
                        FCBuy = "3.67",
                        FCSale = "3.68",
                        TFRate = "45"
                    }

                );


        }
    }
}
