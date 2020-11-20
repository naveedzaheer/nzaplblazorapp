using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using CommonData;
using System.Collections.Generic;

namespace DemoFunc
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            List<TodoItem> items = new List<TodoItem>
            {
                new TodoItem
                {
                    Name = "Test1",
                    Description = "Test Dec1",
                    Status = true,
                    Id = 1
                },
                new TodoItem
                {
                    Name = "Test2",
                    Description = "Test Dec2",
                    Status = true,
                    Id = 1
                }
            };

            return new OkObjectResult(items);
        }
    }
}
