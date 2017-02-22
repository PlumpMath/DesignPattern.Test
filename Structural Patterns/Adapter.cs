// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Adapter.cs" company="">
//   
// </copyright>
// <summary>
//   The target.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Test
{
    using System;

    /// <summary>
    ///     The target.
    /// </summary>
    public class Target
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The request.
        /// </summary>
        public virtual void Request()
        {
            Console.WriteLine("Target Request call.");
        }

        #endregion
    }

    /// <summary>
    ///     The adapter.
    /// </summary>
    public class Adapter : Target
    {
        #region Fields

        /// <summary>
        ///     The adaptee.
        /// </summary>
        private readonly Adaptee adaptee = new Adaptee();

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The request.
        /// </summary>
        public override void Request()
        {
            this.adaptee.SpecificRequest();
        }

        #endregion
    }

    /// <summary>
    ///     The adaptee.
    /// </summary>
    public class Adaptee
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The specific request.
        /// </summary>
        public void SpecificRequest()
        {
            Console.WriteLine("Real Request call.");
        }

        #endregion
    }
}