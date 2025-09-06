using GameApp.Libraries.Abstract;
namespace GameApp.Libraries.Interface
{
    public class Shield : GameItem
    {
        private int Defense;

        // Constructor - creates a Shield with a Name and Defense value
        public Shield(string name, int defense) : base(name)
        {
            this.Defense = defense;
        }



        // Show us what happens when you use the Shield
        public override void UseItem()
        {
            Console.WriteLine("You equipped " + this.Name + ". " + "Defense Increase by " + this.Defense);
        }
    }


}