class Enemy
{
    public int MaxHealth;
    public string Name;
    public int Health;
    public List<Attack> AttackList;
    public Enemy(string name)
    {
        Name = name;
        Health = 100;
        MaxHealth = Health;
        AttackList = new List<Attack>();
    }
    public Enemy (string name, int maxHealth){
        Name = name;
        Health = maxHealth;
        MaxHealth = Health;
        AttackList = new List<Attack>();
    }
    public Attack RandAtk()
    {
        Random rand = new Random();
        int indexRand = rand.Next(AttackList.Count);
        return AttackList[indexRand];
    }
    public virtual void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        if (Health > 0 && Target.Health > 0)
        {
            Target.Health -= ChosenAttack.DmgAmount;
            if (Target.Health < 0)
            {
                Target.Health = 0;
            }
            Console.WriteLine($"{Name} attacks {Target.Name} with {ChosenAttack.Name}, dealing {ChosenAttack.DmgAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");

        }
        else if (Health <= 0)
        {
            Console.WriteLine($"{Name} does not have enough health to attack. Their health is {Health}.");
        }
        else
        {
            Console.WriteLine($"Stop beating the dead horse. {Target.Name} has {Target.Health} health.");
        }
    }

}