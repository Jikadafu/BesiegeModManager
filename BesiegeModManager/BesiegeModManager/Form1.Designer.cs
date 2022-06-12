using System;
using System.Drawing;
using System.Windows.Forms;

namespace BesiegeModManager
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ModList = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FIle = new System.Windows.Forms.ToolStripMenuItem();
            this.moddingOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MODApply = new System.Windows.Forms.ToolStripMenuItem();
            this.Apply = new System.Windows.Forms.ToolStripMenuItem();
            this.preset = new System.Windows.Forms.ToolStripMenuItem();
            this.vanilla = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.preset1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Load1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ChengeName1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Save1 = new System.Windows.Forms.ToolStripMenuItem();
            this.priset2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Load2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ChengeName2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Save2 = new System.Windows.Forms.ToolStripMenuItem();
            this.priset3 = new System.Windows.Forms.ToolStripMenuItem();
            this.Load3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ChengeName3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.Save3 = new System.Windows.Forms.ToolStripMenuItem();
            this.priset4 = new System.Windows.Forms.ToolStripMenuItem();
            this.Load4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.ChengeName4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.Save4 = new System.Windows.Forms.ToolStripMenuItem();
            this.priset5 = new System.Windows.Forms.ToolStripMenuItem();
            this.Load5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.ChengeName5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.Save5 = new System.Windows.Forms.ToolStripMenuItem();
            this.priset6 = new System.Windows.Forms.ToolStripMenuItem();
            this.Load6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.ChengeName6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.Save6 = new System.Windows.Forms.ToolStripMenuItem();
            this.priset7 = new System.Windows.Forms.ToolStripMenuItem();
            this.Load7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.ChengeName7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.Save7 = new System.Windows.Forms.ToolStripMenuItem();
            this.priset8 = new System.Windows.Forms.ToolStripMenuItem();
            this.Load8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.ChengeName8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.Save8 = new System.Windows.Forms.ToolStripMenuItem();
            this.priset9 = new System.Windows.Forms.ToolStripMenuItem();
            this.Load9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.ChengeName9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.Save9 = new System.Windows.Forms.ToolStripMenuItem();
            this.BesiegeStart = new System.Windows.Forms.ToolStripMenuItem();
            this.steamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ApplyingMod = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModList
            // 
            this.ModList.AutoEllipsis = true;
            this.ModList.AutoSize = true;
            this.ModList.BackColor = System.Drawing.SystemColors.Window;
            this.ModList.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ModList.Location = new System.Drawing.Point(12, 24);
            this.ModList.Name = "ModList";
            this.ModList.Size = new System.Drawing.Size(149, 19);
            this.ModList.TabIndex = 0;
            this.ModList.Text = "適用させたいMod";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FIle,
            this.MODApply,
            this.preset,
            this.BesiegeStart,
            this.menuClose});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(352, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FIle
            // 
            this.FIle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moddingOpen});
            this.FIle.Name = "FIle";
            this.FIle.Size = new System.Drawing.Size(67, 20);
            this.FIle.Text = "ファイル(&F)";
            // 
            // moddingOpen
            // 
            this.moddingOpen.Name = "moddingOpen";
            this.moddingOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.moddingOpen.Size = new System.Drawing.Size(224, 22);
            this.moddingOpen.Text = "Modding.xmlを開く...";
            this.moddingOpen.Click += new System.EventHandler(this.moddingOpen_Click_1);
            // 
            // MODApply
            // 
            this.MODApply.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Apply});
            this.MODApply.Name = "MODApply";
            this.MODApply.Size = new System.Drawing.Size(68, 20);
            this.MODApply.Text = "Mod適用";
            // 
            // Apply
            // 
            this.Apply.Name = "Apply";
            this.Apply.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
            this.Apply.Size = new System.Drawing.Size(189, 22);
            this.Apply.Text = "適用させる";
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // preset
            // 
            this.preset.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vanilla,
            this.toolStripSeparator1,
            this.preset1,
            this.priset2,
            this.priset3,
            this.priset4,
            this.priset5,
            this.priset6,
            this.priset7,
            this.priset8,
            this.priset9});
            this.preset.Name = "preset";
            this.preset.Size = new System.Drawing.Size(73, 20);
            this.preset.Text = "プリセット(&I)";
            // 
            // vanilla
            // 
            this.vanilla.Name = "vanilla";
            this.vanilla.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.vanilla.Size = new System.Drawing.Size(147, 22);
            this.vanilla.Text = "vanilla";
            this.vanilla.Click += Vanilla_Click;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(144, 6);
            // 
            // preset1
            // 
            this.preset1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Load1,
            this.toolStripSeparator2,
            this.ChengeName1,
            this.toolStripSeparator4,
            this.Save1});
            this.preset1.Name = "preset1";
            this.preset1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.preset1.ShowShortcutKeys = false;
            this.preset1.Size = new System.Drawing.Size(147, 22);
            this.preset1.Text = "プリセット1";
            // 
            // Load1
            // 
            this.Load1.Name = "Load1";
            this.Load1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.Load1.Size = new System.Drawing.Size(138, 22);
            this.Load1.Text = "ロード";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(135, 6);
            // 
            // ChengeName1
            // 
            this.ChengeName1.Name = "ChengeName1";
            this.ChengeName1.Size = new System.Drawing.Size(138, 22);
            this.ChengeName1.Text = "名前の変更";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(135, 6);
            // 
            // Save1
            // 
            this.Save1.Name = "Save1";
            this.Save1.Size = new System.Drawing.Size(138, 22);
            this.Save1.Text = "セーブ";
            // 
            // priset2
            // 
            this.priset2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Load2,
            this.toolStripSeparator5,
            this.ChengeName2,
            this.toolStripSeparator3,
            this.Save2});
            this.priset2.Name = "priset2";
            this.priset2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.priset2.ShowShortcutKeys = false;
            this.priset2.Size = new System.Drawing.Size(147, 22);
            this.priset2.Text = "プリセット2";
            // 
            // Load2
            // 
            this.Load2.Name = "Load2";
            this.Load2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.Load2.Size = new System.Drawing.Size(138, 22);
            this.Load2.Text = "ロード";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(135, 6);
            // 
            // ChengeName2
            // 
            this.ChengeName2.Name = "ChengeName2";
            this.ChengeName2.Size = new System.Drawing.Size(138, 22);
            this.ChengeName2.Text = "名前の変更";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(135, 6);
            // 
            // Save2
            // 
            this.Save2.Name = "Save2";
            this.Save2.Size = new System.Drawing.Size(138, 22);
            this.Save2.Text = "セーブ";
            // 
            // priset3
            // 
            this.priset3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Load3,
            this.toolStripSeparator6,
            this.ChengeName3,
            this.toolStripSeparator7,
            this.Save3});
            this.priset3.Name = "priset3";
            this.priset3.ShowShortcutKeys = false;
            this.priset3.Size = new System.Drawing.Size(147, 22);
            this.priset3.Text = "プリセット3";
            // 
            // Load3
            // 
            this.Load3.Name = "Load3";
            this.Load3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.Load3.Size = new System.Drawing.Size(138, 22);
            this.Load3.Text = "ロード";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(135, 6);
            // 
            // ChengeName3
            // 
            this.ChengeName3.Name = "ChengeName3";
            this.ChengeName3.Size = new System.Drawing.Size(138, 22);
            this.ChengeName3.Text = "名前の変更";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(135, 6);
            // 
            // Save3
            // 
            this.Save3.Name = "Save3";
            this.Save3.Size = new System.Drawing.Size(138, 22);
            this.Save3.Text = "セーブ";
            // 
            // priset4
            // 
            this.priset4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Load4,
            this.toolStripSeparator8,
            this.ChengeName4,
            this.toolStripSeparator9,
            this.Save4});
            this.priset4.Name = "priset4";
            this.priset4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.priset4.ShowShortcutKeys = false;
            this.priset4.Size = new System.Drawing.Size(147, 22);
            this.priset4.Text = "プリセット4";
            // 
            // Load4
            // 
            this.Load4.Name = "Load4";
            this.Load4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.Load4.Size = new System.Drawing.Size(138, 22);
            this.Load4.Text = "ロード";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(135, 6);
            // 
            // ChengeName4
            // 
            this.ChengeName4.Name = "ChengeName4";
            this.ChengeName4.Size = new System.Drawing.Size(138, 22);
            this.ChengeName4.Text = "名前の変更";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(135, 6);
            // 
            // Save4
            // 
            this.Save4.Name = "Save4";
            this.Save4.Size = new System.Drawing.Size(138, 22);
            this.Save4.Text = "セーブ";
            // 
            // priset5
            // 
            this.priset5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Load5,
            this.toolStripSeparator10,
            this.ChengeName5,
            this.toolStripSeparator11,
            this.Save5});
            this.priset5.Name = "priset5";
            this.priset5.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.priset5.ShowShortcutKeys = false;
            this.priset5.Size = new System.Drawing.Size(147, 22);
            this.priset5.Text = "プリセット5";
            // 
            // Load5
            // 
            this.Load5.Name = "Load5";
            this.Load5.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.Load5.Size = new System.Drawing.Size(138, 22);
            this.Load5.Text = "ロード";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(135, 6);
            // 
            // ChengeName5
            // 
            this.ChengeName5.Name = "ChengeName5";
            this.ChengeName5.Size = new System.Drawing.Size(138, 22);
            this.ChengeName5.Text = "名前を変更";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(135, 6);
            // 
            // Save5
            // 
            this.Save5.Name = "Save5";
            this.Save5.Size = new System.Drawing.Size(138, 22);
            this.Save5.Text = "セーブ";
            // 
            // priset6
            // 
            this.priset6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Load6,
            this.toolStripSeparator12,
            this.ChengeName6,
            this.toolStripSeparator13,
            this.Save6});
            this.priset6.Name = "priset6";
            this.priset6.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6)));
            this.priset6.ShowShortcutKeys = false;
            this.priset6.Size = new System.Drawing.Size(147, 22);
            this.priset6.Text = "プリセット6";
            // 
            // Load6
            // 
            this.Load6.Name = "Load6";
            this.Load6.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6)));
            this.Load6.Size = new System.Drawing.Size(138, 22);
            this.Load6.Text = "ロード";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(135, 6);
            // 
            // ChengeName6
            // 
            this.ChengeName6.Name = "ChengeName6";
            this.ChengeName6.Size = new System.Drawing.Size(138, 22);
            this.ChengeName6.Text = "名前を変更";
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(135, 6);
            // 
            // Save6
            // 
            this.Save6.Name = "Save6";
            this.Save6.Size = new System.Drawing.Size(138, 22);
            this.Save6.Text = "セーブ";
            // 
            // priset7
            // 
            this.priset7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Load7,
            this.toolStripSeparator15,
            this.ChengeName7,
            this.toolStripSeparator14,
            this.Save7});
            this.priset7.Name = "priset7";
            this.priset7.ShowShortcutKeys = false;
            this.priset7.Size = new System.Drawing.Size(147, 22);
            this.priset7.Text = "プリセット7";
            // 
            // Load7
            // 
            this.Load7.Name = "Load7";
            this.Load7.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D7)));
            this.Load7.Size = new System.Drawing.Size(138, 22);
            this.Load7.Text = "ロード";
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(135, 6);
            // 
            // ChengeName7
            // 
            this.ChengeName7.Name = "ChengeName7";
            this.ChengeName7.Size = new System.Drawing.Size(138, 22);
            this.ChengeName7.Text = "名前の変更";
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(135, 6);
            // 
            // Save7
            // 
            this.Save7.Name = "Save7";
            this.Save7.Size = new System.Drawing.Size(138, 22);
            this.Save7.Text = "セーブ";
            // 
            // priset8
            // 
            this.priset8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Load8,
            this.toolStripSeparator16,
            this.ChengeName8,
            this.toolStripSeparator17,
            this.Save8});
            this.priset8.Name = "priset8";
            this.priset8.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D8)));
            this.priset8.ShowShortcutKeys = false;
            this.priset8.Size = new System.Drawing.Size(147, 22);
            this.priset8.Text = "プリセット8";
            // 
            // Load8
            // 
            this.Load8.Name = "Load8";
            this.Load8.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D8)));
            this.Load8.Size = new System.Drawing.Size(138, 22);
            this.Load8.Text = "ロード";
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(135, 6);
            // 
            // ChengeName8
            // 
            this.ChengeName8.Name = "ChengeName8";
            this.ChengeName8.Size = new System.Drawing.Size(138, 22);
            this.ChengeName8.Text = "名前の変更";
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(135, 6);
            // 
            // Save8
            // 
            this.Save8.Name = "Save8";
            this.Save8.Size = new System.Drawing.Size(138, 22);
            this.Save8.Text = "セーブ";
            // 
            // priset9
            // 
            this.priset9.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Load9,
            this.toolStripSeparator19,
            this.ChengeName9,
            this.toolStripSeparator18,
            this.Save9});
            this.priset9.Name = "priset9";
            this.priset9.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D9)));
            this.priset9.ShowShortcutKeys = false;
            this.priset9.Size = new System.Drawing.Size(147, 22);
            this.priset9.Text = "プリセット9";
            // 
            // Load9
            // 
            this.Load9.Name = "Load9";
            this.Load9.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D9)));
            this.Load9.Size = new System.Drawing.Size(138, 22);
            this.Load9.Text = "ロード";
            // 
            // toolStripSeparator19
            // 
            this.toolStripSeparator19.Name = "toolStripSeparator19";
            this.toolStripSeparator19.Size = new System.Drawing.Size(135, 6);
            // 
            // ChengeName9
            // 
            this.ChengeName9.Name = "ChengeName9";
            this.ChengeName9.Size = new System.Drawing.Size(138, 22);
            this.ChengeName9.Text = "名前の変更";
            // 
            // toolStripSeparator18
            // 
            this.toolStripSeparator18.Name = "toolStripSeparator18";
            this.toolStripSeparator18.Size = new System.Drawing.Size(135, 6);
            // 
            // Save9
            // 
            this.Save9.Name = "Save9";
            this.Save9.Size = new System.Drawing.Size(138, 22);
            this.Save9.Text = "セーブ";
            // 
            // BesiegeStart
            // 
            this.BesiegeStart.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.steamToolStripMenuItem,
            this.LocalToolStripMenuItem});
            this.BesiegeStart.Name = "BesiegeStart";
            this.BesiegeStart.Size = new System.Drawing.Size(93, 20);
            this.BesiegeStart.Text = "Besiegeの起動";
            // 
            // steamToolStripMenuItem
            // 
            this.steamToolStripMenuItem.Name = "steamToolStripMenuItem";
            this.steamToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.steamToolStripMenuItem.Text = "Steam";
            this.steamToolStripMenuItem.Click += SteamToolStripMenuItem_Click;
            // 
            // LocalToolStripMenuItem
            // 
            this.LocalToolStripMenuItem.Name = "LocalToolStripMenuItem";
            this.LocalToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.LocalToolStripMenuItem.Text = "ローカル";
            this.LocalToolStripMenuItem.Click += LocalToolStripMenuItem_Click;

            // 
            // menuClose
            // 
            this.menuClose.Name = "menuClose";
            this.menuClose.Size = new System.Drawing.Size(43, 20);
            this.menuClose.Text = "終了";
            this.menuClose.Click += new System.EventHandler(this.menuClose_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ApplyingMod
            // 
            this.ApplyingMod.AutoEllipsis = true;
            this.ApplyingMod.AutoSize = true;
            this.ApplyingMod.BackColor = System.Drawing.SystemColors.Window;
            this.ApplyingMod.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ApplyingMod.Location = new System.Drawing.Point(224, 24);
            this.ApplyingMod.Name = "ApplyingMod";
            this.ApplyingMod.Size = new System.Drawing.Size(122, 19);
            this.ApplyingMod.TabIndex = 2;
            this.ApplyingMod.Text = "適用中のMod";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.AutoScrollMinSize = new System.Drawing.Size(100, 100);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(543, 751);
            this.Controls.Add(this.ApplyingMod);
            this.Controls.Add(this.ModList);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "BesiegeModManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }





        #endregion


        private System.Windows.Forms.Label ModList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem FIle;
        private System.Windows.Forms.ToolStripMenuItem moddingOpen;
        private System.Windows.Forms.ToolStripMenuItem menuClose;
        private System.Windows.Forms.ToolStripMenuItem BesiegeStart;
        private ToolStripMenuItem MODApply;
        private ToolStripMenuItem Apply;
        private ToolStripMenuItem preset;
        private ToolStripMenuItem vanilla;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem preset1;
        private ToolStripMenuItem Load1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem ChengeName1;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem Save1;
        private Label ApplyingMod;
        private ToolStripMenuItem steamToolStripMenuItem;
        private ToolStripMenuItem LocalToolStripMenuItem;
        private ToolStripMenuItem priset2;
        private ToolStripMenuItem Load2;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem ChengeName2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem Save2;
        private ToolStripMenuItem priset3;
        private ToolStripMenuItem priset4;
        private ToolStripMenuItem priset5;
        private ToolStripMenuItem priset6;
        private ToolStripMenuItem priset7;
        private ToolStripMenuItem priset8;
        private ToolStripMenuItem priset9;
        private ToolStripMenuItem Load3;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem ChengeName3;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem Save3;
        private ToolStripMenuItem Load4;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripMenuItem ChengeName4;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripMenuItem Save4;
        private ToolStripMenuItem Load5;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripMenuItem ChengeName5;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripMenuItem Save5;
        private ToolStripMenuItem Load6;
        private ToolStripSeparator toolStripSeparator12;
        private ToolStripMenuItem ChengeName6;
        private ToolStripSeparator toolStripSeparator13;
        private ToolStripMenuItem Save6;
        private ToolStripMenuItem Load7;
        private ToolStripSeparator toolStripSeparator15;
        private ToolStripMenuItem ChengeName7;
        private ToolStripSeparator toolStripSeparator14;
        private ToolStripMenuItem Save7;
        private ToolStripMenuItem Load8;
        private ToolStripSeparator toolStripSeparator16;
        private ToolStripMenuItem ChengeName8;
        private ToolStripSeparator toolStripSeparator17;
        private ToolStripMenuItem Save8;
        private ToolStripMenuItem Load9;
        private ToolStripSeparator toolStripSeparator19;
        private ToolStripMenuItem ChengeName9;
        private ToolStripSeparator toolStripSeparator18;
        private ToolStripMenuItem Save9;
    }
}

