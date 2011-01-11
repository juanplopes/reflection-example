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
        public RemessasForm()
        {
            InitializeComponent();
            remessas.DataSource = new List<Remessa>();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var serializer = new FixedColumnsSerializer(typeof(Remessa));

            using (var file = File.CreateText("test.txt"))
                foreach (Remessa remessa in remessas.DataSource as IEnumerable)
                    serializer.Write(file, remessa);




        }
    }
}
