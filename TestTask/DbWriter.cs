using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestTask
{
	public static class DbWriter
	{
		public static async Task PushDataAsync(List<Test> data)
		{
			await Task.Factory.StartNew(() => 5);
		}
	}
}
