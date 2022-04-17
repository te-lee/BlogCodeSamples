using System.Windows.Forms;

namespace PieBuilder
{
    class CrustSelectionEnabledSwitch : ICrustSelectionSwitch
    {
        public void SetControlVisibility(Label crustLabel, ComboBox crustComboBox)
        {
            crustLabel.Visible = true;
            crustComboBox.Visible = true;
            crustComboBox.Enabled = true;
        }
    }
}