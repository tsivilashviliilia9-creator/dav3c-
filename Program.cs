namespace dav3c_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //GameCharacter character = new(); ეს არის საჭირო? ერორს აგდებს რადგან ცარიელია?

            Warrior warrior = new Warrior();
            warrior.Name = "Conan";
            warrior.DisplayInfo();
            warrior.Attack();
            warrior.Defend();



            Mage mage = new Mage();
            mage.Name = "Gandalf";
            mage.DisplayInfo();
            mage.Attack();
            mage.Defend();




            Archer archer = new Archer();
            archer.Name = "Legolas";
            archer.DisplayInfo();
            archer.Attack();
            archer.Defend();
        }
    }
}
