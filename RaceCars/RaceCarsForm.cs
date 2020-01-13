using RaceCars.Business.AllPunters;
using System;
using System.Windows.Forms;

namespace RaceCars
{
    public partial class RaceCarsForm : Form
    {
        //instantiate an array of punters and fighters
        private F1[] f1 = new F1[4];
        private string winner;

        Punter[] myPunter = new Punter[3];
        Punter singlePunter = new Matt();


        public RaceCarsForm()
        {
            InitializeComponent();
            f1[0] = new F1() { Distance = 0, myPB = pb1, Name = "Alfa Romeo" };
            f1[0].myPB.BackgroundImage = Resource1.alfa_romeo_f1;
            //bind the picturebox to the image
            f1[1] = new F1() { Distance = 0, myPB = pb2, Name = "Ferrari" };
            f1[1].myPB.BackgroundImage = Resource1.ferrari_f1;
            f1[2] = new F1() { Distance = 0, myPB = pb3, Name = "Infiniti" };
            f1[2].myPB.BackgroundImage = Resource1.infiniti_f1;
            f1[3] = new F1() { Distance = 0, myPB = pb4, Name = "Mclaren" };
            f1[3].myPB.BackgroundImage = Resource1.mclaren_f1;



            SetUpThePunters();
        }

        public void SetUpThePunters()
        {
            for (int i = 0; i < 3; i++)
            {
                myPunter[i] = Factory.GetAPunter(i);
                myPunter[i].LabelWinner = lblWinner;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            RunRace();
        }

        private void RunRace()
        {
            var myrnd = new Random();
            bool end = false;

            while (end != true)
            {
                int Distance = RaceCarsForm.ActiveForm.Width - pb1.Width;

                for (int i = 0; i < 4; i++)
                {
                    Application.DoEvents();



                    f1[i].myPB.Left += myrnd.Next(1, 5);

                    if (f1[i].myPB.Left > Distance)
                    {
                        end = true;
                        winner = f1[i].Name;
                        this.Text = winner + " " + i.ToString();
                        FindTheWinner();
                    }
                }


            }
        }



        private void FindTheWinner()
        {
            lblWinner.Text = string.Empty;
            for (int i = 0; i < 3; i++)
            {
                if (f1[i].Name == winner)
                {
                    myPunter[i].Cash += myPunter[i].Bet;

                    lblCar.Text = winner;


                    myPunter[i].LabelWinner.Text += winner + " and " + myPunter[i].PunterName + " Won and now has " + myPunter[i].Cash;


                }
                else
                {
                    myPunter[i].Cash -= myPunter[i].Bet;
                    myPunter[i].LabelWinner.Text += " " + myPunter[i].PunterName + " lost and now has " +
                        myPunter[i].Cash + " ";
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                f1[i].myPB.Left = 33;

                winner = "The race is over";
                txtClark.Text = String.Empty;
                txtMatt.Text = String.Empty;
                txtZoe.Text = String.Empty;
                myPunter[0].Cash += myPunter[0].Bet;
                myPunter[1].Cash += myPunter[1].Bet;
                myPunter[2].Cash += myPunter[2].Bet;
                //this.Text = winner;
            }
        }

        private void btnBets_Click(object sender, EventArgs e)
        //set some values for the bettors
        //   txtMatt.Text = singlePunter.Bet;
        {

            if (singlePunter.PunterName == "Matt")
            {


                myPunter[0].Bet = singlePunter.Bet;
                myPunter[0].F1 = singlePunter.F1;
                myPunter[0].Cash = singlePunter.Cash;


                lblBettorName.Text = singlePunter.PunterName + " has " + myPunter[0].Cash;
                txtMatt.Text = "My name is " + singlePunter.PunterName + " and I have $" + myPunter[0].Cash + " to waste on the Races. And I bet " + myPunter[0].Bet + " on the " + myPunter[0].F1;

            }
            else if (singlePunter.PunterName == "Clark")
            {
                myPunter[1].Bet = singlePunter.Bet;
                myPunter[1].F1 = singlePunter.F1;
                myPunter[1].Cash = singlePunter.Cash;


                lblBettorName.Text = singlePunter.PunterName + " has " + myPunter[1].Cash;
                txtClark.Text = "My name is " + singlePunter.PunterName + " and I have $" + myPunter[1].Cash + " to waste on the Races. And I bet " + myPunter[1].Bet + " on the " + myPunter[1].F1;

            }

            else if (singlePunter.PunterName == "Zoe")
            {
                myPunter[2].Bet = singlePunter.Bet;
                myPunter[2].F1 = singlePunter.F1;
                myPunter[2].Cash = singlePunter.Cash;
                //  myPunter[2].Cash += myPunter[2].Bet;

                lblBettorName.Text = singlePunter.PunterName + " has " + myPunter[2].Cash;
                txtZoe.Text = "My name is " + singlePunter.PunterName + " and I have $" + myPunter[2].Cash + " to waste on the Races. And I bet " + myPunter[2].Bet + " on the " + myPunter[2].F1;

            }
            return;
        }



        private void Allrb_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton fakerb = new RadioButton();
            fakerb = (RadioButton)sender;
            if (fakerb.Checked == true)
            {
                switch (fakerb.Text)
                {
                    case "Matt":
                        singlePunter = Factory.GetAPunter(0);


                        break;

                    case "Clark":
                        singlePunter = Factory.GetAPunter(1);

                        break;
                    case "Zoe":
                        singlePunter = Factory.GetAPunter(2);

                        break;
                }


            }

        }



        private void udBet_ValueChanged_1(object sender, EventArgs e)
        {

            singlePunter.Bet = (float)udBet.Value;

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            singlePunter.F1 = cbxCar.SelectedItem.ToString();
            SinglePunterSetup();
        }


        public void SinglePunterSetup()
        {
            udBet.Maximum = (decimal)singlePunter.Cash;
            udBet.Value = (decimal)singlePunter.Bet;
            SinglePunterCheckForBetValue();
        }



        private void SinglePunterCheckForBetValue()
        {
            //set the value of the bed the person has made
            singlePunter.Bet = (float)udBet.Value;




        }



        private void rbMatt_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblBettorName_Click(object sender, EventArgs e)
        {

        }
    }

}
