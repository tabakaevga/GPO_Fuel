﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelArea;

namespace WindowsFormsApplication1
{
    public partial class StartingForm : Form
    {
        public StartingForm()
        {
            InitializeComponent();
        }

        private void AddObjectButton_Click(object sender, EventArgs e)
        {
            AddingForm addFigure = new AddingForm();
            addFigure.ShowDialog();
        }
    }
}
