class Complex
    {
        int a, b;

        public Complex(int re, int im)
        {
            a = re;
            b = im;
        }

        public string Print()
        {
            string s;
            if(b > 0) s = $"{a}+{b}i";
            else s = $"{a}-{-b}i";
            return s;
        }

        public Complex Sum(Complex x, Complex y)
        {
            Complex result;
            result = new(x.a + y.a, x.b + y.b);
            return result;
        }

        public  Complex Sub(Complex x, Complex y)
        {
            Complex result;
            result = new(x.a - y.a, x.b - y.b);
            return result;
        }

        public  Complex Mult(Complex x, Complex y)
        {
            Complex result;
            result = new(x.a * y.a - x.b * y.b, x.b * y.a + x.a * y.b);
            return result;
        }
    }