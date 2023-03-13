namespace Bevoelkerungsstand
{
    /// <summary>
    /// The Gender Class.
    /// </summary>
    internal class Gender
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The Gender.
        /// </summary>
        /// <param name="name"></param>
        public Gender(string name)
        {
            this.Name = name;
        }
    }
}