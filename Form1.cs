using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MODUL3_1302220084
{
    public partial class Form1 : Form
    {   
        //deklarasi variabel result untuk menampilkan pada label dan final untuk menampung hasil penjumlahan
        string result;
        int final = 0;
        
        public Form1()
        {
            InitializeComponent();
        }
        
        //tombol ketika ditekan string result akan ditambahkan sesuai dengan text tombol
        private void button1_Click(object sender, EventArgs e)
        {   
            result += "1";
            label1.Text = result;
        }
        //tombol ketika ditekan string result akan ditambahkan sesuai dengan text tombol
        private void button3_Click(object sender, EventArgs e)
        {
            result += "3";
            label1.Text = result;
        }
        //tombol ketika ditekan string result akan ditambahkan sesuai dengan text tombol
        private void button5_Click(object sender, EventArgs e)
        {
            result += "5";
            label1.Text = result;
        }
        //tombol ketika ditekan string result akan ditambahkan sesuai dengan text tombol
        private void button11_Click(object sender, EventArgs e)
        {
            result += "0";
            label1.Text = result;
        }
        //tombol ketika ditekan string result akan ditambahkan sesuai dengan text tombol
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        //tombol ketika ditekan string result akan ditambahkan sesuai dengan text tombol
        private void button2_Click(object sender, EventArgs e)
        {
            result += "2";
            label1.Text = result;
        }
        //tombol ketika ditekan string result akan ditambahkan sesuai dengan text tombol
        private void button4_Click(object sender, EventArgs e)
        {
            result += "4";
            label1.Text = result;
        }
        //tombol ketika ditekan string result akan ditambahkan sesuai dengan text tombol
        private void button6_Click(object sender, EventArgs e)
        {
            result += "6";
            label1.Text = result;
        }
        //tombol ketika ditekan string result akan ditambahkan sesuai dengan text tombol
        private void button7_Click(object sender, EventArgs e)
        {
            result += "7";
            label1.Text = result;
        }
        //tombol ketika ditekan string result akan ditambahkan sesuai dengan text tombol
        private void button8_Click(object sender, EventArgs e)
        {
            result += "8";
            label1.Text = result;
        }
        //tombol ketika ditekan string result akan ditambahkan sesuai dengan text tombol
        private void button9_Click(object sender, EventArgs e)
        {
            result += "9";
            label1.Text = result;
        }
        //tombol ketika ditekan akan mengclear result dan 
        private void button10_Click(object sender, EventArgs e)
        {
            // tambah
            
            label1.Text = "";
            final += Int32.Parse(result);
            result = "";
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //sama dengan
         
            final += Int32.Parse(result);

            
            label1.Text = final.ToString();
            final = 0;
            result = "0";
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

//Int32.parse()
