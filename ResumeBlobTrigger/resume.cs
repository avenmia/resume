using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace resume
{
    public static class Resume
    {
        [FunctionName("Resume")]
        public static void Run([BlobTrigger("mikesresume/{name}", Connection = "AzureWebJobsStorage")]Stream myBlob, string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name: {name} \n Size: {myBlob.Length} Bytes");
        }
    }
}
