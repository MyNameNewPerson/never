using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ABClient.APIForms;

public class ForpostBuildings : Form
{
	private string[] string_0;

	private IContainer icontainer_0;

	private Button button1;

	private Label label1;

	private Button button2;

	private Label label2;

	private Button button3;

	private Label label3;

	private Button button4;

	private Label label4;

	private Label label5;

	private Button button5;

	private Label label0;

	private Button button0;

	private GroupBox groupBox1;

	private Label resLabel0;

	private PictureBox resPicture0;

	private Label resLabel13;

	private PictureBox resPicture13;

	private Label resLabel12;

	private PictureBox resPicture12;

	private Label resLabel11;

	private PictureBox resPicture11;

	private Label resLabel10;

	private PictureBox resPicture10;

	private Label resLabel9;

	private PictureBox resPicture9;

	private Label resLabel8;

	private PictureBox resPicture8;

	private Label resLabel7;

	private PictureBox resPicture7;

	private Label resLabel6;

	private PictureBox resPicture6;

	private Label resLabel5;

	private PictureBox resPicture5;

	private Label resLabel4;

	private PictureBox resPicture4;

	private Label resLabel3;

	private PictureBox resPicture3;

	private Label resLabel2;

	private PictureBox resPicture2;

	private Label resLabel1;

	private PictureBox resPicture1;

	private Label totalLabel;

	public ForpostBuildings()
	{
		InitializeComponent();
		string_0 = Class21.smethod_4().Split('\n');
		for (int i = 0; i < 6; i++)
		{
			if (string_0[i].Split(',').Length == 3)
			{
				base.Controls["button" + i].Enabled = true;
				base.Controls["label" + i].ForeColor = Color.Brown;
			}
		}
	}

	private void method_0(string string_1)
	{
		string[] array = string_1.Split(',')[2].Split('@');
		float num = 0f;
		float num2 = 0f;
		for (int i = 0; i < 14; i++)
		{
			Class67 @class = new Class67(array[i]);
			Control.ControlCollection controls = groupBox1.Controls;
			(controls["resPicture" + i] as PictureBox).ImageLocation = @class.string_3;
			Control control = controls["resLabel" + i];
			control.Text = $"{@class.string_2}{Environment.NewLine}{@class.string_0}/{@class.string_1}{Environment.NewLine}{@class.float_0}/{@class.float_1} NV";
			control.ForeColor = (@class.bool_0 ? Color.Green : Color.Brown);
			num += @class.float_0;
			num2 += @class.float_1;
		}
		totalLabel.Text = $"{num}/{num2} NV";
	}

	private void button0_Click(object sender, EventArgs e)
	{
		method_0(string_0[0]);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		method_0(string_0[1]);
	}

	private void button2_Click(object sender, EventArgs e)
	{
		method_0(string_0[2]);
	}

	private void button3_Click(object sender, EventArgs e)
	{
		method_0(string_0[3]);
	}

	private void button4_Click(object sender, EventArgs e)
	{
		method_0(string_0[4]);
	}

