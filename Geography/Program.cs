abstract class GeographicObject
{
    public double X { get; set; }
    public double Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public abstract string GetInformation();
}

class River : GeographicObject
{
    public double FlowSpeedCmPerSec { get; set; }
    public double TotalLength { get; set; }

    public override string GetInformation()
    {
        return $"Назва: {Name}\nКоординати: ({X}, {Y})\nОпис: {Description}\nШвидкість течії: {FlowSpeedCmPerSec} см/с\nЗагальна довжина: {TotalLength} км";
    }
}

class Mountain : GeographicObject
{
    public double HighestPoint { get; set; }

    public override string GetInformation()
    {
        return $"Назва: {Name}\nКоординати: ({X}, {Y})\nОпис: {Description}\n Найвища точка: {HighestPoint} метрів";
    }
}

