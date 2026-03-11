using System;

namespace saleAndBillingSystem
{
    // 5. Observer Pattern: Used to manage a one-to-many dependency so that when 
    // one object changes state (e.g., a Sale is made), all its dependents are notified
    // and updated automatically (e.g., the Sales dashboard/list refreshes).
    public class EventAggregator
    {
        private static EventAggregator _instance;
        private static readonly object _lock = new object();

        // Singleton implementation for the event bus
        public static EventAggregator Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new EventAggregator();
                    }
                    return _instance;
                }
            }
        }

        // Define the event
        public event EventHandler OnSaleMade;

        // Method to publish the event
        public void PublishSaleMade()
        {
            OnSaleMade?.Invoke(this, EventArgs.Empty);
        }
    }
}
