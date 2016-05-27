using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Newsoft.Roslyn.T4
{

    [TestAttribute]
    public class TestClassWithInterfaceAndAttribute : TestClassBlank, ITestInterface
    {

    }
    public class TestClassGenInterface<T> : TestClassBlank, ITestGenericInterface<T>
    {

    }
    public class TestClassBlank
    {
        public bool? A
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
        public List<string> SomeCollection { get; set; }

        public Expression<Func<string, object>> SomeExpression { get; set; }

        public void MethodA() { }

        public string FunctionA() { return "A"; }
    }

    [TestAttribute]
    public class TestClassWithAttr : TestClassBlank
    {

    }
    public class TestAttribute : Attribute { }
    public interface ITestInterface {
        bool? A { get; set; }
        List<string> SomeCollection { get; set; }

        Expression<Func<string,object>> SomeExpression { get; set; }
    }

    public interface ITestGenericInterface<T> : ITestInterface { }
}
