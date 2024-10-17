using System.Reflection.Metadata;

namespace _3KT_Csharp;

public class ThirdPart<TGeneric>
{
    public TGeneric? Value { get; private set; }

    public ThirdPart(TGeneric? value)
    {
        Value = value;
    }

    public void Reset()
    {
        Value = default;
    }

    public override string ToString()
    {
        return Value == null ? $"кробка пуста" : $"текущий тип в коробке: {Value}";
    }
}