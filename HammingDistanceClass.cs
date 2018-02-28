using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class HammingDistanceClass
    {
        public int HammingDistance(int x, int y)
        {
            int dis=0;
            List<int> xx = new List<int>();
            List<int> yy = new List<int>();
            
            while(x/2!=0||x%2!=0)
            {
                xx.Add(x%2);
                x = x / 2;
            }
            while(y / 2 != 0 || y % 2 != 0)
            {
                yy.Add(y % 2);
                y = y / 2;
            }
            int xCount = xx.Count;
            int yCount = yy.Count;
            int MinCount=xCount;
            if (xCount > yCount)
            {
                while (xCount != yCount)
                {
                    yy.Add(0);
                    yCount++;
                }
            }
            else
            {
                while (xCount != yCount)
                {
                    xx.Add(0);
                    xCount++;
                }
            }

            
            for(int i=0;i<xCount;i++)
            {
                if (xx[i] != yy[i])
                    dis++;
            }

            return dis;
        }
    }
}
