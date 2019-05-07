using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace WindowsFormsAppInetlabSMPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Assembly asembly = Assembly.LoadFrom("Path to assembly");

            foreach (CustomAttributeData atributedata in asembly.CustomAttributes)
            {
                Console.WriteLine(" Name : {0}", atributedata.AttributeType.Name);

                foreach (CustomAttributeTypedArgument argumentset in atributedata.ConstructorArguments)
                {
                    Console.WriteLine("   >> Value : {0} \n", argumentset.Value);
                }
            }
        }
    }
}
