
using BooksApi.Models;
using BooksApi.Repositories.Base;
using MongoDB.Driver;

namespace BooksApi.Repositories;

public class MongoBooksRepository : IBookRepository
{
    private readonly MongoClient mongoClient;
    private readonly IMongoDatabase mongoBooksDb;

    public MongoBooksRepository(string connectionoString)
    {
        this.mongoClient = new MongoClient(connectionoString);

        this.mongoBooksDb = this.mongoClient.GetDatabase("MongoBooksDb");
    }

    public async Task<Book> GetBookByIdAsync(int id)
    {
        var booksCollection = this.mongoBooksDb.GetCollection<Book>("Books");

        var mongoBook = await booksCollection.FindAsync(b => b.Id == id);

        var seachedBook = await mongoBook.FirstOrDefaultAsync();

        return seachedBook;
    }
}
