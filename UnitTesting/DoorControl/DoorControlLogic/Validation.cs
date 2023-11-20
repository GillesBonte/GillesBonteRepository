using DoorControlLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DoorControlLogic
{
    public class Validation
    {
        private CRUDRepo _repo = new CRUDRepo();

        public int GetStatus(string tokenId, int doorNumber)
        {
            int intResult = 0;

                Token usedToken = _repo.GetTokenById(tokenId);
                if (!Regex.IsMatch(tokenId, "^[0-9a-fA-F]+$"))
                {
                    throw new ArgumentException($"{tokenId} is invalid.");
                }
                else if (!_repo.GetTokens().Contains(usedToken))
                {
                    intResult = 22;
                }
                else if (usedToken.Blocked == true)
                {
                    intResult = 21;
                }
                else if (usedToken.AllowedDoors.Contains(doorNumber))
                {
                    intResult = 10;
                }
                else
                {
                    intResult = 20;
                }

            return intResult;
        }
    }
}
