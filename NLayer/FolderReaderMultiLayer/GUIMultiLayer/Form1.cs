namespace GUIMultiLayer
{
    public partial class frmGUI : Form
    {
        public frmGUI()
        {
            InitializeComponent();
        }

        private void btnToonBestanden_Click(object sender, EventArgs e)
        {
            string[] bestanden = new ProcessingLibraryMultiLayer.ProcessMultiLayerClass().ToonBestanden(AppDomain.CurrentDomain.BaseDirectory + "TestFolder");
            string result = "";

            foreach (string bestand in bestanden)
            {
                result += bestand + "\n";
            }

            MessageBox.Show(result);
        }

        private void btnToonInhoudEersteBestand_Click(object sender, EventArgs e)
        {
            string[] bestanden = new ProcessingLibraryMultiLayer.ProcessMultiLayerClass().ToonInhoudEersteFile(AppDomain.CurrentDomain.BaseDirectory + "TestFolder");
            string result = "";

            foreach (string bestand in bestanden)
            {
                result += bestand + "\n";
            }

            MessageBox.Show(result);

        }
    }
}