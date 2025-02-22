using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.Guide.Select(x => new//Guide tablosundaki sütunları listelemek için verilen bir ifadedir.
            {
                FullName = x.GuideName + " " + x.GUideSurname,
                x.GuideId
            }).ToList();
            cmbGuide.DisplayMember = "FullName";
            cmbGuide.ValueMember = "GuideId";
            cmbGuide.DataSource = values;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        EgitimKampiEFTravelDbEntities1 db = new EgitimKampiEFTravelDbEntities1();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values=db.Location.ToList();
            dataGridView1 .DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Location location=new Location();//Location tablosu üzerinen parametre üretir
            location.Capacity=byte.Parse(nudCapacity.Value.ToString());//Atama yapar.Numerikten gelen value değerini alır
            location.City=txtCity.Text;
            location.Country=txtCountry.Text;
            location.Price=decimal.Parse(txtPrice.Text.ToString());
            location.DayNight=txtDayNight.Text;
            location.GuideId=int.Parse(cmbGuide.SelectedValue.ToString());
            db.Location.Add(location);
            db.SaveChanges();
            MessageBox.Show("Ekleme işlemi başarılı!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtId.Text);
            var deletedvalue=db.Location.Find(id);
            db.Location.Remove(deletedvalue);
            db.SaveChanges();
            MessageBox.Show("Silme işlemi başarılı!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtId.Text);
            var updateValue=db.Location.Find(id);
            updateValue.DayNight = txtDayNight.Text;
            updateValue.Price=decimal.Parse(txtPrice.Text);
            updateValue.Capacity = byte.Parse(nudCapacity.Value.ToString());
            updateValue.City=txtCity.Text;
            updateValue.Country=txtCountry.Text;
            updateValue.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Güncelleme işlemi başarılı!");
        }
    }
}
