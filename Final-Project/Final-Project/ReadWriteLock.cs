using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Final_Project
{
    public class ReadWriteLock
    {
        private int waitingForReadLock = 0;
        private int outstandingReadLocks = 0;

        private Thread writeLockedThread;

        private List<Thread> waitingForWriteLock = new List<Thread>();

        public void ReadLock()
        {
          if  (writeLockedThread != null) 
          {
               waitingForReadLock++;
               while (writeLockedThread != null) 
               {
                    Monitor.Wait(writeLockedThread);
               }
               waitingForReadLock--;
          }
          outstandingReadLocks++;
        }

        public void writeLock()
        {
            Thread thisThread;
            lock (this) 
            {
                if (writeLockedThread == null && outstandingReadLocks == 0)
                {
                    writeLockedThread = Thread.CurrentThread;
                    return;
                }
                thisThread = Thread.CurrentThread;
                waitingForWriteLock.Add(thisThread);
            }
            lock (thisThread) 
            {
                while (thisThread != writeLockedThread)
                {
                    Monitor.Wait(thisThread);
                }
            }
            lock (this) 
            {
                waitingForWriteLock.Remove(thisThread);
            }
        }

        public void done()
        {
            if (outstandingReadLocks > 0)
            {
                outstandingReadLocks--;
                if (outstandingReadLocks == 0 && waitingForWriteLock.Count > 0)
                {
                    writeLockedThread = (Thread)waitingForWriteLock[0];
                    lock (writeLockedThread)
                    {
                        Monitor.PulseAll(writeLockedThread);
                    }
                }
            }
            else if (Thread.CurrentThread == writeLockedThread)
            {
                if (outstandingReadLocks == 0 && waitingForWriteLock.Count > 0)
                {
                    writeLockedThread = (Thread)waitingForWriteLock[0];
                    lock (writeLockedThread)
                    {
                        Monitor.PulseAll(writeLockedThread);
                    }
                }
            }
            else
            {
                writeLockedThread = null;
                if (waitingForReadLock > 0)
                {
                    Monitor.PulseAll(writeLockedThread);
                }
                else
                {
                    throw new Exception("Thread does not have lock");
                }
            }
        }
    }
}
