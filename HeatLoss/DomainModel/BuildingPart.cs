namespace HeatLoss.DomainModel
{
    /// <summary>
    /// Building part.
    /// </summary>
    public class BuildingPart
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the area, in m2.
        /// </summary>
        /// <value>The area.</value>
        /// <remarks>This is the gross area, i.e. the area including the area of all child building parts</remarks>
        public double Area { get; set; }

        // TODO: Transparent building parts and opaque (non-transparent) building parts
    }
}
