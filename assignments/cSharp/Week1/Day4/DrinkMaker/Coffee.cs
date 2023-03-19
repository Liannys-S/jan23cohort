class Coffee : Drink
{
    string RoastValue;
    string BeanType;

    public Coffee(string name, string color, double temp, bool isCarb, int calories, string roast, string bean) : base(name, color, temp, isCarb, calories)
    {
        RoastValue = roast;
        BeanType = bean;
    }
    public override void ShowDrink()
    {
        base.ShowDrink();
        Console.WriteLine($"Roast Value: {RoastValue}");
        Console.WriteLine($"Bean Type: {BeanType}");
    }
}