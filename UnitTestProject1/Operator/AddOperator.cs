using ObjectExtension;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddOperators
{
    public class AddOperator
    {
        private double? _numericResult;
        private StringBuilder _stringResult;
        public AddOperator()
        {
        }


        //  Addition of 2 positive or two negative numbers and stings with numbers 
        public object Evaluate(List<object> data)
        {
           
            object result;
            foreach (object value in data)
            {
                if (value.IsNumeric())
                {

                    if (_numericResult == null)
                        _numericResult = 0.0;
                    _numericResult = _numericResult.Value + Convert.ToDouble(value);
                }
                else if (value.IsString())
                {
                    if (_stringResult == null)
                        _stringResult = new StringBuilder();

                    _stringResult.Append(value);
                }
                else
                {
                    throw new ArgumentException($"Non numeric or string value encountered");
                }
            }

            if (_numericResult != null)
                result = _numericResult.Value;
            else if (_stringResult != null)
            {
                result = _stringResult.ToString();
            }
            else
            {
                throw new ArgumentException($"Incorrect arguments encountered in {nameof(AddOperator)}");
            }
            return result;
        }
    }
}
