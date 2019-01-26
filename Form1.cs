using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACKS_Initiate_Tracker
{

    public partial class Form1 : Form
    {
        

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        public Random rnd = new Random();

        
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            var initList = new List<(string, decimal)>();

            var result1 = Roll(textBoxName1, spinnerMods1, textBoxInit1, deadBox1);
            initList.Add(result1);
            var result2 = Roll(textBoxName2, spinnerMods2, textBoxInit2, deadBox2);
            var result3 = Roll(textBoxName3, spinnerMods3, textBoxInit3, deadBox3);
            var result4 = Roll(textBoxName4, spinnerMods4, textBoxInit4, deadBox4);
            var result5 = Roll(textBoxName5, spinnerMods5, textBoxInit5, deadBox5);
            var result6 = Roll(textBoxName6, spinnerMods6, textBoxInit6, deadBox6);
            var result7 = Roll(textBoxName7, spinnerMods7, textBoxInit7, deadBox7);
            var result8 = Roll(textBoxName8, spinnerMods8, textBoxInit8, deadBox8);
            var result9 = Roll(textBoxName9, spinnerMods9, textBoxInit9, deadBox9);
            var result10 = Roll(textBoxName10, spinnerMods10, textBoxInit10, deadBox10);
            var result11 = Roll(textBoxName11, spinnerMods11, textBoxInit11, deadBox11);
            var result12 = Roll(textBoxName12, spinnerMods12, textBoxInit12, deadBox12);
            var result13 = Roll(textBoxName13, spinnerMods13, textBoxInit13, deadBox13);
            var result14 = Roll(textBoxName14, spinnerMods14, textBoxInit14, deadBox14);
            var result15 = Roll(textBoxName15, spinnerMods15, textBoxInit15, deadBox15);

        }

        public Tuple<string, decimal> Roll(TextBox nameBox, NumericUpDown modBox, TextBox initBox, CheckBox deadBox)
        {

            //Checks whether there is text in the Name box and whether Dead box is unchecked. If so, calculate an initiative of 1d6+mod.
            if (deadBox.Checked != true && nameBox.Text != "") 
            {
                //Here I should place the initiative value into a variable, so that it can be inserted into the tuple as well as stringed into the initBox
                decimal initiative = (rnd.Next(1, 7) + modBox.Value);
                initBox.Text = initiative.ToString();
                var fullInfo = Tuple.Create(nameBox.Text, initiative);
                return fullInfo;
            }
            else
            {
                initBox.Text = "";
                return null;
            }
            

        }


    }
}

//Things to do: 
//Associate each name with its corresponding initiative value. (Maybe turn them into a single string? Will they sort properly that way?)
//Compile these combinations into a list. 
//Sort list. 
//Print list to textBoxOutput.
