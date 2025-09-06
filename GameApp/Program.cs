
using GameApp.Libraries.Interface;


namespace GameApp
{

    public class Program
    {
        public static void Main(string[] args)
        {
            //used to create the object for shield
            Shield newshield = new Shield("Iron Shield", 80);
            //usee to create the object for potion
            Potion newpotion = new Potion("Healing Potion", 50);

            newshield.ShowInfo();
            newshield.UseItem();
            newpotion.ShowInfo();
            newpotion.UseItem();



            Console.WriteLine("----------------------------------------");


            Console.Write("Enter Birth Place: ");
            string birthPlace = Console.ReadLine();
            Console.Write("Enter Nationality: ");
            string nation = Console.ReadLine();

            Console.WriteLine("You are born in " + birthPlace + " and your nationality is " + nation);

            //made by Salazar and Pillar

        }

    }
}