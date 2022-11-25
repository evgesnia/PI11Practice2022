using static System.Console;
using static System.Math;
#region
//данные
double f=60;    //количество топлива(с)
double h=1000;  // высота(м)
double v=0;     //скорость движения(м/с)
double t;       //время движения(с)
double eps=0.0000001;

const double vmax=10;//максимальная скорость ракетты(м/с)
const double g=-1.62;//ускорение свободного падения(м/с^2)
const double a=2;    //ускорение движения при включенном двигателе(м/с^2)
#endregion


//основной цикл
while (h>= Abs(eps))
{
    //вывод текущего состояния 
    WriteLine($"Высота на данный момент:{h}м");
    WriteLine($"Количество топлива на данный момент:{f}с");
    WriteLine($"Скорость на данный момент:{v}м/с");   
    //выбор пользователя
    int actoin=ActionChoose("(1-включить, 0-выключить): ", 0, 1);
    WriteLine("Введите время полета:");
    t=TimeChoose();
    double chosen = actoin == 0 ? g : a ;
    //вычесления

    if (t<0) t=0;
    if (t>f) t=f;

    int n;//кол-во решений уравнения
    double t1, t2;
    SquareRoot(chosen/2, v, h, out n, out t1, out t2);

    if (n>0 && t1>0 && t>t1) t = t1;
    if (n>0 && t2>0 && t>t2) t = t2;

    if (chosen == 1) f-=t;
    h=h+v*t+chosen/2*t*t;
    v=v+chosen*t;

}
//поздравить(или нет)
Console.WriteLine($"Текущие значения: высота {h:F2} м, скорость {Math.Abs(v):F2} м/с, топлива {f:F2} сек"); 
            if (Math.Abs(v) > vmax)
                Console.WriteLine("Вы разбились");
            else
                Console.WriteLine("Вы приземлились");


static int TimeChoose()
    {
        int number;
                do
                {
                    Console.Write("Введите номер от 1 до 35: ");
                    int.TryParse(Console.ReadLine(), out number);
                } while (number < 0 || number > 35);
                return number;
    }
static int ActionChoose(string msg, int x1, int x2)
        {
            bool valid = false;
            int input = 0;

            do
            {
                Console.Write(msg);
                valid = int.TryParse(Console.ReadLine(), out input);
            } while (!valid || (input != x1 && input != x2));

            return input;
        }
static void SquareRoot(double A,double B, double C, out int n, out double x1, out double x2)
{
    n=0;
    x1=0;
    x2=0;
    //проверка А
    if (A==0)
    {   
        x1=C/B;
    }
    else
    {
        double d = B*B-4*A*C;

        if (d<0) return;
        if (d==0) n=1;
        if (d>0) n=2;

        x1=(-B+Sqrt(d))/(2*A);
        x2=(-B-Sqrt(d))/(2*A);
    }
}    