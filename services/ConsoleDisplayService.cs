using System;
using AtmDemo.constants;

namespace AtmDemo.services
{
    /*
        The Console Display Service:
        Contains all methods for displaying information to the console.
    */
    /// <summary>
    /// The <c>ConsoleDisplayService</c> class.
    /// Contains all methods for displaying information to the console.
    /// <list type="bullet">
    ///     <item>
    ///         <term>DisplayBalanceLine</term>
    ///         <description>Prints a balance line to the console.</description>
    ///     </item>
    ///     <item>
    ///         <term>DisplayMachineBalance</term>
    ///         <description>Prints the machine balance to the console.</description>
    ///     </item>
    ///     <item>
    ///         <term>DisplayWithdrawalSuccess</term>
    ///         <description>Prints Withdrawal Success message and machine balance to console.</description>
    ///     </item>
    ///     <item>
    ///         <term>DisplayWithdrawalFailure</term>
    ///         <description>Prints Withdrawal Failure message to console.</description>
    ///     </item>
    ///     <item>
    ///         <term>DisplayInvalidCommandMessage</term>
    ///         <description>Prints Invalid Command message to console.</description>
    ///     </item>
    ///     <item>
    ///         <term>DisplayInvalidArgumentMessage</term>
    ///         <description>Prints Invalid Argument message to console.</description>
    ///     </item>
    /// </list>
    /// </summary>
    public class ConsoleDisplayService : IDisplayService
    {
        #region Private Fields

        #endregion

        #region Constructor

        #endregion

        #region Public Methods

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
        public virtual void DisplayBalanceLine(int denomination, int value)
        {
            // Build print string.
            var balanceLine = string.Concat(PrintConstants.CURRENCY_CHAR,
                                            denomination,
                                            PrintConstants.HYPHEN_SPACING,
                                            value);
            Print(balanceLine);
        }

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
        public virtual void DisplayMachineBalance(Atm atm)
        {
            DisplayMachineBalanceHeader();

            foreach (var denomination in atm.Denominations)
            {
                DisplayBalanceLine(
                    denomination,
                    atm.GetValue(denomination));
            }
        }

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
        public virtual void DisplayWithdrawalSuccess(Atm atm, int amount)
        {
            var display = string.Concat(PrintConstants.WITHDRAWAL_SUCCESS,
                                        PrintConstants.CURRENCY_CHAR,
                                        amount.ToString());
            Print(display);

            // Print Machine Balances.
            DisplayMachineBalance(atm);

        }

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
        public virtual void DisplayWithdrawalFailure()
        {
            Print(PrintConstants.WITHDRAWAL_FAILURE);
        }

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
        public virtual void DisplayInvalidCommandMessage()
        {
            Print(PrintConstants.INVALID_COMMAND);
        }

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
        public virtual void DisplayInvalidArgumentMessage()
        {
            Print(PrintConstants.INVALID_ARGUMENT);
        }

        #endregion

        #region Private Methods

        // The private DisplayMachineBalanceHeader method displays the Machine Balance Header.  
        /// <summary>
        /// The <c>DisplayMachineBalanceHeader</c> method displays the Machine Balance Header.
        /// </summary>
        /// <seealso cref="Print"/>
        private void DisplayMachineBalanceHeader()
        {
            Print(PrintConstants.MACHINE_BALANCE);
        }

        // The private Print method provides a layer of abstraction between the data and the display.  
        /// <summary>
        /// The private <c>Print</c> method provides a layer of abstraction
        ///  between the data and the display.
        /// </summary>
        /// <param name="output">The string to be displayed.</param>
        /// <seealso cref="DisplayMachineBalanceHeader"/>
        private void Print(string output)
        {
            Console.WriteLine(output);
        }

        #endregion
    }
}