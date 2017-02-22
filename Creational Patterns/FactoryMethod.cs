// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FactoryMethod.cs" company="">
//   
// </copyright>
// <summary>
//   The creator.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Test
{
    /// <summary>
    ///     The creator.
    /// </summary>
    public abstract class Creator
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The factory.
        /// </summary>
        /// <returns>
        ///     The <see cref="AbstractProduct" />.
        /// </returns>
        public abstract AbstractProduct Factory();

        #endregion
    }

    /// <summary>
    ///     The concrete creator 1.
    /// </summary>
    public class ConcreteCreator1 : Creator
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The factory.
        /// </summary>
        /// <returns>
        ///     The <see cref="AbstractProduct" />.
        /// </returns>
        public override AbstractProduct Factory()
        {
            return new ProductA();
        }

        #endregion
    }

    /// <summary>
    ///     The concrete creator 2.
    /// </summary>
    public class ConcreteCreator2 : Creator
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The factory.
        /// </summary>
        /// <returns>
        ///     The <see cref="AbstractProduct" />.
        /// </returns>
        public override AbstractProduct Factory()
        {
            return new ProductB();
        }

        #endregion
    }

    /// <summary>
    ///     The abstract product.
    /// </summary>
    public abstract class AbstractProduct
    {
    }

    /// <summary>
    ///     The product a.
    /// </summary>
    public class ProductA : AbstractProduct
    {
    }

    /// <summary>
    ///     The product b.
    /// </summary>
    public class ProductB : AbstractProduct
    {
    }
}