using LogicBuilder.Attributes;
using System.Collections.Generic;

namespace LogicBuilder.Forms.Parameters.Expansions
{
    public class SelectExpandItemParameters(
            [Comments("Update fieldTypeSource first. This is the navigation property name.")]
            [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
            [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, "fieldTypeSource")]
            string memberName,

            [Comments("Used to filter the navigation property when it is a collection.")]
            SelectExpandItemFilterParameters? filter = null,

            [Comments("Used to apply sort, skip and take to the navigation property when it is a collection.")]
            SelectExpandItemQueryFunctionParameters? queryFunction = null,

            [Comments("Update navigationProperyType first. This is a list of fields to select when a subset of fields is required.")]
            [ParameterEditorControl(ParameterControlType.ParameterSourcedPropertyInput)]
            [NameValue(AttributeNames.PROPERTYSOURCEPARAMETER, "navigationProperyType")]
            List<string>? selects = null,

            [Comments("List of navigation properties to expand.")]
            List<SelectExpandItemParameters>? expandedItems = null,

            [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
            [Comments("Fully qualified class name for the model type.")]
#pragma warning disable CS9113 // Used as metadata in the LogicBuilder UI
            string fieldTypeSource = "MyApp.Domain.Entities",
#pragma warning restore CS9113 // Used as metadata in the LogicBuilder UI

            [ParameterEditorControl(ParameterControlType.ParameterSourceOnly)]
            [Comments("Fully qualified class name for the model type.")]
#pragma warning disable CS9113 // Used as metadata in the LogicBuilder UI
            string navigationProperyType = "MyApp.Domain.Entities"
#pragma warning restore CS9113 // Used as metadata in the LogicBuilder UI
        )
    {
        public string MemberName { get; set; } = memberName;
        public SelectExpandItemFilterParameters? Filter { get; set; } = filter;
        public SelectExpandItemQueryFunctionParameters? QueryFunction { get; set; } = queryFunction;
        public List<string> Selects { get; set; } = selects ?? [];
        public List<SelectExpandItemParameters> ExpandedItems { get; set; } = expandedItems ?? [];
    }
}
