namespace vue_cat_browser_api.Models;

public class CatsDatabaseSettings
{
    public string ConnectionString { get; set; } = null!;

    public string DatabaseName { get; set; } = null!;

    public string CatsCollectionName { get; set; } = null!;
}