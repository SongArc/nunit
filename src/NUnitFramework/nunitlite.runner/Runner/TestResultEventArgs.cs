using System;

namespace NUnitLite.Runner
{
    public class TestResultEventArgs : EventArgs
    {
        public string Result { get; private set; }

        public TestResultEventArgs(string result)
        {
            this.Result = result;
        }
    }
}