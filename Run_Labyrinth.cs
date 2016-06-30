using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth
{


    class Run_Labyrinth : I_Run_Labyrinth
    {    
        /// <summary>
        /// Метод реализующий автоматическое прохождение лабиринта
        /// </summary>   
        public void Run_Algorithm(int[,] Matrix, int In_x, int In_y, int Out_x, int Out_y, int Str, int Col, out int cout, out int[,] Result)
        {           
            int [,] Map = (int [,])Matrix.Clone();
            int startX = In_x;
            int startY = In_y;            
            int finishX = Out_x;
            int finishY = Out_y;
            int MapHeight = Str;
            int MapWidth = Col;

            bool add = true;
            int step = 0;
            int value_step = 0;
            
            Map[startX, startY] = 0; 
            Map[finishX, finishY] = -10;
            while (add == true)
            {
                add = false;
                for (int i = 0; i < MapHeight; i++)
                {
                    for (int j = 0; j < MapWidth; j++)
                    {
                        if (Map[i,j] == step)
                        {
                            if (j - 1 >= 0 && Map[i, j - 1] != -1 && (Map[i, j - 1] == -2 || Map[i, j - 1] == -10))
                            {
                                
                                Map[i, j - 1] = step + 1;
                                value_step = step + 1;
                            }
                            if (i - 1 >= 0 && Map[i - 1, j] != -1 && (Map[i - 1, j] == -2 || Map[i - 1, j] == -10))
                            {
                                Map[i - 1, j] = step + 1;
                                value_step = step + 1;
                            }
                            if (j + 1 < MapWidth && Map[i, j + 1] != -1 && (Map[i, j + 1] == -2 || Map[i, j + 1] == -10))
                            {
                                Map[i, j + 1] = step + 1;
                                value_step = step + 1;
                            }
                            if (i + 1 < MapHeight && Map[i + 1, j] != -1 && (Map[i + 1, j] == -2 || Map[i + 1, j] == -10))
                            {
                                Map[i + 1, j] = step + 1;
                                value_step = step + 1;
                            }

                        }
                    }
                }
                step++;
                add = true;
                
                if (step > MapHeight * MapWidth)//Путь не найден
                {
                    add = false;
                }

            }
            Result = Map;
            cout = value_step;
        }

        /// <summary>
        /// Метод реализующий прохождение лабиринта по шагу
        /// </summary>
        public void Run_Algorithm_Hand(int Move, int[,] Matrix, int In_x, int In_y, int Out_x, int Out_y, int Str, int Col, out int cout, out int[,] Result)
        {
            int[,] Map = Matrix;
            int startX = In_x;
            int startY = In_y;
            int finishX = Out_x;
            int finishY = Out_y;
            int MapHeight = Str;
            int MapWidth = Col;
            int step = Move;
            bool add = true;
            
            int value_step = 0;

            Map[startX, startY] = 0;
            Map[finishX, finishY] = -10;
            while (add == true)
            {
                add = false;
                for (int i = 0; i < MapHeight; i++)
                {
                    for (int j = 0; j < MapWidth; j++)
                    {
                        if (Map[i, j] == step)
                        {
                            if (j - 1 >= 0 && Map[i, j - 1] != -1 && (Map[i, j - 1] == -2 || Map[i, j - 1] == -10))
                            {

                                Map[i, j - 1] = step + 1;
                                value_step = step + 1;
                            }
                            if (i - 1 >= 0 && Map[i - 1, j] != -1 && (Map[i - 1, j] == -2 || Map[i - 1, j] == -10))
                            {
                                Map[i - 1, j] = step + 1;
                                value_step = step + 1;
                            }
                            if (j + 1 < MapWidth && Map[i, j + 1] != -1 && (Map[i, j + 1] == -2 || Map[i, j + 1] == -10))
                            {
                                Map[i, j + 1] = step + 1;
                                value_step = step + 1;
                            }
                            if (i + 1 < MapHeight && Map[i + 1, j] != -1 && (Map[i + 1, j] == -2 || Map[i + 1, j] == -10))
                            {
                                Map[i + 1, j] = step + 1;
                                value_step = step + 1;
                            }

                        }
                    }
                }
                step++;
                

                if (step > MapHeight * MapWidth)//Путь не найден
                {
                    add = false;
                }

            } 
            Result = Map;
            cout = value_step;
        }
    }
}
