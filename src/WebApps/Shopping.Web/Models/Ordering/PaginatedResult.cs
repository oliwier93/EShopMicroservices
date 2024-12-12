namespace Shopping.Web.Models.Ordering;

public class PaginatedResult<TEntity>(int pageIndex, int pageSize, int totalCount, IEnumerable<TEntity> data)
{
    public int PageIndex { get; } = pageIndex;
    public int PageSize { get; } = pageSize;
    public int TotalCount { get; } = totalCount;
    public IEnumerable<TEntity> Data { get; } = data;
}