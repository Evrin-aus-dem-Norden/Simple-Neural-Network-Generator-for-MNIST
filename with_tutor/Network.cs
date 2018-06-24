using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace with_tutor
{

    public class Network
    {
        public bool stLayer;
        public bool stFunctions;
        public bool stSpeeds;
        public bool stWeights;

        public int l_number;            // all layers
        public Layer[] layers;

        public MnistImage[] X;
        public int[] ind;
        public double[] Y;

        public MnistImage[] T;
        public double[][] dT;

        public double[] e;
        public double[][] d;
        public double nEav;
        public double lastnEav;
        public double itlocalGrad;

        public Network()
        {
            this.stLayer = true;
            this.stFunctions = true;
            this.stSpeeds = true;
            this.stWeights = true;
            this.l_number = 2;
            this.nEav = 0;
            this.lastnEav = 0;
        }

        public double LogisticFunction(double[] args, double x)
        {
            return 1 / (1 + Math.Exp(-args[0] * x));
        }

        public double HyperbolicTangent(double[] args, double x)
        {
            return args[0] * Math.Tanh(args[1] * x);
        }

        public double DerivativeOfLogisticFunction(double[] args, double x)
        {
            return args[0] * x * (1 - x);
        }

        public double DerivativeOfHyperbolicTangent(double[] args, double x)
        {
            return args[1] / args[0] * (args[0] - x) * (args[0] + x);
        }

        public void createLayers(string[] layersArr = null)
        {
            if (layersArr == null)                                            // hidden layers
            {
                this.layers = new Layer[this.l_number];
                this.layers[0] = new Layer(this.X[0].pixels.Length * this.X[0].pixels[0].Length);
            }
            else
            {
                for (var i = 0; i < layersArr.Length; ++i)
                    this.layers[i] = new Layer(Convert.ToInt32(layersArr[i]));
            }
            this.layers[this.l_number - 1] = new Layer(this.Y.Length);         // the output layer
        }

        public void createWeights()
        {
            this.layers[0].weight = new double[this.X[0].pixels.Length * this.X[0].pixels[0].Length + 1][];
            for (int j = 0; j < this.layers[0].weight.Length; ++j)
                this.layers[0].weight[j] = new double[this.layers[0].number];

            for (int i = 1; i < this.l_number; ++i) {
                this.layers[i].weight = new double[this.layers[i - 1].number][];
                for (int j = 0; j < this.layers[i].weight.Length; ++j)
                    this.layers[i].weight[j] = new double[this.layers[i].number];
            }
        }

        public void addVectors() {
            for (int l = 0; l < this.l_number; ++l) {
                this.layers[l].y = new double[this.layers[l].weight.Length];
                this.layers[l].v = new double[this.layers[l].weight[0].Length];
                this.layers[l].delta = new double[this.layers[l].weight[0].Length];
            }

            this.e = new double[this.layers[this.l_number - 1].number];

            this.ind = new int[this.X.Length];
            for (int i = 0; i < this.ind.Length; ++i)
                ind[i] = i;
        }

    }

    public class Layer
    {
        public int number;
        public double speed;
        public double[] args;

        public Del func;
        public Del der;

        public double[][] weight;
        public double[] y;
        public double[] v;
        public double[] delta;


        public delegate double Del(double[] args, double x);

        public Layer(int n)
        {
            this.number = n;
        }
    }

}