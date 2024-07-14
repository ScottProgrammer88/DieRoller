namespace DieRoller
{
    /// <summary>
    /// Represents a single six sided die (1-6).
    /// </summary>
    public class Die
    {
        /// <summary>
        /// Creates the die and rolls it to start with a random number.
        /// </summary>
        public Die()
        {
            Roll();    
        }

        /// <summary>
        /// The current face up value of the die.
        /// </summary>
        public byte FaceValue { get; private set; }

        /// <summary>
        /// True if the die is currently held
        /// </summary>
        public bool IsHeld { get; set; }

        /// <summary>
        /// Rolls the die and sets the <see cref="FaceValue"/> to the new number.
        /// Returns the new number.
        /// </summary>
        /// <returns>The new face value of the die</returns>
        public byte Roll()
        {
            // Generate a random number between 1 and 6
            Random random = new Random();
            byte newValue = (byte)random.Next(1, 7); // .Next returns a int so we need to cast it to a byte

            // Set the new face value
            FaceValue = newValue;

            // Return the new face value
            return FaceValue;
            // throw new NotImplementedException(); why was this added originally?
        }
    }
}
