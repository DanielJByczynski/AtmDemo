using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using AtmDemo.constants;

namespace AtmDemo.services
{
    public class ConsoleInputService : IInputService
    {
        #region Private Properties

        #endregion

        #region Constructor

        #endregion

        #region Public Methods

        /*
         *    The GetInputMessage method prompts the user for input and
         *  returns an AtmInputMessage object.
         */
        /// <summary>
        ///    The GetInputMessage method prompts the user for input and
        ///    returns an AtmInputMessage object.
        ///    <example>
        ///    Example:
        ///    <code>
        ///       var inputMessage = _inputService.GetInputMessage();
        ///    </code>
        ///    returns an AtmInputMessage object.
        ///    </example>
        /// </summary>
        /// <returns>Returns an AtmInputMessage object.</returns>
        public AtmInputMessage GetInputMessage()
        {
            var inputMessage = new AtmInputMessage();

            // Get Command Input and split into strings delimited by spaces.
            var inputStrings = Console.ReadLine().Split(' ').ToList();

            // Validate inputStrings length.
            if (inputStrings.Count > (AtmConstants.MAX_INPUT_ARGUMENTS + 1)
                    || inputStrings.Count < AtmConstants.MIN_INPUT_ARGUMENTS + 1)
            {
                inputMessage.Command = (int)CommandConstants.COMMAND_ENUM.Error;
                return inputMessage;
            }

            inputMessage = BuildInputMessage(inputMessage, inputStrings);

            return inputMessage;
        }

        #endregion

        #region Private Methods

        /*
         *  Builds the input message Command and argument(s).
         */
        /// <summary>
        /// Builds the input message Command and argument(s).
        /// </summary>
        /// <param name="inputMessage"></param>
        /// <param name="inputStrings"></param>
        /// <returns>AtmInputMessage object.</returns>
        private AtmInputMessage BuildInputMessage(
            AtmInputMessage inputMessage,
            List<string> inputStrings)
        {
            inputMessage.Command = GetCommand(inputStrings);
            inputMessage = GetArguments(inputMessage, inputStrings);

            return inputMessage;
        }

        /*
         *  Gets the Command int for the inputMessage.
         */
        /// <summary>
        /// Gets the Command int for the inputMessage.
        /// </summary>
        /// <param name="inputStrings"></param>
        /// <returns>Command Int.</returns>
        private int GetCommand(List<string> inputStrings)
        {
            int command;

            // Get command from beginning of input string array.
            switch (inputStrings[InputConstants.COMMAND])
            {
                case CommandConstants.RESTOCK:
                    command = (int)CommandConstants.COMMAND_ENUM.Restock;
                    break;

                case CommandConstants.WITHDRAW:
                    command = (int)CommandConstants.COMMAND_ENUM.Withdraw;
                    break;

                case CommandConstants.INVENTORY:
                    command = (int)CommandConstants.COMMAND_ENUM.Inventory;
                    break;

                case CommandConstants.QUIT:
                    command = (int)CommandConstants.COMMAND_ENUM.Quit;
                    break;

                default:
                    command = (int)CommandConstants.COMMAND_ENUM.Error;
                    break;
            }

            return command;
        }

        /*
         *  Gets Withdrawal or Inventory argument(s) depending on Command.
         */
        /// <summary>
        /// Gets Withdrawal or Inventory argument(s) depending on Command.
        /// </summary>
        /// <param name="inputMessage"></param>
        /// <param name="inputStrings"></param>
        /// <returns></returns>
        private AtmInputMessage GetArguments(
            AtmInputMessage inputMessage,
             List<string> inputStrings)
        {
            // Return if Error command or no args.
            if (inputMessage.Command == (int)CommandConstants.COMMAND_ENUM.Error
                        || inputStrings.Count <= 1)
            {
                return inputMessage;
            }

            // Get Withdrawal Amount.
            if (inputMessage.Command == (int)CommandConstants.COMMAND_ENUM.Withdraw)
            {
                var isValid = int.TryParse(
                    inputStrings[InputConstants.AMOUNT],
                    NumberStyles.Currency,
                    CultureInfo.CurrentCulture,
                    out int amount);

                if (isValid)
                {
                    inputMessage.WithdrawalAmount = amount;
                }

                return inputMessage;
            }

            // Get Inventory arguments.
            foreach (var amount in inputStrings.Skip(1))
            {
                var isValid = int.TryParse(
                    amount,
                    NumberStyles.Currency,
                    CultureInfo.CurrentCulture,
                    out int validAmount);

                if (isValid)
                {
                    inputMessage.CountRequests.Add(validAmount);
                }
            }

            // Remove Inventory request duplicates.
            inputMessage.CountRequests =
                inputMessage.CountRequests.Distinct().ToList();

            return inputMessage;
        }

        #endregion
    }
}