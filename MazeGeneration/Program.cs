// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

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
