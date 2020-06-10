using HeatLoss.Data;

namespace HeatLoss
{
    /// <summary>
    /// Entry class of the application.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        private static void Main(string[] args)
        {
            var projectManager = new ProjectManager();
            var project = projectManager.CreateTestProject();

            // TODO

            projectManager.ShowProject(project);
        }
    }
}
