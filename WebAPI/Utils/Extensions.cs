using System;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace WebAPI.Utils
{
    public static class Extensions
    {
        public static PagedResult<TReturn> GetPaged<TReturn, T>(this IQueryable<T> query, int page, int pageSize, IMapper mapper) 
            where T : class where TReturn : class

        {
            var result = new PagedResult<TReturn>
            {
                CurrentPage = page,
                PageSize = pageSize,
                TotalNumberOfRecords = query.Count()
            };


            var pageCount = (double)result.TotalNumberOfRecords / pageSize;
            result.TotalPages = (int)Math.Ceiling(pageCount);

            var skip = (page - 1) * pageSize;
            var projection = query.Skip(skip).Take(pageSize).ProjectTo<TReturn>(mapper.ConfigurationProvider);

            result.Results = projection.ToList();

            return result;
        }
    }
}
