// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Mediator.cs" company="">
//   
// </copyright>
// <summary>
//   The mediator.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Test
{
    using System;

    /// <summary>
    ///     The mediator.
    /// </summary>
    public abstract class Mediator
    {
        #region Public Methods and Operators

        /// <summary>
        /// The send.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        /// <param name="colleague">
        /// The colleague.
        /// </param>
        public abstract void Send(string message, Colleague colleague);

        #endregion
    }

    /// <summary>
    ///     The concrete mediator.
    /// </summary>
    public class ConcreteMediator : Mediator
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the concrete colleague 1.
        /// </summary>
        public ConcreteColleague1 ConcreteColleague1 { get; set; }

        /// <summary>
        ///     Gets or sets the concrete colleague 2.
        /// </summary>
        public ConcreteColleague2 ConcreteColleague2 { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The send.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        /// <param name="colleague">
        /// The colleague.
        /// </param>
        public override void Send(string message, Colleague colleague)
        {
            if (colleague == this.ConcreteColleague1)
            {
                this.ConcreteColleague2.Notify(message);
            }
            else if (colleague == this.ConcreteColleague2)
            {
                this.ConcreteColleague1.Notify(message);
            }
        }

        #endregion
    }

    /// <summary>
    ///     The colleague.
    /// </summary>
    public abstract class Colleague
    {
        #region Fields

        /// <summary>
        ///     The mediator.
        /// </summary>
        protected Mediator mediator;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Colleague"/> class.
        /// </summary>
        /// <param name="mediator">
        /// The mediator.
        /// </param>
        protected Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The notify.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        public abstract void Notify(string message);

        /// <summary>
        /// The send.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        public abstract void Send(string message);

        #endregion
    }

    /// <summary>
    ///     The concrete colleague 1.
    /// </summary>
    public class ConcreteColleague1 : Colleague
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteColleague1"/> class.
        /// </summary>
        /// <param name="mediator">
        /// The mediator.
        /// </param>
        public ConcreteColleague1(Mediator mediator)
            : base(mediator)
        {
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The notify.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        public override void Notify(string message)
        {
            Console.WriteLine("ConcreteColleague1 receive message:" + message);
        }

        /// <summary>
        /// The send.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        public override void Send(string message)
        {
            this.mediator.Send(message, this);
        }

        #endregion
    }

    /// <summary>
    ///     The concrete colleague 2.
    /// </summary>
    public class ConcreteColleague2 : Colleague
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteColleague2"/> class.
        /// </summary>
        /// <param name="mediator">
        /// The mediator.
        /// </param>
        public ConcreteColleague2(Mediator mediator)
            : base(mediator)
        {
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The notify.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        public override void Notify(string message)
        {
            Console.WriteLine("ConcreteColleague2 receive message:" + message);
        }

        /// <summary>
        /// The send.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        public override void Send(string message)
        {
            this.mediator.Send(message, this);
        }

        #endregion
    }
}