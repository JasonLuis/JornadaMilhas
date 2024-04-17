using System.Runtime.CompilerServices;

namespace JornadaMilhas.API.Common;

public interface ITaskWrapperType<T> : ITaskWrapperBase<ITaskWrapperType<T>>
{
    TaskAwaiter<T> GetAwaiter();
}