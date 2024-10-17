namespace _3KT_Csharp;

public class FirstPart
{
    public float SumListElements(List<Object> objectList)
    {
        float finalResult = 0;
        
        foreach (var obj in objectList)
        {
            var floatNumber = Convert.ToSingle(obj);

            finalResult += floatNumber;
        }

        return finalResult;
    }
}