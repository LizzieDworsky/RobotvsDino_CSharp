using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotCodeOut
{
    public class Robot
    {
        public string name;
        public int health;
        public Weapon activeWeapon;

        public Robot(string roboName)
        {
            name = roboName;
            health = 300;
            activeWeapon = new Weapon();
        }

        public void Attack(Dinosaur dino)
        {
            Console.WriteLine($"{name} attacks {dino.name}.");
            dino.health -= activeWeapon.attackPower;
            Console.WriteLine($"{dino.name}'s health is now {dino.health}.");
        }

    }
}
