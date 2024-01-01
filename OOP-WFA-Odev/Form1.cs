using OOP_WFA_Odev.Enums;
using System.Drawing.Imaging;

namespace OOP_WFA_Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static Bitmap resim;
        public static List<Arac> araclar = new List<Arac>();
        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (var item in Enum.GetNames(typeof(Enums.AracTuru)))
            {
                cmb_aracTuru.Items.Add(item);
            }
            foreach (var item in Enum.GetNames(typeof(Enums.Marka)))
            {
                cmb_aracMarkasi.Items.Add(item);
            }
            foreach (var item in Enum.GetNames(typeof(Enums.Model)))
            {
                cmb_aracModeli.Items.Add(item);
            }
            foreach (var item in Enum.GetNames(typeof(Enums.SanzimanTuru)))
            {
                cmb_sanzimanTuru.Items.Add(item);
            }
            foreach (var item in Enum.GetNames(typeof(Enums.YakitTuru)))
            {
                cmb_yakitTuru.Items.Add(item);
            }
            foreach (var item in Enum.GetNames(typeof(Enums.KasaTipi)))
            {
                cmb_kasaTipi.Items.Add(item);
            }
            chk_garanti.Checked = true;
            lbl_aracinRengi.BackColor = Color.Transparent;
            btn_resim.Enabled = false;
        }

        private void btn_aracinRengi_Click(object sender, EventArgs e)
        {
            cd_aracinRengi.ShowDialog();
            lbl_aracinRengi.BackColor = cd_aracinRengi.Color;
        }

        private void btn_aracResimEkle_Click(object sender, EventArgs e)
        {
            ofd_aracResmi.ShowDialog();
            try
            {
                resim = new Bitmap(ofd_aracResmi.FileName);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Lütfen aracýn resmini ekleyiniz.");
            }
            btn_resim.BackgroundImage = resim;
        }

        private void btn_olustur_Click(object sender, EventArgs e)
        {
            Arac arac = new Arac();
            try
            {
                arac.ModelYili = (int)nmr_model.Value;
                arac.MotorGucu = (int)nmr_motorGucu.Value;
                arac.Renk = lbl_aracinRengi.BackColor;
                arac.Resim = resim;

                if (arac.Resim == null)
                {
                    throw new Exception("Lütfen aracýn resmini ekleyiniz.");
                }
                if (arac.Renk == Color.Transparent)
                {
                    throw new Exception("Lütfen aracýn rengini belirleyiniz.");
                }
                foreach (Control item in gb_araclar.Controls)
                {
                    if (item is ComboBox)
                    {
                        ComboBox cmb = item as ComboBox;

                        if (cmb.SelectedItem != null)
                        {
                            arac.AracTuru = cmb_aracTuru.SelectedItem.ToString();
                            arac.Marka = cmb_aracMarkasi.SelectedItem.ToString();
                            arac.Model = cmb_aracModeli.SelectedItem.ToString();
                            arac.SanzimanTuru = cmb_sanzimanTuru.SelectedItem.ToString();
                            arac.YakitTuru = cmb_yakitTuru.SelectedItem.ToString();
                            arac.KasaTipi = cmb_kasaTipi.SelectedItem.ToString();
                        }
                        else
                        {
                            throw new Exception("Lütfen araç bilgilerini tam giriniz.");
                        }
                    }
                }
                arac.GarantiliMi = chk_garanti.Checked ? true : false;
                araclar.Add(arac);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            lst_arabaIncele.Items.Clear();

            foreach (Arac item in araclar)
            {
                lst_arabaIncele.Items.Add(item);
            }

            Temizle(gb_araclar.Controls);
        }

        private void lst_arabaIncele_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_arabaIncele.SelectedIndex != -1)
            {
                cmb_aracTuru.SelectedItem = ((Arac)lst_arabaIncele.SelectedItem).AracTuru;
                cmb_aracMarkasi.SelectedItem = ((Arac)lst_arabaIncele.SelectedItem).Marka;
                cmb_aracModeli.SelectedItem = ((Arac)lst_arabaIncele.SelectedItem).Model;
                cmb_sanzimanTuru.SelectedItem = ((Arac)lst_arabaIncele.SelectedItem).SanzimanTuru;
                cmb_yakitTuru.SelectedItem = ((Arac)lst_arabaIncele.SelectedItem).YakitTuru;
                cmb_kasaTipi.SelectedItem = ((Arac)lst_arabaIncele.SelectedItem).KasaTipi;
                chk_garanti.Checked = ((Arac)lst_arabaIncele.SelectedItem).GarantiliMi ? true : false;
                nmr_model.Value = ((Arac)lst_arabaIncele.SelectedItem).ModelYili;
                nmr_motorGucu.Value = ((Arac)lst_arabaIncele.SelectedItem).MotorGucu;
                lbl_aracinRengi.BackColor = ((Arac)lst_arabaIncele.SelectedItem).Renk;
                btn_resim.BackgroundImage = ((Arac)lst_arabaIncele.SelectedItem).Resim;
                pb_resim.BackgroundImage = ((Arac)lst_arabaIncele.SelectedItem).Resim;
            }
        }
        private static void Temizle(Control.ControlCollection collection)
        {
            foreach (Control control in collection)
            {
                if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                else if (control is NumericUpDown)
                {
                    ((NumericUpDown)control).Value = ((NumericUpDown)control).Minimum;
                }
                else if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = true;
                }
                else if (control is Label)
                {
                    Label lbl = control as Label;

                    if (lbl.Name == "lbl_aracinRengi")
                    {
                        lbl.BackColor = Color.Transparent;
                    }
                }
                else if (control is Button)
                {
                    Button btn = control as Button;

                    if (btn.Name == "btn_resim")
                    {
                        btn.BackgroundImage = null;
                    }
                }
            }
        }
    }
}
