// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace SwaggerTest.RestApiRef
{
    using System.Threading.Tasks;
   using Models;

    /// <summary>
    /// Extension methods for SwaggerSampleAPI.
    /// </summary>
    public static partial class SwaggerSampleAPIExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static System.Collections.Generic.IList<ValueViewModel> ApiValuesGet(this ISwaggerSampleAPI operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ISwaggerSampleAPI)s).ApiValuesGetAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<System.Collections.Generic.IList<ValueViewModel>> ApiValuesGetAsync(this ISwaggerSampleAPI operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ApiValuesGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='model'>
            /// </param>
            public static ValueViewModel ApiValuesPost(this ISwaggerSampleAPI operations, ValueViewModel model = default(ValueViewModel))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ISwaggerSampleAPI)s).ApiValuesPostAsync(model), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='model'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ValueViewModel> ApiValuesPostAsync(this ISwaggerSampleAPI operations, ValueViewModel model = default(ValueViewModel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ApiValuesPostWithHttpMessagesAsync(model, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static ValueViewModel ApiValuesByIdGet(this ISwaggerSampleAPI operations, int id)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ISwaggerSampleAPI)s).ApiValuesByIdGetAsync(id), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ValueViewModel> ApiValuesByIdGetAsync(this ISwaggerSampleAPI operations, int id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ApiValuesByIdGetWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='model'>
            /// </param>
            public static void ApiValuesByIdPut(this ISwaggerSampleAPI operations, int id, ValueViewModel model = default(ValueViewModel))
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((ISwaggerSampleAPI)s).ApiValuesByIdPutAsync(id, model), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='model'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task ApiValuesByIdPutAsync(this ISwaggerSampleAPI operations, int id, ValueViewModel model = default(ValueViewModel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.ApiValuesByIdPutWithHttpMessagesAsync(id, model, null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static void ApiValuesByIdDelete(this ISwaggerSampleAPI operations, int id)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((ISwaggerSampleAPI)s).ApiValuesByIdDeleteAsync(id), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task ApiValuesByIdDeleteAsync(this ISwaggerSampleAPI operations, int id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.ApiValuesByIdDeleteWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='model'>
            /// </param>
            public static ValueViewModel ApiValuesTestPost(this ISwaggerSampleAPI operations, ValueViewModel model = default(ValueViewModel))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ISwaggerSampleAPI)s).ApiValuesTestPostAsync(model), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='model'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ValueViewModel> ApiValuesTestPostAsync(this ISwaggerSampleAPI operations, ValueViewModel model = default(ValueViewModel), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ApiValuesTestPostWithHttpMessagesAsync(model, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
