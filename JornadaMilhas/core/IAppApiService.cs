using Detran.Common.Core;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization.Metadata;

namespace JornadaMilhas.API.Common;

public interface IAppApiService
{
    ITaskWrapperType<TResult?> RequestAsync<TRequest, TResult>(
        EndpointBase endpoint,
        TRequest value,
        JsonTypeInfo<TResult> resultJsonTypeInfo,
        IDictionary<string, string?>? queryString = null,
        CancellationToken cancellationToken = default);

    ITaskWrapperType<TResult?> RequestAsync<TResult>(
       EndpointBase endpoint,
       JsonTypeInfo<TResult> resultJsonTypeInfo,
       IDictionary<string, string?>? queryString = null,
       CancellationToken cancellationToken = default);

    ITaskWrapper RequestVoidAsync<TRequest>(
        EndpointBase endpoint,
        TRequest value,
        IDictionary<string, string?>? queryString = null,
        CancellationToken cancellationToken = default);
    ITaskWrapperType<TResult?> GetFromJsonAsync<TResult>(
        [StringSyntax("Uri")] string requestUri,
        CancellationToken cancellationToken = default);
    ITaskWrapperType<TResult?> GetFromJsonAsync<TResult>(
        [StringSyntax("Uri")] string requestUri,
        JsonTypeInfo<TResult> jsonTypeInfo,
        CancellationToken cancellationToken = default);

    ITaskWrapperType<TResult?> PostAndReturnAsJsonAsync<TRequest, TResult>(
        [StringSyntax("Uri")] string requestUri,
        TRequest value,
        CancellationToken cancellationToken = default);

    ITaskWrapperType<TResult?> PostAndReturnAsJsonAsync<TRequest, TResult>(
        [StringSyntax("Uri")] string requestUri,
        TRequest value,
        JsonTypeInfo<TResult> resultJsonTypeInfo,
        CancellationToken cancellationToken = default);

}