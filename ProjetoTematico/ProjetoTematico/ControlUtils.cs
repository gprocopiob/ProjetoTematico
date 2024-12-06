using System;
using System.Windows.Forms;

namespace ProjetoTematico
{
    public class ControlUtils
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

        public static void ShowAndCloseForm(Form currentForm, Type newFormType, string email)
        {
            var form = (Form)Activator.CreateInstance(newFormType, email);

            currentForm.Hide();

            form.ShowDialog();

            currentForm.Close();
        }

        public static void ShowPanelBotoes(PictureBox pbx, bool visible, Panel pnl)
        {
            pbx.Visible = visible;
            pnl.Visible = !visible;
        }

        public static void AllowNumbersAndComa(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == ',')
            {
                return;
            }

            e.Handled = true;
        }
    }
}