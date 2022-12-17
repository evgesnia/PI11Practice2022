class Maze
{
    //данные
    int playerx=1;
    int playery=1;
    bool key1=false;
    bool key2=false;
    public int i=0;
    public bool end = false;
    int[,] maze = new int[,]
    {
        {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
        {1,0,1,0,6,0,3,0,0,0,0,0,0,0,0,1},
        {1,0,1,0,1,0,1,1,0,1,1,1,1,1,1,1},
        {1,0,1,0,1,0,0,0,0,1,0,0,0,0,0,0},
        {1,6,1,0,1,6,1,1,0,1,0,0,0,0,0,0},
        {1,0,1,6,1,0,1,1,4,1,1,1,1,1,1,1},
        {1,0,1,0,1,0,1,1,0,1,0,0,0,0,0,1},
        {1,0,1,0,1,0,0,1,0,5,0,7,0,0,0,1},
        {1,6,0,0,1,1,0,1,6,1,0,0,0,0,0,1},
        {1,0,1,1,1,1,2,1,0,1,1,1,1,1,1,1},
        {1,6,0,0,6,1,0,1,0,6,0,0,0,0,0,1},
        {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
    };
    ConsoleColor ink;
    ConsoleColor paper;
    
    public Maze(ConsoleColor i, ConsoleColor p)
    {
        ink = i;
        paper = p;
        
    }

    //методы
    public void Move(int dx, int dy)
    {   
        int nx = playerx + dx;
        int ny = playery + dy;

        if (maze[ny,nx] == 0)
        {
            playerx = nx;
            playery = ny;
        }
        else if (maze[ny,nx]==2)
        {
            playerx = nx;
            playery = ny;
            key1=true;
            maze[ny,nx]=0;
        }
        else if(maze[ny,nx]==3 && key1)
        {
            playerx = nx;
            playery = ny;
            maze[ny,nx]=0;
        }
        else if (maze[ny,nx]==4)
        {
            playerx = nx;
            playery = ny;
            key2=true;
            maze[ny,nx]=0;
        }
        else if(maze[ny,nx]==5 && key2)
        {
            playerx = nx;
            playery = ny;
            maze[ny,nx]=0;
        }
        else if(maze[ny,nx]==6)
        {
            playerx = nx;
            playery = ny;
            maze[ny,nx]=0;
            i=i+1;
        }
        else if(maze[ny,nx]==7)
        {
            maze[ny,nx]=0;
            end = true;
        }
    }   
    
    public void Print(int shiftx, int shifty)
    {
        for (int y=0; y<maze.GetLength(0); y++)
            for (int x=0; x<maze.GetLength(1); x++)
            {
                double dist = Math.Sqrt((playerx-x)*(playerx-x) + (playery-y)*(playery-y));
                if (dist > 3.7)
                {
                    Print(shiftx + x, shifty + y, " ", ConsoleColor.Gray, ConsoleColor.DarkGray);
                }
                else
                {
                    if (maze[y,x] == 0) Print(shiftx + x, shifty + y, ".");
                    else if (maze[y,x] == 1) Print(shiftx + x, shifty + y, "#", ink, paper);
                    else if (maze[y,x]==2) Print (shiftx+x,shifty+y,"$",ConsoleColor.Green);
                    else if (maze[y,x]==3) Print (shiftx+x,shifty+y,"*",ConsoleColor.Green);
                    else if (maze[y,x]==4) Print (shiftx+x,shifty+y,"$",ConsoleColor.Blue);
                    else if (maze[y,x]==5) Print (shiftx+x,shifty+y,"*",ConsoleColor.Blue);
                    else if (maze[y,x]==6) Print (shiftx+x,shifty+y,"~",ConsoleColor.Yellow);
                    else if (maze[y,x]==7) Print (shiftx+x,shifty+y,"!",ConsoleColor.Gray);
                }
            }

        Print(shiftx + playerx, shifty + playery, "@");
    }

    void Print(int x, int y, string s, ConsoleColor ink = ConsoleColor.White, ConsoleColor paper = ConsoleColor.Black)
    {
        Console.ForegroundColor = ink;
        Console.BackgroundColor = paper;
        
        Console.CursorLeft = x;
        Console.CursorTop = y;
        Console.Write(s);
    
    }  
}