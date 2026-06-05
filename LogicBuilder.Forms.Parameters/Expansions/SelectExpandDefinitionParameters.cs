using LogicBuilder.Attributes;
using System.Collections.Generic;

namespace LogicBuilder.Forms.Parameters.Expansions
{
    public class SelectExpandDefinitionParameters(
            [Comments("Update fieldTypeSource first. List of fields to select when a subset of fields is required.")]
            [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
            [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, "fieldTypeSource")]
            List<string> selects,

            [Comments("List of navigation properties to expand.")]
            List<SelectExpandItemParameters> expandedItems,

            [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
            [Comments("Fully qualified class name for the model type.")]
#pragma warning disable CS9113 // Used as metadata in the LogicBuilder UI
            string fieldTypeSource = "MyApp.Domain.Entities"
#pragma warning restore CS9113 // Used as metadata in the LogicBuilder UI
        )
    {
        public List<string> Selects { get; set; } = selects;
        public List<SelectExpandItemParameters> ExpandedItems { get; set; } = expandedItems;
    }
}
