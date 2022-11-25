﻿Console.Clear();

Maze m = new Maze(ConsoleColor.Red, ConsoleColor.Gray);


while (true)
{
    m.Print(3,3);
    
    
    ConsoleKeyInfo ki = Console.ReadKey(true);
    if (ki.Key == ConsoleKey.LeftArrow ) m.Move(-1,0) ;
    if (ki.Key == ConsoleKey.RightArrow) m.Move(1,0);
    if (ki.Key == ConsoleKey.UpArrow) m.Move(0,-1);
    if (ki.Key == ConsoleKey.DownArrow) m.Move(0,1);
    if (ki.Key == ConsoleKey.Enter) break;
    

    
}
