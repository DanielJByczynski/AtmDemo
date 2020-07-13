namespace AtmDemo.constants
{
    // The CommandConstants class contains the program's input char values.
    /// <summary>
    /// The <c>CommandConstants</c> class contains the program's input char values.
    /// </summary>
    /// <seealso cref="AtmConstants"/>
    /// <seealso cref="PrintConstants"/>
    /// <seealso cref="InputConstants"/>
    public static class CommandConstants
    {
        /*
         *      The RESTOCK parameter defines the char input value for the
         *  Restocking functionality.
         */
        /// <summary>
        /// The <c>RESTOCK</c> parameter defines the char input value for the
        /// Restocking functionality.
        /// </summary>
        /// <seealso cref="WITHDRAW"/>
        /// <seealso cref="INVENTORY"/>
        /// <seealso cref="QUIT"/>
        /// <seealso cref="COMMAND_ENUM"/>
        public const string RESTOCK = "R";

        /*
         *      The WITHDRAW parameter defines the char input value for the
         *  Withdrawal functionality.
         */
        /// <summary>
        /// The <c>WITHDRAW</c> parameter defines the char input value for the
        /// Withdrawal functionality.
        /// </summary>
        /// <seealso cref="RESTOCK"/>
        /// <seealso cref="INVENTORY"/>
        /// <seealso cref="QUIT"/>
        /// <seealso cref="COMMAND_ENUM"/>
        public const string WITHDRAW = "W";

        /*
         *      The INVENTORY parameter defines the char input value
         *  for the Inventory functionality.
         */
        /// <summary>
        /// The <c>INVENTORY</c> parameter defines the char input value
        /// for the Inventory functionality.
        /// </summary>
        /// <seealso cref="RESTOCK"/>
        /// <seealso cref="WITHDRAW"/>
        /// <seealso cref="QUIT"/>
        /// <seealso cref="COMMAND_ENUM"/>
        public const string INVENTORY = "I";

        /*
         *      The QUIT parameter defines the char input value
         *  for the Quit functionality.
         */
        /// <summary>
        /// The <c>QUIT</c> parameter defines the char input value
        /// for the Quit functionality.
        /// </summary>
        /// <seealso cref="RESTOCK"/>
        /// <seealso cref="INVENTORY"/>
        /// <seealso cref="WITHDRAW"/>
        /// <seealso cref="COMMAND_ENUM"/>
        public const string QUIT = "Q";

        /*
         *  The COMMAND_ENUM parameter defines the input Command enum values.
         */
        /// <summary>
        /// The <c>COMMAND_ENUM</c> parameter defines the input Command enum values.
        /// </summary>
        /// <seealso cref="RESTOCK"/>
        /// <seealso cref="INVENTORY"/>
        /// <seealso cref="WITHDRAW"/>
        /// <seealso cref="QUIT"/>
        public enum COMMAND_ENUM
        {
            Error = 1,
            Restock = 10,
            Withdraw = 20,
            Inventory = 30,
            Quit = 40
        }
    }
}