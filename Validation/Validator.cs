using Open.Linq.AsyncExtensions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Validation
{
	public static class Validator
    {

		public static async Task<IEnumerable<string>> X(this Task<IEnumerable<string>> source)
			=> await source;

		public static Task<IEnumerable<string>> ExampleTest(Task<List<string>> source)
			=> source.AsEnumerable().Where(x=>x=="foo").X();

	}
}
