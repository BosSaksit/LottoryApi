using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LottoryApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LottoryApi.Controllers
{
    [ApiController]
    [Route("[action]")]

    public class ResultLottoryController : ControllerBase
    {
        public static List<ResultLottory> ResultLottoryData = new List<ResultLottory>
        {
            // new ResultLottory { Id = Guid.NewGuid().ToString() , TypeLottory = "RTH" , ThreeNumber = "321" , TwoNumber = "99" , RoundDate = new DateTime(2020,4,21) },
            new ResultLottory { Id = Guid.NewGuid().ToString() , TypeLottory = "หวยฮานอย" , ThreeNumber = "504" , TwoNumber = "93" , RoundDate = new DateTime(2020,10,28) },
            new ResultLottory { Id = Guid.NewGuid().ToString() , TypeLottory = "หวยฮานอย" , ThreeNumber = "412" , TwoNumber = "34" , RoundDate = new DateTime(2020,10,27) },
            new ResultLottory { Id = Guid.NewGuid().ToString() , TypeLottory = "หวยฮานอย" , ThreeNumber = "025" , TwoNumber = "87" , RoundDate = new DateTime(2020,10,26) },
            new ResultLottory { Id = Guid.NewGuid().ToString() , TypeLottory = "หวยฮานอย" , ThreeNumber = "497" , TwoNumber = "21" , RoundDate = new DateTime(2020,10,25) },
            new ResultLottory { Id = Guid.NewGuid().ToString() , TypeLottory = "หวยฮานอย" , ThreeNumber = "633" , TwoNumber = "48" , RoundDate = new DateTime(2020,10,24) },
            new ResultLottory { Id = Guid.NewGuid().ToString() , TypeLottory = "หวยลาว" , ThreeNumber = "341" , TwoNumber = "63" , RoundDate = new DateTime(2020,10,26) },
            new ResultLottory { Id = Guid.NewGuid().ToString() , TypeLottory = "หวยลาว" , ThreeNumber = "996" , TwoNumber = "99" , RoundDate = new DateTime(2020,10,22) },
            new ResultLottory { Id = Guid.NewGuid().ToString() , TypeLottory = "หวยลาว" , ThreeNumber = "207" , TwoNumber = "72" , RoundDate = new DateTime(2020,10,21) },
            new ResultLottory { Id = Guid.NewGuid().ToString() , TypeLottory = "หวยลาว" , ThreeNumber = "809" , TwoNumber = "39" , RoundDate = new DateTime(2020,10,19) },
            new ResultLottory { Id = Guid.NewGuid().ToString() , TypeLottory = "หวยลาว" , ThreeNumber = "268" , TwoNumber = "22" , RoundDate = new DateTime(2020,10,15) },
        };

        public static List<ResultLottoryThai> ResultLottoryThaiData = new List<ResultLottoryThai>
        {
            new ResultLottoryThai { Id = Guid.NewGuid().ToString(), TypeLottory = "หวยรัฐบาล", NumberOne = "286051", ThreeNumberFront = new [] {"189","464"}, ThreeNumberBack = new string[]{"189","464"}, TwoNumberDown = "38",RoundDate = new DateTime(2020,10,16) },
            new ResultLottoryThai { Id = Guid.NewGuid().ToString(), TypeLottory = "หวยรัฐบาล", NumberOne = "837893", ThreeNumberFront = new [] {"757","110"}, ThreeNumberBack = new string[]{"594","595"}, TwoNumberDown = "59",RoundDate = new DateTime(2020,10,01) },
            new ResultLottoryThai { Id = Guid.NewGuid().ToString(), TypeLottory = "หวยรัฐบาล", NumberOne = "244083", ThreeNumberFront = new [] {"853","127"}, ThreeNumberBack = new string[]{"220","623"}, TwoNumberDown = "57",RoundDate = new DateTime(2020,09,16) },
            new ResultLottoryThai { Id = Guid.NewGuid().ToString(), TypeLottory = "หวยรัฐบาล", NumberOne = "999997", ThreeNumberFront = new [] {"957","342"}, ThreeNumberBack = new string[]{"636","725"}, TwoNumberDown = "98",RoundDate = new DateTime(2020,09,01) },
            new ResultLottoryThai { Id = Guid.NewGuid().ToString(), TypeLottory = "หวยรัฐบาล", NumberOne = "945811", ThreeNumberFront = new [] {"733","364"}, ThreeNumberBack = new string[]{"614","712"}, TwoNumberDown = "88",RoundDate = new DateTime(2020,08,16) }
        };

        [HttpGet]
        public ActionResult<IEnumerable<ResultLottory>> GetLottoryResultAllData()
        {
            return ResultLottoryData.ToList();
        }

        [HttpGet("{key}/{type}/{date}")]
        public ActionResult<ResultLottory> GetLottoryResultByDateAndType(string key, string type, DateTime date)
        {
            var KeySerial1 = "b8ea-e5521885f067";
            // var KeySerial2 = "a74d-1dd8f3c79597";
            if (key == KeySerial1)
            {
                var Getdata = ResultLottoryData.FirstOrDefault(it => it.TypeLottory == type && it.RoundDate.Date == date.Date);
                return Getdata;
            }
            return null;
        }

        [HttpGet("{key}/{type}/{date}")]
        public ActionResult<ResultLottoryThai> GetLottoryResultThaiByDateAndType(string key, string type, DateTime date)
        {
            var KeySerial1 = "b8ea-e5521885f067";
            // var KeySerial2 = "a74d-1dd8f3c79597";
            if (key == KeySerial1)
            {
                var Getdata2 = ResultLottoryThaiData.FirstOrDefault(it => it.TypeLottory == type && it.RoundDate.Date == date.Date);
                return Getdata2;
            }
            return null;
        }


        // [HttpGet("{date}")]
        // public string TestDate(DateTime date)
        // {
        //     var da = DateTime.Now;
        //     var da0 = DateTime.Now.Date.ToString();
        //     var da00 = DateTime.UtcNow.ToString();
        //     var da01 = DateTime.UtcNow.Date.ToString();
        //     var da2 = date.Date.ToString();

        //     if (da2 == da0)
        //     {
        //         return "true" + da2 + "----" + da0;
        //     }
        //     string da3 = da.ToString() + "///" + da0.ToString() + "///" + da00.ToString() + "///" + da01.ToString() + "///" + da2.ToString();
        //     return (da3);
        // }

    }
}