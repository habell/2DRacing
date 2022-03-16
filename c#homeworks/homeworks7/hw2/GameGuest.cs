using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    class GameGuest
    {
        public delegate void Act(string message);
        public delegate void UpdateInfo();
        public event Act CountEnded;
        public event UpdateInfo updateInfo;
        private int Number { get; set; }
        public int counter { get; private set; }

        public int attemotCount { get; private set; }

        public GameGuest(int min=1, int max=100)
        {
            Number = new Random().Next(min, max + 1);
            attemotCount = (int)Math.Log2(max - min + 1) + 1;
            counter = 0;
            //updateInfo?.Invoke();
        }

        public string Attempt(int n)
        {
            if (attemotCount <= counter)
            {
                CountEnded?.Invoke("Закончились попытки.");
                return "Закончились попытки";
            }
            string s = "";
            if (Comparer(n) == 0) s = "УГАДАЛИ!";
            if (Comparer(n) > 0) s = "Больше";
            if (Comparer(n) < 0) s = "Меньше";
            CountEnded?.Invoke(s);
            counter++;
            updateInfo?.Invoke();
            return s;
        }
        private int Comparer(int n)
        {
            return Number - n;
        }

    }
}
