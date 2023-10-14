namespace BucketTestClass
{
    public partial class Form1 : Form
    {
        private Bucket? testbucket;
        public Form1()
        {
            testbucket = new Bucket();
            testbucket.MaxAmount = 10;
            testbucket.bucketsAlmostFull += Testbucket_bucketsAlmostFull;
            testbucket.bucketsfull += Testbucket_bucketsfull;
            InitializeComponent();
        }

        private void Testbucket_bucketsfull(object? sender, EventArgs e)
        {
            MessageBox.Show("full");
        }

        private void Testbucket_bucketsAlmostFull(object? sender, EventArgs e)
        {
           this.BackColor = Color.Orange;
        }

        private void btnFillBucket_Click_1(object sender, EventArgs e)
        {
            testbucket.Fill(1);
        }
    }
}