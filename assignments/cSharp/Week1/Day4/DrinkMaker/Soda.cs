class Soda : Drink
{
    bool IsDiet;

    public Soda(string name, string color, double temp, bool isCarb, int calories, bool isDiet) : base(name, color, temp, isCarb, calories)
    {
        IsDiet = isDiet;
    }
    public override void ShowDrink()
    {
        base.ShowDrink();
        Console.WriteLine($"Diet?: {IsDiet}");
    }
}