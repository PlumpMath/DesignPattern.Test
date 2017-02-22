// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Memento.cs" company="">
//   
// </copyright>
// <summary>
//   The originator.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Test
{
    using System;

    /// <summary>
    ///     The originator.
    /// </summary>
    public class Originator
    {
        #region Fields

        /// <summary>
        ///     The state.
        /// </summary>
        private string state;

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the state.
        /// </summary>
        public string State
        {
            get
            {
                return this.state;
            }

            set
            {
                this.state = value;
                Console.WriteLine("State: " + this.state);
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The create memento.
        /// </summary>
        /// <returns>
        ///     The <see cref="Memento" />.
        /// </returns>
        public Memento CreateMemento()
        {
            var memento = new Memento();
            memento.State = this.State;
            return memento;
        }

        /// <summary>
        /// The set memento.
        /// </summary>
        /// <param name="memento">
        /// The memento.
        /// </param>
        public void SetMemento(Memento memento)
        {
            Console.WriteLine("Restore state");
            this.State = memento.State;
        }

        #endregion
    }

    /// <summary>
    ///     The memento.
    /// </summary>
    public class Memento
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the state.
        /// </summary>
        public string State { get; set; }

        #endregion
    }

    /// <summary>
    ///     The caretaker.
    /// </summary>
    public class Caretaker
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the memento.
        /// </summary>
        public Memento Memento { get; set; }

        #endregion
    }
}