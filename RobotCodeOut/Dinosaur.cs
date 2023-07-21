using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotCodeOut
{
    public class Dinosaur
    {
        public string name;
        public int health;
        public int attackPower;

        public Dinosaur(string dinoName)
        {
            name = dinoName;
            health = 600;
            attackPower = 50;
        }

        public void Attack(Robot robo)
        {
            Console.WriteLine($"{name} attacks {robo.name}.");
            robo.health -= attackPower;
            Console.WriteLine($"{robo.name}'s health is now {robo.health}.");
        }

    }
}
