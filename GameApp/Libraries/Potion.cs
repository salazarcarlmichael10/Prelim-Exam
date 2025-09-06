using System.Runtime.InteropServices.Marshalling;
using GameApp.Libraries.Abstract;
namespace GameApp.Libraries.Interface
{

    public class Potion : GameItem
    {
        private int HealAmount;

        // Constructor - creates a Potion with a Name and HealingAmount value
        public Potion(string name, int healamount) : base(name)
        {
            this.HealAmount = healamount;

        }
        // Shows us what happens when you use the Potion
        public override void UseItem()
        {
            Console.WriteLine("You drank " + this.Name + ". " + "Restored " + this.HealAmount + "HP");
        }
    }
}