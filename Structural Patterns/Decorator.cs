// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Decorator.cs" company="">
//   
// </copyright>
// <summary>
//   The base component.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Test
{
    using System;

    /// <summary>
    ///     The base component.
    /// </summary>
    public abstract class BaseComponent
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The operation.
        /// </summary>
        public abstract void Operation();

        #endregion
    }

    /// <summary>
    ///     The concrete component.
    /// </summary>
    public class ConcreteComponent : BaseComponent
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The operation.
        /// </summary>
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation");
        }

        #endregion
    }

    /// <summary>
    ///     The decorator.
    /// </summary>
    public abstract class Decorator : BaseComponent
    {
        #region Fields

        /// <summary>
        ///     The component.
        /// </summary>
        protected BaseComponent component;

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The operation.
        /// </summary>
        public override void Operation()
        {
            if (this.component != null)
            {
                this.component.Operation();
            }
        }

        /// <summary>
        /// The set component.
        /// </summary>
        /// <param name="component">
        /// The component.
        /// </param>
        public void SetComponent(BaseComponent component)
        {
            this.component = component;
        }

        #endregion
    }

    /// <summary>
    ///     The concrete decorator a.
    /// </summary>
    public class ConcreteDecoratorA : Decorator
    {
        #region Fields

        /// <summary>
        ///     The added state.
        /// </summary>
        public string addedState;

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The operation.
        /// </summary>
        public override void Operation()
        {
            base.Operation();
            this.addedState = "new state";
            Console.WriteLine("ConcreteDecoratorA.Operation");
        }

        #endregion
    }

    /// <summary>
    ///     The concrete decorator b.
    /// </summary>
    public class ConcreteDecoratorB : Decorator
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The added behavior.
        /// </summary>
        public void AddedBehavior()
        {
        }

        /// <summary>
        ///     The operation.
        /// </summary>
        public override void Operation()
        {
            base.Operation();
            this.AddedBehavior();
            Console.WriteLine("ConcreteDecoratorB.Operation");
        }

        #endregion
    }
}