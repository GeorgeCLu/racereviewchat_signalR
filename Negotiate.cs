// Negotiate.cs
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.SignalRService;

namespace Company
{
  public static class Negotiate
  {
      [FunctionName("negotiate")]
      public static SignalRConnectionInfo GetSignalRInfo(
          [HttpTrigger(AuthorizationLevel.Anonymous, "post")] HttpRequest req,
          [SignalRConnectionInfo(HubName = "chat")] SignalRConnectionInfo connectionInfo)
      {
          return connectionInfo;
      }
  }
}