namespace CalculadoraSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text.Length > 0)
           
        }
        txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1,1); 
        
        
        
        
        

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtdisplay.Text); 
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtdisplay.Clear(); 

        }

        private void btncopy_Click(object sender, EventArgs e)
        {
            if (Display.Text = txtdisplay.Text.Remove(txtdisplay.Text.Length - 1, 1); 

        }

        private void btnone_Click(object sender, EventArgs e)
        {

        }
    }
}