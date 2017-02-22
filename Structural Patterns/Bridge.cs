// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Bridge.cs" company="">
//   
// </copyright>
// <summary>
//   The abstraction.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Test
{
    using System;

    /// <summary>
    ///     The abstraction.
    /// </summary>
    public abstract class Abstraction
    {
        #region Fields

        /// <summary>
        ///     The implementor.
        /// </summary>
        protected Implementor implementor;

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The operation.
        /// </summary>
        public abstract void Operation();

        /// <summary>
        /// The set implementor.
        /// </summary>
        /// <param name="implementor">
        /// The implementor.
        /// </param>
        public void SetImplementor(Implementor implementor)
        {
            this.implementor = implementor;
        }

        #endregion
    }

    /// <summary>
    ///     The refined abstraction.
    /// </summary>
    public class RefinedAbstraction : Abstraction
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The operation.
        /// </summary>
        public override void Operation()
        {
            if (this.implementor != null)
            {
                this.implementor.OperationImp();
            }
        }

        #endregion
    }

    /// <summary>
    ///     The implementor.
    /// </summary>
    public abstract class Implementor
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The operation imp.
        /// </summary>
        public abstract void OperationImp();

        #endregion
    }

    /// <summary>
    ///     The concrete implementor a.
    /// </summary>
    public class ConcreteImplementorA : Implementor
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The operation imp.
        /// </summary>
        public override void OperationImp()
        {
            Console.WriteLine("ConcreteImplementorA.OperationImp");
        }

        #endregion
    }

    /// <summary>
    ///     The concrete implementor b.
    /// </summary>
    public class ConcreteImplementorB : Implementor
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The operation imp.
        /// </summary>
        public override void OperationImp()
        {
            Console.WriteLine("ConcreteImplementorB.OperationImp");
        }

        #endregion
    }
}