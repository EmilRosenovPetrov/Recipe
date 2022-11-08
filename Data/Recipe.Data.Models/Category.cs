namespace Recipe.Data.Models
{
    using System.Collections.Generic;

    using global::Recipe.Data.Common.Models;

    public class Category : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public virtual ICollection<Recipe> Recipes { get; set; } = new HashSet<Recipe>();
    }
}
