using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SqlKata.Execution.Extensions
{
    public static class QueryExtensions
    {
        public static IEnumerable<dynamic> Get(this Query query, ExecutionArguments args)
        {
            return query.Get(args.Transaction, args.QueryTimeout);
        }

        public static IEnumerable<T> Get<T>(this Query query, ExecutionArguments args)
        {
            return query.Get<T>(args.Transaction, args.QueryTimeout);
        }

        public static async Task<IEnumerable<dynamic>> GetAsync(this Query query, AsyncExecutionArguments args)
        {
            return await query.GetAsync(args.Transaction, args.QueryTimeout, args.CancellationToken);
        }

        public static async Task<IEnumerable<T>> GetAsync<T>(this Query query, AsyncExecutionArguments args)
        {
            return await query.GetAsync<T>(args.Transaction, args.QueryTimeout, args.CancellationToken);
        }

        public static dynamic First(this Query query, ExecutionArguments args)
        {
            return query.First(args.Transaction, args.QueryTimeout);
        }

        public static T First<T>(this Query query, ExecutionArguments args)
        {
            return query.First<T>(args.Transaction, args.QueryTimeout);
        }

        public static dynamic FirstOrDefault(this Query query, ExecutionArguments args)
        {
            return query.FirstOrDefault(args.Transaction, args.QueryTimeout);
        }

        public static T FirstOrDefault<T>(this Query query, ExecutionArguments args)
        {
            return query.FirstOrDefault<T>(args.Transaction, args.QueryTimeout);
        }

        public static async Task<dynamic> FirstAsync(this Query query, AsyncExecutionArguments args)
        {
            return await query.FirstAsync(args.Transaction, args.QueryTimeout, args.CancellationToken);
        }

        public static async Task<T> FirstAsync<T>(this Query query, AsyncExecutionArguments args)
        {
            return await query.FirstAsync<T>(args.Transaction, args.QueryTimeout, args.CancellationToken);
        }

        public static async Task<dynamic> FirstOrDefaultAsync(this Query query, AsyncExecutionArguments args)
        {
            return await query.FirstOrDefaultAsync(args.Transaction, args.QueryTimeout, args.CancellationToken);
        }

        public static async Task<T> FirstOrDefaultAsync<T>(this Query query, AsyncExecutionArguments args)
        {
            return await query.FirstOrDefaultAsync<T>(args.Transaction, args.QueryTimeout, args.CancellationToken);
        }

        public static PaginationResult<dynamic> Paginate(this Query query, int page, int perPage, ExecutionArguments args)
        {
            return query.Paginate(page, perPage, args.Transaction, args.QueryTimeout);
        }

        public static PaginationResult<dynamic> Paginate(this Query query, PaginationArguments paginationArgs, ExecutionArguments executionsArgs)
        {
            return query.Paginate(paginationArgs.Page, paginationArgs.PerPage, executionsArgs);
        }

        public static async Task<PaginationResult<dynamic>> PaginateAsync(this Query query, int page, int perPage, AsyncExecutionArguments args)
        {
            return await query.PaginateAsync(page, perPage, args.Transaction, args.QueryTimeout, args.CancellationToken);
        }

        public static async Task<PaginationResult<dynamic>> PaginateAsync(this Query query, PaginationArguments paginationArgs, AsyncExecutionArguments executionsArgs)
        {
            return await query.PaginateAsync(paginationArgs.Page, paginationArgs.PerPage, executionsArgs);
        }

        public static PaginationResult<T> Paginate<T>(this Query query, int page, int perPage, ExecutionArguments args)
        {
            return query.Paginate<T>(page, perPage, args.Transaction, args.QueryTimeout);
        }

        public static PaginationResult<T> Paginate<T>(this Query query, PaginationArguments paginationArgs, ExecutionArguments executionsArgs)
        {
            return query.Paginate<T>(paginationArgs.Page, paginationArgs.PerPage, executionsArgs);
        }

        public static async Task<PaginationResult<T>> PaginateAsync<T>(this Query query, int page, int perPage, AsyncExecutionArguments args)
        {
            return await query.PaginateAsync<T>(page, perPage, args.Transaction, args.QueryTimeout, args.CancellationToken);
        }

        public static async Task<PaginationResult<T>> PaginateAsync<T>(this Query query, PaginationArguments paginationArgs, AsyncExecutionArguments executionsArgs)
        {
            return await query.PaginateAsync<T>(paginationArgs.Page, paginationArgs.PerPage, executionsArgs);
        }

        public static void Chunk(this Query query, int chunkSize, Action<IEnumerable<dynamic>, int> action, ExecutionArguments args)
        {
            query.Chunk(chunkSize, action, args.Transaction, args.QueryTimeout);
        }

        public static void Chunk(this Query query, int chunkSize, Func<IEnumerable<dynamic>, int, bool> func, ExecutionArguments args)
        {
            query.Chunk(chunkSize, func, args.Transaction, args.QueryTimeout);
        }

        public static async Task ChunkAsync(this Query query, int chunkSize, Action<IEnumerable<dynamic>, int> action, AsyncExecutionArguments args)
        {
            await query.ChunkAsync(chunkSize, action, args.Transaction, args.QueryTimeout, args.CancellationToken);
        }

        public static async Task ChunkAsync(this Query query, int chunkSize, Func<IEnumerable<dynamic>, int, bool> func, AsyncExecutionArguments args)
        {
            await query.ChunkAsync(chunkSize, func, args.Transaction, args.QueryTimeout, args.CancellationToken);
        }

        public static void Chunk<T>(this Query query, int chunkSize, Action<IEnumerable<T>, int> action, ExecutionArguments args)
        {
            query.Chunk(chunkSize, action, args.Transaction, args.QueryTimeout);
        }

        public static void Chunk<T>(this Query query, int chunkSize, Func<IEnumerable<T>, int, bool> func, ExecutionArguments args)
        {
            query.Chunk(chunkSize, func, args.Transaction, args.QueryTimeout);
        }

        public static async Task ChunkAsync<T>(this Query query, int chunkSize, Action<IEnumerable<T>, int> action, AsyncExecutionArguments args)
        {
            await query.ChunkAsync(chunkSize, action, args.Transaction, args.QueryTimeout, args.CancellationToken);
        }

        public static async Task ChunkAsync<T>(this Query query, int chunkSize, Func<IEnumerable<T>, int, bool> func, AsyncExecutionArguments args)
        {
            await query.ChunkAsync(chunkSize, func, args.Transaction, args.QueryTimeout, args.CancellationToken);
        }

        public static int Update(this Query query, object data, ExecutionArguments args)
        {
            return query.Update(data, args.Transaction, args.QueryTimeout);
        }

        public static int Update(this Query query, IEnumerable<KeyValuePair<string, object>> values, ExecutionArguments args)
        {
            return query.Update(values, args.Transaction, args.QueryTimeout);
        }
        public static async Task<int> UpdateAsync(this Query query, object data, AsyncExecutionArguments args)
        {
            return await query.UpdateAsync(data, args.Transaction, args.QueryTimeout, args.CancellationToken);
        }

        public static async Task<int> UpdateAsync(this Query query, IEnumerable<KeyValuePair<string, object>> values, AsyncExecutionArguments args)
        {
            return await query.UpdateAsync(values, args.Transaction, args.QueryTimeout, args.CancellationToken);
        }

        public static int Insert(this Query query, object data, ExecutionArguments args)
        {
            return query.Insert(data, args.Transaction, args.QueryTimeout);
        }

        public static int Insert(this Query query, IEnumerable<KeyValuePair<string, object>> values, ExecutionArguments args)
        {
            return query.Insert(values, args.Transaction, args.QueryTimeout);
        }

        public static int Insert(this Query query, IEnumerable<string> colums, Query fromQuery, ExecutionArguments args)
        {
            return query.Insert(colums, fromQuery, args.Transaction, args.QueryTimeout);
        }

        public static int Insert(this Query query, IEnumerable<string> colums, IEnumerable<IEnumerable<object>> valueCollection, ExecutionArguments args)
        {
            return query.Insert(colums, valueCollection, args.Transaction, args.QueryTimeout);
        }

        public static async Task<int> InsertAsync(this Query query, object data, AsyncExecutionArguments args)
        {
            return await query.InsertAsync(data, args.Transaction, args.QueryTimeout, args.CancellationToken);
        }

        public static async Task<int> InsertAsync(this Query query, IEnumerable<KeyValuePair<string, object>> values, AsyncExecutionArguments args)
        {
            return await query.InsertAsync(values, args.Transaction, args.QueryTimeout, args.CancellationToken);
        }

        public static async Task<int> InsertAsync(this Query query, IEnumerable<string> colums, Query fromQuery, AsyncExecutionArguments args)
        {
            return await query.InsertAsync(colums, fromQuery, args.Transaction, args.QueryTimeout, args.CancellationToken);
        }

        public static async Task<int> InsertAsync(this Query query, IEnumerable<string> colums, IEnumerable<IEnumerable<object>> valueCollection, AsyncExecutionArguments args)
        {
            return await query.InsertAsync(colums, valueCollection, args.Transaction, args.QueryTimeout, args.CancellationToken);
        }

        public static T InsertGetId<T>(this Query query, object data, ExecutionArguments args)
        {
            return query.InsertGetId<T>(data, args.Transaction, args.QueryTimeout);
        }

        public static T InsertGetId<T>(this Query query, IEnumerable<KeyValuePair<string, object>> values, ExecutionArguments args)
        {
            return query.InsertGetId<T>(values, args.Transaction, args.QueryTimeout);
        }

        public static async Task<T> InsertGetIdAsync<T>(this Query query, object data, AsyncExecutionArguments args)
        {
            return await query.InsertGetIdAsync<T>(data, args.Transaction, args.QueryTimeout, args.CancellationToken);
        }

        public static async Task<T> InsertGetIdAsync<T>(this Query query, IEnumerable<KeyValuePair<string, object>> values, AsyncExecutionArguments args)
        {
            return await query.InsertGetIdAsync<T>(values, args.Transaction, args.QueryTimeout, args.CancellationToken);
        }

        public static int Delete(this Query query, ExecutionArguments args)
        {
            return query.Delete(args.Transaction, args.QueryTimeout);
        }

        public static async Task<int> DeleteAsync(this Query query, AsyncExecutionArguments args)
        {
            return await query.DeleteAsync(args.Transaction, args.QueryTimeout, args.CancellationToken);
        }

        public static T Aggregate<T>(this Query query, string aggregateOperation, string[] columns, ExecutionArguments args)
        {
            return query.Aggregate<T>(aggregateOperation, columns, args.Transaction, args.QueryTimeout);
        }

        public static async Task<T> AggregateAsync<T>(this Query query, string aggregateOperation, string[] columns, AsyncExecutionArguments args)
        {
            return await query.AggregateAsync<T>(aggregateOperation, columns, args.Transaction, args.QueryTimeout, args.CancellationToken);
        }
    }
}
