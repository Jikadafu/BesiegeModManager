using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
        XmlDocument xmlDocument = new XmlDocument();
        public string FileLocation = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Besiege\\Besiege_Data\\Mods\\Config\\Modding.xml";
        public string[] elemTemp = new String[5];
        public string[,] ModLists = new string[NumOfMods, 6];
        public string[] DisableModLists = new string[NumOfMods];
        public OpenFileDialog openFileDialog = new OpenFileDialog();
        public CheckedListBox cLB_select = new CheckedListBox();
        public CheckedListBox cLB_maintenance = new CheckedListBox();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getXElement(FileLocation);
        }


        private void moddingOpen_Click_1(object sender, EventArgs e)
        {
            openModdingXml();
        }

        public void openModdingXml()
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Modding.xmlファイルを選択してください";
            openFileDialog.FileName = "Modding.xml";
            openFileDialog.InitialDirectory = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Besiege\\Besiege_Data\\Mods\\Config";
            openFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileLocation = openFileDialog.FileName;
                //RemoveList();
                getXElement(openFileDialog.FileName);
            }

            return;
        }
        public int getXElement(string FileName)
        {
            try
            {
                RemoveList();
                xml = XElement.Load(FileName);
                xmlDocument.Load(FileName);
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
            return ;
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
                    if (ModLists[i,0] == DisableModLists[j])
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
                    cLB_maintenance.Items.Add(ModLists[i,4]);
                    cLB_maintenance.Size = new Size(200, 30 + (AddcounterM) * 14);
                    cLB_maintenance.CheckOnClick = true;
                    cLB_maintenance.Enabled = false;
                    Controls.Add(cLB_maintenance);
                    cLB_select.SetItemCheckState(i, CheckState.Checked);
                }
            }
            return;
        }
        private void Apply_Click(object sender, EventArgs e)
        {
            int i;
            string ApplytingMod;
            ApplytingMod = "適用したMOD:\n";
            for (i = 0; i <= (cLB_select.Items.Count - 1); i++)
            {
                ModLists[i, 5] = "disabled";
                if (cLB_select.GetItemChecked(i))
                {
                    ApplytingMod  += (i + 1).ToString() + ". " + cLB_select.Items[i].ToString() + "\n";
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
            Array.Clear(ModLists ,0, ModLists.Length);
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

        private void Vanilla_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i < AddcounterS; i++)
            {
                cLB_select.SetItemCheckState(i, CheckState.Unchecked);
            }
        }




        private void LocalToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            string LocalLocation = FileLocation;
            LocalLocation = LocalLocation.Replace("\\Besiege_Data\\Mods\\Config\\Modding.xml", "") + "\\Besiege.exe";
            Process.Start(LocalLocation);
        }
        private void SteamToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start("steam://rungameid/346010");
        }

        private void menuClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
