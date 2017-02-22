// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Strategy.cs" company="">
//   
// </copyright>
// <summary>
//   The strategy context.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Test
{
    using System;

    /// <summary>
    ///     The strategy context.
    /// </summary>
    public class StrategyContext
    {
        #region Fields

        /// <summary>
        ///     The strategy.
        /// </summary>
        private readonly Strategy strategy;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="StrategyContext"/> class.
        /// </summary>
        /// <param name="strategy">
        /// The strategy.
        /// </param>
        public StrategyContext(Strategy strategy)
        {
            this.strategy = strategy;
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The context interface.
        /// </summary>
        public void ContextInterface()
        {
            this.strategy.AlgorithmInterface();
        }

        #endregion
    }

    /// <summary>
    ///     The strategy.
    /// </summary>
    public abstract class Strategy
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The algorithm interface.
        /// </summary>
        public abstract void AlgorithmInterface();

        #endregion
    }

    /// <summary>
    ///     The concrete strategy 1.
    /// </summary>
    public class ConcreteStrategy1 : Strategy
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The algorithm interface.
        /// </summary>
        public override void AlgorithmInterface()
        {
            Console.WriteLine("ConcreteStrategy1.AlgorithmInterface");
        }

        #endregion
    }

    /// <summary>
    ///     The concrete strategy 2.
    /// </summary>
    public class ConcreteStrategy2 : Strategy
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The algorithm interface.
        /// </summary>
        public override void AlgorithmInterface()
        {
            Console.WriteLine("ConcreteStrategy2.AlgorithmInterface");
        }

        #endregion
    }

    /// <summary>
    ///     The concrete strategy 3.
    /// </summary>
    public class ConcreteStrategy3 : Strategy
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The algorithm interface.
        /// </summary>
        public override void AlgorithmInterface()
        {
            Console.WriteLine("ConcreteStrategy3.AlgorithmInterface");
        }

        #endregion
    }
}