using System.Text;
using PieBuilder.Enums;
using PieBuilder.Recipes;

namespace PieBuilder
{
    class RecipeAssembler
    {
        private readonly RecipeFactory _recipeFactory;

        public RecipeAssembler(RecipeFactory recipeFactory)
        {
            _recipeFactory = recipeFactory;
        }

        public string AssembleRecipe(PieFillingType fillingType, PieCrustType crustType)
        {
            IRecipe pastry = _recipeFactory.CreatePastryRecipe();
            IRecipe filling = _recipeFactory.CreateFillingRecipe(fillingType);
            IRecipe crust = _recipeFactory.CreateCrustRecipe(crustType);

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(pastry.Recipe);
            stringBuilder.AppendLine("Press into pie tin");
            stringBuilder.AppendLine(filling.Recipe);
            stringBuilder.AppendLine("Fill pie cavity");
            stringBuilder.AppendLine(crust.Recipe);
            stringBuilder.AppendLine("Top off pie");

            return stringBuilder.ToString();
        }
    }
}
