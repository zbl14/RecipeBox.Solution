using System.Collections.Generic;
using System;

namespace RecipeBox.Models
{
  public class Recipe
  {
    public Recipe()
    {
      this.JoinEntities = new HashSet<CategoryRecipe>();
    }
    public int Rating { get; set; }
    public string Name { get; set; }
    public int RecipeId { get; set; }
    public string Ingredients { get; set; }

    public virtual ICollection<CategoryRecipe> JoinEntities { get; } 
  }
}