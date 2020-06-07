using System;

namespace TPoly
{
    class TMember
    {
        public int FCoeff, FDegree;
        public TMember(int Ci, int n)
        {
            this.FCoeff = Ci;
            this.FDegree = n;
        }

        public int ReturnDegree()
        {
            return this.FDegree;
        }
        public void WriteDegree(int Input)
        {
            this.FDegree = Input;
        }
        public void WriteCoeff(int Input)
        {
            this.FCoeff = Input;
        }
        public Boolean Equal(TMember Input)
        {
            if (Input.FCoeff == this.FCoeff && Input.FDegree == this.FDegree) return true;
         return false;
        }
        public void Differencial()
        {
            switch (this.FDegree)
            {
                case 0:
                {
                    this.FCoeff = 0;
                    this.FDegree = 0;
                    break;
                }
                default:
                {
                    this.FCoeff = this.FCoeff * this.FDegree;
                    this.FDegree -= 1;
                    break;
                }
            }
        }
        public double Solve(double Input)
        {
            return this.FCoeff * Math.Pow(Input, (double)this.FDegree);
        }
        public String Tostring()
        {
             return " " + this.FCoeff.ToString() + " * x ^ " + this.FDegree.ToString();
        }
    }
}
