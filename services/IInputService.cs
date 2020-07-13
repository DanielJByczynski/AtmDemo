namespace AtmDemo.services
{
    public interface IInputService
    {
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
        AtmInputMessage GetInputMessage();
    }
}
