using System;
using System.Windows.Forms;
using PieBuilder.Enums;

namespace PieBuilder
{
    partial class PieBuilderForm : Form
    {
        private readonly RecipeAssembler _recipeAssembler;

        public PieBuilderForm(RecipeAssembler recipeAssembler, ICrustSelectionSwitch crustSelectionSwitch)
        {
            _recipeAssembler = recipeAssembler;

            InitializeComponent();

            fillingComboBox.SelectedIndex = 0;
            crustComboBox.SelectedIndex = 0;

            crustSelectionSwitch.SetControlVisibility(crustLabel, crustComboBox);
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            var recipe = _recipeAssembler.AssembleRecipe((PieFillingType)fillingComboBox.SelectedIndex, 
                (PieCrustType)crustComboBox.SelectedIndex);

            recipeTextBox.Text = recipe;
        }
    }
}
