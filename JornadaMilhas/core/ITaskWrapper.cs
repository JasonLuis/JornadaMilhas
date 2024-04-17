using JornadaMilhas.API.Common;
using System.Runtime.CompilerServices;

namespace Detran.Common.Core;

public interface ITaskWrapper : ITaskWrapperBase<ITaskWrapper>
{
    TaskAwaiter GetAwaiter();
}
