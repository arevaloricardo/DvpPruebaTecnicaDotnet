namespace DvpPruebaTecnica.Application.DTOs;

public class PaginatedResponse<T>
{
    public IEnumerable<T> Items { get; set; } = [];
    public int Total { get; set; }
    public int TotalPages { get; set; }
    public int ActualPage { get; set; }
}