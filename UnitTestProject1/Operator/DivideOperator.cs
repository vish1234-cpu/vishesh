
using ObjectExtension;
using System;
using System.Collections.Generic;
using System.Text;

namespace DivideOperators
{
    public class DivideOperator
    {
        private double? _numericResult;
        public DivideOperator()
        {
        }


        // evaluate method to divide 2 numeric numbers
        public object Evaluate(List<object> data)
        {

            object result;
            foreach (object value in data)
            {
                if (value.IsNumeric())
                {

                    if (_numericResult == null)
                    {
                        _numericResult = Convert.ToDouble(value);
                    }

                    else
                    {
                        try
                        {
                            _numericResult = _numericResult.Value / Convert.ToDouble(value);
                        }
                        catch (DivideByZeroException)
                        {
                            throw new ArgumentException($"Divide by zero is not possible!!");
                        }
                        catch (Exception)
                        {
                            throw new ArgumentException($"Wrong values are added!!!");
                        }

                    }

                }
                else
                {
                    throw new ArgumentException($"Special symbols or strings are encountered!!!");
                }
            }

            if (_numericResult != null)
            {
                result = _numericResult.Value;
            }
            else
            {
                throw new ArgumentException($"Incorrect arguments encountered in {nameof(DivideOperator)}");
            }
            return result;
        }
    }
}
