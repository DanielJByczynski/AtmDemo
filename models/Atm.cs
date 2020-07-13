using System.Collections.Generic;
using System.Linq;

namespace AtmDemo
{
    /*
     * The Atm class models an Atm machine.
     */
    /// <summary>
    /// The <c>Atm</c> class models an Atm machine.
    /// </summary>
    public class Atm
    {
        #region Constructor

        /*
         *  Initialize new instance of an Atm object.
         */
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Atm()"/> class.
        /// </summary>
        public Atm()
        {
            //  Initializes new Vault dictionary.
            //  Key = Denomination, value = Inventory.
            Vault = new Dictionary<int, int>
            {
                { 100, 10 },
                { 50, 10 },
                { 20, 10 },
                { 10, 10 },
                { 5, 10 },
                { 1, 10 }
            };
        }

        #endregion

        #region Public Properties

        /*
         *      The Vault property controls the Atm object's
         *  [denomination, inventory] Dictionary.
         */
        /// <summary>
        ///     The <c>Vault</c> property controls the Atm object's
        ///     [denomination, inventory] Dictionary.
        ///     <example>
        ///     Example:
        ///     <code>
        ///         atm.Vault = new Dictionary int, int { ... };
        ///     </code>
        ///     instantiates the Vault.
        /// </example>
        /// </summary>
        /// <seealso cref="Denominations"/>
        /// <seealso cref="Inventory"/>
        /// <seealso cref="GetValue(int)"/>
        /// <seealso cref="SetValue(int, int)"/>
        /// <seealso cref="DenominationCount"/>
        public Dictionary<int, int> Vault { get; set; }

        //  The Denominations method returns the list of denominations in the Vault.
        /// <summary>
        ///    The <c>Denominations</c> method returns the list of denominations
        ///    in the Vault.
        /// <example>
        /// Example:
        /// <code>
        ///     var denominations = atm.Denominations();
        /// </code>
        /// </example>
        /// </summary>
        /// <seealso cref="Vault"/>
        /// <seealso cref="Inventory"/>
        /// <seealso cref="GetValue(int)"/>
        /// <seealso cref="SetValue(int, int)"/>
        /// <seealso cref="DenominationCount"/>
        public List<int> Denominations {
            get 
            {
                return Vault.Keys.ToList();
            }
        }

        //  The Inventory method returns the list of inventory values in the Vault.
        /// <summary>
        ///    The <c>Inventory</c> method returns the list of inventory values
        ///    in the Vault.
        /// <example>
        /// Example:
        /// <code>
        ///     var inventoryValues = atm.inventory();
        /// </code>
        /// </example>
        /// </summary>
        /// <seealso cref="Vault"/>
        /// <seealso cref="Denominations"/>
        /// <seealso cref="GetValue(int)"/>
        /// <seealso cref="SetValue(int, int)"/>
        /// <seealso cref="DenominationCount"/>
        public List<int> Inventory
        {
            get
            {
                return Vault.Values.ToList();
            }
        }

        /*
         *      The GetValue method returns the inventory value
         *  of the given denomination key.
         */
        /// <summary>
        ///     The <c>GetValue</c> method returns the inventory value
        ///     of the given denomination key.
        ///     <example>
        ///         Example:
        ///         <code>
        ///             var inventoryValue = atm.GetValue(100);
        ///         </code>
        ///     </example>
        /// </summary>
        /// <seealso cref="Vault"/>
        /// <seealso cref="Denominations"/>
        /// <seealso cref="Inventory"/>
        /// <seealso cref="SetValue(int, int)"/>
        /// <seealso cref="DenominationCount"/>
        public int GetValue(int key)
        {
            return Vault[key];
        }

        /*
         *      The DenominationInventory method sets the inventory value
         *  of the given denomination key to the given value.
         */
        /// <summary>
        ///     The <c>SetValue(int key, int value)</c> method sets the
        ///     inventory value of the given denomination key to the given value.
        ///     <example>
        ///         Example:
        ///         <code>
        ///             atm.SetValue(100, 10);
        ///         </code>
        ///     </example>
        /// </summary>
        /// <seealso cref="Vault"/>
        /// <seealso cref="Denominations"/>
        /// <seealso cref="Inventory"/>
        /// <seealso cref="GetValue(int)"/>
        /// <seealso cref="DenominationCount"/>
        public void SetValue(int key, int value)
        {
            Vault[key] = value;
        }

        /*
         *      The DenominationCount returns the number of key value
         *  pairs in the Vault dictionary.
         */
        /// <summary>
        ///     The <c>SetValue(int key, int value)</c> method sets the
        ///     inventory value of the given denomination key to the given value.
        ///     <example>
        ///         Example:
        ///         <code>
        ///             var denominationCount = atm.DenominationCount;
        ///         </code>
        ///     </example>
        /// </summary>
        /// <seealso cref="Vault"/>
        /// <seealso cref="Denominations"/>
        /// <seealso cref="Inventory"/>
        /// <seealso cref="GetValue(int)"/>
        /// <seealso cref="SetValue(int, int)"/>
        public int DenominationCount
        {
            get 
            {
                return Vault.Keys.ToList().Count;
            }
        }

        #endregion
    }
}