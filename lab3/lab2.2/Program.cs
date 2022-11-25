using static System.Console;

const int LOC_START = 0;
const int LOC_ASK1 = 1;
const int LOC_ASK2 = 2;
const int LOC_ASK3 = 3;
const int LOC_ASK4 = 4;
const int LOC_ASK5 = 5;
const int LOC_ASK6 = 6;
const int LOC_ASK7 = 7;
const int LOC_ASK8 = 8;
const int LOC_ASK9 = 9;
const int LOC_ASK10 = 10;
const int LOC_SPAWNPOINT=11;
const int LOC_FINISH=12;
const int LOC_START1 = 13;


Story story=null;
story = new StoryBuilder()
    .SetupStory("Вы очень хорошо отпраздновали Новый год.Проснувшись, вы понимаете, что находитесь в каом-то помещении. Осмотревшись до вас доходит, что находитесь в библиотеке.Вам необходимо выбраться от сюда,чтобы это сделать вам нужно првильно ответит на вопросы векторины.", "Вы выбрались!", LOC_ASK1)
    //если не правильный ответ 
    .AddLocation(LOC_START,"Вы не правильно ответили на вопрос,придется начать сначала(")
    .AddOption(LOC_START, LOC_ASK1,"Готов?")
    //первый ворос
    .AddLocation(LOC_ASK1, "Первый вопрос: Астрономия – это…")
    .AddOption(LOC_ASK1, LOC_START, " Максимально большая область пространства, включающая в себя все доступные для изучения небесные тела и их системы")
    .AddOption(LOC_ASK1, LOC_ASK2, " Наука о строении, движении, происхождении и развитии небесных тел, их систем и всей Вселенной в целом")
    .AddOption(LOC_ASK1, LOC_START, " Наука, изучающая законы строения материи, тел и их систем")
    //второй вопрос
    .AddLocation(LOC_ASK2, "Второй вопрос: 1 астрономическая единица равна…")
    .AddOption(LOC_ASK2, LOC_ASK3, " 150 млн.км")
    .AddOption(LOC_ASK2, LOC_START, " 3,26 св. лет")
    .AddOption(LOC_ASK2, LOC_START, " 1 св. год")
    //третий вопрос 
    .AddLocation(LOC_ASK3, "Третий вопрос: Основным источником знаний о небесных телах, процессах и явлениях происходящих во Вселенной, являются…")
    .AddOption(LOC_ASK3, LOC_START, " Измерения")
    .AddOption(LOC_ASK3, LOC_ASK4, " Наблюдения")
    .AddOption(LOC_ASK3, LOC_START, " Опыт")
    //четвертый вопрос
    .AddLocation(LOC_ASK4, "Четвертый вопрос: В тёмную безлунную ночь на небе можно увидеть примерно...")
    .AddOption(LOC_ASK4, LOC_START, " 2500 звёзд")
    .AddOption(LOC_ASK4, LOC_ASK5, " 3000 звёзд")
    .AddOption(LOC_ASK4, LOC_START, " 6000 звёзд")
    //пятый вопрос 
    .AddLocation(LOC_ASK5, "Пятый вопрос: Небесную сферу условно разделили на…")
    .AddOption(LOC_ASK5, LOC_START, " 50 созвездий ")
    .AddOption(LOC_ASK5, LOC_SPAWNPOINT, " 88 созвездий ")
    .AddOption(LOC_ASK5, LOC_START, " 100 созвездий")
    //SPAWNPOINT
    .AddLocation(LOC_SPAWNPOINT, "Отлично)Первый уровень пройден остался еще один...")
    .AddOption(LOC_SPAWNPOINT, LOC_ASK6, "Продолжим?")
    //страт1 
    .AddLocation(LOC_START1,"Вы не правильно ответили на вопрос,придется начать сначала(")
    .AddOption(LOC_START1, LOC_ASK6,"Готов?")
    //шестой вопрос 
    .AddLocation(LOC_ASK6, "СОБЫТИЕМ, ПОСЛУЖИВШИМ СПУСКОВЫМ КРЮЧКОМ К МИРОВОЙ БОЙНЕ, СТАЛО УБИЙСТВО АВСТРИЙСКОГО ЭРЦГЕРЦОГА ФРАНЦА ФЕРДИНАНДА СЕРБСКИМ НАЦИОНАЛИСТОМ ГАВРИЛОЙ ПРИНЦИПОМ. В КАКОМ ГОРОДЕ ПРОИЗОШЛА ЭТА ТРАГЕДИЯ?")
    .AddOption(LOC_ASK6, LOC_START1, " Загреб")
    .AddOption(LOC_ASK6, LOC_ASK7, " Сараево ")
    .AddOption(LOC_ASK6, LOC_START1, " Белград")
    // седьмой вопрос
    .AddLocation(LOC_ASK7, "ПОСЛЕ УБИЙСТВА ЭРЦГЕРЦОГА НА ПРОТЯЖЕНИИ МЕСЯЦА ДЛИЛСЯ ПОЛИТИЧЕСКИЙ КРИЗИС, КОТОРЫЙ ЕВРОПЕЙСКИЕ ДЕРЖАВЫ НЕ МОГЛИ РАЗРЕШИТЬ. В ИТОГЕ СТРАНЫ ОДНА ЗА ДРУГОЙ НАЧАЛИ ОБЪЯВЛЯТЬ ДРУГ ДРУГУ ВОЙНУ. КОГДА ПЕРВАЯ МИРОВАЯ НАЧАЛАСЬ ДЛЯ РОССИИ?")
    .AddOption(LOC_ASK7, LOC_START1, " 28 июля (15 июля) ")
    .AddOption(LOC_ASK7, LOC_ASK8, " 1 августа (19 июля ")
    .AddOption(LOC_ASK7, LOC_START1, " 3 августа (21 июля)")
    // восьмой вопрос
    .AddLocation(LOC_ASK8, "С САМЫХ ПЕРВЫХ ДНЕЙ ВОЙНЫ РУССКАЯ АРМИЯ ПОВЕЛА НАСТУПЛЕНИЕ НА ВОСТОЧНОМ ФРОНТЕ. ОСОБЕННО УСПЕШНЫМИ БЫЛИ ДЕЙСТВИЯ ПРОТИВ АВСТРО-ВЕНГРИИ. КАК НАЗЫВАЛАСЬ БИТВА, В КОТОРОЙ РОССИЯ ОДЕРЖАЛА ВЕРХ НАД АВСТРИЙЦАМИ В АВГУСТЕ-СЕНТЯБРЕ 1914 ГОДА?")
    .AddOption(LOC_ASK8, LOC_START1, " Битва на Марне ")
    .AddOption(LOC_ASK8, LOC_ASK9, " Галицийская битва ")
    .AddOption(LOC_ASK8, LOC_START1, " Битва при Капоретто")
    // девятый вопрос
    .AddLocation(LOC_ASK9, "НА ЗАПАДНОМ ФРОНТЕ В 1915 ГОДУ НАЧАЛАСЬ ПОЗИЦИОННАЯ ВОЙНА. СТОРОНЫ КОНФЛИКТА ПЫТАЛИСЬ НАЙТИ ВЫХОД ИЗ СЛОЖИВШЕЙСЯ СИТУАЦИИ, В ТОМ ЧИСЛЕ ПРИМЕНЯЯ НОВЫЕ ВИДЫ ВООРУЖЕНИЙ. ОДНИМ ИЗ НИХ СТАЛО ХИМИЧЕСКОЕ ОРУЖИЕ, КОТОРОЕ ВПЕРВЫЕ ПРИМЕНИЛИ ГЕРМАНСКИЕ ВОЙСКА. ВО ХОДЕ КАКОЙ БИТВЫ ЭТО ПРОИЗОШЛО?")
    .AddOption(LOC_ASK9, LOC_START1, " Битва на Марне ")
    .AddOption(LOC_ASK9, LOC_ASK10, " Сражение при Ипре ")
    .AddOption(LOC_ASK9, LOC_START1, " Битва при Сомме")
    //десятый вопрос
    .AddLocation(LOC_ASK10, "ХИМИЧЕСКОЕ ОРУЖИЕ БЫЛО ПРИМЕНЕНО НЕМЦАМИ И НА ВОСТОЧНОМ ФРОНТЕ. ЭПИЗОД, СВЯЗАННЫЙ С ЭТИМ, ПОЛУЧИЛ В ДАЛЬНЕЙШЕМ НАЗВАНИЕ «АТАКА МЕРТВЕЦОВ»: РУССКИЙ ГАРНИЗОН ОДНОЙ ИЗ КРЕПОСТЕЙ, ОТРАЗИВШИЙ ШТУРМ С ПРИМЕНЕНИЕМ ГАЗОВ, 6 АВГУСТА НЕОЖИДАННО ДЛЯ ПРОТИВНИКА ПОШЁЛ В КОНТРАТАКУ. О КАКОЙ КРЕПОСТИ ИДЁТ РЕЧЬ?")
    .AddOption(LOC_ASK10, LOC_START1, " Новогеоргиевск")
    .AddOption(LOC_ASK10, LOC_FINISH, " Осовец")
    .AddOption(LOC_ASK10, LOC_START1, " Брест-Литовск")
    //финиш
    .AddLocation(LOC_FINISH,"Все этапы пройдены,поздравляю теперь ты свободен.Хочешь пройти заново?")
    .AddOption(LOC_ASK10, LOC_START, " Да")
    .AddOption(LOC_ASK10, LOC_FINISH, " Нет")
    .Build();
    


////////////
// engine //
////////////
Clear();
WriteLine(story.Intro);
while(true)
{
    Location loc = story.Locations.First(item => item.Id == story.CurrentLocationId);
    WriteLine();
    WriteLine(loc.Description);

    for (int i=0; i<loc.Options.Count; i++)
        WriteLine($"{i+1}) {loc.Options[i].Title}");

    int n = GetInt("Ваш выбор: ", 1, loc.Options.Count) - 1;

    loc.Options[n].Work();
}
WriteLine(story.Final);



int GetInt(string msg, int min, int max)
{
    int result = min;
    bool valid = false;
    do
    {
        Write(msg);
        valid = int.TryParse(ReadLine(), out result);
    } while(!valid || result < min || result > max);
    return result;
}