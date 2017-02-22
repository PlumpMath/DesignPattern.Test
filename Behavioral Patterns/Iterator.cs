// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Iterator.cs" company="">
//   
// </copyright>
// <summary>
//   The aggregate.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Test
{
    using System.Collections;

    /// <summary>
    ///     The aggregate.
    /// </summary>
    public abstract class Aggregate
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The create iterator.
        /// </summary>
        /// <returns>
        ///     The <see cref="Iterator" />.
        /// </returns>
        public abstract Iterator CreateIterator();

        #endregion
    }

    /// <summary>
    ///     The concrete aggregate.
    /// </summary>
    public class ConcreteAggregate : Aggregate
    {
        #region Fields

        /// <summary>
        ///     The items.
        /// </summary>
        private readonly ArrayList items = new ArrayList();

        #endregion

        #region Public Indexers

        /// <summary>
        /// The this.
        /// </summary>
        /// <param name="index">
        /// The index.
        /// </param>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        public object this[int index]
        {
            get
            {
                return this.items[index];
            }

            set
            {
                this.items.Add(value);
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The count.
        /// </summary>
        /// <returns>
        ///     The <see cref="int" />.
        /// </returns>
        public int Count()
        {
            return this.items.Count;
        }

        /// <summary>
        ///     The create iterator.
        /// </summary>
        /// <returns>
        ///     The <see cref="Iterator" />.
        /// </returns>
        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        #endregion
    }

    /// <summary>
    ///     The iterator.
    /// </summary>
    public abstract class Iterator
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The current item.
        /// </summary>
        /// <returns>
        ///     The <see cref="object" />.
        /// </returns>
        public abstract object CurrentItem();

        /// <summary>
        ///     The first.
        /// </summary>
        /// <returns>
        ///     The <see cref="object" />.
        /// </returns>
        public abstract object First();

        /// <summary>
        ///     The is done.
        /// </summary>
        /// <returns>
        ///     The <see cref="bool" />.
        /// </returns>
        public abstract bool IsDone();

        /// <summary>
        ///     The next.
        /// </summary>
        /// <returns>
        ///     The <see cref="object" />.
        /// </returns>
        public abstract object Next();

        #endregion
    }

    /// <summary>
    ///     The concrete iterator.
    /// </summary>
    public class ConcreteIterator : Iterator
    {
        #region Fields

        /// <summary>
        ///     The concrete aggregate.
        /// </summary>
        private readonly ConcreteAggregate concreteAggregate;

        /// <summary>
        ///     The current index.
        /// </summary>
        private int currentIndex;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteIterator"/> class.
        /// </summary>
        /// <param name="aggregate">
        /// The aggregate.
        /// </param>
        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.concreteAggregate = aggregate;
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The current item.
        /// </summary>
        /// <returns>
        ///     The <see cref="object" />.
        /// </returns>
        public override object CurrentItem()
        {
            return this.concreteAggregate[this.currentIndex];
        }

        /// <summary>
        ///     The first.
        /// </summary>
        /// <returns>
        ///     The <see cref="object" />.
        /// </returns>
        public override object First()
        {
            return this.concreteAggregate[0];
        }

        /// <summary>
        ///     The is done.
        /// </summary>
        /// <returns>
        ///     The <see cref="bool" />.
        /// </returns>
        public override bool IsDone()
        {
            return this.currentIndex == this.concreteAggregate.Count() - 1;
        }

        /// <summary>
        ///     The next.
        /// </summary>
        /// <returns>
        ///     The <see cref="object" />.
        /// </returns>
        public override object Next()
        {
            if (this.currentIndex < this.concreteAggregate.Count() - 1)
            {
                return this.concreteAggregate[++this.currentIndex];
            }

            return null;
        }

        #endregion
    }
}