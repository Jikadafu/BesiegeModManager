using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.Diagnostics;

namespace BesiegeModManager
{
    public partial class Form1 : Form
    {
        public const int NumOfMods = 200;
        public int AddcounterS = 0;
        public int AddcounterD = 0;
        public int AddcounterM = 0;
        XElement xml = null;
        XDocument XDocument = new XDocument();
        XDocument settingXml = new XDocument();
        string settingFile = "";
        string set = "";


        public string FileLocation = @"C:\Program Files (x86)\Steam\steamapps\common\Besiege\Besiege_Data\Mods\Config\Modding.xml";
        public string[] elemTemp = new String[5];
        public string[,] ModLists = new string[NumOfMods, 6];
        public string[] DisableModLists = new string[NumOfMods];
        public OpenFileDialog openFileDialog = new OpenFileDialog();
        public CheckedListBox cLB_select = new CheckedListBox();
        public CheckedListBox cLB_maintenance = new CheckedListBox();


        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initialOpenSettingFile();
            LoadSettingFile();
            getXElement(FileLocation);
        }
        public void initialOpenSettingFile()
        {
            settingFile = Application.LocalUserAppDataPath;
            set = settingFile.Substring(0, settingFile.LastIndexOf(@"\") + 1);
            set = set.Remove(set.Length - 1);
            set = set.Substring(0, set.LastIndexOf(@"\") + 1);
            settingFile = set + "setting.xml";
            if (File.Exists(settingFile) == false)
            {
                //初期SettingFile作成
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                XmlWriter writer = XmlWriter.Create(settingFile, settings);
                writer.WriteStartElement("BesiegeModManager");
                writer.WriteElementString("FileLocation", FileLocation);
                writer.WriteElementString("NumberOfMod", AddcounterS.ToString());
                for (int i = 1; i < 10; i++)
                {
                    writer.WriteElementString("preset" + i, "プリセット" + i);
                }
                writer.WriteEndElement();
                writer.Close();
            }
            Directory.Delete(set + "\\BesiegeModManager", true);
            settingXml = XDocument.Load(settingFile);
            return;
        }

        public void SaveSettingFile()
        {
            XElement BMM = settingXml.Element("BesiegeModManager");
            XElement a = BMM.Element("FileLocation");
            a.ReplaceWith(new XElement("FileLocation", FileLocation));
            XElement b = BMM.Element("NumberOfMod");
            b.ReplaceWith(new XElement("NumberOfMod", AddcounterS.ToString()));
            settingXml.Save(settingFile);
        }

        public void LoadSettingFile()
        {
            /*
            FileLocation = settingXml.Element("FileLocation").Value ;
            string temp = settingXml.Element("NumberOfMod").Value;
            AddcounterS = Convert.ToInt32(temp);
            */
            XElement BMM = settingXml.Element("BesiegeModManager");
            FileLocation = BMM.Element("FileLocation").Value;
            string temp = BMM.Element("NumberOfMod").Value;
            AddcounterS = Convert.ToInt32(temp);
            preset1.Text = BMM.Element("preset1").Value;
            preset2.Text = BMM.Element("preset2").Value;
            preset3.Text = BMM.Element("preset3").Value;
            preset4.Text = BMM.Element("preset4").Value;
            preset5.Text = BMM.Element("preset5").Value;
            preset6.Text = BMM.Element("preset6").Value;
            preset7.Text = BMM.Element("preset7").Value;
            preset8.Text = BMM.Element("preset8").Value;
            preset9.Text = BMM.Element("preset9").Value;
        }

        private void moddingOpen_Click_1(object sender, EventArgs e)
        {
            openModdingXml();
        }

        public void openModdingXml()
        {
            LoadSettingFile();
            openFileDialog.Title = "Modding.xmlファイルを選択してください";
            openFileDialog.FileName = "Modding.xml";
            openFileDialog.InitialDirectory = FileLocation;
            openFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileLocation = openFileDialog.FileName;
                getXElement(openFileDialog.FileName);
                SaveSettingFile();
            }

            return;
        }

        public int getXElement(string FileName)
        {
            try
            {
                RemoveList();
                xml = XElement.Load(FileName);
                XDocument.Load(FileName);
                IEnumerable<XElement> elems = from el in xml.Descendants("String") select el;
                foreach (XElement elem in elems)
                {
                    SelectModList(elem);
                }
                IEnumerable<XElement> elems2 = from el2 in xml.Descendants("String") select el2;
                foreach (XElement elem2 in elems2)
                {
                    DisabledModsList(elem2);
                }
                MaintenanceModList();
                return 0;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public void SelectModList(XElement elem)
        {
            var eleme = (String)elem;
            string[] elemTemp = eleme.Replace("\r", "").Replace("\n", "").Split('~');
            if (elemTemp.Length == 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    ModLists[AddcounterS, i] = elemTemp[i];
                }
            }
            else if (elemTemp.Length == 4)
            {
                ModLists[AddcounterS, 0] = elemTemp[0];
                ModLists[AddcounterS, 1] = elemTemp[1];
                ModLists[AddcounterS, 2] = "None";
                ModLists[AddcounterS, 3] = elemTemp[2];
                ModLists[AddcounterS, 4] = elemTemp[3];
            }
            else
            {
                return;
            }
            ModLists[AddcounterS, 5] = elemTemp[3];
            cLB_select.Location = new Point(12, 48);
            cLB_select.Items.Add(ModLists[AddcounterS, 4]);
            cLB_select.Size = new Size(200, 30 + AddcounterS * 14);
            cLB_select.CheckOnClick = true;
            Controls.Add(cLB_select);
            AddcounterS++;
            return;
        }

        public void DisabledModsList(XElement elem)
        {
            var eleme = (String)elem;
            string[] elemTemp = eleme.Replace("\r", "").Replace("\n", "").Split('~');
            if (AddcounterD == 0)
            {
                AddcounterD = 1;
                return;
            }
            if (elemTemp.Length == 1)
            {
                for (int i = 0; i < 1; i++)
                {
                    DisableModLists[AddcounterD] = elemTemp[i];
                }
            }
            else
            {
                return;
            }
            AddcounterD++;
            return;
        }

        public void MaintenanceModList()
        {
            for (int i = 0; i < AddcounterS; i++)
            {
                for (int j = 0; j < AddcounterD; j++)
                {
                    if (ModLists[i, 0] == DisableModLists[j])
                    {

                        ModLists[i, 5] = "disabled";
                        break;
                    }
                    else
                    {
                        ModLists[i, 5] = "Maintenance";
                    }
                }
            }
            AddcounterM = AddcounterS - AddcounterD;
            for (int i = 0; i < AddcounterS; i++)
            {
                if (ModLists[i, 5] == "Maintenance")
                {
                    cLB_maintenance.Location = new Point(224, 48);
                    cLB_maintenance.Items.Add(ModLists[i, 4]);
                    cLB_maintenance.Size = new Size(200, 30 + (AddcounterM) * 14);
                    cLB_maintenance.CheckOnClick = true;
                    cLB_maintenance.Enabled = false;
                    Controls.Add(cLB_maintenance);
                    cLB_select.SetItemCheckState(i, CheckState.Checked);
                }
            }
            return;
        }

        private void MODApply_Click(object sender, EventArgs e)
        {
            ModApply();
        }

        public void ModApply()
        {
            int i;
            string ApplytingMod;
            ApplytingMod = "適用したMOD:\n";
            for (i = 0; i <= (cLB_select.Items.Count - 1); i++)
            {
                ModLists[i, 5] = "disabled";
                if (cLB_select.GetItemChecked(i))
                {
                    ApplytingMod += (i + 1).ToString() + ". " + cLB_select.Items[i].ToString() + "\n";
                    for (int j = 0; j < ModLists.Length; j++)
                    {

                        if (cLB_select.Items[i].ToString() == ModLists[j, 4])
                        {
                            ModLists[i, 5] = "Maintenance";
                            break;
                        }
                    }
                }
            }

            XElement strary = xml.Element("StringArray");
            var maintenanceStrAry = strary;
            strary.Remove();
            strary = xml.Element("StringArray");
            strary.Remove();
            xml.Add(maintenanceStrAry);
            XElement disableTree = new XElement("StringArray", new XAttribute("key", "disabled-mods"));
            for (i = 0; i < AddcounterS; i++)
            {
                if (ModLists[i, 5] == "disabled")
                {
                    XElement xElem = new XElement("String", ModLists[i, 0]);
                    disableTree.Add(xElem);
                }
            }
            xml.Add(disableTree);
            xml.Save(FileLocation);
            getXElement(FileLocation);
            return;
        }

        public void RemoveList()
        {
            Array.Clear(elemTemp, 0, elemTemp.Length);
            Array.Clear(ModLists, 0, ModLists.Length);
            Array.Clear(DisableModLists, 0, DisableModLists.Length);
            cLB_select.Items.Clear();
            cLB_maintenance.Items.Clear();
            Controls.Remove(cLB_select);
            Controls.Remove(cLB_maintenance);
            AddcounterS = 0;
            AddcounterD = 0;
            AddcounterM = 0;
            return;
        }

        private void vanilla_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < AddcounterS; i++)
            {
                cLB_select.SetItemCheckState(i, CheckState.Unchecked);
            }
            ModApply();
        }

        private void LocalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string LocalLocation = FileLocation;
            LocalLocation = LocalLocation.Replace("\\Besiege_Data\\Mods\\Config\\Modding.xml", "") + "\\Besiege.exe";
            Process.Start(LocalLocation);
        }

        private void steamToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("steam://rungameid/346010");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            SaveSettingFile();

            dr = MessageBox.Show("Modを適用して終了しますか？", Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                ModApply();
            }
            else if (dr == DialogResult.No)
            {

            }
            else if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }


