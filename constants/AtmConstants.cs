namespace AtmDemo.constants
{
    /*
     *  The AtmConstants class defines various app setting constants for the system.
     */
    /// <summary>
    /// The <c>AtmConstants</c> class defines various app setting constants
    /// for the system.
    /// </summary>
    /// <seealso cref="CommandConstants"/>
    /// <seealso cref="PrintConstants"/>
    /// <seealso cref="InputConstants"/>
    public static class AtmConstants
    {
        /*
         *      The MAX_INPUT_ARGUMENTS constant defines the maximum number of
         *      argument inputs accepted by the system. This does not include
         *      the Command input.
         */
        /// <summary>
        /// <c>MAX_INPUT_ARGUMENTS</c> constant defines the maximum number of argument
        /// inputs accepted by the system. This does not include the Command input.
        /// </summary>
        /// <seealso cref="MIN_INPUT_ARGUMENTS"/>
        /// <seealso cref="VALUE_INDEX"/>
        /// <seealso cref="COUNT_INDEX"/>
        public const int MAX_INPUT_ARGUMENTS = 6;

        /*
         *      MIN_INPUT_ARGUMENTS constant defines the minimum number of argument
         *  inputs accepted by the system. This does not include the Command input.
         */
        /// <summary>
        /// <c>MIN_INPUT_ARGUMENTS</c> constant defines the minimum number of
        /// argument
        /// inputs accepted by the system. This does not include the Command input.
        /// </summary>
        /// <seealso cref="MAX_INPUT_ARGUMENTS"/>
        /// <seealso cref="VALUE_INDEX"/>
        /// <seealso cref="COUNT_INDEX"/>
        public const int MIN_INPUT_ARGUMENTS = 0;

        
 // Todo: COMMENTS
        public const int MAX_WITHDRAWAL_AMOUNT = 2500;

        /*
         *      The VALUE_INDEX constant defines the denomination value column in the
         *  [Denomination, Inventory] <c>Atm</c> <c>Vault</c> array.
         */
        /// <summary>
        /// The <c>VALUE_INDEX</c> constant defines the denomination value column
        /// in the [Denomination, Inventory] <c>Atm</c> <c>Vault</c> array.
        /// </summary>
        /// <seealso cref="MAX_INPUT_ARGUMENTS"/>
        /// <seealso cref="MIN_INPUT_ARGUMENTS"/>
        /// <seealso cref="COUNT_INDEX"/>
        public const int VALUE_INDEX = 0;

        /*
         *      The COUNT_INDEX constant is used to define the inventory count
         *  column in the [Denomination, Inventory] <c>Atm</c> <c>Vault</c> array.
         */
        /// <summary>
        /// The <c>COUNT_INDEX</c> constant is used to define the inventory count
        /// column in the [Denomination, Inventory] <c>Atm</c> <c>Vault</c> array.
        /// </summary>
        /// <seealso cref="MAX_INPUT_ARGUMENTS"/>
        /// <seealso cref="MIN_INPUT_ARGUMENTS"/>
        /// <seealso cref="VALUE_INDEX"/>
        public const int COUNT_INDEX = 1;
    }
}