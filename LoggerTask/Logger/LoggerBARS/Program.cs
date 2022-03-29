using LoggerBARS;

void Logger<T>()
{
    LocalFileLogger<T> logger = new LocalFileLogger<T>();
    logger.LogInfo("info method trigger");
    logger.LogWarning("warning method trigger");
    logger.LogError("error!", new Exception());
}
Logger<Client>();
Logger<Books>();
Logger<Orders>();
public class Client
{
    public int Id { get; set; }
    public int Age { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public int Balance { get; set; }
}
public class Books
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }
}
public class Orders
{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public int BooksId { get; set; }
    public Client Client { get; set; }
    public Books Books { get; set; }
}
