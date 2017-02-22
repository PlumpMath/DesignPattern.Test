// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AbstractFactory.cs" company="">
//   
// </copyright>
// <summary>
//   The client.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Test
{
    using System;

    /// <summary>
    ///     The client.
    /// </summary>
    public class Client
    {
        #region Fields

        /// <summary>
        ///     The product a.
        /// </summary>
        public AbstractProductA ProductA;

        /// <summary>
        ///     The product b.
        /// </summary>
        public AbstractProductB ProductB;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        /// <param name="factory">
        /// The factory.
        /// </param>
        public Client(AbstractFactory factory)
        {
            this.ProductA = factory.CreateProductA();
            this.ProductB = factory.CreateProductB();
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The run.
        /// </summary>
        public void Run()
        {
            this.ProductB.Interact(this.ProductA);
        }

        #endregion
    }

    /// <summary>
    ///     The abstract factory.
    /// </summary>
    public abstract class AbstractFactory
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The create product a.
        /// </summary>
        /// <returns>
        ///     The <see cref="AbstractProductA" />.
        /// </returns>
        public abstract AbstractProductA CreateProductA();

        /// <summary>
        ///     The create product b.
        /// </summary>
        /// <returns>
        ///     The <see cref="AbstractProductB" />.
        /// </returns>
        public abstract AbstractProductB CreateProductB();

        #endregion
    }

    /// <summary>
    ///     The concrete factory a.
    /// </summary>
    public class ConcreteFactoryA : AbstractFactory
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The create product a.
        /// </summary>
        /// <returns>
        ///     The <see cref="AbstractProductA" />.
        /// </returns>
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        /// <summary>
        ///     The create product b.
        /// </summary>
        /// <returns>
        ///     The <see cref="AbstractProductB" />.
        /// </returns>
        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }

        #endregion
    }

    /// <summary>
    ///     The concrete factory b.
    /// </summary>
    public class ConcreteFactoryB : AbstractFactory
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The create product a.
        /// </summary>
        /// <returns>
        ///     The <see cref="AbstractProductA" />.
        /// </returns>
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        /// <summary>
        ///     The create product b.
        /// </summary>
        /// <returns>
        ///     The <see cref="AbstractProductB" />.
        /// </returns>
        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }

        #endregion
    }

    /// <summary>
    ///     The abstract product a.
    /// </summary>
    public abstract class AbstractProductA
    {
    }

    /// <summary>
    ///     The abstract product b.
    /// </summary>
    public abstract class AbstractProductB
    {
        #region Public Methods and Operators

        /// <summary>
        /// The interact.
        /// </summary>
        /// <param name="a">
        /// The a.
        /// </param>
        public abstract void Interact(AbstractProductA a);

        #endregion
    }

    /// <summary>
    ///     The product a 1.
    /// </summary>
    public class ProductA1 : AbstractProductA
    {
    }

    /// <summary>
    ///     The product a 2.
    /// </summary>
    public class ProductA2 : AbstractProductA
    {
    }

    /// <summary>
    ///     The product b 1.
    /// </summary>
    public class ProductB1 : AbstractProductB
    {
        #region Public Methods and Operators

        /// <summary>
        /// The interact.
        /// </summary>
        /// <param name="a">
        /// The a.
        /// </param>
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " interacts with " + a.GetType().Name);
        }

        #endregion
    }

    /// <summary>
    ///     The product b 2.
    /// </summary>
    public class ProductB2 : AbstractProductB
    {
        #region Public Methods and Operators

        /// <summary>
        /// The interact.
        /// </summary>
        /// <param name="a">
        /// The a.
        /// </param>
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " interacts with " + a.GetType().Name);
        }

        #endregion
    }
}