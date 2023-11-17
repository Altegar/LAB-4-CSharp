namespace LAB4
{
    internal class Complex
    {
        private double re;
        private double im;

        public Complex()
        {
            re = 0;
            im = 0;
        }

        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        public Complex(Complex c)
        {
            this.re = c.re;
            this.im = c.im;
        }

        public void SetRe(double re) { this.re = re; }
        public void SetIm(double im) { this.im = im; }

        public double GetRe() { return this.re; }
        public double GetIm() { return this.im; }

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.re + b.re, a.im + b.im);
        }

        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.re - b.re, a.im - b.im);
        }

        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex(a.re * b.re - a.im * b.im, a.re * b.im + a.im * b.re);
        }

        public static Complex operator /(Complex a, Complex b)
        {
            double r1 = a.re;
            double i1 = a.im;
            double r2 = b.re;
            double i2 = b.im;
            return new Complex((r1 * r2 - i1 * i2) / (r2 * r2 + i2 * i2), (-r1 * i2 + i1 * r2) / (r2 * r2 + i2 * i2));
        }

        public static Complex operator ^(Complex a, uint n)
        {
            var y = new Complex(1, 0);
            for (uint i = 1; i <= n; i++)
                y *= a;
            return y;
        }

        public static Complex operator ++(Complex a)
        {
            a.re++;
            a.im++;
            return a;
        }

        public static Complex operator --(Complex a)
        {
            a.re--;
            a.im--;
            return a;
        }

        public override string ToString()
        {
            return " re: " + this.re + "\n im: " + this.im;
        }
    }
}