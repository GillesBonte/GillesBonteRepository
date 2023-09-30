using System.IO;
namespace CalculationProgressAsync
{
    public partial class frmDataProgress : Form
    {
        //create a delegate with an integer (because we need to retreive ints)
        delegate void RequestCallBack(int i);

        public frmDataProgress()
        {
            InitializeComponent();
        }

        private async void btnStart_Click(object sender, EventArgs e) //async the click event
        {
            //this is a lambda notation where the calculations happen
            await Task.Run(() => //these calculations run in the "background"
            {
                string strCurrentDirectory = Directory.GetCurrentDirectory() + "\\" + "NumberLineData.txt";
                string strText = File.ReadAllText(strCurrentDirectory);
                List<int> lstNumbers = new List<int>();
                int intMaxAmount = 0;
                int intResult = 0;
                foreach (string strLine in strText.Split('\n'))
                {

                    if (strLine != "")
                    {
                        lstNumbers.Add(int.Parse(strLine));
                    }

                }

                intMaxAmount = lstNumbers.Count;
                IniCallbacks(intMaxAmount);

                foreach (int i in lstNumbers)
                {
                    intResult += i;
                    IniCallbacks2(i);
                }

                MessageBox.Show(intResult.ToString());

            });

        }

        //method to initialize the callback for the maximum
        private void IniCallbacks(int i)
        {

            if (this.pbCalculations.InvokeRequired)
            {
                RequestCallBack callBack = new RequestCallBack(IniCallbacks);
                this.Invoke(callBack, i);
            }
            else
            {
                pbCalculations.Maximum = i;
            }

        }

        private void IniCallbacks2(int i)
        {

            if (this.pbCalculations.InvokeRequired)
            {
                RequestCallBack callBack = new RequestCallBack(IniCallbacks2);
                Invoke(callBack, i);
            }
            else
            {
                pbCalculations.Value = i;
            }

        }

    }
}