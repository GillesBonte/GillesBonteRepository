using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ExamenMyDictionary
{
    public class MyDictionary<T, U>
    {
        //create delegates for the events
        public delegate void DoubleKeyEventHandler(object o, DoubleKeyEventArgs e);
        public delegate void KeyCountEventHandler(object o, KeyCountEventArgs e);

        //create events
        public event EventHandler KeyCountEvent;
        public event DoubleKeyEventHandler DoubleKeyEvent;

        //create list of keys and list of values
        private List<T> _keys;
        private List<U> _values;
        private int _keycount; //create keycount

        //constructor
        public MyDictionary()
        {
            //initiate lists
            _keys = new List<T>();
            _values = new List<U>();

            //create and start timer
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 5000;
            timer.Start();

            //add event to timer for when an interval has passed
            timer.Elapsed += Timer_Elapsed;

        }

        //execute this method when an interval of the timer has passed
        private void Timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            //we invoke an event in our program
            //use keycountARGS to transfer the keycount to our program
            KeyCountEvent?.Invoke(this, new KeyCountEventArgs(_keycount));
        }

        //Add method 
        public void Add(T key, U value)
        {
            //check if our list of keys doesn't already contain that key
            if (!ContainsKey(key))
            {
                //add key to list of keys
                _keys.Add(key);
                //add value to list of values
                _values.Add(value);
                //add one to the keycount
                _keycount++;
            }
            //if the key already exists...
            else
            {
                //trigger the DoubleKeyEvent
                DoubleKeyEvent?.Invoke(this, new DoubleKeyEventArgs());
            }
        }

        //method to remove key & value
        public void Remove(T key)
        {
            //save the index of the chosen key
            int index = _keys.IndexOf(key);

            //check if the index exists
            if (index >= 0)
            {
                //remove key at said index
                _keys.RemoveAt(index);
                //remove value at said index
                _values.RemoveAt(index);
                //lower keycount
                _keycount--;
            }
            else
            {
                //otherwise something went wrong
                Console.WriteLine("Something went wrong.");
            }
        }

        //Method to check if key already exists (private because we only do this in our class)
        private bool ContainsKey(T key)
        {
            //define resultbool default: false
            bool result = false;

            //check for every key in list of keys...
            foreach (T keyFromList in _keys)
            {
                //when the key matches the one in the list
                if (EqualityComparer<T>.Default.Equals(keyFromList, key))
                {
                    //set our result to 'true'
                    result = true;
                }
            }
            //return result
            return result;

            //this is the code that seemed to work too:
            //return _keys.Contains(key);
        }

        //mehtod Values shows all values on screen
        public void Values()
        {
            List<U> listValues = new List<U>();
            if (_values != null)
            {
                foreach (var item in _values)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine("No values found.");
            }

        }
    }

}
