using System;
using TrainWatch.Services;

namespace TestingConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var sjservice = new SJApiService();
            var res = sjservice.GetAllTrainStationInformations().Result;
        }
    }
}