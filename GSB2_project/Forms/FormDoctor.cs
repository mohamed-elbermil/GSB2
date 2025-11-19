using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSB2_project.DAO;
using GSB2_project.Models;

namespace GSB2_project.Forms
{
    public partial class FormDoctor : Form
    {
        public FormDoctor()
        {
            InitializeComponent();
            MedicineDAO medicineDAO = new MedicineDAO();
            List<Medicine> medList = medicineDAO.GetAll();
            this.dataGridViewDoctorListMedicine.DataSource = medList;
        }
    }
}
