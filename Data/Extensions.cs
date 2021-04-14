using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Transactions;
using System.Linq.Expressions;

namespace Data
{
    public static class Extensions
    {
        public static List<T> ToListUncommited<T>(this IQueryable<T> Query)
        {
            using (var scope = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required,
                 new System.Transactions.TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
            {
                return Query.ToList();
            }
        }

        public static async Task<List<T>> ToListAsyncUncommited<T>(this IQueryable<T> Query)
        {
            using (var scope = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required,
                 new System.Transactions.TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }, 
                 TransactionScopeAsyncFlowOption.Enabled))
            {
                return await Query.ToListAsync();
            }
        }

        public static T FirstOrDefaultUncommited<T>(this IQueryable<T> Query)
        {
            using (var scope = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required,
                 new System.Transactions.TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
            {
                return Query.FirstOrDefault();
            }
        }

        public static async Task<T> FirstOrDefaultAsyncUncommited<T>(this IQueryable<T> Query)
        {
            using (var scope = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required,
                 new System.Transactions.TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted },
                 TransactionScopeAsyncFlowOption.Enabled))
            {
                return await Query.FirstOrDefaultAsync();
            }
        }

        public static T FirstUncommited<T>(this IQueryable<T> Query)
        {
            using (var scope = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required,
                 new System.Transactions.TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
            {
                return Query.First();
            }
        }

        public static T SingleOrDefaultUncommited<T>(this IQueryable<T> Query)
        {
            using (var scope = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required,
                 new System.Transactions.TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
            {
                return Query.SingleOrDefault();
            }
        }

        public static T SingleUncommited<T>(this IQueryable<T> Query)
        {
            using (var scope = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required,
                 new System.Transactions.TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
            {
                return Query.Single();
            }
        }

        public static bool AnyUncommited<T>(this IQueryable<T> Query)
        {
            using (var scope = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required,
                 new System.Transactions.TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
            {
                return Query.Any();
            }
        }

        public static async Task<bool> AnyAsyncUncommited<T>(this IQueryable<T> Query)
        {
            using (var scope = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required,
                 new System.Transactions.TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted },
                 TransactionScopeAsyncFlowOption.Enabled))
            {
                return await Query.AnyAsync();
            }
        }

        public static int CountUncommited<T>(this IQueryable<T> Query)
        {
            using (var scope = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required,
                 new System.Transactions.TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
            {
                return Query.Count();
            }
        }

        public static int CountUncommited<T>(this IQueryable<T> Query, Expression<Func<T, bool>> expression)
        {
            using (var scope = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required,
                 new System.Transactions.TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
            {
                return Query.Count(expression);
            }
        }

        public static async Task<int> CountAsyncUncommited<T>(this IQueryable<T> Query)
        {
            using (var scope = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required,
                 new System.Transactions.TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted },
                 TransactionScopeAsyncFlowOption.Enabled))
            {
                return await Query.CountAsync();
            }
        }

        public static async Task<int> CountAsyncUncommited<T>(this IQueryable<T> Query, Expression<Func<T, bool>> expression)
        {
            using (var scope = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required,
                 new System.Transactions.TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted },
                 TransactionScopeAsyncFlowOption.Enabled))
            {
                return await Query.CountAsync(expression);
            }
        }
    }
}
