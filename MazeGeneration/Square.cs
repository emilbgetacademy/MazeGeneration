namespace MazeGeneration
{
    internal class Square
    {
        public readonly int Row;
        public readonly int Col;
        public bool IsWallUpOpen;
        public bool IsWallDownOpen;
        public bool IsWallLeftOpen;
        public bool IsWallRightOpen;
        public bool HasBeenVisited;

        public Square(int row, int col)
        {
            Row = row;
            Col = col;
        }

        public void Show()
        {
            var x = Col * 2;
            var y = Row * 2;
            WriteChar(x, y, false); // øvre venstre hjørne
            WriteChar(x+1, y, IsWallUpOpen); // øvre midten
            WriteChar(x+2, y, false); // øvre høyre hjørne

            WriteChar(x, y+1, IsWallLeftOpen); // midtre venstre 
            WriteChar(x + 1, y + 1, true); // midtre midten
            WriteChar(x + 2, y+1, IsWallRightOpen); // midtre høyre 

            WriteChar(x, y+2, false); // nedre venstre hjørne
            WriteChar(x + 1, y+2, IsWallDownOpen); // nedre midten
            WriteChar(x + 2, y+2, false); // nedre høyre hjørne
        }

        private static void WriteChar(int x, int y, bool isOpen)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(isOpen? ' ': '█');
        }
    }
}
