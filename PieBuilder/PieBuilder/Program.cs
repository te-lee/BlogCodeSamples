using System;
using System.Windows.Forms;
using PieBuilder.Properties;

namespace PieBuilder
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var recipeAssembler = new RecipeAssembler(new RecipeFactory());

            ICrustSelectionSwitch crustSelectionSwitch;
            if (Settings.Default.CrustSelectionFeatureEnabled)
            {
                crustSelectionSwitch = new CrustSelectionEnabledSwitch();
            }
            else
            {
                crustSelectionSwitch = new CrustSelectionDisabledSwitch();
            }

            Application.Run(new PieBuilderForm(recipeAssembler, crustSelectionSwitch));
        }
    }
}
