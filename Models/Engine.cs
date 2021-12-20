namespace ForDifferent.Models
{
    abstract class Engine
    {
        public bool IsRunning { get { return _isRunning; } }
        private bool _isRunning = false;
        public virtual void Start()
        {
            _isRunning = true;
        }
        public virtual void Stop()
        {
            _isRunning = false;
        }

        //public abstract void Start();
        //public abstract void Stop();
    }
}
