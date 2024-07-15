namespace DieRoller // This is a namespace, it is a way to group related classes together
{
    /// <summary>
    /// Represents a single six sided die (1-6).
    /// </summary>
    public class Die // This is a class, it is a blueprint for creating objects
    {
        private static Random _random; // This is a static field, so it is shared between all instances of Die

        static Die() // This is a static constructor, it is called once when the class is first used
        {
            _random = new Random(); // Create a new Random object
        }

        /// <summary>
        /// Creates the die and rolls it to start with a random number.
        /// </summary>
        public Die() // This is the constructor, it is called when a new instance of Die is created
        {
            Roll();    // Roll the die to set the initial face value
        }

        /// <summary>
        /// The current face up value of the die.
        /// </summary>
        public byte FaceValue { get; private set; } // This is a property, it is a way to access a private field

        /// <summary>
        /// True if the die is currently held
        /// </summary>
        public bool IsHeld { get; set; } // This is a property, it is a way to access a private field

        /// <summary>
        /// Rolls the die and sets the <see cref="FaceValue"/> to the new number, if
        /// the die is not currentl held.
        /// Returns the <see cref="FaceValue"/>
        /// </summary>
        /// <returns>Returns the <see cref="FaceValue"/></returns>
        public byte Roll() // This is a method, it is a function that belongs to the class
        {
            if (!IsHeld) // If the die is not held
            {
                // Generate a random number between 1 and 6
                byte newValue = (byte)_random.Next(1, 7); // .Next returns a int so we need to cast it to a byte

                // Set the new face value
                FaceValue = newValue; // This is a field, it is a variable that belongs to the class
            }
            // Return the new face value
            return FaceValue; 
            // throw new NotImplementedException(); why was this added originally?
        }
    }
}
