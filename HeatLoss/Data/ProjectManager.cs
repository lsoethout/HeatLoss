using System;
using System.Collections.Generic;
using HeatLoss.DomainModel;
using Environment = HeatLoss.DomainModel.Environment;

namespace HeatLoss.Data
{
    /// <summary>
    /// Collection of methods to manage projects.
    /// </summary>
    public class ProjectManager
    {
        /// <summary>
        /// Creates the test project.
        /// </summary>
        /// <returns>Project.</returns>
        public Project CreateTestProject()
        {
            var building = new Building
            {
                Name="Vabi building",
            };

            var project = new Project
            {
                Name = "Test project",
                Environment = new Environment
                {
                    OutsideTemperature = 7.0,
                    GroundTemperature = 10.0
                },
                Building = building
            };

            var part = new BuildingPart
            {
                Name = "ground floor - front wall",
                Area = 16.50,
            };
            // TODO: building.BuildingParts.Add(part);

            // TODO

            return project;
        }

        /// <summary>
        /// Shows the project on the console.
        /// </summary>
        /// <param name="project">The project.</param>
        public void ShowProject(Project project)
        {
            Console.WriteLine("Overview of the project");
            // TODO
        }

        /// <summary>
        /// Saves the project to the specified file path.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="project">The project.</param>
        public void SaveProject(string path, Project project)
        {
            // TODO or remove
            throw new NotImplementedException();
        }

        /// <summary>
        /// Loads the project from the specified file path.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>Project.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public Project LoadProject(string path)
        {
            // TODO or remove
            throw new NotImplementedException();
        }
    }
}
