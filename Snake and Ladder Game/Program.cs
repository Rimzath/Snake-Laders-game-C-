using System;
using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;
namespace HelloWorld{
    class Program{
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Snake and Ladder Game");
            Console.Write("Enter the player 1 Name: ");
            string player_1 = Console.ReadLine();

            Console.Write("Enter the player 2 Name: ");
            string player_2 = Console.ReadLine();


            int pr_1_Psn = 0;
            int pr_2_Psn = 0;

            while(pr_1_Psn<100 && pr_1_Psn<100){

                Console.Write(player_1+" Please roll the dice using r key: ");
                string x = Console.ReadLine();

                if(x=="r"){
                    Random rd = new Random();
                    int rand_num = rd.Next(1,7);

                    Console.WriteLine("Dice value "+rand_num);
                    pr_1_Psn += rand_num;
                    pr_1_Psn = CheckPosition(pr_1_Psn);

                    Console.WriteLine(player_1+", your new position is "+pr_1_Psn);

                }else{
                    Console.WriteLine("Please enter 'r' to roll dice ");

                }
                if (pr_1_Psn >= 100)
                {
                    Console.WriteLine(player_1+" wins the game!");
                    break;
                }


                Console.Write(player_2+ " Please roll the dice using r key: ");
                string y = Console.ReadLine();
                
                if(y=="r"){
                    Random rd = new Random();
                    int rand_num = rd.Next(1,7);

                    Console.WriteLine("Dice value"+rand_num);
                    pr_2_Psn += rand_num;
                    pr_2_Psn = CheckPosition(pr_2_Psn);

                    Console.WriteLine(player_2+", your new position is "+pr_2_Psn);
                }else{
                    Console.WriteLine("Please enter 'r' to roll dice ");
                    
                }
                if (pr_2_Psn >= 100)
                {
                    Console.WriteLine(player_2+" wins the game!");
                    break;
                }

            }
// This method created to find the players position
            static int CheckPosition(int position) 
        {
            // Upwared(Ladders)
            if (position == 2) return 23;
            if (position == 8) return 34;
            if (position == 20) return 77;
            if (position == 32) return 68;
            if (position == 41) return 79;
            if (position == 74) return 88;

            // Downward(Snakes)
            if (position == 29) return 9;
            if (position == 47) return 15;
            if (position == 56) return 19;
            if (position == 73) return 51;
            if (position == 82) return 42;
            if (position == 92) return 75;
            if (position == 97) return 78;
            if (position == 99) return 62;

            return position;
        }

            

            
        }
    }
}