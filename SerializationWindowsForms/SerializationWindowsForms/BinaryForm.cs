using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerializationWindowsForms
{
    public partial class BinaryForm : Form
    {
        public BinaryForm()
        {
            InitializeComponent();
        }

        StructureOfFolder structureOfFolder = new StructureOfFolder();

        private void Serializition_button_Click(object sender, EventArgs e)
        {
                string inputFolder = input.Text;
                structureOfFolder.Serialization(inputFolder);
        }

        private void DeSerializition_button_Click(object sender, EventArgs e)
        {
            string outputFolder = output.Text;
            structureOfFolder.Deserialization(outputFolder);
        }

     
    }
}
