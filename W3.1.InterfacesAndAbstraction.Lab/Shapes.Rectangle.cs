﻿using System;

namespace Shapes
{
	class Rectangle : IDrawable
	{
		public int Width { get; private set; }

		public int Height { get; private set; }

		public Rectangle(int width, int height)
		{
			Width = width;
			Height = height;
		}

		public void Draw()
		{
			DrawLine(Width, '*', '*');
			for (int i = 1; i < Height - 1; i++)
			{
				DrawLine(Width, '*', ' ');
			}
			DrawLine(Width, '*', '*');
		}

		private void DrawLine(int length, char terminal, char mid)
		{
			Console.Write(terminal);
			for (int i = 1; i < length - 1; i++)
			{
				Console.Write(mid);
			}
			Console.Write(terminal);
		}
	}
}
