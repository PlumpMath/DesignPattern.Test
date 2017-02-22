// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TemplateMethod.cs" company="">
//   
// </copyright>
// <summary>
//   The abstract class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPattern.Test
{
    using System;

    /// <summary>
    /// The abstract class.
    /// </summary>
    public abstract class AbstractClass
    {
        #region Public Methods and Operators

        /// <summary>
        /// The primitive operation 1.
        /// </summary>
        public abstract void PrimitiveOperation1();

        /// <summary>
        /// The primitive operation 2.
        /// </summary>
        public abstract void PrimitiveOperation2();

        /// <summary>
        /// The template method.
        /// </summary>
        public void TemplateMethod()
        {
            this.PrimitiveOperation1();
            this.PrimitiveOperation2();
        }

        #endregion
    }

    /// <summary>
    /// The concrete class a.
    /// </summary>
    public class ConcreteClassA : AbstractClass
    {
        #region Public Methods and Operators

        /// <summary>
        /// The primitive operation 1.
        /// </summary>
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("ConcreteClassA.PrimitiveOperation1");
        }

        /// <summary>
        /// The primitive operation 2.
        /// </summary>
        public override void PrimitiveOperation2()
        {
            Console.WriteLine("ConcreteClassA.PrimitiveOperation2");
        }

        #endregion
    }

    /// <summary>
    /// The concrete class b.
    /// </summary>
    public class ConcreteClassB : AbstractClass
    {
        #region Public Methods and Operators

        /// <summary>
        /// The primitive operation 1.
        /// </summary>
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("ConcreteClassB.PrimitiveOperation1");
        }

        /// <summary>
        /// The primitive operation 2.
        /// </summary>
        public override void PrimitiveOperation2()
        {
            Console.WriteLine("ConcreteClassB.PrimitiveOperation2");
        }

        #endregion
    }
}