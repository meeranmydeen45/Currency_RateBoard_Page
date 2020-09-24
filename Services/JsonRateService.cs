using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;
using WebCore_MVC_RateBoard.Models;


namespace WebCore_MVC_RateBoard.Services
{
    public class JsonRateService
    {
        private readonly IWebHostEnvironment hostingEnvironment;
        private IEnumerable<RateModel> jsonDataModel;

        public JsonRateService(IWebHostEnvironment hosting, IEnumerable<RateModel> rates)
        {
            hostingEnvironment = hosting;
            jsonDataModel = rates;
        }

        public string JsonFileName
        {
            get
            {
                return Path.Combine(hostingEnvironment.WebRootPath, "data", "Rates.json");
            }
        }


        public string JsonFileNameBackScreen
        {
            get
            {
                return Path.Combine(hostingEnvironment.WebRootPath, "data", "BackScreenRate.json");
            }
        }

        public IEnumerable<RateModel> GetRateData()
        {
            using (var jsonFile = File.OpenText(JsonFileName))
            {

                return JsonSerializer.Deserialize<RateModel[]>(jsonFile.ReadToEnd(),
                    new JsonSerializerOptions
                    {

                        PropertyNameCaseInsensitive = false
                    });

            }


        }

        public BackScreenRate GetBackScreenData()
        {
            using (var jsonFile = File.OpenText(JsonFileNameBackScreen))
            {

                return JsonSerializer.Deserialize<BackScreenRate>(jsonFile.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        //Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping, WriteIndented = true,
                        PropertyNameCaseInsensitive = false
                    });

            }


        }


        public void AddData(IEnumerable<RateModel> rateModels)
        {
            var jsonData = GetRateData();


            foreach (RateModel rateModel in rateModels)
            {
                RateModel rateModel1 = new RateModel();
                rateModel1 = jsonData.SingleOrDefault(x => x.Code == rateModel.Code);
                rateModel1.FCBuy = rateModel.FCBuy;
                rateModel1.FCSale = rateModel.FCSale;
                rateModel1.TFRate = rateModel.TFRate;


            }
            using (var outputstream = File.OpenWrite(JsonFileName))
            {
                JsonSerializer.Serialize<IEnumerable<RateModel>>(
                    new Utf8JsonWriter(outputstream, new JsonWriterOptions
                    {
                        SkipValidation = true,
                        Indented = true



                    }), jsonData
                    );


            }
        }

        public void AddBackScreenData(BackScreenRate backScreenRate)
        {


            BackScreenRate backScreenRate1 = new BackScreenRate();

            backScreenRate1.Inr = backScreenRate.Inr;
            backScreenRate1.PhpCash = backScreenRate.PhpCash;
            backScreenRate1.PhpBank = backScreenRate.PhpBank;
            backScreenRate1.Bdt = backScreenRate.Bdt;
            backScreenRate1.Pkr = backScreenRate.Pkr;



            using (var outputstream = File.OpenWrite(JsonFileNameBackScreen))
            {
                JsonSerializer.Serialize<BackScreenRate>(
                    new Utf8JsonWriter(outputstream, new JsonWriterOptions
                    {
                        SkipValidation = true,
                        Indented = true


                    }), backScreenRate1
                    );


            }

           
        }
    }
}
