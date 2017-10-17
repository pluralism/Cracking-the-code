using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Exercise1010
    {

    }

    class RankNode
    {
        public int LeftSize = 0;
        public RankNode Left, Right;
        public int Data;

        public RankNode(int d)
        {
            Data = d;
        }

        public void Insert(int d)
        {
            if(d <= Data)
            {
                if (Left != null)
                    Left.Insert(d);
                else
                    Left = new RankNode(d);
                LeftSize++;
            } else
            {
                if (Right != null)
                    Right.Insert(d);
                else
                    Right = new RankNode(d);
            }
        }

        public int GetRank(int d)
        {
            if (d == Data)
                return LeftSize;
            else if(d < Data)
            {
                if (Left == null)
                    return -1;
                return Left.GetRank(d);
            } else
            {
                int rightRank = Right == null ? -1 : Right.GetRank(d);
                if (rightRank == -1)
                    return -1;
                return LeftSize + 1 + rightRank;
            }
        }
    }
}
