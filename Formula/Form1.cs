using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtAltura.Clear();
            txtPeso.Clear();
            txtResultado.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float peso = float.Parse(txtPeso.Text);
            float altura = float.Parse(txtAltura.Text);
            float resultado;

            resultado = peso / (altura * altura);


            if (rbMasculino.Checked == true)
            {
                if (resultado >= 0 && resultado <= 20)
                {
                    txtResultado.Text = "Você Está Abaixo do Peso";


                }
                else if (resultado >= 21 && resultado <= 24.9)
                {
                    txtResultado.Text = "Você está normal";
                }
                else if (resultado >= 25 && resultado <= 29.9)
                {
                    txtResultado.Text = "Você esta com obesidade leve";
                }
                else if (resultado >= 30 && resultado <= 39.9)
                {
                    txtResultado.Text = "Você esta com obesidade moderada";
                }
                else if (resultado >= 40)
                {
                    txtResultado.Text = "Você esta com obesidade mórbida";
                }
            }
                if (rbFeminino.Checked == true)
                {
                    if (resultado >= 0 && resultado <= 19)
                    {
                        txtResultado.Text = "Você Está Abaixo do Peso";


                    }
                    else if (resultado >= 19 && resultado <= 23.9)
                    {
                        txtResultado.Text = "Você está normal";
                    }
                    else if (resultado >= 24 && resultado <= 28.9)
                    {
                        txtResultado.Text = "Você está com obesidade leve";
                    }
                    else if (resultado >= 29 && resultado <= 38.9)
                    {
                        txtResultado.Text = "Você está com obesidade moderada";
                    }
                    else if (resultado >= 39)
                    {
                        txtResultado.Text = "Você está com obesidade mórbida";
                    }


                }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
    }

