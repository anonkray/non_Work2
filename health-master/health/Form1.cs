using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string op1,op2,op3,op4,op5;
            
    //เพศ
            if (radioButton1.Checked == true)
            {
                op1= " ชาย" ;
            }
            else
            {
                op1 = " หญิง" ;
            }
    //อายุ
            if (radioButton3.Checked == true)
            {
                op2= " 10-20 ปี" ;
            }
            else if (radioButton4.Checked == true)
            {
                op2= " 20-30 ปี";
            }
            else 
            {
               op2 = " มากกว่า 30 ปี" ;
            }
    //สมรส
            if (radioButton6.Checked == true)
            {
                op3= " โสด" ;
            }
            else if (radioButton7.Checked == true)
            {
                op3= " สมรส" ;
            }
            else if (radioButton8.Checked == true)
            {
                op3 =" แยกกันอยู่" ;
            }
            else
            {
                op3= " หม้าย/อย่า" ;
            }
    //ระดับการศึกษา
            
            if (radioButton10.Checked == true)
            {
                op4= " ต่ำกว่าปริญญาตรี" ;
            }
            else if (radioButton11.Checked == true)
            {
                op4= " ปริญญาตรี" ;
            }
            else
            {
                op4= " สูงกว่าปริญญาตรี" ;
            }
    //ออกกำลังกาย
            
            if (radioButton13.Checked == true)
            {
                op5= " เดิน" ;
            }
            else if (radioButton14.Checked == true)
            {
                op5= " วิ่งเหยาะๆ" ;
            }
            else if (radioButton15.Checked == true)
            {
                op5= " เต้นแอโรบิค" ;
            }
            else
            {
                op5= " ปั่นจักรยาน" ;
            }

            Form2 frm = new Form2(op1,op2,op3,op4,op5);
            frm.Show();

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
