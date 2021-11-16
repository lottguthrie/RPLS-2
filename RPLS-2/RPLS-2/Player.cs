using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPLS_2
{
    public int gesture_choice
    public int player_point
    internal class Player(int player_point, int gesture_choice);
    {
       this.gesture_choice = [];
       this.player_point = 0;
    }
    public void choose_gesture
        gesture_choice = [];

            if(gesture_choice == 0)
            {
            Console.WriteLine("You have chosen Rock!");
            }
            else if(gesture_choice == 1)
            {
            Console.WriteLine("You have chosen Scissors!");
            }
            else if (gesture_choice == 2)
            {
                Console.WriteLine("You have chosen Paper!");
            }
            else if (gesture_choice == 3)
            {
                Console.WriteLine("You have chosen Lizard!");
            }
            else if (gesture_choice == 4)
            {
                Console.WriteLine("You have chosen Spock!");
            }
            else
                        {
                        Console.WriteLine("Please try again and Enter 0 for Rock, 1 for Scissors, 2 for Paper, 3 for Lizard, 4 for Spock: ");
                    }
