using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRent
{
    public partial class Form1 : Form
    {
        //Folder name.name of the class and created the object
        Database.Database obj_Database = new Database.Database();
        public Form1()
        {
            InitializeComponent();
        }
      
        private void DGV_Rentmovie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_rentoutM_Click(object sender, EventArgs e)
        {
           //When click the button make it null
                DGV_Rentmovie.DataSource = null;
                try
            {
                // select the view form the database
                string queryObj = "Select * from ReturnOuts";
                DGV_Rentmovie.DataSource = obj_Database.FillDGV(queryObj);
                // To resize the data grid view
                DGV_Rentmovie.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_allMovie_Click(object sender, EventArgs e)
        {
            DGV_Rentmovie.DataSource = null;
            try
            {
                // select the view form the database
                string queryObj = "Select * from allMovie";
                //calling  the FillDGV class
                DGV_Rentmovie.DataSource = obj_Database.FillDGV(queryObj);
                // To resize the data grid view
                DGV_Rentmovie.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }

