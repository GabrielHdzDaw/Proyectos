namespace BORRAR_MapaPrueba
{
    internal class Program
    {
        const int TAMANO = 10;

        public static void MostrarMapa(char[,] lineas)
        {
            Console.Clear();
            Console.CursorVisible = false;

            int x = 0;
            int y = 0;

            ConsoleKeyInfo tecla = new ConsoleKeyInfo();
            while(tecla.Key != ConsoleKey.Escape)
            {
                Console.SetCursorPosition(0,0);

                for(int i=x; i<TAMANO+x; i++)
                {
                    for(int j=y; j<TAMANO+y; j++)
                    {
                         Console.Write($"{lineas[i, j]} ");
                    }
                    Console.WriteLine();
                }

                if(Console.KeyAvailable == true)
                {
                    tecla = Console.ReadKey(true);
                    LecturaTecla(ref x, ref y, lineas.GetLength(0), lineas.GetLength(1), tecla);
                }
            }
        }

        public static void LecturaTecla(ref int x, ref int y, int maxX, int maxY, ConsoleKeyInfo tecla)
        {
            switch (tecla.Key)
            {
                case ConsoleKey.UpArrow:
                    if (x > 0)
                    {
                        x--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (x < maxX - TAMANO)
                    {
                        x++;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (y > 0)
                    {
                        y--;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (y < maxY - TAMANO)
                    {
                        y++;
                    }
                    break;
            }
        }

        static void Main(string[] args)
        {
            char[,] mapa =
            {
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
                {'#',' ',' ',' ','~','~','~',' ',' ','^','^','^',' ',' ','T','T','T','T',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ','@',' ','~','~','~',' ',' ','^','^','^',' ',' ','T','T','T','T',' ',' ',' ','M',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ','~','~','~',' ',' ',' ',' ',' ',' ','T','T','T','T','T','T',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ','#','#','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#','#',' ',' ',' ',' ',' ',' ','#','#','#','#'},
                {'#',' ','#','#','#',' ','M',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#','#',' ',' ',' ',' ',' ',' ','#','#','#','#'},
                {'#',' ','#','#','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#','#',' ',' ',' ',' ',' ',' ','#','#','#','#'},
                {'#',' ',' ',' ',' ',' ','B','B','B',' ',' ',' ',' ',' ',' ','P','P','P',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ','B','B','B','B','B','B',' ',' ',' ',' ',' ','P','P','P',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ',' ','B','B','B',' ',' ',' ',' ',' ',' ','P','P','P',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','C',' ',' ',' ','#'},
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'}
            };


            MostrarMapa(mapa);
        }
    }
}
