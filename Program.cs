using AtmDemo.services;

namespace AtmDemo
{
    /*
     *  The main Program class.
     *  Instantiates all dependencies and runs the program.   
     */
    /// <summary>
    /// The main <c>Program</c> class.
    /// Instantiates all dependencies and runs the program.
    /// </summary>
    /// <remarks>
    /// <para>Author: Daniel J. Byczynski - 2019</para>
    /// <para>
    ///       You are to write a cash machine (ATM) application. The cash machine is pre-stocked with the
    ///     following denominations:
    ///         • $100 - 10 Bills
    ///         • $50 - 10 Bills
    ///         • $20 - 10 Bills
    ///         • $10 - 10 Bills
    ///         • $5 - 10 Bills
    ///         • $1 - 10 Bills
    /// </para>
    /// <para>
    ///       Your application should take input from the standard input stream and support the following
    ///     commands:
    ///         • R - Restocks the cash machine to the original pre-stock levels defined above
    ///         • W&lt;dollar amount&gt; - Withdraws that amount from the cash machine(e.g. &quot; W $145&quot;)
    ///         • I&lt;denominations&gt; - Displays the number of bills in that denomination present in the cash machine(e.g.I $20 $10 $1)
    ///         • Q - Quits the application
    /// </para>
    /// <para>
    ///       The withdrawals from the cash machine should dispense cash in the most efficient manner
    ///     possible, with the least amount of bills.After a withdrawal, the program should display success
    ///     or failure and the remaining balance in the cash machine (sample output below). For an
    ///     inquiry, the program should display the number of bills in the denominations specified(sample
    ///     output below). After a restock, the program should display the balance in the cash machine
    ///     (same as after a withdrawal). If the input is not understood, &quot;Invalid Command&quot; should be
    ///     displayed.No additional messages, prompts or errors should be displayed.
    /// </para>
    /// </remarks>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Instantiate Dependencies.
            IDisplayService displayService = new ConsoleDisplayService();
            IInputService inputService = new ConsoleInputService();
            var atmController = new AtmController(displayService, inputService);

            // Start Atm.
            atmController.StartAtm();
        }
    }
}