using System;

namespace LAB8_Matrix
{
    class Matrix
    {
        int j;
        int i;
        int[,] M;
        int I
        {
            get
            {
                return i;
            }
            set
            {
                i = value;
            }
        }
        int J
        {
            get
            {
                return j;
            }
            set
            {
                j = value;
            }
        }
        String MParam
        {
            get
            {
                return "raw_count= " + j + "; string_count= " + i;
            }
        }
        public Matrix(int raw_count, int string_count)
        {
            this.j = raw_count;
            this.i = string_count;
            this.M = new int[i, j];
        }
        public int this[int i, int j]
        {
            get
            {
                return M[i, j];
            }
            set
            {
                M[i, j] = value;
            }
        }
        public Matrix Add(Matrix Input)
        {
            if (this.i == Input.i && this.j == Input.j)
            {
                for (int a = 0; a < this.j; a++)
                {
                    for (int b = 0; b < this.i; b++)
                    {
                        this[a, b] += Input[a, b];
                    }
                }
            }
            return this;
        }

        public Matrix Sub(Matrix Input)
        {
            if (this.i == Input.i && this.j == Input.j)
            {
                for (int a = 0; a < this.j; a++)
                {
                    for (int b = 0; b < this.i; b++)
                    {
                        this[a, b] -= Input[a, b];
                    }
                }
            }
            return this;
        }

        public Matrix Mul(Matrix Input)
        {
            Matrix result = new Matrix(this.j, Input.i);
            if (this.j == Input.i)
            {
                for (int a = 0; a < this.i; a++)
                {
                    for (int b = 0; b < Input.j; b++)
                    {
                        for (int c = 0; c < Input.i; c++)
                        {
                            result[a, b] += this[a, c] * Input[b, c];
                        }
                    }
                }
                this.M = result.M;
                this.i = result.i;
                this.j = result.j;
                return this;
            }
            else
            {
                Console.WriteLine("[Mul]: Умножение не возможно, матрицы не совместимы");
                return this;
            }

        }
        public Boolean Eq(Matrix Input)
        {
            if (this.i == Input.i && this.j == Input.j)
            {
                for (int a = 0; a < this.i; a++)
                {
                    for (int b = 0; b < this.j; b++)
                    {
                        if (this[a, b] != Input[a, b])
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Tran()
        {
            if (this.i == this.j)
            {
                int t = 0;
                for (int a = 0; a < this.i; a++)
                {
                    for (int b = a; b < this.j; b++)
                    {
                        t = this[a, b];
                        this[a, b] = this[b, a];
                        this[b, a] = t;
                    }
                }
            }
        }
        public int Min()
        {
            int Min = this[0,0];
            for (int a = 0; a < this.i; a++)
            {
                for (int b = 0; b < this.j; b++)
                {
                    if (Min > this[a, b])
                    {
                        Min = this[a, b];
                    }
                }
            }
                    return Min;
        }
        public void Show()
        {
            for (int a = 0; a < this.i; a++)
            {
                for (int b = 0; b < this.j; b++)
                {
                    Console.Write(this[a, b] + " ; ");
                }
                Console.WriteLine();
            }
        }
        public int ShowElement(int raw, int str)
        {
            if (raw < i && str < j && 0 < raw && 0 < str)
            {
                return this[raw, str];
            }
            else
            {
                Console.WriteLine("[ShowElement]: Невалидные атрибуты матрицы");
                return 0;
            }
        }
        public void SetElement(int raw, int str,int New)
        {
            if (raw < i && str < j && 0 <= raw && 0 <= str)
            {
               this[raw, str] = New;
            }
            else
            {
                Console.WriteLine("[SetElement]: Невалидные атрибуты матрицы");
            }
        }
    }
}