namespace MazeGeneration
{
    internal class Square
    {
        private readonly int _mazeRow;
        private readonly int _mazeCol;
        public bool WallUp;
        public bool WallDown;
        public bool WallLeft;
        public bool WallRight;

        public Square(int mazeRow, int mazeCol)
        {
            _mazeRow = mazeRow;
            _mazeCol = mazeCol;
        }

        public void Show()
        {
            var x = _mazeCol * 2;
            var y = _mazeRow * 2;
            WriteChar(x, y, false); // øvre venstre hjørne
            WriteChar(x+1, y, WallUp); // øvre midten
            WriteChar(x+2, y, false); // øvre høyre hjørne

            WriteChar(x, y+1, WallLeft); // midtre venstre 
            WriteChar(x + 1, y + 1, true); // midtre midten
            WriteChar(x + 2, y+1, WallRight); // midtre høyre 

            WriteChar(x, y+2, false); // nedre venstre hjørne
            WriteChar(x + 1, y+2, WallDown); // nedre midten
            WriteChar(x + 2, y+2, false); // nedre høyre hjørne
        }

        private static void WriteChar(int x, int y, bool isOpen)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(isOpen? ' ': '█');
        }
    }
}
