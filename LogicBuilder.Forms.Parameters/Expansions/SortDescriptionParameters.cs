using LogicBuilder.Attributes;
using LogicBuilder.Expressions.Utils.Strutures;

namespace LogicBuilder.Forms.Parameters.Expansions
{
    public class SortDescriptionParameters(
            [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
            [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, "fieldTypeSource")]
            [Comments("Update fieldTypeSource first. This property to sort by.")]
            string propertyName,

            [Comments("Click the variable button and select th configured ListSortDirection.")]
            ListSortDirection order,

            [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
            [Comments("Fully qualified class name for the model type.")]
#pragma warning disable CS9113 // Used as metadata in the LogicBuilder UI
            string fieldTypeSource = "MyApp.Domain.Entities"
#pragma warning restore CS9113 // Used as metadata in the LogicBuilder UI
        )
    {
        public string PropertyName { get; set; } = propertyName;
        public ListSortDirection SortDirection { get; set; } = order;
    }
}
