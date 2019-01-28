using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BowlingGroup2.Models;

namespace BowlingGroup2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SetUpView());

            for (int i = 0; i < 10; i++)
            {
                Player.addScore(i, Frame());
            }

        }

        static int Frame()
        {
            int firstBowl = 0;
            int secondBowl = 0;

            firstBowl = Die.GetNextBowl(10);
            secondBowl = Die.GetNextBowl(10-firstBowl);

            return secondBowl + firstBowl;
        }
    }
}
