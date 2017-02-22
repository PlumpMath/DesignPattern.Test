// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//   
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Test
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    ///     The program.
    /// </summary>
    internal class Program
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The abstract factory test.
        /// </summary>
        public static void AbstractFactoryTest()
        {
            AbstractFactory factoryA = new ConcreteFactoryA();
            var client = new Client(factoryA);
            client.Run();

            AbstractFactory factoryB = new ConcreteFactoryB();
            client = new Client(factoryB);
            client.Run();
            Console.WriteLine("AbstractFactoryTest finish.");
        }

        /// <summary>
        ///     The adapter test.
        /// </summary>
        public static void AdapterTest()
        {
            Target target = new Adapter();
            target.Request();
            Console.WriteLine("AdapterTest finish.");
        }

        /// <summary>
        ///     The bridge test.
        /// </summary>
        public static void BridgeTest()
        {
            Abstraction abstraction = new RefinedAbstraction();
            abstraction.SetImplementor(new ConcreteImplementorA());
            abstraction.Operation();

            abstraction.SetImplementor(new ConcreteImplementorB());
            abstraction.Operation();
            Console.WriteLine("BridgeTest finish.");
        }

        /// <summary>
        ///     The builder test.
        /// </summary>
        public static void BuilderTest()
        {
            var director = new Director();
            Builder builder1 = new ConcreteBuilder1();
            Builder builder2 = new ConcreteBuilder2();

            director.Construct(builder1);
            Product product1 = builder1.GetProduct();
            product1.Show();

            director.Construct(builder2);
            Product product2 = builder2.GetProduct();
            product2.Show();
            Console.WriteLine("BuilderTest finish.");
        }

        /// <summary>
        ///     The chain of responsibility test.
        /// </summary>
        public static void ChainOfResponsibilityTest()
        {
            Handler handler1 = new ConcreteHandler1();
            Handler handler2 = new ConcreteHandler2();
            Handler handler3 = new ConcreteHandler3();

            handler1.SetHandler(handler2);
            handler2.SetHandler(handler3);

            var inputs = new List<int> { 58, 69, 95, 85, 46, 100, 88, 59 };

            foreach (int input in inputs)
            {
                handler1.HandleRequest(input);
            }

            Console.WriteLine("ChainOfResponsibilityTest finish.");
        }

        /// <summary>
        ///     The command test.
        /// </summary>
        public static void CommandTest()
        {
            var receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);
            var invoker = new Invoker();
            invoker.SetCommand(command);
            invoker.Execute();
            Console.WriteLine("CommandTest finish.");
        }

        /// <summary>
        ///     The composit test.
        /// </summary>
        public static void CompositTest()
        {
            var root = new Composit("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            var comp = new Composit("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));

            root.Add(comp);
            root.Add(new Leaf("Leaf C"));

            var leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            root.Display(1);
            Console.WriteLine("CompositTest finish.");
        }

        /// <summary>
        ///     The decorator test.
        /// </summary>
        public static void DecoratorTest()
        {
            var component = new ConcreteComponent();
            var componentA = new ConcreteDecoratorA();
            var componentB = new ConcreteDecoratorB();

            componentA.SetComponent(componentB);
            componentB.SetComponent(component);
            componentB.Operation();
            Console.WriteLine("DecoratorTest finish.");
        }

        /// <summary>
        ///     The facade test.
        /// </summary>
        public static void FacadeTest()
        {
            var facade = new Facade();
            facade.MethodOne();
            facade.MethodTwo();
            Console.WriteLine("FacadeTest finish.");
        }

        /// <summary>
        ///     The factory method test.
        /// </summary>
        public static void FactoryMethodTest()
        {
            var creators = new Creator[2];
            creators[0] = new ConcreteCreator1();
            creators[1] = new ConcreteCreator2();

            foreach (Creator creator in creators)
            {
                AbstractProduct product = creator.Factory();
                Console.WriteLine("Created {0}", product.GetType().Name);
            }

            Console.WriteLine("FactoryMethodTest finish.");
        }

        /// <summary>
        ///     The fly weight test.
        /// </summary>
        public static void FlyWeightTest()
        {
            int extrinsicstate = 22;

            var factory = new FlyweightFactory();
            Flyweight x = factory.GetFlyweight("X");
            Flyweight y = factory.GetFlyweight("Y");
            Flyweight z = factory.GetFlyweight("Z");

            x.Operation(--extrinsicstate);
            y.Operation(--extrinsicstate);
            z.Operation(--extrinsicstate);

            var m = new NonConcreteFlyweight();
            m.Operation(--extrinsicstate);

            Console.WriteLine("FlyWeightTest finish.");
        }

        /// <summary>
        ///     The interpreter test.
        /// </summary>
        public static void InterpreterTest()
        {
            var context = new Context();

            var expressions = new List<Expression>
                                  {
                                      new ConcreteExpression1(), 
                                      new ConcreteExpression2(), 
                                      new ConcreteExpression1(), 
                                  };

            foreach (Expression expression in expressions)
            {
                expression.Interpret(context);
            }

            Console.WriteLine("InterpreterTest finish.");
        }

        /// <summary>
        ///     The iterator test.
        /// </summary>
        public static void IteratorTest()
        {
            var aggregate = new ConcreteAggregate();
            aggregate[0] = "A";
            aggregate[1] = "B";
            aggregate[2] = "C";
            aggregate[3] = "D";

            var iterator = new ConcreteIterator(aggregate);
            Console.WriteLine(iterator.First());
            while (iterator.Next() != null)
            {
                Console.WriteLine(iterator.CurrentItem());
            }

            Console.WriteLine(iterator.IsDone());
            Console.WriteLine("IteratorTest finish.");
        }

        /// <summary>
        ///     The mediator test.
        /// </summary>
        public static void MediatorTest()
        {
            var mediator = new ConcreteMediator();
            var colleague1 = new ConcreteColleague1(mediator);
            var colleague2 = new ConcreteColleague2(mediator);

            mediator.ConcreteColleague1 = colleague1;
            mediator.ConcreteColleague2 = colleague2;

            colleague1.Send("Hello world");
            colleague2.Send("Happy");
            Console.WriteLine("MediatorTest finish.");
        }

        /// <summary>
        ///     The memento test.
        /// </summary>
        public static void MementoTest()
        {
            var originator = new Originator();
            originator.State = "OFF";

            Memento memento = originator.CreateMemento();
            var caretaker = new Caretaker();
            caretaker.Memento = memento;

            originator.State = "ON";
            originator.SetMemento(caretaker.Memento);
            Console.WriteLine("MementoTest finish.");
        }

        /// <summary>
        ///     The observer test.
        /// </summary>
        public static void ObserverTest()
        {
            var subject = new ConcreteSubject();

            var observer1 = new ConcreteObserver(subject, "A");
            var observer2 = new ConcreteObserver(subject, "B");
            var observer3 = new ConcreteObserver(subject, "C");

            subject.Attach(observer1);
            subject.Attach(observer2);
            subject.Attach(observer3);

            subject.SubjectState = "OFF";
            subject.Notify();

            subject.Detach(observer2);
            subject.SubjectState = "ON";
            subject.Notify();
            Console.WriteLine("ObserverTest finish.");
        }

        /// <summary>
        ///     The prototype test.
        /// </summary>
        public static void PrototypeTest()
        {
            var p1 = new ConcretePrototype1("1");
            var c1 = (ConcretePrototype1)p1.Clone();
            Console.WriteLine("Cloned Id: {0}", c1.Id);

            var p2 = new ConcretePrototype2("2");
            var c2 = (ConcretePrototype2)p2.Clone();
            Console.WriteLine("Cloned Id: {0}", c2.Id);
            Console.WriteLine("PrototypeTest finish.");
        }

        /// <summary>
        ///     The proxy test.
        /// </summary>
        public static void ProxyTest()
        {
            var proxy = new Proxy();
            proxy.Request();
            Console.WriteLine("ProxyTest finish.");
        }

        /// <summary>
        ///     The simple factory test.
        /// </summary>
        public static void SimpleFactoryTest()
        {
            Operation op = SimpleFactory.Create("+");
            op.A = 2;
            op.B = 5;
            Console.WriteLine("Simple Factory: {0}", op.Operate());
        }

        /// <summary>
        ///     The state test.
        /// </summary>
        public static void StateTest()
        {
            var stateContext = new StateContext(new ConcreteState1());

            stateContext.Request();
            stateContext.Request();
            stateContext.Request();
            stateContext.Request();
            Console.WriteLine("StateTest finish.");
        }

        /// <summary>
        ///     The strategy test.
        /// </summary>
        public static void StrategyTest()
        {
            var concreteStrategy1 = new ConcreteStrategy1();
            var concreteStrategy2 = new ConcreteStrategy2();
            var concreteStrategy3 = new ConcreteStrategy3();

            var context = new StrategyContext(concreteStrategy1);
            context.ContextInterface();

            context = new StrategyContext(concreteStrategy2);
            context.ContextInterface();

            context = new StrategyContext(concreteStrategy3);
            context.ContextInterface();
            Console.WriteLine("StrategyTest finish.");
        }

        /// <summary>
        /// The template method test.
        /// </summary>
        public static void TemplateMethodTest()
        {
            AbstractClass itemA = new ConcreteClassA();
            itemA.TemplateMethod();

            AbstractClass itemB = new ConcreteClassB();
            itemB.TemplateMethod();
            Console.WriteLine("TemplateMethodTest finish.");
        }

        /// <summary>
        /// The visitor test.
        /// </summary>
        public static void VisitorTest()
        {
            Element elementA = new ConcreteElementA();
            Element elementB = new ConcreteElementB();

            Visitor visitorA = new ConcreteVisitorA();
            Visitor visitorB = new ConcreteVisitorB();

            var structure = new ObjectStructure();
            structure.Attach(elementA);
            structure.Attach(elementB);
            structure.Accept(visitorA);
            structure.Accept(visitorB);

            structure.Detach(elementA);
            structure.Accept(visitorA);
            structure.Accept(visitorB);

            Console.WriteLine("VisitorTest finish.");
        }

        #endregion

        #region Methods

        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        private static void Main(string[] args)
        {
            VisitorTest();
            Console.Read();
        }

        #endregion
    }
}