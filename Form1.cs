namespace create_buttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int a = 0; a <= 5; a++)
            {
                Button btn = new Button();
                btn.Name = "btn" + a;
                btn.Text = "Button" + a;
                btn.Location = new Point(10, a * 25);
                this.Controls.Add(btn);
                btn.Click += new EventHandler(btn_click);

            }
        }
        private void btn_click(object sender,EventArgs e)
        {
            Control ctrl = (Control)sender;
            MessageBox.Show(ctrl.Text);
        }
    }
}