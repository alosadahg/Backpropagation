using Backprop;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Backpropagation2
{
    public partial class Form1 : Form
    {
        NeuralNet nn;
        int epochCnt;
        int epochMult;
        int hiddenNeuronCnt;
        public Form1()
        {
            InitializeComponent();
            btnTest.Enabled = false;
            btnSave.Enabled = false;
            btnTrainNN.Enabled = false;

        }

        private void btnCreateNN_Click(object sender, EventArgs e)
        {
            epochCnt = Convert.ToInt32(tbEpoch.Text);
            hiddenNeuronCnt = Convert.ToInt32(tbHN.Text);
            epochMult = 1;
            nn = new NeuralNet(4, hiddenNeuronCnt, 1);
            btnTrainNN.Enabled = true;
            lbTestRecord.Items.Add("Neural network created!");
            lbTestRecord.Items.Add("Proceed to training");
        }

        private void btnTrainNN_Click(object sender, EventArgs e)
        {
            lbTestRecord.Items.Add("Training neural network...");
            btnTest.Enabled = true;
            btnSave.Enabled = true;
            for (int i = 0; i < epochCnt; i++)
            {
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();
            }

            lbTestRecord.Items.Add("Epoch Count: " + epochCnt * epochMult);
            lbTestRecord.Items.Add("Hidden Neurons Count: " + hiddenNeuronCnt);
            ++epochMult;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            nn.setInputs(0, Convert.ToDouble(tbInput1.Text));
            nn.setInputs(1, Convert.ToDouble(tbInput2.Text));
            nn.setInputs(2, Convert.ToDouble(tbInput3.Text));
            nn.setInputs(3, Convert.ToDouble(tbInput4.Text));
            nn.run();
            tbOutput.Text = "" + nn.getOuputData(0);
            lbTestRecord.Items.Add("Test Output: " + nn.getOuputData(0));
        }


        private void btnSaveTo_Click(object sender, EventArgs e)
        {
           
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            nn.loadWeights(openFileDialog1.FileName);
            lbTestRecord.Items.Add("Loaded weights from: " + openFileDialog1.FileName.ToString());
            lbTestRecord.Items.Add("Proceed to testing");
            btnTest.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            nn.saveWeights(saveFileDialog1.FileName);
            lbTestRecord.Items.Add("Weights saved successfully!");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
