namespace HeatLoss.DomainModel
{
    /// <summary>
    /// Environment where the building is located.
    /// </summary>
    public class Environment
    {
        /// <summary>
        /// Gets or sets the outside temperature, in °C.
        /// </summary>
        /// <value>The outside temperature.</value>
        public double OutsideTemperature { get; set; }

        /// <summary>
        /// Gets or sets the ground temperature, in °C.
        /// </summary>
        /// <value>The ground temperature.</value>
        public double GroundTemperature { get; set; }
    }
}
