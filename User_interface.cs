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
    public partial class User_interface : Form
    {
        Read_labyrinth_from_file obj;
        int Cout = 0;
        public User_interface()
        {
            InitializeComponent();
            Labyrinth_dataGridView.Rows.Clear();
            Labyrinth_dataGridView.Columns.Clear();
            Labyrinth_dataGridView.AutoResizeColumns();
            Labyrinth_dataGridView.RowHeadersVisible = false;
            groupBox1.Enabled = false;
            Avto_button.Enabled = false;
            Hand_button.Enabled = false;

            
        }


        /// <summary>
        /// Загрузка лабиринта
        /// </summary>
        private void Load_labyrinth_button_Click(object sender, EventArgs e)
        {
            Labyrinth_dataGridView.ClearSelection();
            obj = new Read_labyrinth_from_file();
            
            try
            {       
                        int[,] matrix = obj.Labyrinth_Matrix;
                        int str = obj.Strings;
                        int col = obj.Columns;
                        Labyrinth_dataGridView.ColumnCount = col;
                        Labyrinth_dataGridView.RowCount = str;
                      
                    
                        int input = 0;
                        int output = 0;

                        for (int i = 0; i < str; i++)
                        {
                            for (int j = 0; j < col; j++)
                            {
                                Labyrinth_dataGridView.Rows[i].Cells[j].Style.BackColor = Color.White;
                                Labyrinth_dataGridView.Rows[i].Cells[j].Value = ' ';

                            }
                        }
                
                
                        for (int i = 0; i < str; i++)
                        {
                            for (int j = 0; j < col; j++)
                            {                                                                                                                                                         
                                    if (matrix[i, j] == -1)
                                    {
                                        Labyrinth_dataGridView.Rows[i].Cells[j].Style.BackColor = Color.Black;
                                    }
                                    else if (matrix[i, j] == -2)
                                    {                                       
                                        Labyrinth_dataGridView.Rows[i].Cells[j].Style.BackColor = Color.White; 
                                    }
                                    else if (matrix[i, j] == -5)
                                    {                        
                                        Labyrinth_dataGridView.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                                        Labyrinth_dataGridView.Rows[i].Cells[j].Value = "№ " + input;
                                        input++;
                                    }
                                    else if (matrix[i, j] == -6)
                                    {
                                        Labyrinth_dataGridView.Rows[i].Cells[j].Style.BackColor = Color.Green;
                                        Labyrinth_dataGridView.Rows[i].Cells[j].Value = "№ " + output;
                                        output++;
                                    }  
                            }
                        }
                        groupBox1.Enabled = true;
                        Avto_button.Enabled = true;
                        Hand_button.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка при чтении из файла.", "Ошибка");
            }
        }



        /// <summary>
        /// Автоматическое выполнение программы
        /// </summary>
        private void Avto_button_Click(object sender, EventArgs e)
        {
            Labyrinth_dataGridView.ClearSelection();
   
            int In_value = Convert.ToInt32(in_textBox.Text);
            int Out_value = Convert.ToInt32(out_textBox.Text);

            try
            {
                int[,] Matrix = obj.Labyrinth_Matrix;
                int in_x = obj.Labyrinth_input[In_value, 0];
                int in_y = obj.Labyrinth_input[In_value, 1];
                int out_x = obj.Labyrinth_output[Out_value, 0];
                int out_y = obj.Labyrinth_output[Out_value, 1];
                int str = obj.Strings;
                int col = obj.Columns;

                if (in_x == 0 && in_y == 0 && out_x == 0 && out_y ==0)
                {
                    MessageBox.Show("Введены некоректные номера входа и выхода");

                }
                else 
                {
                    for (int i = 0; i < str; i++)
                    {
                        for (int j = 0; j < col; j++)
                        {
                            Labyrinth_dataGridView.Rows[i].Cells[j].Style.BackColor = Color.White;
                        }
                    }

                    int[,] Result_Matrix = null;
                    int Cout = 0;

                    Run_Labyrinth lab = new Run_Labyrinth();
                    lab.Run_Algorithm(Matrix, in_x, in_y, out_x, out_y, str, col, out Cout, out Result_Matrix);

                    int a = 0;
                    int x = out_x;
                    int y = out_y;

                    for (int i = 0; i < str; i++)
                    {
                        for (int j = 0; j < col; j++)
                        {
                            if (Matrix[i, j] == -1)
                            {
                                Labyrinth_dataGridView.Rows[i].Cells[j].Style.BackColor = Color.Black;
                            }
                            else if (Matrix[i, j] == -2)
                            {
                                Labyrinth_dataGridView.Rows[i].Cells[j].Style.BackColor = Color.White;
                            }
                            else if (Matrix[i, j] == -5)
                            {
                                Labyrinth_dataGridView.Rows[i].Cells[j].Style.BackColor = Color.Yellow;

                            }
                            else if (Matrix[i, j] == -6)
                            {
                                Labyrinth_dataGridView.Rows[i].Cells[j].Style.BackColor = Color.Green;

                            }
                        }
                    }

                    while (a == 0)
                    {
                        if (Result_Matrix[x, y] == Cout)
                        {
                            Labyrinth_dataGridView.Rows[x].Cells[y].Style.BackColor = Color.Red;
                            Cout--;

                            if (Cout < 0)
                            {
                                a = 1;
                            }

                            if (y - 1 >= 0 && Result_Matrix[x, y - 1] != -1 && Result_Matrix[x, y - 1] == Cout)
                            {
                                Labyrinth_dataGridView.Rows[x].Cells[y - 1].Style.BackColor = Color.Red;
                                y = y - 1;
                            }
                            else if (x - 1 >= 0 && Result_Matrix[x - 1, y] != -1 && Result_Matrix[x - 1, y] == Cout)
                            {
                                Labyrinth_dataGridView.Rows[x - 1].Cells[y].Style.BackColor = Color.Red;
                                x = x - 1;
                            }
                            else if (y + 1 < col && Result_Matrix[x, y + 1] != -1 && Result_Matrix[x, y + 1] == Cout)
                            {
                                Labyrinth_dataGridView.Rows[x].Cells[y + 1].Style.BackColor = Color.Red;
                                y = y + 1;
                            }
                            else if (x + 1 < str && Result_Matrix[x + 1, y] != -1 && Result_Matrix[x + 1, y] == Cout)
                            {
                                Labyrinth_dataGridView.Rows[x + 1].Cells[y].Style.BackColor = Color.Red;
                                x = x + 1;
                            }
                        }
                        else
                        {
                            Cout--;
                        }
                    }
                }
                                        
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Нужно выбрать файл с лабиринтом.", "Ошибка");
            }          
        }
        
        /// <summary>
        /// Ручное выполнение программы
        /// </summary>
        private void Hand_button_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            Avto_button.Enabled = false;
            Labyrinth_dataGridView.ClearSelection();
   
            int In_value = Convert.ToInt32(in_textBox.Text);
            int Out_value = Convert.ToInt32(out_textBox.Text);

            try
            {
                int[,] Matrix = obj.Labyrinth_Matrix;
                int[,] matr = (int[,])obj.Labyrinth_Matrix.Clone();
                int in_x = obj.Labyrinth_input[In_value, 0];
                int in_y = obj.Labyrinth_input[In_value, 1];
                int out_x = obj.Labyrinth_output[Out_value, 0];
                int out_y = obj.Labyrinth_output[Out_value, 1];
                int str = obj.Strings;
                int col = obj.Columns;
                if (in_x == 0 && in_y == 0 && out_x == 0 && out_y == 0)
                {
                    MessageBox.Show("Введены некоректные номера входа и выхода");

                }
                else
                {
                    for (int i = 0; i < str; i++)
                    {
                        for (int j = 0; j < col; j++)
                        {
                            Labyrinth_dataGridView.Rows[i].Cells[j].Style.BackColor = Color.White;
                        }
                    }

                    for (int i = 0; i < str; i++)
                    {
                        for (int j = 0; j < col; j++)
                        {
                            if (Matrix[i, j] == -1)
                            {
                                Labyrinth_dataGridView.Rows[i].Cells[j].Style.BackColor = Color.Black;
                            }
                            else if (Matrix[i, j] == -2)
                            {
                                Labyrinth_dataGridView.Rows[i].Cells[j].Style.BackColor = Color.White;
                            }
                            else if (Matrix[i, j] == -5)
                            {
                                Labyrinth_dataGridView.Rows[i].Cells[j].Style.BackColor = Color.Yellow;

                            }
                            else if (Matrix[i, j] == -6)
                            {
                                Labyrinth_dataGridView.Rows[i].Cells[j].Style.BackColor = Color.Green;

                            }
                        }
                    }

                    int[,] Result_Matrix_Hand = null;
                    int[,] Matrix_Hand = null;

                    int move = Cout;
                    Run_Labyrinth lab = new Run_Labyrinth();
                    lab.Run_Algorithm_Hand(move, Matrix, in_x, in_y, out_x, out_y, str, col, out Cout, out Result_Matrix_Hand);
                    
                    bool a = false;
                    bool b = false;
                    
                    int x = out_x;
                    int y = out_y;
                    int s = Cout;
                    int s1 = Cout;
                    Matrix_Hand = (int[,])Result_Matrix_Hand.Clone();
                    for (int i = 0; i < str; i++)
                    {
                        for (int j = 0; j < col; j++)
                        {
                            if (matr[i, j] == -1)
                            {
                                Labyrinth_dataGridView.Rows[i].Cells[j].Style.BackColor = Color.Black;
                            }
                            else if (matr[i, j] == -2)
                            {

                                Labyrinth_dataGridView.Rows[i].Cells[j].Style.BackColor = Color.White;
                                Labyrinth_dataGridView.Rows[i].Cells[j].Value = Result_Matrix_Hand[i, j];                              
                            }
                            else if (matr[i, j] == -5 || matr[i, j] == 0)
                            {
                                Labyrinth_dataGridView.Rows[i].Cells[j].Style.BackColor = Color.Yellow;

                            }
                            else if (matr[i, j] == -6 || matr[i, j] == -10)
                            {
                                Labyrinth_dataGridView.Rows[i].Cells[j].Style.BackColor = Color.Green;

                            }
                            if (Result_Matrix_Hand[i, j] == s)
                            {

                                while (a == false)
                                {

                                    if (Result_Matrix_Hand[i, j] == s)
                                    {
                                        if (Result_Matrix_Hand[x, y] == s)
                                        {
                                            b = true;
                                        }
                                        s--;

                                        if (s < 0)
                                        {
                                            a = true;
                                        }

                                        else if (j - 1 >= 0 && Result_Matrix_Hand[i, j - 1] != -1 && Result_Matrix_Hand[i, j - 1] == s)
                                        {
                                            j = j - 1;
                                        }
                                        else if (i - 1 >= 0 && Result_Matrix_Hand[i - 1, j] != -1 && Result_Matrix_Hand[i - 1, j] == s)
                                        {
                                            i = i - 1;
                                        }
                                        else if (j + 1 < col && Result_Matrix_Hand[i, j + 1] != -1 && Result_Matrix_Hand[i, j + 1] == s)
                                        {
                                            j = j + 1;
                                        }
                                        else if (i + 1 < str && Result_Matrix_Hand[i + 1, j] != -1 && Result_Matrix_Hand[i + 1, j] == s)
                                        {                                           
                                            i = i + 1;
                                        }
                                       
                                    }
                                    else
                                    {
                                        s--;
                                    }
                                }
                            }
                        }
                    }
                    bool c = false;
                    if (b == true)
                    {
                        for (int i = 0; i < str; i++)
                        {
                            for (int j = 0; j < col; j++)
                            {
                                Labyrinth_dataGridView.Rows[i].Cells[j].Style.BackColor = Color.White;
                            }
                        }
                        
                        for (int i = 0; i < str; i++)
                        {
                            for (int j = 0; j < col; j++)
                            {
                                if (Matrix[i, j] == -1)
                                {
                                    Labyrinth_dataGridView.Rows[i].Cells[j].Style.BackColor = Color.Black;
                                }
                                else if (Matrix[i, j] == -2)
                                {
                                    Labyrinth_dataGridView.Rows[i].Cells[j].Style.BackColor = Color.White;
                                }
                                else if (Matrix[i, j] == -5)
                                {
                                    Labyrinth_dataGridView.Rows[i].Cells[j].Style.BackColor = Color.Yellow;

                                }
                                else if (Matrix[i, j] == -6)
                                {
                                    Labyrinth_dataGridView.Rows[i].Cells[j].Style.BackColor = Color.Green;

                                }
                            }
                        }

                        while (c == false)
                        {
                            if (Matrix_Hand[x, y] == s1)
                            {
                                Labyrinth_dataGridView.Rows[x].Cells[y].Style.BackColor = Color.Red;
                                s1--;

                                if (s1 < 0)
                                {
                                    c = true;
                                }

                                if (y - 1 >= 0 && Matrix_Hand[x, y - 1] != -1 && Matrix_Hand[x, y - 1] == s1)
                                {
                                    Labyrinth_dataGridView.Rows[x].Cells[y - 1].Style.BackColor = Color.Red;
                                    y = y - 1;
                                }
                                else if (x - 1 >= 0 && Matrix_Hand[x - 1, y] != -1 && Matrix_Hand[x - 1, y] == s1)
                                {
                                    Labyrinth_dataGridView.Rows[x - 1].Cells[y].Style.BackColor = Color.Red;
                                    x = x - 1;
                                }
                                else if (y + 1 < col && Matrix_Hand[x, y + 1] != -1 && Matrix_Hand[x, y + 1] == s1)
                                {
                                    Labyrinth_dataGridView.Rows[x].Cells[y + 1].Style.BackColor = Color.Red;
                                    y = y + 1;
                                }
                                else if (x + 1 < str && Matrix_Hand[x + 1, y] != -1 && Matrix_Hand[x + 1, y] == s1)
                                {
                                    Labyrinth_dataGridView.Rows[x + 1].Cells[y].Style.BackColor = Color.Red;
                                    x = x + 1;
                                }
                            }
                            else
                            {
                                s1--;
                            }
                        }
                        
                        Labyrinth_dataGridView.Rows[x].Cells[y].Style.BackColor = Color.Red;
                        MessageBox.Show("Выход из лабиринта найден.");
                        Hand_button.Enabled = false;

                    } 
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Нужно выбрать файл с лабиринтом.", "Ошибка");
            }
        }       
    }
}
