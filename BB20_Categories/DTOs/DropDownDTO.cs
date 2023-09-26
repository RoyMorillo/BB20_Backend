using System.Runtime.Serialization;

namespace BB20_Categories.DTOs;

public class DropDownDTO
{
    [DataMember]
    public string? Code { get; set; }

    [DataMember]
    public string? Name { get; set; }
}
