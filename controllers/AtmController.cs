using System.Collections.Generic;
using AtmDemo.constants;

namespace AtmDemo.services
{
    /// <summary>
    /// <c>AtmController</c>The AtmController class contains 
    /// all methods for controlling ATM operation.
    /// </summary>
    public class AtmController
    {
        #region Private Fields

        private readonly IDisplayService _displayService;
        private readonly IInputService _inputService;
        private static List<int[]> _possibilities;

        #endregion

        #region Constructor

        /*
         *  Initialize new instance of AtmController(IDisplayService, IInputService).
         */
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AtmController(IDisplayService, IInputService)"/> class.
        /// </summary>
        public AtmController(
            IDisplayService displayService,
            IInputService inputService)
        {
            _displayService = displayService;
            _inputService = inputService;
            _possibilities = new List<int[]>();
        }

        #endregion

        #region Public Methods

        /*
         *      The StartAtm method instantiates the Atm object and runs
         *  the InputMessage Command cycle.
         */
        /// <summary>
        /// The <c>StartAtm</c> method instantiates the Atm object and runs
        /// the InputMessage Command cycle.
        /// <example>
        /// Example:
        /// <code>
        ///     atmController.StartAtm();
        /// </code>
        /// starts the Atm.
        /// </example>
        /// </summary>
        public void StartAtm()
        {
            var run = true;
            var atm = new Atm();

            while (run)
            {
                var inputMessage = _inputService.GetInputMessage();

                // Run input command.
                switch (inputMessage.Command)
                {
                    case (int)CommandConstants.COMMAND_ENUM.Restock:
                        Restock(out atm);
                        break;
                    case (int)CommandConstants.COMMAND_ENUM.Withdraw:
                        atm = Withdraw(atm, inputMessage.WithdrawalAmount);
                        break;
                    case (int)CommandConstants.COMMAND_ENUM.Inventory:
                        Inventory(atm, inputMessage.CountRequests);
                        break;
                    case (int)CommandConstants.COMMAND_ENUM.Quit:
                        run = false;
                        break;
                    default:
                        _displayService.DisplayInvalidCommandMessage(); ;
                        break;
                }
            }
        }

        /*
         *      The Restock method resets the Atm object,
         *  displays the machine balance, then outputs the atm object. 
         */
        /// <summary>
        /// The <c>Restock</c> method resets the Atm object,
        /// displays the machine balance, then outputs the atm object. 
        /// <example>
        /// Example:
        /// <code>
        ///     Restock(atm);
        /// </code>
        /// results in the Atm object resetting and the machine
        /// balance displaying.
        /// </example>
        /// </summary>
        /// <param name="atm"><c>atm</c> is the Atm object to be reset.</param>
        /// <seealso cref="Inventory(Atm, List{int})"/>
        /// <seealso cref="Withdraw(Atm, int)"/>
        public void Restock(out Atm atm)
        {
            atm = new Atm();
            _displayService.DisplayMachineBalance(atm);
        }

        /*
         *      The Inventory method accepts an Atm object and a list
         *  of denominations and validates them. If valid, a distinct
         *  list of the requested inventories is displayed.
         */
        /// <summary>
        /// The <c>Inventory</c> method accepts an Atm object and a list 
        /// of denominations and validates them. If valid, a distinct list of 
        /// the requested inventories is displayed.
        /// <example>
        /// Example:
        /// <code>
        ///     Inventory(atm, denominations);
        /// </code>
        /// results in the output of inventory information for the provided
        /// list of denominations.
        /// </example>
        /// </summary>
        /// <param name="atm"><c>atm</c> is the Atm object.</param>
        /// <param name="inputs"><c>inputs</c> is a list of inventory requests.</param>
        /// <seealso cref="Restock(out Atm)"/>
        /// <seealso cref="Withdraw(Atm, int)"/>
        public void Inventory(Atm atm, List<int> inputs)
        {
            //  Return error if inputs is less than 1.
            if (inputs.Count < 1)
            {
                _displayService.DisplayInvalidArgumentMessage();
                return;
            }

            //  Loop over each input.
            foreach (var input in inputs)
            {
                //  Instantiate Index.
                int index = 0;

                //  Instantiate validity check bool.
                bool isValidInput = false;

                // Try to get denomination from input value.
                foreach (var denomination in atm.Denominations)
                {
                    //  Check if input matches vaultKey value.
                    if (input == denomination)
                    {
                        //  Displays the balance line for the valid request.
                        _displayService.DisplayBalanceLine(
                            input,
                             atm.Inventory[index]);

                        //  Confirm validity.
                        isValidInput = true;
                        break;
                    }

                    //  Iterate index.
                    index++;
                }

                // Error if input is not a valid denomination.
                if (!isValidInput)
                {
                    _displayService.DisplayInvalidArgumentMessage();
                }
            }
        }

