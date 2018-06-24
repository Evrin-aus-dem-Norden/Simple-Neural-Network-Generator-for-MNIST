using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace with_tutor
{
    public partial class Form1 : Form
    {
        Network Net = new Network();
        StreamWriter sw = new StreamWriter(@"D:\нейросети\2\output.txt");

        public Form1()
        {
            InitializeComponent();
            sw.WriteLine("Start");
        }

        private void Create_Click(object sender, EventArgs e)
        {
            X.Visible = true;
            d.Visible = true;
            Y_length.Visible = true;
            Ylen.Visible = true;
        }

        private void Add_layers_Click(object sender, EventArgs e)
        {
            l_num.Visible = true;
        }

        private void l_num_TextChanged(object sender, EventArgs e)
         {
            try
            {
                Net.stLayer = false;
                Net.l_number = Convert.ToInt32(l_num.Text) + 1;
                layers.Visible = true;
                Choose_functions.Visible = true;
                Choose_speeds.Visible = true;
            }
            catch
            {
                Net.stLayer = true;
                Net.l_number = 2;
                error_layers.Visible = true;
                l_num.Visible = false;
                layers.Visible = false;
                Choose_functions.Visible = false;
                Choose_speeds.Visible = false;
            }
            Net.layers = new Layer[Net.l_number];
        }

        private void Choose_functions_Click(object sender, EventArgs e)
        {
            functions.Visible = true;
        }

        private void functions_TextChanged(object sender, EventArgs e)
        {
            Net.stFunctions = false;
            funcParams.Visible = true;
        }

        private void Choose_speeds_Click(object sender, EventArgs e) {
            speeds.Visible = true;
        }

        private void speeds_TextChanged(object sender, EventArgs e) {
            Net.stSpeeds = false;
        }

        private void Load_weights_Click(object sender, EventArgs e) {
            folderBrowserDialog3.SelectedPath = @"D:\нейросети\2\with_tutor\W\";
            folderBrowserDialog3.ShowDialog();
            openFileDialog3.InitialDirectory = folderBrowserDialog3.SelectedPath;
            openFileDialog3.FileName = "";
            openFileDialog3.ShowDialog();
            if (openFileDialog3.FileName != "")
                Net.stWeights = false;
        }

        private void setLayers() {
            if (Net.stLayer)
                Net.createLayers();
            else {
                string[] layersArr = new string[Net.l_number];
                layersArr = layers.Text.Split(' ');
                Net.createLayers(layersArr);
            }
        }

        private int countLetters(string s, char c) {
            int count = s.Length - s.Replace(c, ' ').Length;
            return count;
        }

        private void setFunctions()
        {
            if (!Net.stFunctions)
                try
                {
                    string[] functionsArr = new string[Net.l_number];
                    string text = functions.Text;

                    if (text.Replace("t", "").Replace("l", "").Replace(" ", "").Length > 0)
                        throw new Exception();

                    functionsArr = text.Split(' ');
                    
                    string[] temp = new string[2 * countLetters(text, 't') + countLetters(text, 'l')];
                    temp = funcParams.Text.Split(' ');

                    int j = 0;
                    double[][] paramsArr = new double[Net.l_number][];

                    for (int i = 0; i < Net.l_number; ++i)         
                        if (functionsArr[i] == "t")
                        {
                            paramsArr[i] = new double[2];
                            paramsArr[i][0] = Convert.ToDouble(temp[j]);
                            j += 1;
                            paramsArr[i][1] = Convert.ToDouble(temp[j]);
                        }
                        else
                        {
                            paramsArr[i] = new double[1];
                            paramsArr[i][0] = Convert.ToDouble(temp[j]);
                        }

                    for (int i = 0; i < Net.l_number; ++i)
                        switch (functionsArr[i])
                        {
                            case "t":
                                Net.layers[i].func = Net.HyperbolicTangent;
                                Net.layers[i].der = Net.DerivativeOfHyperbolicTangent;
                                Net.layers[i].args = paramsArr[i];
                                break;
                            case "l":
                                Net.layers[i].func = Net.LogisticFunction;
                                Net.layers[i].der = Net.DerivativeOfLogisticFunction;
                                Net.layers[i].args = paramsArr[i];
                                break;
                            default:
                                break;
                        }
                }
                catch
                {
                    Net.stFunctions = true;
                    error_func.Visible = true;
                    functions.Visible = false;
                    funcParams.Visible = false;
                }

            if (Net.stFunctions)
            {
                for (int i = 0; i < Net.l_number; ++i)
                {
                    Net.layers[i].func = Net.LogisticFunction;
                    Net.layers[i].der = Net.DerivativeOfLogisticFunction;
                    Net.layers[i].args = new double[] {0.5};
                }
            }

            if (Net.layers[Net.l_number - 1].func == Net.HyperbolicTangent)
                for (int i = 0; i < Net.d.Length; ++i)
                    for (int j = 0; j < Net.d[0].Length; ++j) {
                        if (Net.d[i][j] == 0)
                            Net.d[i][j] = -1 * Net.layers[Net.l_number - 1].args[0];
                        if (Net.d[i][j] == 1)
                            Net.d[i][j] = Net.layers[Net.l_number - 1].args[0];
                    }
        }

        private void setSpeeds() 
        {
            if (!Net.stSpeeds)
                try 
                {
                    string[] speedsArr = new string[Net.l_number];
                    string text = speeds.Text;

                    speedsArr = text.Split(' ');
                    double temp;

                    for (int i = 0; i < Net.l_number; ++i) 
                    {
                        temp = Convert.ToDouble(speedsArr[i]);
                        if (temp <= 1.0)
                            Net.layers[i].speed = temp;
                        else
                            throw new Exception();
                    }
                } 
                catch 
                {
                    Net.stSpeeds = true;
                    error_speeds.Visible = true;
                    speeds.Visible = false;
                }

            if (Net.stSpeeds) 
            {
                for (int i = 0; i < Net.l_number; ++i)
                    Net.layers[i].speed = 0.6;
            }
        }

        private void setWeights() 
        {
            Random rand = new Random();

            for (int l = 0; l < Net.l_number; ++l)
                for (int i = 0; i < Net.layers[l].weight.Length; ++i)
                    for (int j = 0; j < Net.layers[l].weight[i].Length; ++j)
                        Net.layers[l].weight[i][j] = 1.6*rand.NextDouble() - 0.8;
        }

        private void getWeights() 
        {
            string weightsFile = openFileDialog3.FileName;
            StreamReader sr = new StreamReader(weightsFile);

            for (int l = 0; l < Net.l_number; ++l)
                for (int i = 0; i < Net.layers[l].weight.Length; ++i)
                    for (int j = 0; j < Net.layers[l].weight[i].Length; ++j)
                        Net.layers[l].weight[i][j] = Double.Parse(sr.ReadLine());

            sr.Close();

            T.Visible = true;
            dT.Visible = true;
        }

        private void X_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = @"D:\нейросети\2\with_tutor\X\";  
            folderBrowserDialog1.ShowDialog();
            openFileDialog1.InitialDirectory = folderBrowserDialog1.SelectedPath;
            openFileDialog1.FileName = "train-images.idx3-ubyte";
            openFileDialog1.ShowDialog();
        }

        private void d_Click(object sender, EventArgs e)
        {
            folderBrowserDialog2.SelectedPath = @"D:\нейросети\2\with_tutor\d\";  
            folderBrowserDialog2.ShowDialog();
            openFileDialog2.InitialDirectory = folderBrowserDialog2.SelectedPath;
            openFileDialog2.FileName = "train-labels.idx1-ubyte";
            openFileDialog2.ShowDialog();
            Load_input.Visible = true;
        }

        private void Load_input_Click(object sender, EventArgs e)
        {
            string pixelFile = openFileDialog1.FileName;
            string labelFile = openFileDialog2.FileName;
            if (pixelFile.Length == 0 || labelFile.Length == 0)
                throw new Exception();
            else 
                MnistImage.LoadData(pixelFile, labelFile, out Net.X, out Net.d);
            Net.Y = new double[Int32.Parse(Ylen.Text)];
            Add_layers.Visible = true;
            Load_weights.Visible = true;
            Confirm.Visible = true;
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            setLayers();
            setFunctions();
            setSpeeds();

            Net.createWeights();
            Net.addVectors();

            if (Net.stWeights)
                setWeights();
            else
                getWeights();

            Learn.Visible = true;

            sw.WriteLine("Process");
        }

        private void Learn_Click(object sender, EventArgs e) {
            T.Visible = false;
            dT.Visible = false;
            Load_test.Visible = false;
            Test.Visible = false;
            Finished.Visible = false;

            MnistImage image;
            double[] label;
            int it = 0;

            Random rand = new Random();

            do 
            {
                Net.ind = Net.ind.OrderBy(x => rand.Next()).ToArray();

                Net.lastnEav = Net.nEav;
                Net.nEav = 0.0;

                for (int n = 0; n < Net.ind.Length; ++n) 
                {
                    image = Net.X[Net.ind[n]];
                    label = Net.d[Net.ind[n]];
                    forward(image);
                    countError(label);
                    backward(image);
                    updateWeights();
                    Net.itlocalGrad = countGrad();
                }
                ++it;

                sw.WriteLine(countEavDiff().ToString() + " diffEav " + (Net.nEav / Net.X.Length).ToString() + " Eav " + (Net.itlocalGrad / it).ToString() + " grad");
            }
            while (it < 2 || countEavDiff() > 0.0003 && Net.itlocalGrad / it > 0.02 && it < 50) ;

            saveWeigths();

            Trained.Visible = true;
            T.Visible = true;
            dT.Visible = true;
        }

        private void forward(MnistImage image) 
        {
            for (int i = 0; i < image.height; ++i)
                for (int j = 0; j < image.width; ++j)
                    Net.layers[0].y[i * image.height + j] = image.pixels[i][j];
            Net.layers[0].y[Net.layers[0].y.Length - 1] = 0.5;

            for (int l = 0; l < Net.l_number; ++l) 
            {
                for (int i = 0; i < Net.layers[l].v.Length; ++i)
                    for (int j = 0; j < Net.layers[l].weight.Length; ++j)
                        Net.layers[l].v[i] += Net.layers[l].y[j] * Net.layers[l].weight[j][i];

                for (int i = 0; i < Net.layers[l].v.Length; ++i)
                    Net.layers[l].v[i] = Net.layers[l].func(Net.layers[l].args, Net.layers[l].v[i]);

                if (l != Net.l_number - 1)
                    Net.layers[l + 1].y = Net.layers[l].v;
            }

            Net.Y = Net.layers[Net.l_number - 1].v;
        }

        private void countError(double[] d) 
        {
            double sum = 0;
            for (int i = 0; i < Net.e.Length; ++i) 
            {
                Net.e[i] = d[i] - Net.layers[Net.l_number - 1].v[i];
                sum += Net.e[i] * Net.e[i];
            }
            Net.nEav += sum / 2.0;
        }

        private void backward(MnistImage image) 
        {
            double sum;
            for (int i = 0; i < Net.e.Length; ++i)
                Net.layers[Net.l_number - 1].delta[i] = Net.e[i] * Net.layers[Net.l_number - 1].der(Net.layers[Net.l_number - 1].args, Net.layers[Net.l_number - 1].v[i]);
            for (int l = Net.l_number - 2; l >= 0; --l)
                for (int i = 0; i < Net.layers[l].v.Length; ++i) 
                {
                    sum = 0;
                    for (int k = 0; k < Net.layers[l + 1].delta.Length; ++k)
                        sum += Net.layers[l + 1].delta[k] * Net.layers[l + 1].weight[i][k];
                    Net.layers[l].delta[i] = Net.layers[l].der(Net.layers[l].args, Net.layers[l].v[i]) * sum;
                }
        }

        private double countGrad() 
        {
            double grad = 0;
            double inc = 0;
            for (int l = 0; l < Net.l_number; ++l)
                for (int i = 0; i < Net.layers[l].delta.Length; ++i) 
                {
                    grad += Net.layers[l].delta[i] * Net.layers[l].delta[i];
                    inc += 1;
                }
            return Net.itlocalGrad + grad / inc;
        }

        private double countEavDiff() 
        {
            return Math.Abs(Net.lastnEav / Net.X.Length - Net.nEav / Net.X.Length);
        }

        private int WTA(double[] d) 
        {
            int imax = 0;
            for (int i = 0; i < d.Length; ++i)
                if (d[i] > d[imax])
                    imax = i;
            return imax;
        }

        private void updateWeights() 
        {
            for (int l = 0; l < Net.l_number; ++l)
                for (int i = 0; i < Net.layers[l].weight.Length; ++i)
                    for (int j = 0; j < Net.layers[l].weight[i].Length; ++j)
                        Net.layers[l].weight[i][j] += Net.layers[l].speed * Net.layers[l].delta[j] * Net.layers[l].y[i];
        }

        private void saveWeigths() {
            var output = File.Create(@"D:\нейросети\2\with_tutor\W\weights" + (Net.layers[0].weight[0][0]).ToString() + ".txt");
            StreamWriter wout = new StreamWriter(output);

            for (int l = 0; l < Net.l_number; ++l)
                for (int i = 0; i < Net.layers[l].weight.Length; ++i)
                    for (int j = 0; j < Net.layers[l].weight[i].Length; ++j)
                        wout.Write(Net.layers[l].weight[i][j].ToString() + '\n');

            wout.Close();
        }

        private void T_Click(object sender, EventArgs e) {
            folderBrowserDialog4.SelectedPath = @"D:\нейросети\2\with_tutor\T\";
            folderBrowserDialog4.ShowDialog();
            openFileDialog4.InitialDirectory = folderBrowserDialog4.SelectedPath;
            openFileDialog4.FileName = "t10k-images.idx3-ubyte";
            openFileDialog4.ShowDialog();
        }

        private void dT_Click(object sender, EventArgs e) {
            folderBrowserDialog5.SelectedPath = @"D:\нейросети\2\with_tutor\dT\";
            folderBrowserDialog5.ShowDialog();
            openFileDialog5.InitialDirectory = folderBrowserDialog5.SelectedPath;
            openFileDialog5.FileName = "t10k-labels.idx1-ubyte";
            openFileDialog5.ShowDialog();
            Load_test.Visible = true;
        }

        private void Load_test_Click(object sender, EventArgs e) 
        {
            string pixelFile = openFileDialog4.FileName;
            string labelFile = openFileDialog5.FileName;
            if (pixelFile.Length == 0 || labelFile.Length == 0)
                throw new Exception();
            else
                MnistImage.LoadData(pixelFile, labelFile, out Net.T, out Net.dT);
            Test.Visible = true;
        }

        private void Test_Click(object sender, EventArgs e) 
        {
            int q = 0;
            double y, d;

            for (int n = 0; n < Net.T.Length; ++n) {
                forward(Net.T[n]);
                y = WTA(Net.Y);
                d = WTA(Net.dT[n]);
                //sw.WriteLine(y.ToString() + " " + d.ToString());
                if (y == d)
                    q += 1;
            }

            double pr = 1.0 * q / Net.T.Length;
            sw.Write(pr);
            Finished.Visible = true;
            Save_Report.Enabled = true;
        }

        private void Save_Report_Click(object sender, EventArgs e) 
        {
            sw.Close();
        }

        class Win32 {
            /// <summary>
            /// Allocates a new console for current process.
            /// </summary>
            [DllImport("kernel32.dll")]
            public static extern Boolean AllocConsole();

            /// <summary>
            /// Frees the console.
            /// </summary>
            [DllImport("kernel32.dll")]
            public static extern Boolean FreeConsole();
        }

    }
}
