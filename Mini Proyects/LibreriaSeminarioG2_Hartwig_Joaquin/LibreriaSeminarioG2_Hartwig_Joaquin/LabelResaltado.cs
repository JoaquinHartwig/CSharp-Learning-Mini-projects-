using System.Drawing;
using System.Windows.Forms;

namespace LibreriaSeminario
{
    public class LabelResaltado : Label
    {
        public LabelResaltado()
        {
           
            this.BackColor = Color.Yellow;
            this.Font = new Font("Arial", 12, FontStyle.Bold);
            this.BorderStyle = BorderStyle.FixedSingle;
            this.AutoSize = true;
        }

        public void MostrarResultado(string texto)
        {
            this.Text = texto;
        }
    }
}