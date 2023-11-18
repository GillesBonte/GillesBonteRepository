namespace ClassLibraryUnitTest
{
    public class Math
    {
        private Single _saldo = 0;

        public Math()
        {
            _saldo = 10000;
        }

        public Single Saldo { get { return _saldo; } }

        public bool Transaction(string soort, Single bedrag)
        {
            bool result = false;
            switch (soort)
            {
                case "+":
                    _saldo += bedrag;
                    result = true;
                    break;
                case "-":
                    if (_saldo - bedrag < 0)
                    {
                        throw new Exception("POOR FUCKER");
                    }
                    else
                    {
                        _saldo -= bedrag;
                        result = true;
                    }
                    break;
            }
            return result;
        }

    }

}