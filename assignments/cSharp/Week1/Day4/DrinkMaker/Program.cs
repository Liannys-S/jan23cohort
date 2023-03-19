List<Drink> allBeverages = new List<Drink>();
Coffee coffee = new Coffee("Cuban Coffee","Black",110.5,false,20,"Dark","Mister Beans");
Wine wine = new Wine("Red Wine", "Red",30,false,80,"Some place",2002);
Soda soda = new Soda("Sprite", "Clear",15,true,200,false);
allBeverages.Add(coffee);
allBeverages.Add(wine);
allBeverages.Add(soda);

foreach(var drink in allBeverages){
    drink.ShowDrink();
    Console.WriteLine("-----------------");
}
//Coffee myDrink = new Soda("some Name","Some color",20,true,100,false);
//Cannot implicitly convert type Soda to Coffee 