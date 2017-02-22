// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Visitor.cs" company="">
//   
// </copyright>
// <summary>
//   The visitor.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPattern.Test
{
    using System;
    using System.Collections;

    /// <summary>
    /// The visitor.
    /// </summary>
    public abstract class Visitor
    {
        #region Public Methods and Operators

        /// <summary>
        /// The visit concrete element a.
        /// </summary>
        /// <param name="concreteElementA">
        /// The concrete element a.
        /// </param>
        public abstract void VisitConcreteElementA(ConcreteElementA concreteElementA);

        /// <summary>
        /// The visit concrete element b.
        /// </summary>
        /// <param name="concreteElementB">
        /// The concrete element b.
        /// </param>
        public abstract void VisitConcreteElementB(ConcreteElementB concreteElementB);

        #endregion
    }

    /// <summary>
    /// The concrete visitor a.
    /// </summary>
    public class ConcreteVisitorA : Visitor
    {
        #region Public Methods and Operators

        /// <summary>
        /// The visit concrete element a.
        /// </summary>
        /// <param name="concreteElementA">
        /// The concrete element a.
        /// </param>
        public override void VisitConcreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine("Element:{0} visited by {1}", concreteElementA.GetType().Name, this.GetType().Name);
        }

        /// <summary>
        /// The visit concrete element b.
        /// </summary>
        /// <param name="concreteElementB">
        /// The concrete element b.
        /// </param>
        public override void VisitConcreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine("Element:{0} visited by {1}", concreteElementB.GetType().Name, this.GetType().Name);
        }

        #endregion
    }

    /// <summary>
    /// The concrete visitor b.
    /// </summary>
    public class ConcreteVisitorB : Visitor
    {
        #region Public Methods and Operators

        /// <summary>
        /// The visit concrete element a.
        /// </summary>
        /// <param name="concreteElementA">
        /// The concrete element a.
        /// </param>
        public override void VisitConcreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine("Element:{0} visited by {1}", concreteElementA.GetType().Name, this.GetType().Name);
        }

        /// <summary>
        /// The visit concrete element b.
        /// </summary>
        /// <param name="concreteElementB">
        /// The concrete element b.
        /// </param>
        public override void VisitConcreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine("Element:{0} visited by {1}", concreteElementB.GetType().Name, this.GetType().Name);
        }

        #endregion
    }

    /// <summary>
    /// The element.
    /// </summary>
    public abstract class Element
    {
        #region Public Methods and Operators

        /// <summary>
        /// The accept.
        /// </summary>
        /// <param name="visitor">
        /// The visitor.
        /// </param>
        public abstract void Accept(Visitor visitor);

        #endregion
    }

    /// <summary>
    /// The concrete element a.
    /// </summary>
    public class ConcreteElementA : Element
    {
        #region Public Methods and Operators

        /// <summary>
        /// The accept.
        /// </summary>
        /// <param name="visitor">
        /// The visitor.
        /// </param>
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }

        #endregion
    }

    /// <summary>
    /// The concrete element b.
    /// </summary>
    public class ConcreteElementB : Element
    {
        #region Public Methods and Operators

        /// <summary>
        /// The accept.
        /// </summary>
        /// <param name="visitor">
        /// The visitor.
        /// </param>
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementB(this);
        }

        #endregion
    }

    /// <summary>
    /// The object structure.
    /// </summary>
    public class ObjectStructure
    {
        #region Fields

        /// <summary>
        /// The objects.
        /// </summary>
        private readonly ArrayList objects = new ArrayList();

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The accept.
        /// </summary>
        /// <param name="visitor">
        /// The visitor.
        /// </param>
        public void Accept(Visitor visitor)
        {
            foreach (Element o in this.objects)
            {
                o.Accept(visitor);
            }
        }

        /// <summary>
        /// The attach.
        /// </summary>
        /// <param name="element">
        /// The element.
        /// </param>
        public void Attach(Element element)
        {
            this.objects.Add(element);
        }

        /// <summary>
        /// The detach.
        /// </summary>
        /// <param name="element">
        /// The element.
        /// </param>
        public void Detach(Element element)
        {
            this.objects.Remove(element);
        }

        #endregion
    }
}