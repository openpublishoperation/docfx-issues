namespace FooLib
{
    
    public class BaseFooClass
    {
        public int BaseClassField;
        public int BaseClassMethod()
        {
            return 1;
        }

        public int BaseClassMethod(int a)
        {
            return 1;
        }

    }

    public class BaseGenericFooClass<T>:BaseFooClass
    {
        public int BaseGenericClassField;
        public int BaseGenericClassMethod()
        {
            return 1;
        }

        public int BaseGenericClassMethod(int a)
        {
            return 1;
        }
        
    }

    
    public class ConcreteClass :BaseGenericFooClass<object>
    {
        public int ConcreteClassField;
        public int ConcreteClassMethod()
        {
            return 1;
        }

        public int ConcreteClassMethod(int a)
        {
            return 1;
        }
    }
}
