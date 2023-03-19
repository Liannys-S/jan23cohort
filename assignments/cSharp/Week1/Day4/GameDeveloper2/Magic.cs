class Magic : Enemy
{
    
    public Attack Fireball = new Attack("Fireball", 25);
    public Attack Lightning = new Attack("Lightning Bolt", 20);
    public Attack Strike = new Attack("Staff Strike", 10);
    public Magic(string name) : base(name, 80)
    {
        base.AttackList.Add(Fireball);
        base.AttackList.Add(Lightning);
        base.AttackList.Add(Strike);
    }
    public void Heal(Enemy target)
    {
        target.Health += 40;
        if(target.Health > target.MaxHealth){
            target.Health = target.MaxHealth;
        }
        Console.WriteLine($"{base.Name} has healed {target.Name}, {target.Name} now has {target.Health} health");
    }
}