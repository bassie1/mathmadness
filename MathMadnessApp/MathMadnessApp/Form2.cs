using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathMadnessApp
{
    public partial class Form2 : Form
    {
        List<Button> lstquestionbuttons;
        List<String> lstquestions;
        List<Button> lstanswerbuttons;
        List<string> lstanswers;
        public Form2()
        {
            InitializeComponent();
            lstquestionbuttons = new() { btnQ1, btnQ2, btnQ3, btnQ4, btnQ5, btnQ6, btnQ7, btnQ8 };
            btnStart.Click += BtnStart_Click;
        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
