namespace _3KT_Csharp;

public class SecondPart<TId>
{
    public SecondPart(TId id, string title, string author, int pagesCount)
    {
        Id = id;
        Name = title;
        Author = author;
        PagesCount = pagesCount;
    }

    public TId Id { get; }
    public string Name { get; }
    public string Author { get; }
    public int PagesCount { get; }

    public override string ToString()
    {
        return $"Id={Id}," +
               $" Title={Name}," +
               $" Author={Author}," +
               $" PagesCount={PagesCount}>";
    }
}