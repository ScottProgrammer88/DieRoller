namespace DieRoller
{
    /// <summary>
    /// Represents a single six sided die (1-6).
    /// </summary>
    public class Die
    {
        /// <summary>
        /// The current face up value of the die.
        /// </summary>
        public byte FaceValue { get; set; }

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
            
            
            if (!IsHeld)
            {
                FaceValue = (byte)DieRoller.Random.Next(1, 7);
            }
            throw new NotImplementedException();
        }










        private static Random _random = new Random();
        
        /// <summary>
        /// Rolls the die and returns the result.
        /// </summary>
        public int Roll()
        {
            return _random.Next(1, 7);
        }
    }
}
