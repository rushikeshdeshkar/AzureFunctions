using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace QueueFuncApDemo
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static void Run([ServiceBusTrigger("sendertopic", "testsubscription", Connection = "Endpoint=sb://rushiservicebus.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=IKRWzbW3e1XHnyGmPKIHxU42ngtHtO86IItiR9YUxHo=")]string mySbMsg, ILogger log)
        {
            log.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
        }
        //public static void Run([ServiceBusTrigger("sendertopic", "testsubscription", Connection = "Endpoint=sb://rushiservicebus.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=RL+uE/KwEL90PmqRt2yiKqpaL/ATW5E2+WGyFVDW8ME=")]string mySbMsg, ILogger log)
        //{
        //    log.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
        //}
    }
}
