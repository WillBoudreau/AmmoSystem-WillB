using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmmoSystem_WillB
{
    internal class Program
    {
        // int variables
        static int[] ammo;
        static int health = 100;
        static int enemyHealth = 100;
        static string[] currentWeapon;
        static int x;
        // string varaibles
        static string answerStart;
        static string weaponSelect;
        static string toShootorNot;
       //Start
        static void Main(string[] args)
        {
            Console.WriteLine("From Will's studio");
            Console.WriteLine("------------------");
            Console.WriteLine("Cave explorers with guns!");
            Console.WriteLine("------------------");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.WriteLine("Would you like to begin, Yes or No");
            answerStart = Console.ReadLine();
            ammo = new int[4];
            ammo[0] = 32;
            ammo[1] = 12;
            ammo[2] = 64;
            ammo[3] = 2;
            currentWeapon = new string[4];
            currentWeapon[0] = "Pistol";
            currentWeapon[1] = "Shotgun";
            currentWeapon[2] = "Spreader";
            currentWeapon[3] = "RPG";
            if (answerStart == "Yes" || answerStart == "yes")
            {
                Console.WriteLine("Great lets begin\nPress any key to begin:");
                Console.ReadKey();
                Console.WriteLine("Please select a weapon:\nPistol\nShotgun\nSpreader\nRPG");
                weaponSelect = Console.ReadLine();
                if (weaponSelect == "Pistol" || weaponSelect =="pistol")
                {
                    Console.WriteLine("Great! You have selected: ");
                    Console.WriteLine(currentWeapon[0]);
                    x=0;
                    Console.ReadKey();
                    ShowHUD();
                }
            }
            if (answerStart == "no"|| answerStart == "No")
            {
                Console.WriteLine("Well...bye");
                Console.ReadKey();
            }
        }
        static void ShowHUD()
        {
            
            Console.WriteLine("+----------------------+");
            Console.WriteLine("|Health: "+health+" |");
            Console.WriteLine("|Weapon: "+currentWeapon[x]+" |");
            Console.WriteLine("|Ammo: " + ammo[x] + " |");
            Console.ReadKey();
            Console.WriteLine("Would you like to shoot or reload");
            toShootorNot = Console.ReadLine();
            if (toShootorNot == "shoot" || toShootorNot == "Shoot")
            {
                Fire();
            }
            else
            {
                Reload();
            }

        }
        static void Fire()
        {
            if (x != 2)
            {
                ammo[x]--;
                ShowHUD();
            }
            else
            {
                ammo[x]--;
                ShowHUD();
            }
        }
        static void Reload()
        {
            if(x <= 0)
            {
                ammo[x]++;
            }
        }
    }
}
