namespace Quinones_TicTactoe_BSCOE_1_4
{
    public partial class Form1 : Form
    {
        bool turn = true; //true = X turn; false = Y turn
        int turn_count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aBOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lOADToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void oPTIONSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BY EMMANUEL JOHN F. QUINONES");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            turn_count++;
            checkForWinnner();
        }
        private void checkForWinnner()
        {
            bool we_have_a_chaampion = false;
            //horizontal checks
            if ((Q1.Text == Q2.Text) && (Q2.Text == Q3.Text) && (!Q1.Enabled))
                we_have_a_chaampion = true;
            else if ((L1.Text == L2.Text) && (L2.Text == L3.Text) && (!L1.Enabled))
                we_have_a_chaampion = true;
            else if ((G1.Text == G2.Text) && (G2.Text == G3.Text) && (!G1.Enabled))
                we_have_a_chaampion = true;
            //vertical checks
            if ((Q1.Text == L1.Text) && (L1.Text == G1.Text) && (!Q1.Enabled))
                we_have_a_chaampion = true;
            else if ((Q2.Text == L2.Text) && (L2.Text == G2.Text) && (!Q2.Enabled))
                we_have_a_chaampion = true;
            else if ((Q3.Text == L3.Text) && (L3.Text == G3.Text) && (!Q3.Enabled))
                we_have_a_chaampion = true;
            //diagonal checks
            if ((Q1.Text == L2.Text) && (L2.Text == G3.Text) && (!Q1.Enabled))
                we_have_a_chaampion = true;
            if ((G3.Text == L2.Text) && (L2.Text == Q1.Text) && (!G1.Enabled))
                we_have_a_chaampion = true;
            if (we_have_a_chaampion)
            {
                dissablebuttons();

                string winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show(winner + " wins!", "Great Job");
            }//end if
            else
            {
                if (turn_count == 9)
                    MessageBox.Show("Draw!", "better luck next time");
            }
        }//end checkForWinner
        private void dissablebuttons()
        {
            try
            { 
            foreach (Control c in Controls)
            {
                Button b = (Button)c;
                b.Enabled = false;
            }//end foreach
        }//end try
        catch{}
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;    
            turn_count = 0;
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }//end foreach
            }//end try
            catch {}    
        }

        private void optionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}