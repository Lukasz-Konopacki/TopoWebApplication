 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Topo.Model;
using System.Globalization;

namespace Topo.ViewModel
{
    public class RegionViewModel
    {
        public Region Region { get; set; }
        public int RoutesNumber { get; set; }
        public int[] DifficultyChar { get; set; }
        public Dictionary<Rock, int[]> DifficultyRock { get; set; }
        public NumberFormatInfo nfi {get; set;}

        public RegionViewModel(Region region)
        {
            Region = region;
            RoutesNumber = CountRoutes();
            DifficultyChar = CountDifficulty();
            DifficultyRock = CountRockDifficulty();
            nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
        }

        public int CountRoutes()
        {
            int counter = 0;
            if(Region != null)
            {
                foreach(var Rock in Region.Rocks)
                {
                    counter += Rock.Routes.Count;
                }
            }

            return counter;
        }

        public int[]CountDifficulty()
        {
            int[] DifficultyChar = new int[6];


            foreach (var Rock in Region.Rocks)
            {
                foreach(var Route in Rock.Routes)
                {
                    if (Route.Difficulty < Difficulty._5am)
                        DifficultyChar[0]++;
                    else if (Route.Difficulty > Difficulty._4cp && Route.Difficulty < Difficulty._6am)
                        DifficultyChar[1]++;
                    else if (Route.Difficulty > Difficulty._5cp && Route.Difficulty < Difficulty._7am)
                        DifficultyChar[2]++;
                    else if (Route.Difficulty > Difficulty._6cp && Route.Difficulty < Difficulty._8am)
                        DifficultyChar[3]++;
                    else if (Route.Difficulty > Difficulty._7cp && Route.Difficulty < Difficulty._9am)
                        DifficultyChar[4]++;
                    else if (Route.Difficulty > Difficulty._8cp && Route.Difficulty <= Difficulty._9cp)
                        DifficultyChar[5]++;
                }
            }
            return DifficultyChar;
        }

        public Dictionary<Rock, int[]> CountRockDifficulty()
        {
            Dictionary<Rock, int[]> result = new Dictionary<Rock, int[]>();

            foreach (var Rock in Region.Rocks)
            {
                result[Rock] = new int[6];
                foreach (var Route in Rock.Routes)
                {
                    if (Route.Difficulty < Difficulty._5am)
                        result[Rock][0]++;
                    else if (Route.Difficulty > Difficulty._4cp && Route.Difficulty < Difficulty._6am)
                        result[Rock][1]++;
                    else if (Route.Difficulty > Difficulty._5cp && Route.Difficulty < Difficulty._7am)
                        result[Rock][2]++;
                    else if (Route.Difficulty > Difficulty._6cp && Route.Difficulty < Difficulty._8am)
                        result[Rock][3]++;
                    else if (Route.Difficulty > Difficulty._7cp && Route.Difficulty < Difficulty._9am)
                        result[Rock][4]++;
                    else if (Route.Difficulty > Difficulty._8cp && Route.Difficulty <= Difficulty._9cp)
                        result[Rock][5]++;
                }
            }

            return result;
        }


    }
}
