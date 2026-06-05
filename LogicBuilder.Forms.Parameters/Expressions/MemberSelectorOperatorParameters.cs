using LogicBuilder.Attributes;

namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class MemberSelectorOperatorParameters(
            [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
            [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, "fieldTypeSource")]
            [Comments("Update fieldTypeSource first. Full or parial member name from the source operand parent.")]
            string memberFullName,

            [Comments("Source Operand.")]
            IExpressionParameter sourceOperand,

            [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
            [NameValue(AttributeNames.DEFAULTVALUE, "MyApp.Domain.Entities")]
            [Comments("Fully qualified class name for the model type.")]
#pragma warning disable CS9113 // Used as metadata in the LogicBuilder UI
            string fieldTypeSource = "MyApp.Domain.Entities"
#pragma warning restore CS9113 // Used as metadata in the LogicBuilder UI
        ) : IExpressionParameter
    {
        public string MemberFullName { get; set; } = memberFullName;
        public IExpressionParameter SourceOperand { get; set; } = sourceOperand;
    }
}