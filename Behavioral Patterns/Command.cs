// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Command.cs" company="">
//   
// </copyright>
// <summary>
//   The command.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Test
{
    using System;

    /// <summary>
    ///     The command.
    /// </summary>
    public abstract class Command
    {
        #region Fields

        /// <summary>
        ///     The receiver.
        /// </summary>
        protected Receiver receiver;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Command"/> class.
        /// </summary>
        /// <param name="receiver">
        /// The receiver.
        /// </param>
        protected Command(Receiver receiver)
        {
            this.receiver = receiver;
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The execute.
        /// </summary>
        public abstract void Execute();

        #endregion
    }

    /// <summary>
    ///     The concrete command.
    /// </summary>
    public class ConcreteCommand : Command
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteCommand"/> class.
        /// </summary>
        /// <param name="receiver">
        /// The receiver.
        /// </param>
        public ConcreteCommand(Receiver receiver)
            : base(receiver)
        {
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The execute.
        /// </summary>
        public override void Execute()
        {
            this.receiver.Action();
        }

        #endregion
    }

    /// <summary>
    ///     The receiver.
    /// </summary>
    public class Receiver
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The action.
        /// </summary>
        public void Action()
        {
            Console.WriteLine("Action");
        }

        #endregion
    }

    /// <summary>
    ///     The invoker.
    /// </summary>
    public class Invoker
    {
        #region Fields

        /// <summary>
        ///     The command.
        /// </summary>
        private Command command;

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The execute.
        /// </summary>
        public void Execute()
        {
            if (this.command != null)
            {
                this.command.Execute();
            }
        }

        /// <summary>
        /// The set command.
        /// </summary>
        /// <param name="command">
        /// The command.
        /// </param>
        public void SetCommand(Command command)
        {
            this.command = command;
        }

        #endregion
    }
}