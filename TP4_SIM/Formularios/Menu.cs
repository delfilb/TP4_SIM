using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP4_SIM.Clases;

namespace TP4_SIM
{
    public partial class Menu : Form
    {
        private static readonly Random random = new Random();

        public Menu()
        {
            InitializeComponent();
        }

        private void monteCarlo(int desde, int hasta, int fila, int[] arreglo, int iteracion)
        {
            Persona persona = new Persona();
            double noAbre = 0.30;
            double rnd_Abre = random.NextDouble();
            string abre = "No abre";

            if (rnd_Abre <= noAbre)
            {
                Cliente(persona, abre, rnd_Abre, 0, desde, hasta, fila, arreglo, iteracion);
            }
            else
            {
                abre = "Abre";
                double rnd_cliente = random.NextDouble();
                if (rnd_cliente > 0.20)
                {
                    persona.genero = "Mujer";
                    persona.numSuscrip1 = 0.60;
                    persona.numSuscrip2 = 0.90;
                    persona.numSuscrip3 = 1;
                    persona.numSuscrip4 = 0;
                    persona.probCompra = 0.15;
                    Cliente(persona, abre, rnd_Abre, rnd_cliente,desde, hasta, fila, arreglo, iteracion);
                }
                else 
                {
                    persona.genero = "Hombre";
                    persona.numSuscrip1 = 0.10;
                    persona.numSuscrip2 = 0.50;
                    persona.numSuscrip3 = 0.80;
                    persona.numSuscrip4 = 1;
                    persona.probCompra = 0.25;
                    Cliente(persona, abre, rnd_Abre, rnd_cliente, desde, hasta, fila, arreglo, iteracion);
                }
            }
        }

        private void Cliente(Persona persona, string abre, double rnd_Abre, double rnd_cliente, int desde, int hasta, int fila, int[] arreglo, int iteracion)
        {
            
            double rnd_compra = 0;
            double rnd_suscripcion = 0;
   
            
            if (abre == "Abre")
            {
                rnd_compra = random.NextDouble();

                if (rnd_compra <= persona.probCompra)
                {
                    persona.venta = "Compra";
                    rnd_suscripcion = random.NextDouble();

                    if (rnd_suscripcion < persona.numSuscrip1)
                    {

                        persona.suscripcion = 1;

                    }
                    else
                    {

                        if (rnd_suscripcion < persona.numSuscrip2)
                        {

                            persona.suscripcion = 2;

                        }
                        else
                        {

                            if (rnd_suscripcion < persona.numSuscrip3)
                            {

                                persona.suscripcion = 3;

                            }
                            else
                            {

                                persona.suscripcion = 4;
                            }
                        }
                    }
                }
                else
                {
                    persona.venta = "No compra";
                }
            }


            int nuevo = persona.suscripcion * 2;
            //arreglo[fila] = arreglo[fila - 1] + nuevo;

            if (fila == 0)
            {
                arreglo[0] = nuevo;
                arreglo[1] = nuevo;
            }
            else
            {
                arreglo[0] = arreglo[0] + nuevo;
                if (nuevo > 0)
                {
                    arreglo[1] = nuevo;
                }
                
            }
            
            if (fila >= desde && fila <= hasta)
            {
                dgv_datos.Rows.Add(fila, Decimales.truncarA4Decimales(rnd_Abre), abre, Decimales.truncarA4Decimales(rnd_cliente), persona.genero, Decimales.truncarA4Decimales(rnd_compra), persona.venta, Decimales.truncarA4Decimales(rnd_suscripcion), persona.suscripcion, nuevo, arreglo[0]);
            }
            
            if(fila==iteracion)
            {
                dgv_datos.Rows.Add(fila, Decimales.truncarA4Decimales(rnd_Abre), abre, Decimales.truncarA4Decimales(rnd_cliente), persona.genero, Decimales.truncarA4Decimales(rnd_compra), persona.venta, Decimales.truncarA4Decimales(rnd_suscripcion), persona.suscripcion, nuevo, arreglo[0]);
            }
        }


