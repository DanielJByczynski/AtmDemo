namespace AtmDemo.constants
{
    //  The InputConstants method defines the input list argument index.
    /// <summary>
    /// The <c>InputConstants</c> class defines the input list argument index.
    /// </summary>
    /// <seealso cref="AtmConstants"/>
    /// <seealso cref="PrintConstants"/>
    /// <seealso cref="PrintConstants"/>
    public static class InputConstants
    {
        //  The COMMAND constant defines index for the Command input argument.
        /// <summary>
        /// The <c>COMMAND</c> constant defines index for the Command input argument.
        /// </summary>
        /// <seealso cref="AMOUNT"/>
        public const int COMMAND = 0;

        //  The AMOUNT constant defines index for the AMOUNT input arguments.
        /// <summary>
        /// The <c>AMOUNT</c> constant defines index for the AMOUNT input arguments.
        /// </summary>
        /// <seealso cref="COMMAND"/>
        public const int AMOUNT = 1;
    }
}