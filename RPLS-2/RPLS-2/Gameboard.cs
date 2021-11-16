using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPLS_2
{
    internal class Gameboard
    {
        public string Run;
        public string welcome_message;
        public string rules_explained;
        public int game_mode;
        public string player_picks;
        public string rule_one;
        public string rule_two;


        public Run(string welcome_message, string rules_explained, int game_mode, string player_picks, string rule_one, string rule_two)
        {
            this.welcome_message = welcome_message;
            this.rules_explained = rules_explained;
            this.game_mode = player_response;
            this.player_picks = player_picks;
            this.rule_one = rule_one;
            this.rule_two = rule_two;
        }

        public void welcome_message()
        {
            welcome_message = Welcome to Rock, Paper, Scissors, Lizard, Spock!;
        }

        public void rules_explained()
        {
            rules_explained = Rock, Paper, Scissors, Lizard, Spock is the game of rock, paper, scissors woth a twist! Choose wether you would like to play with another person or against the computer. The first player to win 2 out of the 3 rounds will be crowned the winner!Here is some instructions for you to follow.Rock crushes Scissors, Scissors cuts Paper, Paper covers Rock, Rock crushes Lizard, Lizard poisons Spock, Spock smashes Scissors, Scissors decapitates Lizard, Lizard eats Paper, Paper disproves Spock, Spock vaporizes Rock.Now that has been explained, Enjoy the game!;
        }

        public void game_mode()
        {
            player_response = 1;

            if (player_response == 1)
            {
                Console.WriteLine("You have chosen to play against another Player!");
            }
            else if (player_response == 2)
            {
                Console.WriteLine("You have chosen to play against the Computer!");
            }
            else
            {
                Console.WriteLine("Please select either 1 or 2 to continue!");
            }
        }


        public void player_picks()
        {
            Player_one = choose_gesture;
            {
                Console.WriteLine("Player_one_input");
            }

            Player_two = choose_gesture;
            {
                Console.WriteLine("Player_two_input");
            }
        }

        public void rule_one()
        {
        public int Rock;
        public int Scissors;
        public int Paper;
        public int Lizard;
        public int Spock;
        public int Point;

            public Choose_Gesture(int Rock, int Scissors, int Paper, int Lizzard, int Spock, int Point)
            {
                this.Rock = 0;
                this.Scissors = 1;
                this.Paper = 2;
                this.Lizard = 3;
                this.Spock = 4;
                this.Point = 1;
            }
        }
        
        
                    public Option_1 == 0;
                    {
                        if (player_one.choose_gesture == 0) ;
                    }
                    {
                        else if(player_two.choose_gesture == 1);
                    }
                    {
                        Console.WriteLine("Player 1 wins");
                    }
                    {
                        Console.WriteLine(player_one.Point + 1);
                    }



                    public Option_2 == 1;
                    {
                        if (player_one.choose_gesture == 1);
                    }
                    {
                        else if (player_two.choose_gesture == 2);
                    }
                    {
                        Console.WriteLine("Player 1 wins");
                    }
                    {
                        Console.WriteLine(player_one.Point + 1);
                    }






                    public Option_3 == 2;
                    {
                        if (player_one.choose_gesture == 2);
                    }
                    {
                        else if (player_two.choose_gesture == 3);
                    }
                    {
                        Console.WriteLine("Player 1 wins");
                    }
                    {
                        Console.WriteLine(player_one.Point + 1);
                    }




                    public Option_4 == 0;
                    {
                        if (player_one.choose_gesture == 0);
                    }
                    {
                        else if (player_two.choose_gesture == 3);
                    }
                    {
                        Console.WriteLine("Player 1 wins");
                    }
                    {
                        Console.WriteLine(player_one.Point + 1);
                    }




                    public Option_5 == 3;
                    {
                        if (player_one.choose_gesture == 3);
                    }
                    {
                        else if (player_two.choose_gesture == 4);
                    }
                    {
                        Console.WriteLine("Player 1 wins");
                    }
                    {
                        Console.WriteLine(player_one.Point + 1);
                    }



                    public Option_6 == 4;
                    {
                        if (player_one.choose_gesture == 4);
                    }
                    {
                        else if (player_two.choose_gesture == 1);
                    }
                    {
                        Console.WriteLine("Player 1 wins");
                    }
                    {
                        Console.WriteLine(player_one.Point + 1);
                    }




                    public Option_7 == 1;
                    {
                        if (player_one.choose_gesture == 1);
                    }
                    {
                        else if (player_two.choose_gesture == 3);
                    }
                    {
                        Console.WriteLine("Player 1 wins");
                    }
                    {
                        Console.WriteLine(player_one.Point + 1);
                    }



                    public Option_8 == 3;
                    {
                        if (player_one.choose_gesture == 3);
                    }
                    {
                        else if (player_two.choose_gesture == 2);
                    }
                    {
                        Console.WriteLine("Player 1 wins");
                    }
                    {
                        Console.WriteLine(player_one.Point + 1);
                    }





                    public Option_9 == 2;
                    {
                        if (player_one.choose_gesture == 2) ;
                    }
                    {
                        else if (player_two.choose_gesture == 4) ;
                    }
                    {
                        Console.WriteLine("Player 1 wins");
                    }
                    {
                        Console.WriteLine(player_one.Point + 1);
                    }




                    public Option_10 == 4;
                    {
                        if (player_one.choose_gesture == 4) ;
                    }
                    {
                        else if (player_two.choose_gesture == 0) ;
                    }
                    {
                        Console.WriteLine("Player 1 wins");
                    }
                    {
                        Console.WriteLine(player_one.Point + 1);
                    }





                    public Option_11 == 0;
                    {
                        if (player_two.choose_gesture == 0) ;
                    }
                    {
                        else if (player_one.choose_gesture == 1) ;
                    }
                    {
                        Console.WriteLine("Player 2 wins");
                    }
                    {
                        Console.WriteLine(player_two.Point + 1);
                    }




                    public Option_12 == 1;
                    {
                        if (player_two.choose_gesture == 1);
                    }
                    {
                        else if (player_one.choose_gesture == 2);
                    }
                    {
                        Console.WriteLine("Player 2 wins");
                    }
                    {
                        Console.WriteLine(player_two.Point + 1);
                    }




                    public Option_13 == 2;
                    {
                        if (player_two.choose_gesture == 2);
                    }
                    {
                                else if (player_one.choose_gesture == 3);
                    }
                    {
                        Console.WriteLine("Player 2 wins");
                    }
                    {
                        Console.WriteLine(player_two.Point + 1);
                    }






                    public Option_14 == 0;
                    {
                        if (player_two.choose_gesture == 0);
                    }
                    {
                        else if (player_one.choose_gesture == 3);
                    }
                    {
                        Console.WriteLine("Player 2 wins");
                    }
                    {
                        Console.WriteLine(player_two.Point + 1);
                    }






                    public Option_15 == 3;
                    {
                        if (player_two.choose_gesture == 3);
                    }
                    {
                        else if (player_one.choose_gesture == 4);
                    }
                    {
                        Console.WriteLine("Player 2 wins");
                    }
                    {
                        Console.WriteLine(player_two.Point + 1);
                    }



                    public Option_16 == 4;
                    {
                        if (player_two.choose_gesture == 4);
                    }
                    {
                                else if (player_one.choose_gesture == 1);
                    }
                    {
                        Console.WriteLine("Player 2 wins");
                    }
                    {
                        Console.WriteLine(player_two.Point + 1);
                    }




                    public Option_17 == 1;
                    {
                        if (player_two.choose_gesture == 1);
                    }
                    {
                        else if (player_one.choose_gesture == 3);
                    }
                    {
                        Console.WriteLine("Player 2 wins");
                    }
                    {
                        Console.WriteLine(player_two.Point + 1);
                    }





                    public Option_18 == 3;
                    {
                        if (player_two.choose_gesture == 3);
                    }
                    {
                        else if (player_one.choose_gesture == 2);
                    }
                    {
                        Console.WriteLine("Player 2 wins");
                    }
                    {
                        Console.WriteLine(player_two.Point + 1);
                    }




                    public Option_19 == 2;
                    {
                        if (player_two.choose_gesture == 2);
                    }
                    {
                        else if (player_one.choose_gesture == 4);
                    }
                    {
                        Console.WriteLine("Player 2 wins");
                    }
                    {
                        Console.WriteLine(player_two.Point + 1);
                    }



                    public Option_20 == 4;
                    {
                        if (player_two.choose_gesture == 4) ;
                    }
                    {
                        else if (player_one.choose_gesture == 0) ;
                    }
                    {
                        Console.WriteLine("Player 2 wins");
                    }
                    {
                        Console.WriteLine(player_two.Point + 1);
                    }



        public int player_point;
        public bool winner_of_game;

        public rule_two(int player_point, bool winner_of_game);
        {
            this.player_point = 0;
            this.winner_of_game = true;
        }
        double player_point = 0;
        if (player_one.player_point == 2);
            winner_of_game = true;
        {
            Console.WriteLine("Winner of Game");
        }
        else if(player_two.player_point == 2);
            winner_of_game = true;
        {
            Console.WriteLine("Winner of Game");
        }
        else(player_picks());
        }
        
