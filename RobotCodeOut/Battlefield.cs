using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotCodeOut
{
    public class Battlefield
    {
        public Dinosaur dinosaur;
        public Robot robot;

        public Battlefield()
        {
            dinosaur = new Dinosaur("Godzilla");
            robot = new Robot("Iron Giant");
        }

        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to an epic battle for the ages!");
        }

        public void Battle()
        {
            while (dinosaur.health > 0 && robot.health > 0)
            {
                dinosaur.Attack(robot);
                if (robot.health > 0)
                {
                    robot.Attack(dinosaur);
                }
            }
        }

        public void DisplayWinner()
        {
            if (robot.health > 0)
            {
                Console.WriteLine($"{robot.name} is victorious!");
            }
            else
            {
                Console.WriteLine($"{dinosaur.name} is victorious!");
            }
        }

        public void RunGame()
        {
            DisplayWelcome();
            Battle();
            DisplayWinner();
        }


    }
}
