using System;
namespace LottoryApi.Models
{
    public class ResultLottory
    {
        public string Id { get; set; }
        public string TypeLottory { get; set; }
        public string ThreeNumber { get; set; }
        public string TwoNumber { get; set; }
        public DateTime RoundDate { get; set; }
    }

    public class ResultLottoryThai
    {
        public string Id { get; set; }
        public string TypeLottory { get; set; }
        public string NumberOne { get; set; }
        public string[] ThreeNumberFront { get; set; } 
        public string[] ThreeNumberBack { get; set; }
        // public string TwoNumberUp { get; set; }
        public string TwoNumberDown { get; set; }
        public DateTime RoundDate { get; set; }
    }

    public class  Key
    {
        public string KeySerial { get; set; }
    }
}