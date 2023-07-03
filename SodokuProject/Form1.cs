namespace SodokuProject
{
    public partial class Form1 : Form
    {
        const int n = 3;
        const int sizeBtn = 50;
        public int[,] map = new int[n * n, n * n];
        public Button[,] button = new Button[n * n, n * n];
        public Form1()
        {
            InitializeComponent();
            GenerateMap();
        }
        public void GenerateMap()
        {
            for (int i = 0; i < n * n; i++)
            {
                for (int j = 0; j < n * n; j++)
                {
                    map[i, j] = (i * n + i / n + j) % (n * n) + 1;
                    button[i, j] = new Button();
                }
            }
            Random r = new Random();
            Randm(r.Next(0, 3));
            SwapColumn();
            SwapRow();
            Matrix();
            CreatMap();
            Hidding();
        }
        public void Hidding()
        {
            int N = 30;
            Random r = new Random();

            for (int i = 0; i < n * n; i++)
            {
                for (int j = 0; j < n * n; j++)
                {

                    int b = r.Next(0, n);
                    button[i, j].Text = b == 0 ? "" : button[i, j].Text;
                    button[i, j].Enabled = b == 0 ? true : false;
                    button[i, j].BackColor = b == 0 ? Color.White : Color.SeaShell;


                }
            }


        }
        public void Randm(int i)
        {
            switch (i)
            {
                case 0:
                    Matrix();
                    break;
                case 1:
                    SwapRow();
                    break;
                case 2:
                    SwapColumn();
                    break;
            }

        }
        public void SwapColumn()
        {
            Random r = new Random();
            var block = r.Next(0, n);
            var row1 = r.Next(0, n);
            var line1 = block * n + row1;
            var row2 = r.Next(0, n);
            while (row1 == row2)
            {
                row2 = r.Next(0, n);
            }
            var line2 = block * n + row2;
            for (int i = 0; i < n * n; i++)
            {
                var temp = map[i, line1];
                map[i, line1] = map[i, line2];
                map[i, line2] = temp;
            }
        }
        public void SwapRow()
        {
            Random r = new Random();
            var block = r.Next(0, n);
            var row1 = r.Next(0, n);
            var line1 = block * n + row1;
            var row2 = r.Next(0, n);
            while (row1 == row2)
            {
                row2 = r.Next(0, n);
            }
            var line2 = block * n + row2;
            for (int i = 0; i < n * n; i++)
            {
                var temp = map[line1, i];
                map[line1, i] = map[line2, i];
                map[line2, i] = temp;
            }
        }
        public void Matrix()
        {
            int[,] tmap = new int[n * n, n * n];
            for (int i = 0; i < n * n; i++)
            {
                for (int j = 0; j < n * n; j++)
                {
                    tmap[i, j] = map[j, i];
                }
            }
            map = tmap;
        }
        public void CreatMap()
        {
            for (int i = 0; i < n * n; i++)
            {
                for (int j = 0; j < n * n; j++)
                {
                    Button btn = new Button();
                    button[i, j] = btn;
                    btn.Size = new Size(sizeBtn, sizeBtn);
                    btn.Text = map[i, j].ToString();
                    btn.Location = new Point(i * sizeBtn, j * sizeBtn);
                    btn.Click += OnPress;
                    this.Controls.Add(btn);
                }
            }
        }
        public void OnPress(object sender, EventArgs e)
        {
            Button pressedButton = sender as Button;
            string buttonText = pressedButton.Text;
            if (string.IsNullOrEmpty(buttonText))
            {
                pressedButton.Text = "1";
            }
            else
            {
                int num = int.Parse(buttonText);
                num++;
                if (num == 10)
                    num = 1;
                pressedButton.Text = num.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int k = 0;
            for (int i = 0; i < n * n; i++)
            {
                for (int j = 0; j < n * n; j++)
                {
                    var btnText = button[i, j].Text;
                    if (btnText != map[i, j].ToString())
                    {
                        k++;
                    }
                }
            }
            if (k < 1)
            {
                MessageBox.Show("That's True!._.");
            }
            else
            {
                MessageBox.Show("That's False!.-.");
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n * n; i++)
            {
                for (int j = 0; j < n * n; j++)
                {
                    this.Controls.Remove(button[i, j]);
                }
            }
            GenerateMap();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n * n; i++)
            {
                for (int j = 0; j < n * n; j++)
                {


                }
            }
        }
    }
}