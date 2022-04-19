// See https://aka.ms/new-console-template for more information
using Snake_and_Ladder;

Console.WriteLine("Welcome to Snake and Ladder Simulator!!!");
Uc1 test = new Uc1();
Uc2 test2 = new Uc2();
Console.WriteLine("Position of Player is Intiallly at : " +test.positionOfPlayer1);
int current_position= test.positionOfPlayer1+ test2.RollingDice();
Console.WriteLine(current_position);