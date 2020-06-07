using System;
using System.Collections.Generic;
using System.Text;

namespace LAB7_Frac
{
    class Frac
    {
        int num;
        int den;
        public int Num
        {
            get
            {
                return num;
            }
            set
            {
                num = value;
            }
        }
        public int Den
        {
            get
            {
                return den;
            }
            set
            {
                den = value;
            }
        }
        public String Num_
        {
            get
            {
                return num.ToString();
            }
        }
        public String Den_
        {
            get
            {
                return den.ToString();
            }
        }
        public String Frac_
        {
            get
            {
                return num + "/" + den;
            }
        }
        public void Cut(ref Frac B) 
        {
            if (B.num % B.den == 0)
            {
                B.num = B.num / B.den;
            }
            for (int i = 10; i > 0; i--)
            if (B.num % i == 0 && B.den % i == 0)
            {
                    B.num /= i;
                    B.den /= i;
            }
        }
        public Frac(int num, int den)
        {
            this.num = num;
            this.den = den;
        }
        public Frac Copy()
        {
            int tnum = this.num;
            int tden = this.den;
            return new Frac(tnum, tden);
        }
        public Frac Add(Frac Input)
        {
            int sumnum = this.num * Input.den + Input.num * this.den;
            int sumden = this.den * Input.den;
            return new Frac(sumnum, sumden);
        }
        public Frac Mul(Frac Input)
        {
            int mulnum = this.num * Input.num;
            int mulden = this.den * Input.den;
            return new Frac(mulnum, mulden);
        }
        public Frac Sub(Frac Input)
        {
            int subnum = this.num * Input.den - Input.num * this.den;
            int subden = this.den * Input.den;
            return new Frac(subnum, subden);
        }
        public Frac Dvd(Frac Input)
        {
            int dvdnum = this.num * Input.den;
            int dvdden = this.den * Input.num;
            return new Frac(dvdnum, dvdden);
        }
        public Frac Sqr()
        {
            int sqrnum = this.num * this.num;
            int sqrden = this.den * this.den;
            return new Frac(sqrnum, sqrden);
        }
        public Frac Rev()
        {
            return new Frac(this.den, this.num);
        }
        public Frac Minus()
        {
            return new Frac(-this.num, this.den);
        }
        public Boolean Equal(Frac Input)
        {
            if (Input.num == this.num && Input.den == this.den)
                return true;
            return false;
        }
        public Boolean Greater(Frac Input)
        {
            int num_1 = this.num * Input.den;
            int num_2 = Input.num * this.den;
            if (num_1 > num_2)
                return true;
            return false;
        }
        public double GetNum()
        {
            return this.num;
        }
        public double GetDenom()
        {
            return this.den;
        }
    }
}
