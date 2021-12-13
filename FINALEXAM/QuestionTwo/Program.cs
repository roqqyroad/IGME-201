using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            // PART A
            Console.WriteLine("Enter a string:\t");
            string str = Console.ReadLine();

            // END OF PART A


            // PART C
            string copyStr = str;
            //convert it to a character array
            char[] charArr = copyStr.ToCharArray();

            for (int i = 0, k = str.Length - 1; i < k; i++, k--)
            {
                charArr[i] = copyStr[k];
                charArr[k] = copyStr[i];
            }

            copyStr = new string(charArr);
            Console.WriteLine("Your string reversed is: " + copyStr);

            //END OF C



            //PART D 

            if(copyStr == str)
            {
                Console.WriteLine("This string is an exact palindrome!");
            }

            //END OF PART D


            //PART B
            int aCount = 0;
            int bCount = 0;
            int cCount = 0;
            int dCount = 0;
            int eCount = 0;
            int fCount = 0;
            int gCount = 0;
            int hCount = 0;
            int iCount = 0;
            int jCount = 0;
            int kCount = 0;
            int lCount = 0;
            int mCount = 0;
            int nCount = 0;
            int oCount = 0;
            int pCount = 0;
            int qCount = 0;
            int rCount = 0;
            int sCount = 0;
            int tCount = 0;
            int uCount = 0;
            int vCount = 0;
            int wCount = 0;
            int xCount = 0;
            int yCount = 0;
            int zCount = 0;
            int spCount = 0;

            int strLength = str.Length;
            //Console.WriteLine(strLength);
            string lowerStr = str.ToLower();
            int strSlot = 0;

            while (strSlot < strLength) {
                if (str[strSlot] == 'a') {
                    aCount++;
                }
                else if (str[strSlot] == 'b')
                {
                    bCount++;
                }
                else if (str[strSlot] == 'c')
                {
                    cCount++;
                }
                else if (str[strSlot] == 'd')
                {
                    dCount++;
                }
                else if (str[strSlot] == 'e')
                {
                    eCount++;
                }
                else if (str[strSlot] == 'f')
                {
                    fCount++;
                }
                else if (str[strSlot] == 'g')
                {
                    gCount++;
                }
                else if (str[strSlot] == 'h')
                {
                    hCount++;
                }
                else if (str[strSlot] == 'i')
                {
                    iCount++;
                }
                else if (str[strSlot] == 'j')
                {
                    jCount++;
                }
                else if (str[strSlot] == 'k')
                {
                    kCount++;
                }
                else if (str[strSlot] == 'l')
                {
                    lCount++;
                }
                else if (str[strSlot] == 'm')
                {
                    mCount++;
                }
                else if (str[strSlot] == 'n')
                {
                    nCount++;
                }
                else if (str[strSlot] == 'o')
                {
                    oCount++;
                }
                else if (str[strSlot] == 'p')
                {
                    pCount++;
                }
                else if (str[strSlot] == 'q')
                {
                    qCount++;
                }
                else if (str[strSlot] == 'r')
                {
                    rCount++;
                }
                else if (str[strSlot] == 's')
                {
                    sCount++;
                }
                else if (str[strSlot] == 't')
                {
                    tCount++;
                }
                else if (str[strSlot] == 'u')
                {
                    uCount++;
                }
                else if (str[strSlot] == 'v')
                {
                    vCount++;
                }
                else if (str[strSlot] == 'w')
                {
                    wCount++;
                }
                else if (str[strSlot] == 'x')
                {
                    xCount++;
                }
                else if (str[strSlot] == 'y')
                {
                    yCount++;
                }
                else if (str[strSlot] == 'z')
                {
                    zCount++;
                }
                else if (str[strSlot] == ' ')
                {
                    spCount++;
                }
            }
            Console.WriteLine("Here are the amounts of each letter or space in your string, \n uppercase and lowercase are counted as the same and numbers or special characters are not accounted for here.: \n A: " + aCount + " B: " + bCount + " C: " + cCount + " D: " + dCount + " E: " + eCount + " F: " + fCount + " G: " + gCount + " H: " + hCount + " I: " + iCount + " J: " + jCount + " K: " + kCount + " L: " + lCount + " M: " + mCount + " N: " + nCount + " O: " + oCount + " P: " + pCount + " Q: " + qCount + " R: " + rCount + " S: " + sCount + " T: " + tCount + " U: " + uCount + " V: " + vCount + " W: " + wCount + " X: " + xCount + " Y: " + yCount + " Z: " + zCount + " sp (spaces): " + spCount);
            //END OF PART B

        }
    }
}
