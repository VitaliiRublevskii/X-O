namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            CreateBtns();
        }

       
        private void CreateBtns(int count = 3)
        {
            int posH = 0;
            int posV = 0;
            int choice = 0;

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                   if (i == 1 && j == 0)
                    {

                        posH =0;
                        posV = 100;
                    }
                    if (i == 2 && j == 0)
                    {
                        posH  = 0;
                        posV = 200;
                    }

                    this.Controls.Add(new Button()
                    {
                        Text = $"выбери меня)",
                        BackColor = Color.Black,
                        ForeColor = Color.Wheat,
                        Location = new Point(posH +=100, posV),
                        Height = 100,
                        Width = 100,
                        
                    });
                    this.Controls[this.Controls.Count - 1].Click += (sender, e) =>
                    {
                        if (choice % 2 == 0 && (sender as Button).Text == "выбери меня)")
                        {
                            (sender as Button).BackColor = Color.Green;
                            (sender as Button).ForeColor = Color.Black;
                            (sender as Button).Text = "X";
                            choice++;
                        }
                        else if (choice % 2 == 1 && (sender as Button).Text == "выбери меня)")
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

    }
}