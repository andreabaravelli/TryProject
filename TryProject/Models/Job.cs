namespace TryProject.Models
{
	public class Job
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string status { get; set; }
		public enum Status
		{
			execute,
			stop
		}
	}
}
