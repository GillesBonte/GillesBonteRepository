namespace DeVoetbalApp
{
    public partial class Form1 : Form
    {
        delegate void RequestCallBack(string message);
        public List<Player> _players = new List<Player>();
        public int _intPlayerCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        //make this method async
        private async void btnImport_Click(object sender, EventArgs e)
        {
            //await Task lambda
            await Task.Run(() =>
            {
                //Put strings of file in a List of strings
                List<string> strFile = new List<String>(File.ReadAllLines(Directory.GetCurrentDirectory() + "/players.txt"));
                //start at 0 when import starts!?
                _intPlayerCount = 0;

                //turn each string in strFile into a player
                foreach (string strLines in strFile)
                {
                    //split on , to get all different properties
                    string[] strPlayer = strLines.Split(',');
                    //try creating a player (to find a faulty name)
                    try
                    {
                        //add player
                        _players.Add(new Player()
                        {
                            //set properties
                            Name = strPlayer[0],
                            Position = strPlayer[1],
                            Country = strPlayer[2],
                            League = strPlayer[3],
                            Club = strPlayer[4],
                            Price = int.Parse(strPlayer[5])
                        });

                        //counter++ after player is added
                        _intPlayerCount++;


                    }
                    //catch for when a faulty name has been detected
                    catch (PlayerNameTooLongException ex)
                    {
                        //to return values to the mainthread we need to initialize a callback
                        IniCallbacks("Could not add " + ex.Message + "\n");
                    }

                }

                //show how many players have been imported
                //to return values to the mainthread we need to initialize a callback
                IniCallbacks($"{_intPlayerCount} players imported");

            }); //end of async
        }

        //initialize the callbacks (they are both strings that need to be showin in txtResult)
        //so only 1 method is requred
        private void IniCallbacks(string message)
        {
            //check if txtResult requires a callback to the mainthread
            if (this.txtResult.InvokeRequired)
            {
                //if it does... initiate the callback
                RequestCallBack callBack = new RequestCallBack(IniCallbacks);
                this.Invoke(callBack, message);
            }
            //when it is on the right thread
            else
            {
                //take the string and put the string in the textbox
                txtResult.Text += message;
            }

        }

        private void btnQuery1_Click(object sender, EventArgs e)
        {
            //query for players with a 'Z' in their name
            var result = from player in _players
                         where player.Name.Contains('z')
                         select $"{player.Name}\t{player.Country}";

            ShowResult(result);
        }

        private void btnQuery2_Click(object sender, EventArgs e)
        {
            //quere for players within the pricerange 5000 - 10000
            var result = from player in _players
                         where player.Price >= 5000 && player.Price <= 10000 //Borders INCLUDED (5000 - 1000)
                         select $"{player.Name}\t{player.Price}";

            ShowResult(result);
        }

        private void btnQuery3_Click(object sender, EventArgs e)
        {
            //query to group by playerposition and count them
            var result = from player in _players
                         group player by player.Position into playersPerPosition
                         select $"{playersPerPosition.Key} - {playersPerPosition.Count()}";

            ShowResult(result);
        }

        private void btnQuery4_Click(object sender, EventArgs e)
        {
            //query to sort on pricerange 10k (INCORRECT) 
            var result = from player in _players
                         group player by player.Price / 10000 into playersPriceRange
                         select $"{playersPriceRange.Key * 10000} - {playersPriceRange.Count()}";

            ShowResult(result);
        }

        //Method to show any result on screen (in txtResult)
        private void ShowResult(IEnumerable<string> filteredList)
        {

            txtResult.Text = string.Empty;

            foreach (string strLine in filteredList)
            {
                txtResult.Text += strLine + "\n";
            }

        }

    }
}