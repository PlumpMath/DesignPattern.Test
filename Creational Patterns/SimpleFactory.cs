// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SimpleFactory.cs" company="">
//   
// </copyright>
// <summary>
//   The simple factory.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Test
{
    /// <summary>
    ///     The simple factory.
    /// </summary>
    public class SimpleFactory
    {
        #region Public Methods and Operators

        /// <summary>
        /// The create.
        /// </summary>
        /// <param name="operator">
        /// The operator.
        /// </param>
        /// <returns>
        /// The <see cref="Operation"/>.
        /// </returns>
        public static Operation Create(string @operator)
        {
            switch (@operator)
            {
                case "+":
                    return new Add();
                case "-":
                    return new Sub();
                default:
                    break;
            }

            return null;
        }

        #endregion
    }

    /// <summary>
    ///     The operation.
    /// </summary>
    public abstract class Operation
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the a.
        /// </summary>
        public int A { get; set; }

        /// <summary>
        ///     Gets or sets the b.
        /// </summary>
        public int B { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The operate.
        /// </summary>
        /// <returns>
        ///     The <see cref="int" />.
        /// </returns>
        public abstract int Operate();

        #endregion
    }

    /// <summary>
    ///     The add.
    /// </summary>
    public class Add : Operation
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The operate.
        /// </summary>
        /// <returns>
        ///     The <see cref="int" />.
        /// </returns>
        public override int Operate()
        {
            return this.A + this.B;
        }

        #endregion
    }

    /// <summary>
    ///     The sub.
    /// </summary>
    public class Sub : Operation
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The operate.
        /// </summary>
        /// <returns>
        ///     The <see cref="int" />.
        /// </returns>
        public override int Operate()
        {
            return this.A - this.B;
        }

        #endregion
    }
}