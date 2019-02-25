using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace RSSFeeder
{
    class ProgressManager
    {
        private bool _cancelled = false;

        public void Cancel()
        {
            _cancelled = true;
        }

        public void Work()
        {
            for (int i = 0; i < 100; i++)
            {
                if (_cancelled)
                    break;
                Thread.Sleep(50);
                ProgressChanged(i);
            }
            WorkCompleted(_cancelled);
        }

        public event Action<int> ProgressChanged;
        public event Action<bool> WorkCompleted;
    }
}
