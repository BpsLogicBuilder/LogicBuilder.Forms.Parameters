using System.Collections.Generic;

namespace LogicBuilder.Forms.Parameters.Expansions
{
    public class SortCollectionParameters(List<SortDescriptionParameters> sortDescriptions, int? skip = null, int? take = null)
    {
        public List<SortDescriptionParameters> SortDescriptions { get; set; } = sortDescriptions;
        public int? Skip { get; set; } = skip;
        public int? Take { get; set; } = take;
    }
}
