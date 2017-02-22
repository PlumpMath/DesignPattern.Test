// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Observer.cs" company="">
//   
// </copyright>
// <summary>
//   The base subject.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Test
{
    using System;
    using System.Collections;

    /// <summary>
    ///     The base subject.
    /// </summary>
    public abstract class BaseSubject
    {
        #region Fields

        /// <summary>
        ///     The observer list.
        /// </summary>
        private readonly ArrayList observerList = new ArrayList();

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The attach.
        /// </summary>
        /// <param name="observer">
        /// The observer.
        /// </param>
        public void Attach(Observer observer)
        {
            this.observerList.Add(observer);
        }

        /// <summary>
        /// The detach.
        /// </summary>
        /// <param name="observer">
        /// The observer.
        /// </param>
        public void Detach(Observer observer)
        {
            this.observerList.Remove(observer);
        }

        /// <summary>
        ///     The notify.
        /// </summary>
        public void Notify()
        {
            foreach (object observer in this.observerList)
            {
                ((Observer)observer).Update();
            }
        }

        #endregion
    }

    /// <summary>
    ///     The concrete subject.
    /// </summary>
    public class ConcreteSubject : BaseSubject
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the subject state.
        /// </summary>
        public string SubjectState { get; set; }

        #endregion
    }

    /// <summary>
    ///     The observer.
    /// </summary>
    public abstract class Observer
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The update.
        /// </summary>
        public abstract void Update();

        #endregion
    }

    /// <summary>
    ///     The concrete observer.
    /// </summary>
    public class ConcreteObserver : Observer
    {
        #region Fields

        /// <summary>
        ///     The name.
        /// </summary>
        private readonly string name;

        /// <summary>
        ///     The subject.
        /// </summary>
        private readonly ConcreteSubject subject;

        /// <summary>
        ///     The observer state.
        /// </summary>
        private string observerState;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteObserver"/> class.
        /// </summary>
        /// <param name="subject">
        /// The subject.
        /// </param>
        /// <param name="name">
        /// The name.
        /// </param>
        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            this.subject = subject;
            this.name = name;
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The update.
        /// </summary>
        public override void Update()
        {
            this.observerState = this.subject.SubjectState;
            Console.WriteLine("Observer:{0},state:{1}", this.name, this.observerState);
        }

        #endregion
    }
}