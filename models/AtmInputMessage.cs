using System.Collections.Generic;

namespace AtmDemo
{
    public class AtmInputMessage
    {
        #region Constructor


        //  Initialize new AtmInputMessage instance.
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AtmInputMessage()"/> class.
        /// </summary>
        public AtmInputMessage()
        {
            CountRequests = new List<int>();
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Command int controls program operations.
        /// </summary>
        public int Command { get; set; }

        /// <summary>
        /// WithdrawalAmount int stores the amount to be withdrawn from the atm.
        /// </summary>
        public int WithdrawalAmount { get; set; }

        /// <summary>
        /// Count Requests holds a number of inventory requests.
        /// </summary>
        public List<int> CountRequests { get; set; }

        #endregion
    }
}