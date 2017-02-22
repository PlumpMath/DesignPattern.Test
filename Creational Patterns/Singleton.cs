// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Singleton.cs" company="">
//   
// </copyright>
// <summary>
//   The singleton.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Test
{
    /// <summary>
    ///     The singleton.
    /// </summary>
    public class Singleton
    {
        #region Static Fields

        /// <summary>
        ///     The instance.
        /// </summary>
        private static Singleton instance;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Prevents a default instance of the <see cref="Singleton" /> class from being created.
        /// </summary>
        private Singleton()
        {
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets the instance.
        /// </summary>
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }

                return instance;
            }
        }

        #endregion
    }

    /// <summary>
    ///     The singleton 1.
    /// </summary>
    public class Singleton1
    {
        #region Static Fields

        /// <summary>
        ///     The locker.
        /// </summary>
        private static readonly object Locker = new object();

        /// <summary>
        ///     The instance.
        /// </summary>
        private static Singleton1 instance;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Prevents a default instance of the <see cref="Singleton1" /> class from being created.
        /// </summary>
        private Singleton1()
        {
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets the instance.
        /// </summary>
        public static Singleton1 Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (Locker)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton1();
                        }
                    }
                }

                return instance;
            }
        }

        #endregion
    }

    /// <summary>
    ///     The singleton 2.
    /// </summary>
    public class Singleton2
    {
        #region Static Fields

        /// <summary>
        ///     The instance.
        /// </summary>
        private static readonly Singleton2 instance = new Singleton2();

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Prevents a default instance of the <see cref="Singleton2" /> class from being created.
        /// </summary>
        private Singleton2()
        {
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets the instance.
        /// </summary>
        public static Singleton2 Instance
        {
            get
            {
                return instance;
            }
        }

        #endregion
    }

    /// <summary>
    ///     The singleton 3.
    /// </summary>
    public class Singleton3
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Prevents a default instance of the <see cref="Singleton3" /> class from being created.
        /// </summary>
        private Singleton3()
        {
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets the instance.
        /// </summary>
        public static Singleton3 Instance
        {
            get
            {
                return Singleton3Inner.Instance;
            }
        }

        #endregion

        /// <summary>
        ///     The singleton 3 inner.
        /// </summary>
        private static class Singleton3Inner
        {
            #region Static Fields

            /// <summary>
            ///     The instance.
            /// </summary>
            public static Singleton3 Instance = new Singleton3();

            #endregion
        }
    }
}