        /*
         *      The Withdraw method returns the optimal way to remove the
         *  requested amount from the Atm vault using the least number of bills.
         *  The machine balance and withdrawal amount are displayed if the 
         *  withdrawal was a success, an error is shown on failure.
         */
        /// <summary>
        ///         The <c>Withdraw</c> method returns the optimal way to remove the
        ///     requested amount from the Atm vault using the least number of bills.
        ///     The machine balance and withdrawal amount are displayed if the 
        ///     withdrawal was a success, an error is shown on failure.
        ///     <example>
        ///         Example: 
        ///         <code>
        ///             atm = Withdraw(atm, withdrawalAmount);
        ///         </code>
        ///         returns an atm object which has been mo
        ///     </example>
        /// </summary>
        /// <param name="atm"><c>atm</c> is the Atm object.</param>
        /// <param name="amount"><c>amount</c> is the amount to be withdrawn.</param>
        /// <returns>Atm object.</returns>
        /// <seealso cref="Restock(out Atm)"/>
        /// <seealso cref="Inventory(Atm, List{int})"/>
        /// <seealso cref="Possibilities(int[], int[], int[], int, int)"/>
        public Atm Withdraw(Atm atm, int amount)
        {
            //  Validate arguments.
            if (atm == null || amount < 1 || amount > AtmConstants.MAX_WITHDRAWAL_AMOUNT)
            {
                //  Display withdrawal failure message on invalid input.
                _displayService.DisplayInvalidArgumentMessage();

                //  Return to exit method.
                return atm;
            }

            //  Create temporary vault value lists.
            var vaultKeys = new List<int>(atm.Denominations);
            var vaultValues = new List<int>(atm.Inventory);

            //  Clear the possibilities list.
            _possibilities = new List<int[]>();

            //  Calculate change possibility int arrays and save to possibilities list.
            Possibilities(
                vaultKeys.ToArray(),
                vaultValues.ToArray(),
                new int[vaultKeys.Count],
                amount,
                0);

            //  Check if the possibility list has any results.
            if (_possibilities.Count > 0)
            {
                //  Loop over each result in the possibilities list.
                foreach (int[] result in _possibilities)
                {
                    //  Loop over each value in the current result array.
                    for (int x = 0; x < result.Length; x++)
                    {
                        //  Remove the result amount from the temp vault values.
                        vaultValues[x] -= result[x];
                    }

                    //  Exit the possibility loop.
                    break;
                }

                //  Loop over each atm vault list int.
                for (int i = 0; i < atm.Vault.Count; i++)
                {
                    //  Set the temp vault values to the atm vault.
                    atm.SetValue(atm.Denominations[i], vaultValues[i]);
                }

                //  Display Success Message and Machine Balance.
                _displayService.DisplayWithdrawalSuccess(atm, amount);
            } else
            {
                //  Display Failure Message.
                _displayService.DisplayWithdrawalFailure();
            }
            return atm;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Possiblities takes an input amount, and compiles a list of change possibilities
        /// sorted by denomination from highest value to lowest.
        /// </summary>
        /// <param name="vaultKeys">Array of denomination values.</param>
        /// <param name="vaultValues">Array of inventory values.</param>
        /// <param name="possibility"></param>
        /// <param name="amount">Change amount desired.</param>
        /// <param name="index">index</param>
        /// <returns>Void.</returns>
        /// <seealso cref="Withdraw(Atm, int)"/>
        /// <seealso cref="GetPossibilityTotal(int[], int[])"/>
        private void Possibilities(
            int[] vaultKeys,
            int[] vaultValues,
            int[] possibility,
            int amount,
            int index)
        {
            //  Calculate the total of the possibility values.
            int total = GetPossibilityTotal(vaultKeys, possibility);

            //  Check if the total of possibility values is less than the desired amount.
            if (total < amount)
            {
                //  Loop over each vaultKey value.
                for (int i = index; i < vaultKeys.Length; i++)
                {
                    //  Check if there is enough inventory to remove bill.
                    if (vaultValues[i] > possibility[i])
                    {
                        //  Instantiate new possibility array and iterate the current vaultValue.
                        int[] newPossibility = new List<int>(possibility).ToArray();
                        newPossibility[i]++;

                        //  Recursive call to generate new list of possibilities.
                        Possibilities(
                            vaultKeys,
                            vaultValues,
                            newPossibility,
                            amount,
                            i);
                    }
                }
            }
            else if (total == amount) //  Check if change has been made!
            {
                //  Add successful possibility to Possibility List.
                _possibilities.Add(possibility);
            }
        }

        /// <summary>
        /// Calculates the total of the possibility using the vaultKey array.
        /// </summary>
        /// <param name="vaultKeys">VaultKey int array.</param>
        /// <param name="possibility">Possibility values int array.</param>
        /// <returns>Total amount of the possibliity <c>int</c></returns>
        /// <seealso cref="Possibilities(int[], int[], int[], int, int)"/>
        private int GetPossibilityTotal(int[] vaultKeys, int[] possibility)
        {
            //  Instantiate total int.
            int total = 0;

            //  Loop over each possibility item.
            for (int i = 0; i < possibility.Length; i++)
            {
                //  Multiply the vaultKey value to the number of bills in the possibility.
                total += vaultKeys[i] * possibility[i];
            }

            //  Return the calculated total.
            return total;
        }

        #endregion
    }
}