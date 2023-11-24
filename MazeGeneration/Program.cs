// See https://aka.ms/new-console-template for more information


using MazeGeneration;

var a = new Square(0, 0);
var b = new Square(0, 1);
var c = new Square(1, 0);

a.Open(2);
b.Open(-1);

a.Show();
b.Show();
c.Show();

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
