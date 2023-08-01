using vue_cat_browser_api.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Newtonsoft.Json;

public class DbInitializerHostedService : IHostedService
{
  private readonly IMongoCollection<Cat> _catsCollection;

  public DbInitializerHostedService(
      IOptions<CatsDatabaseSettings> catsDatabaseSettings)
  {
    var mongoClient = new MongoClient(
        catsDatabaseSettings.Value.ConnectionString);

    var mongoDatabase = mongoClient.GetDatabase(
        catsDatabaseSettings.Value.DatabaseName);

    _catsCollection = mongoDatabase.GetCollection<Cat>(
        catsDatabaseSettings.Value.CatsCollectionName);
  }

  public async Task StartAsync(CancellationToken stoppingToken)
  {
    await _catsCollection.DeleteManyAsync(Builders<Cat>.Filter.Empty);
    StreamReader r = new StreamReader("jsons/cats.json");
    string json = r.ReadToEnd();
    var catsFromJson = JsonConvert.DeserializeObject<List<Cat>>(json);
    await _catsCollection.InsertManyAsync(catsFromJson);
  }

  public Task StopAsync(CancellationToken stoppingToken)
  {
    return Task.CompletedTask;
  }
}