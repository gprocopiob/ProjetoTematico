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

        public static void ShowAndCloseForm(Form currentForm, Type newFormType)
        {
            Form newForm = (Form)Activator.CreateInstance(newFormType);

            currentForm.Hide();

            newForm.ShowDialog();

            currentForm.Close();
        }
    }
}