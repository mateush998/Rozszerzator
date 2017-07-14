using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rozszerzator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ControlHelp();
            pages.Text = "STRONA: " + control.ToString() + "/3";
        }

        int control = 1;

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void authorButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autorem tego programu jest Mateusz Podsiadło.\n\nPozdro elo program spoko, ładuj pliki kij Ci w oko");
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            control--;
            ControlHelp();
            pages.Text = "STRONA: " + control.ToString() + "/3";
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            control++;
            ControlHelp();
            pages.Text = "STRONA: " + control.ToString() + "/3";
        }

        public void ControlHelp()
        {
            if (control == 1)
            {
                previousButton.Enabled = false;

                Button1Text.Text = "OTWÓRZ FOLDER";
                Button2Text.Text = "ZMIEŃ NA";
                Button3Text.Text = "USUŃ PLIKI";

                ExtensionText.Text = ".MP3";

                Explain1.Text = "Przycisk otwiera okno dialogowe do wyboru folderu,\ngdzie znajdują się pliki przeznaczone do modyfikacji.\nPrzed wyborem folderu należy wybrać jedną z opcji formatów.\n";
                Explain2.Text = "Opcja wyboru formatu.";
                Explain3.Text = "Po naciśnięciu przycisku wybranemu plikowi zostanie zmienione rozszerzenie.\nPrzed zmianą rozszerzenia należy wpisać pożądane rozszerzenie\nw Pasku rozszerzeń plików.";
                Explain4.Text = "Pasek rozszerzeń plików. W nim należy wpisać jakieś rozszerzenie pliku.\nFormat wpisywania jest następujący: .gif - rozszerzenie po kropce.\nStandardowy format rozszerzenia; < > - pozostawienie czystego paska rozszerzeń.\nUsuwa bieżące rozszerzenie pliku (nie wpisywać żadnych symboli).";
                Explain5.Text = "Usuwa wszystkie pliki o danym rozszerzeniu lub wszystkie pliki z folderu\n(jeżeli wybrano wszystkie).";

                Button11.Visible = true;
                Button22.Visible = true;
                Button33.Visible = true;
                
                CheckBox11.Visible = true;
                ExtensionText.Visible = true;

                ExtensionBar11.Visible = true;
                ExtensionBarText.Visible = true;
                AllExtensionsText.Visible = true;

                ClearButton.Visible = false;
                ClearText.Visible = false;

                openFolder.Visible = false;

            }

            if (control == 2)
            {
                previousButton.Enabled = true;
                forwardButton.Enabled = true;

                Button11.Visible = true;
                Button22.Visible = true;
                Button33.Visible = true;

                Button1Text.Text = "PRZENIEŚ PLIKI";
                Button2Text.Text = "KOMPRESUJ PLIKI";
                Button3Text.Text = "DEKOMPRESUJ PLIKI";

                Explain1.Text = "Przenosi pliki pod wskazany folder. Należy wcześniej wybrać folder docelowy\nprzenoszenia plików poprzez wciśnięcie przycisku wyboru folderu.";
                Explain2.Text = "Przycisk wyboru folderu. Działa na zasadzie jak przycisk 'OTWÓRZ FOLDER'.";
                Explain3.Text = "Po naciśnięciu przycisku rusza proces kompresji wybranych plików.";
                Explain4.Text = "Przycisk czyści wszystkie wyniki wyświetlane na ekranie informacyjnym logów";
                Explain5.Text = "Po naciśnięciu przycisku rusza proces dekompresji archiwum .zip.\nBy zacząć proces dekompresji należy wybrać opcję\n'Niewymienione' lub 'Tylko dekompresja(zip)." ;

                CheckBox11.Visible = false;
                ExtensionText.Visible = false;

                ExtensionBar11.Visible = false;
                ExtensionBarText.Visible = false;
                AllExtensionsText.Visible = false;

                ClearText.Visible = true;
                ClearButton.Visible = true;
                

                openFolder.Visible = true;
            }

            if (control == 3)
            {
                forwardButton.Enabled = false;

                Button11.Visible = false;
                Button22.Visible = false;
                Button33.Visible = false;

                Button1Text.Text = "";
                Button2Text.Text = "";
                Button3Text.Text = "";

                Explain1.Text = "Wszelkie pytania proszę zostawiać na e-mail: matis.poo@wp.pl\n\nDziękuję za używanie mojego programu\n\nStaram się jak mogę być coś ze mnie było,\nwięc mam nadzieje, że program chociaż trochę się podoba.";
                Explain2.Text = "";
                Explain3.Text = "";
                Explain4.Text = "";
                Explain5.Text = "";

                CheckBox11.Visible = false;
                ExtensionText.Visible = false;

                ExtensionBar11.Visible = false;
                ExtensionBarText.Visible = false;
                AllExtensionsText.Visible = false;

                ClearText.Visible = false;
                ClearButton.Visible = false;


                openFolder.Visible = false;

            }
        }
    }
}