        private void presetLoad(int num)
        {
            try
            {
                string presetfileLocation = set + "preset" + num + ".xml";
                XElement prefile = XElement.Load(presetfileLocation);
                //全部チェックを外してから
                for (int i = 0; i < cLB_select.Items.Count; i++)
                {
                    cLB_select.SetItemCheckState(i, CheckState.Unchecked);
                }
                //preset(num)でMaintenanceで記されたものにチェックを付ける
                XDocument.Load(presetfileLocation);
                IEnumerable<XElement> elems = from el in prefile.Descendants("Maintenance") select el;
                foreach (XElement elem in elems)
                {
                    for (int i = 0; i < cLB_select.Items.Count; i++)
                    {
                        string temp = cLB_select.Items[i].ToString();
                        var valtemp = (string)elem;

                        if (valtemp == temp )
                        {
                            cLB_select.SetItemCheckState(i, CheckState.Checked);
                            break;
                        }
                    }
                }
                ModApply();
            }
            catch (Exception)
            {
                return ;
            }
            

        }

        private void presetSave(int num)
        {
            string presetfileLocation = set + "preset" + num + ".xml";
            if (File.Exists(presetfileLocation) == false)
            {
                XmlWriterSettings presetfile = new XmlWriterSettings();
                presetfile.Indent = true;
                XmlWriter writer = XmlWriter.Create(presetfileLocation, presetfile);
                writer.WriteStartElement("BesiegeModManagerPreset");
                writer.WriteElementString("MaintenanceLists", " ");
                writer.WriteEndElement();
                writer.Close();
            }
            XElement prefile = XElement.Load(presetfileLocation);
            XElement MaintenanceLists = new XElement("MaintenanceLists");

            XElement temp = prefile.Element("MaintenanceLists");
            temp.Remove();

            /* //適用しているModをプリセットにセーブするとき
            for (int i = 0; i < AddcounterS; i++)
            {
                if (ModLists[i, 5] == "Maintenance")
                {
                    XElement xElement = new XElement("Maintenance", ModLists[i, 4]);
                    MaintenanceLists.Add(xElement);

                }
            }*/
            //現在チェックしているModをプリセットにセーブするとき
            foreach (var item in cLB_select.CheckedItems)
            {
                XElement xElement = new XElement("Maintenance", item);
                MaintenanceLists.Add(xElement);
            }
            prefile.Add(MaintenanceLists);
            prefile.Save(presetfileLocation);
        }


