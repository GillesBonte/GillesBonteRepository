using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucketTestClass
{
    public class Bucket
    {
        public event EventHandler bucketsAlmostFull;
        public event EventHandler bucketsfull;

        public Bucket() 
        {

        }
        public int MaxAmount { get; set; }
        public int CurrentAmount { get; set; } 

        public void Fill(int amount)
        {
            CurrentAmount += amount;
            CheckForFill();
        }

        public void CheckForFill()
        {
            if (CurrentAmount >= MaxAmount * 0.8 && CurrentAmount < MaxAmount)
            {
                bucketsAlmostFull.Invoke(this, new EventArgs());
            }
            if (CurrentAmount == MaxAmount)
            {
                bucketsfull.Invoke(this, new EventArgs());
            }
        }
    }

}
