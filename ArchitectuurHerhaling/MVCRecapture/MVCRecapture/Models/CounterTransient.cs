namespace MVCRecapture.Models
{
    public class CounterTransient
    {
        private CounterScoped _counterScoped;
       public CounterTransient (CounterScoped counterScoped)
            {
            _counterScoped = counterScoped;
            _counterScoped.Count++;
            }
        public CounterTransient() { }
        public int Count { get; set; }

    }
}
