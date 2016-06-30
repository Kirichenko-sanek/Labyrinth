using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Labyrinth
{
    public class Read_labyrinth_from_file : I_Read_labyrinth
    {
        public Read_labyrinth_from_file()
        {
            int Str, Col = 0;
            int [,] L_matrix = null;
            int[,] L_input = null;
            int[,] L_output = null;
            Read_file(out Str, out Col, out L_matrix,out L_input, out L_output);
            _labyrinth_matrix = L_matrix;
            _strings  = Str;
            _columns = Col;
            _labyrinth_input = L_input;
            _labyrinth_output = L_output;

        }

        private readonly int[,] _labyrinth_matrix;
        public int[,] Labyrinth_Matrix
        {
            get { return _labyrinth_matrix; }

        }

        private readonly int[,] _labyrinth_input;
        public int[,] Labyrinth_input
        {
            get { return _labyrinth_input; }

        }

        private readonly int[,] _labyrinth_output;
        public int[,] Labyrinth_output
        {
            get { return _labyrinth_output; }

        }

        private readonly int _strings;
        public int Strings
        {
            get { return _strings; }
        }

        private readonly int _columns;
        public int Columns
        {
            get { return _columns; }
        }



        /// <summary>
        /// Чтение из файла
        /// </summary>
        public void Read_file(out int Str, out int Col, out int[,] L_matrix, out int[,] L_input, out int[,] L_output)
        {
            int str = 0;
            int col = 0;
            int [,] input =new int[10,2];
            int[,] output = new int[10, 2];            
            int count_input = 0;
            int count_output = 0;
            User_interface reading = new User_interface();
            DialogResult res = reading.openFileDialog1.ShowDialog();
                if (res == DialogResult.Yes || res == DialogResult.OK)
                {
            
                        using (StreamReader stream = new StreamReader(reading.openFileDialog1.OpenFile()))
                        {
                            string[] tmp = stream.ReadLine().Split(' ');
                            str = Convert.ToInt32(tmp[0]);
                            col = Convert.ToInt32(tmp[1]);
                            Str = str;
                            Col = col;
                            int[,] Matrix_Lab = new int[str, col];
                            for (int i = 0; i < str; i++)
                            {
                                tmp = stream.ReadLine().Split(' ');
                                for (int j = 0; j < col; j++)
                                {
                                    Matrix_Lab[i, j] = Convert.ToInt32(tmp[j]);
                                    if (Matrix_Lab[i, j] == -5)
                                    {
                                        input[count_input, 0] = i;
                                        input[count_input, 1] = j;
                                        count_input++;
                                    }

                                    if (Matrix_Lab[i, j] == -6)
                                    {
                                        output[count_output, 0] = i;
                                        output[count_output, 1] = j;
                                        count_output++;
                                    }

                                }
                            }
                            L_matrix = Matrix_Lab;
                            L_input = input;
                            L_output = output;
                        }

                }
                else
                {
                    Str = str;
                    Col = col;
                    L_matrix = null;
                    L_input = null;
                    L_output = null;
                    return;
                }
           
            return ;
        }
    }
}
