using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Soldier soldier = new Soldier();
            Command shoot = new ShootCommand(soldier);
            Command rush = new RushCommand(soldier);
            Officer officer = new Officer();
            officer.SetOrder(rush);
            officer.Notify();

            officer.SetOrder(shoot);
            officer.Notify();

            Console.Read();
        }
    }
}
