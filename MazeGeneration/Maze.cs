namespace MazeGeneration
{
    internal class Maze
    {
        private Square[] _squares;
        private int _size;
        private Random _random;

        public Maze(int size)
        {
            _random = new Random();
            _size = size;
            var squareCount = size * size;
            _squares = new Square[squareCount];
            for (int i = 0; i < squareCount; i++)
            {
                var row = i / size;
                var col = i % size;
                _squares[i] = new Square(row, col);
            }
            OpenWalls();
        }

        private void OpenWalls()
        {
            var index = _random.Next(0, _squares.Length);
            OpenSquare(index);
        }

        private void OpenSquare(int index)
        {
            var square = _squares[index];
            square.HasBeenVisited = true;
            var notVisitedNeighbours = GetNotVisitedNeighbours(square);

            while (notVisitedNeighbours.Count > 0)
            {
                var neighbourIndex = _random.Next(0, notVisitedNeighbours.Count);
                var neighbor = notVisitedNeighbours[neighbourIndex];
                if (neighbor.HasBeenVisited)
                {
                    notVisitedNeighbours.Remove(neighbor);
                    continue;
                }
                neighbor.HasBeenVisited = true;
                var neigbourIndex = neighbor.Row * _size + neighbor.Col;
                var IsHorizontal = Math.Abs(neigbourIndex - index) == 1;
                if (IsHorizontal)
                {
                    var index1 = Math.Min(index, neigbourIndex);
                    var index2 = Math.Max(index, neigbourIndex);
                    _squares[index1].IsWallRightOpen = true;
                    _squares[index2].IsWallLeftOpen = true;
                }
                else
                {
                    var index1 = Math.Min(index, neigbourIndex);
                    var index2 = Math.Max(index, neigbourIndex);
                    _squares[index1].IsWallDownOpen = true;
                    _squares[index2].IsWallUpOpen = true;
                }

                OpenSquare(neigbourIndex);
            }
        }

        private List<Square> GetNotVisitedNeighbours(Square square)
        {
            var notVisitedNeighbours = new List<Square>();
            AddIfNotVisited(square.Row - 1, square.Col, notVisitedNeighbours);
            AddIfNotVisited(square.Row + 1, square.Col, notVisitedNeighbours);
            AddIfNotVisited(square.Row, square.Col + 1, notVisitedNeighbours);
            AddIfNotVisited(square.Row, square.Col - 1, notVisitedNeighbours);
            return notVisitedNeighbours;
        }

        private void AddIfNotVisited(int row, int col, List<Square> notVisitedNeighbours)
        {
            if (row < 0 || row >= _size || col < 0 || col >= _size) return;
            var index = row* _size + col;
            var square = _squares[index];
            if (square.HasBeenVisited) return;
            notVisitedNeighbours.Add(square);
        }

        /*
            Funksjon generateMaze(width, height):
                Lag en tom rutenett av størrelse (width, height)
                Marker alle ruter som ubesøkte

                Velg en tilfeldig startRute
                Kall generateMazeRecursive(startRute)

                Returner det genererte rutenettet

            Funksjon generateMazeRecursive(currentCell):
                Marker currentCell som besøkt

                Finn alle ubesøkte naboer til currentCell
                Mens det er ubesøkte naboer:
                    Velg en tilfeldig nabo, nextCell
                    Sett currentCell og nextCell som besøkt
                    Fjern veggen mellom currentCell og nextCell

                    Kall generateMazeRecursive(nextCell)

                Returner 
             */

        public void Show()
        {
            foreach (var square in _squares)
            {
                square.Show();
            }
        }
    }
}
