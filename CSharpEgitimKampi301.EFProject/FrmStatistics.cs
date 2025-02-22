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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        EgitimKampiEFTravelDbEntities1 db=new EgitimKampiEFTravelDbEntities1();

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Location.Count().ToString();
            lblSumCapacity.Text = db.Location.Sum(x=>x.Capacity).ToString();//kapasiteyi toplar
            lblGuideCount.Text = db.Guide.Count().ToString();
            lblAvgcapacity.Text=db.Location.Average(x=>x.Capacity).ToString();//Kapasite tablosunun ortalamasını bize string olarak getirir
            lblAvgLocationPrice.Text = db.Location.Average(x => x.Price).ToString() + "£";

            int lastCountryId = db.Location.Max(x => x.LocationId);//Ekelenen son ülkenin max idisini bulur.
            lblLastCountryName.Text = db.Location.Where(x => x.LocationId == lastCountryId).Select(y => y.Country).FirstOrDefault();

            lblCappadociaLocationCapacity.Text=db.Location.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();//Tek değer getireceğimiz için FirstOrderDefault kullanılır
            lblTurkiyeCapacityAvg.Text=db.Location.Where(x=>x.Country=="Türkiye").Average(y=>y.Capacity).ToString();//Ülke bazında ortalama kapasiteyi bulur
            
           
            var romeGuideId=db.Location.Where(x=>x.City=="Roma").Select(y=>y.GuideId).FirstOrDefault(); //Roma gezisinin idisi lazım
            lblRomeGuideName.Text = db.Guide.Where(x => x.GuideId == romeGuideId).Select(y => y.GuideName + " " + y.GUideSurname).FirstOrDefault().ToString();//51.satırda bulduğumuz GuideId bulundu.

            var maxCapacity=db.Location.Max(x=>x.Capacity);
            lblmaxCapacityLocation.Text=db.Location.Where(x=>x.Capacity==maxCapacity).Select(y=>y.City).FirstOrDefault().ToString();//Select maksimum kapasiteye sahip şehiri çeker

            var maxPrice=db.Location.Max(x=>x.Price);
            lblMaxPriceLocation.Text=db.Location.Where(x=>x.Price==maxPrice).Select(y=>y.City).FirstOrDefault().ToString();

            var guideIdByNameAysegulCinar = db.Guide.Where(x => x.GuideName == "Ayşegül" && x.GUideSurname == "Çınar").Select(y => y.GuideId).FirstOrDefault();
            lblAysegulCinarLocationCount.Text=db.Location.Where(x=>x.GuideId==guideIdByNameAysegulCinar).Count().ToString();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
