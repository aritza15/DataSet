using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmTest : Form
    {
        public string mensaje = "";
        public Panel panel1 = new Panel();
        public Panel panel = new Panel();
        public List<CheckBox> listaCb = new List<CheckBox>();
        public List<PictureBox> listaPb = new List<PictureBox>();
        public List<Pregunta> ListaPreguntas;
        public FrmTest()
        {
            InitializeComponent();
        }

        private void FrmTest_Load(object sender, EventArgs e)
        {
            cboCat.Items.Clear();
            cboCat.Items.AddRange(Program.acceso.DevolverCategorias(out mensaje).ToArray());
            cboCat.DisplayMember = "Nombre";
        }

        private void cboCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboTest.Items.Clear();
            cboTest.Items.AddRange(Program.acceso.DevolverTestPorCategoria((cboCat.SelectedItem as Categoria).Id, out  mensaje).ToArray());
            cboTest.DisplayMember = "Nombre";
            MessageBox.Show(mensaje);
        }

        private void btnHacerTest_Click(object sender, EventArgs e)
        {
            int distancia = 0;
            ListaPreguntas = Program.acceso.DevolverPreguntasPorTest((cboTest.SelectedItem as Test).Id,out mensaje);
            if (ListaPreguntas.Count() == 0)
            {
                MessageBox.Show("Error, este test no tiene preguntas disponibles.");
                return;
            }
            Size = new Size(700, 600);

            foreach (Pregunta preg in ListaPreguntas)
            {

                panel.Location = new Point(30, 120 + distancia);
                panel.Size = new Size(700, 160 + distancia);
                TextBox txt = new TextBox();
                txt.Size = new Size(450, 20);
                txt.Location = new Point(30, 120 + distancia);
                txt.Text = preg.Enunciado;
                CheckBox cb = new CheckBox();
                listaCb.Add(cb);
                cb.Size = new Size(10, 10);
                cb.Location = new Point(550, 120 + distancia);
                Label lbl = new Label();
                lbl.Size = new Size(80, 20);
                lbl.Location = new Point(570, 120 + distancia);
                lbl.Text = "Verdadera";
                this.Controls.Add(panel);
                panel.Controls.Add(txt);
                panel.Controls.Add(cb);
                panel.Controls.Add(lbl);
                distancia += 40;
            }

            panel1.Location = new Point(30, 150 + distancia);
            panel1.Size = new Size(700, 300);
            Button btnHacer = new Button();
            btnHacer.Size = new Size(80, 20);
            btnHacer.Location = new Point(120, 150 + distancia);
            btnHacer.Text = "Hacer test";
            btnHacer.Click += new EventHandler(btnHacer_Click);
            Button btnCancelar = new Button();
            btnCancelar.Size = new Size(80, 20);
            btnCancelar.Location = new Point(250, 150 + distancia);
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += new EventHandler(btnCancelar_Click);
            this.Controls.Add(panel1);
            panel1.Controls.Add(btnHacer);
            panel1.Controls.Add(btnCancelar);

        }
        private void btnHacer_Click(object sender, EventArgs e)
        {
            int validas = 0;
            foreach (Pregunta preg in ListaPreguntas)
            {
                foreach (CheckBox cb in listaCb)
                {
                    if (cb.Checked && preg.Respuesta == true)
                    {
                        validas += 1;
                    }
                    else
                    {
                        PictureBox pb = new PictureBox();
                        pb.Image = Image.FromFile("../../../Icono/icono.png");
                        pb.Location = new Point(cb.Location.X - 40, cb.Location.Y);
                        listaPb.Add(pb);
                        panel.Controls.Add(pb);

                    }
                }
                break;
            }
            MessageBox.Show($"Has acertado {validas} preguntas");
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            foreach (PictureBox pb in listaPb)
            {
                if (pb.Image != null)
                {
                    pb.Image.Dispose();
                    pb.Image = null;
                }
            }
            foreach (CheckBox cb in listaCb)
            {
                if (cb.Checked)
                {
                    cb.Checked = false;
                }
            }
            listaPb.Clear();
            listaCb.Clear();
            this.Controls.Remove(panel);
            this.Controls.Remove(panel1);
            Size = new Size(700, 374);
        }
    }
}

