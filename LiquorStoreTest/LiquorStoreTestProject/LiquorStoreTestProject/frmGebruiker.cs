using LiquorStoreTestProject.LiquorStoreTableAdapters;

namespace LiquorStoreTestProject
{
    public partial class frmGebruiker : Form
    {

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmGebruiker_Load(object sender, EventArgs e)
        {
            LiquorStore dataSet = new LiquorStore();
            GebruikersTableAdapter adapter = new GebruikersTableAdapter();
            txtGebruiker.Text = dataSet.Gebruikers[0].Gebruikersnaam;
        }
    }
}
