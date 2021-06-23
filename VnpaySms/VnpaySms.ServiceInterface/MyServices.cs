using System;
using ServiceStack;
using VnpaySms.ServiceModel;

namespace VnpaySms.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}
