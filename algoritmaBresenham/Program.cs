namespace algoritmaBresenham
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float r = 10f;
            float _xC = 0f;
            float _yC = r;

            float _p = 1 - r;

            int index = 0;


            Console.WriteLine("Algoritma Bresenham");
            Console.WriteLine($@"r =>  {r}");
            Console.WriteLine($@"X0 => {_xC}");
            Console.WriteLine($@"Y0 => {_yC}");
            Console.WriteLine($@"P0 => {_p}");
            Console.WriteLine($@"Result : ");

            while (_xC < _yC) {
                if (_p >= 0)
                {
                    _xC = _xC + 1;
                    _yC = _yC - 1;
                    _p = _p + (2 * _xC) + 1 - (2 * _yC);

                    Console.WriteLine($@"Iterasi {index}");
                    Console.WriteLine($@"X{index + 1} = X{index} + 1 = {_xC}");
                    Console.WriteLine($@"Y{index + 1} = Y{index} - 1 = {_yC}");
                    Console.WriteLine($@"P{index + 1} = P{index} + 2X{index + 1} + 1 - 2Y{index + 1} = {_p}");
                }
                else
                {
                    _xC = _xC + 1;
                    _p = _p + (2 * _xC) + 1;
                    Console.WriteLine($@"Iterasi {index}");
                    Console.WriteLine($@"X{index + 1} = X{index} + 1 = {_xC}");
                    Console.WriteLine($@"Y{index + 1} = Y{index} = {_yC}");
                    Console.WriteLine($@"P{index + 1} = P{index} + 2X{index + 1} + 1 = {_p}");
                }
                index++;
            }
        }

        
    }
}