// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChainOfResponsibility.cs" company="">
//   
// </copyright>
// <summary>
//   The handler.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Test
{
    using System;

    /// <summary>
    ///     The handler.
    /// </summary>
    public abstract class Handler
    {
        #region Fields

        /// <summary>
        ///     The next handler.
        /// </summary>
        protected Handler nextHandler;

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The handle request.
        /// </summary>
        /// <param name="input">
        /// The input.
        /// </param>
        public abstract void HandleRequest(int input);

        /// <summary>
        /// The set handler.
        /// </summary>
        /// <param name="handler">
        /// The handler.
        /// </param>
        public void SetHandler(Handler handler)
        {
            this.nextHandler = handler;
        }

        #endregion
    }

    /// <summary>
    ///     The concrete handler 1.
    /// </summary>
    public class ConcreteHandler1 : Handler
    {
        #region Public Methods and Operators

        /// <summary>
        /// The handle request.
        /// </summary>
        /// <param name="input">
        /// The input.
        /// </param>
        public override void HandleRequest(int input)
        {
            if (input > 90)
            {
                Console.WriteLine("ConcreteHandler1.HandleRequest: " + input);
            }
            else
            {
                if (this.nextHandler != null)
                {
                    this.nextHandler.HandleRequest(input);
                }
            }
        }

        #endregion
    }

    /// <summary>
    ///     The concrete handler 2.
    /// </summary>
    public class ConcreteHandler2 : Handler
    {
        #region Public Methods and Operators

        /// <summary>
        /// The handle request.
        /// </summary>
        /// <param name="input">
        /// The input.
        /// </param>
        public override void HandleRequest(int input)
        {
            if (input >= 60 && input <= 90)
            {
                Console.WriteLine("ConcreteHandler2.HandleRequest: " + input);
            }
            else
            {
                if (this.nextHandler != null)
                {
                    this.nextHandler.HandleRequest(input);
                }
            }
        }

        #endregion
    }

    /// <summary>
    ///     The concrete handler 3.
    /// </summary>
    public class ConcreteHandler3 : Handler
    {
        #region Public Methods and Operators

        /// <summary>
        /// The handle request.
        /// </summary>
        /// <param name="input">
        /// The input.
        /// </param>
        public override void HandleRequest(int input)
        {
            if (input < 60)
            {
                Console.WriteLine("ConcreteHandler3.HandleRequest: " + input);
            }
            else
            {
                if (this.nextHandler != null)
                {
                    this.nextHandler.HandleRequest(input);
                }
            }
        }

        #endregion
    }
}