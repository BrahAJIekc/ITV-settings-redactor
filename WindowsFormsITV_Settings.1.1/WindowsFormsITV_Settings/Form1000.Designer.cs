using WindowsFormsITV_Settings.Styles;
namespace WindowsFormsITV_Settings
{
    partial class Form1000
    {
	   /// <summary>
	   /// Required designer variable.
	   /// </summary>
	   private System.ComponentModel.IContainer components = null;

	   /// <summary>
	   /// Clean up any resources being used.
	   /// </summary>
	   /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	   protected override void Dispose(bool disposing)
	   {
		  if (disposing && (components != null))
		  {
			 components.Dispose();
		  }
		  base.Dispose(disposing);
	   }

	   #region Windows Form Designer generated code

	   /// <summary>
	   /// Required method for Designer support - do not modify
	   /// the contents of this method with the code editor.
	   /// </summary>
	   private void InitializeComponent()
	   {
		  this.ContextMenu = new System.Windows.Forms.ContextMenu();
		  Form1000.button1 = new System.Windows.Forms.Button();
		  Form1000.button2 = new System.Windows.Forms.Button();
		  Form1000.button9 = new System.Windows.Forms.Button();
		  Form1000.button8 = new System.Windows.Forms.Button();
		  Form1000.treeView1 = new System.Windows.Forms.TreeView();
		  Form1000.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
		  Form1000.label1 = new System.Windows.Forms.Label();
		  Form1000.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
		  Form1000.label2 = new System.Windows.Forms.Label();
		  Form1000.label3 = new System.Windows.Forms.Label();
		  Form1000.listBox1 = new System.Windows.Forms.ListBox();
		  Form1000.button3 = new System.Windows.Forms.Button();
		  Form1000.treeView2 = new System.Windows.Forms.TreeView();
		  Form1000.button5 = new System.Windows.Forms.Button();
		  Form1000.button6 = new System.Windows.Forms.Button();
		  Form1000.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
		  Form1000.menuStrip1 = new System.Windows.Forms.MenuStrip();
		 // Form1000.камераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		  //Form1000.камераToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		  Form1000.очиститьУстройстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		  Form1000.удалитьКамерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		  Form1000.выделитьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		  Form1000.очиститьКамерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		  Form1000.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		  Form1000.labelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		  Form1000.UndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		  Form1000.button4 = new System.Windows.Forms.Button();
		  Form1000.button7 = new System.Windows.Forms.Button();
		  Form1000.panel1 = new System.Windows.Forms.Panel();
		  Form1000.panel2 = new System.Windows.Forms.Panel();
		  ((System.ComponentModel.ISupportInitialize)(Form1000.numericUpDown1)).BeginInit();
		  ((System.ComponentModel.ISupportInitialize)(Form1000.numericUpDown2)).BeginInit();
		  ((System.ComponentModel.ISupportInitialize)(Form1000.numericUpDown3)).BeginInit();
		  Form1000.menuStrip1.SuspendLayout();
		  Form1000.panel1.SuspendLayout();
		  Form1000.panel2.SuspendLayout();
		  this.SuspendLayout();
		  // 
		  // button1
		  // 
		  Form1000.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
		  Form1000.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		  Form1000.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
		  Form1000.button1.Location = new System.Drawing.Point(385, 553+17);
		  Form1000.button1.Margin = new System.Windows.Forms.Padding(4);
		  Form1000.button1.Name = "button1";
		  Form1000.button1.Padding = new System.Windows.Forms.Padding(5);
		  Form1000.button1.Size = new System.Drawing.Size(350, 49);
		  Form1000.button1.TabIndex = 0;
		  Form1000.button1.Text = "Добавить устройство";
		  Form1000.button1.UseVisualStyleBackColor = true;
		  Form1000.button1.Click += new System.EventHandler((sender, e) => WindowsFormsITV_Settings.Events.AddCamAndAddDevs.button1_Click(sender, e));
		  // 
		  // button2
		  // 
		  Form1000.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
		  Form1000.button2.AutoEllipsis = true;
		  Form1000.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		  Form1000.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
		  Form1000.button2.Location = new System.Drawing.Point(0, 7);
		  Form1000.button2.Margin = new System.Windows.Forms.Padding(4);
		  Form1000.button2.Name = "button2";
		  Form1000.button2.Padding = new System.Windows.Forms.Padding(5);
		  Form1000.button2.Size = new System.Drawing.Size(140, 45);
		  Form1000.button2.TabIndex = 1;
		  Form1000.button2.Text = "Добавить камеру ";
		  Form1000.button2.UseVisualStyleBackColor = true;
		  Form1000.button2.Click += new System.EventHandler((sender, e) => WindowsFormsITV_Settings.Events.AddCamAndAddDevs.button2_Click(sender, e));
		  // 
		  // treeView1
		  // 
		  Form1000.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
		  Form1000.treeView1.Location = new System.Drawing.Point(12, 30);
		  Form1000.treeView1.Name = "treeView1";
		  Form1000.treeView1.Size = new System.Drawing.Size(370, 534);
		  Form1000.treeView1.TabIndex = 2;
		  Form1000.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler((sender, e) => WindowsFormsITV_Settings.Events.treeViews_AfterCheck.treeView1_AfterCheck(sender, e));
		  Form1000.treeView1.Resize +=  new System.EventHandler((sender, e) => WindowsFormsITV_Settings.Events.treeView1Resize.treeView1_Resize(sender,e));
		  //Form1000.treeView1.MouseClick += new System.Windows.Forms.MouseEventHandler((sender, e) => WindowsFormsITV_Settings.Events.Refresher.Changed_Node(sender, e));
		  Form1000.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler((sender, e) => WindowsFormsITV_Settings.Events.Refresher.Delete(sender, e));
		  Form1000.treeView1.DrawNode +=  new System.Windows.Forms.DrawTreeNodeEventHandler((sender, e) => WindowsFormsITV_Settings.Events.Hide.treeView1_DrawNode(sender,e));
		  //Form1000.treeView1.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler((sender, e) => WindowsFormsITV_Settings.Events.Refresher.Changed_Node(sender, e));
		  //WindowsFormsITV_Settings.Events.Refresh.CN.changed_node += new WindowsFormsITV_Settings.Events.Refresher.ChangedEventHandler(WindowsFormsITV_Settings.Events.Refresh.ListChanged);
		  //WindowsFormsITV_Settings.Events.Refresh dr = new WindowsFormsITV_Settings.Events.Refresh((WindowsFormsITV_Settings.Events.Refresher)Form1000.treeView1);
		  
		  // 
		  // numericUpDown1
		  // 
		  Form1000.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		  Form1000.numericUpDown1.Location = new System.Drawing.Point(237, 555);
		  Form1000.numericUpDown1.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
		  Form1000.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
		  Form1000.numericUpDown1.Name = "numericUpDown1";
		  Form1000.numericUpDown1.ReadOnly = true;
		  Form1000.numericUpDown1.Size = new System.Drawing.Size(70, 47);
		  Form1000.numericUpDown1.TabIndex = 3;
		  Form1000.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
		  Form1000.numericUpDown1.ValueChanged += new System.EventHandler((sender, e) => WindowsFormsITV_Settings.Events.numerics_ValueChanged.numericUpDown1_ValueChanged(sender, e));
		  // 
		  // label1
		  // 
		  Form1000.label1.AutoSize = true;
		  Form1000.label1.Location = new System.Drawing.Point(306, 597);
		  Form1000.label1.Name = "label1";
		  Form1000.label1.Size = new System.Drawing.Size(0, 13);
		  Form1000.label1.TabIndex = 4;
		  // 
		  // numericUpDown2
		  // 
		  Form1000.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		  Form1000.numericUpDown2.Location = new System.Drawing.Point(320, 555);
		  Form1000.numericUpDown2.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
		  Form1000.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
		  Form1000.numericUpDown2.Name = "numericUpDown2";
		  Form1000.numericUpDown2.ReadOnly = true;
		  Form1000.numericUpDown2.Size = new System.Drawing.Size(60, 47);
		  Form1000.numericUpDown2.TabIndex = 5;
		  Form1000.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
		  Form1000.numericUpDown2.ValueChanged += new System.EventHandler((sender, e) => WindowsFormsITV_Settings.Events.numerics_ValueChanged.numericUpDown2_ValueChanged(sender, e));
		  // 
		  // label2
		  // 
		  Form1000.label2.AutoSize = true;
		  Form1000.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		  Form1000.label2.Location = new System.Drawing.Point(320, 578 + 35);
		  Form1000.label2.Name = "label2";
		  Form1000.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
		  Form1000.label2.Size = new System.Drawing.Size(66, 13);
		  Form1000.label2.TabIndex = 6;
		  Form1000.label2.Text = "Камера №";
		  // 
		  // label3
		  // 
		  Form1000.label3.AutoSize = true;
		  Form1000.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		  Form1000.label3.Location = new System.Drawing.Point(237-5, 578 + 35);
		  Form1000.label3.Name = "label3";
		  Form1000.label3.Size = new System.Drawing.Size(87, 13);
		  Form1000.label3.TabIndex = 7;
		  Form1000.label3.Text = "Устройство №";
		  // 
		  // listBox1
		  // 
		  Form1000.listBox1.FormattingEnabled = true;
		  Form1000.listBox1.HorizontalScrollbar = true;
		  Form1000.listBox1.Location = new System.Drawing.Point(740, 17);
		  Form1000.listBox1.Name = "listBox1";
		  Form1000.listBox1.Size = new System.Drawing.Size(95, 524);
		  Form1000.listBox1.TabIndex = 8;
		  // 
		  // button3
		  // 
		  Form1000.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
		  Form1000.button3.Location = new System.Drawing.Point(740, 553);
		  Form1000.button3.Name = "button3";
		  Form1000.button3.Size = new System.Drawing.Size(94, 49);
		  Form1000.button3.TabIndex = 9;
		  Form1000.button3.Text = "✖";
		  Form1000.button3.UseVisualStyleBackColor = true;
		  Form1000.button3.Click += new System.EventHandler((sender, e) => WindowsFormsITV_Settings.Events.DeleteFromListBox.button3_Click(sender, e));
		  // 
		  // treeView2
		  // 
		  Form1000.treeView2.Location = new System.Drawing.Point(387, 30);
		  Form1000.treeView2.Name = "treeView2";
		  Form1000.treeView2.Size = new System.Drawing.Size(347, 499);
		  Form1000.treeView2.TabIndex = 11;
		  Form1000.treeView2.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler((sender, e) => WindowsFormsITV_Settings.Events.Hide.treeView2_DrawNode(sender, e));
		  // 
		  // button5
		  // 
		  Form1000.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		  Form1000.button5.Location = new System.Drawing.Point(387, 510);
		  Form1000.button5.Name = "button5";
		  Form1000.button5.Size = new System.Drawing.Size(151, 35);
		  Form1000.button5.TabIndex = 12;
		  Form1000.button5.Text = "Удалить событие";
		  Form1000.button5.UseVisualStyleBackColor = true;
		  Form1000.button5.Click += new System.EventHandler((sender, e) => WindowsFormsITV_Settings.Events.Add2andDel2.button5_Click(sender, e));
		  // 
		  // button6
		  // 
		  Form1000.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		  Form1000.button6.Location = new System.Drawing.Point(593, 510);
		  Form1000.button6.Name = "button6";
		  Form1000.button6.Size = new System.Drawing.Size(141, 35);
		  Form1000.button6.TabIndex = 13;
		  Form1000.button6.Text = "Добавить событие";
		  Form1000.button6.UseVisualStyleBackColor = true;
		  Form1000.button6.Click += new System.EventHandler((sender, e) => WindowsFormsITV_Settings.Events.Add2andDel2.button6_Click(sender, e));
		  // 
		  // numericUpDown3
		  // 
		  Form1000.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		  Form1000.numericUpDown3.Location = new System.Drawing.Point(544, 512);
		  Form1000.numericUpDown3.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
		  Form1000.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
		  Form1000.numericUpDown3.Name = "numericUpDown3";
		  Form1000.numericUpDown3.ReadOnly = true;
		  Form1000.numericUpDown3.Size = new System.Drawing.Size(45, 29);
		  Form1000.numericUpDown3.TabIndex = 14;
		  Form1000.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
		  Form1000.numericUpDown3.ValueChanged += new System.EventHandler((sender, e) => WindowsFormsITV_Settings.Events.numerics_ValueChanged.numericUpDown3_ValueChanged(sender, e));
		  // 
		  // menuStrip1
		  // 
		  //Form1000.menuStrip1.Renderer = new MenuStripStyle();
		  Form1000.menuStrip1.AllowItemReorder = true;
		  Form1000.menuStrip1.CanOverflow = true;
		  Form1000.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
		  Form1000.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
		  Form1000.menuStrip1.Dock = System.Windows.Forms.DockStyle.Top;
		  //Form1000.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
		  Form1000.menuStrip1.Stretch = true;
		  Form1000.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
		  Form1000.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {Form1000.UndoToolStripMenuItem,
            //Form1000.камераToolStripMenuItem,
            //Form1000.камераToolStripMenuItem1,
            Form1000.очиститьУстройстваToolStripMenuItem,
            Form1000.удалитьКамерыToolStripMenuItem,
            Form1000.выделитьВсеToolStripMenuItem,
            Form1000.очиститьКамерыToolStripMenuItem,
            Form1000.сохранитьToolStripMenuItem,
            Form1000.labelToolStripMenuItem});
		  Form1000.menuStrip1.Location = new System.Drawing.Point(0, 608);
		  Form1000.menuStrip1.Name = "menuStrip1";
		  Form1000.menuStrip1.Size = new System.Drawing.Size(839, 24);
		  Form1000.menuStrip1.TabIndex = 15;
		  Form1000.menuStrip1.TabStop = true;
		  Form1000.menuStrip1.Text = "menuStrip1";
		  // 
		  // камераToolStripMenuItem
		  // 
		 // Form1000.камераToolStripMenuItem.DoubleClickEnabled = true;
		 // Form1000.камераToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		  //Form1000.камераToolStripMenuItem.Name = "камераToolStripMenuItem";
		  //Form1000.камераToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
		  //Form1000.камераToolStripMenuItem.Text = "+ Камера";
		  //Form1000.камераToolStripMenuItem.Click += new System.EventHandler((sender, e) => WindowsFormsITV_Settings.Events.PlusMinusCamera.камераToolStripMenuItem_Click(sender, e));
		  //Form1000.камераToolStripMenuItem.DoubleClick += new System.EventHandler((sender, e) => WindowsFormsITV_Settings.Events.PlusMinusCamsDouble.камераToolStripMenuItem_DoubleClick(sender, e));
		  // 
		  // камераToolStripMenuItem1
		  // 
		  //Form1000.камераToolStripMenuItem1.DoubleClickEnabled = true;
		  //Form1000.камераToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		  //Form1000.камераToolStripMenuItem1.Name = "камераToolStripMenuItem1";
		  //Form1000.камераToolStripMenuItem1.Size = new System.Drawing.Size(65, 20);
		  //Form1000.камераToolStripMenuItem1.Text = "- Камера";
		  //Form1000.камераToolStripMenuItem1.Click += new System.EventHandler((sender, e) => WindowsFormsITV_Settings.Events.PlusMinusCamera.камераToolStripMenuItem1_Click(sender, e));
		  //Form1000.камераToolStripMenuItem1.DoubleClick += new System.EventHandler((sender, e) => WindowsFormsITV_Settings.Events.PlusMinusCamsDouble.камераToolStripMenuItem1_DoubleClick(sender, e));
		  // 
		  // очиститьУстройстваToolStripMenuItem
		  // 
		  Form1000.очиститьУстройстваToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		  Form1000.очиститьУстройстваToolStripMenuItem.Name = "очиститьУстройстваToolStripMenuItem";
		  Form1000.очиститьУстройстваToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
		  Form1000.очиститьУстройстваToolStripMenuItem.Text = "Очистить устройства";
		  Form1000.очиститьУстройстваToolStripMenuItem.Click += new System.EventHandler((sender, e) => WindowsFormsITV_Settings.Events.ClearingDevsAndCams.очиститьУстройстваToolStripMenuItem_Click(sender, e));
		  // 
		  // удалитьКамерыToolStripMenuItem
		  // 
		  Form1000.удалитьКамерыToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		  Form1000.удалитьКамерыToolStripMenuItem.Name = "удалитьКамерыToolStripMenuItem";
		  Form1000.удалитьКамерыToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
		  Form1000.удалитьКамерыToolStripMenuItem.Text = "Удалить камеры";
		  Form1000.удалитьКамерыToolStripMenuItem.Click += new System.EventHandler((sender, e) => WindowsFormsITV_Settings.Events.DeleteAllCams.удалитьКамерыToolStripMenuItem_Click(sender, e));
		  // 
		  // выделитьВсеToolStripMenuItem
		  // 
		  Form1000.выделитьВсеToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		  Form1000.выделитьВсеToolStripMenuItem.Name = "выделитьВсеToolStripMenuItem";
		  Form1000.выделитьВсеToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
		  Form1000.выделитьВсеToolStripMenuItem.Text = "Выделить все события";
		  Form1000.выделитьВсеToolStripMenuItem.Click += new System.EventHandler((sender, e) => WindowsFormsITV_Settings.Events.SelectAllEvent.выделитьВсеToolStripMenuItem_Click(sender, e)); 
		  // 
		  // очиститьКамерыToolStripMenuItem
		  // 
		  Form1000.очиститьКамерыToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
		  Form1000.очиститьКамерыToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		  Form1000.очиститьКамерыToolStripMenuItem.Name = "очиститьКамерыToolStripMenuItem";
		  Form1000.очиститьКамерыToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
		  Form1000.очиститьКамерыToolStripMenuItem.Text = "Очистить камеры";
		  Form1000.очиститьКамерыToolStripMenuItem.Click += new System.EventHandler((sender, e) => WindowsFormsITV_Settings.Events.ClearingDevsAndCams.очиститьКамерыToolStripMenuItem_Click(sender, e));
		  // 
		  // сохранитьToolStripMenuItem
		  //
		  Form1000.сохранитьToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
		  Form1000.сохранитьToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))); 
		  Form1000.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
		  Form1000.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
		  Form1000.сохранитьToolStripMenuItem.Text = "Сохранить";
		  Form1000.сохранитьToolStripMenuItem.Click += new System.EventHandler((sender, e) => WindowsFormsITV_Settings.Events.Save.сохранитьToolStripMenuItem_Click(sender, e));
		  // 
		  // labelToolStripMenuItem
		  // 
		  Form1000.labelToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
		  Form1000.labelToolStripMenuItem.Enabled = false;
		  Form1000.labelToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		  Form1000.labelToolStripMenuItem.ForeColor = System.Drawing.Color.MistyRose;
		  Form1000.labelToolStripMenuItem.Name = "labelToolStripMenuItem";
		  Form1000.labelToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
		  Form1000.labelToolStripMenuItem.Text = "label";
		  //
		  //Undo
		  //
		  Form1000.UndoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		  Form1000.UndoToolStripMenuItem.Name = "Undo";
		  Form1000.UndoToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
		  Form1000.UndoToolStripMenuItem.Text = "Undo";
		  Form1000.UndoToolStripMenuItem.Click += new System.EventHandler((sender, e) => WindowsFormsITV_Settings.Events.Undo.Undo_Click(sender, e));
		  // 
		  // 
		  // button4
		  // 
		  //Form1000.сохранитьToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))); 
		  Form1000.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
		  Form1000.button4.Location = new System.Drawing.Point(10, 7);
		  Form1000.button4.Name = "button4";
		  Form1000.button4.Size = new System.Drawing.Size(53, 23);
		  Form1000.button4.TabIndex = 16;
		  Form1000.button4.Text = "✖";
		  Form1000.button4.UseVisualStyleBackColor = true;
		  Form1000.button4.Click += new System.EventHandler((sender, e) => WindowsFormsITV_Settings.Events.EventsAddRemoveWithListBox.button4_Click(sender, e));
		  // 
		  // button7
		  // 
		  Form1000.button7.FlatStyle = System.Windows.Forms.FlatStyle.System;
		  Form1000.button7.Location = new System.Drawing.Point(Form1000.panel1.Location.X + Form1000.treeView2.Width- 110, 7);
		  Form1000.button7.Name = "button7";
		  Form1000.button7.Size = new System.Drawing.Size(53, 23);
		  Form1000.button7.TabIndex = 19;
		  Form1000.button7.Text = "✚ Событие ";
		  Form1000.button7.UseVisualStyleBackColor = true;
		  Form1000.button7.Click += new System.EventHandler((sender, e) => WindowsFormsITV_Settings.Events.EventsAddRemoveWithListBox.button7_Click(sender, e));
		  // 
		  // groupBox1
		  // 
		  //Form1000.groupBox1.Controls.Add(Form1000.button7);
		  //Form1000.groupBox1.Controls.Add(Form1000.button4);
		  //Form1000.groupBox1.Location = new System.Drawing.Point(464, 547);
		  //Form1000.groupBox1.Name = "groupBox1";
		  //Form1000.groupBox1.Size = new System.Drawing.Size(125, 59);
		  //Form1000.groupBox1.TabIndex = 20;
		  //Form1000.groupBox1.TabStop = false;
		  Form1000.panel1.Controls.Add(Form1000.button7);
		  Form1000.panel1.Controls.Add(Form1000.button4);
		  Form1000.panel1.Location = new System.Drawing.Point(464, 547);
		  Form1000.panel1.Name = "panel1";
		  Form1000.panel1.Size = new System.Drawing.Size(125, 59);
		  Form1000.panel1.TabIndex = 20;
		  Form1000.panel1.TabStop = false;
		  //Form1000.groupBox1.Text = "  Удалить/Добавить";
		  //
		  // 
		  // button8
		  // 
		  //Form1000.сохранитьToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))); 
		  Form1000.button8.FlatStyle = System.Windows.Forms.FlatStyle.System;
		  Form1000.button8.Location = new System.Drawing.Point(10, 7);
		  Form1000.button8.Name = "button8";
		  Form1000.button8.Size = new System.Drawing.Size(53, 23);
		  Form1000.button8.TabIndex = 16;
		  Form1000.button8.Text = "✚";
		  Form1000.button8.UseVisualStyleBackColor = true;
		  Form1000.button8.Click += new System.EventHandler((sender, e) => WindowsFormsITV_Settings.Events.EventsAddRemoveWithListBox.button4_Click(sender, e));
		  // ✖
		  // button9
		  // ✚
		  Form1000.button9.FlatStyle = System.Windows.Forms.FlatStyle.System;
		  Form1000.button9.Location = new System.Drawing.Point(10, 30);
		  Form1000.button9.Name = "button9";
		  Form1000.button9.Size = new System.Drawing.Size(53, 23);
		  Form1000.button9.TabIndex = 19;
		  Form1000.button9.Text = "✖";
		  Form1000.button9.UseVisualStyleBackColor = true;
		  Form1000.button9.Click += new System.EventHandler((sender, e) => WindowsFormsITV_Settings.Events.EventsAddRemoveWithListBox.button7_Click(sender, e));
		  // 
		  //
		  //groupBox2
		  //
		  //Form1000.groupBox2.Controls.Add(Form1000.button8);
		  //Form1000.groupBox2.Controls.Add(Form1000.button2);
		  //Form1000.groupBox2.Controls.Add(Form1000.button9);
		  //Form1000.groupBox2.Location = new System.Drawing.Point(10, 547);
		  //Form1000.groupBox2.Name = "groupBox2";
		  //Form1000.groupBox2.Size = new System.Drawing.Size(220, 55);
		  //Form1000.groupBox2.TabIndex = 20;
		  //Form1000.groupBox2.TabStop = false;
		  Form1000.panel2.Controls.Add(Form1000.button8);
		  Form1000.panel2.Controls.Add(Form1000.button2);
		  Form1000.panel2.Controls.Add(Form1000.button9);
		  Form1000.panel2.Location = new System.Drawing.Point(10, 547);
		  Form1000.panel2.Name = "groupBox2";
		  Form1000.panel2.Size = new System.Drawing.Size(220, 55);
		  Form1000.panel2.TabIndex = 20;
		  Form1000.panel2.TabStop = false;
		  // 
		  // Form1000
		  // 
		  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
		  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		  this.ClientSize = new System.Drawing.Size(850, 632);
		  //this.Controls.Add(Form1000.groupBox1);
		  //this.Controls.Add(Form1000.groupBox2);
		  this.Controls.Add(Form1000.panel1);
		  this.Controls.Add(Form1000.panel2);
		  this.Controls.Add(Form1000.numericUpDown3);
		  this.Controls.Add(Form1000.button6);
		  this.Controls.Add(Form1000.button5);
		  this.Controls.Add(Form1000.treeView2);
		  this.Controls.Add(Form1000.button3);
		  this.Controls.Add(Form1000.listBox1);
		  this.Controls.Add(Form1000.label3);
		  this.Controls.Add(Form1000.label2);
		  this.Controls.Add(Form1000.numericUpDown2);
		  this.Controls.Add(Form1000.label1);
		  this.Controls.Add(Form1000.numericUpDown1);
		  this.Controls.Add(Form1000.treeView1);
		  //this.Controls.Add(Form1000.button2);
		  this.Controls.Add(Form1000.button1);
		  this.Controls.Add(Form1000.menuStrip1);
		  this.MainMenuStrip = Form1000.menuStrip1;
		  this.MinimumSize = new System.Drawing.Size(500, 210);
		  this.Name = "Form1000";
		  this.ShowIcon = false;
		  this.Tag = "ITV";
		  this.Text = "Настройка сервиса ITV";
		  this.FormClosing += new System.Windows.Forms.FormClosingEventHandler((sender,e) => WindowsFormsITV_Settings.Events.Form_Closing.Form1000_FormClosing(sender,e));
		  this.Load += new System.EventHandler((sender,e) => WindowsFormsITV_Settings.Events.Load.Form1000_Load(sender, e));
		  ((System.ComponentModel.ISupportInitialize)(Form1000.numericUpDown1)).EndInit();
		  ((System.ComponentModel.ISupportInitialize)(Form1000.numericUpDown2)).EndInit();
		  ((System.ComponentModel.ISupportInitialize)(Form1000.numericUpDown3)).EndInit();
		  Form1000.menuStrip1.ResumeLayout(false);
		  Form1000.menuStrip1.PerformLayout();
		  //Form1000.groupBox1.ResumeLayout(false);
		  //Form1000.groupBox2.ResumeLayout(false);
		  Form1000.panel1.ResumeLayout(false);
		  Form1000.panel2.ResumeLayout(false);
		  this.ResumeLayout(false);
		  this.PerformLayout();
		  //
		  //menuitems
		  //
		  Form1000.menuItem1.Select += new System.EventHandler((sender, e) => WindowsFormsITV_Settings.Events.AddCamAndAddDevs.menuItem1_Click(sender, e));
		  Form1000.menuItem2.Select += new System.EventHandler((sender, e) => WindowsFormsITV_Settings.Events.AddCamAndAddDevs.menuItem2_Click(sender, e));
		  Form1000.menuItem3.Select += new System.EventHandler((sender, e) => WindowsFormsITV_Settings.Events.AddCamAndAddDevs.menuItem3_Click(sender, e));
		  Form1000.menuItem4.Select += new System.EventHandler((sender, e) => WindowsFormsITV_Settings.Events.AddCamAndAddDevs.menuItem4_Click(sender, e));
		  Form1000.menuItem5.Select += new System.EventHandler((sender, e) => WindowsFormsITV_Settings.Events.AddCamAndAddDevs.menuItem5_Click(sender, e));
		  Form1000.menuItem6.Select += new System.EventHandler((sender, e) => WindowsFormsITV_Settings.Events.AddCamAndAddDevs.menuItem6_Click(sender, e));

	   }
	   #endregion

	   public static System.Windows.Forms.Button button1;
	   public static System.Windows.Forms.Button button2;
	   public static System.Windows.Forms.Button button8;
	   public static System.Windows.Forms.Button button9;
	   public static System.Windows.Forms.TreeView treeView1;
	   public static System.Windows.Forms.NumericUpDown numericUpDown1;
	   public static System.Windows.Forms.Label label1;
	   public static System.Windows.Forms.NumericUpDown numericUpDown2;
	   public static System.Windows.Forms.Label label2;
	   public static System.Windows.Forms.Label label3;
	   public static System.Windows.Forms.ListBox listBox1;
	   public static System.Windows.Forms.Button button3;
	   public static System.Windows.Forms.TreeView treeView2;
	   public static System.Windows.Forms.Button button5;
	   public static System.Windows.Forms.Button button6;
	   public static System.Windows.Forms.NumericUpDown numericUpDown3;
	   public static System.Windows.Forms.MenuStrip menuStrip1;
	   //public static System.Windows.Forms.ToolStripMenuItem камераToolStripMenuItem;
	  // public static System.Windows.Forms.ToolStripMenuItem камераToolStripMenuItem1;
	   public static System.Windows.Forms.ToolStripMenuItem очиститьУстройстваToolStripMenuItem;
	   public static System.Windows.Forms.ToolStripMenuItem удалитьКамерыToolStripMenuItem;
	   public static System.Windows.Forms.ToolStripMenuItem выделитьВсеToolStripMenuItem;
	   public static System.Windows.Forms.ToolStripMenuItem очиститьКамерыToolStripMenuItem;
	   public static System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
	   public static System.Windows.Forms.ToolStripMenuItem labelToolStripMenuItem;
	   public static System.Windows.Forms.ToolStripMenuItem UndoToolStripMenuItem;
	   public static System.Windows.Forms.Button button4;
	   public static System.Windows.Forms.Button button7;
	   //public static System.Windows.Forms.GroupBox groupBox1;
	   //public static System.Windows.Forms.GroupBox groupBox2;
	   public static System.Windows.Forms.Panel panel1;
	   public static System.Windows.Forms.Panel panel2;

    }
}