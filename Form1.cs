namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            CreateBtns();
            Width = 500;
            Height = 350;
        }

        int posH = 0;
        int posV = 0;
        int choice = 0;
        public void CreateBtns(int count = 3)
        {


            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    if (i == 1 && j == 0)
                    {

                        posH = 0;
                        posV = 100;
                    }
                    if (i == 2 && j == 0)
                    {
                        posH = 0;
                        posV = 200;
                    }

                    this.Controls.Add(new Button()
                    {
                        Text = $"������ ����)",
                        BackColor = Color.Black,
                        ForeColor = Color.Wheat,
                        Location = new Point(posH += 100, posV),
                        Height = 100,
                        Width = 100,
                        Name = $"btn_{i.ToString()}_{j.ToString()}"
                        

                    });
                    this.Controls[this.Controls.Count - 1].Click += (sender, e) =>
                    {
                        //MessageBox.Show((sender as Button).Name);
                        if (choice % 2 == 0 && (sender as Button).Text == "������ ����)")
                        {
                            (sender as Button).BackColor = Color.Green;
                            (sender as Button).ForeColor = Color.Black;
                            (sender as Button).Text = "X";
                            choice++;
                        }
                        else if (choice % 2 == 1 && (sender as Button).Text == "������ ����)")
                        {
                            (sender as Button).BackColor = Color.Yellow;
                            (sender as Button).ForeColor = Color.Black;
                            (sender as Button).Text = "O";
                            choice++;
                        }
                       
                    };
                    
                }
            }



        }
        private void btn_click(object? sender, EventArgs e)
        {
            Button btn = sender as Button;

            if ((btn.Name == "btn_0_0" && btn.Text == "X") && (btn.Name == "btn_0_1" && btn.Text == "X") && (btn.Name == "btn_0_2" && btn.Text == "X"))
            {
                MessageBox.Show($"X - WIN");

            }
            if (btn.Name == "btn_1_0" && btn.Name == "btn_1_1" && btn.Name == "btn_1_2" && btn.Text == "X")
            {
                MessageBox.Show($"X - WIN");

            }
            if ((sender as Button).Text == "X" && (sender as Button).Text == "X" && (sender as Button).Text == "X")
            {
                this.Text = "X - win";

            }

        }
    }
}