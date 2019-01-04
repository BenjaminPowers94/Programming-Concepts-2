using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
//-----------------------------------
// Ben Powers
// Assignment 4 (Province Maintenance)
// Student Number 7986250
// Wednesday, July 24, 2018
//-----------------------------------

namespace Assignment4.NewFolder1
{
    public class BPProvince
    {
        StreamWriter sw = null;
        StreamReader sr = null;
        string fileLocation = Path.Combine(Environment.CurrentDirectory,
            "Province.txt");
        Boolean isEdit = false;

        public BPProvince(string provCode, string name,
        string countryCode, string taxCode, double taxRate, bool fedTax)
        {
            ProvinceCode = provCode;
            Name = name;
            CountryCode = countryCode;
            TaxCode = taxCode;
            TaxRate = taxRate;
            IncludesFederalTax = fedTax;
        }

        public BPProvince()
        {

        } 
        // using get set for 6 strings used in program
        public string ProvinceCode { get; set; } 
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string TaxCode { get; set; }
        public double TaxRate { get; set; }
        public Boolean IncludesFederalTax { get; set; }

        // List method to get provinces
        public List<BPProvince> BPGetProvinces()
        {
            List<BPProvince> prov = new List<BPProvince>(); // creating instance to call BPProvince Class
            try
            {
                if (!File.Exists(fileLocation)) // if file exists return prov
                    return prov;

                sr = new StreamReader(fileLocation); // reads fileLocation
                while (!sr.EndOfStream)
                {
                    string record = sr.ReadLine();
                    if (!String.IsNullOrEmpty(record))
                    {
                        prov.Add(BPParseProvince(record));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting province list to GetProvice" + ex.Message);
            }
            finally
            {
                if(sr != null)
                    sr.Close();
            }
            return prov;
        }

        // Get By Province Code Method
        public BPProvince BPGetByProvinceCode(string inputCode)
        {
            try
            {
                BPProvince province = new BPProvince(); // creating instance to call BPProvince Class
                using (StreamReader sr = new StreamReader(fileLocation))
                {
                    while (!sr.EndOfStream)
                    {
                        province = BPParseProvince(sr.ReadLine());

                        if (province.ProvinceCode == inputCode)
                        {
                            return province;
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error converting Record to Province "
                    + ex.Message);
            }
        }

        // Get By Province Name Method
        public BPProvince BPGetByProvinceName(string inputName)
        {
            try
            {
                BPProvince province = new BPProvince(); // creating instance to call BPProvince Class
                using (sr = new StreamReader(fileLocation))
                {
                    while (!sr.EndOfStream)
                    {
                        province = BPParseProvince(sr.ReadLine());

                        if (province.Name == inputName)
                        {
                            return province;
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error converting Record to Province "
                    + ex.Message);
            }
        }

        // Add Method
        public void BPAdd()
        {
            try
            {
                BPEdit();
                if (isEdit == false)
                {
                    sw = new StreamWriter(fileLocation, append: true);
                    sw.WriteLine(ToString());
                    sw.Close();
                }
                else
                {
                    throw new Exception("Error Province is already on file");
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error Trying to Add Province" + ex.Message);
            }
        }

        // update method
        public void BPUpdate()
        {
            BPEdit();
            if (!isEdit)
            {
                throw new Exception($"Unable to update non-existant record.");
            }
            else
            {
                BPDelete();
                isEdit = false;
                BPAdd();
            }
        }

        // Delete method
        public void BPDelete()
        {
            try
            {
                List<string> newFile = new List<string>();
                bool fileFound = false;
                sr = new StreamReader(fileLocation);
                while (!sr.EndOfStream)
                {
                    string record = sr.ReadLine();
                    string[] fields = record.Split(new string[] { "|" },
                        StringSplitOptions.None);
                    if (ProvinceCode != fields[0])
                    {
                        newFile.Add(record);
                    }
                    else
                    {
                        fileFound = true;
                    }
                }
                sr.Close();
                if (!fileFound)
                {
                    throw new Exception("Unable to delete a non existant " +
                        "record");
                }
                else
                {
                    sw = new StreamWriter(fileLocation, append: false);
                    foreach (string newRecord in newFile)
                    {
                        sw.WriteLine(newRecord);
                    }
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error reading records in Delete.\n"
                    + ex.Message);
            }
        }

        // Override ToString method using | as delimter
        public override string ToString()
        {
            return ProvinceCode + "|" + Name + "|" + CountryCode + "|" + TaxCode
                + "|" + TaxRate.ToString() + "|" + IncludesFederalTax.ToString();

        }

        // Parse Province Method
        public BPProvince BPParseProvince(string record)
        {
            try
            {
                string[] fields =
                record.Split(new string[] { "|" }, StringSplitOptions.None);
                string newRecords = fields[1] + " ";
                newRecords += fields[2];
                BPProvince province = new BPProvince();
                province.Name = fields[1];
                province.CountryCode = fields[2];
                province.TaxCode = fields[3];
                province.TaxRate = Double.Parse(fields[4]);
                province.ProvinceCode = fields[0];
                province.IncludesFederalTax = Convert.ToBoolean(fields[5]);
                return province;

            }
            catch (Exception ex)
            {
                throw new Exception("Error converting Record to Province "
                    + ex.Message);
            }
        }

        // Edit Method
        public void BPEdit()
        {
            Regex pattern = new Regex("^[A-Z][A-Z]$"); 
            Regex patternTwo = new Regex("^[A-Z][A-Z]+$");
            ProvinceCode = (ProvinceCode + "").Trim(); // trims access
            ProvinceCode = ProvinceCode.ToUpper(); // makes all letters Upper Case
            Name = (Name + "").Trim(); // trims access
            Name = char.ToUpper(Name[0]) + Name.Substring(1);
            CountryCode = (CountryCode + "").Trim();
            CountryCode = CountryCode.ToUpper(); // makes all letters Upper Case
            TaxCode = (TaxCode + "").Trim(); // trims access
            TaxCode = TaxCode.ToUpper(); // makes all letters Upper Case

            string errors = "";

            if (Name == "") // if name is left blank error message will display
            {
                errors += "Name cannot be empty\n"; // error message
            }
            if (!pattern.IsMatch(ProvinceCode)) // ensures that it has 2 characters
            {
                errors += "Province code does not match. Must be two letters\n";
            }
            if (!pattern.IsMatch(CountryCode)) // ensures that it has 2 characters
            {
                errors += "Country code does not match. Must be two letters\n"; // error message
            }

            foreach (BPProvince province in BPGetProvinces())
            {
                if (province.ProvinceCode == ProvinceCode)
                {
                    isEdit = true;
                }
                else if (province.Name == Name) // doesnt allow user to enter same province twice
                {
                    errors += "Name is already in use by other province code\n";
                }
            }
            if (TaxCode != "")
            {
                if (!patternTwo.IsMatch(TaxCode))
                {
                    errors += "Must be empty or contain two numbers only \n";
                }
                else if (TaxRate < 0 || TaxRate > 1) // ensures that tax rate isnt greater than 1
                {
                    errors += "Tax rate must be between 0 and 1 inclusive \n";
                }
            }
            else
            {
                if (TaxRate != 0)
                    errors += "If Tax Rate field is empty must be 0\n";
            }
            if (TaxRate == 0 && IncludesFederalTax)
            {
                errors += "If Tax Rate is 0, must not include Tax Rate\n";
            }
            if (errors != "")
            {
                throw new Exception(errors);
            }
        }
    }
}
    
    
