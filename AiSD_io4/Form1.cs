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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int[] Convert(string napis)
        {
            var liczbyS = napis.Trim().Split('');
            var liczby = new int[liczbyS.Length];
            for (int i = 0; i < liczbyS.Length; i++)
            {
                liczby[i] = int.Parse(liczbyS[i]);
            }
            return liczby;
        }

        int[] BubbleSort(int[] napis) {
            var n = napis.Length;
            bool zmiana = true;
            if(zmiana == true){
                for (int i = 0; i < napis.Length-1; i++)
                {
                    if (napis[i] < napis[i++])
                    {
                        int temp = napis[i];
                        napis[i] = napis[i++];
                        napis[i++] = temp;
                        zmiana = true;
                    }
                    else
                    {
                        zmiana = false;
                    }
                }
            }
            
        }

        int[] SelectSort(int[] napis)
        {
            for(int i = 0; i < napis.Length-1; i++)
            {
                int min = i;
                for(int j = i++; j < napis.Length; j++)
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
        }

        int[] InsertSort(int[] napis)
        {
            for(int i = 0; i < napis.Length-1; i++)
            {
                for(int j=0; j < napis.Length-1; j-- && napis[j] > napis[j-1])
                {

                }
            }
        }

        int[] MergeSort(int[] napis)
        {

        }

        int[] QuickSort(int[] napis)
        {

        }
    }
}