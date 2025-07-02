using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Execution_Of_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                                           // in this place we have step 1
            if (this.txt300.Text == "")
            {
                MessageBox.Show("Memory is empty", "Enter value", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.timer1.Enabled = true; // power on the progressbar when click on button of the start
                
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                                         // step 1 and 2 code in timer place


                    // start 1 step

            this.progressBar1.Value = this.progressBar1.Value + 1;
            this.label21.Text = this.progressBar1.Value + "% ";

            if (this.progressBar1.Value == 100) {
                this.timer1.Enabled = false;
            }
            if(this.progressBar1.Value==5){
                this.txtpc1.Text = this.label2.Text;
            }
            if(this.progressBar1.Value==10){
              this.txtir1.Text = this.txt300.Text;
            }
               if(this.progressBar1.Value==15){
             this.txtac1.Text = "Value Interpreted";
            }
               if (this.progressBar1.Value == 20)
               {
                   this.txt940.Text = "0003";
                   this.txt941.Text = "0002";

                   // end of 1 step 
               }

                                                     // start of the step 2

               if (this.progressBar1.Value == 25)
               {
                   this.txt300s.Text = this.txt300.Text;
                   this.txt301s.Text = this.txt301.Text;
                   this.txt302s.Text = this.txt302.Text;
                   this.txtirs.Text = this.txt300.Text;
               }

               if (this.progressBar1.Value ==28)
               {
                   this.txtpc2.Text = this.label17.Text;
               }
              
            if (this.progressBar1.Value == 30)
               {
                   this.txt940s.Text = "0003";
                   this.txt941s.Text = "0002";
               }
            if (this.progressBar1.Value == 35) {

                this.txtacs.Text = "0003";
                // end of the step 2
            }

                                               // step 3 and 4 code in timer place

            // start of the step 3
            if (this.progressBar1.Value == 38)
            {
                this.txt300t.Text = this.txt300.Text;
                this.txt301t.Text = this.txt301.Text;
                this.txt302t.Text = this.txt302.Text;
                this.txtpc3.Text = this.label40.Text;
            }
            if (this.progressBar1.Value == 40)
            {
                this.txtir3.Text = this.txt301t.Text;
            }
            if (this.progressBar1.Value == 45)
            {
                this.txtac3.Text = "0003";
            }
            if (this.progressBar1.Value == 48)
            {
                this.txt940t.Text = "0003";
                this.txt941t.Text = "0002";

                // end of 3 step 
            }

            // start of the step 4

            if (this.progressBar1.Value == 50)
            {
                this.txt300f.Text = this.txt300.Text;
                this.txt301f.Text = this.txt301.Text;
                this.txt302f.Text = this.txt302.Text;
                this.txtir4.Text = this.txt301.Text;
            }

            if (this.progressBar1.Value == 53)
            {
                this.txtpc4.Text = this.label41.Text;
            }

            if (this.progressBar1.Value == 57)
            {
                this.txt940f.Text = "0003";
                this.txt941f.Text = "0002";
            }
            if (this.progressBar1.Value == 60)
            {

                this.txtac4.Text = "0005";
                // end of the step 4
            }
                                                 // step 5 and 6 code in timer place

                                          // start of the step 5
            if (this.progressBar1.Value == 65)
            {
                this.txt300ff.Text = this.txt300.Text;
                this.txt301ff.Text = this.txt301.Text;
                this.txt302ff.Text = this.txt302.Text;
                this.txtpc5.Text = this.label3.Text;
            }
            if (this.progressBar1.Value == 70)
            {
                this.txtir5.Text = this.txt301.Text;
            }
            if (this.progressBar1.Value == 75)
            {
                this.txtac5.Text = "0005";
            }
            if (this.progressBar1.Value == 80)
            {
                this.txt940ff.Text = "0003";
                this.txt941ff.Text = "0002";

                // end of 5 step 
            }

            // start of the step 6

            if (this.progressBar1.Value == 83)
            {
                this.txt300si.Text = this.txt300.Text;
                this.txt301si.Text = this.txt301.Text;
                this.txt302si.Text = this.txt302.Text;
                this.txtir6.Text = this.txt302.Text;
            }

            if (this.progressBar1.Value == 85)
            {
                this.txtpc6.Text ="303";
            }

            if (this.progressBar1.Value == 88)
            {
                this.txt940si.Text = "0003";
                this.txt941si.Text = "0005";
            }
            if (this.progressBar1.Value == 90)
            {

                this.txtac6.Text = "0005";
                // end of the step 6
            }


            if (this.progressBar1.Value == 100) {
                this.progressBar1.Visible = false;
                MessageBox.Show("All Steps are completed", "Completed", MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.label21.Text = "Completed";
            }
                          






        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
             
               
        }

        private void txt300t_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
