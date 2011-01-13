using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace ReflectionExample.UI
{
    public partial class RemessasForm : Form
    {
        string openFilePath = null;
        FixedColumnsSerializer serializer = new FixedColumnsSerializer(typeof(Remessa));

        public RemessasForm()
        {
            InitializeComponent();
            NewFile();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            if (openFilePath == null && saveFile.ShowDialog() == DialogResult.OK)
                openFilePath = saveFile.FileName;

            if (openFilePath != null)
                SaveFile(openFilePath);
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
                OpenFile(openFile.FileName);
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void SaveFile(string fileName)
        {
            using (var file = File.CreateText(fileName))
                serializer.WriteAll(file, remessas.DataSource as IEnumerable);

            OpenFile(fileName);
        }

        private void OpenFile(string fileName)
        {
            openFilePath = fileName;
            this.Text = openFilePath;

            using (var file = File.OpenText(openFilePath))
                remessas.DataSource = serializer.ReadAll(file);
        }

        private void NewFile()
        {
            openFilePath = null;
            this.Text = "novo";
            remessas.DataSource = new List<Remessa>();
        }



    }
}
