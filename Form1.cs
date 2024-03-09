using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejer_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            comboBox1.Items.Add("Estados Unidos");
            comboBox1.Items.Add("Canadá");
            comboBox1.Items.Add("México");
            comboBox1.Items.Add("España");
            comboBox1.Items.Add("Francia");            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el país seleccionado
            string selectedCountry = comboBox1.SelectedItem.ToString();

            // Mostrar información relevante sobre el país seleccionado en los TextBox
            switch (selectedCountry)
            {
                case "Estados Unidos":
                    txt_Capital.Text = "Washington, D.C.";
                    txt_Idioma.Text = "Inglés";
                    txt_Poblacion.Text = "331 millones";
                    break;
                case "Canadá":
                    txt_Capital.Text = "Ottawa";
                    txt_Idioma.Text = "Inglés y Francés";
                    txt_Poblacion.Text = "38 millones";
                    break;
                case "México":
                    txt_Capital.Text = "Ciudad de México";
                    txt_Idioma.Text = "Español";
                    txt_Poblacion.Text = "126 millones";
                    break;
                case "España":
                    txt_Capital.Text = "Madrid";
                    txt_Idioma.Text = "Español";
                    txt_Poblacion.Text = "47 millones";
                    break;
                case "Francia":
                    txt_Capital.Text = "París";
                    txt_Idioma.Text = "Francés";
                    txt_Poblacion.Text = "67 millones";
                    break;                

            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Capital.Clear();
            txt_Idioma.Clear();
            txt_Poblacion.Clear();
        }      
        
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}

