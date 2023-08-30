using EjAlumnos.BackEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjAlumnos.FrontEnd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            //Instaciado el objeto objAlumno de la clase Alumno e inicializado dicho objeto
            Alumno objAlumno = new Alumno();

            //objAlumno.DNI = "1587458";

            lblSalida.Text = objAlumno.DNI;
        }
    }
}
