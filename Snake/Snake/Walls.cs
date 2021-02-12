using System;
using System.Collections.Generic;

namespace Snake
{
    class Walls
    {
        List<Figure> wallsList;
        public Walls(int mapWidth, int mapHeight)
        {
            wallsList = new List<Figure>();
            HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, mapWidth-2, mapHeight - 2, '+');
            VerticalLine leftLine = new VerticalLine(0, 0, mapHeight - 2, '+');
            VerticalLine rightLine = new VerticalLine(mapWidth - 2, 0, mapHeight - 2, '+');
            wallsList.Add(upLine);
            wallsList.Add(downLine);
            wallsList.Add(leftLine);
            wallsList.Add(rightLine);
        }

        internal void Draw()
        {
            foreach(var wall in wallsList)
            {
                wall.Draw();
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach(var wall in wallsList)
            {
                if(wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
    }
}