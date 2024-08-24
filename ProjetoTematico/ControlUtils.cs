using System;
using System.Windows.Forms;

namespace ProjetoTematico
{
    public static class ControlUtils // Certifique-se de que a classe é pública
    {
        public static void ClearControls(params Control[] controls)
        {
            foreach (Control control in controls)
            {
                switch (control)
                {
                    case TextBox textBox:
                        textBox.Clear();
                        break;

                    case ComboBox comboBox:
                        comboBox.SelectedIndex = -1;
                        break;

                    case CheckBox checkBox:
                        checkBox.Checked = false;
                        break;

                    case RadioButton radioButton:
                        radioButton.Checked = false;
                        break;

                    case ListBox listBox:
                        listBox.ClearSelected();
                        break;

                    case RichTextBox richTextBox:
                        richTextBox.Clear();
                        break;

                    default:
                        break;
                }
            }
        }
    }
}