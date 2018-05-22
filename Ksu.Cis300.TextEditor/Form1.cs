/*Ksu.Cis300.TextEditor.cs
 * Author: Joshua Weese
 * Modified by: Carlos Bryant Cerna
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu.Cis300.TextEditor
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Main form used to contain all components of the text editor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens the OpenFileDialogue menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (uxOpenFileDialogue.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Cannot Open File:" + uxOpenFileDialogue.FileName);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (uxSaveFileDialogue.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Cannot Save File:" + uxSaveFileDialogue.FileName);
            }
        }
    }
}
