﻿using System;

namespace Snake
{
    public class Point
    {
        public int x;
        public int y;
        public char sym;

        // Constructor
        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x += offset;
            }
            else if (direction == Direction.LEFT)
            {
                x -= offset;
            }
            else if (direction == Direction.UP)
            {
                y -= offset;
            }
            else if (direction == Direction.DOWN)
            {
                y += offset;
            }
        }

        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }

        public void Draw(ConsoleColor foreg = ConsoleColor.Black)
        {
            Console.BackgroundColor = default;
            Console.ForegroundColor = foreg;
            Console.SetCursorPosition(x, y); // Cursor position
            Console.Write(sym); // draw symbol
            Console.CursorVisible = false; // Hide cursor
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
    }
}