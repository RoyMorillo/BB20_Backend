using Microsoft.Extensions.PlatformAbstractions;
using System.Reflection;

public partial class Program
{
    public static string XmlCommentsFilePath
    {
        get
        {
            var basePath = PlatformServices.Default.Application.ApplicationBasePath;
            var fileName = typeof(Program).GetTypeInfo().Assembly.GetName().Name + ".xml";
            return Path.Combine(basePath, fileName);
        }
    }
}
