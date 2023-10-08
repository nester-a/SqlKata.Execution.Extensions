using System.Data;

namespace SqlKata.Execution.Extensions
{
    public class ExecutionArguments
    {
        public IDbTransaction Transaction { get; set; }
        public int QueryTimeout { get; set; }
    }
}