        //プリセット設定

        //preset1
        private void Load1_Click(object sender, EventArgs e)
        {
            presetLoad(1);
        }

        private void Save1_Click(object sender, EventArgs e)
        {
            presetSave(1);
        }

        private void toolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            XElement BMM = settingXml.Element("BesiegeModManager");
            XElement a = BMM.Element("preset1");
            a.ReplaceWith(new XElement("preset1", toolStripTextBox1.Text));
            settingXml.Save(settingFile);
            LoadSettingFile();
        }

        //preset2
        private void Load2_Click(object sender, EventArgs e)
        {
            presetLoad(2);
        }

        private void Save2_Click(object sender, EventArgs e)
        {
            presetSave(2);
        }

        private void toolStripTextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            XElement BMM = settingXml.Element("BesiegeModManager");
            XElement a = BMM.Element("preset2");
            a.ReplaceWith(new XElement("preset2", toolStripTextBox2.Text));
            settingXml.Save(settingFile);
            LoadSettingFile();
        }

        //preset3
        private void Load3_Click(object sender, EventArgs e)
        {
            presetLoad(3);
        }

        private void Save3_Click(object sender, EventArgs e)
        {
            presetSave(3);
        }

        private void toolStripTextBox3_KeyUp(object sender, KeyEventArgs e)
        {
            XElement BMM = settingXml.Element("BesiegeModManager");
            XElement a = BMM.Element("preset3");
            a.ReplaceWith(new XElement("preset3", toolStripTextBox3.Text));
            settingXml.Save(settingFile);
            LoadSettingFile();
        }

        //preset4
        private void Load4_Click(object sender, EventArgs e)
        {
            presetLoad(4);
        }

        private void Save4_Click(object sender, EventArgs e)
        {
            presetSave(4);
        }

        private void toolStripTextBox4_KeyUp(object sender, KeyEventArgs e)
        {
            XElement BMM = settingXml.Element("BesiegeModManager");
            XElement a = BMM.Element("preset4");
            a.ReplaceWith(new XElement("preset4", toolStripTextBox4.Text));
            settingXml.Save(settingFile);
            LoadSettingFile();
        }

        //preset5
        private void Load5_Click(object sender, EventArgs e)
        {
            presetLoad(5);
        }

        private void Save5_Click(object sender, EventArgs e)
        {
            presetSave(5);
        }

        private void toolStripTextBox5_KeyUp(object sender, KeyEventArgs e)
        {
            XElement BMM = settingXml.Element("BesiegeModManager");
            XElement a = BMM.Element("preset5");
            a.ReplaceWith(new XElement("preset5", toolStripTextBox5.Text));
            settingXml.Save(settingFile);
            LoadSettingFile();
        }

        //preset6
        private void Load6_Click(object sender, EventArgs e)
        {
            presetLoad(6);
        }

        private void Save6_Click(object sender, EventArgs e)
        {
            presetSave(6);
        }

        private void toolStripTextBox6_KeyUp(object sender, KeyEventArgs e)
        {
            XElement BMM = settingXml.Element("BesiegeModManager");
            XElement a = BMM.Element("preset6");
            a.ReplaceWith(new XElement("preset6", toolStripTextBox6.Text));
            settingXml.Save(settingFile);
            LoadSettingFile();
        }

        //preset7
        private void Load7_Click(object sender, EventArgs e)
        {
            presetLoad(7);
        }

        private void Save7_Click(object sender, EventArgs e)
        {
            presetSave(7);
        }

        private void toolStripTextBox7_KeyUp(object sender, KeyEventArgs e)
        {
            XElement BMM = settingXml.Element("BesiegeModManager");
            XElement a = BMM.Element("preset7");
            a.ReplaceWith(new XElement("preset7", toolStripTextBox7.Text));
            settingXml.Save(settingFile);
            LoadSettingFile();
        }

        //preset8
        private void Load8_Click(object sender, EventArgs e)
        {
            presetLoad(8);
        }

        private void Save8_Click(object sender, EventArgs e)
        {
            presetSave(8);
        }

        private void toolStripTextBox8_KeyUp(object sender, KeyEventArgs e)
        {
            XElement BMM = settingXml.Element("BesiegeModManager");
            XElement a = BMM.Element("preset8");
            a.ReplaceWith(new XElement("preset8", toolStripTextBox8.Text));
            settingXml.Save(settingFile);
            LoadSettingFile();
        }

        //preset9
        private void Load9_Click(object sender, EventArgs e)
        {
            presetLoad(9);
        }

        private void Save9_Click(object sender, EventArgs e)
        {
            presetSave(9);
        }

        private void toolStripTextBox9_KeyUp(object sender, KeyEventArgs e)
        {
            XElement BMM = settingXml.Element("BesiegeModManager");
            XElement a = BMM.Element("preset9");
            a.ReplaceWith(new XElement("preset9", toolStripTextBox9.Text));
            settingXml.Save(settingFile);
            LoadSettingFile();
        }

        
    }
}
