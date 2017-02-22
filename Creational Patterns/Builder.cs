// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Builder.cs" company="">
//   
// </copyright>
// <summary>
//   The director.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Test
{
    using System;
    using System.Collections;

    /// <summary>
    ///     The director.
    /// </summary>
    public class Director
    {
        #region Public Methods and Operators

        /// <summary>
        /// The construct.
        /// </summary>
        /// <param name="builder">
        /// The builder.
        /// </param>
        public void Construct(Builder builder)
        {
            builder.BuildPart1();
            builder.BuildPart2();
        }

        #endregion
    }

    /// <summary>
    ///     The builder.
    /// </summary>
    public abstract class Builder
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The build part 1.
        /// </summary>
        public abstract void BuildPart1();

        /// <summary>
        ///     The build part 2.
        /// </summary>
        public abstract void BuildPart2();

        /// <summary>
        ///     The get product.
        /// </summary>
        /// <returns>
        ///     The <see cref="Product" />.
        /// </returns>
        public abstract Product GetProduct();

        #endregion
    }

    /// <summary>
    ///     The concrete builder 1.
    /// </summary>
    public class ConcreteBuilder1 : Builder
    {
        #region Fields

        /// <summary>
        ///     The product.
        /// </summary>
        private readonly Product product = new Product();

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The build part 1.
        /// </summary>
        public override void BuildPart1()
        {
            this.product.Add("ConcreteBuilder1.BuildPart1");
        }

        /// <summary>
        ///     The build part 2.
        /// </summary>
        public override void BuildPart2()
        {
            this.product.Add("ConcreteBuilder1.BuildPart2");
        }

        /// <summary>
        ///     The get product.
        /// </summary>
        /// <returns>
        ///     The <see cref="Product" />.
        /// </returns>
        public override Product GetProduct()
        {
            return this.product;
        }

        #endregion
    }

    /// <summary>
    ///     The concrete builder 2.
    /// </summary>
    public class ConcreteBuilder2 : Builder
    {
        #region Fields

        /// <summary>
        ///     The product.
        /// </summary>
        private readonly Product product = new Product();

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The build part 1.
        /// </summary>
        public override void BuildPart1()
        {
            this.product.Add("ConcreteBuilder2.BuildPart1");
        }

        /// <summary>
        ///     The build part 2.
        /// </summary>
        public override void BuildPart2()
        {
            this.product.Add("ConcreteBuilder2.BuildPart2");
        }

        /// <summary>
        ///     The get product.
        /// </summary>
        /// <returns>
        ///     The <see cref="Product" />.
        /// </returns>
        public override Product GetProduct()
        {
            return this.product;
        }

        #endregion
    }

    /// <summary>
    ///     The product.
    /// </summary>
    public class Product
    {
        #region Fields

        /// <summary>
        ///     The parts.
        /// </summary>
        private readonly ArrayList parts = new ArrayList();

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The add.
        /// </summary>
        /// <param name="part">
        /// The part.
        /// </param>
        public void Add(string part)
        {
            this.parts.Add(part);
        }

        /// <summary>
        ///     The show.
        /// </summary>
        public void Show()
        {
            Console.WriteLine("Parts: ");
            foreach (object part in this.parts)
            {
                Console.WriteLine(part);
            }
        }

        #endregion
    }
}