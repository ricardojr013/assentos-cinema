namespace TP04
{
    public partial class Form1 : Form
    {
        Button []b = new Button [200];
        private int cont = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            const int linhas = 10;
            const int colunas = 20;
            const int largura = 40;
            const int altura = 40;
            const int padding = 17;

            char rowLabel = 'A';

            for (int row = 0; row < linhas; row++)
            {
                for(int col = 0; col < colunas; col++)
                {
                    Button button = new Button ();
                    button.BackColor = Color.Green;
                    button.Text = $"{rowLabel}{col + 1}";
                    button.Width = largura;
                    button.Height = altura;
                    button.Left = padding + col * (largura + padding);
                    button.Top = padding + row * (largura + padding);
                    button.Click += new EventHandler(this.ai);

                    Controls.Add (button);
                }
                rowLabel++;
            }

        }

        private void ai(object sender, EventArgs e)
        {
            Button aux = (Button)sender;

            DialogResult result = MessageBox.Show("Deseja Reservar este assento?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(result == DialogResult.Yes)
            {
                aux.BackColor = Color.Red;
                cont++;
            }
            else
            {
                aux.BackColor = Color.Green;
                cont--;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = cont * 20;
            MessageBox.Show("Faturou R$" + total + ",00");
        }
    }
}