using System.Windows.Forms;

namespace PieBuilder
{
    class CrustSelectionDisabledSwitch : ICrustSelectionSwitch
    {
        public void SetControlVisibility(Label crustLabel, ComboBox crustComboBox)
        {
            crustLabel.Visible = false;
            crustComboBox.Visible = false;
            crustComboBox.Enabled = false;
        }
    }
}