namespace ForDifferent.Interfaces
{
    interface ISystem
    {
        public bool GetRunningState();
        public void Start();
        public void Stop();
    }
}
