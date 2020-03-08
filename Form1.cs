using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tubes_Stima_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BG_Click(object sender, EventArgs e)
        {
            //
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            //
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int targetDay = int.Parse(dayTxtBox.Text);
                if (targetDay < 0 || targetDay > 20)
                {
                    throw new Exception("Query hari tidak boleh negatif atau lebih dari 20!");
                }
                string[] g = listKotaTxtBox.Text.Split('\n');
                Dictionary<string, City> map = new Dictionary<string, City>();
                int i = 0;
                string[] l = g[i++].Split(' ');
                string root = l[1];
                CityGraph graph = new CityGraph();
                int n = int.Parse(l[0]);
                while (n-- > 0)
                {
                    string[] line = g[i++].Split(' ');
                    map[line[0]] = new City(line[0], int.Parse(line[1]));
                    graph.MSAGLGraph.AddNode(new Node(line[0]));
                }
                g = petaTxtBox.Text.Split('\n');
                i = 0;
                n = int.Parse(g[i++]);
                while (n-- > 0)
                {
                    string[] line = g[i++].Split(' ');
                    graph.AddEdge(map[line[0]], map[line[1]], double.Parse(line[2]));
                }
                graph.Query(map[root], targetDay);
                SetGraph(graph);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Input tidak valid!\n" + ex.StackTrace);
            }
        }

        private void SetGraph(CityGraph g)
        {
            GViewer viewer = new GViewer();
            viewer.Graph = g.MSAGLGraph;
            panel1.SuspendLayout();
            viewer.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(viewer);
            panel1.ResumeLayout();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Peta hubungan file
            openFilePetaDialog.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // List kota file
            openFileListKotaDialog.ShowDialog();
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                listKotaTxtBox.Text = File.ReadAllText(openFileListKotaDialog.FileName, Encoding.UTF8);
            }
            catch
            {
                MessageBox.Show("Gagal membaca file!");
            }
        }

        private void openFilePetaDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                petaTxtBox.Text = File.ReadAllText(openFilePetaDialog.FileName, Encoding.UTF8);
            }
            catch
            {
                MessageBox.Show("Gagal membaca file!");
            }
        }
    }
}