using FunctionValueTuple.Lib;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using System;
using System.Globalization;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;

namespace FunctionValueTuple
{
    public static class Function
    {
        [FunctionName("Function")]
        public static Task Run([HttpTrigger(WebHookType = "genericJson")]HttpRequestMessage req, TraceWriter log)
        {
            log.Info($"Webhook was triggered!");

            var sampleService = new SampleService((5, "Test string"));

            log.Info("Function finished.");
            return Task.FromResult(0);
        }
    }
}
