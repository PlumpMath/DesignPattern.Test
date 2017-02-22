// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Prototype.cs" company="">
//   
// </copyright>
// <summary>
//   The prototype.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Test
{
    /// <summary>
    ///     The prototype.
    /// </summary>
    public abstract class Prototype
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Prototype"/> class.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        protected Prototype(string id)
        {
            this.Id = id;
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets the id.
        /// </summary>
        public string Id { get; private set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The clone.
        /// </summary>
        /// <returns>
        ///     The <see cref="Prototype" />.
        /// </returns>
        public abstract Prototype Clone();

        #endregion
    }

    /// <summary>
    ///     The concrete prototype 1.
    /// </summary>
    public class ConcretePrototype1 : Prototype
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcretePrototype1"/> class.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        public ConcretePrototype1(string id)
            : base(id)
        {
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The clone.
        /// </summary>
        /// <returns>
        ///     The <see cref="Prototype" />.
        /// </returns>
        public override Prototype Clone()
        {
            return this.MemberwiseClone() as ConcretePrototype1;
        }

        #endregion
    }

    /// <summary>
    ///     The concrete prototype 2.
    /// </summary>
    public class ConcretePrototype2 : Prototype
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcretePrototype2"/> class.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        public ConcretePrototype2(string id)
            : base(id)
        {
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The clone.
        /// </summary>
        /// <returns>
        ///     The <see cref="Prototype" />.
        /// </returns>
        public override Prototype Clone()
        {
            return this.MemberwiseClone() as ConcretePrototype2;
        }

        #endregion
    }
}