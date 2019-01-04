using Assignment4.NewFolder1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//-----------------------------------
// Ben Powers
// Assignment 4 (Province Maintenance)
// Student Number 7986250
// Wednesday, July 24, 2018
//-----------------------------------

namespace Assignment4
{
    public partial class provinceMaintenance : Form
    {
        public provinceMaintenance()
        {
            InitializeComponent();
        }

        string provCde = "";
        string name = "";
        string countryCde = "";
        string taxCde = "";
        double taxRte = 0;

        // clears all fields of text fields on form
        private void clearAllFields()
        {
            provinceTextBox.Text = "";
            nameTextBox.Text = "";
            countryTextBox.Text = "";
            taxCodeTextBox.Text = "";
            taxRateTextBox.Text = "";
            federalCheckBox.Checked = false;
        }

        // new record button
        private void newRecordButton_Click(object sender, EventArgs e)
        {
            try // try catches to catch errors
            {
                provCde = provinceTextBox.Text; // string equals textboxs
                name = nameTextBox.Text;
                countryCde = countryTextBox.Text;
                taxCde = taxCodeTextBox.Text;
                taxRte = double.Parse(taxRateTextBox.Text);
                BPProvince p = new BPProvince(provCde, name,
                countryCde, taxCde, taxRte, federalCheckBox.Checked); // creating instance with all strings
                p.BPAdd(); // calling add function from BPProvince class
                provinceMaintenance_Load(sender, e);
                clearAllFields();
                listBoxProvince.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        private void provinceMaintenance_Load(object sender, EventArgs e)
        {
            listBoxProvince.Items.Clear();
            BPProvince province = new BPProvince();
            foreach (BPProvince currentProvince in province.BPGetProvinces())
            {
                listBoxProvince.Items.Add(currentProvince.ProvinceCode);
            }
        }

        // saves file
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                provCde = provinceTextBox.Text;
                name = nameTextBox.Text;
                countryCde = countryTextBox.Text;
                taxCde = taxCodeTextBox.Text;
                taxRte = double.Parse(taxRateTextBox.Text);
                BPProvince p = new BPProvince(provCde, name,
                countryCde, taxCde, taxRte, federalCheckBox.Checked);
                p.BPUpdate();
                provinceMaintenance_Load(sender, e);
                clearAllFields();
                listBoxProvince.SelectedIndex = listBoxProvince.Items.
               IndexOf(p.ProvinceCode);
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        // deletes file
        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                provCde = provinceTextBox.Text;
                name = nameTextBox.Text;
                countryCde = countryTextBox.Text;
                taxCde = taxCodeTextBox.Text;
                taxRte = double.Parse(taxRateTextBox.Text);
                BPProvince p = new BPProvince(provCde, name,
                countryCde, taxCde, taxRte, federalCheckBox.Checked);
                p.BPDelete();
                provinceMaintenance_Load(sender, e);
                clearAllFields();
                listBoxProvince.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Problems Deleting Records \n" + ex.Message;
            }
        }

        // closes form
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBoxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearAllFields();
            string currentCode = listBoxProvince.GetItemText(listBoxProvince.SelectedItem);
            BPProvince province = new BPProvince();
            string[] fields = province.BPGetByProvinceCode(currentCode).
            ToString().Split(new string[] { "|" }, StringSplitOptions.None);
            provinceTextBox.Text = fields[0];
            nameTextBox.Text = fields[1];
            countryTextBox.Text = fields[2];
            taxCodeTextBox.Text = fields[3];
            taxRateTextBox.Text = fields[4];
            if (Convert.ToBoolean(fields[5]))
            {
                federalCheckBox.Checked = true;
            }
        }
    }
}
