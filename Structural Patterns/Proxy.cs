// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Proxy.cs" company="">
//   
// </copyright>
// <summary>
//   The subject.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Test
{
    using System;

    /// <summary>
    ///     The subject.
    /// </summary>
    public abstract class Subject
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The request.
        /// </summary>
        public abstract void Request();

        #endregion
    }

    /// <summary>
    ///     The proxy.
    /// </summary>
    public class Proxy : Subject
    {
        #region Fields

        /// <summary>
        ///     The real subject.
        /// </summary>
        private RealSubject realSubject;

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The request.
        /// </summary>
        public override void Request()
        {
            if (this.realSubject == null)
            {
                this.realSubject = new RealSubject();
            }

            this.realSubject.Request();
        }

        #endregion
    }

    /// <summary>
    ///     The real subject.
    /// </summary>
    public class RealSubject : Subject
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The request.
        /// </summary>
        public override void Request()
        {
            Console.WriteLine("RealSubject.Request");
        }

        #endregion
    }
}