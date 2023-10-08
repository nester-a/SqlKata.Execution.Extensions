using System.Threading;

namespace SqlKata.Execution.Extensions
{
    public class AsyncExecutionArguments : ExecutionArguments
    {
        public CancellationToken CancellationToken { get; set; }
    }
}
