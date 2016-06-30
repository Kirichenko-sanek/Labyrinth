using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth
{
    /// <summary>
    /// Интерфейс для чтения из файла
    /// </summary>
    public interface I_Read_labyrinth
    {
        void Read_file(out int Str, out int Col, out int[,] L_matrix, out int[,] L_input, out int[,] L_output);
    }
    
    /// <summary>
    /// Интерфейс для прохождения лабиринта
    /// </summary>
    public interface I_Run_Labyrinth
    {
        void Run_Algorithm(int[,] Matrix, int In_x, int In_y, int Out_x, int Out_y, int Str, int Col, out int cout, out int[,] Result);
        void Run_Algorithm_Hand(int Move, int[,] Matrix, int In_x, int In_y, int Out_x, int Out_y, int Str, int Col, out int cout, out int[,] Result);
    }

    
    
}
