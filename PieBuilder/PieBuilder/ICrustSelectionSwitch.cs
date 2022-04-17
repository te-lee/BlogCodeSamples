using System.Windows.Forms;

namespace PieBuilder
{
    interface ICrustSelectionSwitch
    {
        void SetControlVisibility(Label crustLabel, ComboBox crustComboBox);
    }
}
