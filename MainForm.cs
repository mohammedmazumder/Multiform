using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/****************************************************************
// Programmer: Mohammed Mazumder
// Date: 7 May 2023
// Software: Microsoft Visual Studio 2019 Community Edition
// Platform: Microsoft Windows 10 Professional 64­bit
// Purpose: Multi form
// (Remember to run this with Ctrl+F5 to see the console output).
*************//

namespace Multiform1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void menuFile2D_Click(object sender, EventArgs e)
        {
            TwoDForm form = new TwoDForm();
            form.Show();
        }
        private void dragDropToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DragAndDrop dd = new DragAndDrop();
            dd.Show();
        }

        private void DoublyToolStripMenuItem_Click(object sender, EventArgs e)
        {
DoublyLinkForm dl = new DoublyLinkForm();
            dl.Show();
        }
        private void menuHelpAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name: Mohammed Mazumder\nCIT ID: CIT285443\nAssessment Title: Assessment2");
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
