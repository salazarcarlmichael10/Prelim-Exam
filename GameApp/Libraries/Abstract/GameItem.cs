

using GameApp.Libraries.Interface;
namespace GameApp.Libraries.Abstract
{

    // an abstract class which allows other class to inherit it
    public abstract class GameItem
    {
        // a variable to store the item’s name
        public string Name;



        // a constructor - runs when you make a new item
        public GameItem(string itemName)
        {
            this.Name = itemName;
        }

        // it is a method which can be called to show the item’s info.
        public void ShowInfo()
        {
            Console.WriteLine("Item: " + this.Name);
        }

        public abstract void UseItem();

    }
}