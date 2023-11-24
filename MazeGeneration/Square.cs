namespace MazeGeneration
{
    internal class Square
    {
        private int _mazeRow;
        private int _mazeCol;

        private bool[] _walls;

        public Square(int mazeRow, int mazeCol)
        {
            _mazeRow = mazeRow;
            _mazeCol = mazeCol;
            // indekser:        0     1     2     3
            // hvilken vegg: opp   høyre ned   venstre
            _walls = new bool[] { true, true, true, true };
        }

        public void Show()
        {
            var x = _mazeCol * 2;
            var y = _mazeRow * 2;
            WriteChar(x, y, false); // øvre venstre hjørne
            WriteChar(x+1, y, _walls[0]); // øvre midten
            WriteChar(x+2, y, false); // øvre høyre hjørne

            WriteChar(x, y+1, _walls[3]); // midtre venstre 
            WriteChar(x + 1, y + 1, true); // midtre midten
            WriteChar(x + 2, y+1, _walls[1]); // midtre høyre 

            WriteChar(x, y+2, false); // nedre venstre hjørne
            WriteChar(x + 1, y+2, _walls[2]); // nedre midten
            WriteChar(x + 2, y+2, false); // nedre høyre hjørne
        }

        private static void WriteChar(int x, int y, bool isOpen)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(isOpen? ' ': '█');
        }

        public void Open(int direction)
        {
            var index = direction switch
            {
                < -1 => 1,
                -1 => 3,
                1 => 1,
                > 1 => 2,
            };
            _walls[index] = true;
        }
    }
}
