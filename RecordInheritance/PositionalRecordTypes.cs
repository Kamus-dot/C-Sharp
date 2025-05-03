namespace RecordInheritance
{
    public record PositionalCar(string Make, string Model, string Color);
    public record PositionalMiviVan (string Make, string Model, string Color, int Seating)
    :PositionalCar(Make, Model, Color);
}