	private void button5_Click(object sender, EventArgs e)
	{
		method_0(string_0[5]);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABClient.APIForms.ForpostBuildings));
		this.button1 = new System.Windows.Forms.Button();
		this.label1 = new System.Windows.Forms.Label();
		this.button2 = new System.Windows.Forms.Button();
		this.label2 = new System.Windows.Forms.Label();
		this.button3 = new System.Windows.Forms.Button();
		this.label3 = new System.Windows.Forms.Label();
		this.button4 = new System.Windows.Forms.Button();
		this.label4 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.button5 = new System.Windows.Forms.Button();
		this.label0 = new System.Windows.Forms.Label();
		this.button0 = new System.Windows.Forms.Button();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.resLabel13 = new System.Windows.Forms.Label();
		this.resPicture13 = new System.Windows.Forms.PictureBox();
		this.resLabel12 = new System.Windows.Forms.Label();
		this.resPicture12 = new System.Windows.Forms.PictureBox();
		this.resLabel11 = new System.Windows.Forms.Label();
		this.resPicture11 = new System.Windows.Forms.PictureBox();
		this.resLabel10 = new System.Windows.Forms.Label();
		this.resPicture10 = new System.Windows.Forms.PictureBox();
		this.resLabel9 = new System.Windows.Forms.Label();
		this.resPicture9 = new System.Windows.Forms.PictureBox();
		this.resLabel8 = new System.Windows.Forms.Label();
		this.resPicture8 = new System.Windows.Forms.PictureBox();
		this.resLabel7 = new System.Windows.Forms.Label();
		this.resPicture7 = new System.Windows.Forms.PictureBox();
		this.resLabel6 = new System.Windows.Forms.Label();
		this.resPicture6 = new System.Windows.Forms.PictureBox();
		this.resLabel5 = new System.Windows.Forms.Label();
		this.resPicture5 = new System.Windows.Forms.PictureBox();
		this.resLabel4 = new System.Windows.Forms.Label();
		this.resPicture4 = new System.Windows.Forms.PictureBox();
		this.resLabel3 = new System.Windows.Forms.Label();
		this.resPicture3 = new System.Windows.Forms.PictureBox();
		this.resLabel2 = new System.Windows.Forms.Label();
		this.resPicture2 = new System.Windows.Forms.PictureBox();
		this.resLabel1 = new System.Windows.Forms.Label();
		this.resPicture1 = new System.Windows.Forms.PictureBox();
		this.resLabel0 = new System.Windows.Forms.Label();
		this.resPicture0 = new System.Windows.Forms.PictureBox();
		this.totalLabel = new System.Windows.Forms.Label();
		this.groupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.resPicture13).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.resPicture12).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.resPicture11).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.resPicture10).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.resPicture9).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.resPicture8).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.resPicture7).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.resPicture6).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.resPicture5).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.resPicture4).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.resPicture3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.resPicture2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.resPicture1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.resPicture0).BeginInit();
		base.SuspendLayout();
		this.button1.Enabled = false;
		this.button1.Location = new System.Drawing.Point(164, 36);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(140, 23);
		this.button1.TabIndex = 1;
		this.button1.Text = "Ресурсы";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.label1.ForeColor = System.Drawing.Color.Green;
		this.label1.Location = new System.Drawing.Point(160, 9);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(144, 23);
		this.label1.TabIndex = 0;
		this.label1.Text = "Мастерская";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.button2.Enabled = false;
		this.button2.Location = new System.Drawing.Point(310, 36);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(200, 23);
		this.button2.TabIndex = 1;
		this.button2.Text = "Ресурсы";
		this.button2.UseVisualStyleBackColor = true;
		this.button2.Click += new System.EventHandler(button2_Click);
		this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.label2.ForeColor = System.Drawing.Color.Green;
		this.label2.Location = new System.Drawing.Point(306, 9);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(204, 23);
		this.label2.TabIndex = 0;
		this.label2.Text = "Станция дирижаблей";
		this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.button3.Enabled = false;
		this.button3.Location = new System.Drawing.Point(516, 36);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(140, 23);
		this.button3.TabIndex = 1;
		this.button3.Text = "Ресурсы";
		this.button3.UseVisualStyleBackColor = true;
		this.button3.Click += new System.EventHandler(button3_Click);
		this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.label3.ForeColor = System.Drawing.Color.Green;
		this.label3.Location = new System.Drawing.Point(512, 9);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(144, 23);
		this.label3.TabIndex = 0;
		this.label3.Text = "Почта";
		this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.button4.Enabled = false;
		this.button4.Location = new System.Drawing.Point(662, 36);
		this.button4.Name = "button4";
		this.button4.Size = new System.Drawing.Size(140, 23);
		this.button4.TabIndex = 1;
		this.button4.Text = "Ресурсы";
		this.button4.UseVisualStyleBackColor = true;
		this.button4.Click += new System.EventHandler(button4_Click);
		this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.label4.ForeColor = System.Drawing.Color.Green;
		this.label4.Location = new System.Drawing.Point(658, 9);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(144, 23);
		this.label4.TabIndex = 0;
		this.label4.Text = "Рынок";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.label5.ForeColor = System.Drawing.Color.Green;
		this.label5.Location = new System.Drawing.Point(804, 9);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(144, 23);
		this.label5.TabIndex = 0;
		this.label5.Text = "Банк";
		this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.button5.Enabled = false;
		this.button5.Location = new System.Drawing.Point(808, 36);
		this.button5.Name = "button5";
		this.button5.Size = new System.Drawing.Size(140, 23);
		this.button5.TabIndex = 1;
		this.button5.Text = "Ресурсы";
		this.button5.UseVisualStyleBackColor = true;
		this.button5.Click += new System.EventHandler(button5_Click);
		this.label0.Font = new System.Drawing.Font("Times New Roman", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.label0.ForeColor = System.Drawing.Color.Green;
		this.label0.Location = new System.Drawing.Point(14, 9);
		this.label0.Name = "label0";
		this.label0.Size = new System.Drawing.Size(144, 23);
		this.label0.TabIndex = 0;
		this.label0.Text = "Таверна";
		this.label0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.button0.Enabled = false;
		this.button0.Location = new System.Drawing.Point(18, 36);
		this.button0.Name = "button0";
		this.button0.Size = new System.Drawing.Size(140, 23);
		this.button0.TabIndex = 1;
		this.button0.Text = "Ресурсы";
		this.button0.UseVisualStyleBackColor = true;
		this.button0.Click += new System.EventHandler(button0_Click);
		this.groupBox1.Controls.Add(this.resLabel13);
		this.groupBox1.Controls.Add(this.resPicture13);
		this.groupBox1.Controls.Add(this.resLabel12);
		this.groupBox1.Controls.Add(this.resPicture12);
		this.groupBox1.Controls.Add(this.resLabel11);
		this.groupBox1.Controls.Add(this.resPicture11);
		this.groupBox1.Controls.Add(this.resLabel10);
		this.groupBox1.Controls.Add(this.resPicture10);
		this.groupBox1.Controls.Add(this.resLabel9);
		this.groupBox1.Controls.Add(this.resPicture9);
		this.groupBox1.Controls.Add(this.resLabel8);
		this.groupBox1.Controls.Add(this.resPicture8);
		this.groupBox1.Controls.Add(this.resLabel7);
		this.groupBox1.Controls.Add(this.resPicture7);
		this.groupBox1.Controls.Add(this.resLabel6);
		this.groupBox1.Controls.Add(this.resPicture6);
		this.groupBox1.Controls.Add(this.resLabel5);
		this.groupBox1.Controls.Add(this.resPicture5);
		this.groupBox1.Controls.Add(this.resLabel4);
		this.groupBox1.Controls.Add(this.resPicture4);
		this.groupBox1.Controls.Add(this.resLabel3);
		this.groupBox1.Controls.Add(this.resPicture3);
		this.groupBox1.Controls.Add(this.resLabel2);
		this.groupBox1.Controls.Add(this.resPicture2);
		this.groupBox1.Controls.Add(this.resLabel1);
		this.groupBox1.Controls.Add(this.resPicture1);
		this.groupBox1.Controls.Add(this.resLabel0);
		this.groupBox1.Controls.Add(this.resPicture0);
		this.groupBox1.Location = new System.Drawing.Point(12, 65);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(960, 350);
		this.groupBox1.TabIndex = 2;
		this.groupBox1.TabStop = false;
		this.resLabel13.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		this.resLabel13.Location = new System.Drawing.Point(822, 255);
		this.resLabel13.Name = "resLabel13";
		this.resLabel13.Size = new System.Drawing.Size(130, 70);
		this.resLabel13.TabIndex = 27;
		this.resLabel13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.resPicture13.Location = new System.Drawing.Point(859, 192);
		this.resPicture13.Name = "resPicture13";
		this.resPicture13.Size = new System.Drawing.Size(60, 60);
		this.resPicture13.TabIndex = 26;
		this.resPicture13.TabStop = false;
		this.resLabel12.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		this.resLabel12.Location = new System.Drawing.Point(686, 255);
		this.resLabel12.Name = "resLabel12";
		this.resLabel12.Size = new System.Drawing.Size(130, 70);
		this.resLabel12.TabIndex = 25;
		this.resLabel12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.resPicture12.Location = new System.Drawing.Point(723, 192);
		this.resPicture12.Name = "resPicture12";
		this.resPicture12.Size = new System.Drawing.Size(60, 60);
		this.resPicture12.TabIndex = 24;
		this.resPicture12.TabStop = false;
		this.resLabel11.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		this.resLabel11.Location = new System.Drawing.Point(550, 255);
		this.resLabel11.Name = "resLabel11";
		this.resLabel11.Size = new System.Drawing.Size(130, 70);
		this.resLabel11.TabIndex = 23;
		this.resLabel11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.resPicture11.Location = new System.Drawing.Point(587, 192);
		this.resPicture11.Name = "resPicture11";
		this.resPicture11.Size = new System.Drawing.Size(60, 60);
		this.resPicture11.TabIndex = 22;
		this.resPicture11.TabStop = false;
		this.resLabel10.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		this.resLabel10.Location = new System.Drawing.Point(414, 255);
		this.resLabel10.Name = "resLabel10";
		this.resLabel10.Size = new System.Drawing.Size(130, 70);
		this.resLabel10.TabIndex = 21;
		this.resLabel10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.resPicture10.Location = new System.Drawing.Point(451, 192);
		this.resPicture10.Name = "resPicture10";
		this.resPicture10.Size = new System.Drawing.Size(60, 60);
		this.resPicture10.TabIndex = 20;
		this.resPicture10.TabStop = false;
		this.resLabel9.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		this.resLabel9.Location = new System.Drawing.Point(278, 255);
		this.resLabel9.Name = "resLabel9";
		this.resLabel9.Size = new System.Drawing.Size(130, 70);
		this.resLabel9.TabIndex = 19;
		this.resLabel9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.resPicture9.Location = new System.Drawing.Point(315, 192);
		this.resPicture9.Name = "resPicture9";
		this.resPicture9.Size = new System.Drawing.Size(60, 60);
		this.resPicture9.TabIndex = 18;
		this.resPicture9.TabStop = false;
		this.resLabel8.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		this.resLabel8.Location = new System.Drawing.Point(142, 255);
		this.resLabel8.Name = "resLabel8";
		this.resLabel8.Size = new System.Drawing.Size(130, 70);
		this.resLabel8.TabIndex = 17;
		this.resLabel8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.resPicture8.Location = new System.Drawing.Point(179, 192);
		this.resPicture8.Name = "resPicture8";
		this.resPicture8.Size = new System.Drawing.Size(60, 60);
		this.resPicture8.TabIndex = 16;
		this.resPicture8.TabStop = false;
		this.resLabel7.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		this.resLabel7.Location = new System.Drawing.Point(6, 255);
		this.resLabel7.Name = "resLabel7";
		this.resLabel7.Size = new System.Drawing.Size(130, 70);
		this.resLabel7.TabIndex = 15;
		this.resLabel7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.resPicture7.Location = new System.Drawing.Point(43, 192);
		this.resPicture7.Name = "resPicture7";
		this.resPicture7.Size = new System.Drawing.Size(60, 60);
		this.resPicture7.TabIndex = 14;
		this.resPicture7.TabStop = false;
		this.resLabel6.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		this.resLabel6.Location = new System.Drawing.Point(822, 82);
		this.resLabel6.Name = "resLabel6";
		this.resLabel6.Size = new System.Drawing.Size(130, 70);
		this.resLabel6.TabIndex = 13;
		this.resLabel6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.resPicture6.Location = new System.Drawing.Point(859, 19);
		this.resPicture6.Name = "resPicture6";
		this.resPicture6.Size = new System.Drawing.Size(60, 60);
		this.resPicture6.TabIndex = 12;
		this.resPicture6.TabStop = false;
		this.resLabel5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		this.resLabel5.Location = new System.Drawing.Point(686, 82);
		this.resLabel5.Name = "resLabel5";
		this.resLabel5.Size = new System.Drawing.Size(130, 70);
		this.resLabel5.TabIndex = 11;
		this.resLabel5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.resPicture5.Location = new System.Drawing.Point(723, 19);
		this.resPicture5.Name = "resPicture5";
		this.resPicture5.Size = new System.Drawing.Size(60, 60);
		this.resPicture5.TabIndex = 10;
		this.resPicture5.TabStop = false;
		this.resLabel4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		this.resLabel4.Location = new System.Drawing.Point(550, 82);
		this.resLabel4.Name = "resLabel4";
		this.resLabel4.Size = new System.Drawing.Size(130, 70);
		this.resLabel4.TabIndex = 9;
		this.resLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.resPicture4.Location = new System.Drawing.Point(587, 19);
		this.resPicture4.Name = "resPicture4";
		this.resPicture4.Size = new System.Drawing.Size(60, 60);
		this.resPicture4.TabIndex = 8;
		this.resPicture4.TabStop = false;
		this.resLabel3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		this.resLabel3.Location = new System.Drawing.Point(414, 82);
		this.resLabel3.Name = "resLabel3";
		this.resLabel3.Size = new System.Drawing.Size(130, 70);
		this.resLabel3.TabIndex = 7;
		this.resLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.resPicture3.Location = new System.Drawing.Point(451, 19);
		this.resPicture3.Name = "resPicture3";
		this.resPicture3.Size = new System.Drawing.Size(60, 60);
		this.resPicture3.TabIndex = 6;
		this.resPicture3.TabStop = false;
		this.resLabel2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		this.resLabel2.Location = new System.Drawing.Point(278, 82);
		this.resLabel2.Name = "resLabel2";
		this.resLabel2.Size = new System.Drawing.Size(130, 70);
		this.resLabel2.TabIndex = 5;
		this.resLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.resPicture2.Location = new System.Drawing.Point(315, 19);
		this.resPicture2.Name = "resPicture2";
		this.resPicture2.Size = new System.Drawing.Size(60, 60);
		this.resPicture2.TabIndex = 4;
		this.resPicture2.TabStop = false;
		this.resLabel1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		this.resLabel1.Location = new System.Drawing.Point(142, 82);
		this.resLabel1.Name = "resLabel1";
		this.resLabel1.Size = new System.Drawing.Size(130, 70);
		this.resLabel1.TabIndex = 3;
		this.resLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.resPicture1.Location = new System.Drawing.Point(179, 19);
		this.resPicture1.Name = "resPicture1";
		this.resPicture1.Size = new System.Drawing.Size(60, 60);
		this.resPicture1.TabIndex = 2;
		this.resPicture1.TabStop = false;
		this.resLabel0.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		this.resLabel0.Location = new System.Drawing.Point(6, 82);
		this.resLabel0.Name = "resLabel0";
		this.resLabel0.Size = new System.Drawing.Size(130, 70);
		this.resLabel0.TabIndex = 1;
		this.resLabel0.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.resPicture0.Location = new System.Drawing.Point(43, 19);
		this.resPicture0.Name = "resPicture0";
		this.resPicture0.Size = new System.Drawing.Size(60, 60);
		this.resPicture0.TabIndex = 0;
		this.resPicture0.TabStop = false;
		this.totalLabel.Font = new System.Drawing.Font("Times New Roman", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.totalLabel.ForeColor = System.Drawing.Color.Green;
		this.totalLabel.Location = new System.Drawing.Point(12, 418);
		this.totalLabel.Name = "totalLabel";
		this.totalLabel.Size = new System.Drawing.Size(960, 42);
		this.totalLabel.TabIndex = 28;
		this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(984, 461);
		base.Controls.Add(this.totalLabel);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.button5);
		base.Controls.Add(this.button4);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.button3);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.button2);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.button1);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.button0);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.label0);
		this.DoubleBuffered = true;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		this.MaximumSize = new System.Drawing.Size(1000, 500);
		base.MinimizeBox = false;
		this.MinimumSize = new System.Drawing.Size(1000, 500);
		base.Name = "ForpostBuildings";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Разрушенные здания Форпоста";
		this.groupBox1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.resPicture13).EndInit();
		((System.ComponentModel.ISupportInitialize)this.resPicture12).EndInit();
		((System.ComponentModel.ISupportInitialize)this.resPicture11).EndInit();
		((System.ComponentModel.ISupportInitialize)this.resPicture10).EndInit();
		((System.ComponentModel.ISupportInitialize)this.resPicture9).EndInit();
		((System.ComponentModel.ISupportInitialize)this.resPicture8).EndInit();
		((System.ComponentModel.ISupportInitialize)this.resPicture7).EndInit();
		((System.ComponentModel.ISupportInitialize)this.resPicture6).EndInit();
		((System.ComponentModel.ISupportInitialize)this.resPicture5).EndInit();
		((System.ComponentModel.ISupportInitialize)this.resPicture4).EndInit();
		((System.ComponentModel.ISupportInitialize)this.resPicture3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.resPicture2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.resPicture1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.resPicture0).EndInit();
		base.ResumeLayout(false);
	}
}
