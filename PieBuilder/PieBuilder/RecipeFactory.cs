using System.ComponentModel;
using PieBuilder.Enums;
using PieBuilder.Properties;
using PieBuilder.Recipes;

namespace PieBuilder
{
    class RecipeFactory
    {
        public IRecipe CreatePastryRecipe()
        {
            if (Settings.Default.ExperimentalPastryFeatureEnabled)
            {
                return new ExperimentalPastryRecipe();
            }
            else
            {
                return new BasicPastryRecipe();
            }
        }

        public IRecipe CreateFillingRecipe(PieFillingType pieFillingType)
        {
            switch (pieFillingType)
            {
                case PieFillingType.Beef:
                    return new BeefFillingRecipe();

                case PieFillingType.Chicken:
                    return new ChickenFillingRecipe();

                case PieFillingType.SteakAndKidney:
                    return new SteakAndKidneyFillingRecipe();
            }

            throw new InvalidEnumArgumentException();
        }

        public IRecipe CreateCrustRecipe(PieCrustType pieCrustType)
        {
            switch (pieCrustType)
            {
                case PieCrustType.Plain:
                    return new PlainCrustRecipe();

                case PieCrustType.Peppercorn:
                    return new PeppercornCrustRecipe();

                case PieCrustType.Potato:
                    return new PotatoCrustRecipe();
            }

            throw new InvalidEnumArgumentException();
        }
    }
}