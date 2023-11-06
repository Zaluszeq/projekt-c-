using System;
using System.Net;

namespace AiSD_io4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        int[] Generate(int x)
        {
            var liczby = new int[x];
            for (int i = 0; i < x; i++)
            {
                Random rnd = new Random();
                liczby[i] = rnd.Next(1,x);
            }
            return liczby;
        }
        int[] Convert(string napis)
        {
            var liczbyS = napis.Trim().Split(' ');
            var liczby = new int[liczbyS.Length];
            for (int i = 0; i < liczbyS.Length; i++)
            {
                liczby[i] = int.Parse(liczbyS[i]);
            }
            return liczby;
        }

        int[] BubbleSort(int[] napis)
        {
            var n = napis.Length;
            bool zmiana = true;
            if (zmiana == true)
            {
                for (int i = 0; i < napis.Length - 1; i++)
                {
                    if (napis[i] < napis[i + 1])
                    {
                        int temp = napis[i];
                        napis[i] = napis[i + 1];
                        napis[i + 1] = temp;
                        zmiana = true;
                    }
                    else
                    {
                        zmiana = false;
                    }
                }
            }
            return napis;
        }

        int[] SelectSort(int[] napis)
        {
            for (int i = 0; i < napis.Length - 1; i++)
            {
                int min = i;
                for (int j = i++; j < napis.Length; j++)
                {
                    if (napis[j] < napis[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    int temp = napis[i];
                    napis[i] = napis[min];
                    napis[min] = temp;
                }
            }
            return napis;
        }

        int[] InsertSort(int[] napis)
        {
            for (int i = 1; i < napis.Length; i++)
            {
                var x = 0;
                for (int j = i - 1; j >= 0 && x != 1;)
                {
                    if (x < napis[j])
                    {
                        napis[j + 1] = napis[j];
                        j--;
                        napis[j + 1] = x;
                    }
                    else x = 1;
                }
            }
            return napis;
        }

        int[] MergeSort(int[] napis)
        {
            int[] lewo;
            int[] prawo;
            int srodek = napis.Length / 2;
            lewo = new int[srodek];
            if (napis.Length % 2 == 0)
            {
                prawo = new int[srodek];
            }
            else
            {
                prawo = new int[srodek + 1];
            }
            for (int i = 0; i < srodek; i++)
            {
                lewo[i] = napis[i];
            }
            int x = 0;
            for (int i = srodek; i < napis.Length; i++)
            {
                prawo[x] = napis[i];
                x++;
            }
            lewo = MergeSort(lewo);
            prawo = MergeSort(prawo);
            napis = merge(lewo, prawo);
            return napis;
        }
        public static int[] merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];
            int indexLeft = 0, indexRight = 0, indexResult = 0;
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }
        int[] QuickSort(int[] napis, int x, int y)
        {
            int lewo = x;
            int prawo = y;
            var srodek = napis[(lewo + prawo) / 2];
            while (lewo < prawo)
            {
                while (napis[lewo] < srodek)
                {
                    lewo++;
                }
                while (napis[j] > srodek)
                {
                    prawo--;
                }
                if (lewo <= prawo)
                {
                    int temp = napis[prawo];
                    napis[prawo] = napis[lewo];
                    napis[lewo] = temp;
                    lewo++;
                    prawo--;
                }
                if (lewo < y)
                    SortArray(napis, lewo, y);
                if (x < rightIndex)
                    SortArray(napis, x, prawo);
                return napis;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void SB_Click_1(object sender, EventArgs e)
        {

        }

        private void SS_Click(object sender, EventArgs e)
        {

        }

        private void SI_Click(object sender, EventArgs e)
        {

        }

        private void SQ_Click(object sender, EventArgs e)
        {

        }
    }
}