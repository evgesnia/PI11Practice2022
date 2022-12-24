using System.Globalization;
while (true)
{
    Calculator calc = new Calculator();

        var n = "";
        while (true)
        {
            Console.CursorVisible = false;
            Console.Clear();
            Console.WriteLine(calc.Screen);
            Console.Write(n);
            n = Console.ReadKey(true).KeyChar.ToString(CultureInfo.InvariantCulture);
            calc.PressKey(n);
        }
}
