using System.Numerics;
using _3KT_Csharp;

public class Program
{
    private static List<object> _objList = [];

    public static void Main(string[] args)
    {
        #region FirstPart
        Console.WriteLine($"\n=============__1 Часть__===============");

        var firstPart = new FirstPart();

        _objList.Add(1);
        _objList.Add(1.507f);
        _objList.Add(1.493f);
        _objList.Add(5);

        var sum = firstPart.SumListElements(_objList);

        Console.WriteLine(sum);

        #endregion

        #region SecondPart
        Console.WriteLine($"\n=============__2 Часть__===============");

        var library = new List<SecondPart<Guid>>
        {
            new SecondPart<Guid>(Guid.NewGuid(), "книга 1", "автор 1", 300),
            new SecondPart<Guid>(Guid.NewGuid(), "книга 2", "автор 2", 400),
            new SecondPart<Guid>(Guid.NewGuid(), "книга 3", "автор 3", 500),
            new SecondPart<Guid>(Guid.NewGuid(), "книга 4", "автор 4", 600)
        };

        foreach (var book in library)
        {
            Console.WriteLine(book.ToString());
        }

        #endregion

        #region ThirdPart
        Console.WriteLine($"\n=============__3 Часть__===============");

        var bookExample = new SecondPart<Guid>(Guid.NewGuid(), "книга 1", "автор 1", 300);
        var genericNumber = new ThirdPart<int>(12);
        var genericBook = new ThirdPart<SecondPart<Guid>>(bookExample);

        Console.WriteLine(genericBook.ToString());
        genericBook.Reset();
        Console.WriteLine(genericBook.ToString());


        #endregion

        #region ForthPart
        Console.WriteLine($"\n=============__4 Часть__===============");

        var intCircle = new CircleChildForthPart<int>(new Vector2(0, 4), 3);
        var floatCircle = new CircleChildForthPart<float>(new Vector2(3, 1.5f), 2.3f);
        var stringCircle = new CircleChildForthPart<string>(new Vector2(1, 2.1f), "4");

        intCircle.SetRadius(3);
        floatCircle.SetRadius(4.7f);
        stringCircle.SetRadius("3");

        Console.WriteLine(intCircle.Area);
        Console.WriteLine(floatCircle.Area);
        Console.WriteLine(stringCircle.Area);


        #endregion

        #region FifthPart
        Console.WriteLine($"\n=============__5 Часть__===============");

        var floatRectangle = new RectangleChildFifthClass<float, double>(new Vector2(3, 2), 2.3f, 3.676);
        var intRectangle = new RectangleChildFifthClass<int, string>(new Vector2(3, 2), 3, "3");
        var doubleRectangle = new RectangleChildFifthClass<double, int>(new Vector2(3, 2), 4.57, 7);

        Console.WriteLine(
            $"Float прямогольник:" +
            $" MinPoint = {floatRectangle.MinPoint}," +
            $" MaxPoint = {floatRectangle.MaxPoint}");
        Console.WriteLine(
            $"Int прямогольник:" +
            $" MinPoint = {intRectangle.MinPoint}," +
            $" MaxPoint = {intRectangle.MaxPoint}");
        Console.WriteLine(
            $"Double прямогольник:" +
            $" MinPoint = {doubleRectangle.MinPoint}," +
            $" MaxPoint = {doubleRectangle.MaxPoint}");


        #endregion
    }
}