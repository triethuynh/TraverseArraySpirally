using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TraverseArraySpirallyNS;

/// <summary>
/// Unit test namespace
/// Written by Triet Huynh 06/23/2016 | triethuynh05@outlook.com
/// </summary>
namespace TraverseArraySpirallyUnitTests
{
	/// <summary>
	/// Unit test class
	/// </summary>
	[TestClass]
	public class TraverseArraySpirallyUnitTests
	{
		/// <summary>
		/// Traverse a null array
		/// </summary>
		[TestMethod]
		public void Traverse_NullArray()
		{
			int[,] A = null;

			TraverseArraySpirally T = new TraverseArraySpirally();
			List<int> R = T.TraverseArraySprirally(arrayToTraverse: A);

			Assert.IsTrue(condition: R.Count == 0, message: "Expecting an empty List<int>");

		}

		/// <summary>
		/// Traverse a one-element 1-D array
		/// </summary>
		[TestMethod]
		public void TraverseOneElementArray()
		{
			int[,] A = { { 10 } };
			List<int> expectedResultList = new List<int>(){ 10 };

			TraverseArraySpirally T = new TraverseArraySpirally();
			List<int> actualResultList = T.TraverseArraySprirally(arrayToTraverse: A);

			Assert.IsTrue(condition: this.CompareTwoListStartToEnd(expectedList: expectedResultList, actualList: actualResultList), message: "Actual list differs from expected list", parameters: new List<int>[] { actualResultList, expectedResultList });
		}

		/// <summary>
		/// Traverse a one-element 1-D array
		/// </summary>
		[TestMethod]
		public void TraverseTwoElementArray()
		{
			int[,] A = { { 10, -11 } };
			List<int> expectedResultList = new List<int>();
			expectedResultList.AddRange(collection: new int[] { 10, -11 });

			TraverseArraySpirally T = new TraverseArraySpirally();
			List<int> actualResultList = T.TraverseArraySprirally(arrayToTraverse: A);

			Assert.IsTrue(condition: this.CompareTwoListStartToEnd(expectedList: expectedResultList, actualList: actualResultList), message: "Actual list differs from expected list", parameters: new List<int>[] { actualResultList, expectedResultList });
		}

		/// <summary>
		/// Traverse a three-element 1-D array
		/// </summary>
		[TestMethod]
		public void TraverseThreeElementArray()
		{
			int[,] A = { { 10, 0, 10 } };
			List<int> expectedResultList = new List<int>();
			expectedResultList.AddRange(collection: new int[] { 10, 0, 10 });

			TraverseArraySpirally T = new TraverseArraySpirally();
			List<int> actualResultList = T.TraverseArraySprirally(arrayToTraverse: A);

			Assert.IsTrue(condition: this.CompareTwoListStartToEnd(expectedList: expectedResultList, actualList: actualResultList), message: "Actual list differs from expected list", parameters: new List<int>[] { actualResultList, expectedResultList });
		}

		/// <summary>
		/// Traverse a two-element 2-D array
		/// </summary>
		[TestMethod]
		public void Traverse1x1Array()
		{
			int[,] A = { { 10 }, { 1000 } };
			List<int> expectedResultList = new List<int>();
			expectedResultList.AddRange(collection: new int[] { 10, 1000 });

			TraverseArraySpirally T = new TraverseArraySpirally();
			List<int> actualResultList = T.TraverseArraySprirally(arrayToTraverse: A);

			Assert.IsTrue(condition: this.CompareTwoListStartToEnd(expectedList: expectedResultList, actualList: actualResultList), message: "Actual list differs from expected list", parameters: new List<int>[] { actualResultList, expectedResultList });
		}

		/// <summary>
		/// Traverse a four-element 2-D array (2 x 2)
		/// </summary>
		[TestMethod]
		public void Traverse2x2Array()
		{
			int[,] A = { { 1, 2}, { 4, 3 } };
			List<int> expectedResultList = new List<int>();
			expectedResultList.AddRange(collection: new int[] { 1, 2, 3, 4 });

			TraverseArraySpirally T = new TraverseArraySpirally();
			List<int> actualResultList = T.TraverseArraySprirally(arrayToTraverse: A);

			Assert.IsTrue(condition: this.CompareTwoListStartToEnd(expectedList: expectedResultList, actualList: actualResultList), message: "Actual list differs from expected list", parameters: new List<int>[] { actualResultList, expectedResultList });
		}

