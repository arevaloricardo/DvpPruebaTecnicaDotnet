namespace DvpPruebaTecnica.Application.Helpers;

public static class PaginationHelper
{
    public static int CountTotalPages(int totalItems, int pageSize)
    {
        return (int)Math.Ceiling((double)totalItems / pageSize);
    }
}