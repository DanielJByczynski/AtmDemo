namespace AtmDemo.services
{
    public interface IDisplayService
    {
        // The DisplayBalanceLine method displays the balance line.
        /// <summary>
        ///     The <c>DisplayBalanceLine</c> method displays the balance line.
        /// </summary>
        /// <param name="denomination">Denomination to be returned.</param>
        /// <param name="value">
        ///     Inventory value of the denomination in the Atm.
        /// </param>
        /// <seealso cref="DisplayMachineBalance"/>
        /// <seealso cref="DisplayWithdrawalSuccess"/>
        /// <seealso cref="DisplayWithdrawalFailure"/>
        /// <seealso cref="DisplayInvalidCommandMessage"/>
        /// <seealso cref="DisplayInvalidArgumentMessage"/>
        void DisplayBalanceLine(int denomination, int value);

        // The DisplayMachineBalance method displays the machine balance.
        /// <summary>
        ///     The <c>DisplayMachineBalance</c> method displays the machine balance.
        /// </summary>
        /// <param name="atm">Atm object to have inventory displayed.</param>
        /// <seealso cref="DisplayBalanceLine"/>
        /// <seealso cref="DisplayWithdrawalSuccess"/>
        /// <seealso cref="DisplayWithdrawalFailure"/>
        /// <seealso cref="DisplayInvalidCommandMessage"/>
        /// <seealso cref="DisplayInvalidArgumentMessage"/>
        void DisplayMachineBalance(Atm atm);

        /*
         *    The DisplayWithdrawalSuccess method displays the Withdrawal
         *  Success message.
         */
        /// <summary>
        ///     The <c>DisplayWithdrawalSuccess</c> method displays the
        ///     Withdrawal Success message.
        /// </summary>
        /// <param name="atm">Atm object to have inventory displayed.</param>
        /// <param name="amount">Amount withdrawn from the Atm.</param>
        /// <seealso cref="DisplayBalanceLine"/>
        /// <seealso cref="DisplayMachineBalance"/>
        /// <seealso cref="DisplayWithdrawalFailure"/>
        /// <seealso cref="DisplayInvalidCommandMessage"/>
        /// <seealso cref="DisplayInvalidArgumentMessage"/>
        void DisplayWithdrawalSuccess(Atm atm, int amount);

        /*
         *    The DisplayWithdrawalFailure method displays the
         *  Withdrawal Failure message.
         */
        /// <summary>
        ///     The <c>DisplayWithdrawalFailure</c> method displays the
        ///     Withdrawal Failure message.
        /// </summary>
        /// <seealso cref="DisplayBalanceLine"/>
        /// <seealso cref="DisplayMachineBalance"/>
        /// <seealso cref="DisplayWithdrawalSuccess"/>
        /// <seealso cref="DisplayInvalidCommandMessage"/>
        /// <seealso cref="DisplayInvalidArgumentMessage"/>
        void DisplayWithdrawalFailure();

        /*
         *    The DisplayInvalidCommandMessage method displays the
         *  Invalid Command message.
         */
        /// <summary>
        ///     The <c>DisplayInvalidCommandMessage</c> method displays the
        ///     Invalid Command message.
        /// </summary>
        /// <seealso cref="DisplayBalanceLine"/>
        /// <seealso cref="DisplayMachineBalance"/>
        /// <seealso cref="DisplayWithdrawalSuccess"/>
        /// <seealso cref="DisplayWithdrawalFailure"/>
        /// <seealso cref="DisplayInvalidArgumentMessage"/>
        void DisplayInvalidCommandMessage();

        /*
         *    The DisplayInvalidArgumentMessage method displays the
         *  Invalid Argument message.
         */
        /// <summary>
        ///     The private <c>DisplayInvalidArgumentMessage</c> method displays the
        ///     Invalid Argument message.
        /// </summary>
        /// <seealso cref="DisplayBalanceLine"/>
        /// <seealso cref="DisplayMachineBalance"/>
        /// <seealso cref="DisplayWithdrawalSuccess"/>
        /// <seealso cref="DisplayWithdrawalFailure"/>
        /// <seealso cref="DisplayInvalidCommandMessage"/>
        void DisplayInvalidArgumentMessage();
    }
}