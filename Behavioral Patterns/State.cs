// --------------------------------------------------------------------------------------------------------------------
// <copyright file="State.cs" company="">
//   
// </copyright>
// <summary>
//   The state context.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Test
{
    using System;

    /// <summary>
    ///     The state context.
    /// </summary>
    public class StateContext
    {
        #region Fields

        /// <summary>
        ///     The state.
        /// </summary>
        private State state;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="StateContext"/> class.
        /// </summary>
        /// <param name="state">
        /// The state.
        /// </param>
        public StateContext(State state)
        {
            this.State = state;
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the state.
        /// </summary>
        public State State
        {
            get
            {
                return this.state;
            }

            set
            {
                this.state = value;
                Console.WriteLine("State:{0}", this.state.GetType().Name);
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The request.
        /// </summary>
        public void Request()
        {
            this.State.Handle(this);
        }

        #endregion
    }

    /// <summary>
    ///     The state.
    /// </summary>
    public abstract class State
    {
        #region Public Methods and Operators

        /// <summary>
        /// The handle.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public abstract void Handle(StateContext context);

        #endregion
    }

    /// <summary>
    ///     The concrete state 1.
    /// </summary>
    public class ConcreteState1 : State
    {
        #region Public Methods and Operators

        /// <summary>
        /// The handle.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public override void Handle(StateContext context)
        {
            context.State = new ConcreteState2();
        }

        #endregion
    }

    /// <summary>
    ///     The concrete state 2.
    /// </summary>
    public class ConcreteState2 : State
    {
        #region Public Methods and Operators

        /// <summary>
        /// The handle.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public override void Handle(StateContext context)
        {
            context.State = new ConcreteState1();
        }

        #endregion
    }
}