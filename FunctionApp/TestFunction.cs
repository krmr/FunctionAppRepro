using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;

namespace DurableFunctionTestApp
{
    public static class TestFunction
    {
        [FunctionName("MethodAnalyzerTestCases")]
        public static async Task Run([OrchestrationTrigger] IDurableOrchestrationContext context)
        {
            RecursiveClass.RecursiveCall();
        }
    }
}