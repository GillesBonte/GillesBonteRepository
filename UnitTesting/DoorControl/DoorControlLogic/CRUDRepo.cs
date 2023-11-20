using DoorControlLogic.Models;
using System.Dynamic;

namespace DoorControlLogic

{
    public class CRUDRepo
    {
        //lists for data
        private List<Token> _tokens = new List<Token>();
        private List<int> _doors = new List<int>();

        public CRUDRepo()
        {
            //create data
            _doors.Add(1);
            _doors.Add(24);
            _doors.Add(54);

            _tokens.Add(new Token()
            {
                Id = "B59D",
                AllowedDoors = new List<int> { 54 },
                Blocked = false
            });

            _tokens.Add(new Token()
            {
                Id = "5789",
                AllowedDoors = new List<int> { 24, 54 },
                Blocked = false
            });

            _tokens.Add(new Token()
            {
                Id = "ABCD",
                AllowedDoors = new List<int> { 1, 24 },
                Blocked = true
            }) ;
        }

        //add Token
        public void AddToken(Token token)
        {
            _tokens.Add(token);
        }

        //remove Token
        public void RemoveToken(Token token) 
        {
            _tokens.Remove(token);
        }

        //get all tokens
        public List<Token> GetTokens() 
        {
            return _tokens;
        }

        //get token by ID
        public Token GetTokenById(string tokenId)
        {
            Token resultToken = null;
            foreach (Token token in _tokens)
            {
                if (token.Id == tokenId)
                {
                    resultToken = token;
                }
            }
            return resultToken;
        }

        //get all doors
        public List<int> GetDoors() 
        {
            return _doors;
        }
    }
}