        private void Menu_Load(object sender, EventArgs e)
        {

            // List View Mujer 
            ListViewItem lvl1 = new ListViewItem("Prob Abra", 0);
            lvl1.SubItems.Add("80%");
            lvl1.SubItems.Add("0,20");
            lvl1.SubItems.Add("1");

            ListViewItem lvl2 = new ListViewItem("Prob Compra", 0);
            lvl2.SubItems.Add("15%");
            lvl2.SubItems.Add("0");
            lvl2.SubItems.Add("0,14999");

            ListViewItem lvl3 = new ListViewItem("N° Suscrip 1", 0);
            lvl3.SubItems.Add("0,60");
            lvl3.SubItems.Add("0");
            lvl3.SubItems.Add("0,59");

            ListViewItem lvl4 = new ListViewItem("N° Suscrip 2", 0);
            lvl4.SubItems.Add("0.30");
            lvl4.SubItems.Add("0,60");
            lvl4.SubItems.Add("0,89");

            ListViewItem lvl5 = new ListViewItem("N° Suscrip 3", 0);
            lvl5.SubItems.Add("0.10");
            lvl5.SubItems.Add("0,90");
            lvl5.SubItems.Add("1");

            lv_mujer.Items.Add(lvl1);
            lv_mujer.Items.Add(lvl2);
            lv_mujer.Items.Add(lvl3);
            lv_mujer.Items.Add(lvl4);
            lv_mujer.Items.Add(lvl5);


            // List View Hombre

            ListViewItem lvl6 = new ListViewItem("Prob Abra", 0);
            lvl6.SubItems.Add("20%");
            lvl6.SubItems.Add("0");
            lvl6.SubItems.Add("0,19999");

            ListViewItem lvl7 = new ListViewItem("Prob Compra", 0);
            lvl7.SubItems.Add("25%");
            lvl7.SubItems.Add("0");
            lvl7.SubItems.Add("0,24999");

            ListViewItem lvl8 = new ListViewItem("N° Suscrip 1", 0);
            lvl8.SubItems.Add("0,10");
            lvl8.SubItems.Add("0");
            lvl8.SubItems.Add("0,09");

            ListViewItem lvl9 = new ListViewItem("N° Suscrip 2", 0);
            lvl9.SubItems.Add("0.40");
            lvl9.SubItems.Add("0,10");
            lvl9.SubItems.Add("0,49");

            ListViewItem lvl10 = new ListViewItem("N° Suscrip 3", 0);
            lvl10.SubItems.Add("0.30");
            lvl10.SubItems.Add("0,50");
            lvl10.SubItems.Add("0,79");

            ListViewItem lvl11 = new ListViewItem("N° Suscrip 4", 0);
            lvl11.SubItems.Add("0,20");
            lvl11.SubItems.Add("0,80");
            lvl11.SubItems.Add("1");

            lv_hombre.Items.Add(lvl6);
            lv_hombre.Items.Add(lvl7);
            lv_hombre.Items.Add(lvl8);
            lv_hombre.Items.Add(lvl9);
            lv_hombre.Items.Add(lvl10);
            lv_hombre.Items.Add(lvl11);


        }


        private void LimpiarCampos(){
            tbxIteracion.Text = "";
            tbxDesde.Text = "";
            tbxHasta.Text = "";
            dgv_datos.Rows.Clear();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string iter = tbxIteracion.Text;
            string des = tbxDesde.Text;
            string has = tbxHasta.Text;
              
            if (iter == "" || des == "" || has == "")
            {
                MessageBox.Show("Ingrese todo los valores");
                tbxIteracion.Focus();
            } else
            {
                int iteracion = int.Parse(iter);
                int desde = int.Parse(des);
                int hasta = int.Parse(has);

                int[] arreglo;
                arreglo = new int[2];

                if (desde >= hasta)
                {
                    MessageBox.Show("El valor 'Hasta' debe ser mayor al valor 'Desde'");
                    tbxDesde.Focus();
                }
                else
                {
                    if (desde < iteracion && hasta <= iteracion && hasta > desde)
                    {
                        for (int i = 0; i <= iteracion; i++)
                        {
                            monteCarlo(desde, hasta, i, arreglo, iteracion);
                        }
                    }
                    else { 
                        MessageBox.Show("Valores fuera de rango");
                        tbxDesde.Focus();
                    }
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
