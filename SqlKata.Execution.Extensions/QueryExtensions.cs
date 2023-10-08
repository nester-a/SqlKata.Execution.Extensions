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
    }
}
