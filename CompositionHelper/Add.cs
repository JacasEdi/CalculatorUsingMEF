using System.ComponentModel.Composition;
using Contract;

namespace CompositionHelper
{
    [Export(typeof(ICalculator))]
    // ExportMetadata attribute will help to determine at runtime which implementation to use. 
    // It is essentially a form of name-value pair.
    [ExportMetadata("CalculatorMetaData", "Add")]
    public class Add : ICalculator
    {
        public double GetResult(double num1, double num2)
        {
            return num1 + num2;
        }
    }

}