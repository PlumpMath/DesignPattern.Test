// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Interpreter.cs" company="">
//   
// </copyright>
// <summary>
//   The context.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Test
{
    using System;

    /// <summary>
    ///     The context.
    /// </summary>
    public class Context
    {
    }

    /// <summary>
    ///     The expression.
    /// </summary>
    public abstract class Expression
    {
        #region Public Methods and Operators

        /// <summary>
        /// The interpret.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public abstract void Interpret(Context context);

        #endregion
    }

    /// <summary>
    ///     The concrete expression 1.
    /// </summary>
    public class ConcreteExpression1 : Expression
    {
        #region Public Methods and Operators

        /// <summary>
        /// The interpret.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public override void Interpret(Context context)
        {
            Console.WriteLine("ConcreteExpression1.Interprete");
        }

        #endregion
    }

    /// <summary>
    ///     The concrete expression 2.
    /// </summary>
    public class ConcreteExpression2 : Expression
    {
        #region Public Methods and Operators

        /// <summary>
        /// The interpret.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public override void Interpret(Context context)
        {
            Console.WriteLine("ConcreteExpression2.Interprete");
        }

        #endregion
    }
}