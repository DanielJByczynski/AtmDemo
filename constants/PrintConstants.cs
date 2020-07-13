namespace AtmDemo.constants
{
    /*
     *  The PrintConstants method contains the program's output strings.
     */
    /// <summary>
    /// The <c>PrintConstants</c> method contains the program's output strings.
    /// </summary>
    /// <seealso cref="AtmConstants"/>
    /// <seealso cref="CommandConstants"/>
    /// <seealso cref="InputConstants"/>
    public static class PrintConstants
    {
        //  The CURRENCY_CHAR constant defines the currency symbol prefix.
        /// <summary>
        /// The <c>CURRENCY_CHAR</c> constant defines the currency symbol prefix.
        /// </summary>
        /// <seealso cref="INVALID_COMMAND"/>
        /// <seealso cref="INVALID_ARGUMENT"/>
        /// <seealso cref="MACHINE_BALANCE"/>
        /// <seealso cref="HYPHEN_SPACING"/>
        /// <seealso cref="WITHDRAWAL_SUCCESS"/>
        /// <seealso cref="WITHDRAWAL_FAILURE"/>
        public const char CURRENCY_CHAR = '$';

        /*
         *      The INVALID_COMMAND constant defines the invalid command
         *  output message.
         */
        /// <summary>
        /// The <c>INVALID_COMMAND</c> constant defines the invalid command
        /// output message.
        /// </summary>
        /// <seealso cref="CURRENCY_CHAR"/>
        /// <seealso cref="INVALID_ARGUMENT"/>
        /// <seealso cref="MACHINE_BALANCE"/>
        /// <seealso cref="HYPHEN_SPACING"/>
        /// <seealso cref="WITHDRAWAL_SUCCESS"/>
        /// <seealso cref="WITHDRAWAL_FAILURE"/>
        public const string INVALID_COMMAND = "Failure: Invalid Command";

        /*
         *      The INVALID_ARGUMENT constant defines the invalid argument
         *  output message.
         */
        /// <summary>
        /// The <c>INVALID_ARGUMENT</c> constant defines the invalid argument
        /// output message.
        /// </summary>
        /// <seealso cref="CURRENCY_CHAR"/>
        /// <seealso cref="INVALID_COMMAND"/>
        /// <seealso cref="MACHINE_BALANCE"/>
        /// <seealso cref="HYPHEN_SPACING"/>
        /// <seealso cref="WITHDRAWAL_SUCCESS"/>
        /// <seealso cref="WITHDRAWAL_FAILURE"/>
        public const string INVALID_ARGUMENT = "Failure: Invalid Argument";

        /*
         *      The MACHINE_BALANCE constant defines the machine balance
         *  header message.
         */
        /// <summary>
        /// The <c>MACHINE_BALANCE</c> constant defines the machine balance
        /// header message.
        /// </summary>
        /// <seealso cref="CURRENCY_CHAR"/>
        /// <seealso cref="INVALID_COMMAND"/>
        /// <seealso cref="INVALID_ARGUMENT"/>
        /// <seealso cref="HYPHEN_SPACING"/>
        /// <seealso cref="WITHDRAWAL_SUCCESS"/>
        /// <seealso cref="WITHDRAWAL_FAILURE"/>
        public const string MACHINE_BALANCE = "Machine Balance:";

        /*
         *      The HYPHEN_SPACING constant defines the inventory
         *  Denomination-Inventory divider.
         */
        /// <summary>
        /// The <c>HYPHEN_SPACING</c> constant defines the inventory
        /// Denomination-Inventory divider.
        /// </summary>
        /// <seealso cref="CURRENCY_CHAR"/>
        /// <seealso cref="INVALID_COMMAND"/>
        /// <seealso cref="INVALID_ARGUMENT"/>
        /// <seealso cref="MACHINE_BALANCE"/>
        /// <seealso cref="WITHDRAWAL_SUCCESS"/>
        /// <seealso cref="WITHDRAWAL_FAILURE"/>
        public const string HYPHEN_SPACING = " - ";

        /*
         *      The WITHDRAWAL_SUCCESS constant defines the withdrawal
         *  success message.
         */
        /// <summary>
        /// The <c>WITHDRAWAL_SUCCESS</c> constant defines the withdrawal
        /// success message.
        /// </summary>
        /// <seealso cref="CURRENCY_CHAR"/>
        /// <seealso cref="INVALID_COMMAND"/>
        /// <seealso cref="INVALID_ARGUMENT"/>
        /// <seealso cref="MACHINE_BALANCE"/>
        /// <seealso cref="HYPHEN_SPACING"/>
        /// <seealso cref="WITHDRAWAL_FAILURE"/>
        public const string WITHDRAWAL_SUCCESS = "Success: Dispensed ";

        /*
         *      The WITHDRAWAL_FAILURE constant defines the withdrawal
         *  failure message.
         */
        /// <summary>
        /// The <c>WITHDRAWAL_FAILURE</c> constant defines the withdrawal
        /// failure message.
        /// </summary>
        /// <seealso cref="CURRENCY_CHAR"/>
        /// <seealso cref="INVALID_COMMAND"/>
        /// <seealso cref="INVALID_ARGUMENT"/>
        /// <seealso cref="MACHINE_BALANCE"/>
        /// <seealso cref="HYPHEN_SPACING"/>
        /// <seealso cref="WITHDRAWAL_SUCCESS"/>
        public const string WITHDRAWAL_FAILURE = "Failure: insufficient funds";
    }
}