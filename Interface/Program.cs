public interface IGeographicObject
{
    string GetInformation();
}

class River : IGeographicObject
{
    public double X { get; set; }
    public double Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double FlowSpeedCmPerSec { get; set; }
    public double TotalLength { get; set; }

    public string GetInformation()
    {
        return $"Назва: {Name}\nКоординати: ({X}, {Y})\nОпис: {Description}\nШвидкість течії: {FlowSpeedCmPerSec} см/с\nЗагальна довжина: {TotalLength} км";
    }
}

class Mountain : IGeographicObject
{
    public double X { get; set; }
    public double Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double HighestPoint { get; set; }

    public string GetInformation()
    {
        return $"Назва: {Name}\nКоординати: ({X}, {Y})\nОпис: {Description}\nНайвища точка: {HighestPoint} метрів";
    }
}