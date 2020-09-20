using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using RheinKraanKeuringLibrary;



namespace Rhein_Kraan_Keuring
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        // initalize
        public MainWindow()
        {
            Methods.InitializeModel();
            InitializeComponent();
        }

        private void Exit_Applcation(object sender, RoutedEventArgs e)
        {
           System.Windows.Application.Current.Shutdown();
            
        }

       
        private void Upload_Image(object sender, RoutedEventArgs e)
        {

            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string filename = ofd.FileName;
                    filepath.Content = filename;
                    BitmapImage src = new BitmapImage();
                    src.BeginInit();
                    src.UriSource = new Uri(filename, UriKind.Absolute);              
                    src.EndInit();
                    image1.Source = src;
                    
                    
                }
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception exception)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                System.Windows.Forms.MessageBox.Show("foutmelding", "fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };


        }


        private void Previous_Clicked(object sender, RoutedEventArgs e)
        {
            if (StaticModel.opdrachtnummer > 0)
            {
                Methods.StoreValues(StaticModel.lengte6dlist, StaticModel.opdrachtnummer, lenget6d1.Text, lenget6d2.Text, lenget6d3.Text, lenget6d4.Text, lenget6d5.Text);
                Methods.StoreValues(StaticModel.lengte30dlist, StaticModel.opdrachtnummer, lenget30d1.Text, lenget30d2.Text, lenget30d3.Text, lenget30d4.Text, lenget30d5.Text);
                Methods.StoreValues(StaticModel.IDlist, StaticModel.opdrachtnummer, id1.Text, id2.Text, id3.Text, id4.Text, id5.Text);
                Methods.StoreValues(StaticModel.afslijpinglist, StaticModel.opdrachtnummer, afslijping1.Text, afslijping2.Text, afslijping3.Text, afslijping4.Text, afslijping5.Text);
                Methods.StoreValues(StaticModel.roestlist, StaticModel.opdrachtnummer, corrosie1.Text, corrosie2.Text, corrosie3.Text, corrosie4.Text, corrosie5.Text);
                Methods.StoreValues(StaticModel.diameterlist, StaticModel.opdrachtnummer, diameter2.Text, diameter3.Text, diameter3.Text, diameter4.Text, diameter5.Text);
                Methods.StoreValues(StaticModel.positielist, StaticModel.opdrachtnummer, positie1.Text, positie2.Text, positie3.Text, positie4.Text, positie5.Text);
                Methods.StoreValues(StaticModel.beoordelinglist, StaticModel.opdrachtnummer, totaal1.Text, totaal2.Text, totaal3.Text, totaal4.Text, totaal5.Text);
                Methods.StoreValues(StaticModel.typelist, StaticModel.opdrachtnummer, beschadiging1.Text, beschadiging2.Text, beschadiging3.Text, beschadiging4.Text, beschadiging5.Text);
                Methods.StoreValues(StaticModel.typeroestlist, StaticModel.opdrachtnummer, roest1.Text, roest2.Text, roest3.Text, roest4.Text, roest5.Text);
                Methods.StoreValues(StaticModel.kabelleverancierlist, StaticModel.opdrachtnummer, kabelleverancier1.Text);
                Methods.StoreValues(StaticModel.waarnemingenlist, StaticModel.opdrachtnummer, waarnemingen1.Text);
                Methods.StoreValues(StaticModel.bedrijfsurenelist, StaticModel.opdrachtnummer, bedrijfsuren1.Text);
                Methods.StoreValues(StaticModel.redenenlist, StaticModel.opdrachtnummer, redenen1.Text);
                Methods.StoreValues(StaticModel.datelist, StaticModel.opdrachtnummer, Convert.ToString(label3.Content));
                Methods.StoreValues(StaticModel.imagepath, StaticModel.opdrachtnummer, Convert.ToString(filepath.Content));

                StaticModel.opdrachtnummer = StaticModel.opdrachtnummer - 1;
                nummer.Content = Convert.ToString(StaticModel.opdrachtnummer);

                Methods.AssignListInsideList(StaticModel.opdrachtnummer);
                
                lenget6d1.Text = ExtractedModel.lengte[0]; 
                lenget6d2.Text = ExtractedModel.lengte[1];
                lenget6d3.Text = ExtractedModel.lengte[2];
                lenget6d4.Text = ExtractedModel.lengte[3];
                lenget6d5.Text = ExtractedModel.lengte[4];

                //lengte30d
                lenget30d1.Text = ExtractedModel.lengte30[0];
                lenget30d2.Text = ExtractedModel.lengte30[1];
                lenget30d3.Text = ExtractedModel.lengte30[2];
                lenget30d4.Text = ExtractedModel.lengte30[3];
                lenget30d5.Text = ExtractedModel.lengte30[4];

                //id
                id1.Text = ExtractedModel.Id[0];
                id2.Text = ExtractedModel.Id[1];
                id3.Text = ExtractedModel.Id[2];
                id4.Text = ExtractedModel.Id[3];
                id5.Text = ExtractedModel.Id[4];
                //aflsijping
                afslijping1.Text = ExtractedModel.afslijping[0];
                afslijping2.Text = ExtractedModel.afslijping[1];
                afslijping3.Text = ExtractedModel.afslijping[2];
                afslijping4.Text = ExtractedModel.afslijping[3];
                afslijping5.Text = ExtractedModel.afslijping[4];
                //corrosie
                corrosie1.Text = ExtractedModel.roest[0];
                corrosie2.Text = ExtractedModel.roest[1];
                corrosie3.Text = ExtractedModel.roest[2];
                corrosie4.Text = ExtractedModel.roest[3];
                corrosie5.Text = ExtractedModel.roest[4];
                //diameter
                diameter1.Text = ExtractedModel.diameter[0];
                diameter2.Text = ExtractedModel.diameter[1];
                diameter3.Text = ExtractedModel.diameter[2];
                diameter4.Text = ExtractedModel.diameter[3];
                diameter5.Text = ExtractedModel.diameter[4];
                //positie
                positie1.Text = ExtractedModel.positie[0];
                positie2.Text = ExtractedModel.positie[1];
                positie3.Text = ExtractedModel.positie[2];
                positie4.Text = ExtractedModel.positie[3];
                positie5.Text = ExtractedModel.positie[4];
                //totaal
                totaal1.Text = ExtractedModel.beoordeling[0];
                totaal2.Text = ExtractedModel.beoordeling[1];
                totaal3.Text = ExtractedModel.beoordeling[2];
                totaal4.Text = ExtractedModel.beoordeling[3];
                totaal5.Text = ExtractedModel.beoordeling[4];
                //beschadiging
                beschadiging1.Text = ExtractedModel.type[0];
                beschadiging2.Text = ExtractedModel.type[1];
                beschadiging3.Text = ExtractedModel.type[2];
                beschadiging4.Text = ExtractedModel.type[3];
                beschadiging5.Text = ExtractedModel.type[4];
                //roest
                roest1.Text = ExtractedModel.typeroest[0];
                roest2.Text = ExtractedModel.typeroest[1];
                roest3.Text = ExtractedModel.typeroest[2];
                roest4.Text = ExtractedModel.typeroest[3];
                roest5.Text = ExtractedModel.typeroest[4];
                //datum*
                //kabelleverancier
                kabelleverancier1.Text = ExtractedModel.leverancier[0];
                //waarnemingen
                waarnemingen1.Text = ExtractedModel.waarnemingen[0];
                //handtekening*
                //bedrijfsuren
                bedrijfsuren1.Text = ExtractedModel.uren[0];
                //redenen
                redenen1.Text = ExtractedModel.reden[0];
                //datum
                label3.Content = ExtractedModel.datum[0];
                //image
                if (ExtractedModel.imageobj == "")
                {
                    image1.Source = null;
                    filepath.Content = "";
                }
                else
                {
                    BitmapImage src = new BitmapImage();
                    src.BeginInit();
                    src.UriSource = new Uri(ExtractedModel.imageobj, UriKind.Absolute);
                    src.EndInit();
                    image1.Source = src;
                    filepath.Content = ExtractedModel.imageobj;
                }

            }
        }

        private void Next_Clicked(object sender, RoutedEventArgs e)
        {
            Methods.StoreValues(StaticModel.lengte6dlist, StaticModel.opdrachtnummer, lenget6d1.Text, lenget6d2.Text, lenget6d3.Text, lenget6d4.Text, lenget6d5.Text);
            Methods.StoreValues(StaticModel.lengte30dlist, StaticModel.opdrachtnummer, lenget30d1.Text, lenget30d2.Text, lenget30d3.Text, lenget30d4.Text, lenget30d5.Text);
            Methods.StoreValues(StaticModel.IDlist, StaticModel.opdrachtnummer, id1.Text, id2.Text, id3.Text, id4.Text, id5.Text);
            Methods.StoreValues(StaticModel.afslijpinglist, StaticModel.opdrachtnummer, afslijping1.Text, afslijping2.Text, afslijping3.Text, afslijping4.Text, afslijping5.Text);
            Methods.StoreValues(StaticModel.roestlist, StaticModel.opdrachtnummer, corrosie1.Text, corrosie2.Text, corrosie3.Text, corrosie4.Text, corrosie5.Text);
            Methods.StoreValues(StaticModel.diameterlist, StaticModel.opdrachtnummer, diameter2.Text, diameter3.Text, diameter3.Text, diameter4.Text, diameter5.Text);
            Methods.StoreValues(StaticModel.positielist, StaticModel.opdrachtnummer, positie1.Text, positie2.Text, positie3.Text, positie4.Text, positie5.Text);
            Methods.StoreValues(StaticModel.beoordelinglist, StaticModel.opdrachtnummer, totaal1.Text, totaal2.Text, totaal3.Text, totaal4.Text, totaal5.Text);
            Methods.StoreValues(StaticModel.typelist, StaticModel.opdrachtnummer, beschadiging1.Text, beschadiging2.Text, beschadiging3.Text, beschadiging4.Text, beschadiging5.Text);
            Methods.StoreValues(StaticModel.typeroestlist, StaticModel.opdrachtnummer, roest1.Text, roest2.Text, roest3.Text, roest4.Text, roest5.Text);
            Methods.StoreValues(StaticModel.kabelleverancierlist, StaticModel.opdrachtnummer, kabelleverancier1.Text);
            Methods.StoreValues(StaticModel.waarnemingenlist, StaticModel.opdrachtnummer, waarnemingen1.Text);
            Methods.StoreValues(StaticModel.bedrijfsurenelist, StaticModel.opdrachtnummer, bedrijfsuren1.Text);
            Methods.StoreValues(StaticModel.redenenlist, StaticModel.opdrachtnummer, redenen1.Text);
            Methods.StoreValues(StaticModel.datelist, StaticModel.opdrachtnummer, Convert.ToString(label3.Content));
            Methods.StoreValues(StaticModel.imagepath, StaticModel.opdrachtnummer, Convert.ToString(filepath.Content));


            StaticModel.opdrachtnummer = StaticModel.opdrachtnummer + 1;
            nummer.Content = Convert.ToString(StaticModel.opdrachtnummer);

            if (StaticModel.maximumgecreerde < StaticModel.opdrachtnummer)
            {
                StaticModel.maximumgecreerde = StaticModel.opdrachtnummer;

                lenget6d1.Clear();
                lenget6d2.Clear();
                lenget6d3.Clear();
                lenget6d4.Clear();
                lenget6d5.Clear();

                lenget30d1.Clear();
                lenget30d2.Clear();
                lenget30d3.Clear();
                lenget30d4.Clear();
                lenget30d5.Clear();

                id1.Clear();
                id2.Clear();
                id3.Clear();
                id4.Clear();
                id5.Clear();

                afslijping1.Clear();
                afslijping2.Clear();
                afslijping3.Clear();
                afslijping4.Clear();
                afslijping5.Clear();

                corrosie1.Clear();
                corrosie2.Clear();
                corrosie3.Clear();
                corrosie4.Clear();
                corrosie5.Clear();

                diameter1.Clear();
                diameter2.Clear();
                diameter3.Clear();
                diameter4.Clear();
                diameter5.Clear();

                positie1.Clear();
                positie2.Clear();
                positie3.Clear();
                positie4.Clear();
                positie5.Clear();

                totaal1.Clear();
                totaal2.Clear();
                totaal3.Clear();
                totaal4.Clear();
                totaal5.Clear();

                beschadiging1.Clear();
                beschadiging2.Clear();
                beschadiging3.Clear();
                beschadiging4.Clear();
                beschadiging5.Clear();

                roest1.Clear();
                roest2.Clear();
                roest3.Clear();
                roest4.Clear();
                roest5.Clear();

                kabelleverancier1.Clear();


                waarnemingen1.Clear();


                bedrijfsuren1.Clear();


                redenen1.Clear();

                label3.Content = "";

                image1.Source = null;
                filepath.Content = "";

            }
            else
            {
                Methods.AssignListInsideList(StaticModel.opdrachtnummer);
                    lenget6d1.Text = ExtractedModel.lengte[0];
                    lenget6d2.Text = ExtractedModel.lengte[1];
                    lenget6d3.Text = ExtractedModel.lengte[2];
                    lenget6d4.Text = ExtractedModel.lengte[3];
                    lenget6d5.Text = ExtractedModel.lengte[4];

                    lenget30d1.Text = ExtractedModel.lengte30[0];
                lenget30d2.Text = ExtractedModel.lengte30[1];
                lenget30d3.Text = ExtractedModel.lengte30[2];
                lenget30d4.Text = ExtractedModel.lengte30[3];
                lenget30d5.Text = ExtractedModel.lengte30[4];

              
                id1.Text = ExtractedModel.Id[0];
                id2.Text = ExtractedModel.Id[1];
                id3.Text = ExtractedModel.Id[2];
                id4.Text = ExtractedModel.Id[3];
                id5.Text = ExtractedModel.Id[4];

     
                afslijping1.Text = ExtractedModel.afslijping[0];
                afslijping2.Text = ExtractedModel.afslijping[1];
                afslijping3.Text = ExtractedModel.afslijping[2];
                afslijping4.Text = ExtractedModel.afslijping[3];
                afslijping5.Text = ExtractedModel.afslijping[4];

            
                corrosie1.Text = ExtractedModel.roest[0];
                corrosie2.Text = ExtractedModel.roest[1];
                corrosie3.Text = ExtractedModel.roest[2];
                corrosie4.Text = ExtractedModel.roest[3];
                corrosie5.Text = ExtractedModel.roest[4];

                diameter1.Text = ExtractedModel.diameter[0];
                diameter2.Text = ExtractedModel.diameter[1];
                diameter3.Text = ExtractedModel.diameter[2];
                diameter4.Text = ExtractedModel.diameter[3];
                diameter5.Text = ExtractedModel.diameter[4];

                positie1.Text = ExtractedModel.positie[0];
                positie2.Text = ExtractedModel.positie[1];
                positie3.Text = ExtractedModel.positie[2];
                positie4.Text = ExtractedModel.positie[3];
                positie5.Text = ExtractedModel.positie[4];

                totaal1.Text = ExtractedModel.beoordeling[0];
                totaal2.Text = ExtractedModel.beoordeling[1];
                totaal3.Text = ExtractedModel.beoordeling[2];
                totaal4.Text = ExtractedModel.beoordeling[3];
                totaal5.Text = ExtractedModel.beoordeling[4];

                beschadiging1.Text = ExtractedModel.type[0];
                beschadiging2.Text = ExtractedModel.type[1];
                beschadiging3.Text = ExtractedModel.type[2];
                beschadiging4.Text = ExtractedModel.type[3];
                beschadiging5.Text = ExtractedModel.type[4];

                roest1.Text = ExtractedModel.typeroest[0];
                roest2.Text = ExtractedModel.typeroest[1];
                roest3.Text = ExtractedModel.typeroest[2];
                roest4.Text = ExtractedModel.typeroest[3];
                roest5.Text = ExtractedModel.typeroest[4];

                kabelleverancier1.Text = ExtractedModel.leverancier[0];

                waarnemingen1.Text = ExtractedModel.waarnemingen[0];

                bedrijfsuren1.Text = ExtractedModel.uren[0];

                redenen1.Text = ExtractedModel.reden[0];

                label3.Content = ExtractedModel.datum[0];

                if (ExtractedModel.imageobj == "")
                {
                    image1.Source = null;
                    filepath.Content = "";
                }
                else
                {
                    BitmapImage src = new BitmapImage();
                    src.BeginInit();
                    src.UriSource = new Uri(ExtractedModel.imageobj, UriKind.Absolute);
                    src.EndInit();
                    image1.Source = src;
                    filepath.Content = ExtractedModel.imageobj;
                }

            }



        }

        private void datum1_CalendarClosed(object sender, RoutedEventArgs e)
        {
           

            try
            {
                SaveDate.savedate = datum1.SelectedDate.Value.Date.ToShortDateString().ToString();
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (InvalidOperationException exception)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                SaveDate.savedate = "";
            }

            label3.Content = SaveDate.savedate;
        }
    }
}

