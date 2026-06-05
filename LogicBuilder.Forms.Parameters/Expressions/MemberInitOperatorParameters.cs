using System.Collections.Generic;
using System;
using LogicBuilder.Attributes;
using System.Linq;

namespace LogicBuilder.Forms.Parameters.Expressions
{
	public class MemberInitOperatorParameters(
            [Comments("List of member bindings")]
            IList<MemberBindingItem> memberBindings,

            [Comments("The Select New type leave as null (uncheck) for anonymous types. Click the function button and use the configured GetType function.  Use the Assembly qualified type name for the type argument.")]
            Type? newType = null
        ) : IExpressionParameter
	{
        public IDictionary<string, IExpressionParameter> MemberBindings { get; set; } = memberBindings.ToDictionary(m => m.Property, m => m.Selector);
        public Type? NewType { get; set; } = newType;
    }
}