namespace MuziekSpeler
{
    public partial class frmMuziekSpeler : Form
    {
        public MuziekSpeler _MuziekSpeler = new MuziekSpeler();

        public frmMuziekSpeler()
        {
            InitializeComponent();
            _MuziekSpeler.LiedGespeeld += _MuziekSpeler_LiedGespeeld;
        }

        private void _MuziekSpeler_LiedGespeeld(object? sender, MuziekSpelerEventArgs e)
        {
            MessageBox.Show("Liedje wordt afgespeeld. " + e.LiedNaam);
        }

        private void btnSpeel_Click(object sender, EventArgs e)
        {
            _MuziekSpeler.SpeelLied(cbLiedjes.Text);
        }

        private void frmMuziekSpeler_Load(object sender, EventArgs e)
        {
            cbLiedjes.Items.Add("Lied 1");
            cbLiedjes.Items.Add("Lied 2");
            cbLiedjes.Items.Add("Lied 3");
            cbLiedjes.Items.Add("Lied 4");
        }
    }
}