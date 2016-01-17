using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe_LB
{
    public class AICase
    {
        public static int getAICase(bool[] CaseP1, bool[] CaseP2)
        {
            Random r = new Random();
            
            int CasePotentielle = checkBlockPossibilites(CaseP1, CaseP2);
            int CaseAReturn = -100;
            int CaseRandom = getRandomInRange(CaseP1, CaseP2);
            int CasePourWin = checkBlockPossibilites(CaseP2,CaseP1);
            bool isGoingTobeRandom = false;
            bool cannotWin = CasePourWin == 10;
            bool cannotBlock = CasePotentielle == 10;

            if (cannotWin)
            {
                if (cannotBlock)
                    isGoingTobeRandom = true;                
                else
                    CaseAReturn = CasePotentielle;
            }
            else
                CaseAReturn = CasePourWin;

            if (isGoingTobeRandom)
                CaseAReturn = CaseRandom;

            return CaseAReturn;
        }

        public static int checkBlockPossibilites(bool[] Case1, bool[] Case2)
        {
            if (Case1[0] && Case1[2] && !Case1[1] && !Case2[1]) //colone 1:1
                return 1;
            if (Case1[1] && Case1[2] && !Case1[0] && !Case2[0]) //colone 1:2
                return 0;
            if (Case1[0] && Case1[1] && !Case1[2] && !Case2[2]) //colone 1:3
                return 2;
            //--------------------------------------------------------------

            if (Case1[3] && Case1[5] && !Case1[4] && !Case2[4]) //colone 2:1
                return 4;
            if (Case1[3] && Case1[4] && !Case1[5] && !Case2[5]) //colone 2:2
                return 5;
            if (Case1[4] && Case1[5] && !Case1[3] && !Case2[3]) //colone 2:3
                return 3;                                       
            //--------------------------------------------------------------

            if (Case1[6] && Case1[8] && !Case1[7] && !Case2[7]) //colone 3:1
                return 7;
            if (Case1[6] && Case1[7] && !Case1[7] && !Case2[7]) //colone 3:2
                return 8;
            if (Case1[7] && Case1[8] && !Case1[6] && !Case2[6]) //colone 3:3
                return 6;
            //--------------------------------------------------------------

            if (Case1[0] && Case1[6] && !Case1[3] && !Case2[3]) //ligne 1:1
                return 3;
            if (Case1[0] && Case1[3] && !Case1[6] && !Case2[6]) //ligne 1:2
                return 6;
            if (Case1[3] && Case1[6] && !Case1[0] && !Case2[0]) //ligne 1:3
                return 0;
            //-------------------------------------------------------------

            if (Case1[1] && Case1[7] && !Case1[4] && !Case2[4]) //ligne 2:1
                return 4;
            if (Case1[1] && Case1[4] && !Case1[7] && !Case2[7]) //ligne 2:2
                return 7;
            if (Case1[4] && Case1[7] && !Case1[1] && !Case2[1]) //ligne 2:3
                return 1;
            //-------------------------------------------------------------

            if (Case1[2] && Case1[8] && !Case1[5] && !Case2[5]) //ligne 3:1
                return 5;
            if (Case1[2] && Case1[5] && !Case1[8] && !Case2[8]) //ligne 3:2
                return 8;
            if (Case1[5] && Case1[8] && !Case1[2] && !Case2[2]) //ligne 3:3
                return 2;
            //-------------------------------------------------------------

            if (Case1[0] && Case1[8] && !Case1[4] && !Case2[4]) //diagonale 1:1
                return 4;
            if (Case1[4] && Case1[8] && !Case1[0] && !Case2[0]) //diagonale 1:2
                return 0;
            if (Case1[0] && Case1[4] && !Case1[8] && !Case2[8]) //diagonale 1:3
                return 8;
            //-------------------------------------------------------------

            if (Case1[6] && Case1[2] && !Case1[4] && !Case2[4]) //diagonale 2:1
                return 4;
            if (Case1[4] && Case1[2] && !Case1[6] && !Case2[6]) //diagonale 2:2
                return 6;
            if (Case1[4] && Case1[6] && !Case1[2] && !Case2[2]) //diagonale 2:3
                return 2;

            return 10;
        }

        public static int getRandomInRange(bool[] Case1, bool[] Case2)
        {
            Random r = new Random();
            int number = 0;

            bool isOK = false;

            do
            {
                int Randum = r.Next(0, 8);
                if (!Case1[Randum] && !Case2[Randum])
                {
                    isOK = true;
                    number = Randum;
                }
            }
            while (!isOK);

            return number;
        }
    }
}
