using System;
using System.Collections.Generic;

/// <summary>
/// Problem from http://blog.sdeskills.com/technical-thursday-09-jun-2016-spatial-problems/
/// 
/// Thank you, Vivekanand Kirubanandan, for the great meetup session!
/// 
/// Code implementation by Triet Huynh (post meetup session 06/09/2016) | triethuynh05@outlook.com
/// </summary>
namespace TraverseArraySpirallyNS
{
	/// <summary>
	/// Program class
	/// </summary>
	public class TraverseArraySpirally
	{
		/// <summary>
		/// Main
		/// </summary>
		/// <param name="args">args</param>
		static void Main(string[] args)
		{
			TraverseArraySpirally P = new TraverseArraySpirally();

			int[,] A = { { 1,  2,  3,  4,  5 },
						 {12, 13, 14, 15,  6 },
						 {11, 10,  9,  8,  7 }};

			//int[,] A = { { 1, 2, },
			//			 { 8, 3, },
			//			 { 7, 4, },
			//			 { 6, 5  }};

			List<int> E = P.TraverseArraySprirally(A);

			foreach (int n in E)
			{
				Console.Write(string.Format(" {0}", n));
			}
			Console.WriteLine();

			Console.ReadKey();
		}

		/// <summary>
		/// Traverse the given 2-D array spirally
		/// 
		/// Problem from http://blog.sdeskills.com/technical-thursday-09-jun-2016-spatial-problems/
		/// </summary>
		/// <param name="arrayToTraverse">the given array</param>
		/// <returns>The list contain elements collected while traversing the 2-D array spirally</returns>
		public List<int> TraverseArraySprirally(int[,] arrayToTraverse)
		{
			List<int> L = new List<int>();

			if (arrayToTraverse == null)
			{
				return L;
			}

			// n x m 2-D array (n columns and m rows)
			int n = arrayToTraverse.GetLength(dimension: 1);
			int m = arrayToTraverse.GetLength(dimension: 0);
			int totalCount = n * m;

			// The inital four edges of the 2-D array
			int topY = 0;
			int bottomY = m - 1;
			int leftX = 0;
			int rightX = n - 1;

			// Count of elements while traversing the array
			int count = 0;

			while (count < totalCount)
			{
				// 1. Going right
				// y is constant (topY)
				for (int x = leftX; x <= rightX; x++)
				{
					L.Add(arrayToTraverse[topY, x]);
					count++;
				}
				if (count == totalCount)
				{
					break;
				}
				topY++;

				// 2. Going down
				// x is constant (rightX)
				for (int y = topY; y <= bottomY; y++)
				{
					L.Add(arrayToTraverse[y, rightX]);
					count++;
				}
				if (count == totalCount)
				{
					break;
				}
				rightX--;

				// 3. Going left
				// y is constant (bottomY)
				for (int x = rightX; x >= leftX; x--)
				{
					L.Add(arrayToTraverse[bottomY, x]);
					count++;
				}
				if (count == totalCount)
				{
					break;
				}
				bottomY--;

				// 4. Going up
				// x is constant (leftX)
				for (int y = bottomY; y >= topY; y--)
				{
					L.Add(arrayToTraverse[y, leftX]);
					count++;
				}
				if (count == totalCount)
				{
					break;
				}
				leftX++;
			}

			return L;
		}
	}
}
