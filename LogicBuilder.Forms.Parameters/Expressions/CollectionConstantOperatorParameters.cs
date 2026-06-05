using System.Collections.Generic;
using System;

namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class CollectionConstantOperatorParameters(ICollection<object> constantValues, Type elementType) : IExpressionParameter
    {
        public Type ElementType { get; set; } = elementType;
        public ICollection<object> ConstantValues { get; set; } = constantValues;
    }
}