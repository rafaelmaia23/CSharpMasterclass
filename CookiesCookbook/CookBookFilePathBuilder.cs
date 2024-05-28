namespace CookiesCookbook;

public class CookBookFilePathBuilder
{
    public string BuildFilePath(AppConfig config)
    {
        return $"{config.FileName}.{config.FileFormat}";
    }
}