		/// <summary>
		/// Traverse a 3 x 2 array (3 columns x 2 rows)
		/// </summary>
		[TestMethod]
		public void Traverse3x2Array()
		{
			int[,] A = { { 1, 2, 3 }, { 6, 5, 4 } };
			List<int> expectedResultList = new List<int>();
			expectedResultList.AddRange(collection: new int[] { 1, 2, 3, 4, 5, 6 });

			TraverseArraySpirally T = new TraverseArraySpirally();
			List<int> actualResultList = T.TraverseArraySprirally(arrayToTraverse: A);

			Assert.IsTrue(condition: this.CompareTwoListStartToEnd(expectedList: expectedResultList, actualList: actualResultList), message: "Actual list differs from expected list", parameters: new List<int>[] { actualResultList, expectedResultList });
		}

		/// <summary>
		/// Traverse a 5 x 3 array (5 columns x 3 rows)
		/// </summary>
		[TestMethod]
		public void Traverse5x3Array()
		{
			int[,] A = { { 1, 2, 3, 4, 5 }, { 12, 13, 14, 15, 6 }, { 11, 10, 9, 8, 7} };
			List<int> expectedResultList = new List<int>();
			expectedResultList.AddRange(collection: new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 });

			TraverseArraySpirally T = new TraverseArraySpirally();
			List<int> actualResultList = T.TraverseArraySprirally(arrayToTraverse: A);

			Assert.IsTrue(condition: this.CompareTwoListStartToEnd(expectedList: expectedResultList, actualList: actualResultList), message: "Actual list differs from expected list", parameters: new List<int>[] { actualResultList, expectedResultList });
		}

		/// <summary>
		/// Traverse a 6 x 6 array (6x6 square array)
		/// </summary>
		[TestMethod]
		public void Traverse6x6Array()
		{
			// 6x6 array
			int[,] A = {    {  1,  2,  3,  4,  5,  6 },
							{ 20, 21, 22, 23, 24,  7 },
							{ 19, 32, 33, 34, 25,  8 },
							{ 18, 31, 36, 35, 26,  9 },
							{ 17, 30, 29, 28, 27, 10 },
							{ 16, 15, 14, 13, 12, 11 } };

			List<int> expectedResultList = new List<int>();
			int loopCount = A.GetLength(0) * A.GetLength(1);
			for (int i = 1; i <= loopCount; i++)
			{
				expectedResultList.Add(item: i);
			}

			TraverseArraySpirally T = new TraverseArraySpirally();
			List<int> actualResultList = T.TraverseArraySprirally(arrayToTraverse: A);

			Assert.IsTrue(condition: this.CompareTwoListStartToEnd(expectedList: expectedResultList, actualList: actualResultList), message: "Actual list differs from expected list", parameters: new List<int>[] { actualResultList, expectedResultList });
		}

		/// <summary>
		/// Traverse a 3 x 2 array (3 columns x 2 rows)
		/// </summary>
		[TestMethod]
		public void Traverse2x3Array()
		{
			int[,] A = { { 1, 2 }, { 6, 3 }, { 5, 4 } };
			List<int> expectedResultList = new List<int>();
			expectedResultList.AddRange(collection: new int[] { 1, 2, 3, 4, 5, 6 });

			TraverseArraySpirally T = new TraverseArraySpirally();
			List<int> actualResultList = T.TraverseArraySprirally(arrayToTraverse: A);

			Assert.IsTrue(condition: this.CompareTwoListStartToEnd(expectedList: expectedResultList, actualList: actualResultList), message: "Actual list differs from expected list", parameters: new List<int>[] { actualResultList, expectedResultList });
		}

		#region Helper Methods
		/// <summary>
		/// Method to determine if the two given list of integers are equal from start to end
		/// </summary>
		/// <param name="actualList">the actual list</param>
		/// <param name="expectedList">the expected list</param>
		/// <returns>
		/// true when the two lists have elemements equal from the start to the end of the list;
		/// false, otherwise
		/// </returns>
		private bool CompareTwoListStartToEnd(List<int> actualList, List<int> expectedList)
		{
			if (actualList == null || expectedList == null)
			{
				return false;
			}

			if (actualList.Count != expectedList.Count)
			{
				return false;
			}

			// Both list should have equal count when reaching here
			for (int i = 0; i < actualList.Count; i++)
			{
				if (actualList[i] != expectedList[i])
				{
					return false;
				}
			}

			return true;
		}
		#endregion Helper Methods
	}
}
