using System.Net;

namespace API.Models
{
    public class PagedAPIResponse<T>: APIResponse<T> where T : class
    {
        public PageInfo? PageInfo { get; set; }

        public static PagedAPIResponse<T> Success(T data, PageInfo pageInfo, HttpStatusCode statusCode = HttpStatusCode.OK)
        {
            return new PagedAPIResponse<T> { Data = data, PageInfo = pageInfo, IsSucceed = true, Status = statusCode };
        }

        public static PagedAPIResponse<T> Success(T data, PageInfo pageInfo, string message, HttpStatusCode statusCode = HttpStatusCode.OK)
        {
            return new PagedAPIResponse<T> { Data = data, PageInfo = pageInfo, IsSucceed = true, Status = statusCode, Message = message };
        }

        public static PagedAPIResponse<T> Failure(string message, HttpStatusCode statusCode = HttpStatusCode.InternalServerError)
        {
            return new PagedAPIResponse<T> { IsSucceed = false, Status = statusCode, Message = message };
        }
    }
}
