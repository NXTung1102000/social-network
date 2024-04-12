using Model.Enum;

namespace Model
{
    public class PagedResponse<T>(int pageNumber, int pageSize, int totalPages, int totalRecords, List<T> data) where T : class
    {
        public ErrorCode ErrorCode { get; set; } = ErrorCode.None;
        public string ErrorMessage { get; set; } = string.Empty;
        public int PageNumber { get; set; } = pageNumber;
        public int PageSize { get; set; } = pageSize;
        public int TotalPages { get; set; } = totalPages;
        public int TotalRecords { get; set; } = totalRecords;
        public IList<T> Data { get; set; } = data;
    }
}
