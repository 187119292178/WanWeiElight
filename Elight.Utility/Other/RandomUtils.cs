using System;

namespace Elight.Utility.Other
{
    public class RandomUtils
    {
        public static int GetRandomInt(int start, int end)
        {
            Random rand = new Random();
            return rand.Next(start, end);
        }
    }
}
