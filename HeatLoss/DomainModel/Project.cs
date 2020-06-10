namespace HeatLoss.DomainModel
{
    /// <summary>
    /// Project, top class of the domain model.
    /// </summary>
    /// <remarks>This class contains all the input classes for the heat-loss calculation.</remarks>
    public class Project
    {
        /// <summary>
        /// Gets or sets the project name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the environment for the <see cref="Building"/>.
        /// </summary>
        /// <value>The environment.</value>
        public Environment Environment { get; set; }

        /// <summary>
        /// Gets or sets the building.
        /// </summary>
        /// <value>The building.</value>
        public Building Building { get; set; }
    }
}
