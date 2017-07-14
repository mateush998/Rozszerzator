using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;

namespace Rozszerzator
{
    public partial class Form1 : Form
    {
        public Form1()
        {

          

            InitializeComponent();
            renameFileButton.Enabled = false;
            deleteFiles.Enabled = false;
            moveFiles.Enabled = false;
            compressFiles.Enabled = false;
            decompressFiles.Enabled = false;
            selectFolder.Enabled = false;

            
                      
        }

        public int intValue = 0; 

        public string path = "";

        public string newpathSec = "";

        public string pathSec = "";

        public string str = "";

        public string newpath = "";

        public string extension = ""; // string przechowujacy lancuch znakow z texboxa

        public string files = "";

        public string getExtension = ""; //string przechwytujacy stare rozszerzenie pliku

        public string ChangeFileExt = "";

        FolderBrowserDialog fbd = new FolderBrowserDialog();
        FolderBrowserDialog fbd2 = new FolderBrowserDialog();

        int controlString = 0;

        int controlFiles = 0;
        

        public string CheckIfExist = "";

        public void CheckExist()
        {
            if (CHB_bmp.Checked == true || CHB_jpg.Checked == true || CHB_mp3.Checked == true || CHB_wav.Checked == true
                || CHB_thm.Checked == true || CHB_txt.Checked == true || CHB_unlisted.Checked == true || CHB_selectAll.Checked == true
                || CHB_onlyZIP.Checked == true)
            {
                intValue = 1;
            }
        }

        public void CheckedExt()
        {
            if(CHB_selectAll.Checked == true)
            {
                files = "wszystkie w folderze";
            }

            if (CHB_selectAll.Checked == false)
            {
                if (CHB_mp3.Checked == true && controlString == 1)
                {
                    files += ".mp3 ";
                    controlString = 0;
                }
                else
                {
                   // if (files.IndexOf(".mp3") != -1) {}
                    files = files.Replace(".mp3", string.Empty);
                    controlString = 1;
                }

                if (CHB_wav.Checked == true && controlString == 1)
                {
                    files += ".wav ";
                    controlString = 0;
                }
                else
                {
                   // if (files.IndexOf(".wav") != -1) { }
                    files = files.Replace(".wav", string.Empty);
                    controlString = 1;
                }

                if (CHB_jpg.Checked == true && controlString == 1)
                {
                    files += ".jpg ";
                    controlString = 0;
                }
                else
                {
                    //if (files.IndexOf(".jpg") != -1) { }
                    files = files.Replace(".jpg", string.Empty);
                    controlString = 1;
                }

                if (CHB_bmp.Checked == true && controlString == 1)
                {
                    files += ".bmp ";
                    controlString = 0;
                }
                else
                {
                    //if (files.IndexOf(".bmp") != -1) { }
                    files = files.Replace(".bmp", string.Empty);
                    controlString = 1;
                }

                if (CHB_txt.Checked == true && controlString == 1)
                {
                    files += ".txt ";
                    controlString = 0;
                }
                else
                {
                    //if (files.IndexOf(".txt") != -1) { }
                    files = files.Replace(".txt", string.Empty);
                    controlString = 1;
                }

                if (CHB_thm.Checked == true && controlString == 1)
                {
                    files += ".thm ";
                    controlString = 0;
                }
                else
                {
                    //if (files.IndexOf(".thm") != -1) { }
                    files = files.Replace(".thm", string.Empty);
                    controlString = 1;
                }

                if (CHB_unlisted.Checked == true && controlString == 1)
                {
                    files += "pliki niewymienione ";
                    controlString = 0;
                }
                else
                {
                   // if (files.IndexOf("pliki niewymienione") != -1) { }
                    files = files.Replace("pliki niewymienione", string.Empty);
                    controlString = 1;
                }

                
            }

            

        }

     

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void helpButton_Click(object sender, EventArgs e) //Przycisk pomocy
        {
           // MessageBox.Show("Kliknij 'OTWÓRZ FOLDER', by otworzyć folder w którym chcesz zmienić rozszerzenie plików.\n\nWprowadź typ rozszerzenia w pasku poniżej przycisku 'ZMIEŃ NA', następnie kliknij na ten przycisk\n\nWpisz dowolne rozszerzenie w pasku rozszerzeń. Wpisując rozszerzenie po kropce zmienisz rozszerzenie pliku. Zostawiając puste pole paska rozszerzeń usuniesz rozszerzenie pliku.");
            Form2 formek2 = new Form2(); 
            formek2.Show();
        }

