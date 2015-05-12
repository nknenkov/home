using System;

namespace _12.ToTheStars
{
    class Program
    {
        static void Main(string[] args)
        {
            string space = "space";
            string[] firstStar = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string firstStarName = firstStar[0].ToLower();
            double firstStarX = double.Parse(firstStar[1]);
            double firstStarY = double.Parse(firstStar[2]);

            string[] secondStar = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string secondStarName = secondStar[0].ToLower();
            double secondStarX = double.Parse(secondStar[1]);
            double secondStarY = double.Parse(secondStar[2]);

            string[] thirdStar = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string thirdStarName = thirdStar[0].ToLower();
            double thirdStarX = double.Parse(thirdStar[1]);
            double thirdStarY = double.Parse(thirdStar[2]);

            string[] start = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double x = double.Parse(start[0]);
            double y = double.Parse(start[1]);
            int moves = int.Parse(Console.ReadLine());

            for (int move = 0; move <= moves; move++)
            {
                if ((x >= firstStarX - 1 && x <= firstStarX + 1) && (y >= firstStarY - 1 && y <= firstStarY + 1))
                {
                    Console.WriteLine("{0}", firstStarName);
                }
                else if ((x >= secondStarX - 1 && x <= secondStarX + 1) && (y >= secondStarY - 1 && y <= secondStarY + 1))
                {
                    Console.WriteLine("{0}", secondStarName);
                }
                else if ((x >= thirdStarX - 1 && x <= thirdStarX + 1) && (y >= thirdStarY - 1 && y <= thirdStarY + 1))
                {
                    Console.WriteLine("{0}", thirdStarName);
                }
                else
                {
                    Console.WriteLine(space);
                }
                y++;
            }
        }
    }
}
