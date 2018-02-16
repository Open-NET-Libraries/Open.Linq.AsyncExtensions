using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Open.Linq.AsyncExtensions
{
	// Because of the necessary specificity of Task<IEnumerable<T>> these exensions are provided to facilitate proper casting.

	public static partial class Extensions
	{
		//
		// Summary:
		//     Returns the input typed as System.Collections.Generic.IEnumerable`1.
		//
		// Parameters:
		//   source:
		//     The sequence to type as System.Collections.Generic.IEnumerable`1.
		//
		// Type parameters:
		//   TSource:
		//     The type of the elements of source.
		//
		// Returns:
		//     The input sequence typed as System.Collections.Generic.IEnumerable`1.
		public static async Task<IEnumerable<TSource>> AsEnumerable<TSource>(
			this Task<ICollection<TSource>> source)
			=> (await source).AsEnumerable();

		//
		// Summary:
		//     Returns the input typed as System.Collections.Generic.IEnumerable`1.
		//
		// Parameters:
		//   source:
		//     The sequence to type as System.Collections.Generic.IEnumerable`1.
		//
		// Type parameters:
		//   TSource:
		//     The type of the elements of source.
		//
		// Returns:
		//     The input sequence typed as System.Collections.Generic.IEnumerable`1.
		public static async Task<IEnumerable<TSource>> AsEnumerable<TSource>(
			this Task<IList<TSource>> source)
			=> (await source).AsEnumerable();


		//
		// Summary:
		//     Returns the input typed as System.Collections.Generic.IEnumerable`1.
		//
		// Parameters:
		//   source:
		//     The sequence to type as System.Collections.Generic.IEnumerable`1.
		//
		// Type parameters:
		//   TSource:
		//     The type of the elements of source.
		//
		// Returns:
		//     The input sequence typed as System.Collections.Generic.IEnumerable`1.
		public static async Task<IEnumerable<TSource>> AsEnumerable<TSource>(
			this Task<List<TSource>> source)
			=> (await source).AsEnumerable();

		//
		// Summary:
		//     Returns the input typed as System.Collections.Generic.IEnumerable`1.
		//
		// Parameters:
		//   source:
		//     The sequence to type as System.Collections.Generic.IEnumerable`1.
		//
		// Type parameters:
		//   TSource:
		//     The type of the elements of source.
		//
		// Returns:
		//     The input sequence typed as System.Collections.Generic.IEnumerable`1.
		public static async Task<IEnumerable<TSource>> AsEnumerable<TSource>(
			this Task<ISet<TSource>> source)
			=> (await source).AsEnumerable();

		//
		// Summary:
		//     Returns the input typed as System.Collections.Generic.IEnumerable`1.
		//
		// Parameters:
		//   source:
		//     The sequence to type as System.Collections.Generic.IEnumerable`1.
		//
		// Type parameters:
		//   TSource:
		//     The type of the elements of source.
		//
		// Returns:
		//     The input sequence typed as System.Collections.Generic.IEnumerable`1.
		public static async Task<IEnumerable<TSource>> AsEnumerable<TSource>(
			this Task<HashSet<TSource>> source)
			=> (await source).AsEnumerable();


		//
		// Summary:
		//     Returns the input typed as System.Collections.Generic.IEnumerable`1.
		//
		// Parameters:
		//   source:
		//     The sequence to type as System.Collections.Generic.IEnumerable`1.
		//
		// Type parameters:
		//   TSource:
		//     The type of the elements of source.
		//
		// Returns:
		//     The input sequence typed as System.Collections.Generic.IEnumerable`1.
		public static async Task<IEnumerable<TSource>> AsEnumerable<TSource>(
			this Task<TSource[]> source)
			=> (await source).AsEnumerable();

		//
		// Summary:
		//     Returns the input typed as System.Collections.Generic.IEnumerable`1.
		//
		// Parameters:
		//   source:
		//     The sequence to type as System.Collections.Generic.IEnumerable`1.
		//
		// Type parameters:
		//   TSource:
		//     The type of the elements of source.
		//
		// Returns:
		//     The input sequence typed as System.Collections.Generic.IEnumerable`1.
		public static IEnumerable<TSource> DequeueAsEnumerable<TSource>(
			this Queue<TSource> source)
		{
			while (source.Count != 0)
				yield return source.Dequeue();
		}

		//
		// Summary:
		//     Returns the input typed as System.Collections.Generic.IEnumerable`1.
		//
		// Parameters:
		//   source:
		//     The sequence to type as System.Collections.Generic.IEnumerable`1.
		//
		// Type parameters:
		//   TSource:
		//     The type of the elements of source.
		//
		// Returns:
		//     The input sequence typed as System.Collections.Generic.IEnumerable`1.
		public static async Task<IEnumerable<TSource>> DequeuAsEnumerable<TSource>(
			this Task<Queue<TSource>> source)
			=> (await source).DequeueAsEnumerable();


		//
		// Summary:
		//     Returns the input typed as System.Collections.Generic.IEnumerable`1.
		//
		// Parameters:
		//   source:
		//     The sequence to type as System.Collections.Generic.IEnumerable`1.
		//
		// Type parameters:
		//   TSource:
		//     The type of the elements of source.
		//
		// Returns:
		//     The input sequence typed as System.Collections.Generic.IEnumerable`1.
		public static async Task<IEnumerable<KeyValuePair<TKey,TValue>>> AsEnumerable<TKey, TValue>(
			this Task<IDictionary<TKey, TValue>> source)
			=> (await source).AsEnumerable();

		//
		// Summary:
		//     Returns the input typed as System.Collections.Generic.IEnumerable`1.
		//
		// Parameters:
		//   source:
		//     The sequence to type as System.Collections.Generic.IEnumerable`1.
		//
		// Type parameters:
		//   TSource:
		//     The type of the elements of source.
		//
		// Returns:
		//     The input sequence typed as System.Collections.Generic.IEnumerable`1.
		public static async Task<IEnumerable<KeyValuePair<TKey, TValue>>> AsEnumerable<TKey, TValue>(
			this Task<Dictionary<TKey, TValue>> source)
			=> (await source).AsEnumerable();
	}
}
