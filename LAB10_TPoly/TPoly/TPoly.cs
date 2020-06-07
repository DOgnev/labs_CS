using System;
using System.Collections.Generic;

namespace TPoly
{
    class TPoly
    {

        List<TMember> Poly;
        public TMember this[int i] { get { return Poly[i]; } }

        public TPoly()
        {
            Poly = new List<TMember>();
        }
        public TPoly(int C, int n)
        {
            Poly = new List<TMember>();
            Poly.Add(new TMember(C, n));
        }

        public void Add(int C, int n)
        {
            this.Poly.Add(new TMember(C,n));
        }

        public int ReturnDegree()
        {
            int max = this.Poly[0]. FDegree;
            for (int i = 1; i < this.Poly.Count; ++i)
            {
                if (this.Poly[i].FDegree > max)
                {
                    max = this.Poly[i].FDegree;
                }
            }
            return max;
        }

        public int ReturnCoeffWithDegree(int n)
        {
            for (int i = 0; i < this.Poly.Count; ++i)
            {
                if (this.Poly[i].FDegree == n)
                {
                    return this.Poly[i].FCoeff;
                }
            }
            return 0;
        }

        public void Summ(TPoly Input)
        {
            for (int i = 0; i < Input.Poly.Count; ++i)
            {
                this.Poly.Add(Input[i]);
            }
            this.Normalize();
        }

        public void Normalize()
        {
            for (int i = 0; i < this.Poly.Count; ++i)
            {
                for (int j = 0; j < this.Poly.Count; ++j)
                {
                    if (this.Poly[i].FDegree == this.Poly[j].FDegree && i != j)
                    {
                        this.Poly[i].FCoeff = (this.Poly[i].FCoeff + this.Poly[j].FCoeff);
                        this.Poly.RemoveAt(j);
                    }
                }
            }
        }

        public TPoly Mult(TPoly Input)
        {
            TPoly tmp = new TPoly();
            for (int i = 0; i < this.Poly.Count; ++i)
            {
                for (int j = 0; j < Input.Poly.Count; ++j)
                {
                    tmp.Add(this.Poly[i].FCoeff * Input.Poly[j].FCoeff, this.Poly[i].FDegree + Input.Poly[j].FDegree);
                }
            }
            tmp.Normalize();
            return tmp;   
        }
        public void Sub(TPoly Input)
        {
            Input.Invert();
            for (int i = 0; i < Input.Poly.Count; ++i)
            {
                this.Poly.Add(Input[i]);
            }
            this.Normalize();       
        }

        public void Invert()
        {
            for (int i = 0; i < this.Poly.Count; ++i)
            {
                {
                    {
                        this.Poly[i].FCoeff =  (-1) * this.Poly[i].FCoeff;
                    }
                }
            }
        }

        public Boolean Equal(TPoly Input)
        {
            for (int i = 0; i < this.Poly.Count; ++i)
            {
                for (int j = 0; j < Input.Poly.Count; ++j)
                {
                    if (this.Poly[i].FCoeff != Input.Poly[j].FCoeff && this.Poly[i].FDegree == Input.Poly[j].FDegree)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void FullDiff()
        {
            for (int i = 0; i < this.Poly.Count; ++i)
            {
                this.Poly[i].Differencial();
            }
        }

        public double Solve(double Input)
        {
            double result = 0;
            for (int i = 0; i < this.Poly.Count; ++i)
            {
                result += this.Poly[i].Solve(Input);
            }
            return result;
        }
        public String PolyToString()
        {
            this.Normalize();
            String result = "";
            for (int i = 0; i < this.Poly.Count; ++i)
            {
                if (this.Poly[i].FDegree != 0 || this.Poly[i].FCoeff != 0)
                {
                    result += this[i].Tostring();
                    if (i != this.Poly.Count - 1)
                    {
                        result += " +";
                    }
                }
            }
            if (result.Equals(""))
                result += "0 * X ^ 0";
            return result;
        }
    }
}
