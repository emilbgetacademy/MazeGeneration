## Docker
Navigate to the source directory "MazeGeneration" (Dockerfile recides there too)

Build Image
```bash
docker build -t mazegeneration .
```

Run Container
```bash
clear && docker run -t --rm --name MazeGeneration mazegeneration && echo
```

Remove Image
```bash
docker rmi mazegeneration
```
