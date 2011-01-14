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
            Novo();
        }

        private void novoMenu_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void Novo()
        {
            openFilePath = null;
            this.Text = "novo";
            remessas.DataSource = new List<Remessa>();
        }

        private void abrirMenu_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
                Abrir(openFile.FileName);
        }


        private void Abrir(string fileName)
        {
            openFilePath = fileName;
            this.Text = openFilePath;

            using (var file = File.OpenText(openFilePath))
            {
                remessas.CancelEdit();
                remessas.DataSource = serializer.ReadAll(file);
            }
        }

        private void salvarMenu_Click(object sender, EventArgs e)
        {
            grid.CommitEdit(DataGridViewDataErrorContexts.Commit);
            if (openFilePath == null && saveFile.ShowDialog() == DialogResult.OK)
                openFilePath = saveFile.FileName;

            if (openFilePath != null)
                Salvar(openFilePath);
        }

        private void Salvar(string fileName)
        {
            using (var file = File.CreateText(fileName))
                serializer.WriteAll(file, remessas.DataSource as IEnumerable);

            Abrir(fileName);
        }







    }
}
