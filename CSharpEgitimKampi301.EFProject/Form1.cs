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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Öncelikle Entity'in olduğu modele ulaşmak gerekir Enti yazdıktan sonra gelir.
        EgitimKampiEFTravelDbEntities1 db = new EgitimKampiEFTravelDbEntities1();//Nesne türetir.Buraya yazmanın amacı bütün süslü parantezlerin içerisinde erişim sağlayabilir
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
        private void btnList_Click(object sender, EventArgs e)
        {
            //Listeleme işlemi yapar
            var values = db.Guide.ToList();//Guide. koyduktan sonra gelen bütün metotlar entity framework  metotlarıdır.
            dataGridView1.DataSource= values;//Datagrid aracının datasource (veri kısmına) values'ı yazdır
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guide guide=new Guide();
            guide.GuideName=txtName.Text;
            guide.GUideSurname=txtSurname.Text;
            db.Guide.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla eklendi");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //ID'ye göre silme işlemi yapılır.Çünkü Id eşsizdir ve sadece bir ID'ye göre silme işlemi yapılır
            //İlk önce ID'yi aldığımız aracı eşitleyeceğiz
            int id = int.Parse(txtId.Text);
            var removeValue = db.Guide.Find(6);
            db.Guide.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla silindi");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Güncellenecek olan ID'ye göre değer alır.
            int id=int.Parse(txtId.Text);//İlk önce Id bulunur
            var updateValue = db.Guide.Find(2);//ID'ye göre gelen idyi bul
            updateValue.GuideName = txtName.Text;//Göndereceğimiz yeni isim
            updateValue.GUideSurname=txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnGetByID_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var value = db.Guide.Where(x => x.GuideId == id).ToList(); //Bir şart yazılacak.
            dataGridView1.DataSource = value;
        }
    }
}
