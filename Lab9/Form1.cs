
using System.Diagnostics;
using System.Threading;
namespace Lab9
{
    public partial class Form1 : Form
    {
        private Thread th1;
        private Thread th2;
        private Thread th3;


        long counter = 1;

        private object monitorObject = new object();
        private Mutex mutexObject = new Mutex();

        private Semaphore semaphoreObject = new Semaphore(0, 2);

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        // no sencronization
        public void DegerArtir1()
        {
            for (int i = 1; i <= 100; i++)
            {
                progressBar1.Value += 1;
                listBox1.Items.Add("Thread 1 Çalýþtý!");
                Thread.Sleep(10); //thread uyutma 
            }
        }

        public void DegerArtir2()
        {
            for (int j = 1; j <= 100; j++)
            {
                progressBar2.Value += 1;
                listBox1.Items.Add("Thread 2 Çalýþtý!");
                Thread.Sleep(100); //thread uyutma 
            }
        }

        public void DegerArtir3()
        {
            for (int k = 1; k <= 100; k++)
            {
                progressBar3.Value += 1;
                listBox1.Items.Add("Thread 3 Çalýþtý!");
                Thread.Sleep(150); //thread uyutma 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            th1 = new Thread(new ThreadStart(DegerArtir1));
            th2 = new Thread(new ThreadStart(DegerArtir2));
            th3 = new Thread(new ThreadStart(DegerArtir3));

            th1.Start();
            th2.Start();
            th3.Start();
        }

        //Inter Lock

        public void DegerArtirInterLock1()
        {
            try
            {
                while (counter <= 300)
                {
                    Interlocked.Increment(ref counter);
                    progressBar1.Value += 1;
                    listBox1.Items.Add("Thread 1 Çalýþtý!");
                    Thread.Sleep(80);
                }

            }
            catch { }
        }

        public void DegerArtirInterLock2()
        {
            try
            {
                while (counter <= 300)
                {
                    Interlocked.Increment(ref counter);
                    progressBar2.Value += 1;
                    listBox1.Items.Add("Thread 2 Çalýþtý!");
                    Thread.Sleep(80);
                }

            }
            catch { }
        }

        public void DegerArtirInterLock3()
        {
            try
            {
                while (counter <= 300)
                {
                    Interlocked.Increment(ref counter);
                    progressBar3.Value += 1;
                    listBox1.Items.Add("Thread 3 Çalýþtý!");
                    Thread.Sleep(80);
                }

            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            th1 = new Thread(new ThreadStart(DegerArtirInterLock1));
            th2 = new Thread(new ThreadStart(DegerArtirInterLock2));
            th3 = new Thread(new ThreadStart(DegerArtirInterLock3));

            th1.Start();
            th2.Start();
            th3.Start();

        }

        //Monitor

        public void DegerArtirMonitor1()
        {
            for (int i = 1; i <= 100; i++)
            {
                try
                {
                    Monitor.Enter(monitorObject);
                    progressBar1.Value += 1;
                    listBox1.Items.Add("Thread 1 Çalýþtý!");
                    Thread.Sleep(10);
                    Monitor.Pulse(monitorObject); // kilidi serbest birakacak
                }
                finally
                {
                    Monitor.Exit(monitorObject); // kilidi saldý
                }
            }
        }

        public void DegerArtirMonitor2()
        {
            for (int i = 1; i <= 100; i++)
            {
                try
                {
                    Monitor.Enter(monitorObject);
                    progressBar2.Value += 1;
                    listBox1.Items.Add("Thread 2 Çalýþtý!");
                    Thread.Sleep(100);
                    Monitor.Pulse(monitorObject); // kilidi serbest birakacak
                }
                finally
                {
                    Monitor.Exit(monitorObject); // kilidi saldý
                }
            }
        }

        public void DegerArtirMonitor3()
        {
            for (int i = 1; i <= 100; i++)
            {
                try
                {
                    Monitor.Enter(monitorObject);
                    progressBar3.Value += 1;
                    listBox1.Items.Add("Thread 3 Çalýþtý!");
                    Thread.Sleep(150);
                    Monitor.Pulse(monitorObject); // kilidi serbest birakacak
                }
                finally
                {
                    Monitor.Exit(monitorObject); // kilidi saldý
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            th1 = new Thread(new ThreadStart(DegerArtirMonitor1));
            th2 = new Thread(new ThreadStart(DegerArtirMonitor2));
            th3 = new Thread(new ThreadStart(DegerArtirMonitor3));

            th1.Start();
            th2.Start();
            th3.Start();
        }

        //Mutex
        public void DegerArtirMutex1()
        {
            for (int i = 1; i <= 100; i++)
            {
                mutexObject.WaitOne();
                progressBar1.Value += 1;
                listBox1.Items.Add("Thread 1 Çalýþtý!");
                Thread.Sleep(10);
                mutexObject.ReleaseMutex();
            }
        }

        public void DegerArtirMutex2()
        {
            for (int j = 1; j <= 100; j++)
            {
                mutexObject.WaitOne();
                progressBar2.Value += 1;
                listBox1.Items.Add("Thread 2 Çalýþtý!");
                Thread.Sleep(100);
                mutexObject.ReleaseMutex();
            }
        }

        public void DegerArtirMutex3()
        {
            for (int k = 1; k <= 100; k++)
            {
                mutexObject.WaitOne();
                progressBar3.Value += 1;
                listBox1.Items.Add("Thread 3 Çalýþtý!");
                Thread.Sleep(150);
                mutexObject.ReleaseMutex();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            th1 = new Thread(new ThreadStart(DegerArtirMutex1));
            th2 = new Thread(new ThreadStart(DegerArtirMutex2));
            th3 = new Thread(new ThreadStart(DegerArtirMutex3));

            th1.Start();
            th2.Start();
            th3.Start();
        }

        // semaphore

        public void DegerArtirSemaphore1()
        {
            for (int i = 1; i <= 100; i++)
            {
                semaphoreObject.WaitOne();
                progressBar1.Value += 1;
                listBox1.Items.Add("Thread 1 Çalýþtý!");
                Thread.Sleep(10);
                semaphoreObject.Release();
            }
        }

        public void DegerArtirSemaphore2()
        {
            for (int j = 1; j <= 100; j++)
            {
                semaphoreObject.WaitOne();
                progressBar2.Value += 1;
                listBox1.Items.Add("Thread 2 Çalýþtý!");
                Thread.Sleep(10);
                semaphoreObject.Release();
            }
        }

        public void DegerArtirSemaphore3()
        {
            for (int k = 1; k <= 100; k++)
            {
                semaphoreObject.WaitOne();
                progressBar3.Value += 1;
                listBox1.Items.Add("Thread 3 Çalýþtý!");
                Thread.Sleep(10);
                semaphoreObject.Release();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            th1 = new Thread(new ThreadStart(DegerArtirSemaphore1));
            th2 = new Thread(new ThreadStart(DegerArtirSemaphore2));
            th3 = new Thread(new ThreadStart(DegerArtirSemaphore3));

            th1.Start();
            th2.Start();
            th3.Start();

            semaphoreObject.Release(2); // 2 threadin çalýþmasýna izin veriyor
        }

        //lock

        public void DegerArtirLock1()
        {
            for (int i = 1; i <= 100; i++)
            {
                lock (this)
                {
                    progressBar1.Value += 1;
                    listBox1.Items.Add("Thread 1 Çalýþtý!");
                    Thread.Sleep(10);
                }
            }
        }

        public void DegerArtirLock2()
        {
            for (int i = 1; i <= 100; i++)
            {
                lock (this)
                {
                    progressBar2.Value += 1;
                    listBox1.Items.Add("Thread 2 Çalýþtý!");
                    Thread.Sleep(10);
                }
            }
        }

        public void DegerArtirLock3()
        {
            for (int i = 1; i <= 100; i++)
            {
                lock (this)
                {
                    progressBar3.Value += 1;
                    listBox1.Items.Add("Thread 3 Çalýþtý!");
                    Thread.Sleep(10);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            th1 = new Thread(new ThreadStart(DegerArtirLock1));
            th2 = new Thread(new ThreadStart(DegerArtirLock2));
            th3 = new Thread(new ThreadStart(DegerArtirLock3));

            th1.Start();
            th2.Start();
            th3.Start();
        }

        //sýfýrlama
        private void button2_Click(object sender, EventArgs e)
        {
            //threadler sonlandýrýlýyor
            th1.Interrupt();
            th2.Interrupt();
            th3.Interrupt();

            //progressbar sýfýrlama
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar3.Value = 0;

            //görüntüleme
            progressBar1.Refresh();
            progressBar2.Refresh();
            progressBar3.Refresh();

            // listbox sýfýrlama
            listBox1.Items.Clear();

            counter = 1; // counter sýfýrlama
        }
    }

}
