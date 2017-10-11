﻿using System.Collections.Generic;
using System.Linq;

namespace SnakeBeauty
{
    internal class Snake
    {
        public Direction MoveDir;
        public List<Point> Points { get; }
        public Snake()
        {
            Points = new List<Point>();
            MoveDir = new Direction(2);
        }

        public int Length()
        {
            return Points.Count;
        }

        public Point AddPoint(Point point)
        {
            Points.Add(point);
            return point;
        }

        public Point GetHead()
        {
            return Points.Last();
        }

        public void SetHead(Point newH)
        {
            Points.Add(newH);
        }

        public Point GetEnd()
        {
            return Points.First();
        }

        public void RemoveLast()
        {
            Points.RemoveAt(0);
        }

        public void RemovePointAt(int i)
        {
            Points.RemoveAt(i);
        }

        public Direction GetDirection()
        {
            return MoveDir;
        }

        public short ChangeDirection(short s)
        {
            return MoveDir.Set(s);
        }
    }
}
