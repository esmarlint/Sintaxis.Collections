using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Sintaxis.Collections.Filter.Extensions
{
    public static class FilterIQueryableExtension
    {
        public static IQueryable<T> FilterWhenTrue<T>(this IQueryable<T> source, Expression<Func<T, bool>> predicate)
        {
            var filteredSource = source.Where(predicate);
            if (filteredSource.Count() == source.Count()) { 
                return source;
            }

            return source;
        }
    }
}
