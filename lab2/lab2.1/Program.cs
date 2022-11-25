using static System.Console;
//данные
const int DOOR1=1;//
const int DOOR2=2;//
const int WINDOW=3;//
const int BOOKCASE=4;//
const int CARPET=5;//
const int TABLE=6;//

int loc= DOOR1;
int code=5879;
bool DOOR1_unlocked = false;//Главная дверь закрыта
bool DOOR2_unlocked = false;//Дверь закрыта
bool key_get = false;       //ключ не найден
bool PIN_get = false;       //ПИН_код не найден
bool book=false;            //книга лежит на полу
bool ImageInTheWindow=false;//изображение в окне не увидили

// НАЧАЛО ИГРЫ(ПРАВИЛА)
Console.Clear();
WriteLine("Вы находитесь в запертой комнате,ваша задача выбраться отсюда.");
WriteLine("В этом вам пожет ваша логика и смекалка.");
WriteLine("Надеюсь у вас все получится)");
WriteLine("Удачи!");
WriteLine();

//основной код//
while(true)
{
    WriteLine();
    /////////////
    //комната 1//
    /////////////
    if (loc==DOOR1)
    {
        //доступные дей-ия
        WriteLine("Перед вами комната,тут есть две двери.");
        WriteLine("Ваша главная задача открыть железную дверь)");
        if (!DOOR1_unlocked)
            WriteLine("На железной двери весит замок...");
        WriteLine();
        WriteLine("1) Подойти к окну.");
        WriteLine("2) Подойти к книжному шкафу.");
        WriteLine("3) Подойти ко второй двери.");
        if (!DOOR1_unlocked)
            WriteLine("4) Открыть замок.");
        else
            WriteLine("4) Выйти из комнаты."); 

        //выбор дей-ия
        int d=GetInt("Ваш выбор:",1,4);

        //обработка дей-ия
        if (d==1)//Подойти к окну.
            loc=WINDOW;
        else if (d==2)//Подойти к книжному шкафу.
            loc=BOOKCASE;
        else if (d==3)//Подойти ко второй двери.
            loc=DOOR2;
        else if (d==4)//Открыть замок или выйти
        {
            if (DOOR1_unlocked)//дверь отперта
            {
                WriteLine("Вы открыли замок с помощью ключа.");
                WriteLine("Поздравляю) Вы выбрались из комнат.");
                break;
            }
            else//дверь закрыта
            {
                if (key_get)
                {
                    DOOR1_unlocked = true;
                }
                else
                {
                    WriteLine("Необходимо сначала найти ключ...");
                }
            }    
        }
            
    }
    else if (loc==WINDOW)
    {   
        if (ImageInTheWindow==false)
        {
            //доступные дей-ия
            WriteLine("Вы подошли к окну.");
            WriteLine();
            WriteLine("1) Подойти к железной двери.");
            WriteLine("2) Подойти к книжному шкафу.");
            WriteLine("3) Подойти ко второй двери.");
            WriteLine("4) Посмотреть в окно.");
            ImageInTheWindow=true;
            //выбор дей-ия
            int d=GetInt("Ваш выбор:",1,4);

            //обработка дей-ия
            if (d==1)//Подойти к железной двери.
                loc=DOOR1;
            else if (d==2)//Подойти к книжному шкафу.
                loc=BOOKCASE;
            else if (d==3)//Подойти ко второй двери.
                loc=DOOR2;
            else if(d==4)//Посмотреть в окно.
            {
                WriteLine("Вы заметили странное исскажение...");
                WriteLine("Присмотревшись,вы разобрали две цифры 5 и 9");
            }
        }
        else
        {
            //доступные дей-ия
            WriteLine("Вы стоите у  окна.");
            WriteLine();
            WriteLine("1) Подойти к железной двери.");
            WriteLine("2) Подойти к книжному шкафу.");
            WriteLine("3) Подойти ко второй двери.");
            WriteLine("4) Посмотреть в окно еще раз.");

            //выбор дей-ия
            int d=GetInt("Ваш выбор:",1,4);

            //обработка дей-ия
            if (d==1)//Подойти к железной двери.
                loc=DOOR1;
            else if (d==2)//Подойти к книжному шкафу.
                loc=BOOKCASE;
            else if (d==3)//Подойти ко второй двери.
                loc=DOOR2;
            else if(d==4)//Посмотреть в окно еще.
                WriteLine("Присмотревшись,вы разобрали две цифры 5 и 9");
        }  
    }
    else if (loc==BOOKCASE)
    {
        if (book==false)
        {
            //доступные дей-ия
            WriteLine("Вы подошли к книжному шкафу,как вдруг одна из книг упала на пол...");
            WriteLine();
            WriteLine("1) Подойти к железной двери.");
            WriteLine("2) Посмотреть в окно.");
            WriteLine("3) Подойти ко второй двери.");
            WriteLine("4) Поставить книгу на место.");
            book=true;

            //выбор дей-ия
            int d=GetInt("Ваш выбор:",1,4);

            //обработка дей-ия
            if (d==1)//Подойти к железной двери.
                loc=DOOR1;
            else if (d==2)//Посмотреть в окно.
                loc=WINDOW;
            else if (d==3)//Подойти ко второй двери.
                loc=DOOR2;
            else if(d==4)//Подойти к книжному шкафу.
            {
                WriteLine("Поставив книгу на место, вы заметили, что из нее выпала записка.");
                WriteLine("Подняв записку, вы прочитали:«78год до н. э. — Цезарь служил под командованием Сервилия Исаврика и сражался с киликийскими пиратами.»");
            }
        }
        else
        {
            //доступные дей-ия
            WriteLine("Вы стоите у книжного шкафа.");
            WriteLine();
            WriteLine("1) Подойти к железной двери.");
            WriteLine("2) Посмотреть в окно.");
            WriteLine("3) Подойти ко второй двери.");
            WriteLine("4) Прочитать записку еще раз.");
            book=true;

            //выбор дей-ия
            int d=GetInt("Ваш выбор:",1,4);

            //обработка дей-ия
            if (d==1)//Подойти к железной двери.
                loc=DOOR1;
            else if (d==2)//Посмотреть в окно.
                loc=WINDOW;
            else if (d==3)//Подойти ко второй двери.
                loc=DOOR2;
            else if(d==4)//Прочитать записку еще раз.
                WriteLine("Вы прочитали:«78год до н. э. — Цезарь служил под командованием Сервилия Исаврика и сражался с киликийскими пиратами.»");
        }
        
    }
    /////////////
    //комната 2//
    /////////////
    else if (loc==DOOR2)
    {
        //доступные дей-ия
        WriteLine("Перед вами вторая дверь.");
        WriteLine("Чтобы открыть ее нужно ввести ПИН-код.");
    
        if (!DOOR2_unlocked)
        WriteLine();
        WriteLine("1) Подойти к окну.");
        WriteLine("2) Подойти к книжному шкафу.");
        WriteLine("3) Подойти ко второй двери.");
        WriteLine("4) Ввести ПИН-код.");

        //выбор дей-ия
        int d=GetInt("Ваш выбор:",1,4);

        //обработка дей-ия
        if (d==1)//Подойти к окну.
            loc=WINDOW;
        else if (d==2)//Подойти к книжному шкафу.
            loc=BOOKCASE;
        else if (d==3)//Подойти ко железной двери.
            loc=DOOR1;
        else if (d==4)//Ввести ПИН-код.
        {
            if (!DOOR2_unlocked)//дверь закрыта
            {
                if (!PIN_get)
                {
                    //Ввести ПИН-код
                    WriteLine("");
                    int x=GetInt("Введите ПИН-код(4 цифры):",1000,9999);

                    if(x==code)
                    {
                        DOOR2_unlocked = true;
                        WriteLine("Вы правильно ввели ПИН-код.Дверь открыта");
                        loc=TABLE;
                    }
                else
                    WriteLine("ПИН-код не правильный,попробуй еще раз.");
                }
                else
                {
                    WriteLine("Необходимо сначала найти ПИН-код....");
                }
            }    
        }        
    }
    else if (loc==TABLE)
        {
            WriteLine("Перед вами стол.");
            //доступные дей-ия
            WriteLine();
            WriteLine("1) Подойти к железной двери.");
            WriteLine("2) Посмотреть в окно.");
            WriteLine("3) Подойти к книжному шкафу.");
            WriteLine("4) Подойти к ковру.");
            WriteLine("5) Осмотреть стол.");
            //выбор дей-ия
            int d1=GetInt("Ваш выбор:",1,5);
            //обработка дей-ия
            if (d1==1)//Подойти к железной двери.
                loc=DOOR1;
            else if (d1==2)//Посмотреть в окно.
                loc=WINDOW;
            else if(d1==3)//Подойти к книжному шкафу.
                loc=BOOKCASE;
            else if (d1==4)//Подойти к ковру.
                loc=CARPET;
            else if (d1==5)//Осмотреть стол   
            {
                WriteLine("На столе стоит ваза, вы заметили что-то внутри нее.");
                WriteLine("Что же это ?");
                WriteLine("Внутри оказалась подсказка:");
                WriteLine("Аладдин летал в сказке на нем,А мы им застилаем полы в доме своем.");
                WriteLine("Что это значит?Подумай и двигайся дальше.");
            }
        }
    else if (loc==CARPET)
    {   
        if (key_get==false)
        {   
            //доступные дей-ия
            WriteLine("Вы стоите на ковре.");
            WriteLine("1) Подойти к железной двери.");
            WriteLine("2) Посмотреть в окно.");
            WriteLine("3) Подойти к книжному шкафу.");
            WriteLine("4) Подойти к столу.");
            WriteLine("5) Подвинуть ковер.");
            //выбор дей-ия
            int d1=GetInt("Ваш выбор:",1,5);
            //обработка дей-ия
            if (d1==1)//Подойти к железной двери.
                loc=DOOR1;
            else if (d1==2)//Посмотреть в окно.
                loc=WINDOW;
            else if(d1==3)//Подойти к книжному шкафу.
                loc=BOOKCASE;
            else if (d1==4)//Подойти к столу.
                loc=TABLE;
            else if (d1==5)//Подвинуть ковер.
            {
               WriteLine("Подвинув ковер, вы увидили ключ и подабрали его.");
                key_get=true;
            }
        }
        else
        {            
            //доступные дей-ия
            WriteLine("Вы стоите на ковре.");
            WriteLine("1) Подойти к железной двери.");
            WriteLine("2) Посмотреть в окно.");
            WriteLine("3) Подойти к книжному шкафу.");
            WriteLine("4) Подойти к столу.");
            //выбор дей-ия
            int d1=GetInt("Ваш выбор:",1,5);
            //обработка дей-ия
            if (d1==1)//Подойти к железной двери.
                loc=DOOR1;
            else if (d1==2)//Посмотреть в окно.
                loc=WINDOW;
            else if(d1==3)//Подойти к книжному шкафу.
                loc=BOOKCASE;
            else if (d1==4)//Подойти к ковру.
                loc=TABLE;
        }
    }
}   

static int GetInt(string s,int min,int max)
{
    int result = min;
    bool valid = false;
    do
    {
        Write(s);
        valid=int.TryParse(ReadLine(),out result);
    } while (!valid || result < min || result > max);
    return result;
}
