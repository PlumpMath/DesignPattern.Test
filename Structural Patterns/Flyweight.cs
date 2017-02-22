// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Flyweight.cs" company="">
//   
// </copyright>
// <summary>
//   The flyweight factory.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Test
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    ///     The flyweight factory.
    /// </summary>
    public class FlyweightFactory
    {
        #region Fields

        /// <summary>
        ///     The dic.
        /// </summary>
        private readonly Dictionary<string, Flyweight> dic = new Dictionary<string, Flyweight>();

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="FlyweightFactory" /> class.
        /// </summary>
        public FlyweightFactory()
        {
            this.dic.Add("X", new ConcreteFlyweight());
            this.dic.Add("Y", new ConcreteFlyweight());
            this.dic.Add("Z", new ConcreteFlyweight());
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The get flyweight.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <returns>
        /// The <see cref="Flyweight"/>.
        /// </returns>
        public Flyweight GetFlyweight(string name)
        {
            if (this.dic.ContainsKey(name))
            {
                return this.dic[name];
            }

            return null;
        }

        #endregion
    }

    /// <summary>
    ///     The flyweight.
    /// </summary>
    public abstract class Flyweight
    {
        #region Public Methods and Operators

        /// <summary>
        /// The operation.
        /// </summary>
        /// <param name="extrinsicstate">
        /// The extrinsicstate.
        /// </param>
        public abstract void Operation(int extrinsicstate);

        #endregion
    }

    /// <summary>
    ///     The concrete flyweight.
    /// </summary>
    public class ConcreteFlyweight : Flyweight
    {
        #region Public Methods and Operators

        /// <summary>
        /// The operation.
        /// </summary>
        /// <param name="extrinsicstate">
        /// The extrinsicstate.
        /// </param>
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("ConcreteFlyweight Operation " + extrinsicstate);
        }

        #endregion
    }

    /// <summary>
    ///     The non concrete flyweight.
    /// </summary>
    public class NonConcreteFlyweight : Flyweight
    {
        #region Public Methods and Operators

        /// <summary>
        /// The operation.
        /// </summary>
        /// <param name="extrinsicstate">
        /// The extrinsicstate.
        /// </param>
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("NonConcreteFlyweight Operation " + extrinsicstate);
        }

        #endregion
    }
}