        public void openFileButton_Click(object sender, EventArgs e) //Przycisk otwierania folderu z plikami
        {
            //FolderBrowserDialog fbd = new FolderBrowserDialog();
           // fbd.RootFolder = Environment.SpecialFolder.MyDocuments;
            fbd.Description = "Wybierz folder z plikami: ";

            CheckExist();
            if (intValue == 1)
            {

                if (fbd.ShowDialog() == DialogResult.OK)
                {

                    renameFileButton.Enabled = true;
                    deleteFiles.Enabled = true;
                    selectFolder.Enabled = true;
                    compressFiles.Enabled = true;
                    decompressFiles.Enabled = true;

                    controlFiles = 0;

                    changeLog.Text = "Status:\n" + fbd.SelectedPath;
                    path = fbd.SelectedPath;
                    DirectoryInfo directory = new DirectoryInfo(path);

                    if (CHB_selectAll.Checked == true)
                    {
                        FileInfo[] Files = directory.GetFiles("*.*");
                        str = "";

                        foreach (FileInfo file in Files)
                        {
                            str = file.Name;
                            changeLog.Text += "\n" + str;
                            controlFiles = 0;
                            controlFiles++;
                        }
                    }

                    if (CHB_selectAll.Checked == false)
                    {

                        if (CHB_jpg.Checked == true)
                        {
                            FileInfo[] Files = directory.GetFiles("*.jpg");
                            str = "";

                            foreach (FileInfo file in Files)
                            {
                                str = file.Name;
                                changeLog.Text += "\n" + str;
                                controlFiles = 0;
                                controlFiles++;
                            }
                        }

                        if (CHB_bmp.Checked == true)
                        {
                            FileInfo[] Files = directory.GetFiles("*.bmp");
                            str = "";

                            foreach (FileInfo file in Files)
                            {
                                str = file.Name;
                                changeLog.Text += "\n" + str;
                                controlFiles = 0;
                                controlFiles++;
                            }
                        }

                        if (CHB_mp3.Checked == true)
                        {
                            FileInfo[] Files = directory.GetFiles("*.mp3");
                            str = "";

                            foreach (FileInfo file in Files)
                            {
                                str = file.Name;
                                changeLog.Text += "\n" + str;
                                controlFiles = 0;
                                controlFiles++;
                            }
                        }

                        if (CHB_wav.Checked == true)
                        {
                            FileInfo[] Files = directory.GetFiles("*.wav");
                            str = "";

                            foreach (FileInfo file in Files)
                            {
                                str = file.Name;
                                changeLog.Text += "\n" + str;
                                controlFiles = 0;
                                controlFiles++;
                            }
                        }

                        if (CHB_txt.Checked == true)
                        {
                            FileInfo[] Files = directory.GetFiles("*.txt");
                            str = "";

                            foreach (FileInfo file in Files)
                            {
                                str = file.Name;
                                changeLog.Text += "\n" + str;
                                controlFiles = 0;
                                controlFiles++;
                            }
                        }

                        if (CHB_onlyZIP.Checked == true)
                        {
                            FileInfo[] Files = directory.GetFiles("*.zip");
                            str = "";

                            changeLog.Text += "\nZostały wyświetlone jedynie pliki ZIP";

                            foreach (FileInfo file in Files)
                            {
                                str = file.Name;
                                changeLog.Text += "\n" + str;
                                controlFiles = 0;
                                controlFiles++;
                            }
                        }

                        if (CHB_thm.Checked == true)
                        {
                            FileInfo[] Files = directory.GetFiles("*.thm");
                            str = "";

                            foreach (FileInfo file in Files)
                            {
                                str = file.Name;
                                changeLog.Text += "\n" + str;
                                controlFiles = 0;
                                controlFiles++;
                            }
                        }

                        if (CHB_unlisted.Checked == true)
                        {
                            FileInfo[] Files = directory.GetFiles("*.*").Where(p => p.Extension != ".mp3"
                                && p.Extension != ".wav" && p.Extension != ".jpg" && p.Extension != ".bmp" && p.Extension != ".txt"
                                && p.Extension != ".thm").ToArray();
                            string str = "";

                            foreach (FileInfo file in Files)
                            {
                                str = file.Name;
                                changeLog.Text += "\n" + str;
                                controlFiles = 0;
                                controlFiles++;
                            }
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Wybierz jakieś rozszerzenie!");
            }
            
        }

        /// <summary>
        /// Przycisk zmian rozszerzen plikow pobiera z wczesniejszej metody wartosc stringa "path". Nastepnie przypisuje ta wartosc do "directory"
        /// i "pathSec". Dzialanie tej metody polega na operowaniu na plikach juz poprzedniego wyboru i zmienianu ich rozszerzen. "pathSec" jest
        /// stringiem zawierajacym lokalizacje folderu "path", nazwe aktualnego pliku "file" i dodatkowo slash "\" do operowania na folderach.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        public void renameFileButton_Click(object sender, EventArgs e) //Przycisk zmiany rozszerzenia w pliku
        {
            if (extensionBar.Text == "*.*" || extensionBar.Text == "*." || extensionBar.Text == ".*" || extensionBar.Text == ".")
            {
                MessageBox.Show("Wpisz jakieś rozszerzenie do paska rozszerzeń!");
            }
            else 
            {

                if (controlFiles != 0)
                {
                    DirectoryInfo directory = new DirectoryInfo(path);

                    extension = extensionBar.Text;
                    changeLog.Text = "Zmieniono w: " + path;
                    changeLog.Text += "\nRozszerzenie na : " + extension;

                    if (CHB_jpg.Checked == true)
                    {
                        FileInfo[] Files = directory.GetFiles("*.jpg");
                        str = "";

                        foreach (FileInfo file in Files)
                        {
                            str = file.Name;
                            changeLog.Text += "\n" + str;
                            pathSec = path + @"\" + file;
                            ChangeFileExt = Path.ChangeExtension(pathSec, extension);
                            File.Move(pathSec, ChangeFileExt);
                            changeLog.Text += "\nRozszerzenie pliku zostało zmienione!";
                            pathSec = path;

                        }
                    }

                    if (CHB_bmp.Checked == true)
                    {
                        FileInfo[] Files = directory.GetFiles("*.bmp");
                        str = "";

                        foreach (FileInfo file in Files)
                        {
                            str = file.Name;
                            changeLog.Text += "\n" + str;
                            pathSec = path + @"\" + file;
                            ChangeFileExt = Path.ChangeExtension(pathSec, extension);
                            File.Move(pathSec, ChangeFileExt);
                            changeLog.Text += "\nRozszerzenie pliku zostało zmienione!";
                            pathSec = path;

                        }
                    }

                    if (CHB_mp3.Checked == true)
                    {
                        FileInfo[] Files = directory.GetFiles("*.mp3");
                        str = "";

                        foreach (FileInfo file in Files)
                        {
                            str = file.Name;
                            changeLog.Text += "\n" + str;
                            pathSec = path + @"\" + file;
                            ChangeFileExt = Path.ChangeExtension(pathSec, extension);
                            File.Move(pathSec, ChangeFileExt);
                            changeLog.Text += "\nRozszerzenie pliku zostało zmienione!";
                            pathSec = path;

                        }
                    }

                    if (CHB_wav.Checked == true)
                    {
                        FileInfo[] Files = directory.GetFiles("*.wav");
                        str = "";

                        foreach (FileInfo file in Files)
                        {
                            str = file.Name;
                            changeLog.Text += "\n" + str;
                            pathSec = path + @"\" + file;
                            ChangeFileExt = Path.ChangeExtension(pathSec, extension);
                            File.Move(pathSec, ChangeFileExt);
                            changeLog.Text += "\nRozszerzenie pliku zostało zmienione!";
                            pathSec = path;

                        }
                    }

                    if (CHB_txt.Checked == true)
                    {
                        FileInfo[] Files = directory.GetFiles("*.txt");
                        str = "";

                        foreach (FileInfo file in Files)
                        {
                            str = file.Name;
                            changeLog.Text += "\n" + str;
                            pathSec = path + @"\" + file;
                            ChangeFileExt = Path.ChangeExtension(pathSec, extension);
                            File.Move(pathSec, ChangeFileExt);
                            changeLog.Text += "\nRozszerzenie pliku zostało zmienione!";
                            pathSec = path;

                        }
                    }

                    if (CHB_unlisted.Checked == true)
                    {
                        FileInfo[] Files = directory.GetFiles("*.*").Where(p => p.Extension != ".mp3"
                            && p.Extension != ".wav" && p.Extension != ".jpg" && p.Extension != ".bmp" && p.Extension != ".txt"
                            && p.Extension != ".thm").ToArray();
                        string str = "";

                        foreach (FileInfo file in Files)
                        {
                            str = file.Name;
                            changeLog.Text += "\n" + str;
                            pathSec = path + @"\" + file;
                            ChangeFileExt = Path.ChangeExtension(pathSec, extension);
                            File.Move(pathSec, ChangeFileExt);
                            changeLog.Text += "\nRozszerzenie pliku zostało zmienione!";
                            pathSec = path;

                        }
                    }

                    if (CHB_selectAll.Checked == true)
                    {
                        FileInfo[] Files = directory.GetFiles("*.*");
                        str = "";

                        foreach (FileInfo file in Files)
                        {
                            str = file.Name;
                            changeLog.Text += "\n" + str;
                            pathSec = path + @"\" + file;
                            ChangeFileExt = Path.ChangeExtension(pathSec, extension);
                            File.Move(pathSec, ChangeFileExt);
                            changeLog.Text += "\nRozszerzenie pliku zostało zmienione!";
                            pathSec = path;

                        }
                    }

                    if (CHB_thm.Checked == true)
                    {
                        FileInfo[] Files = directory.GetFiles("*.thm");
                        str = "";

                        foreach (FileInfo file in Files)
                        {
                            str = file.Name;
                            changeLog.Text += "\n" + str;
                            pathSec = path + @"\" + file;
                            ChangeFileExt = Path.ChangeExtension(pathSec, extension);
                            File.Move(pathSec, ChangeFileExt);
                            changeLog.Text += "\nRozszerzenie pliku zostało zmienione!";
                            pathSec = path;

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nie odnaleziono podanych plików!", "Błąd");
                }



            }
        }



        private void CHB_selectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (CHB_selectAll.Checked == true)
            {
                CHB_unlisted.Checked = true;
                CHB_jpg.Checked = true;
                CHB_bmp.Checked = true;
                CHB_mp3.Checked = true;
                CHB_wav.Checked = true;
                CHB_thm.Checked = true;
                CHB_txt.Checked = true;
            }
        }

        private void deleteFiles_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć te pliki?", "Usuwanie plików", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (controlFiles != 0)
            {

                if (dialogResult == DialogResult.Yes)
                {

                    DirectoryInfo directory = new DirectoryInfo(path);

                    CheckedExt();
                    changeLog.Text = "Usunięto w: " + path;
                    changeLog.Text += "\nPliki z rozszerzniem na : " + files;

                    if (CHB_jpg.Checked == true)
                    {
                        FileInfo[] Files = directory.GetFiles("*.jpg");
                        str = "";

                        foreach (FileInfo file in Files)
                        {
                            str = file.Name;
                            changeLog.Text += "\n" + str;
                            pathSec = path + @"\" + file;
                            //ChangeFileExt = Path.ChangeExtension(pathSec, extension);
                            File.Delete(pathSec);
                            changeLog.Text += "\nPlik został usunięty!";
                            pathSec = path;

                        }
                    }

                    if (CHB_bmp.Checked == true)
                    {
                        FileInfo[] Files = directory.GetFiles("*.bmp");
                        str = "";

                        foreach (FileInfo file in Files)
                        {
                            str = file.Name;
                            changeLog.Text += "\n" + str;
                            pathSec = path + @"\" + file;
                            //ChangeFileExt = Path.ChangeExtension(pathSec, extension);
                            File.Delete(pathSec);
                            changeLog.Text += "\nPlik został usunięty!";
                            pathSec = path;

                        }
                    }

                    if (CHB_mp3.Checked == true)
                    {
                        FileInfo[] Files = directory.GetFiles("*.mp3");
                        str = "";

                        foreach (FileInfo file in Files)
                        {
                            str = file.Name;
                            changeLog.Text += "\n" + str;
                            pathSec = path + @"\" + file;
                            //ChangeFileExt = Path.ChangeExtension(pathSec, extension);
                            File.Delete(pathSec);
                            changeLog.Text += "\nPlik został usunięty!";
                            pathSec = path;

                        }
                    }

                    if (CHB_wav.Checked == true)
                    {
                        FileInfo[] Files = directory.GetFiles("*.wav");
                        str = "";

                        foreach (FileInfo file in Files)
                        {
                            str = file.Name;
                            changeLog.Text += "\n" + str;
                            pathSec = path + @"\" + file;
                            // ChangeFileExt = Path.ChangeExtension(pathSec, extension);
                            File.Delete(pathSec);
                            changeLog.Text += "\nPlik został usunięty!";
                            pathSec = path;

                        }
                    }

                    if (CHB_txt.Checked == true)
                    {
                        FileInfo[] Files = directory.GetFiles("*.txt");
                        str = "";

                        foreach (FileInfo file in Files)
                        {
                            str = file.Name;
                            changeLog.Text += "\n" + str;
                            pathSec = path + @"\" + file;
                            // ChangeFileExt = Path.ChangeExtension(pathSec, extension);
                            File.Delete(pathSec);
                            changeLog.Text += "\nPlik został usunięty!";
                            pathSec = path;

                        }
                    }

                    if (CHB_unlisted.Checked == true)
                    {
                        FileInfo[] Files = directory.GetFiles("*.*").Where(p => p.Extension != ".mp3"
                            && p.Extension != ".wav" && p.Extension != ".jpg" && p.Extension != ".bmp" && p.Extension != ".txt"
                            && p.Extension != ".thm").ToArray();
                        string str = "";

                        foreach (FileInfo file in Files)
                        {
                            str = file.Name;
                            changeLog.Text += "\n" + str;
                            pathSec = path + @"\" + file;
                            // ChangeFileExt = Path.ChangeExtension(pathSec, extension);
                            File.Delete(pathSec);
                            changeLog.Text += "\nPlik został usunięty!";
                            pathSec = path;

                        }
                    }

                    if (CHB_selectAll.Checked == true)
                    {
                        FileInfo[] Files = directory.GetFiles("*.*");
                        str = "";

                        foreach (FileInfo file in Files)
                        {
                            str = file.Name;
                            changeLog.Text += "\n" + str;
                            pathSec = path + @"\" + file;
                            ChangeFileExt = Path.ChangeExtension(pathSec, extension);
                            File.Delete(pathSec);
                            changeLog.Text += "\nPlik został usunięty!";
                            pathSec = path;

                        }
                    }

                    if (CHB_thm.Checked == true)
                    {
                        FileInfo[] Files = directory.GetFiles("*.thm");
                        str = "";

                        foreach (FileInfo file in Files)
                        {
                            str = file.Name;
                            changeLog.Text += "\n" + str;
                            pathSec = path + @"\" + file;
                            ChangeFileExt = Path.ChangeExtension(pathSec, extension);
                            File.Delete(pathSec);
                            changeLog.Text += "\nPlik został usunięty!";
                            pathSec = path;

                        }
                    }
                }
                if (dialogResult == DialogResult.No) { }
            }
            else
            {
                MessageBox.Show("Nie odnaleziono podanych plików!", "Błąd");
            }
            


        }

        private void moveFiles_Click(object sender, EventArgs e)
        {
            if (controlFiles != 0)
            {
                DirectoryInfo directory = new DirectoryInfo(path);
                

                changeLog.Text += "\nPrzeniesiono do: " + newpath;
               

                if (CHB_jpg.Checked == true)
                {
                    FileInfo[] Files = directory.GetFiles("*.jpg");
                    str = "";

                    foreach (FileInfo file2 in Files)
                    {
                        str = file2.Name;
                        changeLog.Text += "\n" + str;
                        pathSec = path + @"\" + file2;
                        newpathSec = newpath + @"\" + file2;
                        //ChangeFileExt = Path.ChangeExtension(pathSec, extension);
                        File.Move(pathSec, newpathSec);
                        changeLog.Text += "\nPlik został przeniesiony!";
                        pathSec = path;
                        newpathSec = newpath;

                    }
                }

                if (CHB_bmp.Checked == true)
                {
                    FileInfo[] Files = directory.GetFiles("*.bmp");
                    str = "";

                    foreach (FileInfo file2 in Files)
                    {
                        str = file2.Name;
                        changeLog.Text += "\n" + str;
                        pathSec = path + @"\" + file2;
                        newpathSec = newpath + @"\" + file2;
                        //ChangeFileExt = Path.ChangeExtension(pathSec, extension);
                        File.Move(pathSec, newpathSec);
                        changeLog.Text += "\nPlik został przeniesiony!";
                        pathSec = path;
                        newpathSec = newpath;

                    }
                }

                if (CHB_mp3.Checked == true)
                {
                    FileInfo[] Files = directory.GetFiles("*.mp3");
                    str = "";

                    foreach (FileInfo file2 in Files)
                    {
                        str = file2.Name;
                        changeLog.Text += "\n" + str;
                        pathSec = path + @"\" + file2;
                        newpathSec = newpath + @"\" + file2;
                        //ChangeFileExt = Path.ChangeExtension(pathSec, extension);
                        File.Move(pathSec, newpathSec);
                        changeLog.Text += "\nPlik został przeniesiony!";
                        pathSec = path;
                        newpathSec = newpath;

                    }
                }

                if (CHB_wav.Checked == true)
                {
                    FileInfo[] Files = directory.GetFiles("*.wav");
                    str = "";

                    foreach (FileInfo file2 in Files)
                    {
                        str = file2.Name;
                        changeLog.Text += "\n" + str;
                        pathSec = path + @"\" + file2;
                        newpathSec = newpath + @"\" + file2;
                        // ChangeFileExt = Path.ChangeExtension(pathSec, extension);
                        File.Move(pathSec, newpathSec);
                        changeLog.Text += "\nPlik został przeniesiony!";
                        pathSec = path;
                        newpathSec = newpath;

                    }
                }

                if (CHB_txt.Checked == true)
                {

                    FileInfo[] Files = directory.GetFiles("*.txt");
                    str = "";

                    foreach (FileInfo file2 in Files)
                    {
               
                        str = file2.Name;
                        changeLog.Text += "\n" + str;
                        pathSec = path + @"\" + file2;
                        newpathSec = newpath + @"\" + file2;
                        // ChangeFileExt = Path.ChangeExtension(pathSec, extension);
                        File.Move(pathSec, newpathSec);
                        changeLog.Text += "\nPlik został przeniesiony!";
                        pathSec = path;
                        newpathSec = newpath;

                    }
                }

                if (CHB_unlisted.Checked == true)
                {
                    FileInfo[] Files = directory.GetFiles("*.*").Where(p => p.Extension != ".mp3"
                        && p.Extension != ".wav" && p.Extension != ".jpg" && p.Extension != ".bmp" && p.Extension != ".txt"
                        && p.Extension != ".thm").ToArray();
                    string str = "";

                    foreach (FileInfo file in Files)
                    {
                        str = file.Name;
                        changeLog.Text += "\n" + str;
                        pathSec = path + @"\" + file;
                        newpathSec = newpath + @"\" + file;
                        // ChangeFileExt = Path.ChangeExtension(pathSec, extension);
                        File.Move(pathSec, newpathSec);
                        changeLog.Text += "\nPlik został przeniesiony!";
                        pathSec = path;
                        newpathSec = newpath;

                    }
                }

                if (CHB_selectAll.Checked == true)
                {
                    FileInfo[] Files = directory.GetFiles("*.*");
                    str = "";

                    foreach (FileInfo file2 in Files)
                    {
                        str = file2.Name;
                        changeLog.Text += "\n" + str;
                        pathSec = path + @"\" + file2;
                        newpathSec = newpath + @"\" + file2;
                        ChangeFileExt = Path.ChangeExtension(pathSec, extension);
                        File.Move(pathSec, newpathSec);
                        changeLog.Text += "\nPlik został przeniesiony!";
                        pathSec = path;
                        newpathSec = newpath;

                    }
                }

                if (CHB_thm.Checked == true)
                {

                    FileInfo[] Files = directory.GetFiles("*.thm");
                    str = "";

                    foreach (FileInfo file2 in Files)
                    {
                        changeLog.Text += "\nPlik został przeniesiony!";
                        str = file2.Name;
                        changeLog.Text += "\n" + str;
                        pathSec = path + @"\" + file2;
                        newpathSec = newpath + @"\" + file2;
                        // ChangeFileExt = Path.ChangeExtension(pathSec, extension);
                        File.Move(pathSec, newpathSec);
                        //Directory.Move(path, newpath);
                        changeLog.Text += "\nPlik został przeniesiony!";
                        pathSec = path;
                        newpathSec = newpath;

                    }
                }
            }
            else
            {
                MessageBox.Show("Nie odnaleziono podanych plików!", "Błąd");
            }
        }

        private void compressFiles_Click(object sender, EventArgs e)
        {
            if (controlFiles != 0)
            {
                DirectoryInfo directory = new DirectoryInfo(path);

                string newDirPath;
                string secPathNew;
                string createZipFolder;

                changeLog.Text += "\nUtworzono nowy folder tymczasowy";
               

                if (CHB_jpg.Checked == true)
                {

                    newDirPath = path + @"\" + "jpgFiles"; 

                    Directory.CreateDirectory(newDirPath);

                    
                    FileInfo[] Files = directory.GetFiles("*.jpg");
                    str = "";

                    foreach (FileInfo file in Files)
                    {
                        pathSec = path + @"\" + file;
                        secPathNew = newDirPath + @"\" + file;
                        File.Move(pathSec, secPathNew);
                    }

                    changeLog.Text += "\nPrzeniesiono pliki do folderu tymczasowego";

                    createZipFolder = path + @"\" + "jpgFiles.zip";

                    ZipFile.CreateFromDirectory(path + @"\" + "jpgFiles", createZipFolder, CompressionLevel.Fastest, true);

                    changeLog.Text += "\nPomyślnie skompresowano pliki!";

                    Directory.Delete(path + @"\" + "jpgFiles", true);
                    changeLog.Text += "\nUsunięto folder tymczasowy";

                }

                if (CHB_bmp.Checked == true)
                {
                    newDirPath = path + @"\" + "bmpFiles";

                    Directory.CreateDirectory(newDirPath);


                    FileInfo[] Files = directory.GetFiles("*.bmp");
                    str = "";

                    foreach (FileInfo file in Files)
                    {
                        pathSec = path + @"\" + file;
                        secPathNew = newDirPath + @"\" + file;
                        File.Move(pathSec, secPathNew);
                    }

                    changeLog.Text += "\nPrzeniesiono pliki do folderu tymczasowego";

                    createZipFolder = path + @"\" + "bmpFiles.zip";

                    ZipFile.CreateFromDirectory(path + @"\" + "bmpFiles", createZipFolder, CompressionLevel.Fastest, true);

                    changeLog.Text += "\nPomyślnie skompresowano pliki!";

                    Directory.Delete(path + @"\" + "bmpFiles", true);
                    changeLog.Text += "\nUsunięto folder tymczasowy";
                }

                if (CHB_mp3.Checked == true)
                {
                    newDirPath = path + @"\" + "mp3Files";

                    Directory.CreateDirectory(newDirPath);


                    FileInfo[] Files = directory.GetFiles("*.mp3");
                    str = "";

                    foreach (FileInfo file in Files)
                    {
                        pathSec = path + @"\" + file;
                        secPathNew = newDirPath + @"\" + file;
                        File.Move(pathSec, secPathNew);
                    }

                    changeLog.Text += "\nPrzeniesiono pliki do folderu tymczasowego";

                    createZipFolder = path + @"\" + "mp3Files.zip";

                    ZipFile.CreateFromDirectory(path + @"\" + "mp3Files", createZipFolder, CompressionLevel.Fastest, true);

                    changeLog.Text += "\nPomyślnie skompresowano pliki!";

                    Directory.Delete(path + @"\" + "mp3Files", true);
                    changeLog.Text += "\nUsunięto folder tymczasowy";
                }

                if (CHB_wav.Checked == true)
                {
                    newDirPath = path + @"\" + "wavFiles";

                    Directory.CreateDirectory(newDirPath);


                    FileInfo[] Files = directory.GetFiles("*.wav");
                    str = "";

                    foreach (FileInfo file in Files)
                    {
                        pathSec = path + @"\" + file;
                        secPathNew = newDirPath + @"\" + file;
                        File.Move(pathSec, secPathNew);
                    }

                    changeLog.Text += "\nPrzeniesiono pliki do folderu tymczasowego";

                    createZipFolder = path + @"\" + "wavFiles.zip";

                    ZipFile.CreateFromDirectory(path + @"\" + "wavFiles", createZipFolder, CompressionLevel.Fastest, true);

                    changeLog.Text += "\nPomyślnie skompresowano pliki!";

                    Directory.Delete(path + @"\" + "wavFiles", true);
                    changeLog.Text += "\nUsunięto folder tymczasowy";
                }

                if (CHB_txt.Checked == true)
                {
                    newDirPath = path + @"\" + "txtFiles";

                    Directory.CreateDirectory(newDirPath);


                    FileInfo[] Files = directory.GetFiles("*.txt");
                    str = "";

                    foreach (FileInfo file in Files)
                    {
                        pathSec = path + @"\" + file;
                        secPathNew = newDirPath + @"\" + file;
                        File.Move(pathSec, secPathNew);
                    }

                    changeLog.Text += "\nPrzeniesiono pliki do folderu tymczasowego";

                    createZipFolder = path + @"\" + "txtFiles.zip";

                    ZipFile.CreateFromDirectory(path + @"\" + "txtFiles", createZipFolder, CompressionLevel.Fastest, true);

                    changeLog.Text += "\nPomyślnie skompresowano pliki!";

                    Directory.Delete(path + @"\" + "txtFiles", true);
                    changeLog.Text += "\nUsunięto folder tymczasowy";
                }

                if (CHB_unlisted.Checked == true)
                {
                    FileInfo[] Files = directory.GetFiles("*.*").Where(p => p.Extension != ".mp3"
                        && p.Extension != ".wav" && p.Extension != ".jpg" && p.Extension != ".bmp" && p.Extension != ".txt"
                        && p.Extension != ".thm").ToArray();
                    str = "";

                    newDirPath = path + @"\" + "unlistedFiles";

                    Directory.CreateDirectory(newDirPath);
                     
                    foreach (FileInfo file in Files)
                    {
                        pathSec = path + @"\" + file;
                        secPathNew = newDirPath + @"\" + file;
                        File.Move(pathSec, secPathNew);
                    }

                    changeLog.Text += "\nPrzeniesiono pliki do folderu tymczasowego";

                    createZipFolder = path + @"\" + "unlistedFiles.zip";

                    ZipFile.CreateFromDirectory(path + @"\" + "unlistedFiles", createZipFolder, CompressionLevel.Fastest, true);

                    changeLog.Text += "\nPomyślnie skompresowano pliki!";

                    Directory.Delete(path + @"\" + "unlistedFiles", true);
                    changeLog.Text += "\nUsunięto folder tymczasowy";
                }

                if (CHB_selectAll.Checked == true)
                {
                    newDirPath = path + @"\" + "allFiles";

                    Directory.CreateDirectory(newDirPath);


                    FileInfo[] Files = directory.GetFiles("*.*");
                    str = "";

                    foreach (FileInfo file in Files)
                    {
                        pathSec = path + @"\" + file;
                        secPathNew = newDirPath + @"\" + file;
                        File.Move(pathSec, secPathNew);
                    }

                    changeLog.Text += "\nPrzeniesiono pliki do folderu tymczasowego";

                    createZipFolder = path + @"\" + "allFiles.zip";

                    ZipFile.CreateFromDirectory(path + @"\" + "allFiles", createZipFolder, CompressionLevel.Fastest, true);

                    changeLog.Text += "\nPomyślnie skompresowano pliki!";

                    Directory.Delete(path + @"\" + "allFiles", true);
                    changeLog.Text += "\nUsunięto folder tymczasowy";
                }

                if (CHB_thm.Checked == true)
                {

                    newDirPath = path + @"\" + "thmFiles";

                    Directory.CreateDirectory(newDirPath);


                    FileInfo[] Files = directory.GetFiles("*.thm");
                    str = "";

                    foreach (FileInfo file in Files)
                    {
                        pathSec = path + @"\" + file;
                        secPathNew = newDirPath + @"\" + file;
                        File.Move(pathSec, secPathNew);
                    }

                    changeLog.Text += "\nPrzeniesiono pliki do folderu tymczasowego";

                    createZipFolder = path + @"\" + "thmFiles.zip";

                    ZipFile.CreateFromDirectory(path + @"\" + "thmFiles", createZipFolder, CompressionLevel.Fastest, true);

                    changeLog.Text += "\nPomyślnie skompresowano pliki!";

                    Directory.Delete(path + @"\" + "thmFiles", true);
                    changeLog.Text += "\nUsunięto folder tymczasowy";
                }
            }
            else
            {
                MessageBox.Show("Nie odnaleziono podanych plików!", "Błąd");
            }
        }

        private void decompressFiles_Click(object sender, EventArgs e)
        {

            DirectoryInfo directory = new DirectoryInfo(path);
            
            FileInfo[] Files = directory.GetFiles("*.zip");
            str = "";

            string zipPath;

            changeLog.Text += "\nPomyślnie zdekompresowano archiwum plików!";

            if (Files != null)
            {
                foreach (FileInfo file in Files)
                {
                    zipPath = path + @"\" + file;
                    ZipFile.ExtractToDirectory(zipPath, path);

                }
            }
            else
            {
                MessageBox.Show("Nie odnaleziono archiwów .ZIP w podanym folderze!", "Błąd");
            }
            
        }

        private void selectFolder_Click(object sender, EventArgs e)
        {
            fbd2.Description = "Wybierz folder: ";

            if (fbd2.ShowDialog() == DialogResult.OK)
            {
                changeLog.Text += "\nWybrano nowy folder: " + fbd2.SelectedPath;
                newpath = fbd2.SelectedPath;
                DirectoryInfo directory2 = new DirectoryInfo(newpath);
                moveFiles.Enabled = true;
            }
        }

        private void clearLog_Click(object sender, EventArgs e)
        {
            changeLog.Text = "";
        }

       

      
    }
}



