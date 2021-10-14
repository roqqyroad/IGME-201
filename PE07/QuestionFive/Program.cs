using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionFive
{
    class Program
    {
        static void Main(string[] args)
        {

            //double startX = -1.0;
            // 20 steps between -1.0 and 1.0
            //double endX = 1.0;
            //double startY = 1.0;
            // 30  steps between 1.0 and 4.0
            //double endY = 4.0;

            double zSlot = 0.0;

            // 20 X Values,
            // 30 Y Values, 
            // 600? I think Z Values
            double[,,] vals = new double[20,30,600];
            int xRun = 0;
            int yRun = 0;
            int zCalc = 0;

            for (double xVal = -1.0; xVal <= 1.0; xVal  += 0.1){
                

                for(double yVal = 1.0; yVal <= 4.0; yVal += 0.1 ){
                    zSlot = (((3 * (yVal * yVal)) + (2 * xVal)) - 1);

            
                    vals[xRun, yRun, zCalc] = { { xVal, yVal, zSlot} };
                    zCalc++;
                    yRun++;

                }
                xRun++;

            }
        }
    }
}
