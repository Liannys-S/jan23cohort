class Wine : Drink
{
    string Region;
    int YearBottled;
    public Wine(string name, string color, double temp, bool isCarb, int calories, string region, int year) : base(name, color, temp, isCarb, calories)
    {
        Region = region;
        YearBottled = year;
    }
    public override void ShowDrink()
    {
        base.ShowDrink();
        Console.WriteLine($"Region: {Region}");
        Console.WriteLine($"Year Bottled: {YearBottled}");
    }
}