//Testing
//5-25 
Enemy warwick = new Enemy("Warwick");
Attack jaws = new Attack("Jaws of the Beast", 15);
Attack howl = new Attack("Primal Howl", 10);
Attack duress = new Attack("Infinite Duress", 25);

warwick.AttackList.Add(jaws);
warwick.AttackList.Add(howl);
warwick.AttackList.Add(duress);

Console.WriteLine(warwick.RandAtk().Name);