namespace Orc.Sort.NSort
{
    using System.Collections;

    using Orc.Sort.Interfaces;

    /// <summary>
	/// Bubble sort sequential algorithm
	/// </summary>
	/// <remarks>
	/// <para>
	/// Bubble sort is a sequential sorting algorithm that runs in
	/// <em>O(n^2)</em>, where <em>n</em> is the number of elements in the 
	/// list.
	/// </para>
	/// <para>
	/// Source: <a href="http://www.cs.rit.edu/~atk/Java/Sorting/sorting.html">
	/// http://www.cs.rit.edu/~atk/Java/Sorting/sorting.html</a>
	/// </para>
	/// </remarks>
	public class BubbleSorter : SwapSorter
	{
		public BubbleSorter()
			:base()
		{
		}

		public BubbleSorter(IComparer comparer, ISwap swapper)
			:base(comparer,swapper)
		{
		}

		public override void Sort(IList list)
		{
			for (int i = list.Count; --i>=0; )
			{
				for (int j = 0; j<i; j++) 
				{
					if (this.Comparer.Compare(list[j],list[j+1])>0) 
						this.Swapper.Swap(list,j,j+1);
				}		
			}
		}
	}
}
