using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Calculo_Formula
    {
        public static string ShowDialog(string text, string caption) 
        {
            Form prompt = new Form();
            prompt.Width = 350;
            prompt.Height = 200;
            prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
            prompt.Text = caption;
            prompt.MaximizeBox = false;
            prompt.StartPosition = FormStartPosition.CenterScreen;
            Label textLabel = new Label() { Left = 20, Top = 20, Text = text, Width = 230 };
            RadioButton calc = new RadioButton() {Left = 20, Top = 50, Text = "Determinando números", Width = 230};
            RadioButton form = new RadioButton() { Left = 20, Top = 80, Text = "Determinando fórmulas", Width = 230 }; ;
            TextBox criar = new TextBox() {Text = text };
            Button confirmation = new Button() { Text = "Salvar", Left = 20, Width = 100, Top = 120 };

            confirmation.Click += (sender, e) =>
            {
                if(calc.Checked == true)
                {
                    criar.Text = "calc";
                }
                if (form.Checked == true)
                {
                    criar.Text = "form";
                }

                prompt.Close();
            };
            prompt.Controls.Add(calc);
            prompt.Controls.Add(form);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            prompt.ShowDialog();

            return criar.Text;
        }
    }
}
