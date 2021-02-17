/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 6.14.0.20201015.001
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Threading;
using System.Threading.Tasks;

namespace Org.OpenAPITools.Client
{
    /// <summary>
    /// Utility functions for sync over async situations.
    /// </summary>
    public static class AsyncHelper
    {
        //https://cpratt.co/async-tips-tricks/

        private static readonly TaskFactory _taskFactory = new TaskFactory(
                                                                CancellationToken.None,
                                                                TaskCreationOptions.None,
                                                                TaskContinuationOptions.None,
                                                                TaskScheduler.Default
                                                            );

        public static TResult RunSync<TResult>(Func<Task<TResult>> func)
            =>
                _taskFactory
                    .StartNew(func)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();

        public static void RunSync(Func<Task> func)
            =>
                _taskFactory
                    .StartNew(func)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
    }
}