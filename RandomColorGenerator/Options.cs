namespace RandomColorGenerator
{
    /// <summary>
    /// Options for generating a random color.
    /// </summary>
    public class Options
    {
        /// <summary>
        /// Gets or sets the color scheme to use when generating the color.
        /// </summary>
        public ColorScheme ColorScheme { get; set; }
        /// <summary>
        /// Gets or sets the luminosity range to use when generating the color.
        /// </summary>
        public Luminosity Luminosity { get; set; }

        /// <summary>
        /// Creates a new instance using default values.
        /// </summary>
        public Options()
        {}

        /// <summary>
        /// Creates a new instance with the given color scheme and luminosity range.
        /// </summary>
        /// <param name="scheme">The color scheme to use when generating the color.</param>
        /// <param name="luminosity">The luminosity range to use when generating the color.</param>
        public Options(ColorScheme scheme, Luminosity luminosity)
        {
            ColorScheme = scheme;
            Luminosity = luminosity;
        }
    }
}