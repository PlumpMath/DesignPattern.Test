// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Facade.cs" company="">
//   
// </copyright>
// <summary>
//   The facade.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Test
{
    using System;

    /// <summary>
    ///     The facade.
    /// </summary>
    public class Facade
    {
        #region Fields

        /// <summary>
        ///     The system 1.
        /// </summary>
        private readonly SubSystem1 system1 = new SubSystem1();

        /// <summary>
        ///     The system 2.
        /// </summary>
        private readonly SubSystem2 system2 = new SubSystem2();

        /// <summary>
        ///     The system 3.
        /// </summary>
        private readonly SubSystem3 system3 = new SubSystem3();

        /// <summary>
        ///     The system 4.
        /// </summary>
        private readonly SubSystem4 system4 = new SubSystem4();

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The method one.
        /// </summary>
        public void MethodOne()
        {
            this.system1.MethodOne();
            this.system2.MethodOne();
            this.system4.MethodOne();
        }

        /// <summary>
        ///     The method two.
        /// </summary>
        public void MethodTwo()
        {
            this.system1.MethodTwo();
            this.system3.MethodTwo();
        }

        #endregion
    }

    /// <summary>
    ///     The sub system 1.
    /// </summary>
    internal class SubSystem1
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The method one.
        /// </summary>
        public void MethodOne()
        {
            Console.WriteLine("SubSystem1.MethodOne");
        }

        /// <summary>
        ///     The method two.
        /// </summary>
        public void MethodTwo()
        {
            Console.WriteLine("SubSystem1.MethodTwo");
        }

        #endregion
    }

    /// <summary>
    ///     The sub system 2.
    /// </summary>
    internal class SubSystem2
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The method one.
        /// </summary>
        public void MethodOne()
        {
            Console.WriteLine("SubSystem2.MethodOne");
        }

        /// <summary>
        ///     The method two.
        /// </summary>
        public void MethodTwo()
        {
            Console.WriteLine("SubSystem2.MethodTwo");
        }

        #endregion
    }

    /// <summary>
    ///     The sub system 3.
    /// </summary>
    internal class SubSystem3
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The method one.
        /// </summary>
        public void MethodOne()
        {
            Console.WriteLine("SubSystem3.MethodOne");
        }

        /// <summary>
        ///     The method two.
        /// </summary>
        public void MethodTwo()
        {
            Console.WriteLine("SubSystem3.MethodTwo");
        }

        #endregion
    }

    /// <summary>
    ///     The sub system 4.
    /// </summary>
    internal class SubSystem4
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The method one.
        /// </summary>
        public void MethodOne()
        {
            Console.WriteLine("SubSystem4.MethodOne");
        }

        /// <summary>
        ///     The method two.
        /// </summary>
        public void MethodTwo()
        {
            Console.WriteLine("SubSystem4.MethodTwo");
        }

        #endregion
    }
}