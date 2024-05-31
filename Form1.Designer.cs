namespace MovieDatabase
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.actorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new MovieDatabase.DataSet1();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.actorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorFNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.directorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.directorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorFNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.movieIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieFNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.movieActorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button14 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.movieIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrollIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.movieDirectorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.movieIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrollIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorTableAdapter = new MovieDatabase.DataSet1TableAdapters.ActorTableAdapter();
            this.directorTableAdapter = new MovieDatabase.DataSet1TableAdapters.DirectorTableAdapter();
            this.movieTableAdapter = new MovieDatabase.DataSet1TableAdapters.MovieTableAdapter();
            this.movieActorTableAdapter = new MovieDatabase.DataSet1TableAdapters.MovieActorTableAdapter();
            this.movieDirectorTableAdapter = new MovieDatabase.DataSet1TableAdapters.MovieDirectorTableAdapter();
            this.button18 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieActorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieDirectorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(43, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1153, 538);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox7);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1145, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Actor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(914, 388);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(122, 20);
            this.textBox7.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(601, 434);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(314, 434);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.actorBindingSource;
            this.comboBox1.DisplayMember = "Actor_FName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(60, 434);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "Actor_ID";
            // 
            // actorBindingSource
            // 
            this.actorBindingSource.DataMember = "Actor";
            this.actorBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(914, 302);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 37);
            this.button4.TabIndex = 4;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(914, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(914, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(914, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.actorIDDataGridViewTextBoxColumn,
            this.actorFNameDataGridViewTextBoxColumn,
            this.actorLNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.actorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(803, 384);
            this.dataGridView1.TabIndex = 0;
            // 
            // actorIDDataGridViewTextBoxColumn
            // 
            this.actorIDDataGridViewTextBoxColumn.DataPropertyName = "Actor_ID";
            this.actorIDDataGridViewTextBoxColumn.HeaderText = "Actor_ID";
            this.actorIDDataGridViewTextBoxColumn.Name = "actorIDDataGridViewTextBoxColumn";
            this.actorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actorFNameDataGridViewTextBoxColumn
            // 
            this.actorFNameDataGridViewTextBoxColumn.DataPropertyName = "Actor_FName";
            this.actorFNameDataGridViewTextBoxColumn.HeaderText = "Actor_FName";
            this.actorFNameDataGridViewTextBoxColumn.Name = "actorFNameDataGridViewTextBoxColumn";
            // 
            // actorLNameDataGridViewTextBoxColumn
            // 
            this.actorLNameDataGridViewTextBoxColumn.DataPropertyName = "Actor_LName";
            this.actorLNameDataGridViewTextBoxColumn.HeaderText = "Actor_LName";
            this.actorLNameDataGridViewTextBoxColumn.Name = "actorLNameDataGridViewTextBoxColumn";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox8);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1145, 512);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Director";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(930, 364);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(129, 20);
            this.textBox8.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(547, 412);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(178, 20);
            this.textBox4.TabIndex = 7;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(323, 412);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(160, 20);
            this.textBox3.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.directorBindingSource;
            this.comboBox2.DisplayMember = "Director_FName";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(98, 411);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(140, 21);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.ValueMember = "Director__ID";
            // 
            // directorBindingSource
            // 
            this.directorBindingSource.DataMember = "Director";
            this.directorBindingSource.DataSource = this.dataSet1;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(930, 285);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(129, 38);
            this.button8.TabIndex = 4;
            this.button8.Text = "Search";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(930, 201);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(129, 38);
            this.button7.TabIndex = 3;
            this.button7.Text = "Update";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(930, 119);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(129, 38);
            this.button6.TabIndex = 2;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(930, 51);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(129, 38);
            this.button5.TabIndex = 1;
            this.button5.Text = "Insert";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.directorIDDataGridViewTextBoxColumn,
            this.directorFNameDataGridViewTextBoxColumn,
            this.directorLNameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.directorBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(812, 365);
            this.dataGridView2.TabIndex = 0;
            // 
            // directorIDDataGridViewTextBoxColumn
            // 
            this.directorIDDataGridViewTextBoxColumn.DataPropertyName = "Director__ID";
            this.directorIDDataGridViewTextBoxColumn.HeaderText = "Director__ID";
            this.directorIDDataGridViewTextBoxColumn.Name = "directorIDDataGridViewTextBoxColumn";
            this.directorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // directorFNameDataGridViewTextBoxColumn
            // 
            this.directorFNameDataGridViewTextBoxColumn.DataPropertyName = "Director_FName";
            this.directorFNameDataGridViewTextBoxColumn.HeaderText = "Director_FName";
            this.directorFNameDataGridViewTextBoxColumn.Name = "directorFNameDataGridViewTextBoxColumn";
            // 
            // directorLNameDataGridViewTextBoxColumn
            // 
            this.directorLNameDataGridViewTextBoxColumn.DataPropertyName = "Director_LName";
            this.directorLNameDataGridViewTextBoxColumn.HeaderText = "Director_LName";
            this.directorLNameDataGridViewTextBoxColumn.Name = "directorLNameDataGridViewTextBoxColumn";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox9);
            this.tabPage3.Controls.Add(this.textBox6);
            this.tabPage3.Controls.Add(this.textBox5);
            this.tabPage3.Controls.Add(this.comboBox3);
            this.tabPage3.Controls.Add(this.button12);
            this.tabPage3.Controls.Add(this.button11);
            this.tabPage3.Controls.Add(this.button10);
            this.tabPage3.Controls.Add(this.button9);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1145, 512);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Movie";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(946, 346);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(134, 20);
            this.textBox9.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(566, 435);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(137, 20);
            this.textBox6.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(349, 435);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(129, 20);
            this.textBox5.TabIndex = 6;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.movieBindingSource;
            this.comboBox3.DisplayMember = "Movie_FName";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(97, 434);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(163, 21);
            this.comboBox3.TabIndex = 5;
            this.comboBox3.ValueMember = "Movie_ID";
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataMember = "Movie";
            this.movieBindingSource.DataSource = this.dataSet1;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(946, 259);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(128, 36);
            this.button12.TabIndex = 4;
            this.button12.Text = "Search";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(946, 189);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(128, 36);
            this.button11.TabIndex = 3;
            this.button11.Text = "Update";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(946, 111);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(128, 36);
            this.button10.TabIndex = 2;
            this.button10.Text = "Delete";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(946, 42);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(128, 36);
            this.button9.TabIndex = 1;
            this.button9.Text = "Insert";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movieIDDataGridViewTextBoxColumn,
            this.movieFNameDataGridViewTextBoxColumn,
            this.movieTypeDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.movieBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(0, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(862, 373);
            this.dataGridView3.TabIndex = 0;
            // 
            // movieIDDataGridViewTextBoxColumn
            // 
            this.movieIDDataGridViewTextBoxColumn.DataPropertyName = "Movie_ID";
            this.movieIDDataGridViewTextBoxColumn.HeaderText = "Movie_ID";
            this.movieIDDataGridViewTextBoxColumn.Name = "movieIDDataGridViewTextBoxColumn";
            this.movieIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // movieFNameDataGridViewTextBoxColumn
            // 
            this.movieFNameDataGridViewTextBoxColumn.DataPropertyName = "Movie_FName";
            this.movieFNameDataGridViewTextBoxColumn.HeaderText = "Movie_FName";
            this.movieFNameDataGridViewTextBoxColumn.Name = "movieFNameDataGridViewTextBoxColumn";
            // 
            // movieTypeDataGridViewTextBoxColumn
            // 
            this.movieTypeDataGridViewTextBoxColumn.DataPropertyName = "Movie_Type";
            this.movieTypeDataGridViewTextBoxColumn.HeaderText = "Movie_Type";
            this.movieTypeDataGridViewTextBoxColumn.Name = "movieTypeDataGridViewTextBoxColumn";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button13);
            this.tabPage4.Controls.Add(this.comboBox6);
            this.tabPage4.Controls.Add(this.comboBox5);
            this.tabPage4.Controls.Add(this.comboBox4);
            this.tabPage4.Controls.Add(this.button14);
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1145, 512);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "MovieActor";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // comboBox6
            // 
            this.comboBox6.DataSource = this.movieActorBindingSource;
            this.comboBox6.DisplayMember = "Enroll_ID";
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(944, 286);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(157, 21);
            this.comboBox6.TabIndex = 7;
            this.comboBox6.ValueMember = "Enroll_ID";
            // 
            // movieActorBindingSource
            // 
            this.movieActorBindingSource.DataMember = "MovieActor";
            this.movieActorBindingSource.DataSource = this.dataSet1;
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.actorBindingSource;
            this.comboBox5.DisplayMember = "Actor_FName";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(944, 89);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(157, 21);
            this.comboBox5.TabIndex = 6;
            this.comboBox5.ValueMember = "Actor_ID";
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.movieBindingSource;
            this.comboBox4.DisplayMember = "Movie_FName";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(944, 62);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(157, 21);
            this.comboBox4.TabIndex = 5;
            this.comboBox4.ValueMember = "Movie_ID";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(956, 313);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(132, 38);
            this.button14.TabIndex = 2;
            this.button14.Text = "Cancel Enroll";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movieIDDataGridViewTextBoxColumn1,
            this.actorIDDataGridViewTextBoxColumn1,
            this.enrollIDDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.movieActorBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(6, 6);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(887, 371);
            this.dataGridView4.TabIndex = 0;
            // 
            // movieIDDataGridViewTextBoxColumn1
            // 
            this.movieIDDataGridViewTextBoxColumn1.DataPropertyName = "Movie_ID";
            this.movieIDDataGridViewTextBoxColumn1.HeaderText = "Movie_ID";
            this.movieIDDataGridViewTextBoxColumn1.Name = "movieIDDataGridViewTextBoxColumn1";
            // 
            // actorIDDataGridViewTextBoxColumn1
            // 
            this.actorIDDataGridViewTextBoxColumn1.DataPropertyName = "Actor_ID";
            this.actorIDDataGridViewTextBoxColumn1.HeaderText = "Actor_ID";
            this.actorIDDataGridViewTextBoxColumn1.Name = "actorIDDataGridViewTextBoxColumn1";
            // 
            // enrollIDDataGridViewTextBoxColumn
            // 
            this.enrollIDDataGridViewTextBoxColumn.DataPropertyName = "Enroll_ID";
            this.enrollIDDataGridViewTextBoxColumn.HeaderText = "Enroll_ID";
            this.enrollIDDataGridViewTextBoxColumn.Name = "enrollIDDataGridViewTextBoxColumn";
            this.enrollIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.comboBox9);
            this.tabPage5.Controls.Add(this.comboBox8);
            this.tabPage5.Controls.Add(this.comboBox7);
            this.tabPage5.Controls.Add(this.button18);
            this.tabPage5.Controls.Add(this.dataGridView5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1145, 512);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "MovieDirector";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // comboBox9
            // 
            this.comboBox9.DataSource = this.movieDirectorBindingSource;
            this.comboBox9.DisplayMember = "Enroll_ID";
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(623, 456);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(158, 21);
            this.comboBox9.TabIndex = 7;
            this.comboBox9.ValueMember = "Enroll_ID";
            // 
            // movieDirectorBindingSource
            // 
            this.movieDirectorBindingSource.DataMember = "MovieDirector";
            this.movieDirectorBindingSource.DataSource = this.dataSet1;
            // 
            // comboBox8
            // 
            this.comboBox8.DataSource = this.movieDirectorBindingSource;
            this.comboBox8.DisplayMember = "Director_ID";
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(382, 456);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(158, 21);
            this.comboBox8.TabIndex = 6;
            this.comboBox8.ValueMember = "Director_ID";
            // 
            // comboBox7
            // 
            this.comboBox7.DataSource = this.movieDirectorBindingSource;
            this.comboBox7.DisplayMember = "Movie_ID";
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(108, 456);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(158, 21);
            this.comboBox7.TabIndex = 5;
            this.comboBox7.ValueMember = "Movie_ID";
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movieIDDataGridViewTextBoxColumn2,
            this.directorIDDataGridViewTextBoxColumn1,
            this.enrollIDDataGridViewTextBoxColumn1});
            this.dataGridView5.DataSource = this.movieDirectorBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(6, 3);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(883, 424);
            this.dataGridView5.TabIndex = 0;
            // 
            // movieIDDataGridViewTextBoxColumn2
            // 
            this.movieIDDataGridViewTextBoxColumn2.DataPropertyName = "Movie_ID";
            this.movieIDDataGridViewTextBoxColumn2.HeaderText = "Movie_ID";
            this.movieIDDataGridViewTextBoxColumn2.Name = "movieIDDataGridViewTextBoxColumn2";
            // 
            // directorIDDataGridViewTextBoxColumn1
            // 
            this.directorIDDataGridViewTextBoxColumn1.DataPropertyName = "Director_ID";
            this.directorIDDataGridViewTextBoxColumn1.HeaderText = "Director_ID";
            this.directorIDDataGridViewTextBoxColumn1.Name = "directorIDDataGridViewTextBoxColumn1";
            // 
            // enrollIDDataGridViewTextBoxColumn1
            // 
            this.enrollIDDataGridViewTextBoxColumn1.DataPropertyName = "Enroll_ID";
            this.enrollIDDataGridViewTextBoxColumn1.HeaderText = "Enroll_ID";
            this.enrollIDDataGridViewTextBoxColumn1.Name = "enrollIDDataGridViewTextBoxColumn1";
            this.enrollIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // actorTableAdapter
            // 
            this.actorTableAdapter.ClearBeforeFill = true;
            // 
            // directorTableAdapter
            // 
            this.directorTableAdapter.ClearBeforeFill = true;
            // 
            // movieTableAdapter
            // 
            this.movieTableAdapter.ClearBeforeFill = true;
            // 
            // movieActorTableAdapter
            // 
            this.movieActorTableAdapter.ClearBeforeFill = true;
            // 
            // movieDirectorTableAdapter
            // 
            this.movieDirectorTableAdapter.ClearBeforeFill = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(953, 145);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(133, 36);
            this.button18.TabIndex = 2;
            this.button18.Text = "Delete";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(956, 116);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(132, 38);
            this.button13.TabIndex = 8;
            this.button13.Text = "Enroll";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 666);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.movieActorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.movieDirectorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource actorBindingSource;
        private DataSet1TableAdapters.ActorTableAdapter actorTableAdapter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn actorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actorFNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actorLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource directorBindingSource;
        private DataSet1TableAdapters.DirectorTableAdapter directorTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn directorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directorFNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directorLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private DataSet1TableAdapters.MovieTableAdapter movieTableAdapter;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieFNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource movieActorBindingSource;
        private DataSet1TableAdapters.MovieActorTableAdapter movieActorTableAdapter;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn actorIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrollIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.BindingSource movieDirectorBindingSource;
        private DataSet1TableAdapters.MovieDirectorTableAdapter movieDirectorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn directorIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrollIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button18;
    }
}

