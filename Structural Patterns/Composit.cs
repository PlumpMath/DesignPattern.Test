// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Composit.cs" company="">
//   
// </copyright>
// <summary>
//   The component.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Test
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    ///     The component.
    /// </summary>
    public abstract class Component
    {
        #region Fields

        /// <summary>
        ///     The name.
        /// </summary>
        protected string name;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Component"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        protected Component(string name)
        {
            this.name = name;
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The add.
        /// </summary>
        /// <param name="component">
        /// The component.
        /// </param>
        public abstract void Add(Component component);

        /// <summary>
        /// The display.
        /// </summary>
        /// <param name="index">
        /// The index.
        /// </param>
        public abstract void Display(int index);

        /// <summary>
        /// The remove.
        /// </summary>
        /// <param name="component">
        /// The component.
        /// </param>
        public abstract void Remove(Component component);

        #endregion
    }

    /// <summary>
    ///     The composit.
    /// </summary>
    public class Composit : Component
    {
        #region Fields

        /// <summary>
        ///     The children.
        /// </summary>
        private readonly List<Component> children = new List<Component>();

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Composit"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        public Composit(string name)
            : base(name)
        {
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The add.
        /// </summary>
        /// <param name="component">
        /// The component.
        /// </param>
        public override void Add(Component component)
        {
            this.children.Add(component);
        }

        /// <summary>
        /// The display.
        /// </summary>
        /// <param name="index">
        /// The index.
        /// </param>
        public override void Display(int index)
        {
            Console.WriteLine(new string('-', index) + this.name);
            foreach (Component child in this.children)
            {
                child.Display(index + 2);
            }
        }

        /// <summary>
        /// The remove.
        /// </summary>
        /// <param name="component">
        /// The component.
        /// </param>
        public override void Remove(Component component)
        {
            this.children.Remove(component);
        }

        #endregion
    }

    /// <summary>
    ///     The leaf.
    /// </summary>
    public class Leaf : Component
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Leaf"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        public Leaf(string name)
            : base(name)
        {
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The add.
        /// </summary>
        /// <param name="component">
        /// The component.
        /// </param>
        public override void Add(Component component)
        {
            Console.WriteLine("not able Leaf add");
        }

        /// <summary>
        /// The display.
        /// </summary>
        /// <param name="index">
        /// The index.
        /// </param>
        public override void Display(int index)
        {
            Console.WriteLine(new string('-', index) + this.name);
        }

        /// <summary>
        /// The remove.
        /// </summary>
        /// <param name="component">
        /// The component.
        /// </param>
        public override void Remove(Component component)
        {
            Console.WriteLine("not able Leaf Remove");
        }

        #endregion
    }
}