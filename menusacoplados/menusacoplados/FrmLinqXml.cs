﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;

namespace menusacoplados
{
    public partial class FrmLinqXml : Form
    {
        public FrmLinqXml()
        {
            InitializeComponent();
        }
        private XDocument xmldoc;
        private string FILE = "productos2.0.xml";

        public void cargarDatos()
        {
            xmldoc = XDocument.Load(FILE);
            var data = xmldoc.Descendants("producto").Select(p => new
            {
                id = p.Element("id").Value,
                nombre = p.Element("nombre").Value,
                precio = p.Element("precio").Value,
                cantidad = p.Element("cantidad").Value,
                total = p.Element("total").Value
            }).OrderBy(p => p.id).ToList();


            txt_id.DataBindings.Clear();
            txt_nombre.DataBindings.Clear();
            txt_precio.DataBindings.Clear();
            txt_cant_vend.DataBindings.Clear();
            txt_total.DataBindings.Clear();
            txt_id.DataBindings.Add("text", data, "id");
            txt_nombre.DataBindings.Add("text", data, "nombre");
            txt_precio.DataBindings.Add("text", data, "precio");
            txt_cant_vend.DataBindings.Add("text", data, "cantidad");
            txt_total.DataBindings.Add("text", data, "total");
            dataGridView1.DataSource = data;
        }
        public double Total(double precio, int cantidad)
        {
            double total;
            total = precio * cantidad;

            return total;
        }

        public void metodoClear()
        {
            foreach (var item in Controls)
            {
                if (item is TextBox)
                {
                    (item as TextBox).Clear();
                }
            }
            txt_id.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            XElement emp = new XElement("producto",
            new XElement("id", txt_id.Text),
            new XElement("nombre", txt_nombre.Text),
            new XElement("precio", txt_precio.Text),
            new XElement("cantidad", txt_cant_vend.Text),
            new XElement("total", txt_total.Text));
            xmldoc.Root.Add(emp);
            xmldoc.Save(FILE);
            cargarDatos();
            metodoClear();
        }

        private void FrmLinqXml_Load(object sender, EventArgs e)
        {
            cargarDatos();
            txt_cant_vend.Clear();
            txt_id.Clear();
            txt_nombre.Clear();
            txt_precio.Clear();
            txt_total.Clear();
            txt_total.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XElement emp = xmldoc.Descendants("producto").FirstOrDefault(p => p.Element("id").Value == txt_id.Text);
            if (emp != null)
            {
                emp.Element("nombre").Value = txt_nombre.Text;
                emp.Element("precio").Value = txt_precio.Text;
                emp.Element("cantidad").Value = txt_cant_vend.Text;
                emp.Element("total").Value = txt_total.Text;
                xmldoc.Save(FILE);
                cargarDatos();
                metodoClear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            XElement emp = xmldoc.Descendants("producto").FirstOrDefault(p => p.Element("id").Value == txt_id.Text);
            if (emp != null)
            {
                emp.Remove();
                xmldoc.Save(FILE);
                cargarDatos();
                metodoClear();
            }
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            var excelApp = new Excel.Application();

            excelApp.Visible = true;
            excelApp.Workbooks.Add();

            Excel._Worksheet Hoja = (Excel.Worksheet)excelApp.ActiveSheet;

            //exportar lo datos de un datagridview a excel

            foreach (DataGridViewColumn columna in dataGridView1.Columns)
            {
                Hoja.Cells[1, columna.Index + 1] = columna.HeaderText;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    Hoja.Cells[fila.Index + 2, columna.Index + 1] = fila.Cells[columna.Index].Value;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(txt_cant_vend.Text);
            double precio = double.Parse(txt_precio.Text);

            txt_total.Text = Total(precio, cantidad).ToString();
        }

        private void FrmLinqXml_Activated(object sender, EventArgs e)
        {
            Left = 0;
            Top = 0;
        }
    }
}
