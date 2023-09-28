namespace BB20_ContentAudios.Models.DTOs;

public class ResponseDTO<TEntity>
{
    public bool success { get; set; } = true;
    public TEntity data { get; set; }
    public ErrorDTO error { get; set; }
}
