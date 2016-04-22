using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdaptiveLinearNeuron
{
    public partial class Adaline : Form
    {
        /// This is the Container for the Class to be evaluated
        int[,] claseTemp = new int[6, 6] {{ 0, 0, 0, 0, 0, 0, },
                                          { 0, 0, 0, 0, 0, 0, },
                                          { 0, 0, 0, 0, 0, 0, },
                                          { 0, 0, 0, 0, 0, 0, },
                                          { 0, 0, 0, 0, 0, 0, },
                                          { 0, 0, 0, 0, 0, 0, }};

        double[] finalWeights = {0,0,0};

        public Adaline()
        {
            InitializeComponent();

            /// Inputs for 5 class
            int[,] clas5InputOne = new int[6, 6] {{ 0, 0, 1, 1, 0, 0, },
                                                  { 0, 0, 1, 0, 0, 0, },
                                                  { 0, 0, 0, 1, 0, 0, },
                                                  { 0, 0, 1, 1, 0, 0, },
                                                  { 0, 0, 0, 0, 0, 0, },
                                                  { 0, 0, 0, 0, 0, 0, }};
              
            int[,] clas5InputTwo = new int[6, 6] {{ 0, 1, 1, 1, 1, 0, },
                                                  { 0, 1, 0, 0, 0, 0, },
                                                  { 0, 1, 1, 1, 0, 0, },
                                                  { 0, 0, 0, 1, 0, 0, },
                                                  { 0, 0, 0, 1, 0, 0, },
                                                  { 1, 1, 1, 1, 0, 0, }};

            int[,] clas5InputThree = new int[6, 6] {{ 0, 1, 1, 1, 0, 0, },
                                                    { 0, 1, 0, 0, 0, 0, },
                                                    { 0, 1, 1, 1, 0, 0, },
                                                    { 0, 0, 0, 1, 0, 0, },
                                                    { 0, 0, 0, 1, 0, 0, },
                                                    { 0, 1, 1, 1, 0, 0, }};
    
            int[,] clas5InputFour = new int[6, 6] {{ 0, 0, 0, 1, 1, 1, },
                                                   { 0, 0, 0, 1, 0, 0, },
                                                   { 0, 0, 0, 1, 1, 0, },
                                                   { 0, 0, 0, 0, 1, 0, },
                                                   { 0, 1, 1, 1, 1, 0, },
                                                   { 0, 0, 0, 0, 0, 0, }};
             
            int[,] clas5InputFive = new int[6, 6] {{ 1, 1, 0, 0, 0, 0, },
                                                   { 1, 0, 0, 0, 0, 0, },
                                                   { 1, 1, 1, 1, 0, 0, },
                                                   { 0, 0, 0, 1, 0, 0, },
                                                   { 1, 1, 1, 1, 0, 0, },
                                                   { 0, 0, 0, 0, 0, 0, }};

            int[,] clas5InputSix = new int[6, 6] {{ 1, 1, 1, 1, 1, 1, },
                                                  { 1, 0, 0, 0, 0, 0, },
                                                  { 1, 1, 1, 1, 1, 1, },
                                                  { 0, 0, 0, 0, 0, 1, },
                                                  { 0, 0, 0, 0, 0, 1, },
                                                  { 1, 1, 1, 1, 1, 1, }};

            int[,] clas5InputSeven = new int[6, 6] {{ 0, 0, 1, 1, 0, 0, },
                                                    { 0, 1, 0, 0, 0, 0, },
                                                    { 0, 1, 1, 0, 0, 0, },
                                                    { 0, 0, 1, 0, 0, 0, },
                                                    { 1, 1, 0, 0, 0, 0, },
                                                    { 0, 0, 0, 0, 0, 0, }};

            int[,] clas5InputEight = new int[6, 6]{ { 0, 0, 0, 0, 0, 0, },
                                                    { 0, 1, 0, 1, 1, 1, },
                                                    { 0, 1, 0, 1, 0, 1, },
                                                    { 0, 1, 0, 1, 0, 1, },
                                                    { 0, 1, 1, 1, 0, 1, },
                                                    { 0, 0, 0, 0, 0, 0, }};

            /// Inputs for 1 class
            int[,] clas1InputOne = new int[6, 6] {{ 0, 0, 0, 1, 0, 0, },
                                                  { 0, 0, 0, 1, 0, 0, },
                                                  { 0, 0, 0, 1, 0, 0, },
                                                  { 0, 0, 0, 1, 0, 0, },
                                                  { 0, 0, 0, 1, 0, 0, },
                                                  { 0, 0, 0, 1, 0, 0, }};

            int[,] clas1InputTwo = new int[6, 6] {{ 0, 0, 1, 1, 0, 0, },
                                                  { 0, 0, 0, 1, 0, 0, },
                                                  { 0, 0, 0, 1, 0, 0, },
                                                  { 0, 0, 0, 1, 0, 0, },
                                                  { 0, 0, 0, 1, 0, 0, },
                                                  { 0, 0, 0, 1, 0, 0, }};

            int[,] clas1InputThree = new int[6, 6] {{ 0, 0, 1, 1, 0, 0, },
                                                    { 0, 0, 0, 1, 0, 0, },
                                                    { 0, 0, 0, 1, 0, 0, },
                                                    { 0, 0, 0, 1, 0, 0, },
                                                    { 0, 0, 0, 1, 0, 0, },
                                                    { 0, 0, 1, 1, 1, 0, }};

            int[,] clas1InputFour = new int[6, 6] {{ 1, 0, 0, 0, 0, 0, },
                                                   { 1, 0, 0, 0, 0, 0, },
                                                   { 1, 0, 0, 0, 0, 0, },
                                                   { 1, 0, 0, 0, 0, 0, },
                                                   { 1, 0, 0, 0, 0, 0, },
                                                   { 1, 0, 0, 0, 0, 0, }};

            int[,] clas1InputFive = new int[6, 6] {{ 0, 0, 0, 0, 0, 0, },
                                                   { 1, 0, 0, 0, 0, 0, },
                                                   { 1, 0, 0, 0, 0, 0, },
                                                   { 1, 0, 0, 0, 0, 0, },
                                                   { 1, 0, 0, 0, 0, 0, },
                                                   { 0, 0, 0, 0, 0, 0, }};

            int[,] clas1InputSix = new int[6, 6] {{ 0, 0, 0, 0, 0, 0, },
                                                  { 0, 0, 0, 0, 0, 0, },
                                                  { 0, 0, 0, 0, 0, 1, },
                                                  { 0, 0, 0, 0, 0, 1, },
                                                  { 0, 0, 0, 0, 0, 1, },
                                                  { 0, 0, 0, 0, 0, 1, }};

            int[,] clas1InputSeven = new int[6, 6] {{ 0, 0, 0, 0, 0, 0, },
                                                    { 0, 0, 0, 0, 0, 0, },
                                                    { 0, 0, 0, 0, 0, 0, },
                                                    { 0, 0, 0, 0, 0, 0, },
                                                    { 0, 0, 0, 0, 1, 0, },
                                                    { 0, 0, 0, 0, 0, 0, }};

            int[,] clas1InputEight = new int[6, 6] {{ 0, 0, 0, 0, 0, 0, },
                                                    { 0, 0, 0, 0, 0, 0, },
                                                    { 0, 0, 0, 0, 0, 0, },
                                                    { 0, 1, 1, 1, 0, 0, },
                                                    { 0, 0, 0, 0, 0, 0, },
                                                    { 0, 0, 0, 0, 0, 0, }};


        
            int[,] input = new int[,] { { 12, 15 }, 
                                        { jumpsXaxis(clas5InputTwo), jumpsYaxis(clas5InputTwo) }, 
                                        { jumpsXaxis(clas5InputThree), jumpsYaxis(clas5InputThree) }, 
                                        { jumpsXaxis(clas5InputFour), jumpsYaxis(clas5InputFour) }, 
                                        { jumpsXaxis(clas5InputFive), jumpsYaxis(clas5InputFive) }, 
                                        { jumpsXaxis(clas5InputSix), jumpsYaxis(clas5InputSix) }, 
                                        { 12, 15 },
                                        { 10, 1 },
                                        { jumpsXaxis(clas1InputOne), jumpsYaxis(clas1InputOne) },
                                        { jumpsXaxis(clas1InputTwo), jumpsYaxis(clas1InputTwo) },
                                        { jumpsXaxis(clas1InputThree), jumpsYaxis(clas1InputThree) },
                                        { jumpsXaxis(clas1InputFour), jumpsYaxis(clas1InputFour) },
                                        { jumpsXaxis(clas1InputFive), jumpsYaxis(clas1InputFive) },
                                        { jumpsXaxis(clas1InputSix), jumpsYaxis(clas1InputSix) },
                                        { jumpsXaxis(clas1InputSeven), jumpsYaxis(clas1InputSeven) },
                                        { jumpsXaxis(clas1InputEight), jumpsYaxis(clas1InputEight) }};

           /*double[,] input = new double[,] { { jumpsXaxis(clas5InputOne), jumpsYaxis(clas5InputOne) }, 
                                        { jumpsXaxis(clas5InputTwo), jumpsYaxis(clas5InputTwo) }, 
                                        { jumpsXaxis(clas5InputThree), jumpsYaxis(clas5InputThree) }, 
                                        { jumpsXaxis(clas5InputFour), jumpsYaxis(clas5InputFour) }, 
                                        { jumpsXaxis(clas5InputFive), jumpsYaxis(clas5InputFive) }, 
                                        { jumpsXaxis(clas5InputSix), jumpsYaxis(clas5InputSix) }, 
                                        { jumpsXaxis(clas5InputSeven), jumpsYaxis(clas5InputSeven) },
                                        { jumpsXaxis(clas5InputEight), jumpsYaxis(clas5InputEight) },
                                        { jumpsXaxis(clas1InputOne), jumpsYaxis(clas1InputOne) },
                                        { jumpsXaxis(clas1InputTwo), jumpsYaxis(clas1InputTwo) },
                                        { jumpsXaxis(clas1InputThree), jumpsYaxis(clas1InputThree) },
                                        { jumpsXaxis(clas1InputFour), jumpsYaxis(clas1InputFour) },
                                        { jumpsXaxis(clas1InputFive), jumpsYaxis(clas1InputFive) },
                                        { jumpsXaxis(clas1InputSix), jumpsYaxis(clas1InputSix) },
                                        { jumpsXaxis(clas1InputSeven), jumpsYaxis(clas1InputSeven) },
                                        { jumpsXaxis(clas1InputEight), jumpsYaxis(clas1InputEight) }};*/

           /* int[,] input = new int[,] { { 5, 0 }, 
                                        { 6, 2 }, 
                                        { 9, 3 }, 
                                        { 8, 1 }, 
                                        { 2, 3 }, 
                                        { 2, 5 }, 
                                        { 3, 3 },
                                        { 3, 4 },
                                        { 4, 3 },
                                        { 6, 5 },
                                        { 8, 5 },
                                        { 2, 8 },
                                        { 2, 10 },
                                        { 3, 8 },
                                        { 4, 8 },
                                        { 4, 9 }};*/


           int[] outputs = { 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0 };

            /*int[,] input = new int[,] { { 0 , 1 }, 
                                        { 1 , 0 }, 
                                        { 0 , 0 }, 
                                        { 1 , 1 }};*/
   
            //int[] outputs = { 1, 1, 0, 0};

            //Generate Randome Instance
            Random r = new Random();
            double[] weights = { r.NextDouble(), r.NextDouble(), r.NextDouble() };

            // Weights array Layer=1 - Neuron=1 (between 0-)
            double[] weights_L1_N1 = { r.Next(-3, 3), r.Next(-3, 3), r.Next(-3, 3) };
            // Weights array Layer=1 - Neuron=2
            double[] weights_L1_N2 = { r.Next(-3, 3), r.Next(-3, 3), r.Next(-3, 3) };
            // Weights array Layer=2 - Neuron=1
            double[] weights_L2_N1 = { r.Next(-3, 3), r.Next(-3, 3), r.Next(-3, 3) };

            //Set specific learning Rate
            double learningRate = 0.5;
            //Show Learning Rate in GUI
            textBox5.Text = learningRate.ToString();
            


            // Desired Error
            double  desiredError = 0.1;
            //Show Learning Rate in GUI
            textBox7.Text = desiredError.ToString();

            // Variable to control the Accumulated Error
            double totalError = 1;

            //Variable to count the number of epochs
            int epoch = 0;

            //Creating Chart for 5 class
            for (int i = 0; i < 8; i++)
            {
                this.chart1.Series["5 Class"].Points.AddXY(input[i, 0], input[i, 1]);
            }

            //Creating Chart for 1 class
            for (int i =8 ; i< 16; i++)
            {
                this.chart1.Series["1 Class"].Points.AddXY(input[i, 0], input[i, 1]);
            }

            while (totalError > desiredError)
            {
                totalError = 0;

                //Forward Equations
                for (int i = 0; i < 16; i++)
                {
                    ////////////////////////////////////FORWARD EQUATIONS/////////////////////////////////////////////////
                    //Layer=1 - Neuron=1                                                                                //
                    double N_1_1 = input[i, 0] * weights_L1_N1[0] + input[i, 1] * weights_L1_N1[1] - weights_L1_N1[2];  //
                    double A_1_1 = sigmoid(N_1_1);                                                                      //
                    //                                                                                                  //
                    //Layer=1 - Neuron=2                                                                                //
                    double N_1_2 = input[i, 0] * weights_L1_N2[0] + input[i, 1] * weights_L1_N2[1] - weights_L1_N2[2];  //
                    double A_1_2 = sigmoid(N_1_2);                                                                      //
                    //                                                                                                  //
                    //Layer=2 - Neuron=1                                                                                //
                    double N_2_1 = A_1_1 * weights_L2_N1[0] + A_1_2 * weights_L2_N1[1] - weights_L2_N1[2];              //
                    double A_2_1 = sigmoid(N_2_1);                                                                      //
                    ////////////////////////////////////CALCULATE ERROR///////////////////////////////////////////////////
                    double error = outputs[i] - A_2_1;                                      //                                            
                    //Error Acumulado                                                       //
                    totalError += ((Math.Pow(error, 2)) / 2);                               //
                    ////////////////////////////////////BACKWARD EQUATIONS//////////////////////////////////////////////////////////////////////
                    //Sensivility Layer=2 - Neuron=1                                                                                          //
                    double S_2_1 = -2 * derivedSigmoid(N_2_1) * (outputs[i] - A_2_1);                                                         //
                    //Sensivility Layer=1 - Neuron=1                                                                                          //
                    double S_1_1 = weights_L2_N1[0] * derivedSigmoid(N_1_1) * S_2_1;
                    //Sensivility Layer=1 - Neuron=2                                                                                          //
                    double S_1_2 = weights_L2_N1[1] * derivedSigmoid(N_1_2) * S_2_1;   
                    ////////////////////////////////////WEIGHT ADJUSTMENT///////////////////////////////////////////////////////////////////////
                    // Weights array Layer=1 - Neuron=1                                         //
                    weights_L1_N1[0] += -learningRate * S_1_1 * input[i, 0];                    // 
                    weights_L1_N1[1] += -learningRate * S_1_1 * input[i, 1];                    //
                    weights_L1_N1[2] += -learningRate * S_1_1 * -1;                             //
                    // Weights array Layer=1 - Neuron=2                                         //
                    weights_L1_N2[0] += -learningRate * S_1_2 * input[i, 0];                    //
                    weights_L1_N2[1] += -learningRate * S_1_2 * input[i, 1];                    //
                    weights_L1_N2[2] += -learningRate * S_1_2 * -1;                             //
                    // Weights array Layer=2 - Neuron=1                                         //
                    weights_L2_N1[0] += -learningRate * S_2_1 * A_1_1;                          //
                    weights_L2_N1[1] += -learningRate * S_2_1 * A_1_2;                          //
                    weights_L2_N1[2] += -learningRate * S_2_1 * -1;                             //
                    //////////////////////////////////////////////////////////////////////////////       
                    
                }
                epoch++;

                //Chart for Error vs Epochs
                this.chart2.Series["Error"].Points.AddXY(epoch, totalError);

                if (epoch > 200000)
                {
                    MessageBox.Show("Too much Epochs");
                    break;
                }

                // Show epochs in GUI
                textBox1.Text = epoch.ToString();
                textBox14.Text = totalError.ToString();
            }
            // Show weights in GUI
            //Weights array Layer=1 - Neuron=1    
            textBox2.Text = weights_L1_N1[0].ToString();
            textBox3.Text = weights_L1_N1[1].ToString();
            textBox4.Text = weights_L1_N1[2].ToString();
            // Weights array Layer=1 - Neuron=2   
            textBox10.Text = weights_L1_N2[0].ToString();
            textBox9.Text = weights_L1_N2[1].ToString();
            textBox8.Text = weights_L1_N2[2].ToString();
            // Weights array Layer=2 - Neuron=1  
            textBox13.Text = weights_L2_N1[0].ToString();
            textBox12.Text = weights_L2_N1[1].ToString();
            textBox11.Text = weights_L2_N1[2].ToString();

            //Get a copy of final weight to use for new input.
            finalWeights[0] = weights[0];
            finalWeights[1] = weights[1];
            finalWeights[2] = weights[2];

            //Draw slope in chart
            //double xMin = -20;
           // double xMax = 20;
            //this.chart1.Series["Slope"].Points.AddXY(xMin, ((-(weights[1] * xMin) + weights[0]) / weights[2]));
            //this.chart1.Series["Slope"].Points.AddXY(xMax, ((-(weights[1] * xMax) + weights[0]) / weights[2]));

        }

        private static int calculateOutput(double input1, double input2, double[] weights)
        {
            double sum = input1 * weights[0] + input2 * weights[1] + 1 * weights[2];
            return (sum >= 0) ? 0 : 1;
        }

        //------------------------------------------------------------------------------------------
        //     Descriptors                                                                        //
        //------------------------------------------------------------------------------------------

        /// Calculate the number of Colored Cells
        private static int calculateColored(int[,] matrix)
        {
            int count = 0;
            
            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 6; col++)
                {
                    if (matrix[col, row] == 1)
                    {
                        count++;
                    }
                }
            }
            return count;

        }

        /// Calculate the number of NO Colored Cells
        private static int calculateNoColored(int[,] matrix)
        {
            int count = 0;

            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 6; col++)
                {
                    if (matrix[col, row] == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        /// Calculate the number of Jumps in X axis
        private static int jumpsXaxis(int[,] matrix)
        {
            int count = 0;
            int newValue;
            int oldValue = matrix[0, 0];

            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 6; col++)
                {
                    newValue = matrix[col, row];
                    if (newValue != oldValue)
                    {
                        count++;
                        oldValue = newValue;
                    }
                }
            }
            return count;
        }

        /// Calculate the number of Jumps in Y axis
        private static int jumpsYaxis(int[,] matrix)
        {
            int count = 0;
            int newValue;
            int oldValue = matrix[0, 0];

            for (int col = 0; col < 6; col++)
            {
                for (int row = 0; row < 6; row++)
                {
                    newValue = matrix[col, row];
                    if (newValue != oldValue)
                    {
                        count++;
                        oldValue = newValue;
                    }
                }
            }
            return count;
        }

        public double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            int[,] input = new int[,] { { jumpsXaxis(claseTemp), jumpsYaxis(claseTemp) } };
            this.chart1.Series["Input"].Points.AddXY(jumpsXaxis(claseTemp), jumpsYaxis(claseTemp));
            int output = calculateOutput(input[0, 0], input[0, 1], finalWeights);

            if (output == 1)
                textBox6.Text = "5 Class";
            else
                textBox6.Text = "1 Class";

        }


        //------------------------------------------------------------------------------------------
        //    Getting Input from the Matrix
        //------------------------------------------------------------------------------------------
        
        private void button37_Click_1(object sender, EventArgs e)
        {
            if (button37.BackColor == System.Drawing.Color.Black)
            {
                button37.BackColor = System.Drawing.Color.White;
                claseTemp[0, 0] = 0;
            }
            else
            {
                button37.BackColor = System.Drawing.Color.Black;
                claseTemp[0, 0] = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == System.Drawing.Color.Black)
            {
                button2.BackColor = System.Drawing.Color.White;
                claseTemp[0, 1] = 0;
            }
            else
            {
                button2.BackColor = System.Drawing.Color.Black;
                claseTemp[0, 1] = 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor == System.Drawing.Color.Black)
            {
                button4.BackColor = System.Drawing.Color.White;
                claseTemp[0, 2] = 0;
            }
            else
            {
                button4.BackColor = System.Drawing.Color.Black;
                claseTemp[0, 2] = 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == System.Drawing.Color.Black)
            {
                button3.BackColor = System.Drawing.Color.White;
                claseTemp[0, 3] = 0;
            }
            else
            {
                button3.BackColor = System.Drawing.Color.Black;
                claseTemp[0, 3] = 1;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.BackColor == System.Drawing.Color.Black)
            {
                button6.BackColor = System.Drawing.Color.White;
                claseTemp[0, 4] = 0;
            }
            else
            {
                button6.BackColor = System.Drawing.Color.Black;
                claseTemp[0, 4] = 1;
            }
        }
        //Row 2
        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.BackColor == System.Drawing.Color.Black)
            {
                button5.BackColor = System.Drawing.Color.White;
                claseTemp[0, 5] = 0;
            }
            else
            {
                button5.BackColor = System.Drawing.Color.Black;
                claseTemp[0, 5] = 1;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.BackColor == System.Drawing.Color.Black)
            {
                button12.BackColor = System.Drawing.Color.White;
                claseTemp[1, 0] = 0;
            }
            else
            {
                button12.BackColor = System.Drawing.Color.Black;
                claseTemp[1, 0] = 1;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.BackColor == System.Drawing.Color.Black)
            {
                button11.BackColor = System.Drawing.Color.White;
                claseTemp[1, 1] = 0;
            }
            else
            {
                button11.BackColor = System.Drawing.Color.Black;
                claseTemp[1, 1] = 1;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.BackColor == System.Drawing.Color.Black)
            {
                button10.BackColor = System.Drawing.Color.White;
                claseTemp[1, 2] = 0;
            }
            else
            {
                button10.BackColor = System.Drawing.Color.Black;
                claseTemp[1, 2] = 1;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.BackColor == System.Drawing.Color.Black)
            {
                button9.BackColor = System.Drawing.Color.White;
                claseTemp[1, 3] = 0;
            }
            else
            {
                button9.BackColor = System.Drawing.Color.Black;
                claseTemp[1, 3] = 1;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.BackColor == System.Drawing.Color.Black)
            {
                button8.BackColor = System.Drawing.Color.White;
                claseTemp[1, 4] = 0;
            }
            else
            {
                button8.BackColor = System.Drawing.Color.Black;
                claseTemp[1, 4] = 1;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.BackColor == System.Drawing.Color.Black)
            {
                button7.BackColor = System.Drawing.Color.White;
                claseTemp[1, 5] = 0;
            }
            else
            {
                button7.BackColor = System.Drawing.Color.Black;
                claseTemp[1, 5] = 1;
            }
        }
        //Row 3
        private void button18_Click(object sender, EventArgs e)
        {
            if (button18.BackColor == System.Drawing.Color.Black)
            {
                button18.BackColor = System.Drawing.Color.White;
                claseTemp[2, 0] = 0;
            }
            else
            {
                button18.BackColor = System.Drawing.Color.Black;
                claseTemp[2, 0] = 1;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (button17.BackColor == System.Drawing.Color.Black)
            {
                button17.BackColor = System.Drawing.Color.White;
                claseTemp[2, 1] = 0;
            }
            else
            {
                button17.BackColor = System.Drawing.Color.Black;
                claseTemp[2, 1] = 1;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button16.BackColor == System.Drawing.Color.Black)
            {
                button16.BackColor = System.Drawing.Color.White;
                claseTemp[2, 2] = 0;
            }
            else
            {
                button16.BackColor = System.Drawing.Color.Black;
                claseTemp[2, 2] = 1;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.BackColor == System.Drawing.Color.Black)
            {
                button15.BackColor = System.Drawing.Color.White;
                claseTemp[2, 3] = 0;
            }
            else
            {
                button15.BackColor = System.Drawing.Color.Black;
                claseTemp[2, 3] = 1;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button14.BackColor == System.Drawing.Color.Black)
            {
                button14.BackColor = System.Drawing.Color.White;
                claseTemp[2, 4] = 0;
            }
            else
            {
                button14.BackColor = System.Drawing.Color.Black;
                claseTemp[2, 4] = 1;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.BackColor == System.Drawing.Color.Black)
            {
                button13.BackColor = System.Drawing.Color.White;
                claseTemp[2, 5] = 0;
            }
            else
            {
                button13.BackColor = System.Drawing.Color.Black;
                claseTemp[2, 5] = 1;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (button24.BackColor == System.Drawing.Color.Black)
            {
                button24.BackColor = System.Drawing.Color.White;
                claseTemp[3, 0] = 0;
            }
            else
            {
                button24.BackColor = System.Drawing.Color.Black;
                claseTemp[3, 0] = 1;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (button23.BackColor == System.Drawing.Color.Black)
            {
                button23.BackColor = System.Drawing.Color.White;
                claseTemp[3, 1] = 0;
            }
            else
            {
                button23.BackColor = System.Drawing.Color.Black;
                claseTemp[3, 1] = 1;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (button22.BackColor == System.Drawing.Color.Black)
            {
                button22.BackColor = System.Drawing.Color.White;
                claseTemp[3, 2] = 0;
            }
            else
            {
                button22.BackColor = System.Drawing.Color.Black;
                claseTemp[3, 2] = 1;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (button21.BackColor == System.Drawing.Color.Black)
            {
                button21.BackColor = System.Drawing.Color.White;
                claseTemp[3, 3] = 0;
            }
            else
            {
                button21.BackColor = System.Drawing.Color.Black;
                claseTemp[3, 3] = 1;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (button20.BackColor == System.Drawing.Color.Black)
            {
                button20.BackColor = System.Drawing.Color.White;
                claseTemp[3, 4] = 0;
            }
            else
            {
                button20.BackColor = System.Drawing.Color.Black;
                claseTemp[3, 4] = 1;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (button19.BackColor == System.Drawing.Color.Black)
            {
                button19.BackColor = System.Drawing.Color.White;
                claseTemp[3, 5] = 0;
            }
            else
            {
                button19.BackColor = System.Drawing.Color.Black;
                claseTemp[3, 5] = 1;
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (button31.BackColor == System.Drawing.Color.Black)
            {
                button31.BackColor = System.Drawing.Color.White;
                claseTemp[4, 0] = 0;
            }
            else
            {
                button31.BackColor = System.Drawing.Color.Black;
                claseTemp[4, 0] = 1;
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (button29.BackColor == System.Drawing.Color.Black)
            {
                button29.BackColor = System.Drawing.Color.White;
                claseTemp[4, 1] = 0;
            }
            else
            {
                button29.BackColor = System.Drawing.Color.Black;
                claseTemp[4, 1] = 1;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (button28.BackColor == System.Drawing.Color.Black)
            {
                button28.BackColor = System.Drawing.Color.White;
                claseTemp[4, 2] = 0;
            }
            else
            {
                button28.BackColor = System.Drawing.Color.Black;
                claseTemp[4, 2] = 1;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (button27.BackColor == System.Drawing.Color.Black)
            {
                button27.BackColor = System.Drawing.Color.White;
                claseTemp[4, 3] = 0;
            }
            else
            {
                button27.BackColor = System.Drawing.Color.Black;
                claseTemp[4, 3] = 1;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (button26.BackColor == System.Drawing.Color.Black)
            {
                button26.BackColor = System.Drawing.Color.White;
                claseTemp[4, 4] = 0;
            }
            else
            {
                button26.BackColor = System.Drawing.Color.Black;
                claseTemp[4, 4] = 1;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (button25.BackColor == System.Drawing.Color.Black)
            {
                button25.BackColor = System.Drawing.Color.White;
                claseTemp[4, 5] = 0;
            }
            else
            {
                button25.BackColor = System.Drawing.Color.Black;
                claseTemp[4, 5] = 1;
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (button36.BackColor == System.Drawing.Color.Black)
            {
                button36.BackColor = System.Drawing.Color.White;
                claseTemp[5, 0] = 0;
            }
            else
            {
                button36.BackColor = System.Drawing.Color.Black;
                claseTemp[5, 0] = 1;
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (button35.BackColor == System.Drawing.Color.Black)
            {
                button35.BackColor = System.Drawing.Color.White;
                claseTemp[5, 1] = 0;
            }
            else
            {
                button35.BackColor = System.Drawing.Color.Black;
                claseTemp[5, 1] = 1;
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (button34.BackColor == System.Drawing.Color.Black)
            {
                button34.BackColor = System.Drawing.Color.White;
                claseTemp[5, 2] = 0;
            }
            else
            {
                button34.BackColor = System.Drawing.Color.Black;
                claseTemp[5, 2] = 1;
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (button33.BackColor == System.Drawing.Color.Black)
            {
                button33.BackColor = System.Drawing.Color.White;
                claseTemp[5, 3] = 0;
            }
            else
            {
                button33.BackColor = System.Drawing.Color.Black;
                claseTemp[5, 3] = 1;
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (button32.BackColor == System.Drawing.Color.Black)
            {
                button32.BackColor = System.Drawing.Color.White;
                claseTemp[5, 4] = 0;
            }
            else
            {
                button32.BackColor = System.Drawing.Color.Black;
                claseTemp[5, 4] = 1;
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (button30.BackColor == System.Drawing.Color.Black)
            {
                button30.BackColor = System.Drawing.Color.White;
                claseTemp[5, 5] = 0;
            }
            else
            {
                button30.BackColor = System.Drawing.Color.Black;
                claseTemp[5, 5] = 1;
            }
        }

        //----------------------------------------------------------------------------------------
        //    Clear  variables
        //----------------------------------------------------------------------------------------
        private void button40_Click(object sender, EventArgs e)
        {
            ////Clear Drawing
            //Row 0
            button37.BackColor = System.Drawing.Color.White;
            button2.BackColor = System.Drawing.Color.White;
            button4.BackColor = System.Drawing.Color.White;
            button3.BackColor = System.Drawing.Color.White;
            button6.BackColor = System.Drawing.Color.White;
            //Row 1
            button5.BackColor = System.Drawing.Color.White;
            button12.BackColor = System.Drawing.Color.White;
            button11.BackColor = System.Drawing.Color.White;
            button10.BackColor = System.Drawing.Color.White;
            button9.BackColor = System.Drawing.Color.White;
            button8.BackColor = System.Drawing.Color.White;
            button7.BackColor = System.Drawing.Color.White;
            //Row 2
            button18.BackColor = System.Drawing.Color.White;
            button17.BackColor = System.Drawing.Color.White;
            button16.BackColor = System.Drawing.Color.White;
            button15.BackColor = System.Drawing.Color.White;
            button14.BackColor = System.Drawing.Color.White;
            button13.BackColor = System.Drawing.Color.White;
            //Row 3
            button24.BackColor = System.Drawing.Color.White;
            button23.BackColor = System.Drawing.Color.White;
            button22.BackColor = System.Drawing.Color.White;
            button21.BackColor = System.Drawing.Color.White;
            button20.BackColor = System.Drawing.Color.White;
            button19.BackColor = System.Drawing.Color.White;
            //Row 4
            button31.BackColor = System.Drawing.Color.White;
            button29.BackColor = System.Drawing.Color.White;
            button28.BackColor = System.Drawing.Color.White;
            button27.BackColor = System.Drawing.Color.White;
            button26.BackColor = System.Drawing.Color.White;
            button25.BackColor = System.Drawing.Color.White;
            //Row 5
            button36.BackColor = System.Drawing.Color.White;
            button35.BackColor = System.Drawing.Color.White;
            button34.BackColor = System.Drawing.Color.White;
            button33.BackColor = System.Drawing.Color.White;
            button32.BackColor = System.Drawing.Color.White;
            button30.BackColor = System.Drawing.Color.White;

            //Clear claseTemp input
            for (int row = 0; row <= 5; row++)
            {
                for (int col = 0; col <= 5; col++)
                {
                    claseTemp[col, row] = 0;
                }
            }

            //Clear Results
            textBox6.Text = "";

            //Clear Result in Chart
            this.chart1.Series["Input"].Points.Clear();
        }
        //----------------------------------------------------------------------------------------


        private void chart1_Click(object sender, EventArgs e)
        {

        }

        /// Sigmoid Functions
        public double sigmoid(double x)
        {
            //if (x < -45.0) return 0.0;
            //else if (x > 45.0) return 1.0;
            return 1.0 / (1.0 + Math.Exp(-x));
            //return 1/(1 + Math.Exp(-x));
        }

        /// Sigmoid Functions
        public double derivedSigmoid(double x)
        {
            return sigmoid(x) * (1 - sigmoid(x));
        }

             
      
    }
}
