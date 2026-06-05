using LogicBuilder.Attributes;

namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class MemberBindingItem(
            [NameValue(AttributeNames.USEFOREQUALITY, "true")]
            [NameValue(AttributeNames.USEFORHASHCODE, "true")]
            [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
            [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, "fieldTypeSource")]
            [Comments("Update fieldTypeSource first. Property to bind the selector to.")]
            string property,

            [Comments("Selector.")]
            IExpressionParameter selector,

            [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
            [NameValue(AttributeNames.DEFAULTVALUE, "MyApp.Domain.Entities")]
            [Comments("Fully qualified class name for the model type.")]
#pragma warning disable CS9113 // Used as metadata in the LogicBuilder UI
            string fieldTypeSource = "MyApp.Domain.Entities"
#pragma warning restore CS9113 // Used as metadata in the LogicBuilder UI
        )
    {
        public string Property { get; set; } = property;
        public IExpressionParameter Selector { get; set; } = selector;
    }
}
