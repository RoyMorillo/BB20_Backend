namespace BB20_InteriorCategories.Models.DTOs;

public class ResponseDTO<TEntity>
{
    public bool success { get; set; } = true;
    public TEntity? data { get; set; }
    public ErrorDTO? error { get; set; }
}
